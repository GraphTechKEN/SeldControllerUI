using Microsoft.Win32;
using SELDController.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

//32bit Only

namespace SELDController
{
    public partial class Form1 : Form
    {// スレッド間処理のために用意
        private delegate void Delegate_write(string data);

        //openFileDialog初期ディレクトリをマイドキュメントに設定
        //string currentDir = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        //設定ファイル
        private string xmlpath;

        //出力設定
        private OutputInfo outputInfo = new OutputInfo();

        List<ParamData> paramList = new List<ParamData>();

        private Button[] btnSpdButtons = new Button[16];
        private TextBox[] tbSpdTextBox = new TextBox[16];

        private static string fileNameInstall = "SeldEx.dll";
        private static string fileNameRemove = "SerialOutputEx.dll";
        private static string destDirBveExPlugins = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\BveEx\";
        private static string dllBveExPathInstall = destDirBveExPlugins + @"2.0\Extensions\" + fileNameInstall;
        private static string dllAtsExPathInstall = destDirBveExPlugins + @"Legacy\Extensions\" + fileNameInstall;
        private static readonly string dllBveExPathRemove = destDirBveExPlugins + @"2.0\Extensions\" + fileNameRemove;
        private static readonly string dllAtsExPathRemove = destDirBveExPlugins + @"Legacy\Extensions\" + fileNameRemove;

        string hexFilePath = @""; // 書き込むHEXファイルのパス

        // アプリBのメインクラス内
        private System.Timers.Timer monitorTimer;
        private bool isBveRunning = false;

        //基板のバージョン管理用
        private int C_VERSION_MINOR, C_VERSION_MAJOR, C_VERSION_BUILD, C_VERSION_PATCH;
        private char C_TYPE;
        private String C_VERSION_NUM;
        private String C_VERSION;
        private int C_VERSION_SUM;
        private int D_VERSION_MINOR, D_VERSION_MAJOR, D_VERSION_BUILD, D_VERSION_PATCH;
        private char D_TYPE;
        private String D_VERSION;
        private int D_VERSION_SUM;
        private int P_VERSION_MINOR, P_VERSION_MAJOR, P_VERSION_BUILD, P_VERSION_PATCH;
        private char P_TYPE;
        private String P_VERSION;
        private int P_VERSION_SUM;

        public Form1()
        {
            InitializeComponent();
            serialPortMain.NewLine = "\r\n"; // 改行コードをCRLFに指定
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 16; i++)
            {
                string suffix = string.Format("{0:000}", (i + 1) * 10); // "010", "020" ...

                // コントロール名から動的に検索して配列に格納
                btnSpdButtons[i] = this.Controls.Find($"btn{suffix}", true).FirstOrDefault() as Button;
                tbSpdTextBox[i] = this.Controls.Find($"tb{suffix}", true).FirstOrDefault() as TextBox;
            }

            Settings.Default.Reload();
            btnSerialPortOpen.Enabled = setSerialComboBox(cbPortSelect, Settings.Default.portName);

            if (!Settings.Default.first_boot)
            {
                for (int i = 0; i < 16; i++)
                {
                    tbSpdTextBox[i].Text = (string)Settings.Default["spd_" + string.Format("{0:000}", (i + 1) * 10)];
                    //取得したデータをセットする（仮のデータを設定）
                    paramList.Add(new ParamData(num: string.Format("{0:000}", ((i * 2) + 12)), name: ((i + 1) * 10).ToString() + "km/h", data: tbSpdTextBox[i].Text));

                }

                tbLimit.Text = Settings.Default.spd_limit;
                paramList.Add(new ParamData(num: "044", name: "最高速度(km/h)", data: tbLimit.Text));

                maxSpeed = Settings.Default.maxSpeed;//044
                tbOhm.Text = Settings.Default.vehicle_res;//列車抵抗 

                tbAdjN.Text = Settings.Default.adj_N;//000
                tbAdjEB.Text = Settings.Default.adj_EB;//002
                tbBrkNum.Text = Settings.Default.brk_num;//004
                tbBrkNumTop.Text = Settings.Default.brk_num;//004
                tbSapAngl.Text = Settings.Default.brk_angl;//006
                tbEBAngl.Text = Settings.Default.brk_eb_angl;//008
                tbBrkFullAngl.Text = Settings.Default.brk_full_angl;//010
                tbBrkSapMaxAngl.Text = Settings.Default.brk_sap_max_angl;//058
                tbBrkSapMinAngl.Text = Settings.Default.brk_sap_min_angl;//060
                tbChatFilter.Text = Settings.Default.chat_filter;//062
                tbBpSpanDown.Text = Settings.Default.bp_span_down;//064
                tbBpSpanUp.Text = Settings.Default.bp_span_up;//066
                                                              //ブレーキ段数読出し, ブレーキ角度読出し,ブレーキ非常位置読出し,ブレーキ幅範囲,常用最大角度,チャタリングフィルタ
                string[] strBrks2 = { "OK 000", "OK 002", "OK 004", "OK 006", "OK 008", "OK 010", "OK 058", "OK 056", "OK 054", "OK 060", "OK 062", "OK 064", "OK 066" };
                TextBox[] txtBoxes2 = { tbAdjN, tbAdjEB, tbBrkNum, tbSapAngl, tbEBAngl, tbBrkFullAngl, tbBrkSapMinAngl, tbBrkSapMaxAngl, tbChatFilter, tbKeep, tbKeepFull, tbBpSpanDown, tbBpSpanUp };
                string[] paramNames = { "N位置", "EB位置", "ブレーキ段数", "直通帯幅[°]", "非常位置[°]", "ブレーキ全体角度[°]", "直通帯最小角度[°]", "常用最大角度[°]", "チャタリングフィルタ", "自動帯開始角度[°]", "自動帯全開角度[°]", "BP減圧間隔", "BP増圧間隔" };

                for (int i = 0; i < strBrks2.Length; i++)
                {
                    // "OK "を除いた番号を取得
                    string paramNum = strBrks2[i].Substring(3);
                    paramList.Add(new ParamData(num: paramNum, name: paramNames[i], data: txtBoxes2[i].Text));
                }
                // DataGridView をリフレッシュ
                RefreshDataGridView();

                int n = Settings.Default.autoair_use;
                cbAutoairUse.Checked = ((n & 1) == 1);
                cbAutoAirEX.Checked = ((n >> 2 & 1) == 1);
                cbAirMeterDebug.Checked = ((n >> 3 & 1) == 1);
                cbTS185.Checked = ((n >> 4 & 1) == 1);

                tbMcNumMax.Text = Settings.Default.mc_num_max;
                tbMcNumMaxTop.Text = Settings.Default.mc_num_max;
                tbMcNum.Text = Settings.Default.mc_num;
                tbMcNumTop.Text = Settings.Default.mc_num;


                rbCurrent.Checked = !Settings.Default.mtr_current;
                rbVolt.Checked = Settings.Default.mtr_current;
                cbKaisei.Checked = Settings.Default.mtr_kaisei;

                n = Settings.Default.input_flip;
                cbAtsCont.Checked = ((n & 1) == 1);
                //cbAtsConf.Checked = ((n >> 1 & 1) == 1);
                cbAtsRec.Checked = ((n >> 2 & 1) == 1);
                cbEB.Checked = ((n >> 3 & 1) == 1);
                cbHorn1.Checked = ((n >> 4 & 1) == 1);
                cbHorn2.Checked = ((n >> 5 & 1) == 1);
                cbDecEB.Checked = ((n >> 6 & 1) == 1);
                cbMeterCheck.Checked = ((n >> 7 & 1) == 0);

                n = Settings.Default.atsconf_flip;
                cbAtsConf.Checked = ((n & 1) == 1);
                cbxPanto.SelectedIndex = (n >> 1 & 1);
                cbxB1Dengen.SelectedIndex = (n >> 3 & 1);
                cbxATSDengen.SelectedIndex = (n >> 4 & 1);
                cbTransferEBState.Checked = ((n >> 5 & 1)==1);
                cbBVEForceMode.Checked = ((n >> 6 & 1) == 1);
                btnATSDengenAngle.Enabled = (cbxATSDengen.SelectedIndex == 1);
                tbATSDengenAngle.Enabled = (cbxATSDengen.SelectedIndex == 1);

                cbxAutoNotch.SelectedIndex = Settings.Default.autonotch_use;

                cbRealAutoAir.Checked = Settings.Default.realAutoAir;

                tbFVMin.Text = Settings.Default.FVMin;
                tbFVMax.Text = Settings.Default.FVMax;
                tbBPMin.Text = Settings.Default.BPMin;
                tbBPMax.Text = Settings.Default.BPMax;
                tbAveRatio.Text = Settings.Default.AveRatio;
                tbBCMin.Text = Settings.Default.BCMin;
                tbMonInterval.Text = Settings.Default.MonInterval;
                tbBCMax.Text = Settings.Default.BCMax;
                tbBCMaxNorm.Text = Settings.Default.BCMaxNorm;

                tbBCMulti.Text = Settings.Default.BCMulti;
                tbBCMultiNorm.Text = Settings.Default.BCMultiNorm;

                Double.TryParse(Settings.Default.EBInterval, out double value);
                tbEBInterval.Text = value.ToString("0.0##");

                tbEBThreshold.Text = Settings.Default.EBThreshold;


                tbFVPressMax.Text = Settings.Default.FVPressMax;
                tbFVPressMin.Text = Settings.Default.FVPressMin;
                tbBPPressMax.Text = Settings.Default.BPPressMax;
                tbBPPressMin.Text = Settings.Default.BPPressMin;

                Int32.TryParse(Settings.Default.FVPressMax, out int value1);
                Int32.TryParse(Settings.Default.FVPressMin, out int value2);
                Int32.TryParse(Settings.Default.BPPressMax, out int value3);
                Int32.TryParse(Settings.Default.BPPressMin, out int value4);

                tbarFV.Maximum = value1;
                tbarFV.Minimum = value2;
                tbarBP.Maximum = value3;
                tbarBP.Minimum = value4;

                tbLogRows.Text = Settings.Default.maxLogLines;

                cbAtsDengenMode.Checked = Settings.Default.AtsDengenMode;
                rbPEast.Checked = Settings.Default.AtsPEast;
                rbPWest.Checked = !Settings.Default.AtsPEast;
                cbAtsPDengenAuto.Checked = Settings.Default.AtsPDengenAuto;
                cbAtsContactUse.Checked = Settings.Default.AtsContactUse;
                tbAtsSDengenTounyuTime.Text = ((double)Settings.Default.AtsDengenTounyuTime / 1000).ToString("0.0##");
                tbAtsPDengenTounyuTime.Text = ((double)Settings.Default.AtsPDengenTounyuTime / 1000).ToString("0.0##");

                tabControl2.SelectedIndex = Convert.ToInt16(Settings.Default.Evalve);

                tbBCMaxE.Text = Settings.Default.BCMaxE;
                tbBCMultiE.Text = Settings.Default.BCMultiE;
                tbAveRatioE.Text = Settings.Default.AveRatioE;

                tsmiDispBoard.Checked = Settings.Default.board_Disp;
                tsmiATSPBoard.Checked = Settings.Default.board_ATSP;
                board_Disp = Settings.Default.board_Disp;
                board_ATSP = Settings.Default.board_ATSP;

                pnlDisp.Enabled = board_Disp;
                pnlPress.Enabled = board_Disp;
                pnlATSP.Enabled = board_ATSP;
                cbModeMON.Enabled = board_Disp;

                cbUnitDisp.Checked = Settings.Default.cbUnitDisp;
                tbUnitNum.Text = Settings.Default.tbUnitNum;

                tbRegOffDelay.Text = Settings.Default.RegOffDelay;

                rbATS.Checked = Settings.Default.rbATS == 0;
                rbATS2.Checked = Settings.Default.rbATS == 3;
                rbATS3.Checked = Settings.Default.rbATS == 1;

                rbDC.Checked = Settings.Default.Section_Mode == 1;
                rbAC.Checked = Settings.Default.Section_Mode == 2;
                rbSection.Checked = Settings.Default.Section_Mode == 0;

                cbFVhold.Checked = Settings.Default.cbFVhold;
                cbFVhold_CheckedChanged(null, null);

                tbATSDengenAngle.Text = Settings.Default.brk_ats_dengen_angl;
                cbAtsActiveMode.Checked = Settings.Default.AtsActiveMode == 1;
            }

            pnlAutoair.Enabled = cbAutoairUse.Checked;

            Decimal.TryParse(tbLimit.Text, out decimal max_spd);
            Disp_Controls(max_spd);

            Int32.TryParse(tbLimit.Text, out int limit);
            tbarSpdTest.Maximum = limit;
            lblTbarMax.Text = limit.ToString();

            FileVersionInfo ver = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text += " V" + ver.FileVersion.ToString();

            ReadSimPress();

            FirmWareFinder("SELDController", "SELDController.ino.hex",cbVersionListCHex, tbHexFilePathC);
            FirmWareFinder("SELDController", "SELDController.ino.bin", cbVersionListCBin, tbBinFilePathC);

            InitialCheck();
            StartMonitoring();

            bool foundAvrdude = File.Exists(avrdudePath);
            gpbControllerBoard.Enabled = foundAvrdude;
            gpbDispBoard.Enabled = foundAvrdude;
            gpbATSP.Enabled = foundAvrdude;
        }
        // クラスのメンバー変数（既存の hexFilePath などの近くに配置）
        private List<string> searchedFiles = new List<string>();
        private List<string> FirmWareFinder(string folderName, string fileName, ComboBox cb,TextBox tb)
        {
            searchedFiles.Clear(); // 前回の検索結果をクリア
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", folderName);

            // 【変更】元のファイルと .bak ファイルの両方を検索できるようにワイルドカードを指定
            string searchPattern = fileName + "*";

            cb.Items.Clear();

            if (Directory.Exists(directoryPath))
            {
                // 1. まず条件に合うすべてのファイル（通常とbak両方）のパスを取得
                string[] rawFiles = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);

                if (rawFiles.Length > 0)
                {
                    // 2. バージョン順でソート（通常ファイルを優先するため、パスの文字数や名前の辞書順で並び替えます）
                    var sortedFiles = rawFiles.OrderBy(f => f).ToList();

                    // メンバー変数に確定した順序で記憶
                    searchedFiles.AddRange(sortedFiles);

                    var versionRegex = new Regex(@"\\(\d+(?:\.\d+)+)\\");

                    // 3. 記憶したファイルリストの順序と「1対1」になるようにコンボボックスへ追加
                    foreach (string file in searchedFiles)
                    {
                        Match match = versionRegex.Match(file);
                        if (match.Success)
                        {
                            string versionText = match.Groups[1].Value;

                            // 【変更】ファイル名の末尾に .bak が含まれていたら (backup) を追記
                            if (file.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                            {
                                versionText += " (backup)";
                            }

                            // コンボボックスへ追加
                            cb.Items.Add(versionText);
                        }
                        else
                        {
                            // 万が一バージョンが正規表現にマッチしないファイルがあっても、
                            // インデックスのズレを防ぐためにダミーを追加（エラー防止）
                            cb.Items.Add("Unknown Version");
                        }
                    }

                    if (cb.Items.Count > 0)
                    {
                        cb.SelectedIndex = 0;
                    }
                }
            }

            return searchedFiles;
        }


        /****************************************************************************/
        /*!
         * シリアルポートを選択するComboBoxを作ります。
         * 接続されているポートの名前を取得し、表示します。
         */
        private bool setSerialComboBox(ComboBox comboBox, string savedPortName)
        {
            bool matchSelect = false;

            comboBox.Items.Clear();

            string[] ports = GetDeviceNames();

            if (ports != null && ports.Length > 0)
            {

                foreach (var _portName in ports)
                {
                    try
                    {
                        comboBox.Items.Add(_portName);
                    }
                    catch
                    {
                        toolStripStatusLabel1.Text = "Error:setSerialComboBox()";
                    }
                }
                if (comboBox.Items.Count > 0)
                {
                    Regex regexPortName = new Regex(@"(COM\d+)");

                    bool match = false;

                    for (int i = 0; i < comboBox.Items.Count; i++)
                    {
                        string tmpPortName = regexPortName.Match(comboBox.Items[i].ToString()).Groups[1].ToString();
                        match = (savedPortName == tmpPortName);
                        if (match)
                        {
                            savedPortName = comboBox.Items[i].ToString();
                            break;
                        }
                    }
                    if (match)
                    {
                        comboBox.Text = savedPortName;
                    }
                    else
                    {
                        comboBox.SelectedIndex = 0;
                    }
                    matchSelect = true;
                }
            }
            return matchSelect;
        }

        //シリアルポート名称一覧を取得
        public string[] GetDeviceNames()
        {
            var deviceNameList = new System.Collections.ArrayList();
            Regex regexPortName = new Regex(@"(COM\d+)");

            ManagementClass mcPnPEntity = new ManagementClass("Win32_PnPEntity");
            ManagementObjectCollection manageObjCol = mcPnPEntity.GetInstances();

            //全てのPnPデバイスを探索しシリアル通信が行われるデバイスを随時追加する
            foreach (ManagementObject manageObj in manageObjCol)
            {
                var namePropertyValue = manageObj["Name"];//Nameプロパティを取得
                if (namePropertyValue != null)
                {
                    string classGuid = manageObj["ClassGuid"] as string; // GUID
                    string devicePass = manageObj["DeviceID"] as string; // デバイスインスタンスパス
                    //Nameプロパティ文字列の一部が"(COM1)～(COM999)"と一致するときリストに追加"
                    string name = namePropertyValue.ToString();
                    if (regexPortName.IsMatch(name) && classGuid != null && devicePass != null)
                    {

                        // デバイスインスタンスパスからシリアル通信接続機器のみを抽出
                        // {4d36e978-e325-11ce-bfc1-08002be10318}はシリアル通信接続機器を示す固定値
                        if (String.Equals(classGuid, "{4d36e978-e325-11ce-bfc1-08002be10318}",
                                StringComparison.InvariantCulture))
                        {

                            // デバイスインスタンスパスからデバイスIDを2段階で抜き出す
                            string[] tokens = devicePass.Split('&');

                            //Bluetoothデバイスかその他(USB等)デバイスかを判別
                            //Bluetoothデバイスのとき
                            if (tokens.Length > 4)
                            {
                                string[] addressToken = tokens[4].Split('_');
                                string[] deviceType = tokens[0].Split('\\');
                                string bluetoothAddress = addressToken[0];
                                if (deviceType[0] == "BTHENUM")
                                {
                                    Match m = regexPortName.Match(name);

                                    string comPortNumber = "";
                                    if (m.Success)
                                    {
                                        // COM番号を抜き出す
                                        comPortNumber = m.Groups[1].ToString();
                                    }

                                    if (Convert.ToUInt64(bluetoothAddress, 16) > 0)
                                    {
                                        string bluetoothName = GetBluetoothRegistryName(bluetoothAddress);
                                        deviceNameList.Add(bluetoothName + " (BT) (" + comPortNumber + ")");
                                    }
                                }
                                //それ以外のとき
                                else
                                {
                                    deviceNameList.Add(name);
                                }
                            }
                            //それ以外のとき
                            else
                            {
                                deviceNameList.Add(name);
                            }
                        }
                    }
                }
            }

            //戻り値作成
            if (deviceNameList.Count > 0)
            {
                string[] deviceNames = new string[deviceNameList.Count];
                int index = 0;
                foreach (var name in deviceNameList)
                {
                    deviceNames[index++] = name.ToString();
                }
                return deviceNames;
            }
            else
            {
                return null;
            }
        }

        private string GetBluetoothRegistryName(string address)
        {
            string deviceName = "";
            // 以下のレジストリパスはどのPCでも共通
            string registryPath = @"SYSTEM\CurrentControlSet\Services\BTHPORT\Parameters\Devices";
            string devicePath = String.Format(@"{0}\{1}", registryPath, address);

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(devicePath))
            {
                if (key != null)
                {
                    Object o = key.GetValue("Name");

                    byte[] raw = o as byte[];

                    if (raw != null)
                    {
                        // ASCII変換
                        deviceName = Encoding.ASCII.GetString(raw);
                    }
                }
            }
            // NULL文字をトリミングしてリターン
            return deviceName.TrimEnd('\0');
        }

        /****************************************************************************/
        /*!
         * openButtonが押されると実行されます。
         * 接続の分岐をします。
         */
        private void openButton_Click(object sender, EventArgs e)
        {
            if (btnSerialPortOpen.Text == "通信開始")
            {                
                send_error = false;
                serialPort1Open();
                CommandWrite("MON 0");
                CommandWrite("RD 100");//制御基板状態確認
                CommandWrite("RD 090");//制御基板バージョン確認
                CommandWrite("RD 190");//表示灯基板バージョン確認
                timerDispBoardFinder.Start();
                CommandWrite("RD 240");//ATS-P基板バージョン確認
                timerATSPBoardFinder.Start();
                tabControl1.Focus();
                Disp();

                if (Settings.Default.first_boot)
                {
                    MessageBox.Show("初回接続です。\r\r[全設定値読出し]ボタンを押してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSetReadAll.BackColor = Color.Salmon;
                    Settings.Default.first_boot = false;
                }
                tbPluginDirectory.Text = destDirBveExPlugins;
                bool installed = File.Exists(dllBveExPathInstall) && File.Exists(dllAtsExPathInstall);
                btnPluginInstall.Text = installed ? "更新" : "インストール";
                btnPluginUnInstall.Enabled = installed;
                cbXmlCopy.Checked = !File.Exists(destDirBveExPlugins + @"\2.0\Extensions\SeldEx.xml");
                if (File.Exists(dllAtsExPathRemove) || File.Exists(dllBveExPathRemove))
                {
                    cbSOUninstall.Visible = true;
                }
                else
                {
                    cbSOUninstall.Visible = false;
                }
                if (File.Exists(FirmWareFinder("SELDController", "SELDController.ino.hex", cbVersionListCHex, tbHexFilePathC) + ".bak"))
                {
                    btnFirmBackup.Text = "ファームバックアップ済";
                    btnFirmBackup.Enabled = false;
                }
                if (File.Exists(FirmWareFinder("SELDController", "SELDController.ino.hex", cbVersionListCHex, tbHexFilePathC) + ".bin"))
                {
                    btnEepromWrite.Enabled = true;
                }


            }
            else
            {
                serialPort1Close();
            }
        }

        /****************************************************************************/
        /*!
         * 接続を開始します。
         */
        private void serialPort1Open()
        {
            if (cbPortSelect.Items.Count > 0)
            {
                try
                {
                    Regex regexPortName = new Regex(@"(COM\d+)");
                    string portName = regexPortName.Match(cbPortSelect.SelectedItem.ToString()).Groups[1].ToString();
                    serialPortMain.PortName = portName;
                    serialPortMain.BaudRate = 115200;
                    serialPortMain.DtrEnable = true;
                    serialPortMain.Open();
                    cbPortSelect.Enabled = false;
                    tabControl1.Enabled = true;
                    toolStripStatusLabel1.Text = "SerialPort1:Open " + serialPortMain.PortName;
                    btnSerialPortOpen.Enabled = true;
                    btnSerialPortOpen.Text = "通信停止";
                    btnLoadParamXml.Enabled = true;
                }
                catch (Exception e)
                {
                    toolStripStatusLabel1.Text = "Error:" + e.ToString();
                    if (serialPortMain.IsOpen)
                    {
                        serialPortMain.Close();
                    }
                }
            }
        }

        /****************************************************************************/
        /*!
         * 接続を終了します。
         */
        private string strPortName = "";
        private void serialPort1Close()
        {
            //serialPort2Close();
            if (!isBveRunning)
            {
                flgFirstReadCheck = false;
                tsslError.Text = "";
                tsslError.BackColor = SystemColors.Control;
                btnSetReadAll.Enabled = false;
                btnSetSaveAll.Enabled = false;
                cbModeMON.Checked = false;
                cbModeN.Checked = false;
                cbPotMode.Checked = false;
                Settings.Default.portName = cbPortSelect.SelectedText;
                timer1.Stop();
                if (serialPortMain.IsOpen)
                {
                    Settings.Default.portName = serialPortMain.PortName;
                    serialPortMain.DiscardInBuffer();
                    serialPortMain.DiscardOutBuffer();
                    serialPortMain.Close();
                }
                cbPortSelect.Enabled = true;
                tabControl1.Enabled = false;
                toolStripStatusLabel1.Text = "Close:" + serialPortMain.PortName;
                btnSerialPortOpen.Enabled = setSerialComboBox(cbPortSelect, Settings.Default.portName);
                strPortName = serialPortMain.PortName;
                btnLoadParamXml.Enabled = false;
                btnSaveParamXml.Enabled = false;

                //SeldEx.xmlポート書き込み
                xmlpath = @".\BveEx\2.0\Extensions\SeldEx.xml";
                if (File.Exists(xmlpath))
                {

                    //XmlSerializerオブジェクトを作成
                    //オブジェクトの型を指定する
                    XmlSerializer serializer = new XmlSerializer(typeof(OutputInfo));
                    //読み込むファイルを開く
                    StreamReader sr = new StreamReader(xmlpath, new UTF8Encoding(false));
                    //XMLファイルから読み込み、逆シリアル化する
                    OutputInfo obj = (OutputInfo)serializer.Deserialize(sr);
                    sr.Close();


                    Regex regexPortName = new Regex(@"(COM\d+)");
                    string portName = regexPortName.Match(strPortName).Groups[1].ToString();

                    int.TryParse(portName.Substring(3), out int iPortNum);
                    obj.PortNum = iPortNum;

                    //XmlSerializerオブジェクトを作成
                    //オブジェクトの型を指定する
                    //書き込むファイルを開く（UTF-8 BOM無し）
                    StreamWriter sw = new StreamWriter(xmlpath, false, new UTF8Encoding(false));
                    //シリアル化し、XMLファイルに保存する
                    serializer.Serialize(sw, obj);
                    sw.Close();
                }
                if (cbModeN.Checked || cbPotMode.Checked)//模型モードまたはPOTモード時はマイコンをリセット
                {
                    cbPotMode.Checked = false;
                    cbModeN.Checked = false;
                    btnSerialPortOpen.BackColor = Color.Yellow;
                    btnSerialPortOpen.Text = "再起動中";
                    serialPortMain.BaudRate = 1200;
                    serialPortMain.Open();
                    Thread.Sleep(100);
                    serialPortMain.Close();
                    timer2.Start();
                    startDt = DateTime.Now;
                    btnSerialPortOpen.Enabled = false;
                    cbPortSelect.Enabled = false;
                    Thread.Sleep(500);
                }
                else
                {
                    btnSerialPortOpen.Text = "通信開始";
                    btnSerialPortOpen.Enabled = true;
                    cbPortSelect.Enabled = true;
                }
            }
            else
            {
                if (serialPortMain.IsOpen)
                {
                    Settings.Default.portName = serialPortMain.PortName;
                    serialPortMain.DiscardInBuffer();
                    serialPortMain.DiscardOutBuffer();
                    serialPortMain.Close();
                }
                tabControl1.Enabled = true;
                cbPortSelect.Enabled = false;
                btnSerialPortOpen.Text = "BVE連動中"; // UI上の表示変更
                btnSerialPortOpen.Enabled = false;
            }
        }
        /****************************************************************************/
        /*!
         * writeButtonが押されると実行されます。
         * serialPort1に送信します。
         */
        private void writeButton_Click(object sender, EventArgs e)
        {
            CommandWrite(messageTextBox1.Text);
        }

        /****************************************************************************/
        /*!
         * serialPort1でデータを受信すると実行されます。
         * スレッドが異なるので、Invokeを使う。
         * BeginInvokeでやったほうがいいらしい
         * http://kana-soft.com/tech/sample_0007_4.htm
         */
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            timer1.Stop();
            // 受信したデータ
            string data = serialPortMain.ReadExisting(); ;
            // 異なるスレッドのテキストボックスに書き込む

            BeginInvoke(new Delegate_write(write), new Object[] { data });
        }

        /****************************************************************************/
        /*!
         * logTextBoxに受信内容を書き込みます。
         */

        //デリミタ(終端文字列)がない場合の文字列格納用
        private string data_temp_next;
        private void write(string data)
        {
            if (data != null)
            {


                //文字列処理用の一時仮格納用
                string data_temp = data;
                //ログ出力用
                string data_disp = "";
                //デリミタ(終端文字列)がある場合
                if (data.Length >= 2)
                {
                    if (data.Substring(data.Length - 2) == "\r\n")
                    {

                        //MessageBox.Show("match");
                        //一時仮格納用文字列とデリミタなし文字列を一時結合
                        data_temp = data_temp_next + data_temp;
                        string data_analys = data_temp;
                        while (data_temp != null)
                        {
                            //\rで文字列を切断
                            if (data_temp.IndexOf("\r") > 0)
                            {
                                int i = data_temp.IndexOf("\r");
                                data_disp = data_temp.Substring(0, i).Trim();
                                data_temp = data_temp.Substring(i).Trim();
                                // --- ここからUIの更新（安全にInvokeで行う） ---
                                tbSerialRcv.Invoke(new Action(() =>
                                {
                                    tbSerialRcv.Text = data_disp;
                                    tbSerialRcv.Update(); // 確実にその場で描画を更新させる
                                }));

                                if (data_disp.Length > 5)
                                {
                                    if (!data_disp.StartsWith("OK POT") && data_disp.StartsWith("Pot"))
                                    {
                                        if (flgAdjN)
                                        {
                                            flgAdjN = false;
                                            int.TryParse(data_disp.Substring(7, 4), out int iAdjN);
                                            if (MessageBox.Show("このポテンショ値(" + iAdjN.ToString() + ")を角度0°に設定します", "N位置設定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                            {
                                                tbAdjN.Text = iAdjN.ToString();
                                                AdjN();
                                                Thread.Sleep(50);
                                            }
                                            CommandWrite("MD POT 0", true);
                                        }
                                        if (flgAdjEB)
                                        {
                                            flgAdjEB = false;
                                            int.TryParse(data_disp.Substring(7, 4), out int iAdjEB);
                                            if (MessageBox.Show("このポテンショ値(" + iAdjEB.ToString() + ")を角度165°に設定します", "EB位置設定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                            {
                                                tbAdjEB.Text = iAdjEB.ToString();
                                                AdjEB();
                                                Thread.Sleep(50);
                                            }
                                            CommandWrite("MD POT 0", true);
                                        }
                                    }
                                }

                                //ログ出力チェックボックスがチェックされている場合
                                if (checkBox1.Checked)
                                {
                                    tbLog.AppendText("Read : " + data_disp + "\r\n");
                                }

                                read_Settings(data_analys, data_disp);
                            }
                            //文字列切断後、最後の文字列の処理
                            else
                            {

                                if (data_temp != "")
                                {
                                    data_disp = data_temp.Trim();
                                    // --- ここからUIの更新（安全にInvokeで行う） ---
                                    tbSerialRcv.Invoke(new Action(() =>
                                    {
                                        tbSerialRcv.Text = data_disp;
                                        tbSerialRcv.Update(); // 確実にその場で描画を更新させる
                                        if (checkBox1.Checked)
                                        {
                                            tbLog.AppendText("Read : " + data_disp + "\r\n");
                                            tbLog.Update(); // 確実にその場で描画を更新させる
                                        }
                                    }));

                                    read_Settings(data_analys, data_disp);
                                }
                                data_temp = null;
                            }


                            //仮格納用文字列をnull(空)にする
                            data_temp_next = null;
                        }
                    }
                    //デリミタ(終端文字列)がない場合
                    else
                    {

                        //MessageBox.Show("not match:"+data );
                        //仮格納用文字列に文字列を一時保管する
                        data_temp_next += data;

                    }
                }
                //デリミタ(終端文字列)がない場合
                else
                {

                    //MessageBox.Show("not match");
                    //仮格納用文字列に文字列を一時保管する
                    data_temp_next += data;

                }


                if (cbModeN.Checked && data.Length < 7)
                {
                    lblBrkNotch.Text = data;
                }
                /*StringReader rs = new System.IO.StringReader(data);
                tbSerialRcv.Text = rs.ReadLine();*/
                int positionTimeStart = data.IndexOf("Time:");
                int positionTimeEnd = data.IndexOf("sec");
                int positionTimeLength = positionTimeEnd - positionTimeStart;
                if (positionTimeStart > 0)
                {
                    //txtBoxLevel.Text = data.Substring(positionTimeStart + 5, positionTimeLength - 5);
                }

            }
        }

        private int Control_Input(string inputText, Control control)
        {
            int.TryParse(inputText.Substring(7), out int d);
            if (d != 65535)
            {
                control.Text = d.ToString();
            }
            return d;

        }

        private void read_Settings(string data_all_, string data_)
        {


            if (data_.IndexOf("OK ") == 0)
            {
                int.TryParse(data_.Substring(3, 3), out int addr);
                if ((addr >= 0 && addr <= 10) || (addr >= 54 && addr <= 66))
                {
                    //ブレーキ段数読出し, ブレーキ角度読出し,ブレーキ非常位置読出し,ブレーキ幅範囲,常用最大角度,チャタリングフィルタ
                    string[] strBrks2 = { "OK 000","OK 002","OK 004", "OK 006", "OK 008", "OK 010", "OK 058", "OK 056", "OK 054", "OK 060", "OK 062", "OK 064", "OK 066" };
                    TextBox[] txtBoxes2 = { tbAdjN, tbAdjEB,tbBrkNum, tbSapAngl, tbEBAngl, tbBrkFullAngl, tbBrkSapMinAngl, tbBrkSapMaxAngl, tbChatFilter, tbKeep, tbKeepFull, tbBpSpanDown, tbBpSpanUp };
                    string[] paramNames = { "N位置","EB位置","ブレーキ段数", "直通帯幅[°]", "非常位置[°]", "ブレーキ全体角度[°]", "直通帯最小角度[°]", "常用最大角度[°]", "チャタリングフィルタ", "自動帯開始角度[°]", "自動帯全開角度[°]", "BP減圧間隔", "BP増圧間隔" };

                    for (int i = 0; i < strBrks2.Length; i++)
                    {
                        if (data_.IndexOf(strBrks2[i]) == 0)
                        {
                            int.TryParse(data_.Substring(strBrks2[i].Length), out int d);
                            Control_Input(data_, txtBoxes2[i]);

                            // "OK "を除いた番号を取得
                            string paramNum = strBrks2[i].Substring(3);

                            UpdateParamList(paramNum, paramNames[i], d.ToString());
                        }
                    }
                }

                //速度設定値
                else  if (addr >= 12 && addr <= 42)
                {
                    int.TryParse(data_.Substring(7), out int d);
                    int index = (addr - 12) / 2;
                    Control_Input(data_, tbSpdTextBox[index]);
                    // paramList にも同じ値を反映させる
                    if (index < paramList.Count)
                    {
                        paramList[index].Data = d.ToString();
                    }
                }
            }

            if (data_all_.IndexOf("OK ") == 0)
            {
                string Name = "";
                //デバイスアドレスを取得
                int.TryParse(data_all_.Substring(3,3), out int addr);
                //デバイス値を取得
                int.TryParse(data_all_.Substring(7), out int val);

                switch (addr)
                {
                    case 44://最高速度
                        Name = "最高速度[km/h]";
                        Control_Input(data_all_, tbLimit);
                        flgRead = false;
                        Limit_Setting();
                        break;


                    case 46://回生モード
                        Name = "回生モード";
                        cbKaisei.Checked = (val == 1);
                        break;

                    case 48://計器モード
                        Name = "計器モード";
                        rbCurrent.Checked = (val == 0);
                        rbVolt.Checked = (val == 1);
                        break;

                    case 52://列車抵抗
                        Name = "列車抵抗[Ω]";
                        Control_Input(data_all_, tbOhm);
                        break;


                    case 68://自動帯使用可否
                        Name = "自動帯設定";
                        cbAutoairUse.Checked = ((val & 1) == 1);//自動帯使用
                        // = ((d >> 1 & 1) == 1);//実際のエアーを使用
                        cbAutoAirEX.Checked = ((val >> 2 & 1) == 1);//BveEXを使用
                        break;

                    case 70: //マスコン段数(コントローラー)
                        Name = "マスコン段数(コントローラー)";
                        Control_Input(data_all_, tbMcNumMax);
                        tbMcNumMaxTop.Text = tbMcNumMax.Text;
                        break;

                    case 72://マスコン段数(BVE車両側)
                        Name = "マスコン段数(BVE車両側)";
                        Control_Input(data_all_, tbMcNum);
                        tbMcNumTop.Text = tbMcNum.Text;
                        break;

                    case 74://警報持続反転
                        Name = "入力設定1(旧警報持続反転)";
                        cbAtsCont.Checked = ((val & 1) == 1);
                        //cbAtsConf.Checked = ((d >> 1 & 1) == 1);
                        cbAtsRec.Checked = ((val >> 2 & 1) == 1);
                        cbEB.Checked = ((val >> 3 & 1) == 1);
                        cbHorn1.Checked = ((val >> 4 & 1) == 1);
                        cbHorn2.Checked = ((val >> 5 & 1) == 1);
                        cbDecEB.Checked = ((val >> 6 & 1) == 1);
                        cbMeterCheck.Checked = ((val >> 7 & 1) == 0);
                        break;

                    case 76://ATS確認ボタン反転
                        Name = "入力設定2(旧ATS確認ボタン反転)";
                        cbAtsConf.Checked = ((val & 1) == 1);
                        cbxPanto.SelectedIndex = (val >> 1 & 1);
                        cbxB1Dengen.SelectedIndex = (val >> 3 & 1);
                        cbxATSDengen.SelectedIndex = (val >> 4 & 1);
                        cbTransferEBState.Checked = ((val >> 5 & 1) == 1);
                        cbBVEForceMode.Checked = ((val >> 6 & 1) == 1);
                        break;

                    case 78://自動ノッチ合わせ
                        Name = "自動ノッチ合わせ";
                        cbxAutoNotch.SelectedIndex = val;////ここ確認！
                        cbBVEForceMode.Checked = ((val >> 6 & 1) == 1);
                        break;

                    case 80://実際のエアー圧で自動帯再現
                        Name = "実際のエアー圧で自動帯再現";
                        cbRealAutoAir.Checked = (val == 1);
                        break;

                    case 82://ATS接点を使用して他基板へ転送する
                        Name = "ATS接点を使用して他基板へ転送";
                        cbAtsContactUse.Checked = (val == 1);
                        break;

                    case 84://ATS電源角度
                        Name = "ATS電源角度[°]";
                        Control_Input(data_all_, tbATSDengenAngle);
                        break;

                    case 90://基板種類
                        Name = "基板種類(制御基板)";
                        val &= 0xFF;
                        C_TYPE = (char)val;
                        //UpdateParamList(addr.ToString("D3"), "基板種類", C_TYPE.ToString());
                        if (C_TYPE == 'C' || val == 0xFF)
                        {
                            CommandWrite("RD 092");
                        }
                        else
                        {
                            MessageBox.Show("接続先が制御基板ではないかもしれません。接続先またはバージョンを確認してください。");
                        }
                        break;

                    case 92:
                        Name = "Major << 8 | Minor(制御基板)";
                        String s = data_all_.Substring(7).Trim();
                        int.TryParse(s, out int d);
                        C_VERSION_MINOR = val >> 8;
                        C_VERSION_MAJOR = val & 0xFF;
                        CommandWrite("RD 094");
                        //Control_Input(data_all_, tbATSDengen);
                        //UpdateParamList(addr.ToString("D3"), "Major,Minor", C_VERSION_MAJOR.ToString() + "." + C_VERSION_MINOR.ToString() + ".");
                        break;

                    case 94:
                        Name = "Patch << 8 | Build(制御基板)";
                        C_VERSION_BUILD = val >> 8;
                        C_VERSION_PATCH = val & 0xFF;
                        if (C_TYPE == 0xFF)
                        {
                            C_VERSION = "未接続";
                        }
                        else
                        {
                            C_VERSION_NUM = C_VERSION_MAJOR.ToString() + "." + C_VERSION_MINOR.ToString() + "." + C_VERSION_PATCH.ToString() + "." + C_VERSION_BUILD.ToString();
                            C_VERSION = C_TYPE.ToString() + " " + C_VERSION_NUM;
                            C_VERSION_SUM = C_VERSION_MAJOR << 24 | C_VERSION_MINOR << 16 | C_VERSION_PATCH << 8 | C_VERSION_BUILD;
                        }
                        tbControlBoardVersion.Text = C_VERSION;
                        break;

                    case 100://制御基板チェック
                        Name = "制御基板チェック";
                        flgSeldControllerFound = true;
                        flgFirstReadCheck = true;
                        break;

                    case 102:
                        Name = "FV Min";
                        Control_Input(data_all_, tbFVMin);
                        break;

                    case 104:
                        Name = "FV Max";
                        Control_Input(data_all_, tbFVMax);
                        break;

                    case 106:
                        Name = "BP Min";
                        Control_Input(data_all_, tbBPMin);
                        break;

                    case 108:
                        Name = "BP Max";
                        Control_Input(data_all_, tbBPMax);
                        break;

                    case 110:
                        Name = "BC Min";
                        Control_Input(data_all_, tbBCMin);
                        break;

                    case 112://平均化率
                        Name = "平均化率";
                        Control_Input(data_all_, tbAveRatio);
                        break;

                    case 114:
                        Name = "モニタ間隔[msec]";
                        Control_Input(data_all_, tbMonInterval);
                        break;

                    case 116:
                        Name = "E電磁弁開放時間[msec]";
                        if (val != 65535)
                        {
                            tbEBInterval.Text = (val * 0.001).ToString("0.0##");
                        }
                        break;

                    case 118:
                        Name = "EBしきい値[kPa]";
                        Control_Input(data_all_, tbEBThreshold);
                        break;
                    
                    case 124:
                        Name = "FVPress Min [kPa]";
                        Control_Input(data_all_, tbFVPressMin);
                        break;

                    case 126:
                        Name = "FVPress Max [kPa]";
                        Control_Input(data_all_, tbFVPressMax);
                        break;
                    case 128:
                        Name = "BPPress Min [kPa]";
                        Control_Input(data_all_, tbBPPressMin);
                        break;
                    case 130:
                        Name = "BPPress Max [kPa]";
                        Control_Input(data_all_, tbBPPressMax);
                        break;
                    
                    case 132://BC最大圧力(急動部動作時)
                        Name = "BC最大圧力(急動部動作時)[kPa]";
                        Control_Input(data_all_, tbBCMax);
                        break;
                    
                    case 134://BC最大圧力(常用時)
                        Name = "BC最大圧力(常用時)[kPa]";
                        Control_Input(data_all_, tbBCMaxNorm);
                        break;
                    
                    case 136://BC倍率(急動部動作時)
                        Name = "BC倍率(急動部動作時)[kPa]";
                        if (val != 65535)
                        {
                            tbBCMulti.Text = (val * 0.1).ToString("0.0");
                        }
                        break;
                    
                    case 138://BC倍率(常用時)
                        Name = "BC倍率(常用時)";
                        if (val != 65535)
                        {
                            tbBCMultiNorm.Text = (val * 0.1).ToString("0.0");
                        }
                        break;
                    
                    case 140://ATS-S電源投入時間
                        Name = "ATS-S電源投入時間[msec]";
                        if (val != 65535)
                        {
                            tbAtsSDengenTounyuTime.Text = (val * 0.001).ToString("0.0##");
                        }
                        break;

                    
                    case 142://急動部動作BP減速度しきい値
                        Name = "急動部動作BP減速度しきい値";
                        if (val != 65535)
                        {
                            tbBPvelocityKyudouThreshold.Text = val.ToString();
                        }
                        break;

                    
                    case 144:  //制御弁モード A制御弁(0) E制御弁(1)
                        Name = "制御弁モード A制御弁(0) E制御弁(1)";
                        if (val == 0)
                        {
                            tabControl2.TabIndex = 0;
                        }
                        else
                        {
                            tabControl2.TabIndex = 1;
                        }
                        break;


                    case 146://BC最大圧力(E制御弁)
                        Name = "BC最大圧力(E制御弁)[kPa]";
                        Control_Input(data_all_, tbBCMaxE);
                        break;
                    
                    case 148://BC倍率(E制御弁)
                        Name = "BC倍率(E制御弁)";
                        if (val != 65535)
                        {
                            tbBCMultiE.Text = (val * 0.1).ToString("0.0");
                        }
                        break;

                    
                    case 150://平均化率(E制御弁)
                        Control_Input(data_all_, tbAveRatioE);
                        break;
                   
                    case 152: //E電磁弁遅延時間
                        Name = "E電磁弁遅延時間[msec]";
                        if (val != 65535)
                        {
                            tbEBOndelay.Text = (val * 0.001).ToString("0.0##");
                        }
                        break;

                    
                    case 154://電空レギュレータ電源OFF時間
                        Name = "電空レギュレータ電源OFF時間[msec]";
                        if (val != 65535)
                        {
                            tbRegOffDelay.Text = (val * 0.001).ToString("0.0##");
                        }
                        break;

                    
                    case 156://FVを490kPaに固定　(0:false 1:true)
                        Name = "FVを490kPaに固定";
                        if (val != 65535)
                        {
                            cbFVhold.Checked = (val == 1);
                        }
                        break;

                    case 190://基板種類
                        Name = "基板種類(電制表示灯基板)";
                        timerDispBoardFinder.Stop();
                        val &= 0xFF;
                        D_TYPE = (char)val;
                        if (D_TYPE == 'D' || val == 0xFF)
                        {
                            CommandWrite("RD 192");
                            board_Disp = true;
                            SwitchDispBoard(true);
                        }
                        break;

                    case 192:
                        Name = "Major << 8 | Minor(電制表示灯基板)";
                        D_VERSION_MINOR = val >> 8;
                        D_VERSION_MAJOR = val & 0xFF;
                        CommandWrite("RD 194");
                        break;

                    case 194:
                        Name = "Patch << 8 | Build(電制表示灯基板)";
                        D_VERSION_BUILD = val >> 8;
                        D_VERSION_PATCH = val & 0xFF;
                        if (D_TYPE == 0xFF)
                        {
                            D_VERSION = "未接続";
                        }
                        else
                        {
                            D_VERSION = D_TYPE.ToString() + " " + D_VERSION_MAJOR.ToString() + "." + D_VERSION_MINOR.ToString() + "." + D_VERSION_PATCH.ToString() + "." + D_VERSION_BUILD.ToString();
                            D_VERSION_SUM = C_VERSION_MAJOR << 24 | C_VERSION_MINOR << 16 | C_VERSION_PATCH << 8 | C_VERSION_BUILD;
                        }
                        tbDispBoardVersion.Text = D_VERSION;
                        break;

                    case 200://ATS-P 自動電源表示 自動(1)/強制(0)
                        Name = "ATS-P自動電源表示 自動(1)/ 強制(0)";
                        cbAtsPDengenAuto.Checked = (val != 0);
                        break;
                    
                    case 202://ATS-P East(1)/West(0)
                        Name = "ATS-P East(1)/West(0)";
                        if (val != 65535)
                        {
                            rbPEast.Checked = (val != 0);
                            rbPWest.Checked = (val == 0);
                        }
                        break;

                    case 204:   //ATS未投入防止 1bit:(1)警報器(0)警報装置 2bit:(1)2ノッチ(0)3ノッチ                     {
                        Name = "ATS未投入防止";
                        if (val != 65535)
                        {
                            rbATS.Checked = (val == 0);
                            rbATS2.Checked = (val == 3);
                            rbATS3.Checked = (val == 1);
                        }
                        break;

                    case 206://BZ21強制停止タイマー
                        break;

                    case 208:  //ATS-P(West)表示灯点灯遅延タイマ
                        Name = "ATS-P(West)表示灯点灯遅延タイマ";
                        if (val != 65535)
                        {
                            tbAtsPDengenTounyuTime.Text = (val * 0.001).ToString("0.0##");
                        }
                        break;

                    case 240://基板種類
                        Name = "基板種類(ATS-P)";
                        timerATSPBoardFinder.Stop();
                        val &= 0xFF;
                        P_TYPE = (char)val;
                        if (P_TYPE == 'P' || val == 0xFF)
                        {
                            CommandWrite("RD 242");
                            board_ATSP = true;
                            SwitchATSPBoard(true);

                        }
                        break;

                    case 242:
                        Name = "Major << 8 | Minor(ATS-P)";
                        P_VERSION_MINOR = val >> 8;
                        P_VERSION_MAJOR = val & 0xFF;
                        CommandWrite("RD 244");
                        break;
  
                    case 244:
                        Name = "Patch << 8 | Build(ATS-P)";
                        P_VERSION_BUILD = val >> 8;
                        P_VERSION_PATCH = val & 0xFF;
                        if (P_TYPE == 0xFF)
                        {
                            P_VERSION = "未接続";
                        }
                        else
                        {
                            P_VERSION = P_TYPE.ToString() + " " + P_VERSION_MAJOR.ToString() + "." + P_VERSION_MINOR.ToString() + "." + P_VERSION_PATCH.ToString() + "." + P_VERSION_BUILD.ToString();
                            P_VERSION_SUM = C_VERSION_MAJOR << 24 | C_VERSION_MINOR << 16 | C_VERSION_PATCH << 8 | C_VERSION_BUILD;
                        }
                        tbATSPBoardVersion.Text = P_VERSION;
                        break;


                }
                if(Name != "")
                {
                    UpdateParamList(addr.ToString("D3"), Name, val.ToString());
                }
            }
            
            //FV BP読出し
            else if (data_all_.StartsWith("FV(V)="))
            {
                tbFV_V.Text = data_.Substring(data_.IndexOf("FV(V)=") + 6, 4);
                tbBP_V.Text = data_.Substring(data_.IndexOf("BP(V)=") + 6, 4);
                tbFV.Text = data_.Substring(data_.IndexOf("FV=") + 3, 4);
                Int32.TryParse(tbFV.Text, out int valueFV);
                Int32.TryParse(tbBP.Text, out int valueBP);
                Int32.TryParse(tbFVPressMax.Text, out int valueFVmax);
                Int32.TryParse(tbBPPressMax.Text, out int valueBPmax);

                if (valueFV > valueFVmax) valueFV = valueFVmax;
                if (valueFV < 0) valueFV = 0;
                tbarFV.Value = valueFV;
                if (valueBP > valueBPmax) valueBP = valueBPmax;
                if (valueBP < 0) valueBP = 0;
                tbarBP.Value = valueBP;
                tbBP.Text = data_.Substring(data_.IndexOf("BP=") + 3, 4);
                //tbFVBP.Text = data_.Substring(data_.IndexOf("(FV-BP)=") + 8, 4);
                string temp_BC = data_.Substring(data_.IndexOf("BC=") + 3);
                tbBCPress.Text = temp_BC.Substring(0, temp_BC.IndexOf("kPa"));
                Double.TryParse(tbBCPress.Text, out double valueBC);
                if (valueBC < 0) valueBC = 0;
                tbarBCPress.Value = (int)valueBC;

            }
            RefreshDataGridView();

        }

        private void UpdateParamList(string ParamNum, string ParamName, string Value)
        {
            // paramList 更新
            var existingParam = paramList.FirstOrDefault(p => p.Num == ParamNum);
            if (existingParam != null)
            {
                existingParam.Data = Value;
            }
            else
            {                    // 存在しない場合は新規追加
                paramList.Add(new ParamData(num: ParamNum, name: ParamName, data: Value));
            }
        }

        /****************************************************************************/
        /*!
         * ウィンドウが閉じられる際に実行されます。
         */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("終了してもよろしいですか？", "確認",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
            );
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            //もしポートが開いており調整モードがONだった場合はOFFにする
            if (serialPortMain.IsOpen)
            {
                if (cbPotMode.Checked)
                {
                    cbPotMode.Checked = false;
                }
            }
        }

        /****************************************************************************/
        /*!
         * ウィンドウが閉じられた後に実行されます。
         */
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            //ポートを閉じる
            string portname = serialPortMain.PortName;
            if (serialPortMain.IsOpen)
            {
                serialPort1Close();
            }

            if ((btnSpdRead.BackColor == SystemColors.Control) && btnSpdRead.BackColor == SystemColors.Control)
            {
                Settings.Default.first_boot = false;
            }
            Settings.Default.Save();
        }


        private void messageTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CommandWrite(messageTextBox1.Text);
            }
        }



        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static string str_latch;

        private void CommandWrite(string str, bool need_response = false)
        {
            if ((serialPortMain.IsOpen || isBveRunning) && str_latch != str)
            {
                if (need_response)
                {
                    tsslError.Text = "";
                    tsslError.BackColor = SystemColors.Control;
                    timer1.Start();
                }
                Command_Sender(str);
                Thread.Sleep(50);
                str_latch = str;
            }
        }
        //開始時間の取得
        //private DateTime start = new DateTime();
        private void Command_Sender(string _str)
        {
            //差分を取得
            //TimeSpan ts = DateTime.Now - start;
            if (!send_error)
            {
                try
                {
                    //if (ts.TotalMilliseconds > 20)
                    //{
                    SendData(_str);
                    //start = DateTime.Now;
                    //}
                    btnSetReadAll.Enabled = true;
                    btnSpdRead.Enabled = true;
                    btnSpdSetRead.Enabled = true;
                    btnBrkRead.Enabled = true;
                    btnPressRead.Enabled = true;
                    tbLog.AppendText("Write:" + _str + "\r\n");
                    // UIスレッド以外からのアクセスの場合はInvokeで実行
                    if (tbSerialSend.InvokeRequired)
                    {
                        tbSerialSend.Invoke(new Action(() =>
                        {
                            tbSerialSend.Text = _str;
                            tbSerialSend.Update(); // 確実にその場で描画を更新させる
                        }));
                    }
                    else
                    {
                        tbSerialSend.Text = _str;
                        tbSerialSend.Update(); // UIスレッド上の場合も強制再描画
                    }
                }
                catch (Exception ex)
                {
                    if (!flgFirstReadCheck)
                    {
                        MessageBox.Show(ex.Message + "\r\n基板の接続やポート番号を確認してください。\r\n\r\nまた、スケッチ(ファームウェア)が無いか正しく書き込まれていません。", "確認");
                        btnSetReadAll.Enabled = false;
                        btnSpdRead.Enabled = false;
                        btnBrkRead.Enabled = false;
                        send_error = true;
                        flgFirstReadCheck = true;
                    }
                }
            }
        }

        private void speedBtn_Click(object sender, EventArgs e)
        {
            // 1. 名前から数値部分(010, 070等)を取り出す
            Control ctrl = (Control)sender;
            // 後ろから3文字取る（btn160でもtb160でも対応可能）
            string spd = ctrl.Name.Substring(ctrl.Name.Length - 3);

            if (!int.TryParse(spd, out int d)) return;

            // 2. 以前のロジックにあった最大速度制限を適用
            if (d >= 130 && maxSpeed < d) return;

            // 3. 10〜160の範囲内なら実行
            if (d >= 10 && d <= 160)
            {
                int index = (d / 10) - 1;
                // アドレス計算: 10 + (d / 5) と同義。string.Formatで3桁固定
                string address = string.Format("{0:D3}", (d / 5) + 10);
                string val = tbSpdTextBox[index].Text;

                // コマンド送信 (WR 020 1234\r の形式)
                CommandWrite($"WR {address} {val}", true);

                // 設定保存 (文字列キーでアクセス)
                Settings.Default["spd_" + spd] = val;
            }

            // 4. UI更新
            tbarSpdTest.Value = d;
            tbSpdTest.Text = d.ToString();
        }

        private void btnLimit_Click(object sender, EventArgs e)
        {
            Limit_Setting();
        }

        private decimal maxSpeed;
        private void Limit_Setting()
        {
            Int32.TryParse(tbLimit.Text, out int result);
            if (result < 10 || result > 160)
            {
                MessageBox.Show("最高速度が範囲外です(10～160km/h)");
            }
            else
            {
                maxSpeed = Math.Round((decimal)result / 10) * 10;
                tbLimit.Text = maxSpeed.ToString();
                tbarSpdTest.Maximum = (int)maxSpeed;
                lblTbarMax.Text = tbLimit.Text;
                if (!flgRead)
                {
                    CommandWrite("WR 044 " + tbLimit.Text, true);
                }
                else
                {
                    flgRead = false;
                }
                Settings.Default.spd_limit = tbLimit.Text;
                Settings.Default.maxSpeed = maxSpeed;
                Disp_Controls(maxSpeed);
            }
        }
        private void btnOhm_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbOhm.Text, out int result);
            if (result < 0 || result > 9999)
            {
                MessageBox.Show("抵抗値が範囲外です(0～9999[mΩ])");
            }
            else
            {
                CommandWrite("WR 052 " + tbOhm.Text, true);
                Settings.Default.vehicle_res = tbOhm.Text;
            }
        }

        private void comboBoxPortselect_MouseHover(object sender, EventArgs e)
        {
            btnSerialPortOpen.Enabled = setSerialComboBox(cbPortSelect, Settings.Default.portName);
        }

        private void speedTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                speedBtn_Click(sender, e);
            }
        }

        private void tbLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLimit_Click(sender, e);
            }
        }

        private void tbSpdTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSpdTest_Click(sender, e);
            }
        }

        private void tbCurrentTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCurrentTest_Click(sender, e);
            }
        }
        private void tbOhm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOhm_Click(sender, e);
            }
        }

        private void Disp_Controls(decimal speed_)
        {
            for (int i = 0; i < btnSpdButtons.Length; i++)
            {
                if (i < (speed_ / 10))
                {
                    btnSpdButtons[i].Visible = true;
                    tbSpdTextBox[i].Visible = true;
                }
                else
                {
                    btnSpdButtons[i].Visible = false;
                    tbSpdTextBox[i].Visible = false;
                }
            }
        }

        private void btnSpdTest_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbSpdTest.Text, out int spd);
            if ((spd >= 0) && (spd <= 350))
            {
                Disp();
            }
            else
            {
                MessageBox.Show("速度の範囲外です(0～350km/h)");
            }
        }

        private void btnCurrentTest_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbCurrentTest.Text, out int current);
            if ((current >= -1000) && (current <= 1000))
            {
                Disp();
            }
            else
            {
                MessageBox.Show("速度の範囲外です(-1000～1000A)");
            }
        }

        private void cbDoor_CheckedChanged(object sender, EventArgs e)
        {
            Disp();

            gbBC.Enabled = cbLampHatsuden.Checked;
            tbBC.Enabled = cbLampHatsuden.Checked;

        }
        private void Disp()
        {
            Int32.TryParse(tbSpdTest.Text, out int speed);
            if (speed > maxSpeed)
            {
                speed = (int)maxSpeed;
            }
            tbarSpdTest.Value = speed;
            string speed_ = (speed * 10).ToString("0000");//0～3

            string door_ = !cbDoor.Checked ? "1" : "0";//5

            Int32.TryParse(tbCurrentTest.Text, out int current_);
            string str_curr = (current_ * 10).ToString("+00000;-00000;' '00000");//7～12

            string str_lamp = "";
            str_lamp += cbLampAts.Checked ? "1" : "0";//14
            str_lamp += cbLampAtsAlm.Checked ? "1" : "0";//15
            str_lamp += cbLampEb.Checked && !cbOERMode.Checked ? "1" : "0";//16
            if (cbOERMode.Checked)//17
            {
                str_lamp += "9";
            }
            else
            {
                str_lamp += cbLampSap.Checked ? "1" : "0";
            }
            str_lamp += cbLampHatsuden.Checked ? "1" : "0";//18
            str_lamp += cbLampYokusoku.Checked ? "1" : "0";//19

            Int32.TryParse(tbBC.Text, out int bc);
            string bc_ = (bc * 10).ToString("0000");//21～24
            string oer_brk = (cbPBreak.Checked && cbOERMode.Checked) || (cbLampEb.Checked && !cbOERMode.Checked) ? "1" : "0";//26
            string oer_stop = cbLampOERStop.Checked ? "1" : "0";//27
            string unit3 = (cbUnit3.Checked && !cbOERMode.Checked) || (cbPPettern.Checked && cbOERMode.Checked) ? "1" : "0";//28:43


            string P = (cbPPettern.Checked && !cbOERMode.Checked) ? "1" : "0";//29
            P += cbPFree.Checked ? "1" : "0";//30
            P += (cbPBreak.Checked && !cbOERMode.Checked) || (cbLampEb.Checked && cbOERMode.Checked) ? "1" : "0";//31
            P += (cbPMode.Checked && !cbOERMode.Checked) ? "1" : "0";//32
            P += (cbPBroken.Checked && !cbOERMode.Checked) || (cbLampOERLight.Checked && cbOERMode.Checked) ? "1" : "0";//33

            string bpEvac_ = cbBpEvac.Checked ? "1" : "0"; //36
            string oer_att = cbLampOERAtt.Checked ? "1" : "0";//37
            string oer_kaiseikaihou = cbLampOERKaisei.Checked && cbOERMode.Checked ? "1" : "0";//38

            string unit1;
            if (cbOERMode.Checked)
            {
                unit1 = cbPMode.Checked ? "2" : "0";
            }
            else
            {
                unit1 = cbUnit1.Checked ? "1" : "0";
            }
            string unit2 = cbUnit2.Checked ? "1" : "0";//41:42
            string P_Dengen = cbPDengen.Checked ? "1" : "0";//42

            string notch_MC = "N" + mc_count.ToString("0");
            string notch_Brake = "B" + brake_count.ToString("X2");

            string s_press_MR = "M" + press_MR.ToString("000");
            string s_press_BC = "C" + press_BC.ToString("000");
            string s_press_ER = "E" + press_ER.ToString("000");
            string s_press_SAP = "S" + press_SAP.ToString("000");
            string s_press_BP = "P" + press_BP.ToString("000");

            CommandWrite(speed_ + "/" + door_ + "/" + str_curr + "/" + str_lamp + "/" + bc_ + "0" + oer_brk + oer_stop + unit3 + P + "00" + bpEvac_ + oer_att + oer_kaiseikaihou + "0" + unit1 + unit2 + P_Dengen + "/" + str_rev + notch_MC + notch_Brake + s_press_MR + s_press_BC + s_press_ER + s_press_SAP + s_press_BP);
            //0000/0/00000/100100/1174/00000000000000000/FN0B03M740C117E490S120P490/
        }

        private void ReadSimPress()
        {
            if (tabControl1.SelectedIndex == 2)
            {
                press_MR = tbarSimAirMR.Value;
                press_BC = tbarSimAirBC.Value;
                press_ER = tbarSimAirER.Value;
                press_SAP = tbarSimAirSAP.Value;
                press_BP = tbarSimAirBP.Value;

                tbSimPressMR.Text = press_MR.ToString();
                tbSimPressBC.Text = press_BC.ToString();
                tbSimPressER.Text = press_ER.ToString();
                tbSimPressSAP.Text = press_SAP.ToString();
                tbSimPressBP.Text = press_BP.ToString();
            }
        }

        private void tbarSpdTest_Scroll(object sender, EventArgs e)
        {
            tbSpdTest.Text = tbarSpdTest.Value.ToString();
            ReadSimPress();
            Disp();
        }

        private void tbBrkNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBrkNum_Click(sender, e);
            }
        }

        private void btnBrkNum_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBrkNum.Text, out int num);
            if ((num >= 0) && (num <= 255))
            {
                CommandWrite("WR 004 " + num, true);
                tbBrkNumTop.Text = tbBrkNum.Text;
                Settings.Default.brk_num = tbBrkNum.Text;
            }
            else
            {
                MessageBox.Show("設定段数の範囲外です(0～255段)");
            }
        }

        private void tbSapAngl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSapAngl_Click(sender, e);
            }
        }

        //直通帯
        private void btnSapAngl_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbSapAngl.Text, out int num);
            if ((num >= 0) && (num <= 360))
            {
                CommandWrite("WR 006 " + num, true);
                Settings.Default.brk_angl = tbSapAngl.Text;
            }
            else
            {
                MessageBox.Show("角度設定の範囲外です(0～360°)");
            }
        }

        private void tbEBAngl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEBAngl_Click(sender, e);
            }
        }

        private void btnEBAngl_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbEBAngl.Text, out int num);
            Int32.TryParse(tbBrkFullAngl.Text, out int num2);
            if ((num >= 0) && (num <= num2))
            {
                CommandWrite("WR 008 " + num, true);
                Settings.Default.brk_eb_angl = tbEBAngl.Text;
            }
            else
            {
                MessageBox.Show("ブレーキ幅の範囲内に設定してください(0～" + num2.ToString() + "°)");
            }
        }

        private void tbBrkFullAngl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBrkFullAngl_Click(sender, e);
            }
        }

        private void btnBrkFullAngl_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBrkFullAngl.Text, out int num);
            if ((num >= 0) && (num <= 360))
            {
                CommandWrite("WR 010 " + num, true);
                Settings.Default.brk_full_angl = tbBrkFullAngl.Text;
            }
            else
            {
                MessageBox.Show("角度設定の範囲外です(0～360°)");
            }
        }

        private void cbModeN_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModeN.Checked)
            {
                CommandWrite("MD N   1", true);
                cbPotMode.Checked = false;
            }
            else
            {
                CommandWrite("MD N   0", true);
                lblBrkNotch.Text = "";
            }
        }

        private void tbarCurrentTest_Scroll(object sender, EventArgs e)
        {
            tbCurrentTest.Text = tbarCurrentTest.Value.ToString();
            Disp();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbLog.Clear();
            }
        }

        private void btnBrkRead_Click(object sender, EventArgs e)
        {
            serialPortMain.DiscardInBuffer();
            //CommandWrite("RD BRK", true);
            CommandWrite("RD 000", true);//ポテンショN位置
            CommandWrite("RD 002", true);//ポテンショEB位置
            CommandWrite("RD 004", true);//ブレーキ段数
            CommandWrite("RD 006", true);//直通帯幅
            CommandWrite("RD 008", true);//非常角度位置
            CommandWrite("RD 010", true);//ブレーキ全体角度

            CommandWrite("RD 046", true);//回生モード
            CommandWrite("RD 048", true);//計器モード
            CommandWrite("RD 050", true);//電流値上限
            CommandWrite("RD 052", true);//列車抵抗

            CommandWrite("RD 054", true);//チャタリング防止
            CommandWrite("RD 056", true);//常用最大角度
            CommandWrite("RD 058", true);//直通帯最小角度
            CommandWrite("RD 060", true);//自動帯常用開始角度
            CommandWrite("RD 062", true);//自動帯常用全開角度
            CommandWrite("RD 064", true);//自動帯減圧インターバル
            CommandWrite("RD 066", true);//自動帯増圧インターバル
            CommandWrite("RD 068", true);//自動帯使用
            CommandWrite("RD 070", true);//マスコン段数(コントローラー)
            CommandWrite("RD 072", true);//マスコン段数(BVE車両)
            CommandWrite("RD 074", true);//警報持続B接点
            CommandWrite("RD 076", true);//ATS確認ボタンB接点
            CommandWrite("RD 078", true);//自動ノッチ合わせ
            CommandWrite("RD 080", true);//実際のエアー圧で自動帯再現
            CommandWrite("RD 082", true);//ATS接点を使用して他基板へ転送する
            CommandWrite("RD 084", true);//ATS電源角度
            btnBrkSave.Enabled = true;
        }

        private void btnSpdRead_Click(object sender, EventArgs e)
        {
            btnSpdSetRead_Click(sender, e);
            if (board_Disp)
            {
                CommandWrite("RD 122", true);//ATS_Active_Mode 0:鳴動なし 1以上:鳴動許可
                CommandWrite("RD 140", true);//ATS-S 電源投入時間
            }
            if (board_ATSP)
            {
                CommandWrite("RD 200", true);//ATS-P 電源自動モード
                CommandWrite("RD 202", true);//ATS-P East(1)/West(0)
                CommandWrite("RD 204", true);//ATS未投入防止 1bit:(1)警報器(0)警報装置 2bit:(1)2ノッチ(0)3ノッチ
                CommandWrite("RD 206", true);//206 BZ21強制停止タイマー
                CommandWrite("RD 208", true);//208 ATS-P(West)表示灯点灯遅延タイマ

            }
            btnSpdSave.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            tsslError.Text = "受信できませんでした";
            tsslError.BackColor = Color.Yellow;
        }
        //ログテキストボックスの行数上限を決める
        private int maxLogLines = 50;
        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            //ログテキストボックスの行数上限処理
            if (tbLog.Lines.Count() > maxLogLines)
            {
                //リスト化
                List<string> lines = new List<string>(tbLog.Lines);
                //余剰行分を削除
                for (int i = 0; tbLog.Lines.Count() - maxLogLines > i; i++)
                {
                    lines.RemoveAt(i); // 1行目削除

                }
                //リストを再度テキストボックスに結合
                tbLog.Text = String.Join("\r\n", lines);
            }
        }

        private void cbPotMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPotMode.Checked)
            {
                CommandWrite("MD POT 1", true);
                cbModeN.Checked = false;
            }
            else
            {
                CommandWrite("MD POT 0", true);
            }
        }

        private void btnMetRead_Click(object sender, EventArgs e)
        {
            serialPortMain.DiscardInBuffer();
            CommandWrite("RD 046", true);//回生モード
            CommandWrite("RD 048", true);//計器モード
            CommandWrite("RD 052", true);//列車抵抗
        }

        private void btnBrkSapMaxAngl_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBrkSapMaxAngl.Text, out int num);
            Int32.TryParse(tbSapAngl.Text, out int num2);
            if ((num >= 0) && (num < num2))
            {
                CommandWrite("WR 056 " + num, true);
                Settings.Default.brk_sap_max_angl = tbBrkSapMaxAngl.Text;
            }
            else
            {
                MessageBox.Show("直通帯の範囲内に設定してください(0～" + num2.ToString() + "°)");
            }
        }

        private void btnChatFilter_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbChatFilter.Text, out int num);
            if ((num >= 0) && (num <= 3))
            {
                CommandWrite("WR 054 " + num, true);
                Settings.Default.chat_filter = tbChatFilter.Text;
            }
            else
            {
                MessageBox.Show("0～3°の範囲内で設定してください");
            }
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
        }

        private void tbBrkMaxAngl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBrkSapMaxAngl_Click(sender, e);
            }
        }

        private void tbChatFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChatFilter_Click(sender, e);
            }
        }

        DateTime startDt;

        private bool flgRead = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (var portName in SerialPort.GetPortNames())
            {
                if (strPortName == portName)
                {
                    timer2.Stop();
                    btnSerialPortOpen.Enabled = true;
                    cbPortSelect.Enabled = true;
                    btnSerialPortOpen.BackColor = SystemColors.Control;
                    btnSerialPortOpen.Text = "通信開始";
                    break;
                }
            }
            if ((DateTime.Now - startDt).TotalSeconds > 10)
            {
                timer2.Stop();
                btnSerialPortOpen.Enabled = true;
                cbPortSelect.Enabled = true;
                btnSerialPortOpen.BackColor = SystemColors.Control;
                btnSerialPortOpen.Text = "通信開始";
            }
        }

        private void btnBrkPlus_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBrkNumTop.Text, out int num);
            if ((num >= 0) && (num < 255))
            {
                if (!serialPortMain.IsOpen)
                {
                    serialPort1Open();
                }
                num++;
                tbBrkNumTop.Text = num.ToString();
                tbBrkNum.Text = tbBrkNumTop.Text;
                btnBrkNum_Click(sender, e);
                Settings.Default.brk_num = tbBrkNumTop.Text;
            }
            else
            {
                MessageBox.Show("設定の範囲外です(0～255段)");
            }
        }

        private void btnBrkMinus_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBrkNumTop.Text, out int num);
            if ((num > 0) && (num <= 255))
            {
                if (!serialPortMain.IsOpen)
                {
                    serialPort1Open();
                }
                num--;
                tbBrkNumTop.Text = num.ToString();
                tbBrkNum.Text = tbBrkNumTop.Text;
                btnBrkNum_Click(sender, e);
                Settings.Default.brk_num = tbBrkNumTop.Text;
            }
            else
            {
                MessageBox.Show("設定の範囲外です(0～255段)");
            }
        }

        private void btnBve5Start_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPort1Close();
            }
            Settings.Default.Save();
            Process p = Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\mackoy\BveTs5\bvets.exe");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tbBrkSapMinAngl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBrkSapMinAngl_Click(sender, e);
            }
        }

        private void btnBrkSapMinAngl_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBrkSapMinAngl.Text, out int num);
            Int32.TryParse(tbBrkSapMaxAngl.Text, out int num2);
            if ((num >= 0) && (num <= num2))
            {
                CommandWrite("WR 058 " + num, true);
                Settings.Default.brk_sap_min_angl = tbBrkSapMinAngl.Text;
            }
            else
            {
                MessageBox.Show("常用最大より小さい範囲に設定してください(0～" + num2.ToString() + "°)");
            }
        }

        private void btnBrkSave_Click(object sender, EventArgs e)
        {
            btnBrkNum_Click(sender, e);         //004
            btnSapAngl_Click(sender, e);        //006
            btnEBAngl_Click(sender, e);         //008
            btnBrkFullAngl_Click(sender, e);    //010
            btnChatFilter_Click(sender, e);     //054
            btnBrkSapMaxAngl_Click(sender, e);  //056
            btnBrkSapMinAngl_Click(sender, e);  //058
            btnKeep_Click(sender, e);           //060
            btnKeepFull_Click(sender, e);       //062
            btnBpSpanDown_Click(sender, e);     //064
            btnBpSpanUp_Click(sender, e);       //066
            btnMcNumMax_Click(sender, e);       //070
            btnMcNum_Click(sender, e);          //072
                                                //cbAtsCont_CheckedChanged(sender, e);//074 警報持続B接点
                                                //cbAtsConf_CheckedChanged(sender, e);//076 ATS確認B接点
                                                //cbAutoNotch_CheckedChanged(sender, e);//078 自動ノッチ合わせ
                                                //cbRealAutoAir_CheckedChanged(sender, e);//080 実際のエアー圧で自動帯再現
                                                //cbAtsContactUse_CheckedChanged(sender, e);//082 ATS接点情報を他基板へ伝送
            Settings.Default.Save();
        }

        private void tbKeep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKeep_Click(sender, e);
            }
        }

        private void tbKeepFull_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKeepFull_Click(sender, e);
            }
        }

        private void btnKeep_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbKeep.Text, out int num);
            Int32.TryParse(tbSapAngl.Text, out int num2);
            if ((num >= 0) && (num > num2))
            {
                CommandWrite("WR 060 " + num, true);
                Settings.Default.brk_keep_angl = tbKeep.Text;
            }
            else
            {
                MessageBox.Show("直通帯幅の外側に設定してください。" + num2.ToString() + "°)");
            }
        }

        private void btnKeepFull_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbKeepFull.Text, out int num);
            Int32.TryParse(tbSapAngl.Text, out int num2);
            if ((num >= 0) && (num > num2))
            {
                CommandWrite("WR 062 " + num, true);
                Settings.Default.brk_keep_full_angl = tbKeepFull.Text;
            }
            else
            {
                MessageBox.Show("直通帯幅の外側に設定してください。" + num2.ToString() + "°)");
            }
        }

        private void btnBpSpanDown_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBpSpanDown.Text, out int num);
            if ((num > 0) && (num <= 100))
            {
                CommandWrite("WR 064 " + num, true);
                Settings.Default.bp_span_down = tbBpSpanDown.Text;
            }
            else
            {
                MessageBox.Show("0～100msの間に設定してください。");
            }
        }

        private void tbBpSpanDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBpSpanDown_Click(sender, e);
            }
        }

        private void btnBpSpanUp_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbBpSpanUp.Text, out int num);
            if ((num > 0) && (num <= 100))
            {
                CommandWrite("WR 066 " + num, true);
                Settings.Default.bp_span_up = tbBpSpanUp.Text;
            }
            else
            {
                MessageBox.Show("0～100msの間に設定してください。");
            }
        }

        private void tbBpSpanUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBpSpanUp_Click(sender, e);
            }
        }

        private void btnSpdSave_Click(object sender, EventArgs e)
        {
            btnSpdSetSave_Click(sender, e);

            btnOhm_Click(sender, e);

            if (board_ATSP)
            {
                CommandWrite("WR 200 " + (cbAtsPDengenAuto.Checked ? "1" : "0"), true);
                CommandWrite("WR 202 " + (rbPEast.Checked ? "1" : "0"), true);
                btnAtsPDengenTounyuTime_Click(sender, e); //208
            }
            if (board_Disp)
            {
                btnAtsSDengenTounyuTime_Click(sender, e); //140
            }
            Disp();
            Settings.Default.Save();
        }

        private void tbarBc_Scroll(object sender, EventArgs e)
        {
            tbBC.Text = tbarBc.Value.ToString();
            Disp();
        }

        private void btnMcPlus_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbMcNumTop.Text, out int num);
            if ((num >= 4) && (num < 5))
            {
                if (!serialPortMain.IsOpen)
                {
                    serialPort1Open();
                }
                num++;
                tbMcNumTop.Text = num.ToString();
                tbMcNum.Text = tbMcNumTop.Text;
                btnMcNum_Click(sender, e);
                Settings.Default.mc_num = tbMcNumTop.Text;
            }
            else
            {
                MessageBox.Show("設定の範囲外です(4～5段)");
            }
        }

        private void btnMcMinus_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbMcNumTop.Text, out int num);
            if ((num > 4) && (num <= 5))
            {
                if (!serialPortMain.IsOpen)
                {
                    serialPort1Open();
                }
                num--;
                tbMcNumTop.Text = num.ToString();
                tbMcNum.Text = tbMcNumTop.Text;
                btnMcNum_Click(sender, e);
                Settings.Default.mc_num = tbMcNumTop.Text;
            }
            else
            {
                MessageBox.Show("設定の範囲外です(4～5段)");
            }
        }

        private void btnMcNum_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbMcNum.Text, out int num);
            if ((num >= 4) && (num <= 5))
            {
                CommandWrite("WR 072 " + num, true);
                Settings.Default.mc_num = tbMcNum.Text;
            }
            else
            {
                MessageBox.Show("設定段数の範囲外です(0～255段)");
            }
        }

        private void btnMcNumMax_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbMcNumMax.Text, out int num);
            if ((num >= 4) && (num <= 5))
            {
                CommandWrite("WR 070 " + num, true);
                Settings.Default.mc_num_max = tbMcNumMax.Text;
            }
            else
            {
                MessageBox.Show("設定段数の範囲外です(0～255段)");
            }
        }

        private void rbCurrent_Click(object sender, EventArgs e)
        {
            CommandWrite("WR 048 0", true);
        }

        private void rbVolt_Click(object sender, EventArgs e)
        {
            CommandWrite("WR 048 1", true);
        }

        private void rbVolt_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.mtr_current = !rbCurrent.Checked;
        }

        private void tbMcNumMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMcNumMax_Click(sender, e);
            }
        }


        private void tbMcNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMcNum_Click(sender, e);
            }
        }

        private void btnBve6Start_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPort1Close();
            }
            Settings.Default.Save();
            Process p = Process.Start(Environment.GetFolderPath((Environment.SpecialFolder.ProgramFiles)) + @"\mackoy\BveTs6\bvets.exe");
        }

        private void btnMcMaxPlus_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbMcNumMaxTop.Text, out int num);
            if ((num >= 4) && (num < 5))
            {
                if (!serialPortMain.IsOpen)
                {
                    serialPort1Open();
                }
                num++;
                tbMcNumMaxTop.Text = num.ToString();
                tbMcNumMax.Text = tbMcNumMaxTop.Text;
                btnMcNumMax_Click(sender, e);
                Settings.Default.mc_num_max = tbMcNumMaxTop.Text;
            }
            else
            {
                MessageBox.Show("設定の範囲外です(4～5段)");
            }
        }

        private void btnMcMaxMinus_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbMcNumMaxTop.Text, out int num);
            if ((num > 4) && (num <= 5))
            {
                if (!serialPortMain.IsOpen)
                {
                    serialPort1Open();
                }
                num--;
                tbMcNumMaxTop.Text = num.ToString();
                tbMcNumMax.Text = tbMcNumMaxTop.Text;
                btnMcNumMax_Click(sender, e);
                Settings.Default.mc_num_max = tbMcNumMaxTop.Text;
            }
            else
            {
                MessageBox.Show("設定の範囲外です(4～5段)");
            }
        }


        private void tbBC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Int32.TryParse(tbBC.Text, out int num);
                tbarBc.Value = num;
                tbarBc_Scroll(sender, e);
            }
        }

        private void cbBpEvac_CheckedChanged(object sender, EventArgs e)
        {
            cbBpEvacPress.Checked = cbBpEvac.Checked;
            Disp();
        }

        private void cbxAutoNotch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommandWrite("WR 078 " + cbxAutoNotch.SelectedIndex.ToString("0"), true);
            Settings.Default.autonotch_use = cbxAutoNotch.SelectedIndex;
        }

        private static bool pause_state = false;
        private static int mc_count = 0;
        private static int brake_count = 0;
        private static int rev_count = 0;
        private static string str_rev = "N";
        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbAtsConf.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.Insert)
            {
                tbAtsCont.BackColor = Color.Orange;
            }
            if (e.KeyCode == Keys.Home)
            {
                tbAtsRec.BackColor = Color.Purple;
            }
            if (e.KeyCode == Keys.Delete)
            {
                tbEB.BackColor = Color.Green;
            }
            if (e.KeyCode == Keys.Return)
            {
                tbHorn1.BackColor = Color.Yellow;
            }
            if (e.KeyCode == Keys.Add)
            {
                tbHorn2.BackColor = Color.Yellow;
            }
            if (e.KeyCode == Keys.Z)
            {
                tbZ.BackColor = Color.Red;
                Int32.TryParse(tbMcNumMaxTop.Text, out int num);
                if (mc_count < num)
                {
                    mc_count++;
                }
                tbMcCount.Text = mc_count.ToString();
            }
            if (e.KeyCode == Keys.A)
            {
                tbA.BackColor = Color.Red;
                if (mc_count > 0)
                {
                    mc_count--;
                }
                else if(mc_count < 0)
                {
                    mc_count++;
                }
                tbMcCount.Text = mc_count.ToString();
            }
            if (e.KeyCode == Keys.Q)
            {
                tbQ.BackColor = Color.Red;
                mc_count--;
                tbMcCount.Text = mc_count.ToString();
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                tbComma.BackColor = Color.Red;
                if (brake_count > 0)
                {
                    brake_count--;
                }
                tbBrakeCount.Text = brake_count.ToString();
                //await LightUpControl(tbComma);
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                tbB.BackColor = Color.Red;
                Int32.TryParse(tbBrkNumTop.Text, out int num);
                if (brake_count < num)
                {
                    brake_count++;
                }
                tbBrakeCount.Text = brake_count.ToString();
                //await LightUpControl(tbB);
            }
            if (e.KeyCode == Keys.OemQuestion)
            {
                tbEm.BackColor = Color.Red;
                Int32.TryParse(tbBrkNumTop.Text, out int num);
                brake_count = num + 1;
                tbBrakeCount.Text = brake_count.ToString();
                //await LightUpControl(tbEm);
            }
            if (e.KeyCode == Keys.Up)
            {
                tbUp.BackColor = Color.SkyBlue;
                if (rev_count < 1)
                {
                    rev_count++;
                }
                if (rev_count == 1)
                {
                    str_rev = "F";
                }
                else if (rev_count == -1)
                {
                    str_rev = "B";
                }
                else
                {
                    str_rev = "N";
                }
                tbRev.Text = str_rev;
            }
            if (e.KeyCode == Keys.Down)
            {
                tbDown.BackColor = Color.SkyBlue;
                if (rev_count > -1)
                {
                    rev_count--;
                }
                if (rev_count == 1)
                {
                    str_rev = "F";
                }
                else if (rev_count == -1)
                {
                    str_rev = "B";
                }
                else
                {
                    str_rev = "N";
                }
                tbRev.Text = str_rev;
            }

            if (e.KeyCode == Keys.P)
            {
                pause_state = !pause_state;
                if (pause_state)
                {
                    tbP.BackColor = Color.Pink;
                }
                else
                {
                    tbP.BackColor = SystemColors.Control;
                }
            }

            if (e.KeyCode == Keys.D0)
            {
                if (cbOERMode.Checked)
                {
                    cbLampOERLight.Checked = !cbLampOERLight.Checked;
                }
            }
        }

        private async Task LightUpControl(Control control)
        {
            control.BackColor = Color.Yellow; // ボタンを光らせる
            await Task.Delay(1000); // 1秒待つ
            control.BackColor = SystemColors.Control; // 元の色に戻す
        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbAtsConf.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Insert)
            {
                tbAtsCont.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Home)
            {
                tbAtsRec.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Delete)
            {
                tbEB.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Return)
            {
                tbHorn1.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Add)
            {
                tbHorn2.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Z)
            {
                tbZ.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.A)
            {
                tbA.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Q)
            {
                tbQ.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                tbComma.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                tbB.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.OemQuestion)
            {
                tbEm.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Up)
            {
                tbUp.BackColor = SystemColors.Control;
            }
            if (e.KeyCode == Keys.Down)
            {
                tbDown.BackColor = SystemColors.Control;
            }
        }

        private void cbRealAutoAir_CheckedChanged(object sender, EventArgs e)
        {
            CommandWrite("WR 080 " + (cbRealAutoAir.Checked ? "1" : "0"), true);
            pnlAutoair.Enabled = !cbRealAutoAir.Checked;
            Settings.Default.realAutoAir = cbRealAutoAir.Checked;
            if (cbRealAutoAir.Checked)
            {
                tabControl3.SelectedIndex = 0;
            }
            else
            {
                tabControl3.SelectedIndex = 1;
            }
        }

        private void btnBCMin_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbBCMin.Text, out int num);
                if ((num > 0) && (num < 490))
                {
                    CommandWrite("WR 110 " + num, true);
                    Settings.Default.BCMin = tbBCMin.Text;
                }
                else
                {
                    MessageBox.Show("圧力範囲に設定してください(0～490kPa)");
                }
            }
        }

        private void tbBCMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBCMin_Click(sender, e);
            }
        }
        private void btnPressRead_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                CommandWrite("RD 102", true);
                CommandWrite("RD 104", true);
                CommandWrite("RD 106", true);
                CommandWrite("RD 108", true);
                CommandWrite("RD 110", true);
                CommandWrite("RD 112", true); //平均化率(A制御弁)
                CommandWrite("RD 114", true);
                CommandWrite("RD 116", true);
                CommandWrite("RD 118", true); //E電磁弁開放開始圧力

                CommandWrite("RD 124", true);
                CommandWrite("RD 126", true);
                CommandWrite("RD 128", true);
                CommandWrite("RD 130", true);
                CommandWrite("RD 132", true); //BC最大圧力(急動部動作時)
                CommandWrite("RD 134", true); //BC最大圧力(常用時)
                CommandWrite("RD 136", true); //BC倍率(急動部動作時)
                CommandWrite("RD 138", true); //BC倍率(常用時)

                CommandWrite("RD 142", true); //急動部動作しきい値
                CommandWrite("RD 144", true); //A制御弁(0) E制御弁(1)
                CommandWrite("RD 146", true); //BC最大圧力(E制御弁)
                CommandWrite("RD 148", true); //BC倍率(E制御弁)
                CommandWrite("RD 150", true); //平均化率(E制御弁)


                btnPressSave.Enabled = true;
            }
        }

        private void btnPressSave_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                btnFVMin_Click(sender, e);          //102 124
                btnFVMax_Click(sender, e);          //104 126
                btnBPMin_Click(sender, e);          //106 128
                btnBPMax_Click(sender, e);          //108 130
                btnBCMin_Click(sender, e);          //110
                btnAveRatio_Click(sender, e);       //112
                btnMonInterval_Click(sender, e);    //114
                btnEBInterval_Click(sender, e);     //116
                btnEBThreshold_Click(sender, e);    //118

                btnBCMax_Click(sender, e);          //132
                btnBCMaxMorm_Click(sender, e);      //134
                btnBCMulti_Click(sender, e);        //136
                btnBCMultiNorm_Click(sender, e);    //138
                Settings.Default.Save();
            }
        }

        private void tbFVPressMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFVMax_Click(sender, e);
            }
        }

        private void tbFVPressMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFVMin_Click(sender, e);
            }
        }

        private void tbMonInterval_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMonInterval_Click(sender, e);
            }

        }

        private void tbBCMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBCMax_Click(sender, e);
            }

        }


        private void tbBCMaxNorm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBCMaxMorm_Click(sender, e);
            }
        }



        private void btnMonInterval_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbMonInterval.Text, out int value);
                CommandWrite("WR 114 " + value.ToString(), false);
                Settings.Default.MonInterval = tbMonInterval.Text;
            }
        }

        //BC最大値(急動部動作時)
        private void btnBCMax_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbBCMax.Text, out int num1);

                if ((num1 >= 0) && (num1 <= 490))
                {
                    CommandWrite("WR 132 " + num1, true);
                    Settings.Default.BCMax = tbBCMax.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0～FV(最大値))");
                }
            }
        }

        private void btnBCMaxMorm_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbBCMaxNorm.Text, out int num1);

                if ((num1 >= 0) && (num1 <= 490))
                {
                    CommandWrite("WR 134 " + num1, true);
                    Settings.Default.BCMaxNorm = tbBCMaxNorm.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0～FV(最大値))");
                }
            }
        }

        private void tbBCMulti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBCMulti_Click(sender, e);
            }
        }

        //BC倍率(常用時)
        private void btnBCMulti_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Double.TryParse(tbBCMulti.Text, out double num1);

                if ((num1 >= 0) && (num1 <= 100))
                {
                    CommandWrite("WR 136 " + (int)(num1 * 10), true);
                    Settings.Default.BCMulti = tbBCMulti.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0.0～100.0");
                }
            }
        }

        private void tbBCMultiNorm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBCMultiNorm_Click(sender, e);
            }
        }


        //BC倍率(常用時)
        private void btnBCMultiNorm_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Double.TryParse(tbBCMultiNorm.Text, out double num1);
                if ((num1 >= 0) && (num1 <= 100))
                {
                    CommandWrite("WR 138 " + (int)(num1 * 10), true);
                    Settings.Default.BCMultiNorm = tbBCMultiNorm.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0.0～100.0");
                }
            }
        }


        //FV最小値
        private void btnFVMin_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbFVMin.Text, out int num1);
                Int32.TryParse(tbFVMax.Text, out int num2);
                Int32.TryParse(tbFVPressMin.Text, out int num3);
                Int32.TryParse(tbFVPressMax.Text, out int num4);

                if ((num1 >= 0) && (num1 < num2) && (num3 >= 0) && (num3 < num4))
                {
                    CommandWrite("WR 102 " + num1, true);
                    CommandWrite("WR 124 " + num3, true);
                    Settings.Default.FVPressMin = tbFVPressMin.Text;
                    Settings.Default.FVPressMin = tbFVPressMin.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0～FV(最大値))");
                }
                tbarFV.Minimum = num3;
                tbarFV.Maximum = num4;
            }
        }
        private void tbFVMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFVMin_Click(sender, e);
            }
        }


        private void tbFVMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFVMax_Click(sender, e);
            }
        }

        //FV最大値
        private void btnFVMax_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbFVMax.Text, out int num1);
                Int32.TryParse(tbFVMin.Text, out int num2);
                Int32.TryParse(tbFVPressMax.Text, out int num3);
                Int32.TryParse(tbFVPressMin.Text, out int num4);
                if ((num1 >= num2) && (num1 <= 1023) && (num3 >= num4) && (num3 <= 1023))
                {
                    CommandWrite("WR 104 " + num1, true);
                    CommandWrite("WR 126 " + num3, true);

                    Settings.Default.FVMax = tbFVMax.Text;
                    Settings.Default.FVPressMax = tbFVPressMax.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。FV(最小値)～1023)");
                }
                tbarFV.Minimum = num4;
                tbarFV.Maximum = num3;
            }
        }

        private void tbBPMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBPMin_Click(sender, e);
            }
        }

        private void btnBPMin_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbBPMin.Text, out int num1);
                Int32.TryParse(tbBPMax.Text, out int num2);
                Int32.TryParse(tbBPPressMin.Text, out int num3);
                Int32.TryParse(tbBPPressMax.Text, out int num4);
                if ((num1 >= 0) && (num1 <= num2) && (num3 >= 0) && (num3 <= num4))
                {
                    CommandWrite("WR 106 " + num1, true);
                    CommandWrite("WR 128 " + num3, true);

                    Settings.Default.BPMin = tbBPMin.Text;
                    Settings.Default.BPPressMin = tbBPPressMin.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0～BP(Max)");
                }
                tbarBP.Minimum = num3;
                tbarBP.Maximum = num4;
            }
        }

        private void tbBPMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBPMax_Click(sender, e);
            }
        }

        private void btnBPMax_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbBPMax.Text, out int num1);
                Int32.TryParse(tbBPMin.Text, out int num2);
                Int32.TryParse(tbBPPressMax.Text, out int num3);
                Int32.TryParse(tbBPPressMin.Text, out int num4);

                if ((num1 >= num2) && (num1 <= 1023) && (num3 >= num4) && (num3 <= 1023))
                {
                    CommandWrite("WR 108 " + num1, true);
                    CommandWrite("WR 130 " + num3, true);
                    Settings.Default.BPMax = tbBPMax.Text;
                    Settings.Default.BPPressMax = tbBPPressMax.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です(BP(最小値)～1024)");
                }
                tbarBP.Maximum = num3;
                tbarBP.Minimum = num4;
            }
        }

        private void cbModeMON_CheckedChanged(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                CommandWrite("MON  " + (cbModeMON.Checked ? "1" : "0"), true);
                tbarFV.Enabled = cbModeMON.Checked;
                tbarBP.Enabled = cbModeMON.Checked;
                tbarBCPress.Enabled = cbModeMON.Checked;
                tbFV_V.Enabled = cbModeMON.Checked;
                tbBP_V.Enabled = cbModeMON.Checked;
                tbFV.Enabled = cbModeMON.Checked;
                tbBP.Enabled = cbModeMON.Checked;
                tbBCPress.Enabled = cbModeMON.Checked;

                cbBpEvac.Enabled = !cbModeMON.Checked;
                cbBpEvacPress.Enabled = !cbModeMON.Checked;

                if (cbModeMON.Checked) tbLog.Focus();
                if (!cbModeMON.Checked) timer1.Stop();
            }
        }

        private void btnAveRatio_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbAveRatio.Text, out int num);
                if ((num >= 0) && (num <= 99))
                {
                    CommandWrite("WR 112 " + num, true);
                    Settings.Default.AveRatio = tbAveRatio.Text;
                }
                else
                {
                    MessageBox.Show("0～99の範囲にして下さい");
                }
            }
        }

        private void cbBpEvacPress_CheckedChanged(object sender, EventArgs e)
        {
            cbBpEvac.Checked = cbBpEvacPress.Checked;
            Disp();
        }

        private void tbEBInterval_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEBInterval_Click(sender, e);
            }
        }

        private void btnEBInterval_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Double.TryParse(tbEBInterval.Text, out double num1);

                if (num1 > 0.0 && num1 <= 65.535)
                {
                    CommandWrite("WR 116 " + (int)(num1 * 1000), true);
                    Settings.Default.EBInterval = tbEBInterval.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です(0.000～65.535秒)");
                }
            }
        }

        private void btnSetReadAll_Click(object sender, EventArgs e)
        {
            btnSpdRead_Click(sender, e);
            btnBrkRead_Click(sender, e);
            btnPressRead_Click(sender, e);
            if (btnSetReadAll.BackColor == Color.Salmon)
            {
                btnSetReadAll.BackColor = SystemColors.Control;
                btnSetSaveAll.BackColor = Color.Salmon;
            }
            btnSetSaveAll.Enabled = true;
            btnSaveParamXml.Enabled = true;
        }

        private void btnSetSaveAll_Click(object sender, EventArgs e)
        {
            btnSpdSave_Click(sender, e);
            btnBrkSave_Click(sender, e);
            btnPressSave_Click(sender, e);
            if (btnSetSaveAll.BackColor == Color.Salmon)
            {
                btnSetSaveAll.BackColor = SystemColors.Control;
            }
            Settings.Default.Save();
        }

        private void tbAveRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAveRatio_Click(sender, e);
            }
        }

        private void tbBPPressMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBPMin_Click(sender, e);
            }
        }

        private void tbBPPressMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBPMax_Click(sender, e);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAirMeterDebug.Checked = false;
            cbModeMON.Checked = false;
            cbModeN.Checked = false;
            ReadSimPress();
        }

        private void tbLogRows_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogClear_Click(sender, e);
                int.TryParse(tbLogRows.Text, out maxLogLines);
                Settings.Default.maxLogLines = maxLogLines.ToString();

            }
        }

        private void cbAtsDengenMode_CheckedChanged(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                string s = cbAtsDengenMode.Checked ? "1" : "0";
                CommandWrite("WR 120 " + s, true);
                Settings.Default.AtsDengenMode = cbAtsDengenMode.Checked;
            }
        }

        private void rbPEast_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.AtsPEast = rbPEast.Checked;
        }

        private void cbAtsPDengenAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (board_ATSP)
            {
                CommandWrite("WR 200 " + (cbAtsPDengenAuto.Checked ? "1" : "0"), true);
                Settings.Default.AtsPDengenAuto = cbAtsPDengenAuto.Checked;
            }
        }

        private void tbAtsSDengenTounyuTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAtsSDengenTounyuTime_Click(sender, e);
            }
        }

        private void btnAtsSDengenTounyuTime_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                double.TryParse(tbAtsSDengenTounyuTime.Text, out double d);
                Settings.Default.AtsDengenTounyuTime = (int)(d * 1000);
                CommandWrite("WR 140 " + (int)(d * 1000), true);
            }
        }

        private void tbBPvelocityKyudouThreshold_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBPvelocityKyudouThreshold_Click(sender, e);
            }
        }



        private void btnBPvelocityKyudouThreshold_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                int.TryParse(tbBPvelocityKyudouThreshold.Text, out int num);
                if ((num >= 0) && (num <= 3000))
                {
                    CommandWrite("WR 142 " + num, true);
                    Settings.Default.BPvelocityKyudouThreshold = num.ToString();
                }
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                if (tabControl2.SelectedIndex == 0)
                {
                    CommandWrite("WR 144 0", true);
                    Settings.Default.Evalve = false;

                    btnBCMulti_Click(sender, e);
                    btnBCMax_Click(sender, e);
                    btnBCMultiNorm_Click(sender, e);
                    btnBCMaxMorm_Click(sender, e);
                    btnBPvelocityKyudouThreshold_Click(sender, e);
                    btnAveRatio_Click(sender, e);

                }
                else
                {
                    CommandWrite("WR 144 1", true);
                    Settings.Default.Evalve = true;
                    btnBCMultiE_Click(sender, e);
                    btnBCMaxE_Click(sender, e);
                    btnAveRationE_Click(sender, e);
                }
            }
        }

        private void tbBCMultiE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBCMultiE_Click(sender, e);
            }
        }

        private void btnBCMultiE_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Double.TryParse(tbBCMultiE.Text, out double num1);
                if ((num1 >= 0) && (num1 <= 100))
                {
                    CommandWrite("WR 148 " + (int)(num1 * 10), true);
                    Settings.Default.BCMultiE = tbBCMultiE.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0.0～100.0");
                }
            }
        }

        private void tbBCMaxE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBCMaxE_Click(sender, e);
            }
        }

        private void btnBCMaxE_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbBCMaxE.Text, out int num1);

                if ((num1 >= 0) && (num1 <= 490))
                {
                    CommandWrite("WR 146 " + num1, true);
                    Settings.Default.BCMaxE = tbBCMaxE.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です。0～FV(最大値))");
                }
            }
        }

        private void tbAveRatioE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAveRationE_Click(sender, e);
            }
        }

        private void btnAveRationE_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbAveRatioE.Text, out int num);
                if ((num >= 0) && (num <= 99))
                {
                    CommandWrite("WR 150 " + num, true);
                    Settings.Default.AveRatioE = tbAveRatioE.Text;
                }
                else
                {
                    MessageBox.Show("0～99の範囲にして下さい");
                }
            }
        }

        private void tbEBOndelay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEBOndelay(sender, e);
            }
        }

        private void btnEBOndelay(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Double.TryParse(tbEBOndelay.Text, out double num1);

                if (num1 > 0.0 && num1 <= 65.535)
                {
                    CommandWrite("WR 152 " + (int)(num1 * 1000), true);
                    Settings.Default.EBOndelay = tbEBOndelay.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です(0.000～65.535秒)");
                }
            }
        }

        private void rbPWest_Click(object sender, EventArgs e)
        {
            if (board_ATSP)
            {
                CommandWrite("WR 202 " + 0, true);
            }
            tbAtsPDengenTounyuTime.Enabled = true;
        }

        private void rbPEast_Click(object sender, EventArgs e)
        {
            if (board_ATSP)
            {
                CommandWrite("WR 202 " + 1, true);
            }
            tbAtsPDengenTounyuTime.Enabled = false;
        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void tbEBThreshold_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEBThreshold_Click(sender, e);
            }
        }

        private void btnEBThreshold_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                Int32.TryParse(tbEBThreshold.Text, out int num);
                if ((num > 0) && (num < 490))
                {
                    CommandWrite("WR 118 " + num, true);
                    Settings.Default.EBThreshold = tbEBThreshold.Text;
                }
                else
                {
                    MessageBox.Show("圧力範囲に設定してください(0～490kPa)");
                }
            }
        }

        private void btnSpdSetRead_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.DiscardInBuffer();
            }
            flgRead = true;
            //CommandWrite("RD SPD", true);
            //Thread.Sleep(20);
            for (int i = 12; i <= 44; i += 2)
            {
                Int32.TryParse(tbLimit.Text, out int limit);
                //if (((i - 12) / 2 + 1) * 10 <= limit && ((i - 12) / 2 + 1) * 10 >= 0)
                //{
                var val = ((i - 12) / 2 + 1) * 10;
                if (val > limit) val = limit;
                tbarSpdTest.Value = val;
                tbSpdTest.Text = tbarSpdTest.Value.ToString();
                //}
                CommandWrite("RD " + i.ToString("D3"), true);
            }

            btnSpdSetSave.Enabled = true;
        }

        private void btnSpdSetSave_Click(object sender, EventArgs e)
        {
            // 1. 制限設定の実行
            btnLimit_Click(sender, e);

            // 2. 10から160まで順番に処理
            // tbSpdTextBox[0]が10、[1]が20...[15]が160に対応している前提
            foreach (var tb in tbSpdTextBox)
            {
                if (tb != null)
                {
                    // TextBoxをsenderとして渡すことでspeedBtn_Click内のロジックが動く
                    speedBtn_Click(tb, e);
                }
            }

            // 3. 画面更新
            Disp();
        }

        private bool board_Disp = false;
        private void tsmiDispBoard_Click(object sender, EventArgs e)
        {
            board_Disp = !board_Disp;
            SwitchDispBoard(board_Disp);
        }

        private void SwitchDispBoard(bool board_Disp)
        {
            tsmiDispBoard.Checked = board_Disp;
            pnlDisp.Enabled = board_Disp;
            pnlPress.Enabled = board_Disp;
            gbBCTop.Enabled = board_Disp;
            cbModeMON.Enabled = board_Disp;
            cbOERMode.Enabled = board_Disp;

            if (!board_Disp)
            {
                cbRealAutoAir.Checked = false;
            }
            Settings.Default.board_Disp = board_Disp;
        }

        private bool board_ATSP = false;

        private void tsmiATSPBoard_Click(object sender, EventArgs e)
        {
            board_ATSP = !board_ATSP;
            SwitchATSPBoard(board_ATSP);
        }

        private void SwitchATSPBoard(bool board_ATSP)
        {
            tsmiATSPBoard.Checked = board_ATSP;
            pnlATSP.Enabled = board_ATSP;
            Settings.Default.board_ATSP = board_ATSP;
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString());
            serialPort1Close();
        }

        private void tbBrkNum_TextChanged(object sender, EventArgs e)
        {
            tbBrkNumTop.Text = tbBrkNum.Text;
        }

        private void tbMcNumMax_TextChanged(object sender, EventArgs e)
        {
            tbMcNumMaxTop.Text = tbMcNumMax.Text;
        }

        private void tbMcNum_TextChanged(object sender, EventArgs e)
        {
            tbMcNumTop.Text = tbMcNum.Text;
        }

        private static bool flgAdjN = false;
        private void btnAdjN_Click(object sender, EventArgs e)
        {
            flgAdjN = true;
            CommandWrite("MD POT 1", true);
        }

        private static bool flgAdjEB = false;
        private static int press_MR = 780;
        private static int press_BC = 0;
        private static int press_ER = 490;
        private static int press_SAP = 0;
        private static int press_BP = 490;
        private string strPortNameAirRead;

        private void btnAdjEB_Click(object sender, EventArgs e)
        {
            flgAdjEB = true;
            CommandWrite("MD POT 1", true);
        }

        private void cbUnitDisp_CheckedChanged(object sender, EventArgs e)
        {
            cbOER1000Console.Visible = !cbUnitDisp.Checked;
            if (cbUnitDisp.Checked)
            {
                cbOER1000Console.Checked = false;
            }
            string s = cbUnitDisp.Checked ? "1" : "0";
            cbUnit1.Visible = cbUnitDisp.Checked;
            cbUnit2.Visible = cbUnitDisp.Checked;
            cbUnit3.Visible = cbUnitDisp.Checked;
            cbUnit4.Visible = cbUnitDisp.Checked;
            tbUnitNum.Visible = cbUnitDisp.Checked;
            CommandWrite("WR 180 " + s, true);
            Settings.Default.cbUnitDisp = cbUnitDisp.Checked;
        }

        private void tbUnitNum_KeyDown(object sender, KeyEventArgs e)
        {
            Int32.TryParse(tbUnitNum.Text, out int num);
            if ((num > 0) && (num < 5))
            {
                CommandWrite("WR 182 " + num, true);
                Settings.Default.tbUnitNum = tbUnitNum.Text;
            }
            else
            {
                MessageBox.Show("設定段数の範囲外です(0～4)");
            }
        }

        private void tbRegOffDelay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegOffDelay(sender, e);
            }
        }

        private void btnRegOffDelay(object sender, KeyEventArgs e)
        {
            if (board_Disp)
            {
                Double.TryParse(tbRegOffDelay.Text, out double num1);

                if (num1 > 0.0 && num1 <= 65.535)
                {
                    CommandWrite("WR 154 " + (int)(num1 * 1000), true);
                    Settings.Default.RegOffDelay = tbRegOffDelay.Text;
                }
                else
                {
                    MessageBox.Show("設定値の範囲外です(0.000～65.535秒)");
                }
            }
        }

        private void cbAutoairUse_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (cbAutoairUse.Checked) n |= (1 << 0);
            if (cbRealAutoAir.Checked) n |= (1 << 1);
            if (cbAutoAirEX.Checked) n |= (1 << 2);
            if (cbAirMeterDebug.Checked) n |= (1 << 3);
            if (cbTS185.Checked) n |= (1 << 4);

            CommandWrite("WR 068 " + n.ToString(), true);
            Settings.Default.autoair_use = n;

            pnlAutoair.Enabled = cbAutoairUse.Checked;
            cbRealAutoAir.Enabled = cbAutoairUse.Checked;
            cbAutoAirEX.Enabled = cbAutoairUse.Checked;
        }

        private void tbSimAir_Scroll(object sender, EventArgs e)
        {
            ReadSimPress();
            Disp();
        }

        private void cbPortSelectAirRead_MouseHover(object sender, EventArgs e)
        {
            setSerialComboBox(cbPortSelectAirRead, Settings.Default.portNameAirRead);
        }

        private void btnSerialPortAirReadOpen_Click(object sender, EventArgs e)
        {
            if (btnSerialPortOpenDensei.Text == "通信開始")
            {
                serialPortAirReadOpen();
                serialPortAirSimDebug.Write("MON 1\r");

            }
            else
            {
                serialPort2Close();
            }
        }

        private void serialPort2Close()
        {
            Settings.Default.portNameAirRead = cbPortSelectAirRead.SelectedText;
            //timer1.Stop();
            if (serialPortAirSimDebug.IsOpen)
            {
                serialPortAirSimDebug.Write("MON 0\r");
                Settings.Default.portNameAirRead = serialPortAirSimDebug.PortName;
                serialPortAirSimDebug.DiscardInBuffer();
                serialPortAirSimDebug.DiscardOutBuffer();
                serialPortAirSimDebug.Close();
            }
            cbPortSelectAirRead.Enabled = true;
            setSerialComboBox(cbPortSelectAirRead, Settings.Default.portNameAirRead);
            strPortNameAirRead = serialPortAirSimDebug.PortName;
            btnSerialPortOpenDensei.Text = "通信開始";
            btnSerialPortOpenDensei.Enabled = true;
            cbPortSelect.Enabled = true;
            //gbAirMeterDebug.Visible = false;
            tbSerialRcv2.Visible = false;
            lblSerialRcv2.Visible = false;
        }

        private void serialPortAirReadOpen()
        {

            if (cbPortSelectAirRead.Items.Count > 0)
            {
                try
                {
                    Regex regexPortName = new Regex(@"(COM\d+)");
                    string portName = regexPortName.Match(cbPortSelectAirRead.SelectedItem.ToString()).Groups[1].ToString();
                    serialPortAirSimDebug.PortName = portName;
                    serialPortAirSimDebug.BaudRate = 115200; //int.Parse(comboBoxSerialPort1BauRate.Text);//115200;
                    serialPortAirSimDebug.DtrEnable = true;
                    serialPortAirSimDebug.Open();
                    btnSerialPortOpenDensei.Text = "通信停止";
                    gbAirMeterDebug.Visible = true;
                    tbSerialRcv2.Visible = true;
                    lblSerialRcv2.Visible = true;

                }
                catch (Exception)
                {
                    if (serialPortAirSimDebug.IsOpen)
                    {
                        serialPortAirSimDebug.Close();
                    }
                }
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 受信したデータ
            string data2 = serialPortAirSimDebug.ReadExisting(); ;
            // 異なるスレッドのテキストボックスに書き込む

            BeginInvoke(new Delegate_write(write2), new Object[] { data2 });
        }

        //デリミタ(終端文字列)がない場合の文字列格納用
        private string data2_temp_next;
        private void write2(string data)
        {
            if (data != null)
            {


                //文字列処理用の一時仮格納用
                string data_temp = data;
                //ログ出力用
                string data_disp = "";
                //デリミタ(終端文字列)がある場合
                if (data.Length >= 2)
                {
                    if (data.Substring(data.Length - 2) == "\r\n")
                    {

                        //MessageBox.Show("match");
                        //一時仮格納用文字列とデリミタなし文字列を一時結合
                        data_temp = data2_temp_next + data_temp;
                        string data_analys = data_temp;
                        while (data_temp != null)
                        {
                            //\rで文字列を切断
                            if (data_temp.IndexOf("\r") > 0)
                            {
                                int i = data_temp.IndexOf("\r");
                                data_disp = data_temp.Substring(0, i).Trim();
                                data_temp = data_temp.Substring(i).Trim();
                                tbSerialRcv2.Text = data_disp;

                                //ログ出力チェックボックスがチェックされている場合
                                /*if (checkBox1.Checked)
                                {
                                    tbLog.AppendText("Read : " + data_disp + "\r\n");
                                }*/

                                //read_Settings(data_analys, data_disp);
                                read_SimAir(data_disp);
                            }
                            //文字列切断後、最後の文字列の処理
                            else
                            {

                                if (data_temp != "")
                                {
                                    data_disp = data_temp.Trim();
                                    tbSerialRcv2.Text = data_disp;
                                    /*if (checkBox1.Checked)
                                    {
                                        tbLog.AppendText("Read : " + data_disp + "\r\n");
                                    }*/
                                    //read_Settings(data_analys, data_disp);
                                    read_SimAir(data_disp);
                                }
                                data_temp = null;
                            }


                            //仮格納用文字列をnull(空)にする
                            data2_temp_next = null;
                        }
                    }
                    //デリミタ(終端文字列)がない場合
                    else
                    {

                        //MessageBox.Show("not match:"+data );
                        //仮格納用文字列に文字列を一時保管する
                        data2_temp_next += data;

                    }
                }
                //デリミタ(終端文字列)がない場合
                else
                {

                    //MessageBox.Show("not match");
                    //仮格納用文字列に文字列を一時保管する
                    data2_temp_next += data;

                }
            }
        }
        private void read_SimAir(string data)
        {
            //圧力読出し
            if (data.Length >= 70)
            {
                //MR
                string s_MR = data.Substring(51, 3);
                tbSimPressReadMR.Text = s_MR;
                int.TryParse(s_MR, out int MR);
                tbarSimAirReadMR.Value = MR;
                //BC
                string s_BC = data.Substring(55, 3);
                tbSimPressReadBC.Text = s_BC;
                int.TryParse(s_BC, out int BC);
                tbarSimAirReadBC.Value = BC;
                //ER  
                string s_ER = data.Substring(59, 3);
                tbSimPressReadER.Text = s_ER;
                int.TryParse(s_ER, out int ER);
                tbarSimAirReadER.Value = ER;
                //SAP
                string s_SAP = data.Substring(63, 3);
                tbSimPressReadSAP.Text = s_SAP;
                int.TryParse(s_SAP, out int SAP);
                tbarSimAirReadSAP.Value = SAP;
                //BP
                string s_BP = data.Substring(67, 3);
                tbSimPressReadBP.Text = s_BP;
                int.TryParse(s_BP, out int BP);
                tbarSimAirReadBP.Value = BP;

                //直通ランプ
                btnDispTestSAP.BackColor = (data.Substring(17, 1) == "1") ? Color.Yellow : SystemColors.Control;

                //発電ランプ
                btnDispTestHatsuden.BackColor = (data.Substring(18, 1) == "1") ? Color.Yellow : SystemColors.Control;

                //抑速ランプ
                btnDispTestYokusoku.BackColor = (data.Substring(19, 1) == "1") ? Color.Yellow : SystemColors.Control;

                //ATSランプ
                btnDsipTestAts.BackColor = (data.Substring(14, 1) == "1") ? Color.Yellow : SystemColors.Control;

                //ATS動作ランプ
                btnDispTestAtsAlm.BackColor = (data.Substring(15, 1) == "1") ? Color.Red : SystemColors.Control;


            }

        }

        private void btnPluginInstall_Click(object sender, EventArgs e)
        {
            string sourceDirBveExPlugins = @".\BveEx\";
            string dllBveExSourcePath = sourceDirBveExPlugins + @"2.0\Extensions\" + fileNameInstall;
            string dllAtsExSourcePath = sourceDirBveExPlugins + @"Legacy\Extensions\" + fileNameInstall;
            if (File.Exists(dllBveExSourcePath) && File.Exists(dllAtsExSourcePath))
            {
                tbInstallLog.AppendText("--- " + btnPluginInstall.Text + "開始 ---" + "\r\n");
                //File.Copy(dllBveExSourcePath, dllBveExPath, true);
                //File.Copy(dllAtsExSourcePath, dllAtsExPath, true);
                CopyDirectory(sourceDirBveExPlugins, destDirBveExPlugins, tbInstallLog);

                //既存SerialOutputEXの削除
                if (cbSOUninstall.Checked)
                {
                    if (File.Exists(dllBveExPathRemove))
                    {
                        File.Delete(dllBveExPathRemove);
                        tbInstallLog.AppendText("Delete -> " + dllBveExPathRemove + "\r\n");
                    }
                    if (File.Exists(dllAtsExPathRemove))
                    {
                        File.Delete(dllAtsExPathRemove);
                        tbInstallLog.AppendText("Delete -> " + dllAtsExPathRemove + "\r\n");
                    }
                }
                tbInstallLog.AppendText("--- " + btnPluginInstall.Text + "が完了しました ---" + "\r\n");
                MessageBox.Show(btnPluginInstall.Text + "が完了しました");
                if (!File.Exists(dllAtsExPathRemove) && !File.Exists(dllBveExPathRemove))
                {
                    cbSOUninstall.Visible = false;
                }
                btnPluginInstall.Text = "更新";
                btnPluginUnInstall.Enabled = true;
            }
            else
            {
                MessageBox.Show("コピー元ファイルがありません");
            }
        }

        private void btnPluginUnInstall_Click(object sender, EventArgs e)
        {
            tbInstallLog.AppendText("--- " + btnPluginUnInstall.Text + "開始 ---" + "\r\n");
            if (File.Exists(dllBveExPathInstall))
            {
                File.Delete(dllBveExPathInstall);
                tbInstallLog.AppendText("Delete -> " + dllBveExPathInstall + "\r\n");
            }
            if (File.Exists(dllAtsExPathInstall))
            {
                File.Delete(dllAtsExPathInstall);
                tbInstallLog.AppendText("Delete -> " + dllAtsExPathInstall + "\r\n");
            }
            tbInstallLog.AppendText("--- " + btnPluginUnInstall.Text + "が完了しました ---" + "\r\n");
            MessageBox.Show(btnPluginUnInstall.Text + "が完了しました");
            btnPluginInstall.Text = "インストール";
            btnPluginUnInstall.Enabled = false;
        }

        /// <summary>
        /// ディレクトリをコピーする
        /// </summary>
        /// <param name="sourceDirName">コピーするディレクトリ</param>
        /// <param name="destDirName">コピー先のディレクトリ</param>
        public void CopyDirectory(string sourceDirName, string destDirName, System.Windows.Forms.TextBox textBox)
        {
            //コピー先のディレクトリがないときは作る
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
                //属性もコピー
                File.SetAttributes(destDirName,
                    File.GetAttributes(sourceDirName));
            }

            //コピー先のディレクトリ名の末尾に"\"をつける
            if (destDirName[destDirName.Length - 1] !=
                    Path.DirectorySeparatorChar)
                destDirName = destDirName + Path.DirectorySeparatorChar;

            //コピー元のディレクトリにあるファイルをコピー
            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
            {
                if (cbXmlCopy.Checked)
                {
                    File.Copy(file, destDirName + Path.GetFileName(file), true);
                    textBox.AppendText(file + " -> " + destDirName + Path.GetFileName(file) + "\r\n");
                }
                else
                {
                    if (!(Path.GetExtension(file) == ".xml"))
                    {
                        File.Copy(file, destDirName + Path.GetFileName(file), true);
                        textBox.AppendText(file + " -> " + destDirName + Path.GetFileName(file) + "\r\n");
                    }
                }
            }

            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
            {
                CopyDirectory(dir, destDirName + Path.GetFileName(dir), textBox);
            }
        }

        private void cbTS185_CheckedChanged(object sender, EventArgs e)
        {
            btnBve5Start.Enabled = !cbTS185.Checked;
            btnBve6Start.Enabled = !cbTS185.Checked;
        }

        private void cbOERMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOERMode.Checked)
            {
                cbLampYokusoku.Checked = false;
                cbLampHatsuden.Checked = false;
                cbLampSap.Checked = false;
                cbLampAts.Checked = false;
                cbLampAtsAlm.Checked = false;
                cbUnitDisp.Checked = false;
                cbPMode.Text = "D-ATS-P";
            }
            else
            {
                cbPMode.Text = "ATS-P";
                cbLampAts.Checked = true;
                cbLampAts.Checked = true;
            }

            cbLampOERAtt.Visible = cbOERMode.Checked;
            cbLampOERKaisei.Visible = cbOERMode.Checked;
            cbLampOERStop.Visible = cbOERMode.Checked;
            cbLampOERLight.Visible = cbOERMode.Checked;

            cbPDengen.Visible = !cbOERMode.Checked;
            cbPFree.Visible = !cbOERMode.Checked;
            cbPBroken.Visible = !cbOERMode.Checked;

            cbLampYokusoku.Visible = !cbOERMode.Checked;
            cbLampHatsuden.Visible = !cbOERMode.Checked;
            cbLampSap.Visible = !cbOERMode.Checked;
            cbLampAts.Visible = !cbOERMode.Checked;
            cbLampAtsAlm.Visible = !cbOERMode.Checked;
            cbUnitDisp.Visible = !cbOERMode.Checked;

            Disp();
        }

        private void cbOER1000Console_CheckedChanged(object sender, EventArgs e)
        {
            cbUnitDisp.Visible = !cbOER1000Console.Checked;
            if (cbOER1000Console.Checked)
            {
                cbUnitDisp.Checked = false;
            }
            string s = cbOER1000Console.Checked ? "2" : "0";
            CommandWrite("WR 180 " + s, true);
        }

        private void rbATS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbATS.Checked)
            {
                CommandWrite("WR 204 0", true);
                Settings.Default.rbATS = 0;
            }
        }

        private void rbATS2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbATS2.Checked)
            {
                CommandWrite("WR 204 3", true);
                Settings.Default.rbATS = 3;
            }
        }

        private void rbATS3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbATS3.Checked)
            {
                CommandWrite("WR 204 1", true);
                Settings.Default.rbATS = 1;
            }
        }

        private int Section_Mode = 0; //1:DC 2:AC 0:Section
        private string portNameDensei;
        private bool send_error = false;
        private bool flgSeldControllerFound = false;
        private bool flgFirstReadCheck = false;

        private void rbDC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDC.Checked)
            {
                CommandWrite("DC  1", true);
                Section_Mode = 1;
                Settings.Default.Section_Mode = Section_Mode;
            }
        }

        private void rbSection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSection.Checked)
            {
                if (Section_Mode == 1)
                {
                    CommandWrite("DC  0", true);
                }
                else if (Section_Mode == 2)
                {
                    CommandWrite("AC  0", true);
                }
                Section_Mode = 0;
                Settings.Default.Section_Mode = Section_Mode;
            }
        }

        private void rbAC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAC.Checked)
            {
                CommandWrite("AC  1", true);
                Section_Mode = 2;
                Settings.Default.Section_Mode = Section_Mode;
            }
        }

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            MessageBox.Show("切断");
        }

        private void btnReferenceChange_Click(object sender, EventArgs e)
        {
            // FolderBrowserDialogオブジェクトの生成
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                // フォルダを選択できるようにする
                fd.Description = "フォルダを選択してください";    //メッセージの指定
                fd.SelectedPath = destDirBveExPlugins;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    // 選択したフォルダ名を表示
                    destDirBveExPlugins = fd.SelectedPath;
                    tbPluginDirectory.Text = destDirBveExPlugins;
                    dllBveExPathInstall = destDirBveExPlugins + @"\2.0\Extensions\" + fileNameInstall;
                    dllAtsExPathInstall = destDirBveExPlugins + @"\Legacy\Extensions\" + fileNameInstall;

                    if (Directory.Exists(dllBveExPathInstall))
                    {
                        if (File.Exists(dllBveExPathInstall) && File.Exists(dllAtsExPathInstall))
                        {
                            btnPluginInstall.Text = "更新";
                            btnPluginUnInstall.Enabled = true;
                        }
                        else
                        {
                            btnPluginInstall.Text = "インストール";
                            btnPluginUnInstall.Enabled = false;
                        }
                    }
                    else
                    {
                        label107.Visible = true;
                        linkLabel1.Visible = true;
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://bveex.okaoka-depot.com/");
        }

        private void btnJreTsStart_Click_1(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/2111630");
        }

        private void cbInputFlip_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (cbAtsCont.Checked) n |= (1 << 0);
            if (cbAtsConf.Checked) n |= (1 << 1);
            if (cbAtsRec.Checked) n |= (1 << 2);
            if (cbEB.Checked) n |= (1 << 3);
            if (cbHorn1.Checked) n |= (1 << 4);
            if (cbHorn2.Checked) n |= (1 << 5);
            if (cbDecEB.Checked) n |= (1 << 6);
            if (!cbMeterCheck.Checked) n |= (1 << 7);

            CommandWrite("WR 074 " + n.ToString(), true);
            //Disp();
            Settings.Default.input_flip = n;
        }

        private void cbAtsConf_Click(object sender, EventArgs e)
        {
            tabControl1.Focus();
            int n = 0;
            if (cbAtsConf.Checked) n |= (1 << 0);
            if (cbxPanto.SelectedIndex == 1) n |= (1 << 1);
            if (cbxB1Dengen.SelectedIndex == 1) n |= (1 << 3);
            if (cbxATSDengen.SelectedIndex == 1) n |= (1 << 4);
            if (cbTransferEBState.Checked) n |= (1 << 5);
            if (cbBVEForceMode.Checked) n |= (1 << 6);

            btnATSDengenAngle.Enabled = (cbxATSDengen.SelectedIndex == 1);
            tbATSDengenAngle.Enabled = (cbxATSDengen.SelectedIndex == 1);

            CommandWrite("WR 076 " + n.ToString(), true);
            //Disp();
            Settings.Default.atsconf_flip = n;
        }

        private void cbAtsContactUse_Click(object sender, EventArgs e)
        {
            CommandWrite("WR 082 " + (cbAtsContactUse.Checked ? "1" : "0"), true);
            Settings.Default.AtsContactUse = cbAtsContactUse.Checked;
        }

        private void cbFVhold_CheckedChanged(object sender, EventArgs e)
        {
            string s = cbFVhold.Checked ? "1" : "0";
            tbFVMax.Enabled = !cbFVhold.Checked;
            tbFVMin.Enabled = !cbFVhold.Checked;
            tbFVPressMax.Enabled = !cbFVhold.Checked;
            tbFVPressMin.Enabled = !cbFVhold.Checked;
            CommandWrite("WR 156 " + s, true);
            Settings.Default.cbFVhold = cbFVhold.Checked;
        }

        /*// ユーザー入力用のメソッド
        private static string Prompt(string text)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(text, "入力", "");
            return input;
        }*/

        // DeviceIDから指定されたキー (VID_ または PID_) の値を抽出するメソッド
        private static string ExtractValue(string deviceId, string key)
        {
            int startIndex = deviceId.IndexOf(key);
            if (startIndex >= 0)
            {
                startIndex += key.Length; // キーの長さを加算して値の開始位置を取得
                int endIndex = deviceId.IndexOf('&', startIndex); // 次の区切り文字 '&' を探す
                if (endIndex >= 0)
                {
                    return deviceId.Substring(startIndex, endIndex - startIndex);
                }
                else
                {
                    return deviceId.Substring(startIndex); // '&' が見つからない場合は最後まで取得
                }
            }
            return null; // キーが見つからない場合
        }

        private void btnFirmUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr_org = DialogResult.OK;
            DialogResult dr = DialogResult.Cancel;

            if (!flgSeldControllerFound)
            {
                MessageBox.Show("初回書込みまたは指定したポートが異なる可能性があります。");
            }
            if (!File.Exists(tbHexFilePathC.Text))
            {
                dr_org = MessageBox.Show("ファームウェアのバックアップファイルが存在しません、続行しますか？", "確認", MessageBoxButtons.OKCancel);
            }
            if (File.Exists(tbHexFilePathC.Text) && dr_org.Equals(DialogResult.OK))
            {
                dr = MessageBox.Show("ファームウェアの書き込みを開始します。", "確認", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("書き込むファイルが正しくありません、指定しなおしてください。");
            }
            if (dr.Equals(DialogResult.OK))
            {
                ArduinoFinder(out bool found);
                if (found)
                {
                    AvrWriter_32u4("write", "flash", "ファームウェアの書き込み", hexFilePath);
                }
            }
        }

        private void btnHexFileChange_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdHexFileChange = new OpenFileDialog())
            {
                ofdHexFileChange.Title = "HEXファイルを選択してください";
                ofdHexFileChange.Filter = "HEXファイル (*.hex)|*.hex|BAKファイル (*.bak)|*.bak";
                ofdHexFileChange.InitialDirectory = tbHexFilePathC.Text;

                if (ofdHexFileChange.ShowDialog() == DialogResult.OK)
                {
                    // 選択されたファイルパスをラベルに表示
                    tbHexFilePathC.Text = $"{ofdHexFileChange.FileName}";
                    // アプリケーションの実行ディレクトリを基準とする
                    string basePath = AppDomain.CurrentDomain.BaseDirectory;

                    // 相対パスを計算
                    string relativePath = GetRelativePath(basePath, ofdHexFileChange.FileName);
                    hexFilePath = relativePath;
                }
            }
        }
        private string GetRelativePath(string basePath, string absolutePath)
        {
            Uri baseUri = new Uri(basePath);
            Uri absoluteUri = new Uri(absolutePath);
            Uri relativeUri = baseUri.MakeRelativeUri(absoluteUri);

            // Windows用にスラッシュをバックスラッシュに変換
            return Uri.UnescapeDataString(relativeUri.ToString()).Replace('/', '\\');
        }

        private void llArduinoIde_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llArduinoIde.LinkVisited = true;
            Process.Start("http://www.arduino.cc/en/software/");
        }

        private void btnFirmRoad_Click(object sender, EventArgs e)
        {
            // 仮のバージョン変数（実際には既に取得済みの変数名に置き換えてください）
            string currentVersion = C_VERSION_NUM;

            // 1. パスを安全に結合してバックアップ先のフルパスを作成
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // 実行ファイルの場所 (bin等)

            string bakFilePath = Path.Combine(
                baseDir,
                "bin",
                "SELDController",
                currentVersion, // ← ここが変数になります
                "SELDController",
                "build",
                "arduino.avr.micro",
                "SELDController.ino.hex.bak"
            );

            // 2. ディレクトリの存在チェックと自動作成（フォルダがない場合のエラー防止）
            string directoryPath = Path.GetDirectoryName(bakFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // 3. 事前確認（ファイルが存在する場合は上書き確認、ない場合は開始確認）
            if (File.Exists(bakFilePath))
            {
                if (MessageBox.Show("バックアップが既に存在します。上書きして続行しますか？", "確認", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("ファームウェアのバックアップを開始します。", "確認", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }

            // 4. デバイスの接続確認
            ArduinoFinder(out bool found);
            if (!found)
            {
                MessageBox.Show("Arduinoが見つかりませんでした。接続を確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. バックアップ処理の実行
            AvrWriter_32u4("read", "flash", "ファームウェアのバックアップ", bakFilePath);
        }

        private void ArduinoFinder(out bool found)
        {
            found = false;
            bool flgDriverinstall = false;
            // ユーザーにCOMポート番号を入力させる
            //string targetComPort = Prompt("COMポート番号を入力してください (例: COM3): ");
            string targetComPort = serialPortMain.PortName;
            if (string.IsNullOrEmpty(targetComPort))
            {
                MessageBox.Show("COMポート番号が無効です。終了します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            targetComPort = targetComPort.ToUpper();

            // WMIクエリでCOMポート情報を取得
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity"))
            {
                foreach (var device in searcher.Get())
                {
                    string name = device["Name"]?.ToString();
                    string deviceId = device["DeviceID"]?.ToString();

                    // 指定されたCOMポート番号を含むデバイスを検索
                    if (!string.IsNullOrEmpty(name) && name.Contains(targetComPort))
                    {

                        // PIDとVIDを抽出
                        if (!string.IsNullOrEmpty(deviceId))
                        {
                            string vid = ExtractValue(deviceId, "VID_");
                            string pid = ExtractValue(deviceId, "PID_");

                            if (vid == "2341" && pid == "8037")
                            {
                                //Arduinoが認識されているかを判別
                                if (name.StartsWith("Arduino"))
                                {
                                    llArduinoIde.Visible = false;
                                    lblArduinoInstall.Visible = false;
                                    found = true;
                                }
                                else
                                {
                                    MessageBox.Show("Arduino Microを認識しましたが、ドライバが見つかりません。\n\nArduino IDEをインストールしてください。");
                                    llArduinoIde.Visible = true;                                    
                                    lblArduinoInstall.Visible = true;
                                    btnDriverInstall.Visible = true;
                                    flgDriverinstall = true;
                                    DriverInstall();
                                }
                            }

                        }
                    }
                }

                if (!found && !flgDriverinstall)
                {
                    MessageBox.Show("Arduino Microではないため接続ができません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void DriverInstall()
        {
            DialogResult dr = MessageBox.Show("ドライバをインストールしますか？", "確認", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string driverPath64 = @".\hardware\avr\1.8.6\drivers\dpinst-amd64.exe";
                string driverPath32 = @".\hardware\avr\1.8.6\drivers\dpinst-x86.exe";
                DriverInstallMethod(Environment.Is64BitProcess ? driverPath64 : driverPath32);
            }
        }

        private static void DriverInstallMethod(string driverPath)
        {
            if (File.Exists(driverPath))
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = driverPath;
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.Verb = "runas"; // 管理者権限で実行
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();

                    //process.WaitForExit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"エラーが発生しました: {ex.Message}", "例外", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show("ドライバが見つかりませんでした");
            }
        }

        private void btnEepromRoad_Click(object sender, EventArgs e)
        {
            // 仮のバージョン変数（実際には既に取得済みの変数名に置き換えてください）
            string currentVersion = C_VERSION_NUM;

            // 1. パスを安全に結合してバックアップ先のフルパスを作成
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // 実行ファイルの場所 (bin等)

            string bakFilePath = Path.Combine(
                baseDir,
                "bin",
                "SELDController",
                currentVersion, // ← ここが変数になります
                "SELDController",
                "build",
                "arduino.avr.micro",
                "SELDController.ino.bin"
            );

            // 2. ディレクトリの存在チェックと自動作成（フォルダがない場合のエラー防止）
            string directoryPath = Path.GetDirectoryName(bakFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            DialogResult dr = MessageBox.Show("EEPROM設定値の読み出しを開始します。", "確認", MessageBoxButtons.OKCancel);
            if (dr.Equals(DialogResult.OK))
            {
                ArduinoFinder(out bool found);
                if (found)
                {
                    AvrWriter_32u4("read", "eeprom", "EEPROM設定値読み出し", bakFilePath);
                }
            }
        }

        private void btnEepromWrite_Click(object sender, EventArgs e)
        {
            DialogResult dr_org = DialogResult.Cancel;
            DialogResult dr = DialogResult.Cancel;
            if (!File.Exists(tbBinFilePathC.Text))
            {
                dr_org = MessageBox.Show("EEPROM設定値ファイルが存在しません", "確認", MessageBoxButtons.OK);
            }
            if (dr_org.Equals(DialogResult.Cancel))
            {
                dr = MessageBox.Show("EEPROM設定値の書き込みを開始します。", "確認", MessageBoxButtons.OKCancel);
            }
            if (dr.Equals(DialogResult.OK))
            {
                ArduinoFinder(out bool found);
                if (found)
                {
                    AvrWriter_32u4("write", "eeprom", "EEPROM設定値書き込み", tbBinFilePathC.Text);
                }
            }
        }

        // avrdudeのパスと設定
        private string avrdudePath = @".\avrdude\avrdude.exe"; // avrdude.exeのパス

        private void AvrWriter_32u4(string read_or_write, string flash_or_eeprom, string contents, string filepath)
        {

            string configPath = @".\avrdude\avrdude.conf"; // avrdude.confのパス
            string mcu = "atmega32u4"; // マイコンの種類

            //読み出し時のVIDとPID
            string targetVid = "VID_2341"; // 例: ベンダーID
            string targetPid = "PID_0037"; // 例: プロダクトID

            //Regex regexPortName = new Regex(@"(COM\d+)");
            //string portName = regexPortName.Match(cbPortSelect.SelectedItem.ToString()).Groups[1].ToString();

            serialPort1Close();

            // 1200bpsタッチでリセット
            try
            {
                serialPortMain.BaudRate = 1200;
                serialPortMain.DtrEnable = true; // 強制リセットにはDTRが必要な場合があります
                serialPortMain.Open();
                Thread.Sleep(100);
                serialPortMain.Close();
            }
            catch { /* 既に閉じている等のエラーは無視 */ }

            // ★修正ポイント：ブートローダーが立ち上がるまで待機＆リトライ
            string foundPort = null;
            int retryCount = 0;
            while (retryCount < 20 && foundPort == null) // 最大約10秒待機
            {
                Thread.Sleep(500);
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%)'"))
                {
                    foreach (ManagementObject device in searcher.Get())
                    {
                        string deviceId = device["DeviceID"]?.ToString() ?? "";
                        string name = device["Name"]?.ToString() ?? "";

                        if (deviceId.Contains(targetVid) && deviceId.Contains(targetPid))
                        {
                            var match = Regex.Match(name, @"(COM\d+)");
                            if (match.Success)
                            {
                                foundPort = match.Value;
                                break;
                            }
                        }
                    }
                }
                retryCount++;
            }

            if (foundPort == null)
            {
                MessageBox.Show("ブートローダーポートが見つかりませんでした。");
                return;
            }

            // avrdudeコマンドの引数
            string strflash = (flash_or_eeprom == "flash") ? "flash" : "eeprom";
            string strwrite = (read_or_write == "write") ? "w" : "r";
            // avrdude実行 (foundPortを使用)
            string arguments = $"-C \"{configPath}\" -v -p{mcu} -c avr109 -P{foundPort} -b 57600 -D -U {strflash}:{strwrite}:\"{filepath}\":i";


            try
            {
                // Processを使ってavrdudeを実行
                Process process = new Process();
                process.StartInfo.FileName = avrdudePath;
                process.StartInfo.Arguments = arguments;

                // 出力を横取りせず、そのままコンソールに流す
                process.StartInfo.RedirectStandardOutput = false;
                process.StartInfo.RedirectStandardError = false;

                // 黒い画面（コンソール）を表示する
                process.StartInfo.UseShellExecute = true; // cmd.exe経由で実行
                process.StartInfo.CreateNoWindow = false; // ウィンドウを作成する

                process.Start();

                // 標準出力とエラー出力を取得
                //string output = process.StandardOutput.ReadToEnd();
                //string error = process.StandardError.ReadToEnd();

                // ★追加：メインフォームを最前面にアクティブ化する
                /*this.Invoke((MethodInvoker)delegate {
                    this.Activate(); // フォームを前面に持ってくる
                    this.Focus();    // フォーカスを当てる
                });*/
                process.WaitForExit();

                // 結果をMessageBoxで表示
                if (process.ExitCode == 0)
                {
                    // output は取得できないので、成功メッセージのみ表示
                    MessageBox.Show(this, contents + "に成功しました！\n\n再度シリアル通信接続を開始してください。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    setSerialComboBox(cbPortSelect, null);
                    serialPortMain.BaudRate = 115200;
                    serialPortMain.DtrEnable = true;
                }
                else
                {
                    // error も取得できないため、ユーザーにコンソールを確認するよう促す
                    MessageBox.Show(contents + "に失敗しました。\n\n詳細は表示された黒い画面（コンソール）を確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"エラーが発生しました: {ex.Message}", "例外", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirmDirOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // フォルダをエクスプローラで開く
                Process.Start("explorer.exe", Path.GetDirectoryName(tbHexFilePathC.Text));
            }
            catch (Exception ex)
            {
                // エラーが発生した場合の処理
                MessageBox.Show("フォルダを開く際にエラーが発生しました:" + ex.Message);
            }
        }

        private void btnBveExDirOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // フォルダをエクスプローラで開く
                Process.Start("explorer.exe", tbPluginDirectory.Text);
            }
            catch (Exception ex)
            {
                // エラーが発生した場合の処理
                MessageBox.Show("フォルダを開く際にエラーが発生しました:"+ ex.Message);
            }
        }

        private void btnDriverInstall_Click(object sender, EventArgs e)
        {
            DriverInstall();
        }

        private void cbPortSelectDensei_MouseHover(object sender, EventArgs e)
        {
            setSerialComboBox(cbPortSelectDensei, Settings.Default.portNameDensei);
        }

        private void btnOpenDensei_Click(object sender, EventArgs e)
        {
            if (btnSerialPortOpenDensei.Text == "通信開始")
            {
                serialPortDenseiOpen();
            }
            else
            {
                serialPortDenseiClose();
            }

        }

        private void serialPortDenseiClose()
        {
            Settings.Default.portNameDensei = cbPortSelectDensei.SelectedText;
            if (serialPortDensei.IsOpen)
            {
                Settings.Default.portNameDensei = serialPortDensei.PortName;
                serialPortDensei.DiscardInBuffer();
                serialPortDensei.DiscardOutBuffer();
                serialPortDensei.Close();
            }
            cbPortSelectDensei.Enabled = true;
            setSerialComboBox(cbPortSelectDensei, Settings.Default.portNameDensei);
            portNameDensei = serialPortDensei.PortName;
            btnSerialPortOpenDensei.Text = "通信開始";
            btnSerialPortOpenDensei.Enabled = true;
        }

        private void serialPortDenseiOpen()
        {
            if (cbPortSelectDensei.Items.Count > 0)
            {
                try
                {
                    Regex regexPortName = new Regex(@"(COM\d+)");
                    string portName = regexPortName.Match(cbPortSelectDensei.SelectedItem.ToString()).Groups[1].ToString();
                    serialPortDensei.PortName = portName;
                    serialPortDensei.BaudRate = 115200; //int.Parse(comboBoxSerialPort1BauRate.Text);//115200;
                    serialPortDensei.DtrEnable = true;
                    serialPortDensei.Open();
                    MessageBox.Show("hit");
                    btnOpenDensei.Text = "通信停止";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    if (serialPortDensei.IsOpen)
                    {
                        serialPortDensei.Close();
                    }
                }
            }
        }

        private void cbKaisei_Click(object sender, EventArgs e)
        {
            string s = cbKaisei.Checked ? "1" : "0";
            CommandWrite("WR 046 " + s, true);
            Settings.Default.mtr_kaisei = cbKaisei.Checked;
        }

        private void btnBPMaxSet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("BP圧力が490kPaに到達していることを確認してください", "確認", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                tbBPMax.Text = tbBP_V.Text;
                btnBPMax_Click(sender, e);
            }
        }

        private void btnFVMaxSet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("FV圧力が490kPaに到達していることを確認してください", "確認", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                tbFVMax.Text = tbFV_V.Text;
                btnFVMax_Click(sender, e);
            }
        }

        private void btnBPMinSet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("BP圧力が0kPaまで減圧していることを確認してください", "確認", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                tbBPMin.Text = tbBP_V.Text;
                btnBPMin_Click(sender, e);
            }
        }

        private void btnFVMinSet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("FV圧力が0kPaまで減圧していることを確認してください", "確認", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                tbFVMin.Text = tbFV_V.Text;
                btnFVMin_Click(sender, e);
            }
        }

        public void Intervene(string message)
        {
            using (var client = new NamedPipeClientStream(".", "SeldExIntervention", PipeDirection.Out))
            {
                try
                {
                    client.Connect(1000); // タイムアウトを1秒に延長
                    using (var writer = new StreamWriter(client))
                    {
                        writer.WriteLine(message); // 改行付きで送る（AのReadLineに対応）
                        writer.Flush();
                    }
                }
                catch (Exception ex)
                {
                    // 接続に失敗した場合はここにMessageBoxを出して確認
                    MessageBox.Show("Pipe Connect Error: " + ex.Message);
                }
            }
        }

        // 使い方:
        // Intervene("WRITE:H10"); // プラグイン経由でシリアルポートに "H10" を送る
        // Intervene("CLOSE");     // プラグインのポートを閉じさせる

        private void StartMonitoring()
        {
            monitorTimer = new System.Timers.Timer(500); // 2秒おきに監視
            monitorTimer.Elapsed += (s, e) => {
                // いずれかの名前が一致すればOKとする
                var processes = Process.GetProcesses().Where(p =>
                    p.ProcessName.Contains("BveTs") ||
                    p.ProcessName.Contains("BveTrainsim")).ToArray();
                bool currentlyRunning = processes.Length > 0;

                if (currentlyRunning && !isBveRunning)
                {
                    // BVEが起動した瞬間：自分のポートを閉じる
                    isBveRunning = true;
                    this.Invoke((MethodInvoker)delegate
                    {
                        serialPort1Close();
                        toolStripStatusLabel1.Text = "BVE起動検知";
                        Debug.WriteLine("BVE起動検知");
                    });
                }
                else if (!currentlyRunning && isBveRunning)
                {
                    // BVEが終了した瞬間：自分のポートを復帰させる
                    isBveRunning = false;
                    this.Invoke((MethodInvoker)delegate {
                        // 作成された関数を呼び出してポートを再オープン
                        serialPort1Open();
                        toolStripStatusLabel1.Text = "BVE終了検知：" + serialPortMain.PortName;
                        Debug.WriteLine("BVE終了検知");
                    });
                }
            };
            monitorTimer.Start();
        }
        // アプリBのロード時などに実行
        private void InitialCheck()
        {
            // いずれかの名前が一致すればOKとする
            var processes = Process.GetProcesses().Where(p =>
                p.ProcessName.Contains("BveTs") ||
                p.ProcessName.Contains("BveTrainsim")).ToArray();
            if (processes.Length > 0)
            {
                isBveRunning = true;
                this.Invoke((MethodInvoker)delegate { serialPort1Close(); });
            }
        }

        private void timerDispBoardFinder_Tick(object sender, EventArgs e)
        {
            timerDispBoardFinder.Stop();
            tsmiDispBoard.Checked = false;
            tbDispBoardVersion.Text = "未接続";
            board_Disp = false;
        }

        private void timerATSPBoardFinder_Tick(object sender, EventArgs e)
        {
            timerATSPBoardFinder.Stop();
            tsmiATSPBoard.Checked = false;
            tbATSPBoardVersion.Text = "未接続";
            board_ATSP = false;
        }

        // データの送信処理（アプリB内のどこか）
        public void SendData(string data)
        {
            if (isBveRunning)
            {
                // BVEが動いているなら、アプリA（プラグイン）のパイプへ送る
                Intervene($"WRITE:{data}");
            }
            else
            {
                // 通常時は自分のポートで送る
                if (serialPortMain.IsOpen) serialPortMain.WriteLine(data);
            }
        }

        private void btnATSDengenAngle_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbATSDengenAngle.Text, out int num);
            if ((num >= 0) && (num <= 360))
            {
                CommandWrite("WR 084 " + num, true);
                Settings.Default.brk_ats_dengen_angl = tbATSDengenAngle.Text;
            }
            else
            {
                MessageBox.Show("角度設定の範囲外です(0～360°)");
            }
        }

        private void serialPortChecker_Tick(object sender, EventArgs e)
        {
            setSerialComboBox(cbPortSelect, Settings.Default.portName);
        }

        private void tbAdjN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                AdjN();
            }
        }

        private void AdjN()
        {
            CommandWrite("WR 000 " + tbAdjN.Text, true);
            Settings.Default.adj_N = tbAdjN.Text;
        }

        private void tbAdjEB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdjEB();
            }
        }

        private void AdjEB()
        {
            CommandWrite("WR 002 " + tbAdjEB.Text, true);
            Settings.Default.adj_EB = tbAdjEB.Text;
        }

        private void cbVersionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVersionListCHex.SelectedItem == null) return;

            // 選択された文字列（例: "4.2.3.10" または "4.2.3.10 (backup)"）
            string selectedItemText = cbVersionListCHex.SelectedItem.ToString();

            // バックアップかどうかの判定フラグ
            bool isBackup = selectedItemText.Contains("(backup)");

            // パス検索用のバージョン文字列を抽出（(backup) があれば削除する）
            string selectedVersion = selectedItemText.Replace(" (backup)", "").Trim();

            // メンバー変数 searchedFiles から該当するバージョンが含まれるパスを検索
            string targetPath = searchedFiles.FirstOrDefault(f => f.Contains($@"\{selectedVersion}\"));

            if (targetPath != null)
            {
                // バックアップが選択されている場合、パスの末尾に .bak を付加する
                // ※すでに targetPath の末尾が .bak の場合は重複しないようチェック
                if (isBackup && !targetPath.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                {
                    targetPath += ".bak";
                }
                // 逆に通常版が選択されているのにパス末尾が .bak の場合は除去する
                else if (!isBackup && targetPath.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                {
                    targetPath = targetPath.Substring(0, targetPath.Length - 4);
                }

                string absolutePath = Path.GetFullPath(targetPath);
                tbHexFilePathC.Text = absolutePath;
                hexFilePath = targetPath;
            }
        }

        private void cbVersionListCBin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVersionListCBin.SelectedItem == null) return;

            // 選択された文字列（例: "4.2.3.10" または "4.2.3.10 (backup)"）
            string selectedItemText = cbVersionListCBin.SelectedItem.ToString();

            // バックアップかどうかの判定フラグ
            bool isBackup = selectedItemText.Contains("(backup)");

            // パス検索用のバージョン文字列を抽出（(backup) があれば削除する）
            string selectedVersion = selectedItemText.Replace(" (backup)", "").Trim();

            // メンバー変数 searchedFiles から該当するバージョンが含まれるパスを検索
            string targetPath = searchedFiles.FirstOrDefault(f => f.Contains($@"\{selectedVersion}\"));

            if (targetPath != null)
            {
                // バックアップが選択されている場合、パスの末尾に .bak を付加する
                // ※すでに targetPath の末尾が .bak の場合は重複しないようチェック
                if (isBackup && !targetPath.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                {
                    targetPath += ".bak";
                }
                // 逆に通常版が選択されているのにパス末尾が .bak の場合は除去する
                else if (!isBackup && targetPath.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                {
                    targetPath = targetPath.Substring(0, targetPath.Length - 4);
                }

                string absolutePath = Path.GetFullPath(targetPath);
                tbBinFilePathC.Text = absolutePath;
                hexFilePath = targetPath;
            }
        }

        private void btnFirmDirOpenBin_Click(object sender, EventArgs e)
        {
            try
            {
                // フォルダをエクスプローラで開く
                Process.Start("explorer.exe", Path.GetDirectoryName(tbBinFilePathC.Text));
            }
            catch (Exception ex)
            {
                // エラーが発生した場合の処理
                MessageBox.Show("フォルダを開く際にエラーが発生しました:" + ex.Message);
            }
        }

        private void btnBinFileChange_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdHexFileChange = new OpenFileDialog())
            {
                ofdHexFileChange.Title = "BINファイルを選択してください";
                ofdHexFileChange.Filter = "BINファイル (*.bin)|*.bin";
                ofdHexFileChange.InitialDirectory = tbBinFilePathC.Text;

                if (ofdHexFileChange.ShowDialog() == DialogResult.OK)
                {
                    // 選択されたファイルパスをラベルに表示
                    tbBinFilePathC.Text = $"{ofdHexFileChange.FileName}";
                    // アプリケーションの実行ディレクトリを基準とする
                    string basePath = AppDomain.CurrentDomain.BaseDirectory;

                    // 相対パスを計算
                    string relativePath = GetRelativePath(basePath, ofdHexFileChange.FileName);
                    hexFilePath = relativePath;
                }
            }
        }

        private void tbATSDengenAngle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnATSDengenAngle_Click(sender, e);
            }
        }

        private void tbAtsPDengenTounyuTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAtsPDengenTounyuTime_Click(sender, e);
            }
        }

        private void btnAtsPDengenTounyuTime_Click(object sender, EventArgs e)
        {
            if (board_Disp)
            {
                double.TryParse(tbAtsPDengenTounyuTime.Text, out double d);
                Settings.Default.AtsPDengenTounyuTime = (int)(d * 1000);
                CommandWrite("WR 208 " + (int)(d * 1000), true);
            }
        }

        private void cbAtsActiveMode_Click(object sender, EventArgs e)
        {
            int n  = cbAtsActiveMode.Checked ? 1 : 0;
            CommandWrite("WR 122 " + n.ToString(), true);
            Settings.Default.AtsActiveMode = n;
        }

        // DataGridView 更新メソッド
        private void RefreshDataGridView()
        {
            // 1. 数値としてパースできるかどうかでブレイクダウンしてソート
            var sortedList = paramList
                .OrderBy(p => !int.TryParse(p.Num, out _)) // まず数値(false=0)を前に、文字列(true=1)を後ろにする
                .ThenBy(p => int.TryParse(p.Num, out int num) ? num : 0) // 数値同士をソート
                .ThenBy(p => p.Num) // 文字列同士を五十音・アルファベット順でソート
                .ToList();

            // 2. データの再バインド
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sortedList;

            // 3. 1列目と3列目を中央揃えに設定（インデックスは 0 から始まります）
            if (dataGridView1.Columns.Count >= 3)
            {
                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 4. 列幅の自動調整
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // XML に出力するメソッド
        private void SaveParamListToXml(string filePath)
        {
            try
            {
                // XmlSerializerオブジェクトを作成
                XmlSerializer serializer = new XmlSerializer(typeof(List<ParamData>));

                // ファイルを開く（UTF-8 BOM無し）
                using (StreamWriter writer = new StreamWriter(filePath, false, new UTF8Encoding(false)))
                {
                    // paramListをシリアル化してXMLファイルに保存
                    serializer.Serialize(writer, paramList);
                }

                MessageBox.Show("paramList を XML に保存しました\n" + filePath, "保存完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML保存エラー: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // XML から読み込むメソッド
        private void LoadParamListFromXml(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("ファイルが見つかりません: " + filePath, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // XmlSerializerオブジェクトを作成
                XmlSerializer serializer = new XmlSerializer(typeof(List<ParamData>));

                // ファイルを開いてXMLから逆シリアル化
                using (StreamReader reader = new StreamReader(filePath, new UTF8Encoding(false)))
                {
                    List<ParamData> loadedList = (List<ParamData>)serializer.Deserialize(reader);

                    if (loadedList != null)
                    {
                        paramList.Clear();
                        paramList.AddRange(loadedList);

                        // 各ParamDataを処理して read_Settings() を呼び出す
                        foreach (ParamData param in loadedList)
                        {
                            try
                            {
                                // Num が3文字であることを確認
                                string numStr = param.Num.PadLeft(3, '0');  // 不足分を0で埋める

                                // "OK Num Data" の形式で文字列を構築
                                string data_all_ = $"OK {numStr} {param.Data}";
                                string data_ = data_all_;

                                // read_Settings() を呼び出す
                                read_Settings(data_all_, data_);

                                tbLog.AppendText($"読込: {data_all_}\r\n");
                            }
                            catch (Exception itemEx)
                            {
                                tbLog.AppendText($"エラー [{param.Num}]: {itemEx.Message}\r\n");
                            }
                        }

                        // DataGridViewを更新
                        RefreshDataGridView();

                        MessageBox.Show("paramList を XML から読み込みました\n" + filePath, "読込完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML読込エラー: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 保存ボタン
        private void btnSaveParamXml_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "paramList を XML 形式で保存";
                saveDialog.Filter = "XML ファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.*";
                saveDialog.FileName = "ParamData.xml";
                saveDialog.InitialDirectory = Application.StartupPath;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveParamListToXml(saveDialog.FileName);
                }
            }
        }

        // 読込ボタン
        private void btnLoadParamXml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "paramList を XML ファイルから読み込み";
                openDialog.Filter = "XML ファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.*";
                openDialog.InitialDirectory = Application.StartupPath;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadParamListFromXml(openDialog.FileName);
                    btnSaveParamXml.Enabled = true;
                }
            }
        }
    }
}