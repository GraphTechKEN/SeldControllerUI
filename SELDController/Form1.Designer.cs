using System;

namespace SELDController
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.基板設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプション基板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDispBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiATSPBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSerialRcv = new System.Windows.Forms.TextBox();
            this.btnSerialPortOpen = new System.Windows.Forms.Button();
            this.cbPortSelect = new System.Windows.Forms.ComboBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.messageTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPortMain = new System.IO.Ports.SerialPort(this.components);
            this.btn010 = new System.Windows.Forms.Button();
            this.btn020 = new System.Windows.Forms.Button();
            this.btn030 = new System.Windows.Forms.Button();
            this.btn040 = new System.Windows.Forms.Button();
            this.btn050 = new System.Windows.Forms.Button();
            this.btn060 = new System.Windows.Forms.Button();
            this.btn070 = new System.Windows.Forms.Button();
            this.btn080 = new System.Windows.Forms.Button();
            this.btn090 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn110 = new System.Windows.Forms.Button();
            this.btn120 = new System.Windows.Forms.Button();
            this.btn130 = new System.Windows.Forms.Button();
            this.btn140 = new System.Windows.Forms.Button();
            this.btn150 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbBrakeCount = new System.Windows.Forms.TextBox();
            this.tbRev = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbMcCount = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.tbEm = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbComma = new System.Windows.Forms.TextBox();
            this.tbDown = new System.Windows.Forms.TextBox();
            this.tbUp = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbHorn2 = new System.Windows.Forms.TextBox();
            this.tbAtsCont = new System.Windows.Forms.TextBox();
            this.tbHorn1 = new System.Windows.Forms.TextBox();
            this.tbAtsConf = new System.Windows.Forms.TextBox();
            this.tbEB = new System.Windows.Forms.TextBox();
            this.tbAtsRec = new System.Windows.Forms.TextBox();
            this.gbBCTop = new System.Windows.Forms.GroupBox();
            this.gbBC = new System.Windows.Forms.GroupBox();
            this.tbBC = new System.Windows.Forms.TextBox();
            this.lblTbarBC500 = new System.Windows.Forms.Label();
            this.lblBCkPa = new System.Windows.Forms.Label();
            this.lblTbarBC0 = new System.Windows.Forms.Label();
            this.tbarBc = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBpEvac = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.rbAC = new System.Windows.Forms.RadioButton();
            this.rbDC = new System.Windows.Forms.RadioButton();
            this.rbSection = new System.Windows.Forms.RadioButton();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.rbATS3 = new System.Windows.Forms.RadioButton();
            this.rbATS = new System.Windows.Forms.RadioButton();
            this.rbATS2 = new System.Windows.Forms.RadioButton();
            this.cbLampOERLight = new System.Windows.Forms.CheckBox();
            this.cbLampOERKaisei = new System.Windows.Forms.CheckBox();
            this.label56 = new System.Windows.Forms.Label();
            this.cbLampOERStop = new System.Windows.Forms.CheckBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbLampOERAtt = new System.Windows.Forms.CheckBox();
            this.rbPWest = new System.Windows.Forms.RadioButton();
            this.cbAtsDengenMode = new System.Windows.Forms.CheckBox();
            this.cbDoor = new System.Windows.Forms.CheckBox();
            this.cbOER1000Console = new System.Windows.Forms.CheckBox();
            this.cbOERMode = new System.Windows.Forms.CheckBox();
            this.rbPEast = new System.Windows.Forms.RadioButton();
            this.pnlDisp = new System.Windows.Forms.Panel();
            this.tbUnitNum = new System.Windows.Forms.TextBox();
            this.cbLampSap = new System.Windows.Forms.CheckBox();
            this.cbLampHatsuden = new System.Windows.Forms.CheckBox();
            this.cbLampYokusoku = new System.Windows.Forms.CheckBox();
            this.cbLampAts = new System.Windows.Forms.CheckBox();
            this.cbLampAtsAlm = new System.Windows.Forms.CheckBox();
            this.cbUnit4 = new System.Windows.Forms.CheckBox();
            this.cbUnit3 = new System.Windows.Forms.CheckBox();
            this.cbUnit2 = new System.Windows.Forms.CheckBox();
            this.cbUnitDisp = new System.Windows.Forms.CheckBox();
            this.cbUnit1 = new System.Windows.Forms.CheckBox();
            this.cbLampEb = new System.Windows.Forms.CheckBox();
            this.tbAtsPDengenTounyuTime = new System.Windows.Forms.TextBox();
            this.pnlATSP = new System.Windows.Forms.Panel();
            this.cbPBreak = new System.Windows.Forms.CheckBox();
            this.cbPFree = new System.Windows.Forms.CheckBox();
            this.cbAtsPDengenAuto = new System.Windows.Forms.CheckBox();
            this.cbPBroken = new System.Windows.Forms.CheckBox();
            this.cbPMode = new System.Windows.Forms.CheckBox();
            this.cbPPettern = new System.Windows.Forms.CheckBox();
            this.cbPDengen = new System.Windows.Forms.CheckBox();
            this.tbAtsSDengenTounyuTime = new System.Windows.Forms.TextBox();
            this.btnSpdSave = new System.Windows.Forms.Button();
            this.btnSpdRead = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTbarMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSpdSetSave = new System.Windows.Forms.Button();
            this.btnSpdSetRead = new System.Windows.Forms.Button();
            this.tbarSpdTest = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpdTest = new System.Windows.Forms.TextBox();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.btnSpdTest = new System.Windows.Forms.Button();
            this.btnLimit = new System.Windows.Forms.Button();
            this.btn160 = new System.Windows.Forms.Button();
            this.tb160 = new System.Windows.Forms.TextBox();
            this.tb120 = new System.Windows.Forms.TextBox();
            this.tb080 = new System.Windows.Forms.TextBox();
            this.tb040 = new System.Windows.Forms.TextBox();
            this.tb150 = new System.Windows.Forms.TextBox();
            this.tb110 = new System.Windows.Forms.TextBox();
            this.tb070 = new System.Windows.Forms.TextBox();
            this.tb030 = new System.Windows.Forms.TextBox();
            this.tb140 = new System.Windows.Forms.TextBox();
            this.tb100 = new System.Windows.Forms.TextBox();
            this.tb060 = new System.Windows.Forms.TextBox();
            this.tb130 = new System.Windows.Forms.TextBox();
            this.tb020 = new System.Windows.Forms.TextBox();
            this.tb090 = new System.Windows.Forms.TextBox();
            this.tb050 = new System.Windows.Forms.TextBox();
            this.tb010 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbarCurrentTest = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.rbVolt = new System.Windows.Forms.RadioButton();
            this.rbCurrent = new System.Windows.Forms.RadioButton();
            this.cbKaisei = new System.Windows.Forms.CheckBox();
            this.tbOhm = new System.Windows.Forms.TextBox();
            this.tbCurrentTest = new System.Windows.Forms.TextBox();
            this.btnOhm = new System.Windows.Forms.Button();
            this.btnCurrentTest = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbBVEForceMode = new System.Windows.Forms.CheckBox();
            this.cbTransferEBState = new System.Windows.Forms.CheckBox();
            this.cbAtsActiveMode = new System.Windows.Forms.CheckBox();
            this.btnATSDengenAngle = new System.Windows.Forms.Button();
            this.tbATSDengenAngle = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.cbxATSDengen = new System.Windows.Forms.ComboBox();
            this.label111 = new System.Windows.Forms.Label();
            this.lblPanto = new System.Windows.Forms.Label();
            this.cbMeterCheck = new System.Windows.Forms.CheckBox();
            this.cbxB1Dengen = new System.Windows.Forms.ComboBox();
            this.cbxPanto = new System.Windows.Forms.ComboBox();
            this.cbAtsContactUse = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblBrkNotch = new System.Windows.Forms.Label();
            this.cbPotMode = new System.Windows.Forms.CheckBox();
            this.cbModeN = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnMcNumMax = new System.Windows.Forms.Button();
            this.btnMcNum = new System.Windows.Forms.Button();
            this.tbMcNumMax = new System.Windows.Forms.TextBox();
            this.tbMcNum = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblAutoNotch = new System.Windows.Forms.Label();
            this.cbxAutoNotch = new System.Windows.Forms.ComboBox();
            this.btnAdjEB = new System.Windows.Forms.Button();
            this.btnAdjN = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.lblChatFilter = new System.Windows.Forms.Label();
            this.tbSapAngl = new System.Windows.Forms.TextBox();
            this.btnBrkNum = new System.Windows.Forms.Button();
            this.tbBrkSapMinAngl = new System.Windows.Forms.TextBox();
            this.tbBrkSapMaxAngl = new System.Windows.Forms.TextBox();
            this.tbAdjEB = new System.Windows.Forms.TextBox();
            this.tbAdjN = new System.Windows.Forms.TextBox();
            this.tbBrkNum = new System.Windows.Forms.TextBox();
            this.tbEBAngl = new System.Windows.Forms.TextBox();
            this.tbChatFilter = new System.Windows.Forms.TextBox();
            this.tbBrkFullAngl = new System.Windows.Forms.TextBox();
            this.btnSapAngl = new System.Windows.Forms.Button();
            this.btnBrkSapMinAngl = new System.Windows.Forms.Button();
            this.btnBrkSapMaxAngl = new System.Windows.Forms.Button();
            this.btnEBAngl = new System.Windows.Forms.Button();
            this.btnChatFilter = new System.Windows.Forms.Button();
            this.btnBrkFullAngl = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pnlAutoair = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.tbnKeep = new System.Windows.Forms.Button();
            this.btnKeepFull = new System.Windows.Forms.Button();
            this.btnBpSpanUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBpSpanDown = new System.Windows.Forms.Button();
            this.tbKeepFull = new System.Windows.Forms.TextBox();
            this.tbBpSpanUp = new System.Windows.Forms.TextBox();
            this.tbKeep = new System.Windows.Forms.TextBox();
            this.tbBpSpanDown = new System.Windows.Forms.TextBox();
            this.cbAutoAirEX = new System.Windows.Forms.CheckBox();
            this.cbRealAutoAir = new System.Windows.Forms.CheckBox();
            this.cbAutoairUse = new System.Windows.Forms.CheckBox();
            this.cbAtsConf = new System.Windows.Forms.CheckBox();
            this.cbDecEB = new System.Windows.Forms.CheckBox();
            this.cbHorn2 = new System.Windows.Forms.CheckBox();
            this.cbHorn1 = new System.Windows.Forms.CheckBox();
            this.cbEB = new System.Windows.Forms.CheckBox();
            this.cbAtsRec = new System.Windows.Forms.CheckBox();
            this.cbAtsCont = new System.Windows.Forms.CheckBox();
            this.btnBrkSave = new System.Windows.Forms.Button();
            this.btnBrkRead = new System.Windows.Forms.Button();
            this.tpPressTest = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tpRealAutoAir = new System.Windows.Forms.TabPage();
            this.pnlPress = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpA = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tbAveRatio = new System.Windows.Forms.TextBox();
            this.tbBCMultiNorm = new System.Windows.Forms.TextBox();
            this.tbBCMaxNorm = new System.Windows.Forms.TextBox();
            this.tbBPvelocityKyudouThreshold = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbBCMulti = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbBCMax = new System.Windows.Forms.TextBox();
            this.tpE = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tbBCMaxE = new System.Windows.Forms.TextBox();
            this.tbAveRatioE = new System.Windows.Forms.TextBox();
            this.tbBCMultiE = new System.Windows.Forms.TextBox();
            this.cbBpEvacPress = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbBCPress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbarBCPress = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBPMinSet = new System.Windows.Forms.Button();
            this.btnBPMaxSet = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbBPMin = new System.Windows.Forms.TextBox();
            this.lblBP = new System.Windows.Forms.Label();
            this.tbBPPressMin = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblBP_B = new System.Windows.Forms.Label();
            this.tbBPPressMax = new System.Windows.Forms.TextBox();
            this.tbBP = new System.Windows.Forms.TextBox();
            this.tbBP_V = new System.Windows.Forms.TextBox();
            this.tbBPMax = new System.Windows.Forms.TextBox();
            this.tbarBP = new System.Windows.Forms.TrackBar();
            this.btnPressRead = new System.Windows.Forms.Button();
            this.btnPressSave = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFVMinSet = new System.Windows.Forms.Button();
            this.btnFVMaxSet = new System.Windows.Forms.Button();
            this.cbFVhold = new System.Windows.Forms.CheckBox();
            this.tbFVPressMax = new System.Windows.Forms.TextBox();
            this.tbFVMax = new System.Windows.Forms.TextBox();
            this.tbFVMin = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.lblFV_V = new System.Windows.Forms.Label();
            this.tbFV_V = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbFV = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbFVPressMin = new System.Windows.Forms.TextBox();
            this.lblFV = new System.Windows.Forms.Label();
            this.tbarFV = new System.Windows.Forms.TrackBar();
            this.tbMonInterval = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbModeMON = new System.Windows.Forms.CheckBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbRegOffDelay = new System.Windows.Forms.TextBox();
            this.tbBCMin = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tbEBOndelay = new System.Windows.Forms.TextBox();
            this.tbEBThreshold = new System.Windows.Forms.TextBox();
            this.tbEBInterval = new System.Windows.Forms.TextBox();
            this.tpSimAutoAir = new System.Windows.Forms.TabPage();
            this.gbAirMeterDebug = new System.Windows.Forms.GroupBox();
            this.btnDispTestAtsAlm = new System.Windows.Forms.Button();
            this.label104 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.tbSimPressReadER = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.tbarSimAirReadER = new System.Windows.Forms.TrackBar();
            this.btnDsipTestAts = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label88 = new System.Windows.Forms.Label();
            this.tbSimPressReadMR = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.tbarSimAirReadMR = new System.Windows.Forms.TrackBar();
            this.label90 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label91 = new System.Windows.Forms.Label();
            this.tbSimPressReadBC = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.tbarSimAirReadBC = new System.Windows.Forms.TrackBar();
            this.btnDispTestYokusoku = new System.Windows.Forms.Button();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label94 = new System.Windows.Forms.Label();
            this.tbSimPressReadSAP = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.tbarSimAirReadSAP = new System.Windows.Forms.TrackBar();
            this.label96 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label97 = new System.Windows.Forms.Label();
            this.tbSimPressReadBP = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.tbarSimAirReadBP = new System.Windows.Forms.TrackBar();
            this.label99 = new System.Windows.Forms.Label();
            this.btnDispTestHatsuden = new System.Windows.Forms.Button();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label100 = new System.Windows.Forms.Label();
            this.tbSimPressReadFV = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.tbarSimAirReadFV = new System.Windows.Forms.TrackBar();
            this.label102 = new System.Windows.Forms.Label();
            this.btnDispTestSAP = new System.Windows.Forms.Button();
            this.cbAirMeterDebug = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPortSelectAirRead = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.tbSimPressER = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.tbarSimAirER = new System.Windows.Forms.TrackBar();
            this.btnSerialPortOpenDensei = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label80 = new System.Windows.Forms.Label();
            this.tbSimPressMR = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.tbarSimAirMR = new System.Windows.Forms.TrackBar();
            this.label76 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label82 = new System.Windows.Forms.Label();
            this.tbSimPressBC = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.tbarSimAirBC = new System.Windows.Forms.TrackBar();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label81 = new System.Windows.Forms.Label();
            this.tbSimPressSAP = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.tbarSimAirSAP = new System.Windows.Forms.TrackBar();
            this.label74 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label83 = new System.Windows.Forms.Label();
            this.tbSimPressBP = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.tbarSimAirBP = new System.Windows.Forms.TrackBar();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.tbSimPressFV = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.tbarSimAirFV = new System.Windows.Forms.TrackBar();
            this.label71 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbLogRows = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpBvePlugin = new System.Windows.Forms.TabPage();
            this.btnBveExDirOpen = new System.Windows.Forms.Button();
            this.cbSOUninstall = new System.Windows.Forms.CheckBox();
            this.cbXmlCopy = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label107 = new System.Windows.Forms.Label();
            this.btnReferenceChange = new System.Windows.Forms.Button();
            this.btnPluginUnInstall = new System.Windows.Forms.Button();
            this.tbInstallLog = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.tbPluginDirectory = new System.Windows.Forms.TextBox();
            this.btnPluginInstall = new System.Windows.Forms.Button();
            this.tpFirmware = new System.Windows.Forms.TabPage();
            this.gpbATSP = new System.Windows.Forms.GroupBox();
            this.label116 = new System.Windows.Forms.Label();
            this.pnlATSPBoard = new System.Windows.Forms.Panel();
            this.cbVersionListPBin = new System.Windows.Forms.ComboBox();
            this.tbBinFilePathP = new System.Windows.Forms.TextBox();
            this.cbVersionListPHex = new System.Windows.Forms.ComboBox();
            this.btnFirmDirOpenHexP = new System.Windows.Forms.Button();
            this.btnFirmDirOpenBinP = new System.Windows.Forms.Button();
            this.btnHexFileChangeP = new System.Windows.Forms.Button();
            this.tbHexFilePathP = new System.Windows.Forms.TextBox();
            this.btnBinFileChangeP = new System.Windows.Forms.Button();
            this.btnEepromWriteP = new System.Windows.Forms.Button();
            this.btnFirmUpdateP = new System.Windows.Forms.Button();
            this.tbATSPBoardVersion = new System.Windows.Forms.TextBox();
            this.btnFirmBackupP = new System.Windows.Forms.Button();
            this.btnOpenATSP = new System.Windows.Forms.Button();
            this.cbPortSelectATSP = new System.Windows.Forms.ComboBox();
            this.btnEepromLoadP = new System.Windows.Forms.Button();
            this.gpbDispBoard = new System.Windows.Forms.GroupBox();
            this.pnlDispBoard = new System.Windows.Forms.Panel();
            this.cbVersionListDBin = new System.Windows.Forms.ComboBox();
            this.tbBinFilePathD = new System.Windows.Forms.TextBox();
            this.cbVersionListDHex = new System.Windows.Forms.ComboBox();
            this.btnFirmDirOpenBinD = new System.Windows.Forms.Button();
            this.btnFirmDirOpenHexD = new System.Windows.Forms.Button();
            this.btnBinFileChangeD = new System.Windows.Forms.Button();
            this.btnHexFileChangeD = new System.Windows.Forms.Button();
            this.tbHexFilePathD = new System.Windows.Forms.TextBox();
            this.btnEepromWriteD = new System.Windows.Forms.Button();
            this.btnFirmUpdateD = new System.Windows.Forms.Button();
            this.cbPortSelectDensei = new System.Windows.Forms.ComboBox();
            this.btnFirmBackupD = new System.Windows.Forms.Button();
            this.label115 = new System.Windows.Forms.Label();
            this.btnEepromLoadD = new System.Windows.Forms.Button();
            this.btnOpenDensei = new System.Windows.Forms.Button();
            this.tbDispBoardVersion = new System.Windows.Forms.TextBox();
            this.gpbControllerBoard = new System.Windows.Forms.GroupBox();
            this.cbVersionListCBin = new System.Windows.Forms.ComboBox();
            this.cbVersionListCHex = new System.Windows.Forms.ComboBox();
            this.label114 = new System.Windows.Forms.Label();
            this.btnFirmBackupC = new System.Windows.Forms.Button();
            this.btnFirmDirOpenBinC = new System.Windows.Forms.Button();
            this.btnFirmDirOpenHexC = new System.Windows.Forms.Button();
            this.tbControlBoardVersion = new System.Windows.Forms.TextBox();
            this.btnBinFileChangeC = new System.Windows.Forms.Button();
            this.btnHexFileChangeC = new System.Windows.Forms.Button();
            this.tbBinFilePathC = new System.Windows.Forms.TextBox();
            this.tbHexFilePathC = new System.Windows.Forms.TextBox();
            this.btnEepromWriteC = new System.Windows.Forms.Button();
            this.btnEepromLoadC = new System.Windows.Forms.Button();
            this.btnFirmUpdateC = new System.Windows.Forms.Button();
            this.btnDriverInstall = new System.Windows.Forms.Button();
            this.label118 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.lblArduinoInstall = new System.Windows.Forms.Label();
            this.llArduinoIde = new System.Windows.Forms.LinkLabel();
            this.tpExtra = new System.Windows.Forms.TabPage();
            this.label110 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslError = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnBrkMinus = new System.Windows.Forms.Button();
            this.btnBrkPlus = new System.Windows.Forms.Button();
            this.tbBrkNumTop = new System.Windows.Forms.TextBox();
            this.lblBrkSetTop = new System.Windows.Forms.Label();
            this.btnBve5Start = new System.Windows.Forms.Button();
            this.tbMcNumTop = new System.Windows.Forms.TextBox();
            this.btnMcMinus = new System.Windows.Forms.Button();
            this.btnMcPlus = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBve6Start = new System.Windows.Forms.Button();
            this.tbMcNumMaxTop = new System.Windows.Forms.TextBox();
            this.btnMcMaxMinus = new System.Windows.Forms.Button();
            this.btnMcMaxPlus = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSetReadAll = new System.Windows.Forms.Button();
            this.btnSetSaveAll = new System.Windows.Forms.Button();
            this.tbSerialSend = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.serialPortAirSimDebug = new System.IO.Ports.SerialPort(this.components);
            this.tbSerialRcv2 = new System.Windows.Forms.TextBox();
            this.lblSerialRcv2 = new System.Windows.Forms.Label();
            this.cbTS185 = new System.Windows.Forms.CheckBox();
            this.btnJreTsStart = new System.Windows.Forms.Button();
            this.label109 = new System.Windows.Forms.Label();
            this.serialPortDensei = new System.IO.Ports.SerialPort(this.components);
            this.timerDispBoardFinder = new System.Windows.Forms.Timer(this.components);
            this.timerATSPBoardFinder = new System.Windows.Forms.Timer(this.components);
            this.btnSaveParamXml = new System.Windows.Forms.Button();
            this.btnLoadParamXml = new System.Windows.Forms.Button();
            this.serialPortChecker = new System.Windows.Forms.Timer(this.components);
            this.timerControllerBoardFinder = new System.Windows.Forms.Timer(this.components);
            this.serialPortATSP = new System.IO.Ports.SerialPort(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbBCTop.SuspendLayout();
            this.gbBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBc)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.pnlDisp.SuspendLayout();
            this.pnlATSP.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSpdTest)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarCurrentTest)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.pnlAutoair.SuspendLayout();
            this.tpPressTest.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tpRealAutoAir.SuspendLayout();
            this.pnlPress.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpA.SuspendLayout();
            this.tpE.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBCPress)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFV)).BeginInit();
            this.tpSimAutoAir.SuspendLayout();
            this.gbAirMeterDebug.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadER)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadMR)).BeginInit();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadBC)).BeginInit();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadSAP)).BeginInit();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadBP)).BeginInit();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadFV)).BeginInit();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirER)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirMR)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirBC)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirSAP)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirBP)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirFV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpBvePlugin.SuspendLayout();
            this.tpFirmware.SuspendLayout();
            this.gpbATSP.SuspendLayout();
            this.pnlATSPBoard.SuspendLayout();
            this.gpbDispBoard.SuspendLayout();
            this.pnlDispBoard.SuspendLayout();
            this.gpbControllerBoard.SuspendLayout();
            this.tpExtra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.基板設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItemExit.Text = "終了(&X)";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // 基板設定ToolStripMenuItem
            // 
            this.基板設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オプション基板ToolStripMenuItem});
            this.基板設定ToolStripMenuItem.Name = "基板設定ToolStripMenuItem";
            this.基板設定ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.基板設定ToolStripMenuItem.Text = "基板設定";
            // 
            // オプション基板ToolStripMenuItem
            // 
            this.オプション基板ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDispBoard,
            this.tsmiATSPBoard});
            this.オプション基板ToolStripMenuItem.Name = "オプション基板ToolStripMenuItem";
            this.オプション基板ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.オプション基板ToolStripMenuItem.Text = "オプション基板";
            // 
            // tsmiDispBoard
            // 
            this.tsmiDispBoard.Name = "tsmiDispBoard";
            this.tsmiDispBoard.Size = new System.Drawing.Size(166, 22);
            this.tsmiDispBoard.Text = "表示灯空制基板";
            this.tsmiDispBoard.Click += new System.EventHandler(this.tsmiDispBoard_Click);
            // 
            // tsmiATSPBoard
            // 
            this.tsmiATSPBoard.Name = "tsmiATSPBoard";
            this.tsmiATSPBoard.Size = new System.Drawing.Size(166, 22);
            this.tsmiATSPBoard.Text = "ATS-P表示灯基板";
            this.tsmiATSPBoard.Click += new System.EventHandler(this.tsmiATSPBoard_Click);
            // 
            // tbSerialRcv
            // 
            this.tbSerialRcv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerialRcv.Location = new System.Drawing.Point(79, 743);
            this.tbSerialRcv.Name = "tbSerialRcv";
            this.tbSerialRcv.Size = new System.Drawing.Size(1081, 19);
            this.tbSerialRcv.TabIndex = 52;
            // 
            // btnSerialPortOpen
            // 
            this.btnSerialPortOpen.Enabled = false;
            this.btnSerialPortOpen.Location = new System.Drawing.Point(252, 20);
            this.btnSerialPortOpen.Name = "btnSerialPortOpen";
            this.btnSerialPortOpen.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPortOpen.TabIndex = 2;
            this.btnSerialPortOpen.Text = "通信開始";
            this.btnSerialPortOpen.UseVisualStyleBackColor = true;
            this.btnSerialPortOpen.Click += new System.EventHandler(this.openButton_Click);
            // 
            // cbPortSelect
            // 
            this.cbPortSelect.FormattingEnabled = true;
            this.cbPortSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPortSelect.Location = new System.Drawing.Point(73, 22);
            this.cbPortSelect.Name = "cbPortSelect";
            this.cbPortSelect.Size = new System.Drawing.Size(173, 20);
            this.cbPortSelect.TabIndex = 1;
            this.cbPortSelect.MouseHover += new System.EventHandler(this.comboBoxPortselect_MouseHover);
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(6, 6);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(657, 490);
            this.tbLog.TabIndex = 41;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWrite.Location = new System.Drawing.Point(319, 513);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 42;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // messageTextBox1
            // 
            this.messageTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTextBox1.Location = new System.Drawing.Point(8, 515);
            this.messageTextBox1.Name = "messageTextBox1";
            this.messageTextBox1.Size = new System.Drawing.Size(305, 19);
            this.messageTextBox1.TabIndex = 43;
            this.messageTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "Serial Port:";
            // 
            // serialPortMain
            // 
            this.serialPortMain.BaudRate = 115200;
            this.serialPortMain.WriteTimeout = 1000;
            this.serialPortMain.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPortMain.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPortMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn010
            // 
            this.btn010.Location = new System.Drawing.Point(283, 340);
            this.btn010.Name = "btn010";
            this.btn010.Size = new System.Drawing.Size(75, 23);
            this.btn010.TabIndex = 51;
            this.btn010.Text = "10km/h";
            this.btn010.UseVisualStyleBackColor = true;
            this.btn010.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn020
            // 
            this.btn020.Location = new System.Drawing.Point(283, 318);
            this.btn020.Name = "btn020";
            this.btn020.Size = new System.Drawing.Size(75, 23);
            this.btn020.TabIndex = 49;
            this.btn020.Text = "20km/h";
            this.btn020.UseVisualStyleBackColor = true;
            this.btn020.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn030
            // 
            this.btn030.Location = new System.Drawing.Point(283, 296);
            this.btn030.Name = "btn030";
            this.btn030.Size = new System.Drawing.Size(75, 23);
            this.btn030.TabIndex = 47;
            this.btn030.Text = "30km/h";
            this.btn030.UseVisualStyleBackColor = true;
            this.btn030.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn040
            // 
            this.btn040.Location = new System.Drawing.Point(283, 274);
            this.btn040.Name = "btn040";
            this.btn040.Size = new System.Drawing.Size(75, 23);
            this.btn040.TabIndex = 45;
            this.btn040.Text = "40km/h";
            this.btn040.UseVisualStyleBackColor = true;
            this.btn040.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn050
            // 
            this.btn050.Location = new System.Drawing.Point(283, 252);
            this.btn050.Name = "btn050";
            this.btn050.Size = new System.Drawing.Size(75, 23);
            this.btn050.TabIndex = 43;
            this.btn050.Text = "50km/h";
            this.btn050.UseVisualStyleBackColor = true;
            this.btn050.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn060
            // 
            this.btn060.Location = new System.Drawing.Point(283, 230);
            this.btn060.Name = "btn060";
            this.btn060.Size = new System.Drawing.Size(75, 23);
            this.btn060.TabIndex = 41;
            this.btn060.Text = "60km/h";
            this.btn060.UseVisualStyleBackColor = true;
            this.btn060.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn070
            // 
            this.btn070.Location = new System.Drawing.Point(283, 208);
            this.btn070.Name = "btn070";
            this.btn070.Size = new System.Drawing.Size(75, 23);
            this.btn070.TabIndex = 39;
            this.btn070.Text = "70km/h";
            this.btn070.UseVisualStyleBackColor = true;
            this.btn070.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn080
            // 
            this.btn080.Location = new System.Drawing.Point(283, 186);
            this.btn080.Name = "btn080";
            this.btn080.Size = new System.Drawing.Size(75, 23);
            this.btn080.TabIndex = 37;
            this.btn080.Text = "80km/h";
            this.btn080.UseVisualStyleBackColor = true;
            this.btn080.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn090
            // 
            this.btn090.Location = new System.Drawing.Point(283, 164);
            this.btn090.Name = "btn090";
            this.btn090.Size = new System.Drawing.Size(75, 23);
            this.btn090.TabIndex = 35;
            this.btn090.Text = "90km/h";
            this.btn090.UseVisualStyleBackColor = true;
            this.btn090.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(283, 142);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 33;
            this.btn100.Text = "100km/h";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn110
            // 
            this.btn110.Location = new System.Drawing.Point(283, 120);
            this.btn110.Name = "btn110";
            this.btn110.Size = new System.Drawing.Size(75, 23);
            this.btn110.TabIndex = 31;
            this.btn110.Text = "110km/h";
            this.btn110.UseVisualStyleBackColor = true;
            this.btn110.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn120
            // 
            this.btn120.Location = new System.Drawing.Point(283, 98);
            this.btn120.Name = "btn120";
            this.btn120.Size = new System.Drawing.Size(75, 23);
            this.btn120.TabIndex = 29;
            this.btn120.Text = "120km/h";
            this.btn120.UseVisualStyleBackColor = true;
            this.btn120.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn130
            // 
            this.btn130.Location = new System.Drawing.Point(283, 77);
            this.btn130.Name = "btn130";
            this.btn130.Size = new System.Drawing.Size(75, 23);
            this.btn130.TabIndex = 27;
            this.btn130.Text = "130km/h";
            this.btn130.UseVisualStyleBackColor = true;
            this.btn130.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn140
            // 
            this.btn140.Location = new System.Drawing.Point(283, 55);
            this.btn140.Name = "btn140";
            this.btn140.Size = new System.Drawing.Size(75, 23);
            this.btn140.TabIndex = 25;
            this.btn140.Text = "140km/h";
            this.btn140.UseVisualStyleBackColor = true;
            this.btn140.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // btn150
            // 
            this.btn150.Location = new System.Drawing.Point(283, 33);
            this.btn150.Name = "btn150";
            this.btn150.Size = new System.Drawing.Size(75, 23);
            this.btn150.TabIndex = 23;
            this.btn150.Text = "150km/h";
            this.btn150.UseVisualStyleBackColor = true;
            this.btn150.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tpPressTest);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tpBvePlugin);
            this.tabControl1.Controls.Add(this.tpFirmware);
            this.tabControl1.Controls.Add(this.tpExtra);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1157, 581);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.gbBCTop);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.btnSpdSave);
            this.tabPage1.Controls.Add(this.btnSpdRead);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "パネル";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox7.Controls.Add(this.tbBrakeCount);
            this.groupBox7.Controls.Add(this.tbRev);
            this.groupBox7.Controls.Add(this.tbP);
            this.groupBox7.Controls.Add(this.tbMcCount);
            this.groupBox7.Controls.Add(this.label63);
            this.groupBox7.Controls.Add(this.label62);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.tbEm);
            this.groupBox7.Controls.Add(this.tbQ);
            this.groupBox7.Controls.Add(this.tbB);
            this.groupBox7.Controls.Add(this.tbA);
            this.groupBox7.Controls.Add(this.tbComma);
            this.groupBox7.Controls.Add(this.tbDown);
            this.groupBox7.Controls.Add(this.tbUp);
            this.groupBox7.Controls.Add(this.tbZ);
            this.groupBox7.Controls.Add(this.tbHorn2);
            this.groupBox7.Controls.Add(this.tbAtsCont);
            this.groupBox7.Controls.Add(this.tbHorn1);
            this.groupBox7.Controls.Add(this.tbAtsConf);
            this.groupBox7.Controls.Add(this.tbEB);
            this.groupBox7.Controls.Add(this.tbAtsRec);
            this.groupBox7.Location = new System.Drawing.Point(6, 405);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(426, 140);
            this.groupBox7.TabIndex = 89;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "キー入力テストエリア";
            // 
            // tbBrakeCount
            // 
            this.tbBrakeCount.AcceptsReturn = true;
            this.tbBrakeCount.Location = new System.Drawing.Point(57, 92);
            this.tbBrakeCount.Name = "tbBrakeCount";
            this.tbBrakeCount.Size = new System.Drawing.Size(47, 19);
            this.tbBrakeCount.TabIndex = 84;
            this.tbBrakeCount.Text = "0";
            this.tbBrakeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRev
            // 
            this.tbRev.AcceptsReturn = true;
            this.tbRev.Location = new System.Drawing.Point(57, 116);
            this.tbRev.Name = "tbRev";
            this.tbRev.Size = new System.Drawing.Size(47, 19);
            this.tbRev.TabIndex = 84;
            this.tbRev.Text = "N";
            this.tbRev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(344, 18);
            this.tbP.Name = "tbP";
            this.tbP.ReadOnly = true;
            this.tbP.Size = new System.Drawing.Size(71, 19);
            this.tbP.TabIndex = 84;
            this.tbP.Text = "一時停止(P)";
            this.tbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMcCount
            // 
            this.tbMcCount.AcceptsReturn = true;
            this.tbMcCount.Location = new System.Drawing.Point(57, 67);
            this.tbMcCount.Name = "tbMcCount";
            this.tbMcCount.Size = new System.Drawing.Size(47, 19);
            this.tbMcCount.TabIndex = 84;
            this.tbMcCount.Text = "0";
            this.tbMcCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(8, 119);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(44, 12);
            this.label63.TabIndex = 86;
            this.label63.Text = "レバーサ";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(8, 95);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(43, 12);
            this.label62.TabIndex = 86;
            this.label62.Text = "ブレーキ";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(11, 71);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(40, 12);
            this.label61.TabIndex = 86;
            this.label61.Text = "マスコン";
            // 
            // tbEm
            // 
            this.tbEm.Location = new System.Drawing.Point(237, 92);
            this.tbEm.Name = "tbEm";
            this.tbEm.ReadOnly = true;
            this.tbEm.Size = new System.Drawing.Size(61, 19);
            this.tbEm.TabIndex = 84;
            this.tbEm.Text = "非常(/)";
            this.tbEm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(218, 67);
            this.tbQ.Name = "tbQ";
            this.tbQ.ReadOnly = true;
            this.tbQ.Size = new System.Drawing.Size(93, 19);
            this.tbQ.TabIndex = 84;
            this.tbQ.Text = "抑速・ブレーキ(Q)";
            this.tbQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(163, 92);
            this.tbB.Name = "tbB";
            this.tbB.ReadOnly = true;
            this.tbB.Size = new System.Drawing.Size(68, 19);
            this.tbB.TabIndex = 84;
            this.tbB.Text = "ブレーキ(.)";
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(163, 67);
            this.tbA.Name = "tbA";
            this.tbA.ReadOnly = true;
            this.tbA.Size = new System.Drawing.Size(49, 19);
            this.tbA.TabIndex = 84;
            this.tbA.Text = "惰行(A)";
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbComma
            // 
            this.tbComma.Location = new System.Drawing.Point(110, 92);
            this.tbComma.Name = "tbComma";
            this.tbComma.ReadOnly = true;
            this.tbComma.Size = new System.Drawing.Size(49, 19);
            this.tbComma.TabIndex = 84;
            this.tbComma.Text = "緩め(,)";
            this.tbComma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDown
            // 
            this.tbDown.Location = new System.Drawing.Point(163, 116);
            this.tbDown.Name = "tbDown";
            this.tbDown.ReadOnly = true;
            this.tbDown.Size = new System.Drawing.Size(49, 19);
            this.tbDown.TabIndex = 84;
            this.tbDown.Text = "下(↓)";
            this.tbDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUp
            // 
            this.tbUp.Location = new System.Drawing.Point(110, 116);
            this.tbUp.Name = "tbUp";
            this.tbUp.ReadOnly = true;
            this.tbUp.Size = new System.Drawing.Size(49, 19);
            this.tbUp.TabIndex = 84;
            this.tbUp.Text = "上(↑)";
            this.tbUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(110, 67);
            this.tbZ.Name = "tbZ";
            this.tbZ.ReadOnly = true;
            this.tbZ.Size = new System.Drawing.Size(49, 19);
            this.tbZ.TabIndex = 84;
            this.tbZ.Text = "力行(Z)";
            this.tbZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHorn2
            // 
            this.tbHorn2.Location = new System.Drawing.Point(90, 43);
            this.tbHorn2.Name = "tbHorn2";
            this.tbHorn2.ReadOnly = true;
            this.tbHorn2.Size = new System.Drawing.Size(79, 19);
            this.tbHorn2.TabIndex = 84;
            this.tbHorn2.Text = "警笛2(+)";
            this.tbHorn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAtsCont
            // 
            this.tbAtsCont.Location = new System.Drawing.Point(100, 18);
            this.tbAtsCont.Name = "tbAtsCont";
            this.tbAtsCont.ReadOnly = true;
            this.tbAtsCont.Size = new System.Drawing.Size(100, 19);
            this.tbAtsCont.TabIndex = 84;
            this.tbAtsCont.Text = "警報持続(Insert)";
            this.tbAtsCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHorn1
            // 
            this.tbHorn1.Location = new System.Drawing.Point(5, 43);
            this.tbHorn1.Name = "tbHorn1";
            this.tbHorn1.ReadOnly = true;
            this.tbHorn1.Size = new System.Drawing.Size(79, 19);
            this.tbHorn1.TabIndex = 84;
            this.tbHorn1.Text = "警笛1(Enter)";
            this.tbHorn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAtsConf
            // 
            this.tbAtsConf.Location = new System.Drawing.Point(5, 18);
            this.tbAtsConf.Name = "tbAtsConf";
            this.tbAtsConf.ReadOnly = true;
            this.tbAtsConf.Size = new System.Drawing.Size(92, 19);
            this.tbAtsConf.TabIndex = 84;
            this.tbAtsConf.Text = "ATS確認(Space)";
            this.tbAtsConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEB
            // 
            this.tbEB.Location = new System.Drawing.Point(276, 18);
            this.tbEB.Name = "tbEB";
            this.tbEB.ReadOnly = true;
            this.tbEB.Size = new System.Drawing.Size(63, 19);
            this.tbEB.TabIndex = 84;
            this.tbEB.Text = "EB(Delete)";
            this.tbEB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAtsRec
            // 
            this.tbAtsRec.Location = new System.Drawing.Point(203, 18);
            this.tbAtsRec.Name = "tbAtsRec";
            this.tbAtsRec.ReadOnly = true;
            this.tbAtsRec.Size = new System.Drawing.Size(69, 19);
            this.tbAtsRec.TabIndex = 84;
            this.tbAtsRec.Text = "復帰(Home)";
            this.tbAtsRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbBCTop
            // 
            this.gbBCTop.BackColor = System.Drawing.Color.MistyRose;
            this.gbBCTop.Controls.Add(this.gbBC);
            this.gbBCTop.Controls.Add(this.cbBpEvac);
            this.gbBCTop.Location = new System.Drawing.Point(435, 405);
            this.gbBCTop.Name = "gbBCTop";
            this.gbBCTop.Size = new System.Drawing.Size(329, 140);
            this.gbBCTop.TabIndex = 87;
            this.gbBCTop.TabStop = false;
            this.gbBCTop.Text = "BC圧力";
            // 
            // gbBC
            // 
            this.gbBC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBC.Controls.Add(this.tbBC);
            this.gbBC.Controls.Add(this.lblTbarBC500);
            this.gbBC.Controls.Add(this.lblBCkPa);
            this.gbBC.Controls.Add(this.lblTbarBC0);
            this.gbBC.Controls.Add(this.tbarBc);
            this.gbBC.Controls.Add(this.label10);
            this.gbBC.Controls.Add(this.label11);
            this.gbBC.Enabled = false;
            this.gbBC.Location = new System.Drawing.Point(13, 18);
            this.gbBC.Name = "gbBC";
            this.gbBC.Size = new System.Drawing.Size(298, 87);
            this.gbBC.TabIndex = 86;
            this.gbBC.TabStop = false;
            this.gbBC.Text = "表示(発電ONで有効)";
            // 
            // tbBC
            // 
            this.tbBC.AcceptsReturn = true;
            this.tbBC.Location = new System.Drawing.Point(57, 18);
            this.tbBC.Name = "tbBC";
            this.tbBC.Size = new System.Drawing.Size(50, 19);
            this.tbBC.TabIndex = 84;
            this.tbBC.Text = "0";
            this.tbBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBC_KeyDown);
            // 
            // lblTbarBC500
            // 
            this.lblTbarBC500.AutoSize = true;
            this.lblTbarBC500.Location = new System.Drawing.Point(128, 65);
            this.lblTbarBC500.Name = "lblTbarBC500";
            this.lblTbarBC500.Size = new System.Drawing.Size(42, 12);
            this.lblTbarBC500.TabIndex = 85;
            this.lblTbarBC500.Text = "500kPa";
            // 
            // lblBCkPa
            // 
            this.lblBCkPa.AutoSize = true;
            this.lblBCkPa.Location = new System.Drawing.Point(113, 21);
            this.lblBCkPa.Name = "lblBCkPa";
            this.lblBCkPa.Size = new System.Drawing.Size(24, 12);
            this.lblBCkPa.TabIndex = 84;
            this.lblBCkPa.Text = "kPa";
            // 
            // lblTbarBC0
            // 
            this.lblTbarBC0.AutoSize = true;
            this.lblTbarBC0.Location = new System.Drawing.Point(7, 65);
            this.lblTbarBC0.Name = "lblTbarBC0";
            this.lblTbarBC0.Size = new System.Drawing.Size(30, 12);
            this.lblTbarBC0.TabIndex = 84;
            this.lblTbarBC0.Text = "0kPa";
            // 
            // tbarBc
            // 
            this.tbarBc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarBc.LargeChange = 100;
            this.tbarBc.Location = new System.Drawing.Point(2, 36);
            this.tbarBc.Maximum = 500;
            this.tbarBc.Name = "tbarBc";
            this.tbarBc.Size = new System.Drawing.Size(289, 45);
            this.tbarBc.SmallChange = 10;
            this.tbarBc.TabIndex = 78;
            this.tbarBc.Scroll += new System.EventHandler(this.tbarBc_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 81;
            this.label11.Text = "+500";
            // 
            // cbBpEvac
            // 
            this.cbBpEvac.AutoSize = true;
            this.cbBpEvac.Location = new System.Drawing.Point(35, 114);
            this.cbBpEvac.Name = "cbBpEvac";
            this.cbBpEvac.Size = new System.Drawing.Size(107, 16);
            this.cbBpEvac.TabIndex = 61;
            this.cbBpEvac.Text = "E電磁給排弁 開";
            this.cbBpEvac.UseVisualStyleBackColor = true;
            this.cbBpEvac.CheckedChanged += new System.EventHandler(this.cbBpEvac_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.Controls.Add(this.groupBox26);
            this.groupBox5.Controls.Add(this.groupBox25);
            this.groupBox5.Controls.Add(this.cbLampOERLight);
            this.groupBox5.Controls.Add(this.cbLampOERKaisei);
            this.groupBox5.Controls.Add(this.label56);
            this.groupBox5.Controls.Add(this.cbLampOERStop);
            this.groupBox5.Controls.Add(this.label113);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.cbLampOERAtt);
            this.groupBox5.Controls.Add(this.rbPWest);
            this.groupBox5.Controls.Add(this.cbAtsDengenMode);
            this.groupBox5.Controls.Add(this.cbDoor);
            this.groupBox5.Controls.Add(this.cbOER1000Console);
            this.groupBox5.Controls.Add(this.cbOERMode);
            this.groupBox5.Controls.Add(this.rbPEast);
            this.groupBox5.Controls.Add(this.pnlDisp);
            this.groupBox5.Controls.Add(this.tbAtsPDengenTounyuTime);
            this.groupBox5.Controls.Add(this.pnlATSP);
            this.groupBox5.Controls.Add(this.tbAtsSDengenTounyuTime);
            this.groupBox5.Location = new System.Drawing.Point(435, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(329, 366);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "表示灯";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.rbAC);
            this.groupBox26.Controls.Add(this.rbDC);
            this.groupBox26.Controls.Add(this.rbSection);
            this.groupBox26.Location = new System.Drawing.Point(210, 216);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(101, 70);
            this.groupBox26.TabIndex = 96;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "デッドセクション";
            // 
            // rbAC
            // 
            this.rbAC.AutoSize = true;
            this.rbAC.Location = new System.Drawing.Point(13, 51);
            this.rbAC.Name = "rbAC";
            this.rbAC.Size = new System.Drawing.Size(71, 16);
            this.rbAC.TabIndex = 92;
            this.rbAC.TabStop = true;
            this.rbAC.Text = "交流区間";
            this.rbAC.UseVisualStyleBackColor = true;
            this.rbAC.CheckedChanged += new System.EventHandler(this.rbAC_CheckedChanged);
            // 
            // rbDC
            // 
            this.rbDC.AutoSize = true;
            this.rbDC.Location = new System.Drawing.Point(13, 15);
            this.rbDC.Name = "rbDC";
            this.rbDC.Size = new System.Drawing.Size(71, 16);
            this.rbDC.TabIndex = 90;
            this.rbDC.TabStop = true;
            this.rbDC.Text = "直流区間";
            this.rbDC.UseVisualStyleBackColor = true;
            this.rbDC.CheckedChanged += new System.EventHandler(this.rbDC_CheckedChanged);
            // 
            // rbSection
            // 
            this.rbSection.AutoSize = true;
            this.rbSection.Location = new System.Drawing.Point(13, 33);
            this.rbSection.Name = "rbSection";
            this.rbSection.Size = new System.Drawing.Size(71, 16);
            this.rbSection.TabIndex = 91;
            this.rbSection.TabStop = true;
            this.rbSection.Text = "死電区間";
            this.rbSection.UseVisualStyleBackColor = true;
            this.rbSection.CheckedChanged += new System.EventHandler(this.rbSection_CheckedChanged);
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.rbATS3);
            this.groupBox25.Controls.Add(this.rbATS);
            this.groupBox25.Controls.Add(this.rbATS2);
            this.groupBox25.Location = new System.Drawing.Point(208, 292);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(118, 71);
            this.groupBox25.TabIndex = 93;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "ATS未投入防止";
            // 
            // rbATS3
            // 
            this.rbATS3.AutoSize = true;
            this.rbATS3.Location = new System.Drawing.Point(13, 51);
            this.rbATS3.Name = "rbATS3";
            this.rbATS3.Size = new System.Drawing.Size(97, 16);
            this.rbATS3.TabIndex = 92;
            this.rbATS3.TabStop = true;
            this.rbATS3.Text = "警報器(3ノッチ)";
            this.rbATS3.UseVisualStyleBackColor = true;
            this.rbATS3.CheckedChanged += new System.EventHandler(this.rbATS3_CheckedChanged);
            // 
            // rbATS
            // 
            this.rbATS.AutoSize = true;
            this.rbATS.Location = new System.Drawing.Point(13, 15);
            this.rbATS.Name = "rbATS";
            this.rbATS.Size = new System.Drawing.Size(71, 16);
            this.rbATS.TabIndex = 90;
            this.rbATS.TabStop = true;
            this.rbATS.Text = "防止装置";
            this.rbATS.UseVisualStyleBackColor = true;
            this.rbATS.CheckedChanged += new System.EventHandler(this.rbATS_CheckedChanged);
            // 
            // rbATS2
            // 
            this.rbATS2.AutoSize = true;
            this.rbATS2.Location = new System.Drawing.Point(13, 33);
            this.rbATS2.Name = "rbATS2";
            this.rbATS2.Size = new System.Drawing.Size(97, 16);
            this.rbATS2.TabIndex = 91;
            this.rbATS2.TabStop = true;
            this.rbATS2.Text = "警報器(2ノッチ)";
            this.rbATS2.UseVisualStyleBackColor = true;
            this.rbATS2.CheckedChanged += new System.EventHandler(this.rbATS2_CheckedChanged);
            // 
            // cbLampOERLight
            // 
            this.cbLampOERLight.AutoSize = true;
            this.cbLampOERLight.Location = new System.Drawing.Point(210, 132);
            this.cbLampOERLight.Name = "cbLampOERLight";
            this.cbLampOERLight.Size = new System.Drawing.Size(60, 16);
            this.cbLampOERLight.TabIndex = 89;
            this.cbLampOERLight.Text = "前照灯";
            this.cbLampOERLight.UseVisualStyleBackColor = true;
            this.cbLampOERLight.Visible = false;
            this.cbLampOERLight.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbLampOERKaisei
            // 
            this.cbLampOERKaisei.AutoSize = true;
            this.cbLampOERKaisei.Location = new System.Drawing.Point(210, 111);
            this.cbLampOERKaisei.Name = "cbLampOERKaisei";
            this.cbLampOERKaisei.Size = new System.Drawing.Size(72, 16);
            this.cbLampOERKaisei.TabIndex = 88;
            this.cbLampOERKaisei.Text = "回生開放";
            this.cbLampOERKaisei.UseVisualStyleBackColor = true;
            this.cbLampOERKaisei.Visible = false;
            this.cbLampOERKaisei.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // label56
            // 
            this.label56.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(115, 252);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(81, 12);
            this.label56.TabIndex = 86;
            this.label56.Text = "電源投入モード";
            // 
            // cbLampOERStop
            // 
            this.cbLampOERStop.AutoSize = true;
            this.cbLampOERStop.Location = new System.Drawing.Point(210, 90);
            this.cbLampOERStop.Name = "cbLampOERStop";
            this.cbLampOERStop.Size = new System.Drawing.Size(48, 16);
            this.cbLampOERStop.TabIndex = 87;
            this.cbLampOERStop.Text = "停車";
            this.cbLampOERStop.UseVisualStyleBackColor = true;
            this.cbLampOERStop.Visible = false;
            this.cbLampOERStop.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // label113
            // 
            this.label113.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(108, 316);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(98, 12);
            this.label113.TabIndex = 86;
            this.label113.Text = "P電源投入時間(s)";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 12);
            this.label18.TabIndex = 86;
            this.label18.Text = "S電源投入時間(s)";
            // 
            // cbLampOERAtt
            // 
            this.cbLampOERAtt.AutoSize = true;
            this.cbLampOERAtt.Location = new System.Drawing.Point(210, 70);
            this.cbLampOERAtt.Name = "cbLampOERAtt";
            this.cbLampOERAtt.Size = new System.Drawing.Size(72, 16);
            this.cbLampOERAtt.TabIndex = 86;
            this.cbLampOERAtt.Text = "速度注意";
            this.cbLampOERAtt.UseVisualStyleBackColor = true;
            this.cbLampOERAtt.Visible = false;
            this.cbLampOERAtt.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // rbPWest
            // 
            this.rbPWest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPWest.AutoSize = true;
            this.rbPWest.Location = new System.Drawing.Point(157, 290);
            this.rbPWest.Name = "rbPWest";
            this.rbPWest.Size = new System.Drawing.Size(48, 16);
            this.rbPWest.TabIndex = 85;
            this.rbPWest.Text = "West";
            this.rbPWest.UseVisualStyleBackColor = true;
            this.rbPWest.Click += new System.EventHandler(this.rbPWest_Click);
            // 
            // cbAtsDengenMode
            // 
            this.cbAtsDengenMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAtsDengenMode.AutoSize = true;
            this.cbAtsDengenMode.Location = new System.Drawing.Point(113, 270);
            this.cbAtsDengenMode.Name = "cbAtsDengenMode";
            this.cbAtsDengenMode.Size = new System.Drawing.Size(80, 16);
            this.cbAtsDengenMode.TabIndex = 61;
            this.cbAtsDengenMode.Text = "ME48モード";
            this.cbAtsDengenMode.UseVisualStyleBackColor = true;
            this.cbAtsDengenMode.CheckedChanged += new System.EventHandler(this.cbAtsDengenMode_CheckedChanged);
            // 
            // cbDoor
            // 
            this.cbDoor.AutoSize = true;
            this.cbDoor.Location = new System.Drawing.Point(12, 20);
            this.cbDoor.Name = "cbDoor";
            this.cbDoor.Size = new System.Drawing.Size(54, 16);
            this.cbDoor.TabIndex = 61;
            this.cbDoor.Text = "ドア閉";
            this.cbDoor.UseVisualStyleBackColor = true;
            this.cbDoor.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbOER1000Console
            // 
            this.cbOER1000Console.AutoSize = true;
            this.cbOER1000Console.Location = new System.Drawing.Point(210, 176);
            this.cbOER1000Console.Name = "cbOER1000Console";
            this.cbOER1000Console.Size = new System.Drawing.Size(96, 16);
            this.cbOER1000Console.TabIndex = 61;
            this.cbOER1000Console.Text = "小田急運転台";
            this.cbOER1000Console.UseVisualStyleBackColor = true;
            this.cbOER1000Console.CheckedChanged += new System.EventHandler(this.cbOER1000Console_CheckedChanged);
            // 
            // cbOERMode
            // 
            this.cbOERMode.AutoSize = true;
            this.cbOERMode.Location = new System.Drawing.Point(210, 48);
            this.cbOERMode.Name = "cbOERMode";
            this.cbOERMode.Size = new System.Drawing.Size(112, 16);
            this.cbOERMode.TabIndex = 61;
            this.cbOERMode.Text = "小田急表示モード";
            this.cbOERMode.UseVisualStyleBackColor = true;
            this.cbOERMode.CheckedChanged += new System.EventHandler(this.cbOERMode_CheckedChanged);
            // 
            // rbPEast
            // 
            this.rbPEast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPEast.AutoSize = true;
            this.rbPEast.Checked = true;
            this.rbPEast.Location = new System.Drawing.Point(111, 290);
            this.rbPEast.Name = "rbPEast";
            this.rbPEast.Size = new System.Drawing.Size(46, 16);
            this.rbPEast.TabIndex = 85;
            this.rbPEast.TabStop = true;
            this.rbPEast.Text = "East";
            this.rbPEast.UseVisualStyleBackColor = true;
            this.rbPEast.CheckedChanged += new System.EventHandler(this.rbPEast_CheckedChanged);
            this.rbPEast.Click += new System.EventHandler(this.rbPEast_Click);
            // 
            // pnlDisp
            // 
            this.pnlDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDisp.Controls.Add(this.tbUnitNum);
            this.pnlDisp.Controls.Add(this.cbLampSap);
            this.pnlDisp.Controls.Add(this.cbLampHatsuden);
            this.pnlDisp.Controls.Add(this.cbLampYokusoku);
            this.pnlDisp.Controls.Add(this.cbLampAts);
            this.pnlDisp.Controls.Add(this.cbLampAtsAlm);
            this.pnlDisp.Controls.Add(this.cbUnit4);
            this.pnlDisp.Controls.Add(this.cbUnit3);
            this.pnlDisp.Controls.Add(this.cbUnit2);
            this.pnlDisp.Controls.Add(this.cbUnitDisp);
            this.pnlDisp.Controls.Add(this.cbUnit1);
            this.pnlDisp.Controls.Add(this.cbLampEb);
            this.pnlDisp.Location = new System.Drawing.Point(3, 38);
            this.pnlDisp.Name = "pnlDisp";
            this.pnlDisp.Size = new System.Drawing.Size(98, 269);
            this.pnlDisp.TabIndex = 87;
            // 
            // tbUnitNum
            // 
            this.tbUnitNum.AcceptsReturn = true;
            this.tbUnitNum.Location = new System.Drawing.Point(9, 157);
            this.tbUnitNum.Name = "tbUnitNum";
            this.tbUnitNum.Size = new System.Drawing.Size(50, 19);
            this.tbUnitNum.TabIndex = 84;
            this.tbUnitNum.Text = "2";
            this.tbUnitNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUnitNum.Visible = false;
            this.tbUnitNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUnitNum_KeyDown);
            // 
            // cbLampSap
            // 
            this.cbLampSap.AutoSize = true;
            this.cbLampSap.Location = new System.Drawing.Point(9, 10);
            this.cbLampSap.Name = "cbLampSap";
            this.cbLampSap.Size = new System.Drawing.Size(48, 16);
            this.cbLampSap.TabIndex = 61;
            this.cbLampSap.Text = "直通";
            this.cbLampSap.UseVisualStyleBackColor = true;
            this.cbLampSap.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbLampHatsuden
            // 
            this.cbLampHatsuden.AutoSize = true;
            this.cbLampHatsuden.Location = new System.Drawing.Point(9, 31);
            this.cbLampHatsuden.Name = "cbLampHatsuden";
            this.cbLampHatsuden.Size = new System.Drawing.Size(48, 16);
            this.cbLampHatsuden.TabIndex = 61;
            this.cbLampHatsuden.Text = "発電";
            this.cbLampHatsuden.UseVisualStyleBackColor = true;
            this.cbLampHatsuden.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbLampYokusoku
            // 
            this.cbLampYokusoku.AutoSize = true;
            this.cbLampYokusoku.Location = new System.Drawing.Point(9, 52);
            this.cbLampYokusoku.Name = "cbLampYokusoku";
            this.cbLampYokusoku.Size = new System.Drawing.Size(48, 16);
            this.cbLampYokusoku.TabIndex = 61;
            this.cbLampYokusoku.Text = "抑速";
            this.cbLampYokusoku.UseVisualStyleBackColor = true;
            this.cbLampYokusoku.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbLampAts
            // 
            this.cbLampAts.AutoSize = true;
            this.cbLampAts.Location = new System.Drawing.Point(9, 73);
            this.cbLampAts.Name = "cbLampAts";
            this.cbLampAts.Size = new System.Drawing.Size(82, 16);
            this.cbLampAts.TabIndex = 61;
            this.cbLampAts.Text = "ATS表示灯";
            this.cbLampAts.UseVisualStyleBackColor = true;
            this.cbLampAts.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbLampAtsAlm
            // 
            this.cbLampAtsAlm.AutoSize = true;
            this.cbLampAtsAlm.Location = new System.Drawing.Point(9, 94);
            this.cbLampAtsAlm.Name = "cbLampAtsAlm";
            this.cbLampAtsAlm.Size = new System.Drawing.Size(82, 16);
            this.cbLampAtsAlm.TabIndex = 61;
            this.cbLampAtsAlm.Text = "ATS警報灯";
            this.cbLampAtsAlm.UseVisualStyleBackColor = true;
            this.cbLampAtsAlm.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbUnit4
            // 
            this.cbUnit4.AutoSize = true;
            this.cbUnit4.Location = new System.Drawing.Point(9, 247);
            this.cbUnit4.Name = "cbUnit4";
            this.cbUnit4.Size = new System.Drawing.Size(64, 16);
            this.cbUnit4.TabIndex = 61;
            this.cbUnit4.Text = "ユニット4";
            this.cbUnit4.UseVisualStyleBackColor = true;
            this.cbUnit4.Visible = false;
            this.cbUnit4.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbUnit3
            // 
            this.cbUnit3.AutoSize = true;
            this.cbUnit3.Location = new System.Drawing.Point(9, 226);
            this.cbUnit3.Name = "cbUnit3";
            this.cbUnit3.Size = new System.Drawing.Size(64, 16);
            this.cbUnit3.TabIndex = 61;
            this.cbUnit3.Text = "ユニット3";
            this.cbUnit3.UseVisualStyleBackColor = true;
            this.cbUnit3.Visible = false;
            this.cbUnit3.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbUnit2
            // 
            this.cbUnit2.AutoSize = true;
            this.cbUnit2.Location = new System.Drawing.Point(9, 204);
            this.cbUnit2.Name = "cbUnit2";
            this.cbUnit2.Size = new System.Drawing.Size(64, 16);
            this.cbUnit2.TabIndex = 61;
            this.cbUnit2.Text = "ユニット2";
            this.cbUnit2.UseVisualStyleBackColor = true;
            this.cbUnit2.Visible = false;
            this.cbUnit2.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbUnitDisp
            // 
            this.cbUnitDisp.AutoSize = true;
            this.cbUnitDisp.Location = new System.Drawing.Point(9, 138);
            this.cbUnitDisp.Name = "cbUnitDisp";
            this.cbUnitDisp.Size = new System.Drawing.Size(82, 16);
            this.cbUnitDisp.TabIndex = 61;
            this.cbUnitDisp.Text = "ユニット使用";
            this.cbUnitDisp.UseVisualStyleBackColor = true;
            this.cbUnitDisp.CheckedChanged += new System.EventHandler(this.cbUnitDisp_CheckedChanged);
            // 
            // cbUnit1
            // 
            this.cbUnit1.AutoSize = true;
            this.cbUnit1.Location = new System.Drawing.Point(9, 182);
            this.cbUnit1.Name = "cbUnit1";
            this.cbUnit1.Size = new System.Drawing.Size(64, 16);
            this.cbUnit1.TabIndex = 61;
            this.cbUnit1.Text = "ユニット1";
            this.cbUnit1.UseVisualStyleBackColor = true;
            this.cbUnit1.Visible = false;
            this.cbUnit1.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbLampEb
            // 
            this.cbLampEb.AutoSize = true;
            this.cbLampEb.Location = new System.Drawing.Point(9, 116);
            this.cbLampEb.Name = "cbLampEb";
            this.cbLampEb.Size = new System.Drawing.Size(39, 16);
            this.cbLampEb.TabIndex = 61;
            this.cbLampEb.Text = "EB";
            this.cbLampEb.UseVisualStyleBackColor = true;
            this.cbLampEb.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // tbAtsPDengenTounyuTime
            // 
            this.tbAtsPDengenTounyuTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAtsPDengenTounyuTime.Location = new System.Drawing.Point(120, 331);
            this.tbAtsPDengenTounyuTime.Name = "tbAtsPDengenTounyuTime";
            this.tbAtsPDengenTounyuTime.Size = new System.Drawing.Size(50, 19);
            this.tbAtsPDengenTounyuTime.TabIndex = 14;
            this.tbAtsPDengenTounyuTime.Text = "1.0";
            this.tbAtsPDengenTounyuTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAtsPDengenTounyuTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAtsPDengenTounyuTime_KeyDown);
            // 
            // pnlATSP
            // 
            this.pnlATSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlATSP.Controls.Add(this.cbPBreak);
            this.pnlATSP.Controls.Add(this.cbPFree);
            this.pnlATSP.Controls.Add(this.cbAtsPDengenAuto);
            this.pnlATSP.Controls.Add(this.cbPBroken);
            this.pnlATSP.Controls.Add(this.cbPMode);
            this.pnlATSP.Controls.Add(this.cbPPettern);
            this.pnlATSP.Controls.Add(this.cbPDengen);
            this.pnlATSP.Location = new System.Drawing.Point(100, 38);
            this.pnlATSP.Name = "pnlATSP";
            this.pnlATSP.Size = new System.Drawing.Size(104, 169);
            this.pnlATSP.TabIndex = 88;
            // 
            // cbPBreak
            // 
            this.cbPBreak.AutoSize = true;
            this.cbPBreak.Location = new System.Drawing.Point(10, 52);
            this.cbPBreak.Name = "cbPBreak";
            this.cbPBreak.Size = new System.Drawing.Size(86, 16);
            this.cbPBreak.TabIndex = 61;
            this.cbPBreak.Text = "ブレーキ動作";
            this.cbPBreak.UseVisualStyleBackColor = true;
            this.cbPBreak.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbPFree
            // 
            this.cbPFree.AutoSize = true;
            this.cbPFree.Location = new System.Drawing.Point(10, 73);
            this.cbPFree.Name = "cbPFree";
            this.cbPFree.Size = new System.Drawing.Size(86, 16);
            this.cbPFree.TabIndex = 61;
            this.cbPFree.Text = "ブレーキ解放";
            this.cbPFree.UseVisualStyleBackColor = true;
            this.cbPFree.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbAtsPDengenAuto
            // 
            this.cbAtsPDengenAuto.AutoSize = true;
            this.cbAtsPDengenAuto.Location = new System.Drawing.Point(10, 136);
            this.cbAtsPDengenAuto.Name = "cbAtsPDengenAuto";
            this.cbAtsPDengenAuto.Size = new System.Drawing.Size(72, 16);
            this.cbAtsPDengenAuto.TabIndex = 61;
            this.cbAtsPDengenAuto.Text = "電源Auto";
            this.cbAtsPDengenAuto.UseVisualStyleBackColor = true;
            this.cbAtsPDengenAuto.CheckedChanged += new System.EventHandler(this.cbAtsPDengenAuto_CheckedChanged);
            // 
            // cbPBroken
            // 
            this.cbPBroken.AutoSize = true;
            this.cbPBroken.Location = new System.Drawing.Point(10, 115);
            this.cbPBroken.Name = "cbPBroken";
            this.cbPBroken.Size = new System.Drawing.Size(48, 16);
            this.cbPBroken.TabIndex = 61;
            this.cbPBroken.Text = "故障";
            this.cbPBroken.UseVisualStyleBackColor = true;
            this.cbPBroken.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbPMode
            // 
            this.cbPMode.AutoSize = true;
            this.cbPMode.Location = new System.Drawing.Point(10, 94);
            this.cbPMode.Name = "cbPMode";
            this.cbPMode.Size = new System.Drawing.Size(59, 16);
            this.cbPMode.TabIndex = 61;
            this.cbPMode.Text = "ATS-P";
            this.cbPMode.UseVisualStyleBackColor = true;
            this.cbPMode.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbPPettern
            // 
            this.cbPPettern.AutoSize = true;
            this.cbPPettern.Location = new System.Drawing.Point(10, 31);
            this.cbPPettern.Name = "cbPPettern";
            this.cbPPettern.Size = new System.Drawing.Size(85, 16);
            this.cbPPettern.TabIndex = 61;
            this.cbPPettern.Text = "パターン接近";
            this.cbPPettern.UseVisualStyleBackColor = true;
            this.cbPPettern.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbPDengen
            // 
            this.cbPDengen.AutoSize = true;
            this.cbPDengen.Location = new System.Drawing.Point(10, 10);
            this.cbPDengen.Name = "cbPDengen";
            this.cbPDengen.Size = new System.Drawing.Size(55, 16);
            this.cbPDengen.TabIndex = 61;
            this.cbPDengen.Text = "P電源";
            this.cbPDengen.UseVisualStyleBackColor = true;
            this.cbPDengen.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // tbAtsSDengenTounyuTime
            // 
            this.tbAtsSDengenTounyuTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAtsSDengenTounyuTime.Location = new System.Drawing.Point(17, 331);
            this.tbAtsSDengenTounyuTime.Name = "tbAtsSDengenTounyuTime";
            this.tbAtsSDengenTounyuTime.Size = new System.Drawing.Size(50, 19);
            this.tbAtsSDengenTounyuTime.TabIndex = 14;
            this.tbAtsSDengenTounyuTime.Text = "0.75";
            this.tbAtsSDengenTounyuTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAtsSDengenTounyuTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAtsSDengenTounyuTime_KeyDown);
            // 
            // btnSpdSave
            // 
            this.btnSpdSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpdSave.Enabled = false;
            this.btnSpdSave.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSpdSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpdSave.Location = new System.Drawing.Point(110, 6);
            this.btnSpdSave.Name = "btnSpdSave";
            this.btnSpdSave.Size = new System.Drawing.Size(81, 23);
            this.btnSpdSave.TabIndex = 11;
            this.btnSpdSave.Text = "設定値保存";
            this.btnSpdSave.UseVisualStyleBackColor = false;
            this.btnSpdSave.Click += new System.EventHandler(this.btnSpdSave_Click);
            // 
            // btnSpdRead
            // 
            this.btnSpdRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpdRead.Enabled = false;
            this.btnSpdRead.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSpdRead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpdRead.Location = new System.Drawing.Point(22, 6);
            this.btnSpdRead.Name = "btnSpdRead";
            this.btnSpdRead.Size = new System.Drawing.Size(81, 23);
            this.btnSpdRead.TabIndex = 11;
            this.btnSpdRead.Text = "設定値読込";
            this.btnSpdRead.UseVisualStyleBackColor = false;
            this.btnSpdRead.Click += new System.EventHandler(this.btnSpdRead_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox6.Controls.Add(this.lblTbarMax);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.btnSpdSetSave);
            this.groupBox6.Controls.Add(this.btnSpdSetRead);
            this.groupBox6.Controls.Add(this.tbarSpdTest);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.tbSpdTest);
            this.groupBox6.Controls.Add(this.tbLimit);
            this.groupBox6.Controls.Add(this.btnSpdTest);
            this.groupBox6.Controls.Add(this.btnLimit);
            this.groupBox6.Controls.Add(this.btn160);
            this.groupBox6.Controls.Add(this.btn130);
            this.groupBox6.Controls.Add(this.tb160);
            this.groupBox6.Controls.Add(this.btn100);
            this.groupBox6.Controls.Add(this.tb120);
            this.groupBox6.Controls.Add(this.btn050);
            this.groupBox6.Controls.Add(this.tb080);
            this.groupBox6.Controls.Add(this.btn110);
            this.groupBox6.Controls.Add(this.tb040);
            this.groupBox6.Controls.Add(this.btn040);
            this.groupBox6.Controls.Add(this.tb150);
            this.groupBox6.Controls.Add(this.btn140);
            this.groupBox6.Controls.Add(this.tb110);
            this.groupBox6.Controls.Add(this.btn090);
            this.groupBox6.Controls.Add(this.tb070);
            this.groupBox6.Controls.Add(this.btn030);
            this.groupBox6.Controls.Add(this.tb030);
            this.groupBox6.Controls.Add(this.btn060);
            this.groupBox6.Controls.Add(this.tb140);
            this.groupBox6.Controls.Add(this.btn080);
            this.groupBox6.Controls.Add(this.tb100);
            this.groupBox6.Controls.Add(this.btn120);
            this.groupBox6.Controls.Add(this.tb060);
            this.groupBox6.Controls.Add(this.btn020);
            this.groupBox6.Controls.Add(this.tb130);
            this.groupBox6.Controls.Add(this.btn070);
            this.groupBox6.Controls.Add(this.tb020);
            this.groupBox6.Controls.Add(this.btn010);
            this.groupBox6.Controls.Add(this.tb090);
            this.groupBox6.Controls.Add(this.btn150);
            this.groupBox6.Controls.Add(this.tb050);
            this.groupBox6.Controls.Add(this.tb010);
            this.groupBox6.Location = new System.Drawing.Point(6, 35);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(426, 366);
            this.groupBox6.TabIndex = 86;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "速度計";
            // 
            // lblTbarMax
            // 
            this.lblTbarMax.AutoSize = true;
            this.lblTbarMax.Location = new System.Drawing.Point(243, 147);
            this.lblTbarMax.Name = "lblTbarMax";
            this.lblTbarMax.Size = new System.Drawing.Size(11, 12);
            this.lblTbarMax.TabIndex = 77;
            this.lblTbarMax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "0";
            // 
            // btnSpdSetSave
            // 
            this.btnSpdSetSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpdSetSave.Enabled = false;
            this.btnSpdSetSave.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSpdSetSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpdSetSave.Location = new System.Drawing.Point(103, 38);
            this.btnSpdSetSave.Name = "btnSpdSetSave";
            this.btnSpdSetSave.Size = new System.Drawing.Size(81, 23);
            this.btnSpdSetSave.TabIndex = 11;
            this.btnSpdSetSave.Text = "設定値保存";
            this.btnSpdSetSave.UseVisualStyleBackColor = false;
            this.btnSpdSetSave.Click += new System.EventHandler(this.btnSpdSetSave_Click);
            // 
            // btnSpdSetRead
            // 
            this.btnSpdSetRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpdSetRead.Enabled = false;
            this.btnSpdSetRead.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSpdSetRead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpdSetRead.Location = new System.Drawing.Point(16, 38);
            this.btnSpdSetRead.Name = "btnSpdSetRead";
            this.btnSpdSetRead.Size = new System.Drawing.Size(81, 23);
            this.btnSpdSetRead.TabIndex = 11;
            this.btnSpdSetRead.Text = "設定値読込";
            this.btnSpdSetRead.UseVisualStyleBackColor = false;
            this.btnSpdSetRead.Click += new System.EventHandler(this.btnSpdSetRead_Click);
            // 
            // tbarSpdTest
            // 
            this.tbarSpdTest.LargeChange = 10;
            this.tbarSpdTest.Location = new System.Drawing.Point(3, 116);
            this.tbarSpdTest.Maximum = 120;
            this.tbarSpdTest.Name = "tbarSpdTest";
            this.tbarSpdTest.Size = new System.Drawing.Size(263, 45);
            this.tbarSpdTest.TabIndex = 76;
            this.tbarSpdTest.TickFrequency = 5;
            this.tbarSpdTest.Scroll += new System.EventHandler(this.tbarSpdTest_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 156);
            this.label2.TabIndex = 66;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tbSpdTest
            // 
            this.tbSpdTest.Location = new System.Drawing.Point(155, 94);
            this.tbSpdTest.Name = "tbSpdTest";
            this.tbSpdTest.Size = new System.Drawing.Size(50, 19);
            this.tbSpdTest.TabIndex = 14;
            this.tbSpdTest.Text = "0";
            this.tbSpdTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSpdTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSpdTest_KeyDown);
            // 
            // tbLimit
            // 
            this.tbLimit.Location = new System.Drawing.Point(155, 69);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(50, 19);
            this.tbLimit.TabIndex = 12;
            this.tbLimit.Text = "120";
            this.tbLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLimit_KeyDown);
            // 
            // btnSpdTest
            // 
            this.btnSpdTest.Location = new System.Drawing.Point(16, 92);
            this.btnSpdTest.Name = "btnSpdTest";
            this.btnSpdTest.Size = new System.Drawing.Size(133, 23);
            this.btnSpdTest.TabIndex = 13;
            this.btnSpdTest.Text = "速度表示テスト(km/h)";
            this.btnSpdTest.UseVisualStyleBackColor = true;
            this.btnSpdTest.Click += new System.EventHandler(this.btnSpdTest_Click);
            // 
            // btnLimit
            // 
            this.btnLimit.Location = new System.Drawing.Point(16, 67);
            this.btnLimit.Name = "btnLimit";
            this.btnLimit.Size = new System.Drawing.Size(133, 23);
            this.btnLimit.TabIndex = 11;
            this.btnLimit.Text = "最高速度(km/h)";
            this.btnLimit.UseVisualStyleBackColor = true;
            this.btnLimit.Click += new System.EventHandler(this.btnLimit_Click);
            // 
            // btn160
            // 
            this.btn160.Location = new System.Drawing.Point(283, 11);
            this.btn160.Name = "btn160";
            this.btn160.Size = new System.Drawing.Size(75, 23);
            this.btn160.TabIndex = 21;
            this.btn160.Text = "160km/h";
            this.btn160.UseVisualStyleBackColor = true;
            this.btn160.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // tb160
            // 
            this.tb160.Location = new System.Drawing.Point(364, 13);
            this.tb160.Name = "tb160";
            this.tb160.Size = new System.Drawing.Size(50, 19);
            this.tb160.TabIndex = 22;
            this.tb160.Text = "4095";
            this.tb160.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb160.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb120
            // 
            this.tb120.Location = new System.Drawing.Point(364, 100);
            this.tb120.Name = "tb120";
            this.tb120.Size = new System.Drawing.Size(50, 19);
            this.tb120.TabIndex = 30;
            this.tb120.Text = "3650";
            this.tb120.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb120.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb080
            // 
            this.tb080.Location = new System.Drawing.Point(364, 188);
            this.tb080.Name = "tb080";
            this.tb080.Size = new System.Drawing.Size(50, 19);
            this.tb080.TabIndex = 38;
            this.tb080.Text = "2340";
            this.tb080.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb080.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb040
            // 
            this.tb040.Location = new System.Drawing.Point(364, 276);
            this.tb040.Name = "tb040";
            this.tb040.Size = new System.Drawing.Size(50, 19);
            this.tb040.TabIndex = 46;
            this.tb040.Text = "1010";
            this.tb040.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb040.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb150
            // 
            this.tb150.Location = new System.Drawing.Point(364, 35);
            this.tb150.Name = "tb150";
            this.tb150.Size = new System.Drawing.Size(50, 19);
            this.tb150.TabIndex = 24;
            this.tb150.Text = "4095";
            this.tb150.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb150.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb110
            // 
            this.tb110.Location = new System.Drawing.Point(364, 122);
            this.tb110.Name = "tb110";
            this.tb110.Size = new System.Drawing.Size(50, 19);
            this.tb110.TabIndex = 32;
            this.tb110.Text = "3340";
            this.tb110.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb110.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb070
            // 
            this.tb070.Location = new System.Drawing.Point(364, 210);
            this.tb070.Name = "tb070";
            this.tb070.Size = new System.Drawing.Size(50, 19);
            this.tb070.TabIndex = 40;
            this.tb070.Text = "2000";
            this.tb070.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb070.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb030
            // 
            this.tb030.Location = new System.Drawing.Point(364, 298);
            this.tb030.Name = "tb030";
            this.tb030.Size = new System.Drawing.Size(50, 19);
            this.tb030.TabIndex = 48;
            this.tb030.Text = "680";
            this.tb030.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb030.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb140
            // 
            this.tb140.Location = new System.Drawing.Point(364, 57);
            this.tb140.Name = "tb140";
            this.tb140.Size = new System.Drawing.Size(50, 19);
            this.tb140.TabIndex = 26;
            this.tb140.Text = "4095";
            this.tb140.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb140.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb100
            // 
            this.tb100.Location = new System.Drawing.Point(364, 144);
            this.tb100.Name = "tb100";
            this.tb100.Size = new System.Drawing.Size(50, 19);
            this.tb100.TabIndex = 34;
            this.tb100.Text = "3020";
            this.tb100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb100.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb060
            // 
            this.tb060.Location = new System.Drawing.Point(364, 232);
            this.tb060.Name = "tb060";
            this.tb060.Size = new System.Drawing.Size(50, 19);
            this.tb060.TabIndex = 42;
            this.tb060.Text = "1650";
            this.tb060.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb060.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb130
            // 
            this.tb130.Location = new System.Drawing.Point(364, 79);
            this.tb130.Name = "tb130";
            this.tb130.Size = new System.Drawing.Size(50, 19);
            this.tb130.TabIndex = 28;
            this.tb130.Text = "4000";
            this.tb130.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb130.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb020
            // 
            this.tb020.Location = new System.Drawing.Point(364, 320);
            this.tb020.Name = "tb020";
            this.tb020.Size = new System.Drawing.Size(50, 19);
            this.tb020.TabIndex = 50;
            this.tb020.Text = "400";
            this.tb020.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb020.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb090
            // 
            this.tb090.Location = new System.Drawing.Point(364, 166);
            this.tb090.Name = "tb090";
            this.tb090.Size = new System.Drawing.Size(50, 19);
            this.tb090.TabIndex = 36;
            this.tb090.Text = "2680";
            this.tb090.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb090.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb050
            // 
            this.tb050.Location = new System.Drawing.Point(364, 254);
            this.tb050.Name = "tb050";
            this.tb050.Size = new System.Drawing.Size(50, 19);
            this.tb050.TabIndex = 44;
            this.tb050.Text = "1330";
            this.tb050.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb050.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // tb010
            // 
            this.tb010.AcceptsReturn = true;
            this.tb010.Location = new System.Drawing.Point(364, 342);
            this.tb010.Name = "tb010";
            this.tb010.Size = new System.Drawing.Size(50, 19);
            this.tb010.TabIndex = 52;
            this.tb010.Text = "150";
            this.tb010.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb010.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTb_KeyDown);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Ivory;
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.tbarCurrentTest);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.rbVolt);
            this.groupBox8.Controls.Add(this.rbCurrent);
            this.groupBox8.Controls.Add(this.cbKaisei);
            this.groupBox8.Controls.Add(this.tbOhm);
            this.groupBox8.Controls.Add(this.tbCurrentTest);
            this.groupBox8.Controls.Add(this.btnOhm);
            this.groupBox8.Controls.Add(this.btnCurrentTest);
            this.groupBox8.Location = new System.Drawing.Point(770, 35);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(330, 510);
            this.groupBox8.TabIndex = 88;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "電圧/電流計";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 81;
            this.label8.Text = "+1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 80;
            this.label7.Text = "-1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 79;
            this.label6.Text = "0";
            // 
            // tbarCurrentTest
            // 
            this.tbarCurrentTest.Location = new System.Drawing.Point(27, 123);
            this.tbarCurrentTest.Maximum = 1000;
            this.tbarCurrentTest.Minimum = -1000;
            this.tbarCurrentTest.Name = "tbarCurrentTest";
            this.tbarCurrentTest.Size = new System.Drawing.Size(263, 45);
            this.tbarCurrentTest.TabIndex = 78;
            this.tbarCurrentTest.TickFrequency = 50;
            this.tbarCurrentTest.Scroll += new System.EventHandler(this.tbarCurrentTest_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 180);
            this.label3.TabIndex = 66;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // rbVolt
            // 
            this.rbVolt.AutoSize = true;
            this.rbVolt.Location = new System.Drawing.Point(148, 18);
            this.rbVolt.Name = "rbVolt";
            this.rbVolt.Size = new System.Drawing.Size(59, 16);
            this.rbVolt.TabIndex = 72;
            this.rbVolt.Text = "電圧計";
            this.rbVolt.UseVisualStyleBackColor = true;
            this.rbVolt.CheckedChanged += new System.EventHandler(this.rbVolt_CheckedChanged);
            this.rbVolt.Click += new System.EventHandler(this.rbVolt_Click);
            // 
            // rbCurrent
            // 
            this.rbCurrent.AutoSize = true;
            this.rbCurrent.Checked = true;
            this.rbCurrent.Location = new System.Drawing.Point(73, 18);
            this.rbCurrent.Name = "rbCurrent";
            this.rbCurrent.Size = new System.Drawing.Size(59, 16);
            this.rbCurrent.TabIndex = 71;
            this.rbCurrent.TabStop = true;
            this.rbCurrent.Text = "電流計";
            this.rbCurrent.UseVisualStyleBackColor = true;
            this.rbCurrent.Click += new System.EventHandler(this.rbCurrent_Click);
            // 
            // cbKaisei
            // 
            this.cbKaisei.AutoSize = true;
            this.cbKaisei.Location = new System.Drawing.Point(73, 43);
            this.cbKaisei.Name = "cbKaisei";
            this.cbKaisei.Size = new System.Drawing.Size(201, 16);
            this.cbKaisei.TabIndex = 75;
            this.cbKaisei.Text = "回生対応(※電流マイナス表示対応)";
            this.cbKaisei.UseVisualStyleBackColor = true;
            this.cbKaisei.Click += new System.EventHandler(this.cbKaisei_Click);
            // 
            // tbOhm
            // 
            this.tbOhm.Location = new System.Drawing.Point(181, 65);
            this.tbOhm.Name = "tbOhm";
            this.tbOhm.Size = new System.Drawing.Size(50, 19);
            this.tbOhm.TabIndex = 74;
            this.tbOhm.Text = "500";
            this.tbOhm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOhm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOhm_KeyDown);
            // 
            // tbCurrentTest
            // 
            this.tbCurrentTest.Location = new System.Drawing.Point(181, 90);
            this.tbCurrentTest.Name = "tbCurrentTest";
            this.tbCurrentTest.Size = new System.Drawing.Size(50, 19);
            this.tbCurrentTest.TabIndex = 74;
            this.tbCurrentTest.Text = "0";
            this.tbCurrentTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCurrentTest_KeyDown);
            // 
            // btnOhm
            // 
            this.btnOhm.Location = new System.Drawing.Point(42, 63);
            this.btnOhm.Name = "btnOhm";
            this.btnOhm.Size = new System.Drawing.Size(133, 23);
            this.btnOhm.TabIndex = 73;
            this.btnOhm.Text = "列車抵抗(mΩ)";
            this.btnOhm.UseVisualStyleBackColor = true;
            this.btnOhm.Click += new System.EventHandler(this.btnOhm_Click);
            // 
            // btnCurrentTest
            // 
            this.btnCurrentTest.Location = new System.Drawing.Point(42, 88);
            this.btnCurrentTest.Name = "btnCurrentTest";
            this.btnCurrentTest.Size = new System.Drawing.Size(133, 23);
            this.btnCurrentTest.TabIndex = 73;
            this.btnCurrentTest.Text = "電流表示テスト(A)";
            this.btnCurrentTest.UseVisualStyleBackColor = true;
            this.btnCurrentTest.Click += new System.EventHandler(this.btnCurrentTest_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.cbBVEForceMode);
            this.tabPage3.Controls.Add(this.cbTransferEBState);
            this.tabPage3.Controls.Add(this.cbAtsActiveMode);
            this.tabPage3.Controls.Add(this.btnATSDengenAngle);
            this.tabPage3.Controls.Add(this.tbATSDengenAngle);
            this.tabPage3.Controls.Add(this.label112);
            this.tabPage3.Controls.Add(this.cbxATSDengen);
            this.tabPage3.Controls.Add(this.label111);
            this.tabPage3.Controls.Add(this.lblPanto);
            this.tabPage3.Controls.Add(this.cbMeterCheck);
            this.tabPage3.Controls.Add(this.cbxB1Dengen);
            this.tabPage3.Controls.Add(this.cbxPanto);
            this.tabPage3.Controls.Add(this.cbAtsContactUse);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.cbAtsConf);
            this.tabPage3.Controls.Add(this.cbDecEB);
            this.tabPage3.Controls.Add(this.cbHorn2);
            this.tabPage3.Controls.Add(this.cbHorn1);
            this.tabPage3.Controls.Add(this.cbEB);
            this.tabPage3.Controls.Add(this.cbAtsRec);
            this.tabPage3.Controls.Add(this.cbAtsCont);
            this.tabPage3.Controls.Add(this.btnBrkSave);
            this.tabPage3.Controls.Add(this.btnBrkRead);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1149, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "コントローラー";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cbBVEForceMode
            // 
            this.cbBVEForceMode.AutoSize = true;
            this.cbBVEForceMode.Location = new System.Drawing.Point(22, 535);
            this.cbBVEForceMode.Name = "cbBVEForceMode";
            this.cbBVEForceMode.Size = new System.Drawing.Size(159, 16);
            this.cbBVEForceMode.TabIndex = 103;
            this.cbBVEForceMode.Text = "電源投入時強制BVEモード";
            this.cbBVEForceMode.UseVisualStyleBackColor = true;
            this.cbBVEForceMode.Click += new System.EventHandler(this.cbAtsConf_Click);
            // 
            // cbTransferEBState
            // 
            this.cbTransferEBState.AutoSize = true;
            this.cbTransferEBState.Location = new System.Drawing.Point(22, 513);
            this.cbTransferEBState.Name = "cbTransferEBState";
            this.cbTransferEBState.Size = new System.Drawing.Size(163, 16);
            this.cbTransferEBState.TabIndex = 103;
            this.cbTransferEBState.Text = "EB投入状態を強制転送する";
            this.cbTransferEBState.UseVisualStyleBackColor = true;
            this.cbTransferEBState.Click += new System.EventHandler(this.cbAtsConf_Click);
            // 
            // cbAtsActiveMode
            // 
            this.cbAtsActiveMode.AutoSize = true;
            this.cbAtsActiveMode.Location = new System.Drawing.Point(22, 491);
            this.cbAtsActiveMode.Name = "cbAtsActiveMode";
            this.cbAtsActiveMode.Size = new System.Drawing.Size(163, 16);
            this.cbAtsActiveMode.TabIndex = 102;
            this.cbAtsActiveMode.Text = "ATS警報器/BZ21鳴動許可";
            this.cbAtsActiveMode.UseVisualStyleBackColor = true;
            this.cbAtsActiveMode.Click += new System.EventHandler(this.cbAtsActiveMode_Click);
            // 
            // btnATSDengenAngle
            // 
            this.btnATSDengenAngle.Location = new System.Drawing.Point(636, 513);
            this.btnATSDengenAngle.Name = "btnATSDengenAngle";
            this.btnATSDengenAngle.Size = new System.Drawing.Size(107, 23);
            this.btnATSDengenAngle.TabIndex = 97;
            this.btnATSDengenAngle.Text = "ATS電源[°](155)";
            this.btnATSDengenAngle.UseVisualStyleBackColor = true;
            this.btnATSDengenAngle.Click += new System.EventHandler(this.btnATSDengenAngle_Click);
            // 
            // tbATSDengenAngle
            // 
            this.tbATSDengenAngle.Location = new System.Drawing.Point(749, 515);
            this.tbATSDengenAngle.Name = "tbATSDengenAngle";
            this.tbATSDengenAngle.Size = new System.Drawing.Size(50, 19);
            this.tbATSDengenAngle.TabIndex = 97;
            this.tbATSDengenAngle.Text = "155";
            this.tbATSDengenAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbATSDengenAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbATSDengenAngle_KeyDown);
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(440, 517);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(75, 12);
            this.label112.TabIndex = 101;
            this.label112.Text = "ATS電源情報";
            // 
            // cbxATSDengen
            // 
            this.cbxATSDengen.FormattingEnabled = true;
            this.cbxATSDengen.Items.AddRange(new object[] {
            "接点",
            "ポテンショ"});
            this.cbxATSDengen.Location = new System.Drawing.Point(560, 514);
            this.cbxATSDengen.Name = "cbxATSDengen";
            this.cbxATSDengen.Size = new System.Drawing.Size(72, 20);
            this.cbxATSDengen.TabIndex = 100;
            this.cbxATSDengen.Text = "接点";
            this.cbxATSDengen.SelectedIndexChanged += new System.EventHandler(this.cbAtsConf_Click);
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(440, 493);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(67, 12);
            this.label111.TabIndex = 99;
            this.label111.Text = "B1電源情報";
            // 
            // lblPanto
            // 
            this.lblPanto.AutoSize = true;
            this.lblPanto.Location = new System.Drawing.Point(440, 470);
            this.lblPanto.Name = "lblPanto";
            this.lblPanto.Size = new System.Drawing.Size(119, 12);
            this.lblPanto.TabIndex = 97;
            this.lblPanto.Text = "パンタ下ボタン押下動作";
            // 
            // cbMeterCheck
            // 
            this.cbMeterCheck.AutoSize = true;
            this.cbMeterCheck.Location = new System.Drawing.Point(424, 448);
            this.cbMeterCheck.Name = "cbMeterCheck";
            this.cbMeterCheck.Size = new System.Drawing.Size(151, 16);
            this.cbMeterCheck.TabIndex = 88;
            this.cbMeterCheck.Text = "電源投入時メーターチェック";
            this.cbMeterCheck.UseVisualStyleBackColor = true;
            this.cbMeterCheck.Click += new System.EventHandler(this.cbInputFlip_Click);
            // 
            // cbxB1Dengen
            // 
            this.cbxB1Dengen.FormattingEnabled = true;
            this.cbxB1Dengen.Items.AddRange(new object[] {
            "接点",
            "ポテンショ"});
            this.cbxB1Dengen.Location = new System.Drawing.Point(560, 490);
            this.cbxB1Dengen.Name = "cbxB1Dengen";
            this.cbxB1Dengen.Size = new System.Drawing.Size(72, 20);
            this.cbxB1Dengen.TabIndex = 98;
            this.cbxB1Dengen.Text = "接点";
            this.cbxB1Dengen.SelectedIndexChanged += new System.EventHandler(this.cbAtsConf_Click);
            // 
            // cbxPanto
            // 
            this.cbxPanto.FormattingEnabled = true;
            this.cbxPanto.Items.AddRange(new object[] {
            "Alt+F4",
            "P"});
            this.cbxPanto.Location = new System.Drawing.Point(560, 466);
            this.cbxPanto.Name = "cbxPanto";
            this.cbxPanto.Size = new System.Drawing.Size(72, 20);
            this.cbxPanto.TabIndex = 98;
            this.cbxPanto.Text = "Alt+F4";
            this.cbxPanto.SelectedIndexChanged += new System.EventHandler(this.cbAtsConf_Click);
            // 
            // cbAtsContactUse
            // 
            this.cbAtsContactUse.AutoSize = true;
            this.cbAtsContactUse.Location = new System.Drawing.Point(22, 426);
            this.cbAtsContactUse.Name = "cbAtsContactUse";
            this.cbAtsContactUse.Size = new System.Drawing.Size(391, 16);
            this.cbAtsContactUse.TabIndex = 87;
            this.cbAtsContactUse.Text = "ATS接点情報伝送(制御基板にブレーキ弁接点を入力している場合にチェック)";
            this.cbAtsContactUse.UseVisualStyleBackColor = true;
            this.cbAtsContactUse.Click += new System.EventHandler(this.cbAtsContactUse_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox12.Controls.Add(this.lblBrkNotch);
            this.groupBox12.Controls.Add(this.cbPotMode);
            this.groupBox12.Controls.Add(this.cbModeN);
            this.groupBox12.Location = new System.Drawing.Point(375, 244);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(433, 132);
            this.groupBox12.TabIndex = 84;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "ブレーキ調整用";
            // 
            // lblBrkNotch
            // 
            this.lblBrkNotch.AutoSize = true;
            this.lblBrkNotch.BackColor = System.Drawing.Color.Yellow;
            this.lblBrkNotch.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBrkNotch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBrkNotch.Location = new System.Drawing.Point(79, 57);
            this.lblBrkNotch.Name = "lblBrkNotch";
            this.lblBrkNotch.Size = new System.Drawing.Size(28, 27);
            this.lblBrkNotch.TabIndex = 78;
            this.lblBrkNotch.Text = "  ";
            // 
            // cbPotMode
            // 
            this.cbPotMode.AutoSize = true;
            this.cbPotMode.Location = new System.Drawing.Point(206, 72);
            this.cbPotMode.Name = "cbPotMode";
            this.cbPotMode.Size = new System.Drawing.Size(118, 16);
            this.cbPotMode.TabIndex = 76;
            this.cbPotMode.Text = "デバッグ(POTモード)";
            this.cbPotMode.UseVisualStyleBackColor = true;
            this.cbPotMode.CheckedChanged += new System.EventHandler(this.cbPotMode_CheckedChanged);
            // 
            // cbModeN
            // 
            this.cbModeN.AutoSize = true;
            this.cbModeN.Location = new System.Drawing.Point(206, 50);
            this.cbModeN.Name = "cbModeN";
            this.cbModeN.Size = new System.Drawing.Size(181, 16);
            this.cbModeN.TabIndex = 76;
            this.cbModeN.Text = "ブレーキ段表示モード(レバーサN)";
            this.cbModeN.UseVisualStyleBackColor = true;
            this.cbModeN.CheckedChanged += new System.EventHandler(this.cbModeN_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox11.Controls.Add(this.btnMcNumMax);
            this.groupBox11.Controls.Add(this.btnMcNum);
            this.groupBox11.Controls.Add(this.tbMcNumMax);
            this.groupBox11.Controls.Add(this.tbMcNum);
            this.groupBox11.Location = new System.Drawing.Point(6, 304);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(363, 72);
            this.groupBox11.TabIndex = 83;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "マスコン設定";
            // 
            // btnMcNumMax
            // 
            this.btnMcNumMax.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMcNumMax.Location = new System.Drawing.Point(13, 19);
            this.btnMcNumMax.Name = "btnMcNumMax";
            this.btnMcNumMax.Size = new System.Drawing.Size(167, 23);
            this.btnMcNumMax.TabIndex = 29;
            this.btnMcNumMax.Text = "マスコン段数(コントローラー)(5)";
            this.btnMcNumMax.UseVisualStyleBackColor = true;
            this.btnMcNumMax.Click += new System.EventHandler(this.btnMcNumMax_Click);
            // 
            // btnMcNum
            // 
            this.btnMcNum.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMcNum.Location = new System.Drawing.Point(13, 44);
            this.btnMcNum.Name = "btnMcNum";
            this.btnMcNum.Size = new System.Drawing.Size(167, 23);
            this.btnMcNum.TabIndex = 29;
            this.btnMcNum.Text = "マスコン段数(BVE車両)(5)";
            this.btnMcNum.UseVisualStyleBackColor = true;
            this.btnMcNum.Click += new System.EventHandler(this.btnMcNum_Click);
            // 
            // tbMcNumMax
            // 
            this.tbMcNumMax.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMcNumMax.Location = new System.Drawing.Point(188, 21);
            this.tbMcNumMax.Name = "tbMcNumMax";
            this.tbMcNumMax.Size = new System.Drawing.Size(50, 19);
            this.tbMcNumMax.TabIndex = 30;
            this.tbMcNumMax.Text = "5";
            this.tbMcNumMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMcNumMax.TextChanged += new System.EventHandler(this.tbMcNumMax_TextChanged);
            this.tbMcNumMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMcNumMax_KeyDown);
            // 
            // tbMcNum
            // 
            this.tbMcNum.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMcNum.Location = new System.Drawing.Point(188, 46);
            this.tbMcNum.Name = "tbMcNum";
            this.tbMcNum.Size = new System.Drawing.Size(50, 19);
            this.tbMcNum.TabIndex = 30;
            this.tbMcNum.Text = "5";
            this.tbMcNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMcNum.TextChanged += new System.EventHandler(this.tbMcNum_TextChanged);
            this.tbMcNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMcNum_KeyDown);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Azure;
            this.groupBox10.Controls.Add(this.lblAutoNotch);
            this.groupBox10.Controls.Add(this.cbxAutoNotch);
            this.groupBox10.Controls.Add(this.btnAdjEB);
            this.groupBox10.Controls.Add(this.btnAdjN);
            this.groupBox10.Controls.Add(this.label60);
            this.groupBox10.Controls.Add(this.label59);
            this.groupBox10.Controls.Add(this.label58);
            this.groupBox10.Controls.Add(this.lblChatFilter);
            this.groupBox10.Controls.Add(this.tbSapAngl);
            this.groupBox10.Controls.Add(this.btnBrkNum);
            this.groupBox10.Controls.Add(this.tbBrkSapMinAngl);
            this.groupBox10.Controls.Add(this.tbBrkSapMaxAngl);
            this.groupBox10.Controls.Add(this.tbAdjEB);
            this.groupBox10.Controls.Add(this.tbAdjN);
            this.groupBox10.Controls.Add(this.tbBrkNum);
            this.groupBox10.Controls.Add(this.tbEBAngl);
            this.groupBox10.Controls.Add(this.tbChatFilter);
            this.groupBox10.Controls.Add(this.tbBrkFullAngl);
            this.groupBox10.Controls.Add(this.btnSapAngl);
            this.groupBox10.Controls.Add(this.btnBrkSapMinAngl);
            this.groupBox10.Controls.Add(this.btnBrkSapMaxAngl);
            this.groupBox10.Controls.Add(this.btnEBAngl);
            this.groupBox10.Controls.Add(this.btnChatFilter);
            this.groupBox10.Controls.Add(this.btnBrkFullAngl);
            this.groupBox10.Location = new System.Drawing.Point(6, 35);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(363, 265);
            this.groupBox10.TabIndex = 82;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ブレーキ設定";
            // 
            // lblAutoNotch
            // 
            this.lblAutoNotch.AutoSize = true;
            this.lblAutoNotch.Location = new System.Drawing.Point(17, 243);
            this.lblAutoNotch.Name = "lblAutoNotch";
            this.lblAutoNotch.Size = new System.Drawing.Size(145, 12);
            this.lblAutoNotch.TabIndex = 89;
            this.lblAutoNotch.Text = "路線起動時自動ノッチ合わせ";
            // 
            // cbxAutoNotch
            // 
            this.cbxAutoNotch.FormattingEnabled = true;
            this.cbxAutoNotch.Items.AddRange(new object[] {
            "しない",
            "常時",
            "路線起動時"});
            this.cbxAutoNotch.Location = new System.Drawing.Point(168, 240);
            this.cbxAutoNotch.Name = "cbxAutoNotch";
            this.cbxAutoNotch.Size = new System.Drawing.Size(108, 20);
            this.cbxAutoNotch.TabIndex = 96;
            this.cbxAutoNotch.Text = "しない";
            this.cbxAutoNotch.SelectedIndexChanged += new System.EventHandler(this.cbxAutoNotch_SelectedIndexChanged);
            // 
            // btnAdjEB
            // 
            this.btnAdjEB.BackColor = System.Drawing.Color.Pink;
            this.btnAdjEB.Location = new System.Drawing.Point(262, 132);
            this.btnAdjEB.Name = "btnAdjEB";
            this.btnAdjEB.Size = new System.Drawing.Size(86, 23);
            this.btnAdjEB.TabIndex = 95;
            this.btnAdjEB.Text = "EB位置調整";
            this.btnAdjEB.UseVisualStyleBackColor = false;
            this.btnAdjEB.Click += new System.EventHandler(this.btnAdjEB_Click);
            // 
            // btnAdjN
            // 
            this.btnAdjN.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAdjN.Location = new System.Drawing.Point(262, 69);
            this.btnAdjN.Name = "btnAdjN";
            this.btnAdjN.Size = new System.Drawing.Size(86, 23);
            this.btnAdjN.TabIndex = 95;
            this.btnAdjN.Text = "N位置調整";
            this.btnAdjN.UseVisualStyleBackColor = false;
            this.btnAdjN.Click += new System.EventHandler(this.btnAdjN_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(16, 36);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(332, 12);
            this.label60.TabIndex = 77;
            this.label60.Text = "それぞれ3秒以上長押ししてください。　※非常抜取タイプは抜取位置";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(16, 19);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(287, 12);
            this.label59.TabIndex = 77;
            this.label59.Text = "設定前に、緩め位置で青ボタン、非常(※)位置で赤ボタンを";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(16, 53);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(260, 12);
            this.label58.TabIndex = 77;
            this.label58.Text = "カッコ内が標準値です。環境により微調整してください。";
            // 
            // lblChatFilter
            // 
            this.lblChatFilter.AutoSize = true;
            this.lblChatFilter.Location = new System.Drawing.Point(225, 219);
            this.lblChatFilter.Name = "lblChatFilter";
            this.lblChatFilter.Size = new System.Drawing.Size(129, 12);
            this.lblChatFilter.TabIndex = 77;
            this.lblChatFilter.Text = "0無効、1標準、2中、3強)";
            // 
            // tbSapAngl
            // 
            this.tbSapAngl.Location = new System.Drawing.Point(170, 93);
            this.tbSapAngl.Name = "tbSapAngl";
            this.tbSapAngl.Size = new System.Drawing.Size(50, 19);
            this.tbSapAngl.TabIndex = 32;
            this.tbSapAngl.Text = "80";
            this.tbSapAngl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSapAngl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSapAngl_KeyDown);
            // 
            // btnBrkNum
            // 
            this.btnBrkNum.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBrkNum.Location = new System.Drawing.Point(13, 69);
            this.btnBrkNum.Name = "btnBrkNum";
            this.btnBrkNum.Size = new System.Drawing.Size(151, 23);
            this.btnBrkNum.TabIndex = 29;
            this.btnBrkNum.Text = "ブレーキ段数(8)";
            this.btnBrkNum.UseVisualStyleBackColor = true;
            this.btnBrkNum.Click += new System.EventHandler(this.btnBrkNum_Click);
            // 
            // tbBrkSapMinAngl
            // 
            this.tbBrkSapMinAngl.Location = new System.Drawing.Point(169, 163);
            this.tbBrkSapMinAngl.Name = "tbBrkSapMinAngl";
            this.tbBrkSapMinAngl.Size = new System.Drawing.Size(50, 19);
            this.tbBrkSapMinAngl.TabIndex = 34;
            this.tbBrkSapMinAngl.Text = "5";
            this.tbBrkSapMinAngl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBrkSapMinAngl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBrkSapMinAngl_KeyDown);
            // 
            // tbBrkSapMaxAngl
            // 
            this.tbBrkSapMaxAngl.Location = new System.Drawing.Point(169, 184);
            this.tbBrkSapMaxAngl.Name = "tbBrkSapMaxAngl";
            this.tbBrkSapMaxAngl.Size = new System.Drawing.Size(50, 19);
            this.tbBrkSapMaxAngl.TabIndex = 34;
            this.tbBrkSapMaxAngl.Text = "67";
            this.tbBrkSapMaxAngl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBrkSapMaxAngl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBrkMaxAngl_KeyDown);
            // 
            // tbAdjEB
            // 
            this.tbAdjEB.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAdjEB.Location = new System.Drawing.Point(283, 158);
            this.tbAdjEB.Name = "tbAdjEB";
            this.tbAdjEB.Size = new System.Drawing.Size(50, 19);
            this.tbAdjEB.TabIndex = 30;
            this.tbAdjEB.Text = "1023";
            this.tbAdjEB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAdjEB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdjEB_KeyDown);
            // 
            // tbAdjN
            // 
            this.tbAdjN.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAdjN.Location = new System.Drawing.Point(283, 93);
            this.tbAdjN.Name = "tbAdjN";
            this.tbAdjN.Size = new System.Drawing.Size(50, 19);
            this.tbAdjN.TabIndex = 30;
            this.tbAdjN.Text = "0";
            this.tbAdjN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAdjN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdjN_KeyDown);
            // 
            // tbBrkNum
            // 
            this.tbBrkNum.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBrkNum.Location = new System.Drawing.Point(170, 71);
            this.tbBrkNum.Name = "tbBrkNum";
            this.tbBrkNum.Size = new System.Drawing.Size(50, 19);
            this.tbBrkNum.TabIndex = 30;
            this.tbBrkNum.Text = "8";
            this.tbBrkNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBrkNum.TextChanged += new System.EventHandler(this.tbBrkNum_TextChanged);
            this.tbBrkNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBrkNum_KeyDown);
            // 
            // tbEBAngl
            // 
            this.tbEBAngl.Location = new System.Drawing.Point(169, 115);
            this.tbEBAngl.Name = "tbEBAngl";
            this.tbEBAngl.Size = new System.Drawing.Size(50, 19);
            this.tbEBAngl.TabIndex = 34;
            this.tbEBAngl.Text = "150";
            this.tbEBAngl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEBAngl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEBAngl_KeyDown);
            // 
            // tbChatFilter
            // 
            this.tbChatFilter.Location = new System.Drawing.Point(169, 216);
            this.tbChatFilter.Name = "tbChatFilter";
            this.tbChatFilter.Size = new System.Drawing.Size(50, 19);
            this.tbChatFilter.TabIndex = 36;
            this.tbChatFilter.Text = "1";
            this.tbChatFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbChatFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChatFilter_KeyDown);
            // 
            // tbBrkFullAngl
            // 
            this.tbBrkFullAngl.Location = new System.Drawing.Point(169, 137);
            this.tbBrkFullAngl.Name = "tbBrkFullAngl";
            this.tbBrkFullAngl.Size = new System.Drawing.Size(50, 19);
            this.tbBrkFullAngl.TabIndex = 36;
            this.tbBrkFullAngl.Text = "165";
            this.tbBrkFullAngl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBrkFullAngl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBrkFullAngl_KeyDown);
            // 
            // btnSapAngl
            // 
            this.btnSapAngl.Location = new System.Drawing.Point(13, 91);
            this.btnSapAngl.Name = "btnSapAngl";
            this.btnSapAngl.Size = new System.Drawing.Size(151, 23);
            this.btnSapAngl.TabIndex = 31;
            this.btnSapAngl.Text = "直通帯幅[°](80)";
            this.btnSapAngl.UseVisualStyleBackColor = true;
            this.btnSapAngl.Click += new System.EventHandler(this.btnSapAngl_Click);
            // 
            // btnBrkSapMinAngl
            // 
            this.btnBrkSapMinAngl.Location = new System.Drawing.Point(13, 162);
            this.btnBrkSapMinAngl.Name = "btnBrkSapMinAngl";
            this.btnBrkSapMinAngl.Size = new System.Drawing.Size(150, 23);
            this.btnBrkSapMinAngl.TabIndex = 33;
            this.btnBrkSapMinAngl.Text = "直通帯最小角度[°](5)";
            this.btnBrkSapMinAngl.UseVisualStyleBackColor = true;
            this.btnBrkSapMinAngl.Click += new System.EventHandler(this.btnBrkSapMinAngl_Click);
            // 
            // btnBrkSapMaxAngl
            // 
            this.btnBrkSapMaxAngl.Location = new System.Drawing.Point(13, 184);
            this.btnBrkSapMaxAngl.Name = "btnBrkSapMaxAngl";
            this.btnBrkSapMaxAngl.Size = new System.Drawing.Size(150, 23);
            this.btnBrkSapMaxAngl.TabIndex = 33;
            this.btnBrkSapMaxAngl.Text = "常用最大角度[°](67)";
            this.btnBrkSapMaxAngl.UseVisualStyleBackColor = true;
            this.btnBrkSapMaxAngl.Click += new System.EventHandler(this.btnBrkSapMaxAngl_Click);
            // 
            // btnEBAngl
            // 
            this.btnEBAngl.Location = new System.Drawing.Point(13, 113);
            this.btnEBAngl.Name = "btnEBAngl";
            this.btnEBAngl.Size = new System.Drawing.Size(150, 23);
            this.btnEBAngl.TabIndex = 33;
            this.btnEBAngl.Text = "非常角度位置[°](150)";
            this.btnEBAngl.UseVisualStyleBackColor = true;
            this.btnEBAngl.Click += new System.EventHandler(this.btnEBAngl_Click);
            // 
            // btnChatFilter
            // 
            this.btnChatFilter.Location = new System.Drawing.Point(13, 214);
            this.btnChatFilter.Name = "btnChatFilter";
            this.btnChatFilter.Size = new System.Drawing.Size(150, 23);
            this.btnChatFilter.TabIndex = 35;
            this.btnChatFilter.Text = "チャタリング防止[°](0～)";
            this.btnChatFilter.UseVisualStyleBackColor = true;
            this.btnChatFilter.Click += new System.EventHandler(this.btnChatFilter_Click);
            // 
            // btnBrkFullAngl
            // 
            this.btnBrkFullAngl.Location = new System.Drawing.Point(13, 135);
            this.btnBrkFullAngl.Name = "btnBrkFullAngl";
            this.btnBrkFullAngl.Size = new System.Drawing.Size(150, 23);
            this.btnBrkFullAngl.TabIndex = 35;
            this.btnBrkFullAngl.Text = "ブレーキ全体角度[°](165)";
            this.btnBrkFullAngl.UseVisualStyleBackColor = true;
            this.btnBrkFullAngl.Click += new System.EventHandler(this.btnBrkFullAngl_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox9.Controls.Add(this.pnlAutoair);
            this.groupBox9.Controls.Add(this.cbAutoAirEX);
            this.groupBox9.Controls.Add(this.cbRealAutoAir);
            this.groupBox9.Controls.Add(this.cbAutoairUse);
            this.groupBox9.Location = new System.Drawing.Point(375, 35);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(433, 203);
            this.groupBox9.TabIndex = 81;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "自動帯";
            // 
            // pnlAutoair
            // 
            this.pnlAutoair.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlAutoair.Controls.Add(this.label44);
            this.pnlAutoair.Controls.Add(this.tbnKeep);
            this.pnlAutoair.Controls.Add(this.btnKeepFull);
            this.pnlAutoair.Controls.Add(this.btnBpSpanUp);
            this.pnlAutoair.Controls.Add(this.label9);
            this.pnlAutoair.Controls.Add(this.btnBpSpanDown);
            this.pnlAutoair.Controls.Add(this.tbKeepFull);
            this.pnlAutoair.Controls.Add(this.tbBpSpanUp);
            this.pnlAutoair.Controls.Add(this.tbKeep);
            this.pnlAutoair.Controls.Add(this.tbBpSpanDown);
            this.pnlAutoair.Enabled = false;
            this.pnlAutoair.Location = new System.Drawing.Point(6, 56);
            this.pnlAutoair.Name = "pnlAutoair";
            this.pnlAutoair.Size = new System.Drawing.Size(413, 111);
            this.pnlAutoair.TabIndex = 80;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(253, 87);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(129, 12);
            this.label44.TabIndex = 78;
            this.label44.Text = "1～(早)～20～(遅)～100";
            // 
            // tbnKeep
            // 
            this.tbnKeep.Location = new System.Drawing.Point(3, 3);
            this.tbnKeep.Name = "tbnKeep";
            this.tbnKeep.Size = new System.Drawing.Size(191, 23);
            this.tbnKeep.TabIndex = 33;
            this.tbnKeep.Text = "自動帯常用開始角度[°](130)";
            this.tbnKeep.UseVisualStyleBackColor = true;
            this.tbnKeep.Click += new System.EventHandler(this.btnKeep_Click);
            // 
            // btnKeepFull
            // 
            this.btnKeepFull.Location = new System.Drawing.Point(3, 26);
            this.btnKeepFull.Name = "btnKeepFull";
            this.btnKeepFull.Size = new System.Drawing.Size(191, 23);
            this.btnKeepFull.TabIndex = 33;
            this.btnKeepFull.Text = "自動帯常用全開角度[°](135)";
            this.btnKeepFull.UseVisualStyleBackColor = true;
            this.btnKeepFull.Click += new System.EventHandler(this.btnKeepFull_Click);
            // 
            // btnBpSpanUp
            // 
            this.btnBpSpanUp.Location = new System.Drawing.Point(3, 82);
            this.btnBpSpanUp.Name = "btnBpSpanUp";
            this.btnBpSpanUp.Size = new System.Drawing.Size(191, 23);
            this.btnBpSpanUp.TabIndex = 33;
            this.btnBpSpanUp.Text = "自動帯BP増圧間隔[ms](20)";
            this.btnBpSpanUp.UseVisualStyleBackColor = true;
            this.btnBpSpanUp.Click += new System.EventHandler(this.btnBpSpanUp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 12);
            this.label9.TabIndex = 77;
            this.label9.Text = "1～(早)～20～(遅)～100";
            // 
            // btnBpSpanDown
            // 
            this.btnBpSpanDown.Location = new System.Drawing.Point(3, 59);
            this.btnBpSpanDown.Name = "btnBpSpanDown";
            this.btnBpSpanDown.Size = new System.Drawing.Size(191, 23);
            this.btnBpSpanDown.TabIndex = 33;
            this.btnBpSpanDown.Text = "自動帯BP減圧間隔[ms](20)";
            this.btnBpSpanDown.UseVisualStyleBackColor = true;
            this.btnBpSpanDown.Click += new System.EventHandler(this.btnBpSpanDown_Click);
            // 
            // tbKeepFull
            // 
            this.tbKeepFull.Location = new System.Drawing.Point(200, 28);
            this.tbKeepFull.Name = "tbKeepFull";
            this.tbKeepFull.Size = new System.Drawing.Size(50, 19);
            this.tbKeepFull.TabIndex = 34;
            this.tbKeepFull.Text = "135";
            this.tbKeepFull.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKeepFull.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeepFull_KeyDown);
            // 
            // tbBpSpanUp
            // 
            this.tbBpSpanUp.Location = new System.Drawing.Point(200, 84);
            this.tbBpSpanUp.Name = "tbBpSpanUp";
            this.tbBpSpanUp.Size = new System.Drawing.Size(50, 19);
            this.tbBpSpanUp.TabIndex = 34;
            this.tbBpSpanUp.Text = "20";
            this.tbBpSpanUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBpSpanUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBpSpanUp_KeyDown);
            // 
            // tbKeep
            // 
            this.tbKeep.Location = new System.Drawing.Point(200, 5);
            this.tbKeep.Name = "tbKeep";
            this.tbKeep.Size = new System.Drawing.Size(50, 19);
            this.tbKeep.TabIndex = 34;
            this.tbKeep.Text = "130";
            this.tbKeep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKeep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeep_KeyDown);
            // 
            // tbBpSpanDown
            // 
            this.tbBpSpanDown.Location = new System.Drawing.Point(200, 61);
            this.tbBpSpanDown.Name = "tbBpSpanDown";
            this.tbBpSpanDown.Size = new System.Drawing.Size(50, 19);
            this.tbBpSpanDown.TabIndex = 34;
            this.tbBpSpanDown.Text = "20";
            this.tbBpSpanDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBpSpanDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBpSpanDown_KeyDown);
            // 
            // cbAutoAirEX
            // 
            this.cbAutoAirEX.AutoSize = true;
            this.cbAutoAirEX.Checked = true;
            this.cbAutoAirEX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoAirEX.Location = new System.Drawing.Point(289, 22);
            this.cbAutoAirEX.Name = "cbAutoAirEX";
            this.cbAutoAirEX.Size = new System.Drawing.Size(82, 16);
            this.cbAutoAirEX.TabIndex = 79;
            this.cbAutoAirEX.Text = "BveEX使用";
            this.cbAutoAirEX.UseVisualStyleBackColor = true;
            this.cbAutoAirEX.Click += new System.EventHandler(this.cbAutoairUse_Click);
            // 
            // cbRealAutoAir
            // 
            this.cbRealAutoAir.AutoSize = true;
            this.cbRealAutoAir.Checked = true;
            this.cbRealAutoAir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRealAutoAir.Location = new System.Drawing.Point(105, 23);
            this.cbRealAutoAir.Name = "cbRealAutoAir";
            this.cbRealAutoAir.Size = new System.Drawing.Size(175, 16);
            this.cbRealAutoAir.TabIndex = 79;
            this.cbRealAutoAir.Text = "自動帯(実際のエアー圧を使用)";
            this.cbRealAutoAir.UseVisualStyleBackColor = true;
            this.cbRealAutoAir.CheckedChanged += new System.EventHandler(this.cbRealAutoAir_CheckedChanged);
            // 
            // cbAutoairUse
            // 
            this.cbAutoairUse.AutoSize = true;
            this.cbAutoairUse.Checked = true;
            this.cbAutoairUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoairUse.Location = new System.Drawing.Point(6, 23);
            this.cbAutoairUse.Name = "cbAutoairUse";
            this.cbAutoairUse.Size = new System.Drawing.Size(84, 16);
            this.cbAutoairUse.TabIndex = 79;
            this.cbAutoairUse.Text = "自動帯使用";
            this.cbAutoairUse.UseVisualStyleBackColor = true;
            this.cbAutoairUse.Click += new System.EventHandler(this.cbAutoairUse_Click);
            // 
            // cbAtsConf
            // 
            this.cbAtsConf.AutoSize = true;
            this.cbAtsConf.Location = new System.Drawing.Point(22, 404);
            this.cbAtsConf.Name = "cbAtsConf";
            this.cbAtsConf.Size = new System.Drawing.Size(302, 16);
            this.cbAtsConf.TabIndex = 79;
            this.cbAtsConf.Text = "ATS確認B接点(離した時に導通する接点の場合にチェック)";
            this.cbAtsConf.UseVisualStyleBackColor = true;
            this.cbAtsConf.Click += new System.EventHandler(this.cbAtsConf_Click);
            // 
            // cbDecEB
            // 
            this.cbDecEB.AutoSize = true;
            this.cbDecEB.Location = new System.Drawing.Point(424, 426);
            this.cbDecEB.Name = "cbDecEB";
            this.cbDecEB.Size = new System.Drawing.Size(220, 16);
            this.cbDecEB.TabIndex = 79;
            this.cbDecEB.Text = "抑速接点を非常接点とする場合にチェック";
            this.cbDecEB.UseVisualStyleBackColor = true;
            this.cbDecEB.Click += new System.EventHandler(this.cbInputFlip_Click);
            // 
            // cbHorn2
            // 
            this.cbHorn2.AutoSize = true;
            this.cbHorn2.Location = new System.Drawing.Point(424, 404);
            this.cbHorn2.Name = "cbHorn2";
            this.cbHorn2.Size = new System.Drawing.Size(290, 16);
            this.cbHorn2.TabIndex = 79;
            this.cbHorn2.Text = "警笛2 B接点(離した時に導通する接点の場合にチェック)";
            this.cbHorn2.UseVisualStyleBackColor = true;
            this.cbHorn2.Click += new System.EventHandler(this.cbInputFlip_Click);
            // 
            // cbHorn1
            // 
            this.cbHorn1.AutoSize = true;
            this.cbHorn1.Location = new System.Drawing.Point(424, 382);
            this.cbHorn1.Name = "cbHorn1";
            this.cbHorn1.Size = new System.Drawing.Size(290, 16);
            this.cbHorn1.TabIndex = 79;
            this.cbHorn1.Text = "警笛1 B接点(離した時に導通する接点の場合にチェック)";
            this.cbHorn1.UseVisualStyleBackColor = true;
            this.cbHorn1.Click += new System.EventHandler(this.cbInputFlip_Click);
            // 
            // cbEB
            // 
            this.cbEB.AutoSize = true;
            this.cbEB.Location = new System.Drawing.Point(22, 470);
            this.cbEB.Name = "cbEB";
            this.cbEB.Size = new System.Drawing.Size(305, 16);
            this.cbEB.TabIndex = 79;
            this.cbEB.Text = "EBスイッチB接点(離した時に導通する接点の場合にチェック)";
            this.cbEB.UseVisualStyleBackColor = true;
            this.cbEB.Click += new System.EventHandler(this.cbInputFlip_Click);
            // 
            // cbAtsRec
            // 
            this.cbAtsRec.AutoSize = true;
            this.cbAtsRec.Location = new System.Drawing.Point(22, 448);
            this.cbAtsRec.Name = "cbAtsRec";
            this.cbAtsRec.Size = new System.Drawing.Size(336, 16);
            this.cbAtsRec.TabIndex = 79;
            this.cbAtsRec.Text = "ATS復帰スイッチB接点(離した時に導通する接点の場合にチェック)";
            this.cbAtsRec.UseVisualStyleBackColor = true;
            this.cbAtsRec.Click += new System.EventHandler(this.cbInputFlip_Click);
            // 
            // cbAtsCont
            // 
            this.cbAtsCont.AutoSize = true;
            this.cbAtsCont.Location = new System.Drawing.Point(22, 382);
            this.cbAtsCont.Name = "cbAtsCont";
            this.cbAtsCont.Size = new System.Drawing.Size(304, 16);
            this.cbAtsCont.TabIndex = 79;
            this.cbAtsCont.Text = "警報持続B接点(離した時に導通する接点の場合にチェック)";
            this.cbAtsCont.UseVisualStyleBackColor = true;
            this.cbAtsCont.Click += new System.EventHandler(this.cbInputFlip_Click);
            // 
            // btnBrkSave
            // 
            this.btnBrkSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrkSave.Enabled = false;
            this.btnBrkSave.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBrkSave.Location = new System.Drawing.Point(110, 6);
            this.btnBrkSave.Name = "btnBrkSave";
            this.btnBrkSave.Size = new System.Drawing.Size(81, 23);
            this.btnBrkSave.TabIndex = 35;
            this.btnBrkSave.Text = "設定値保存";
            this.btnBrkSave.UseVisualStyleBackColor = false;
            this.btnBrkSave.Click += new System.EventHandler(this.btnBrkSave_Click);
            // 
            // btnBrkRead
            // 
            this.btnBrkRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrkRead.Enabled = false;
            this.btnBrkRead.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBrkRead.Location = new System.Drawing.Point(22, 6);
            this.btnBrkRead.Name = "btnBrkRead";
            this.btnBrkRead.Size = new System.Drawing.Size(81, 23);
            this.btnBrkRead.TabIndex = 35;
            this.btnBrkRead.Text = "設定値読込";
            this.btnBrkRead.UseVisualStyleBackColor = false;
            this.btnBrkRead.Click += new System.EventHandler(this.btnBrkRead_Click);
            // 
            // tpPressTest
            // 
            this.tpPressTest.AutoScroll = true;
            this.tpPressTest.Controls.Add(this.tabControl3);
            this.tpPressTest.Location = new System.Drawing.Point(4, 22);
            this.tpPressTest.Name = "tpPressTest";
            this.tpPressTest.Size = new System.Drawing.Size(1149, 555);
            this.tpPressTest.TabIndex = 3;
            this.tpPressTest.Text = "圧力計・制御弁";
            this.tpPressTest.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tpRealAutoAir);
            this.tabControl3.Controls.Add(this.tpSimAutoAir);
            this.tabControl3.Location = new System.Drawing.Point(4, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(902, 488);
            this.tabControl3.TabIndex = 110;
            // 
            // tpRealAutoAir
            // 
            this.tpRealAutoAir.Controls.Add(this.pnlPress);
            this.tpRealAutoAir.Location = new System.Drawing.Point(4, 22);
            this.tpRealAutoAir.Name = "tpRealAutoAir";
            this.tpRealAutoAir.Padding = new System.Windows.Forms.Padding(3);
            this.tpRealAutoAir.Size = new System.Drawing.Size(894, 462);
            this.tpRealAutoAir.TabIndex = 0;
            this.tpRealAutoAir.Text = "圧力空気モニタ";
            this.tpRealAutoAir.UseVisualStyleBackColor = true;
            // 
            // pnlPress
            // 
            this.pnlPress.Controls.Add(this.label43);
            this.pnlPress.Controls.Add(this.tabControl2);
            this.pnlPress.Controls.Add(this.cbBpEvacPress);
            this.pnlPress.Controls.Add(this.groupBox4);
            this.pnlPress.Controls.Add(this.groupBox3);
            this.pnlPress.Controls.Add(this.btnPressRead);
            this.pnlPress.Controls.Add(this.btnPressSave);
            this.pnlPress.Controls.Add(this.label34);
            this.pnlPress.Controls.Add(this.label36);
            this.pnlPress.Controls.Add(this.groupBox1);
            this.pnlPress.Controls.Add(this.tbMonInterval);
            this.pnlPress.Controls.Add(this.label66);
            this.pnlPress.Controls.Add(this.label65);
            this.pnlPress.Controls.Add(this.label20);
            this.pnlPress.Controls.Add(this.cbModeMON);
            this.pnlPress.Controls.Add(this.label53);
            this.pnlPress.Controls.Add(this.label64);
            this.pnlPress.Controls.Add(this.label21);
            this.pnlPress.Controls.Add(this.tbRegOffDelay);
            this.pnlPress.Controls.Add(this.tbBCMin);
            this.pnlPress.Controls.Add(this.label51);
            this.pnlPress.Controls.Add(this.label49);
            this.pnlPress.Controls.Add(this.label52);
            this.pnlPress.Controls.Add(this.label42);
            this.pnlPress.Controls.Add(this.label41);
            this.pnlPress.Controls.Add(this.tbEBOndelay);
            this.pnlPress.Controls.Add(this.tbEBThreshold);
            this.pnlPress.Controls.Add(this.tbEBInterval);
            this.pnlPress.Location = new System.Drawing.Point(6, 6);
            this.pnlPress.Name = "pnlPress";
            this.pnlPress.Size = new System.Drawing.Size(640, 442);
            this.pnlPress.TabIndex = 109;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(199, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(281, 12);
            this.label43.TabIndex = 99;
            this.label43.Text = "※圧力センサ読出モードではE電磁給排弁は作動しません";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpA);
            this.tabControl2.Controls.Add(this.tpE);
            this.tabControl2.Location = new System.Drawing.Point(303, 269);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(328, 141);
            this.tabControl2.TabIndex = 108;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tpA
            // 
            this.tpA.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpA.Controls.Add(this.label33);
            this.tpA.Controls.Add(this.label35);
            this.tpA.Controls.Add(this.label37);
            this.tpA.Controls.Add(this.label38);
            this.tpA.Controls.Add(this.label39);
            this.tpA.Controls.Add(this.label40);
            this.tpA.Controls.Add(this.tbAveRatio);
            this.tpA.Controls.Add(this.tbBCMultiNorm);
            this.tpA.Controls.Add(this.tbBCMaxNorm);
            this.tpA.Controls.Add(this.tbBPvelocityKyudouThreshold);
            this.tpA.Controls.Add(this.label27);
            this.tpA.Controls.Add(this.label24);
            this.tpA.Controls.Add(this.tbBCMulti);
            this.tpA.Controls.Add(this.label32);
            this.tpA.Controls.Add(this.label25);
            this.tpA.Controls.Add(this.tbBCMax);
            this.tpA.Location = new System.Drawing.Point(4, 22);
            this.tpA.Name = "tpA";
            this.tpA.Padding = new System.Windows.Forms.Padding(3);
            this.tpA.Size = new System.Drawing.Size(320, 115);
            this.tpA.TabIndex = 0;
            this.tpA.Text = "A制御弁";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(8, 24);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 12);
            this.label33.TabIndex = 100;
            this.label33.Text = "急動部動作時";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(190, 91);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(11, 12);
            this.label35.TabIndex = 98;
            this.label35.Text = "%";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(128, 6);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 12);
            this.label37.TabIndex = 96;
            this.label37.Text = "FV-BC倍率";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(285, 44);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(24, 12);
            this.label38.TabIndex = 102;
            this.label38.Text = "kPa";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(241, 6);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(29, 12);
            this.label39.TabIndex = 95;
            this.label39.Text = "最大";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(286, 24);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(24, 12);
            this.label40.TabIndex = 94;
            this.label40.Text = "kPa";
            // 
            // tbAveRatio
            // 
            this.tbAveRatio.Location = new System.Drawing.Point(134, 88);
            this.tbAveRatio.Name = "tbAveRatio";
            this.tbAveRatio.Size = new System.Drawing.Size(50, 19);
            this.tbAveRatio.TabIndex = 85;
            this.tbAveRatio.Text = "95";
            this.tbAveRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAveRatio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAveRatio_KeyDown);
            // 
            // tbBCMultiNorm
            // 
            this.tbBCMultiNorm.Location = new System.Drawing.Point(134, 41);
            this.tbBCMultiNorm.Name = "tbBCMultiNorm";
            this.tbBCMultiNorm.Size = new System.Drawing.Size(50, 19);
            this.tbBCMultiNorm.TabIndex = 90;
            this.tbBCMultiNorm.Text = "3.3";
            this.tbBCMultiNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBCMultiNorm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBCMultiNorm_KeyDown);
            // 
            // tbBCMaxNorm
            // 
            this.tbBCMaxNorm.Location = new System.Drawing.Point(233, 41);
            this.tbBCMaxNorm.Name = "tbBCMaxNorm";
            this.tbBCMaxNorm.Size = new System.Drawing.Size(50, 19);
            this.tbBCMaxNorm.TabIndex = 89;
            this.tbBCMaxNorm.Text = "380";
            this.tbBCMaxNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBCMaxNorm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBCMaxNorm_KeyDown);
            // 
            // tbBPvelocityKyudouThreshold
            // 
            this.tbBPvelocityKyudouThreshold.Location = new System.Drawing.Point(134, 63);
            this.tbBPvelocityKyudouThreshold.Name = "tbBPvelocityKyudouThreshold";
            this.tbBPvelocityKyudouThreshold.Size = new System.Drawing.Size(50, 19);
            this.tbBPvelocityKyudouThreshold.TabIndex = 85;
            this.tbBPvelocityKyudouThreshold.Text = "80";
            this.tbBPvelocityKyudouThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBPvelocityKyudouThreshold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBPvelocityKyudouThreshold_KeyDown);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 12);
            this.label27.TabIndex = 100;
            this.label27.Text = "平均化率(95)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 12);
            this.label24.TabIndex = 100;
            this.label24.Text = "急動部動作BP減圧度";
            // 
            // tbBCMulti
            // 
            this.tbBCMulti.Location = new System.Drawing.Point(134, 21);
            this.tbBCMulti.Name = "tbBCMulti";
            this.tbBCMulti.Size = new System.Drawing.Size(50, 19);
            this.tbBCMulti.TabIndex = 88;
            this.tbBCMulti.Text = "20.0";
            this.tbBCMulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBCMulti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBCMulti_KeyDown);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(8, 44);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 12);
            this.label32.TabIndex = 101;
            this.label32.Text = "常用動作時";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(186, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 12);
            this.label25.TabIndex = 100;
            this.label25.Text = "(50敏感～100鈍感)";
            // 
            // tbBCMax
            // 
            this.tbBCMax.Location = new System.Drawing.Point(233, 21);
            this.tbBCMax.Name = "tbBCMax";
            this.tbBCMax.Size = new System.Drawing.Size(50, 19);
            this.tbBCMax.TabIndex = 87;
            this.tbBCMax.Text = "490";
            this.tbBCMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBCMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBCMax_KeyDown);
            // 
            // tpE
            // 
            this.tpE.BackColor = System.Drawing.Color.Azure;
            this.tpE.Controls.Add(this.label28);
            this.tpE.Controls.Add(this.label45);
            this.tpE.Controls.Add(this.label46);
            this.tpE.Controls.Add(this.label48);
            this.tpE.Controls.Add(this.label50);
            this.tpE.Controls.Add(this.label47);
            this.tpE.Controls.Add(this.tbBCMaxE);
            this.tpE.Controls.Add(this.tbAveRatioE);
            this.tpE.Controls.Add(this.tbBCMultiE);
            this.tpE.Location = new System.Drawing.Point(4, 22);
            this.tpE.Name = "tpE";
            this.tpE.Padding = new System.Windows.Forms.Padding(3);
            this.tpE.Size = new System.Drawing.Size(320, 115);
            this.tpE.TabIndex = 1;
            this.tpE.Text = "E制御弁";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(190, 91);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(11, 12);
            this.label28.TabIndex = 119;
            this.label28.Text = "%";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(128, 6);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(66, 12);
            this.label45.TabIndex = 118;
            this.label45.Text = "FV-BC倍率";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(285, 43);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(24, 12);
            this.label46.TabIndex = 124;
            this.label46.Text = "kPa";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 91);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(67, 12);
            this.label48.TabIndex = 123;
            this.label48.Text = "平均化率(0)";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(8, 44);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(41, 12);
            this.label50.TabIndex = 123;
            this.label50.Text = "動作時";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(241, 6);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 12);
            this.label47.TabIndex = 117;
            this.label47.Text = "最大";
            // 
            // tbBCMaxE
            // 
            this.tbBCMaxE.Location = new System.Drawing.Point(233, 41);
            this.tbBCMaxE.Name = "tbBCMaxE";
            this.tbBCMaxE.Size = new System.Drawing.Size(50, 19);
            this.tbBCMaxE.TabIndex = 114;
            this.tbBCMaxE.Text = "490";
            this.tbBCMaxE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBCMaxE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBCMaxE_KeyDown);
            // 
            // tbAveRatioE
            // 
            this.tbAveRatioE.Location = new System.Drawing.Point(134, 88);
            this.tbAveRatioE.Name = "tbAveRatioE";
            this.tbAveRatioE.Size = new System.Drawing.Size(50, 19);
            this.tbAveRatioE.TabIndex = 110;
            this.tbAveRatioE.Text = "0";
            this.tbAveRatioE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAveRatioE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAveRatioE_KeyDown);
            // 
            // tbBCMultiE
            // 
            this.tbBCMultiE.Location = new System.Drawing.Point(134, 41);
            this.tbBCMultiE.Name = "tbBCMultiE";
            this.tbBCMultiE.Size = new System.Drawing.Size(50, 19);
            this.tbBCMultiE.TabIndex = 115;
            this.tbBCMultiE.Text = "2.6";
            this.tbBCMultiE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBCMultiE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBCMultiE_KeyDown);
            // 
            // cbBpEvacPress
            // 
            this.cbBpEvacPress.AutoSize = true;
            this.cbBpEvacPress.Location = new System.Drawing.Point(26, 276);
            this.cbBpEvacPress.Name = "cbBpEvacPress";
            this.cbBpEvacPress.Size = new System.Drawing.Size(107, 16);
            this.cbBpEvacPress.TabIndex = 106;
            this.cbBpEvacPress.Text = "E電磁給排弁 開";
            this.cbBpEvacPress.UseVisualStyleBackColor = true;
            this.cbBpEvacPress.CheckedChanged += new System.EventHandler(this.cbBpEvacPress_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbBCPress);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.tbarBCPress);
            this.groupBox4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox4.Location = new System.Drawing.Point(9, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 225);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(125, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 12);
            this.label14.TabIndex = 77;
            this.label14.Text = "kPa";
            // 
            // tbBCPress
            // 
            this.tbBCPress.Enabled = false;
            this.tbBCPress.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBCPress.Location = new System.Drawing.Point(70, 35);
            this.tbBCPress.Name = "tbBCPress";
            this.tbBCPress.ReadOnly = true;
            this.tbBCPress.Size = new System.Drawing.Size(50, 23);
            this.tbBCPress.TabIndex = 30;
            this.tbBCPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(74, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 12);
            this.label15.TabIndex = 77;
            this.label15.Text = "490 kPa";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(74, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 12);
            this.label16.TabIndex = 77;
            this.label16.Text = "0 kPa";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(36, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 12);
            this.label19.TabIndex = 77;
            this.label19.Text = "計算圧力 (FC-BP)×倍率";
            // 
            // tbarBCPress
            // 
            this.tbarBCPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarBCPress.Enabled = false;
            this.tbarBCPress.Location = new System.Drawing.Point(26, 64);
            this.tbarBCPress.Maximum = 490;
            this.tbarBCPress.Name = "tbarBCPress";
            this.tbarBCPress.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarBCPress.Size = new System.Drawing.Size(45, 155);
            this.tbarBCPress.TabIndex = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btnBPMinSet);
            this.groupBox3.Controls.Add(this.btnBPMaxSet);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.tbBPMin);
            this.groupBox3.Controls.Add(this.lblBP);
            this.groupBox3.Controls.Add(this.tbBPPressMin);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.lblBP_B);
            this.groupBox3.Controls.Add(this.tbBPPressMax);
            this.groupBox3.Controls.Add(this.tbBP);
            this.groupBox3.Controls.Add(this.tbBP_V);
            this.groupBox3.Controls.Add(this.tbBPMax);
            this.groupBox3.Controls.Add(this.tbarBP);
            this.groupBox3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(201, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 225);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BP";
            // 
            // btnBPMinSet
            // 
            this.btnBPMinSet.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBPMinSet.Location = new System.Drawing.Point(118, 158);
            this.btnBPMinSet.Name = "btnBPMinSet";
            this.btnBPMinSet.Size = new System.Drawing.Size(73, 25);
            this.btnBPMinSet.TabIndex = 111;
            this.btnBPMinSet.Text = "下限セット";
            this.btnBPMinSet.UseVisualStyleBackColor = true;
            this.btnBPMinSet.Click += new System.EventHandler(this.btnBPMinSet_Click);
            // 
            // btnBPMaxSet
            // 
            this.btnBPMaxSet.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBPMaxSet.Location = new System.Drawing.Point(118, 94);
            this.btnBPMaxSet.Name = "btnBPMaxSet";
            this.btnBPMaxSet.Size = new System.Drawing.Size(73, 25);
            this.btnBPMaxSet.TabIndex = 110;
            this.btnBPMaxSet.Text = "上限セット";
            this.btnBPMaxSet.UseVisualStyleBackColor = true;
            this.btnBPMaxSet.Click += new System.EventHandler(this.btnBPMaxSet_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label22.Location = new System.Drawing.Point(174, 193);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 12);
            this.label22.TabIndex = 77;
            this.label22.Text = "kPa";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(174, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 12);
            this.label23.TabIndex = 77;
            this.label23.Text = "kPa";
            // 
            // tbBPMin
            // 
            this.tbBPMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBPMin.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBPMin.Location = new System.Drawing.Point(17, 189);
            this.tbBPMin.Name = "tbBPMin";
            this.tbBPMin.Size = new System.Drawing.Size(50, 19);
            this.tbBPMin.TabIndex = 34;
            this.tbBPMin.Text = "98";
            this.tbBPMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBPMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBPMin_KeyDown);
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBP.Location = new System.Drawing.Point(116, 20);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(53, 12);
            this.lblBP.TabIndex = 77;
            this.lblBP.Text = "圧力換算";
            // 
            // tbBPPressMin
            // 
            this.tbBPPressMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBPPressMin.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBPPressMin.Location = new System.Drawing.Point(119, 189);
            this.tbBPPressMin.Name = "tbBPPressMin";
            this.tbBPPressMin.Size = new System.Drawing.Size(50, 19);
            this.tbBPPressMin.TabIndex = 30;
            this.tbBPPressMin.Text = "0";
            this.tbBPPressMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBPPressMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBPPressMin_KeyDown);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label26.Location = new System.Drawing.Point(174, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 12);
            this.label26.TabIndex = 77;
            this.label26.Text = "kPa";
            // 
            // lblBP_B
            // 
            this.lblBP_B.AutoSize = true;
            this.lblBP_B.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBP_B.Location = new System.Drawing.Point(15, 20);
            this.lblBP_B.Name = "lblBP_B";
            this.lblBP_B.Size = new System.Drawing.Size(58, 12);
            this.lblBP_B.TabIndex = 77;
            this.lblBP_B.Text = "センサ出力";
            // 
            // tbBPPressMax
            // 
            this.tbBPPressMax.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBPPressMax.Location = new System.Drawing.Point(118, 69);
            this.tbBPPressMax.Name = "tbBPPressMax";
            this.tbBPPressMax.Size = new System.Drawing.Size(50, 19);
            this.tbBPPressMax.TabIndex = 32;
            this.tbBPPressMax.Text = "490";
            this.tbBPPressMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBPPressMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBPPressMax_KeyDown);
            // 
            // tbBP
            // 
            this.tbBP.Enabled = false;
            this.tbBP.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBP.Location = new System.Drawing.Point(118, 35);
            this.tbBP.Name = "tbBP";
            this.tbBP.ReadOnly = true;
            this.tbBP.Size = new System.Drawing.Size(50, 23);
            this.tbBP.TabIndex = 30;
            this.tbBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBP_V
            // 
            this.tbBP_V.Enabled = false;
            this.tbBP_V.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBP_V.Location = new System.Drawing.Point(17, 38);
            this.tbBP_V.Name = "tbBP_V";
            this.tbBP_V.ReadOnly = true;
            this.tbBP_V.Size = new System.Drawing.Size(50, 19);
            this.tbBP_V.TabIndex = 30;
            this.tbBP_V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBPMax
            // 
            this.tbBPMax.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBPMax.Location = new System.Drawing.Point(17, 69);
            this.tbBPMax.Name = "tbBPMax";
            this.tbBPMax.Size = new System.Drawing.Size(50, 19);
            this.tbBPMax.TabIndex = 36;
            this.tbBPMax.Text = "800";
            this.tbBPMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBPMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBPMax_KeyDown);
            // 
            // tbarBP
            // 
            this.tbarBP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarBP.Enabled = false;
            this.tbarBP.Location = new System.Drawing.Point(73, 64);
            this.tbarBP.Maximum = 490;
            this.tbarBP.Name = "tbarBP";
            this.tbarBP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarBP.Size = new System.Drawing.Size(45, 155);
            this.tbarBP.TabIndex = 80;
            // 
            // btnPressRead
            // 
            this.btnPressRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnPressRead.Enabled = false;
            this.btnPressRead.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPressRead.Location = new System.Drawing.Point(9, 4);
            this.btnPressRead.Name = "btnPressRead";
            this.btnPressRead.Size = new System.Drawing.Size(81, 23);
            this.btnPressRead.TabIndex = 92;
            this.btnPressRead.Text = "設定値読込";
            this.btnPressRead.UseVisualStyleBackColor = false;
            this.btnPressRead.Click += new System.EventHandler(this.btnPressRead_Click);
            // 
            // btnPressSave
            // 
            this.btnPressSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnPressSave.Enabled = false;
            this.btnPressSave.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPressSave.Location = new System.Drawing.Point(96, 4);
            this.btnPressSave.Name = "btnPressSave";
            this.btnPressSave.Size = new System.Drawing.Size(81, 23);
            this.btnPressSave.TabIndex = 91;
            this.btnPressSave.Text = "設定値保存";
            this.btnPressSave.UseVisualStyleBackColor = false;
            this.btnPressSave.Click += new System.EventHandler(this.btnPressSave_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(369, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(62, 12);
            this.label34.TabIndex = 99;
            this.label34.Text = "読出し間隔";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(492, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(31, 12);
            this.label36.TabIndex = 97;
            this.label36.Text = "ミリ秒";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnFVMinSet);
            this.groupBox1.Controls.Add(this.btnFVMaxSet);
            this.groupBox1.Controls.Add(this.cbFVhold);
            this.groupBox1.Controls.Add(this.tbFVPressMax);
            this.groupBox1.Controls.Add(this.tbFVMax);
            this.groupBox1.Controls.Add(this.tbFVMin);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.lblFV_V);
            this.groupBox1.Controls.Add(this.tbFV_V);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.tbFV);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.tbFVPressMin);
            this.groupBox1.Controls.Add(this.lblFV);
            this.groupBox1.Controls.Add(this.tbarFV);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(419, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 225);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FV";
            // 
            // btnFVMinSet
            // 
            this.btnFVMinSet.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFVMinSet.Location = new System.Drawing.Point(119, 158);
            this.btnFVMinSet.Name = "btnFVMinSet";
            this.btnFVMinSet.Size = new System.Drawing.Size(73, 25);
            this.btnFVMinSet.TabIndex = 112;
            this.btnFVMinSet.Text = "下限セット";
            this.btnFVMinSet.UseVisualStyleBackColor = true;
            this.btnFVMinSet.Click += new System.EventHandler(this.btnFVMinSet_Click);
            // 
            // btnFVMaxSet
            // 
            this.btnFVMaxSet.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFVMaxSet.Location = new System.Drawing.Point(118, 94);
            this.btnFVMaxSet.Name = "btnFVMaxSet";
            this.btnFVMaxSet.Size = new System.Drawing.Size(73, 25);
            this.btnFVMaxSet.TabIndex = 111;
            this.btnFVMaxSet.Text = "上限セット";
            this.btnFVMaxSet.UseVisualStyleBackColor = true;
            this.btnFVMaxSet.Click += new System.EventHandler(this.btnFVMaxSet_Click);
            // 
            // cbFVhold
            // 
            this.cbFVhold.AutoSize = true;
            this.cbFVhold.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbFVhold.Location = new System.Drawing.Point(118, 129);
            this.cbFVhold.Name = "cbFVhold";
            this.cbFVhold.Size = new System.Drawing.Size(85, 16);
            this.cbFVhold.TabIndex = 111;
            this.cbFVhold.Text = "490kPa固定";
            this.cbFVhold.UseVisualStyleBackColor = true;
            this.cbFVhold.CheckedChanged += new System.EventHandler(this.cbFVhold_CheckedChanged);
            // 
            // tbFVPressMax
            // 
            this.tbFVPressMax.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFVPressMax.Location = new System.Drawing.Point(118, 69);
            this.tbFVPressMax.Name = "tbFVPressMax";
            this.tbFVPressMax.Size = new System.Drawing.Size(50, 19);
            this.tbFVPressMax.TabIndex = 32;
            this.tbFVPressMax.Text = "490";
            this.tbFVPressMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFVPressMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFVPressMax_KeyDown);
            // 
            // tbFVMax
            // 
            this.tbFVMax.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFVMax.Location = new System.Drawing.Point(17, 69);
            this.tbFVMax.Name = "tbFVMax";
            this.tbFVMax.Size = new System.Drawing.Size(50, 19);
            this.tbFVMax.TabIndex = 32;
            this.tbFVMax.Text = "800";
            this.tbFVMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFVMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFVMax_KeyDown);
            // 
            // tbFVMin
            // 
            this.tbFVMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFVMin.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFVMin.Location = new System.Drawing.Point(17, 189);
            this.tbFVMin.Name = "tbFVMin";
            this.tbFVMin.Size = new System.Drawing.Size(50, 19);
            this.tbFVMin.TabIndex = 30;
            this.tbFVMin.Text = "98";
            this.tbFVMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFVMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFVMin_KeyDown);
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label29.Location = new System.Drawing.Point(174, 192);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 12);
            this.label29.TabIndex = 77;
            this.label29.Text = "kPa";
            // 
            // lblFV_V
            // 
            this.lblFV_V.AutoSize = true;
            this.lblFV_V.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFV_V.Location = new System.Drawing.Point(15, 20);
            this.lblFV_V.Name = "lblFV_V";
            this.lblFV_V.Size = new System.Drawing.Size(58, 12);
            this.lblFV_V.TabIndex = 77;
            this.lblFV_V.Text = "センサ出力";
            // 
            // tbFV_V
            // 
            this.tbFV_V.Enabled = false;
            this.tbFV_V.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFV_V.Location = new System.Drawing.Point(17, 38);
            this.tbFV_V.Name = "tbFV_V";
            this.tbFV_V.ReadOnly = true;
            this.tbFV_V.Size = new System.Drawing.Size(50, 19);
            this.tbFV_V.TabIndex = 30;
            this.tbFV_V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label30.Location = new System.Drawing.Point(174, 72);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 12);
            this.label30.TabIndex = 77;
            this.label30.Text = "kPa";
            // 
            // tbFV
            // 
            this.tbFV.Enabled = false;
            this.tbFV.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFV.Location = new System.Drawing.Point(118, 35);
            this.tbFV.Name = "tbFV";
            this.tbFV.ReadOnly = true;
            this.tbFV.Size = new System.Drawing.Size(50, 23);
            this.tbFV.TabIndex = 30;
            this.tbFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label31.Location = new System.Drawing.Point(174, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(24, 12);
            this.label31.TabIndex = 77;
            this.label31.Text = "kPa";
            // 
            // tbFVPressMin
            // 
            this.tbFVPressMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFVPressMin.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFVPressMin.Location = new System.Drawing.Point(118, 189);
            this.tbFVPressMin.Name = "tbFVPressMin";
            this.tbFVPressMin.Size = new System.Drawing.Size(50, 19);
            this.tbFVPressMin.TabIndex = 30;
            this.tbFVPressMin.Text = "0";
            this.tbFVPressMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFVPressMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFVPressMin_KeyDown);
            // 
            // lblFV
            // 
            this.lblFV.AutoSize = true;
            this.lblFV.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFV.Location = new System.Drawing.Point(117, 20);
            this.lblFV.Name = "lblFV";
            this.lblFV.Size = new System.Drawing.Size(53, 12);
            this.lblFV.TabIndex = 77;
            this.lblFV.Text = "圧力換算";
            // 
            // tbarFV
            // 
            this.tbarFV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarFV.Enabled = false;
            this.tbarFV.Location = new System.Drawing.Point(73, 63);
            this.tbarFV.Maximum = 490;
            this.tbarFV.Name = "tbarFV";
            this.tbarFV.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarFV.Size = new System.Drawing.Size(45, 158);
            this.tbarFV.TabIndex = 80;
            // 
            // tbMonInterval
            // 
            this.tbMonInterval.Location = new System.Drawing.Point(434, 5);
            this.tbMonInterval.Name = "tbMonInterval";
            this.tbMonInterval.Size = new System.Drawing.Size(52, 19);
            this.tbMonInterval.TabIndex = 86;
            this.tbMonInterval.Text = "500";
            this.tbMonInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMonInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMonInterval_KeyDown);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(143, 392);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(51, 12);
            this.label66.TabIndex = 77;
            this.label66.Text = "時間(2.0)";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(143, 369);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(49, 12);
            this.label65.TabIndex = 77;
            this.label65.Text = "圧力(10)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 12);
            this.label20.TabIndex = 77;
            this.label20.Text = "電空レギュレータ電源OFF";
            // 
            // cbModeMON
            // 
            this.cbModeMON.AutoSize = true;
            this.cbModeMON.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbModeMON.Location = new System.Drawing.Point(201, 5);
            this.cbModeMON.Name = "cbModeMON";
            this.cbModeMON.Size = new System.Drawing.Size(140, 20);
            this.cbModeMON.TabIndex = 93;
            this.cbModeMON.Text = "圧力センサ読出し";
            this.cbModeMON.UseVisualStyleBackColor = true;
            this.cbModeMON.CheckedChanged += new System.EventHandler(this.cbModeMON_CheckedChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(235, 321);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(24, 12);
            this.label53.TabIndex = 77;
            this.label53.Text = "kPa";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(263, 392);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(17, 12);
            this.label64.TabIndex = 77;
            this.label64.Text = "秒";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(263, 369);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 12);
            this.label21.TabIndex = 77;
            this.label21.Text = "kPa";
            // 
            // tbRegOffDelay
            // 
            this.tbRegOffDelay.Location = new System.Drawing.Point(207, 388);
            this.tbRegOffDelay.Name = "tbRegOffDelay";
            this.tbRegOffDelay.Size = new System.Drawing.Size(50, 19);
            this.tbRegOffDelay.TabIndex = 34;
            this.tbRegOffDelay.Text = "2.0";
            this.tbRegOffDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRegOffDelay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRegOffDelay_KeyDown);
            // 
            // tbBCMin
            // 
            this.tbBCMin.Location = new System.Drawing.Point(207, 366);
            this.tbBCMin.Name = "tbBCMin";
            this.tbBCMin.Size = new System.Drawing.Size(50, 19);
            this.tbBCMin.TabIndex = 34;
            this.tbBCMin.Text = "10";
            this.tbBCMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBCMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBCMin_KeyDown);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(45, 342);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(96, 12);
            this.label51.TabIndex = 98;
            this.label51.Text = "E電磁弁遅延時間";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(201, 342);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(17, 12);
            this.label49.TabIndex = 98;
            this.label49.Text = "秒";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(45, 320);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(120, 12);
            this.label52.TabIndex = 98;
            this.label52.Text = "E電磁弁開放開始圧力";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(45, 299);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(96, 12);
            this.label42.TabIndex = 98;
            this.label42.Text = "E電磁弁開放時間";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(201, 299);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(17, 12);
            this.label41.TabIndex = 98;
            this.label41.Text = "秒";
            // 
            // tbEBOndelay
            // 
            this.tbEBOndelay.Location = new System.Drawing.Point(145, 339);
            this.tbEBOndelay.Name = "tbEBOndelay";
            this.tbEBOndelay.Size = new System.Drawing.Size(50, 19);
            this.tbEBOndelay.TabIndex = 85;
            this.tbEBOndelay.Text = "0.2";
            this.tbEBOndelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEBOndelay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEBOndelay_KeyDown);
            // 
            // tbEBThreshold
            // 
            this.tbEBThreshold.Location = new System.Drawing.Point(179, 318);
            this.tbEBThreshold.Name = "tbEBThreshold";
            this.tbEBThreshold.Size = new System.Drawing.Size(50, 19);
            this.tbEBThreshold.TabIndex = 85;
            this.tbEBThreshold.Text = "10";
            this.tbEBThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEBThreshold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEBThreshold_KeyDown);
            // 
            // tbEBInterval
            // 
            this.tbEBInterval.Location = new System.Drawing.Point(145, 296);
            this.tbEBInterval.Name = "tbEBInterval";
            this.tbEBInterval.Size = new System.Drawing.Size(50, 19);
            this.tbEBInterval.TabIndex = 85;
            this.tbEBInterval.Text = "10";
            this.tbEBInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEBInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEBInterval_KeyDown);
            // 
            // tpSimAutoAir
            // 
            this.tpSimAutoAir.Controls.Add(this.gbAirMeterDebug);
            this.tpSimAutoAir.Controls.Add(this.cbAirMeterDebug);
            this.tpSimAutoAir.Controls.Add(this.label4);
            this.tpSimAutoAir.Controls.Add(this.cbPortSelectAirRead);
            this.tpSimAutoAir.Controls.Add(this.label103);
            this.tpSimAutoAir.Controls.Add(this.groupBox18);
            this.tpSimAutoAir.Controls.Add(this.btnSerialPortOpenDensei);
            this.tpSimAutoAir.Controls.Add(this.groupBox17);
            this.tpSimAutoAir.Controls.Add(this.groupBox13);
            this.tpSimAutoAir.Controls.Add(this.groupBox16);
            this.tpSimAutoAir.Controls.Add(this.groupBox14);
            this.tpSimAutoAir.Controls.Add(this.groupBox15);
            this.tpSimAutoAir.Location = new System.Drawing.Point(4, 22);
            this.tpSimAutoAir.Name = "tpSimAutoAir";
            this.tpSimAutoAir.Padding = new System.Windows.Forms.Padding(3);
            this.tpSimAutoAir.Size = new System.Drawing.Size(894, 462);
            this.tpSimAutoAir.TabIndex = 1;
            this.tpSimAutoAir.Text = "圧力計動作テスタ";
            this.tpSimAutoAir.UseVisualStyleBackColor = true;
            // 
            // gbAirMeterDebug
            // 
            this.gbAirMeterDebug.Controls.Add(this.btnDispTestAtsAlm);
            this.gbAirMeterDebug.Controls.Add(this.label104);
            this.gbAirMeterDebug.Controls.Add(this.groupBox19);
            this.gbAirMeterDebug.Controls.Add(this.btnDsipTestAts);
            this.gbAirMeterDebug.Controls.Add(this.groupBox20);
            this.gbAirMeterDebug.Controls.Add(this.groupBox21);
            this.gbAirMeterDebug.Controls.Add(this.btnDispTestYokusoku);
            this.gbAirMeterDebug.Controls.Add(this.groupBox22);
            this.gbAirMeterDebug.Controls.Add(this.groupBox23);
            this.gbAirMeterDebug.Controls.Add(this.btnDispTestHatsuden);
            this.gbAirMeterDebug.Controls.Add(this.groupBox24);
            this.gbAirMeterDebug.Controls.Add(this.btnDispTestSAP);
            this.gbAirMeterDebug.Location = new System.Drawing.Point(6, 230);
            this.gbAirMeterDebug.Name = "gbAirMeterDebug";
            this.gbAirMeterDebug.Size = new System.Drawing.Size(874, 223);
            this.gbAirMeterDebug.TabIndex = 120;
            this.gbAirMeterDebug.TabStop = false;
            this.gbAirMeterDebug.Text = "Debug Read";
            this.gbAirMeterDebug.Visible = false;
            // 
            // btnDispTestAtsAlm
            // 
            this.btnDispTestAtsAlm.Location = new System.Drawing.Point(600, 196);
            this.btnDispTestAtsAlm.Name = "btnDispTestAtsAlm";
            this.btnDispTestAtsAlm.Size = new System.Drawing.Size(68, 23);
            this.btnDispTestAtsAlm.TabIndex = 111;
            this.btnDispTestAtsAlm.Text = "ATS動作";
            this.btnDispTestAtsAlm.UseVisualStyleBackColor = true;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label104.Location = new System.Drawing.Point(7, 93);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(53, 19);
            this.label104.TabIndex = 111;
            this.label104.Text = "Read";
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox19.Controls.Add(this.label85);
            this.groupBox19.Controls.Add(this.label86);
            this.groupBox19.Controls.Add(this.tbSimPressReadER);
            this.groupBox19.Controls.Add(this.label87);
            this.groupBox19.Controls.Add(this.tbarSimAirReadER);
            this.groupBox19.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox19.Location = new System.Drawing.Point(72, 7);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(125, 187);
            this.groupBox19.TabIndex = 115;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "ER";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label85.Location = new System.Drawing.Point(90, 112);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(24, 12);
            this.label85.TabIndex = 110;
            this.label85.Text = "kPa";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label86.Location = new System.Drawing.Point(68, 30);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(46, 12);
            this.label86.TabIndex = 77;
            this.label86.Text = "490 kPa";
            // 
            // tbSimPressReadER
            // 
            this.tbSimPressReadER.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressReadER.Location = new System.Drawing.Point(64, 86);
            this.tbSimPressReadER.Name = "tbSimPressReadER";
            this.tbSimPressReadER.ReadOnly = true;
            this.tbSimPressReadER.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressReadER.TabIndex = 109;
            this.tbSimPressReadER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label87
            // 
            this.label87.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label87.Location = new System.Drawing.Point(80, 161);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(34, 12);
            this.label87.TabIndex = 77;
            this.label87.Text = "0 kPa";
            // 
            // tbarSimAirReadER
            // 
            this.tbarSimAirReadER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirReadER.LargeChange = 10;
            this.tbarSimAirReadER.Location = new System.Drawing.Point(20, 22);
            this.tbarSimAirReadER.Maximum = 490;
            this.tbarSimAirReadER.Name = "tbarSimAirReadER";
            this.tbarSimAirReadER.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirReadER.Size = new System.Drawing.Size(45, 159);
            this.tbarSimAirReadER.TabIndex = 80;
            this.tbarSimAirReadER.TickFrequency = 10;
            this.tbarSimAirReadER.Value = 490;
            // 
            // btnDsipTestAts
            // 
            this.btnDsipTestAts.Location = new System.Drawing.Point(538, 196);
            this.btnDsipTestAts.Name = "btnDsipTestAts";
            this.btnDsipTestAts.Size = new System.Drawing.Size(57, 23);
            this.btnDsipTestAts.TabIndex = 111;
            this.btnDsipTestAts.Text = "ATS";
            this.btnDsipTestAts.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox20.Controls.Add(this.label88);
            this.groupBox20.Controls.Add(this.tbSimPressReadMR);
            this.groupBox20.Controls.Add(this.label89);
            this.groupBox20.Controls.Add(this.tbarSimAirReadMR);
            this.groupBox20.Controls.Add(this.label90);
            this.groupBox20.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox20.Location = new System.Drawing.Point(201, 7);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(125, 187);
            this.groupBox20.TabIndex = 113;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "MR";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label88.Location = new System.Drawing.Point(86, 112);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(24, 12);
            this.label88.TabIndex = 112;
            this.label88.Text = "kPa";
            // 
            // tbSimPressReadMR
            // 
            this.tbSimPressReadMR.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressReadMR.Location = new System.Drawing.Point(60, 86);
            this.tbSimPressReadMR.Name = "tbSimPressReadMR";
            this.tbSimPressReadMR.ReadOnly = true;
            this.tbSimPressReadMR.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressReadMR.TabIndex = 111;
            this.tbSimPressReadMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label89.Location = new System.Drawing.Point(68, 30);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(42, 12);
            this.label89.TabIndex = 77;
            this.label89.Text = "800kPa";
            // 
            // tbarSimAirReadMR
            // 
            this.tbarSimAirReadMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirReadMR.LargeChange = 10;
            this.tbarSimAirReadMR.Location = new System.Drawing.Point(17, 22);
            this.tbarSimAirReadMR.Maximum = 800;
            this.tbarSimAirReadMR.Name = "tbarSimAirReadMR";
            this.tbarSimAirReadMR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirReadMR.Size = new System.Drawing.Size(45, 159);
            this.tbarSimAirReadMR.TabIndex = 80;
            this.tbarSimAirReadMR.TickFrequency = 10;
            this.tbarSimAirReadMR.Value = 740;
            // 
            // label90
            // 
            this.label90.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label90.Location = new System.Drawing.Point(76, 161);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(34, 12);
            this.label90.TabIndex = 77;
            this.label90.Text = "0 kPa";
            // 
            // groupBox21
            // 
            this.groupBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox21.Controls.Add(this.label91);
            this.groupBox21.Controls.Add(this.tbSimPressReadBC);
            this.groupBox21.Controls.Add(this.label92);
            this.groupBox21.Controls.Add(this.label93);
            this.groupBox21.Controls.Add(this.tbarSimAirReadBC);
            this.groupBox21.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox21.Location = new System.Drawing.Point(468, 7);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(125, 187);
            this.groupBox21.TabIndex = 116;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "BC";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label91.Location = new System.Drawing.Point(90, 112);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(24, 12);
            this.label91.TabIndex = 112;
            this.label91.Text = "kPa";
            // 
            // tbSimPressReadBC
            // 
            this.tbSimPressReadBC.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressReadBC.Location = new System.Drawing.Point(64, 86);
            this.tbSimPressReadBC.Name = "tbSimPressReadBC";
            this.tbSimPressReadBC.ReadOnly = true;
            this.tbSimPressReadBC.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressReadBC.TabIndex = 111;
            this.tbSimPressReadBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label92.Location = new System.Drawing.Point(68, 30);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(46, 12);
            this.label92.TabIndex = 77;
            this.label92.Text = "490 kPa";
            // 
            // label93
            // 
            this.label93.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label93.Location = new System.Drawing.Point(80, 161);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(34, 12);
            this.label93.TabIndex = 77;
            this.label93.Text = "0 kPa";
            // 
            // tbarSimAirReadBC
            // 
            this.tbarSimAirReadBC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirReadBC.LargeChange = 10;
            this.tbarSimAirReadBC.Location = new System.Drawing.Point(20, 22);
            this.tbarSimAirReadBC.Maximum = 490;
            this.tbarSimAirReadBC.Name = "tbarSimAirReadBC";
            this.tbarSimAirReadBC.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirReadBC.Size = new System.Drawing.Size(45, 159);
            this.tbarSimAirReadBC.TabIndex = 80;
            this.tbarSimAirReadBC.TickFrequency = 10;
            // 
            // btnDispTestYokusoku
            // 
            this.btnDispTestYokusoku.Location = new System.Drawing.Point(428, 196);
            this.btnDispTestYokusoku.Name = "btnDispTestYokusoku";
            this.btnDispTestYokusoku.Size = new System.Drawing.Size(57, 23);
            this.btnDispTestYokusoku.TabIndex = 111;
            this.btnDispTestYokusoku.Text = "抑速";
            this.btnDispTestYokusoku.UseVisualStyleBackColor = true;
            // 
            // groupBox22
            // 
            this.groupBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox22.Controls.Add(this.label94);
            this.groupBox22.Controls.Add(this.tbSimPressReadSAP);
            this.groupBox22.Controls.Add(this.label95);
            this.groupBox22.Controls.Add(this.tbarSimAirReadSAP);
            this.groupBox22.Controls.Add(this.label96);
            this.groupBox22.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox22.Location = new System.Drawing.Point(339, 7);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(125, 187);
            this.groupBox22.TabIndex = 111;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "SAP";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label94.Location = new System.Drawing.Point(88, 112);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(24, 12);
            this.label94.TabIndex = 112;
            this.label94.Text = "kPa";
            // 
            // tbSimPressReadSAP
            // 
            this.tbSimPressReadSAP.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressReadSAP.Location = new System.Drawing.Point(62, 86);
            this.tbSimPressReadSAP.Name = "tbSimPressReadSAP";
            this.tbSimPressReadSAP.ReadOnly = true;
            this.tbSimPressReadSAP.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressReadSAP.TabIndex = 111;
            this.tbSimPressReadSAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label95.Location = new System.Drawing.Point(66, 30);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(46, 12);
            this.label95.TabIndex = 77;
            this.label95.Text = "490 kPa";
            // 
            // tbarSimAirReadSAP
            // 
            this.tbarSimAirReadSAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirReadSAP.LargeChange = 10;
            this.tbarSimAirReadSAP.Location = new System.Drawing.Point(15, 22);
            this.tbarSimAirReadSAP.Maximum = 490;
            this.tbarSimAirReadSAP.Name = "tbarSimAirReadSAP";
            this.tbarSimAirReadSAP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirReadSAP.Size = new System.Drawing.Size(45, 159);
            this.tbarSimAirReadSAP.TabIndex = 80;
            this.tbarSimAirReadSAP.TickFrequency = 10;
            // 
            // label96
            // 
            this.label96.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label96.Location = new System.Drawing.Point(78, 161);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(34, 12);
            this.label96.TabIndex = 77;
            this.label96.Text = "0 kPa";
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox23.Controls.Add(this.label97);
            this.groupBox23.Controls.Add(this.tbSimPressReadBP);
            this.groupBox23.Controls.Add(this.label98);
            this.groupBox23.Controls.Add(this.tbarSimAirReadBP);
            this.groupBox23.Controls.Add(this.label99);
            this.groupBox23.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox23.Location = new System.Drawing.Point(608, 7);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(125, 187);
            this.groupBox23.TabIndex = 114;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "BP";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label97.Location = new System.Drawing.Point(90, 112);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(24, 12);
            this.label97.TabIndex = 112;
            this.label97.Text = "kPa";
            // 
            // tbSimPressReadBP
            // 
            this.tbSimPressReadBP.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressReadBP.Location = new System.Drawing.Point(64, 86);
            this.tbSimPressReadBP.Name = "tbSimPressReadBP";
            this.tbSimPressReadBP.ReadOnly = true;
            this.tbSimPressReadBP.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressReadBP.TabIndex = 111;
            this.tbSimPressReadBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label98.Location = new System.Drawing.Point(68, 30);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(46, 12);
            this.label98.TabIndex = 77;
            this.label98.Text = "490 kPa";
            // 
            // tbarSimAirReadBP
            // 
            this.tbarSimAirReadBP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirReadBP.LargeChange = 10;
            this.tbarSimAirReadBP.Location = new System.Drawing.Point(17, 22);
            this.tbarSimAirReadBP.Maximum = 490;
            this.tbarSimAirReadBP.Name = "tbarSimAirReadBP";
            this.tbarSimAirReadBP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirReadBP.Size = new System.Drawing.Size(45, 159);
            this.tbarSimAirReadBP.TabIndex = 80;
            this.tbarSimAirReadBP.TickFrequency = 10;
            this.tbarSimAirReadBP.Value = 490;
            // 
            // label99
            // 
            this.label99.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label99.Location = new System.Drawing.Point(80, 161);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(34, 12);
            this.label99.TabIndex = 77;
            this.label99.Text = "0 kPa";
            // 
            // btnDispTestHatsuden
            // 
            this.btnDispTestHatsuden.Location = new System.Drawing.Point(365, 196);
            this.btnDispTestHatsuden.Name = "btnDispTestHatsuden";
            this.btnDispTestHatsuden.Size = new System.Drawing.Size(57, 23);
            this.btnDispTestHatsuden.TabIndex = 111;
            this.btnDispTestHatsuden.Text = "発電";
            this.btnDispTestHatsuden.UseVisualStyleBackColor = true;
            // 
            // groupBox24
            // 
            this.groupBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox24.Controls.Add(this.label100);
            this.groupBox24.Controls.Add(this.tbSimPressReadFV);
            this.groupBox24.Controls.Add(this.label101);
            this.groupBox24.Controls.Add(this.tbarSimAirReadFV);
            this.groupBox24.Controls.Add(this.label102);
            this.groupBox24.Enabled = false;
            this.groupBox24.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox24.Location = new System.Drawing.Point(737, 7);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(125, 187);
            this.groupBox24.TabIndex = 112;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "FV";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label100.Location = new System.Drawing.Point(88, 112);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(24, 12);
            this.label100.TabIndex = 112;
            this.label100.Text = "kPa";
            // 
            // tbSimPressReadFV
            // 
            this.tbSimPressReadFV.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressReadFV.Location = new System.Drawing.Point(62, 86);
            this.tbSimPressReadFV.Name = "tbSimPressReadFV";
            this.tbSimPressReadFV.ReadOnly = true;
            this.tbSimPressReadFV.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressReadFV.TabIndex = 111;
            this.tbSimPressReadFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label101.Location = new System.Drawing.Point(66, 30);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(46, 12);
            this.label101.TabIndex = 77;
            this.label101.Text = "490 kPa";
            // 
            // tbarSimAirReadFV
            // 
            this.tbarSimAirReadFV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirReadFV.Enabled = false;
            this.tbarSimAirReadFV.LargeChange = 10;
            this.tbarSimAirReadFV.Location = new System.Drawing.Point(15, 22);
            this.tbarSimAirReadFV.Maximum = 490;
            this.tbarSimAirReadFV.Name = "tbarSimAirReadFV";
            this.tbarSimAirReadFV.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirReadFV.Size = new System.Drawing.Size(45, 159);
            this.tbarSimAirReadFV.TabIndex = 80;
            this.tbarSimAirReadFV.TickFrequency = 10;
            this.tbarSimAirReadFV.Value = 490;
            // 
            // label102
            // 
            this.label102.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label102.Location = new System.Drawing.Point(78, 161);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(34, 12);
            this.label102.TabIndex = 77;
            this.label102.Text = "0 kPa";
            // 
            // btnDispTestSAP
            // 
            this.btnDispTestSAP.Location = new System.Drawing.Point(302, 196);
            this.btnDispTestSAP.Name = "btnDispTestSAP";
            this.btnDispTestSAP.Size = new System.Drawing.Size(57, 23);
            this.btnDispTestSAP.TabIndex = 111;
            this.btnDispTestSAP.Text = "直通";
            this.btnDispTestSAP.UseVisualStyleBackColor = true;
            // 
            // cbAirMeterDebug
            // 
            this.cbAirMeterDebug.AutoSize = true;
            this.cbAirMeterDebug.Checked = true;
            this.cbAirMeterDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAirMeterDebug.Location = new System.Drawing.Point(6, 123);
            this.cbAirMeterDebug.Name = "cbAirMeterDebug";
            this.cbAirMeterDebug.Size = new System.Drawing.Size(72, 16);
            this.cbAirMeterDebug.TabIndex = 119;
            this.cbAirMeterDebug.Text = "直接伝送";
            this.cbAirMeterDebug.UseVisualStyleBackColor = true;
            this.cbAirMeterDebug.Click += new System.EventHandler(this.cbAutoairUse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(11, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 118;
            this.label4.Text = "デバッグ用";
            // 
            // cbPortSelectAirRead
            // 
            this.cbPortSelectAirRead.FormattingEnabled = true;
            this.cbPortSelectAirRead.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPortSelectAirRead.Location = new System.Drawing.Point(78, 202);
            this.cbPortSelectAirRead.Name = "cbPortSelectAirRead";
            this.cbPortSelectAirRead.Size = new System.Drawing.Size(167, 20);
            this.cbPortSelectAirRead.TabIndex = 117;
            this.cbPortSelectAirRead.MouseHover += new System.EventHandler(this.cbPortSelectAirRead_MouseHover);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label103.Location = new System.Drawing.Point(13, 97);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(56, 19);
            this.label103.TabIndex = 111;
            this.label103.Text = "Write";
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox18.Controls.Add(this.label79);
            this.groupBox18.Controls.Add(this.label77);
            this.groupBox18.Controls.Add(this.tbSimPressER);
            this.groupBox18.Controls.Add(this.label78);
            this.groupBox18.Controls.Add(this.tbarSimAirER);
            this.groupBox18.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox18.Location = new System.Drawing.Point(78, 11);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(125, 177);
            this.groupBox18.TabIndex = 108;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "ER";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label79.Location = new System.Drawing.Point(90, 112);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(24, 12);
            this.label79.TabIndex = 110;
            this.label79.Text = "kPa";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label77.Location = new System.Drawing.Point(68, 30);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(46, 12);
            this.label77.TabIndex = 77;
            this.label77.Text = "490 kPa";
            // 
            // tbSimPressER
            // 
            this.tbSimPressER.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressER.Location = new System.Drawing.Point(64, 86);
            this.tbSimPressER.Name = "tbSimPressER";
            this.tbSimPressER.ReadOnly = true;
            this.tbSimPressER.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressER.TabIndex = 109;
            this.tbSimPressER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label78
            // 
            this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label78.Location = new System.Drawing.Point(80, 161);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(34, 12);
            this.label78.TabIndex = 77;
            this.label78.Text = "0 kPa";
            // 
            // tbarSimAirER
            // 
            this.tbarSimAirER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirER.LargeChange = 10;
            this.tbarSimAirER.Location = new System.Drawing.Point(20, 22);
            this.tbarSimAirER.Maximum = 490;
            this.tbarSimAirER.Name = "tbarSimAirER";
            this.tbarSimAirER.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirER.Size = new System.Drawing.Size(45, 149);
            this.tbarSimAirER.TabIndex = 80;
            this.tbarSimAirER.TickFrequency = 10;
            this.tbarSimAirER.Value = 490;
            this.tbarSimAirER.Scroll += new System.EventHandler(this.tbSimAir_Scroll);
            // 
            // btnSerialPortOpenDensei
            // 
            this.btnSerialPortOpenDensei.Location = new System.Drawing.Point(251, 200);
            this.btnSerialPortOpenDensei.Name = "btnSerialPortOpenDensei";
            this.btnSerialPortOpenDensei.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPortOpenDensei.TabIndex = 2;
            this.btnSerialPortOpenDensei.Text = "通信開始";
            this.btnSerialPortOpenDensei.UseVisualStyleBackColor = true;
            this.btnSerialPortOpenDensei.Click += new System.EventHandler(this.btnSerialPortAirReadOpen_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox17.Controls.Add(this.label80);
            this.groupBox17.Controls.Add(this.tbSimPressMR);
            this.groupBox17.Controls.Add(this.label75);
            this.groupBox17.Controls.Add(this.tbarSimAirMR);
            this.groupBox17.Controls.Add(this.label76);
            this.groupBox17.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox17.Location = new System.Drawing.Point(207, 11);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(125, 177);
            this.groupBox17.TabIndex = 107;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "MR";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label80.Location = new System.Drawing.Point(86, 112);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(24, 12);
            this.label80.TabIndex = 112;
            this.label80.Text = "kPa";
            // 
            // tbSimPressMR
            // 
            this.tbSimPressMR.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressMR.Location = new System.Drawing.Point(60, 86);
            this.tbSimPressMR.Name = "tbSimPressMR";
            this.tbSimPressMR.ReadOnly = true;
            this.tbSimPressMR.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressMR.TabIndex = 111;
            this.tbSimPressMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label75.Location = new System.Drawing.Point(68, 30);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(42, 12);
            this.label75.TabIndex = 77;
            this.label75.Text = "800kPa";
            // 
            // tbarSimAirMR
            // 
            this.tbarSimAirMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirMR.LargeChange = 10;
            this.tbarSimAirMR.Location = new System.Drawing.Point(17, 22);
            this.tbarSimAirMR.Maximum = 800;
            this.tbarSimAirMR.Name = "tbarSimAirMR";
            this.tbarSimAirMR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirMR.Size = new System.Drawing.Size(45, 149);
            this.tbarSimAirMR.TabIndex = 80;
            this.tbarSimAirMR.TickFrequency = 10;
            this.tbarSimAirMR.Value = 740;
            this.tbarSimAirMR.Scroll += new System.EventHandler(this.tbSimAir_Scroll);
            // 
            // label76
            // 
            this.label76.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label76.Location = new System.Drawing.Point(76, 161);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(34, 12);
            this.label76.TabIndex = 77;
            this.label76.Text = "0 kPa";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox13.Controls.Add(this.label82);
            this.groupBox13.Controls.Add(this.tbSimPressBC);
            this.groupBox13.Controls.Add(this.label68);
            this.groupBox13.Controls.Add(this.label69);
            this.groupBox13.Controls.Add(this.tbarSimAirBC);
            this.groupBox13.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox13.Location = new System.Drawing.Point(474, 11);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(125, 177);
            this.groupBox13.TabIndex = 108;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "BC";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label82.Location = new System.Drawing.Point(90, 112);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(24, 12);
            this.label82.TabIndex = 112;
            this.label82.Text = "kPa";
            // 
            // tbSimPressBC
            // 
            this.tbSimPressBC.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressBC.Location = new System.Drawing.Point(64, 86);
            this.tbSimPressBC.Name = "tbSimPressBC";
            this.tbSimPressBC.ReadOnly = true;
            this.tbSimPressBC.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressBC.TabIndex = 111;
            this.tbSimPressBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label68.Location = new System.Drawing.Point(68, 30);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(46, 12);
            this.label68.TabIndex = 77;
            this.label68.Text = "490 kPa";
            // 
            // label69
            // 
            this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label69.Location = new System.Drawing.Point(80, 161);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(34, 12);
            this.label69.TabIndex = 77;
            this.label69.Text = "0 kPa";
            // 
            // tbarSimAirBC
            // 
            this.tbarSimAirBC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirBC.LargeChange = 10;
            this.tbarSimAirBC.Location = new System.Drawing.Point(20, 22);
            this.tbarSimAirBC.Maximum = 490;
            this.tbarSimAirBC.Name = "tbarSimAirBC";
            this.tbarSimAirBC.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirBC.Size = new System.Drawing.Size(45, 149);
            this.tbarSimAirBC.TabIndex = 80;
            this.tbarSimAirBC.TickFrequency = 10;
            this.tbarSimAirBC.Scroll += new System.EventHandler(this.tbSimAir_Scroll);
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox16.Controls.Add(this.label81);
            this.groupBox16.Controls.Add(this.tbSimPressSAP);
            this.groupBox16.Controls.Add(this.label73);
            this.groupBox16.Controls.Add(this.tbarSimAirSAP);
            this.groupBox16.Controls.Add(this.label74);
            this.groupBox16.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox16.Location = new System.Drawing.Point(345, 11);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(125, 177);
            this.groupBox16.TabIndex = 106;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "SAP";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label81.Location = new System.Drawing.Point(88, 112);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(24, 12);
            this.label81.TabIndex = 112;
            this.label81.Text = "kPa";
            // 
            // tbSimPressSAP
            // 
            this.tbSimPressSAP.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressSAP.Location = new System.Drawing.Point(62, 86);
            this.tbSimPressSAP.Name = "tbSimPressSAP";
            this.tbSimPressSAP.ReadOnly = true;
            this.tbSimPressSAP.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressSAP.TabIndex = 111;
            this.tbSimPressSAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label73.Location = new System.Drawing.Point(66, 30);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(46, 12);
            this.label73.TabIndex = 77;
            this.label73.Text = "490 kPa";
            // 
            // tbarSimAirSAP
            // 
            this.tbarSimAirSAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirSAP.LargeChange = 10;
            this.tbarSimAirSAP.Location = new System.Drawing.Point(15, 22);
            this.tbarSimAirSAP.Maximum = 490;
            this.tbarSimAirSAP.Name = "tbarSimAirSAP";
            this.tbarSimAirSAP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirSAP.Size = new System.Drawing.Size(45, 149);
            this.tbarSimAirSAP.TabIndex = 80;
            this.tbarSimAirSAP.TickFrequency = 10;
            this.tbarSimAirSAP.Scroll += new System.EventHandler(this.tbSimAir_Scroll);
            // 
            // label74
            // 
            this.label74.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label74.Location = new System.Drawing.Point(78, 161);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(34, 12);
            this.label74.TabIndex = 77;
            this.label74.Text = "0 kPa";
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox14.Controls.Add(this.label83);
            this.groupBox14.Controls.Add(this.tbSimPressBP);
            this.groupBox14.Controls.Add(this.label70);
            this.groupBox14.Controls.Add(this.tbarSimAirBP);
            this.groupBox14.Controls.Add(this.label67);
            this.groupBox14.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox14.Location = new System.Drawing.Point(614, 11);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(125, 177);
            this.groupBox14.TabIndex = 107;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "BP";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label83.Location = new System.Drawing.Point(90, 112);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(24, 12);
            this.label83.TabIndex = 112;
            this.label83.Text = "kPa";
            // 
            // tbSimPressBP
            // 
            this.tbSimPressBP.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressBP.Location = new System.Drawing.Point(64, 86);
            this.tbSimPressBP.Name = "tbSimPressBP";
            this.tbSimPressBP.ReadOnly = true;
            this.tbSimPressBP.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressBP.TabIndex = 111;
            this.tbSimPressBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label70.Location = new System.Drawing.Point(68, 30);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(46, 12);
            this.label70.TabIndex = 77;
            this.label70.Text = "490 kPa";
            // 
            // tbarSimAirBP
            // 
            this.tbarSimAirBP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirBP.LargeChange = 10;
            this.tbarSimAirBP.Location = new System.Drawing.Point(17, 22);
            this.tbarSimAirBP.Maximum = 490;
            this.tbarSimAirBP.Name = "tbarSimAirBP";
            this.tbarSimAirBP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirBP.Size = new System.Drawing.Size(45, 149);
            this.tbarSimAirBP.TabIndex = 80;
            this.tbarSimAirBP.TickFrequency = 10;
            this.tbarSimAirBP.Value = 490;
            this.tbarSimAirBP.Scroll += new System.EventHandler(this.tbSimAir_Scroll);
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label67.Location = new System.Drawing.Point(80, 161);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(34, 12);
            this.label67.TabIndex = 77;
            this.label67.Text = "0 kPa";
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox15.Controls.Add(this.label84);
            this.groupBox15.Controls.Add(this.tbSimPressFV);
            this.groupBox15.Controls.Add(this.label72);
            this.groupBox15.Controls.Add(this.tbarSimAirFV);
            this.groupBox15.Controls.Add(this.label71);
            this.groupBox15.Enabled = false;
            this.groupBox15.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox15.Location = new System.Drawing.Point(743, 11);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(125, 177);
            this.groupBox15.TabIndex = 106;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "FV";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label84.Location = new System.Drawing.Point(88, 112);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(24, 12);
            this.label84.TabIndex = 112;
            this.label84.Text = "kPa";
            // 
            // tbSimPressFV
            // 
            this.tbSimPressFV.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSimPressFV.Location = new System.Drawing.Point(62, 86);
            this.tbSimPressFV.Name = "tbSimPressFV";
            this.tbSimPressFV.ReadOnly = true;
            this.tbSimPressFV.Size = new System.Drawing.Size(50, 23);
            this.tbSimPressFV.TabIndex = 111;
            this.tbSimPressFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label72.Location = new System.Drawing.Point(66, 30);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(46, 12);
            this.label72.TabIndex = 77;
            this.label72.Text = "490 kPa";
            // 
            // tbarSimAirFV
            // 
            this.tbarSimAirFV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbarSimAirFV.Enabled = false;
            this.tbarSimAirFV.LargeChange = 10;
            this.tbarSimAirFV.Location = new System.Drawing.Point(15, 22);
            this.tbarSimAirFV.Maximum = 490;
            this.tbarSimAirFV.Name = "tbarSimAirFV";
            this.tbarSimAirFV.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSimAirFV.Size = new System.Drawing.Size(45, 149);
            this.tbarSimAirFV.TabIndex = 80;
            this.tbarSimAirFV.TickFrequency = 10;
            this.tbarSimAirFV.Value = 490;
            // 
            // label71
            // 
            this.label71.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label71.Location = new System.Drawing.Point(78, 161);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(34, 12);
            this.label71.TabIndex = 77;
            this.label71.Text = "0 kPa";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbLogRows);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tbSpec);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.tbLog);
            this.tabPage2.Controls.Add(this.messageTextBox1);
            this.tabPage2.Controls.Add(this.btnLogClear);
            this.tabPage2.Controls.Add(this.buttonWrite);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1149, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "通信ログ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbLogRows
            // 
            this.tbLogRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLogRows.Location = new System.Drawing.Point(614, 515);
            this.tbLogRows.Name = "tbLogRows";
            this.tbLogRows.Size = new System.Drawing.Size(43, 19);
            this.tbLogRows.TabIndex = 66;
            this.tbLogRows.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogRows_KeyDown);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(555, 518);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 65;
            this.label17.Text = "表示行数";
            // 
            // tbSpec
            // 
            this.tbSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpec.Location = new System.Drawing.Point(669, 6);
            this.tbSpec.Multiline = true;
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.ReadOnly = true;
            this.tbSpec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSpec.Size = new System.Drawing.Size(462, 490);
            this.tbSpec.TabIndex = 64;
            this.tbSpec.Text = resources.GetString("tbSpec.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(400, 516);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 16);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.Text = "ログ出力";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnLogClear
            // 
            this.btnLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogClear.Location = new System.Drawing.Point(472, 513);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(75, 23);
            this.btnLogClear.TabIndex = 42;
            this.btnLogClear.Text = "ログクリア";
            this.btnLogClear.UseVisualStyleBackColor = true;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1149, 555);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "一覧";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpBvePlugin
            // 
            this.tpBvePlugin.Controls.Add(this.btnBveExDirOpen);
            this.tpBvePlugin.Controls.Add(this.cbSOUninstall);
            this.tpBvePlugin.Controls.Add(this.cbXmlCopy);
            this.tpBvePlugin.Controls.Add(this.linkLabel1);
            this.tpBvePlugin.Controls.Add(this.label107);
            this.tpBvePlugin.Controls.Add(this.btnReferenceChange);
            this.tpBvePlugin.Controls.Add(this.btnPluginUnInstall);
            this.tpBvePlugin.Controls.Add(this.tbInstallLog);
            this.tpBvePlugin.Controls.Add(this.label105);
            this.tpBvePlugin.Controls.Add(this.label108);
            this.tpBvePlugin.Controls.Add(this.label106);
            this.tpBvePlugin.Controls.Add(this.tbPluginDirectory);
            this.tpBvePlugin.Controls.Add(this.btnPluginInstall);
            this.tpBvePlugin.Location = new System.Drawing.Point(4, 22);
            this.tpBvePlugin.Name = "tpBvePlugin";
            this.tpBvePlugin.Padding = new System.Windows.Forms.Padding(3);
            this.tpBvePlugin.Size = new System.Drawing.Size(1149, 555);
            this.tpBvePlugin.TabIndex = 5;
            this.tpBvePlugin.Text = "BveEXプラグイン";
            this.tpBvePlugin.UseVisualStyleBackColor = true;
            // 
            // btnBveExDirOpen
            // 
            this.btnBveExDirOpen.Location = new System.Drawing.Point(632, 105);
            this.btnBveExDirOpen.Name = "btnBveExDirOpen";
            this.btnBveExDirOpen.Size = new System.Drawing.Size(75, 23);
            this.btnBveExDirOpen.TabIndex = 98;
            this.btnBveExDirOpen.Text = "フォルダを開く";
            this.btnBveExDirOpen.UseVisualStyleBackColor = true;
            this.btnBveExDirOpen.Click += new System.EventHandler(this.btnBveExDirOpen_Click);
            // 
            // cbSOUninstall
            // 
            this.cbSOUninstall.AutoSize = true;
            this.cbSOUninstall.Location = new System.Drawing.Point(397, 65);
            this.cbSOUninstall.Name = "cbSOUninstall";
            this.cbSOUninstall.Size = new System.Drawing.Size(158, 16);
            this.cbSOUninstall.TabIndex = 14;
            this.cbSOUninstall.Text = "既存SerialOutputEXを削除";
            this.cbSOUninstall.UseVisualStyleBackColor = true;
            this.cbSOUninstall.Visible = false;
            // 
            // cbXmlCopy
            // 
            this.cbXmlCopy.AutoSize = true;
            this.cbXmlCopy.Checked = true;
            this.cbXmlCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbXmlCopy.Location = new System.Drawing.Point(212, 65);
            this.cbXmlCopy.Name = "cbXmlCopy";
            this.cbXmlCopy.Size = new System.Drawing.Size(179, 16);
            this.cbXmlCopy.TabIndex = 14;
            this.cbXmlCopy.Text = "設定ファイルを上書きインストール";
            this.cbXmlCopy.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(210, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 12);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ダウンロードはこちら。";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(25, 16);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(179, 12);
            this.label107.TabIndex = 12;
            this.label107.Text = "BveEXがインストールされていません。";
            this.label107.Visible = false;
            // 
            // btnReferenceChange
            // 
            this.btnReferenceChange.Location = new System.Drawing.Point(551, 105);
            this.btnReferenceChange.Name = "btnReferenceChange";
            this.btnReferenceChange.Size = new System.Drawing.Size(75, 23);
            this.btnReferenceChange.TabIndex = 11;
            this.btnReferenceChange.Text = "変更";
            this.btnReferenceChange.UseVisualStyleBackColor = true;
            this.btnReferenceChange.Click += new System.EventHandler(this.btnReferenceChange_Click);
            // 
            // btnPluginUnInstall
            // 
            this.btnPluginUnInstall.Enabled = false;
            this.btnPluginUnInstall.Location = new System.Drawing.Point(106, 61);
            this.btnPluginUnInstall.Name = "btnPluginUnInstall";
            this.btnPluginUnInstall.Size = new System.Drawing.Size(91, 23);
            this.btnPluginUnInstall.TabIndex = 10;
            this.btnPluginUnInstall.Text = "アンインストール";
            this.btnPluginUnInstall.UseVisualStyleBackColor = true;
            this.btnPluginUnInstall.Click += new System.EventHandler(this.btnPluginUnInstall_Click);
            // 
            // tbInstallLog
            // 
            this.tbInstallLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInstallLog.Location = new System.Drawing.Point(25, 150);
            this.tbInstallLog.Multiline = true;
            this.tbInstallLog.Name = "tbInstallLog";
            this.tbInstallLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInstallLog.Size = new System.Drawing.Size(686, 449);
            this.tbInstallLog.TabIndex = 9;
            this.tbInstallLog.WordWrap = false;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(25, 135);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(78, 12);
            this.label105.TabIndex = 7;
            this.label105.Text = "インストールログ";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(25, 46);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(120, 12);
            this.label108.TabIndex = 8;
            this.label108.Text = "連動用プラグインSeldEx";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(25, 92);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(72, 12);
            this.label106.TabIndex = 8;
            this.label106.Text = "インストール先";
            // 
            // tbPluginDirectory
            // 
            this.tbPluginDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPluginDirectory.Location = new System.Drawing.Point(25, 107);
            this.tbPluginDirectory.Name = "tbPluginDirectory";
            this.tbPluginDirectory.Size = new System.Drawing.Size(540, 19);
            this.tbPluginDirectory.TabIndex = 6;
            // 
            // btnPluginInstall
            // 
            this.btnPluginInstall.Location = new System.Drawing.Point(25, 61);
            this.btnPluginInstall.Name = "btnPluginInstall";
            this.btnPluginInstall.Size = new System.Drawing.Size(75, 23);
            this.btnPluginInstall.TabIndex = 5;
            this.btnPluginInstall.Text = "インストール";
            this.btnPluginInstall.UseVisualStyleBackColor = true;
            this.btnPluginInstall.Click += new System.EventHandler(this.btnPluginInstall_Click);
            // 
            // tpFirmware
            // 
            this.tpFirmware.Controls.Add(this.gpbATSP);
            this.tpFirmware.Controls.Add(this.gpbDispBoard);
            this.tpFirmware.Controls.Add(this.gpbControllerBoard);
            this.tpFirmware.Controls.Add(this.btnDriverInstall);
            this.tpFirmware.Controls.Add(this.label118);
            this.tpFirmware.Controls.Add(this.label117);
            this.tpFirmware.Controls.Add(this.lblArduinoInstall);
            this.tpFirmware.Controls.Add(this.llArduinoIde);
            this.tpFirmware.Location = new System.Drawing.Point(4, 22);
            this.tpFirmware.Name = "tpFirmware";
            this.tpFirmware.Size = new System.Drawing.Size(1149, 555);
            this.tpFirmware.TabIndex = 6;
            this.tpFirmware.Text = "ファームウェア";
            this.tpFirmware.UseVisualStyleBackColor = true;
            // 
            // gpbATSP
            // 
            this.gpbATSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbATSP.BackColor = System.Drawing.Color.Honeydew;
            this.gpbATSP.Controls.Add(this.label116);
            this.gpbATSP.Controls.Add(this.pnlATSPBoard);
            this.gpbATSP.Controls.Add(this.tbATSPBoardVersion);
            this.gpbATSP.Controls.Add(this.btnFirmBackupP);
            this.gpbATSP.Controls.Add(this.btnOpenATSP);
            this.gpbATSP.Controls.Add(this.cbPortSelectATSP);
            this.gpbATSP.Controls.Add(this.btnEepromLoadP);
            this.gpbATSP.Location = new System.Drawing.Point(8, 245);
            this.gpbATSP.Name = "gpbATSP";
            this.gpbATSP.Size = new System.Drawing.Size(1133, 109);
            this.gpbATSP.TabIndex = 120;
            this.gpbATSP.TabStop = false;
            this.gpbATSP.Text = "ATS-P 表示灯基板";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(68, 20);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(118, 12);
            this.label116.TabIndex = 106;
            this.label116.Text = "現在のATS-P基板Ver.";
            // 
            // pnlATSPBoard
            // 
            this.pnlATSPBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlATSPBoard.Controls.Add(this.cbVersionListPBin);
            this.pnlATSPBoard.Controls.Add(this.tbBinFilePathP);
            this.pnlATSPBoard.Controls.Add(this.cbVersionListPHex);
            this.pnlATSPBoard.Controls.Add(this.btnFirmDirOpenHexP);
            this.pnlATSPBoard.Controls.Add(this.btnFirmDirOpenBinP);
            this.pnlATSPBoard.Controls.Add(this.btnHexFileChangeP);
            this.pnlATSPBoard.Controls.Add(this.tbHexFilePathP);
            this.pnlATSPBoard.Controls.Add(this.btnBinFileChangeP);
            this.pnlATSPBoard.Controls.Add(this.btnEepromWriteP);
            this.pnlATSPBoard.Controls.Add(this.btnFirmUpdateP);
            this.pnlATSPBoard.Location = new System.Drawing.Point(5, 43);
            this.pnlATSPBoard.Name = "pnlATSPBoard";
            this.pnlATSPBoard.Size = new System.Drawing.Size(1122, 60);
            this.pnlATSPBoard.TabIndex = 120;
            // 
            // cbVersionListPBin
            // 
            this.cbVersionListPBin.FormattingEnabled = true;
            this.cbVersionListPBin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVersionListPBin.Location = new System.Drawing.Point(17, 33);
            this.cbVersionListPBin.Name = "cbVersionListPBin";
            this.cbVersionListPBin.Size = new System.Drawing.Size(167, 20);
            this.cbVersionListPBin.TabIndex = 120;
            this.cbVersionListPBin.SelectedIndexChanged += new System.EventHandler(this.cbVersionListPBin_SelectedIndexChanged_1);
            // 
            // tbBinFilePathP
            // 
            this.tbBinFilePathP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinFilePathP.Location = new System.Drawing.Point(448, 34);
            this.tbBinFilePathP.Name = "tbBinFilePathP";
            this.tbBinFilePathP.Size = new System.Drawing.Size(663, 19);
            this.tbBinFilePathP.TabIndex = 96;
            // 
            // cbVersionListPHex
            // 
            this.cbVersionListPHex.FormattingEnabled = true;
            this.cbVersionListPHex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVersionListPHex.Location = new System.Drawing.Point(16, 5);
            this.cbVersionListPHex.Name = "cbVersionListPHex";
            this.cbVersionListPHex.Size = new System.Drawing.Size(167, 20);
            this.cbVersionListPHex.TabIndex = 121;
            this.cbVersionListPHex.SelectedIndexChanged += new System.EventHandler(this.cbVersionListPHex_SelectedIndexChanged);
            // 
            // btnFirmDirOpenHexP
            // 
            this.btnFirmDirOpenHexP.Location = new System.Drawing.Point(325, 3);
            this.btnFirmDirOpenHexP.Name = "btnFirmDirOpenHexP";
            this.btnFirmDirOpenHexP.Size = new System.Drawing.Size(75, 23);
            this.btnFirmDirOpenHexP.TabIndex = 97;
            this.btnFirmDirOpenHexP.Text = "フォルダを開く";
            this.btnFirmDirOpenHexP.UseVisualStyleBackColor = true;
            this.btnFirmDirOpenHexP.Click += new System.EventHandler(this.btnFirmDirOpenHexP_Click);
            // 
            // btnFirmDirOpenBinP
            // 
            this.btnFirmDirOpenBinP.Location = new System.Drawing.Point(326, 32);
            this.btnFirmDirOpenBinP.Name = "btnFirmDirOpenBinP";
            this.btnFirmDirOpenBinP.Size = new System.Drawing.Size(75, 23);
            this.btnFirmDirOpenBinP.TabIndex = 97;
            this.btnFirmDirOpenBinP.Text = "フォルダを開く";
            this.btnFirmDirOpenBinP.UseVisualStyleBackColor = true;
            this.btnFirmDirOpenBinP.Click += new System.EventHandler(this.btnFirmDirOpenBinP_Click);
            // 
            // btnHexFileChangeP
            // 
            this.btnHexFileChangeP.Location = new System.Drawing.Point(404, 3);
            this.btnHexFileChangeP.Name = "btnHexFileChangeP";
            this.btnHexFileChangeP.Size = new System.Drawing.Size(37, 23);
            this.btnHexFileChangeP.TabIndex = 97;
            this.btnHexFileChangeP.Text = "変更";
            this.btnHexFileChangeP.UseVisualStyleBackColor = true;
            this.btnHexFileChangeP.Click += new System.EventHandler(this.btnHexFileChangeP_Click);
            // 
            // tbHexFilePathP
            // 
            this.tbHexFilePathP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexFilePathP.Location = new System.Drawing.Point(447, 5);
            this.tbHexFilePathP.Name = "tbHexFilePathP";
            this.tbHexFilePathP.Size = new System.Drawing.Size(664, 19);
            this.tbHexFilePathP.TabIndex = 96;
            // 
            // btnBinFileChangeP
            // 
            this.btnBinFileChangeP.Location = new System.Drawing.Point(405, 32);
            this.btnBinFileChangeP.Name = "btnBinFileChangeP";
            this.btnBinFileChangeP.Size = new System.Drawing.Size(38, 23);
            this.btnBinFileChangeP.TabIndex = 97;
            this.btnBinFileChangeP.Text = "変更";
            this.btnBinFileChangeP.UseVisualStyleBackColor = true;
            this.btnBinFileChangeP.Click += new System.EventHandler(this.btnBinFileChangeP_Click);
            // 
            // btnEepromWriteP
            // 
            this.btnEepromWriteP.Location = new System.Drawing.Point(188, 32);
            this.btnEepromWriteP.Name = "btnEepromWriteP";
            this.btnEepromWriteP.Size = new System.Drawing.Size(131, 23);
            this.btnEepromWriteP.TabIndex = 95;
            this.btnEepromWriteP.Text = "EEPROM設定値書込";
            this.btnEepromWriteP.UseVisualStyleBackColor = true;
            this.btnEepromWriteP.Click += new System.EventHandler(this.btnEepromWriteP_Click);
            // 
            // btnFirmUpdateP
            // 
            this.btnFirmUpdateP.Location = new System.Drawing.Point(188, 3);
            this.btnFirmUpdateP.Name = "btnFirmUpdateP";
            this.btnFirmUpdateP.Size = new System.Drawing.Size(131, 23);
            this.btnFirmUpdateP.TabIndex = 95;
            this.btnFirmUpdateP.Text = "ファーム書込";
            this.btnFirmUpdateP.UseVisualStyleBackColor = true;
            this.btnFirmUpdateP.Click += new System.EventHandler(this.btnFirmUpdateP_Click);
            // 
            // tbATSPBoardVersion
            // 
            this.tbATSPBoardVersion.Location = new System.Drawing.Point(193, 17);
            this.tbATSPBoardVersion.Name = "tbATSPBoardVersion";
            this.tbATSPBoardVersion.Size = new System.Drawing.Size(131, 19);
            this.tbATSPBoardVersion.TabIndex = 105;
            // 
            // btnFirmBackupP
            // 
            this.btnFirmBackupP.Location = new System.Drawing.Point(330, 15);
            this.btnFirmBackupP.Name = "btnFirmBackupP";
            this.btnFirmBackupP.Size = new System.Drawing.Size(131, 23);
            this.btnFirmBackupP.TabIndex = 100;
            this.btnFirmBackupP.Text = "ファームバックアップ";
            this.btnFirmBackupP.UseVisualStyleBackColor = true;
            this.btnFirmBackupP.Click += new System.EventHandler(this.btnFirmBackupP_Click);
            // 
            // btnOpenATSP
            // 
            this.btnOpenATSP.Location = new System.Drawing.Point(840, 16);
            this.btnOpenATSP.Name = "btnOpenATSP";
            this.btnOpenATSP.Size = new System.Drawing.Size(75, 23);
            this.btnOpenATSP.TabIndex = 118;
            this.btnOpenATSP.Text = "通信開始";
            this.btnOpenATSP.UseVisualStyleBackColor = true;
            this.btnOpenATSP.Visible = false;
            this.btnOpenATSP.Click += new System.EventHandler(this.btnOpenATSP_Click);
            // 
            // cbPortSelectATSP
            // 
            this.cbPortSelectATSP.FormattingEnabled = true;
            this.cbPortSelectATSP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPortSelectATSP.Location = new System.Drawing.Point(593, 18);
            this.cbPortSelectATSP.Name = "cbPortSelectATSP";
            this.cbPortSelectATSP.Size = new System.Drawing.Size(241, 20);
            this.cbPortSelectATSP.TabIndex = 119;
            this.cbPortSelectATSP.Visible = false;
            this.cbPortSelectATSP.MouseHover += new System.EventHandler(this.cbPortSelectATSP_MouseHover);
            // 
            // btnEepromLoadP
            // 
            this.btnEepromLoadP.Location = new System.Drawing.Point(467, 15);
            this.btnEepromLoadP.Name = "btnEepromLoadP";
            this.btnEepromLoadP.Size = new System.Drawing.Size(120, 23);
            this.btnEepromLoadP.TabIndex = 95;
            this.btnEepromLoadP.Text = "EEPROM設定値読出";
            this.btnEepromLoadP.UseVisualStyleBackColor = true;
            this.btnEepromLoadP.Click += new System.EventHandler(this.btnEepromLoadP_Click_1);
            // 
            // gpbDispBoard
            // 
            this.gpbDispBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDispBoard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbDispBoard.Controls.Add(this.pnlDispBoard);
            this.gpbDispBoard.Controls.Add(this.cbPortSelectDensei);
            this.gpbDispBoard.Controls.Add(this.btnFirmBackupD);
            this.gpbDispBoard.Controls.Add(this.label115);
            this.gpbDispBoard.Controls.Add(this.btnEepromLoadD);
            this.gpbDispBoard.Controls.Add(this.btnOpenDensei);
            this.gpbDispBoard.Controls.Add(this.tbDispBoardVersion);
            this.gpbDispBoard.Location = new System.Drawing.Point(8, 139);
            this.gpbDispBoard.Name = "gpbDispBoard";
            this.gpbDispBoard.Size = new System.Drawing.Size(1133, 100);
            this.gpbDispBoard.TabIndex = 104;
            this.gpbDispBoard.TabStop = false;
            this.gpbDispBoard.Text = "電制表示灯基板";
            // 
            // pnlDispBoard
            // 
            this.pnlDispBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDispBoard.Controls.Add(this.cbVersionListDBin);
            this.pnlDispBoard.Controls.Add(this.tbBinFilePathD);
            this.pnlDispBoard.Controls.Add(this.cbVersionListDHex);
            this.pnlDispBoard.Controls.Add(this.btnFirmDirOpenBinD);
            this.pnlDispBoard.Controls.Add(this.btnFirmDirOpenHexD);
            this.pnlDispBoard.Controls.Add(this.btnBinFileChangeD);
            this.pnlDispBoard.Controls.Add(this.btnHexFileChangeD);
            this.pnlDispBoard.Controls.Add(this.tbHexFilePathD);
            this.pnlDispBoard.Controls.Add(this.btnEepromWriteD);
            this.pnlDispBoard.Controls.Add(this.btnFirmUpdateD);
            this.pnlDispBoard.Location = new System.Drawing.Point(5, 37);
            this.pnlDispBoard.Name = "pnlDispBoard";
            this.pnlDispBoard.Size = new System.Drawing.Size(1122, 58);
            this.pnlDispBoard.TabIndex = 121;
            // 
            // cbVersionListDBin
            // 
            this.cbVersionListDBin.FormattingEnabled = true;
            this.cbVersionListDBin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVersionListDBin.Location = new System.Drawing.Point(17, 31);
            this.cbVersionListDBin.Name = "cbVersionListDBin";
            this.cbVersionListDBin.Size = new System.Drawing.Size(167, 20);
            this.cbVersionListDBin.TabIndex = 120;
            this.cbVersionListDBin.SelectedIndexChanged += new System.EventHandler(this.cbVersionListDBin_SelectedIndexChanged);
            // 
            // tbBinFilePathD
            // 
            this.tbBinFilePathD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinFilePathD.Location = new System.Drawing.Point(448, 31);
            this.tbBinFilePathD.Name = "tbBinFilePathD";
            this.tbBinFilePathD.Size = new System.Drawing.Size(663, 19);
            this.tbBinFilePathD.TabIndex = 96;
            // 
            // cbVersionListDHex
            // 
            this.cbVersionListDHex.FormattingEnabled = true;
            this.cbVersionListDHex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVersionListDHex.Location = new System.Drawing.Point(17, 5);
            this.cbVersionListDHex.Name = "cbVersionListDHex";
            this.cbVersionListDHex.Size = new System.Drawing.Size(167, 20);
            this.cbVersionListDHex.TabIndex = 120;
            this.cbVersionListDHex.SelectedIndexChanged += new System.EventHandler(this.cbVersionListDHex_SelectedIndexChanged);
            // 
            // btnFirmDirOpenBinD
            // 
            this.btnFirmDirOpenBinD.Location = new System.Drawing.Point(326, 29);
            this.btnFirmDirOpenBinD.Name = "btnFirmDirOpenBinD";
            this.btnFirmDirOpenBinD.Size = new System.Drawing.Size(75, 23);
            this.btnFirmDirOpenBinD.TabIndex = 97;
            this.btnFirmDirOpenBinD.Text = "フォルダを開く";
            this.btnFirmDirOpenBinD.UseVisualStyleBackColor = true;
            this.btnFirmDirOpenBinD.Click += new System.EventHandler(this.btnFirmDirOpenBinD_Click);
            // 
            // btnFirmDirOpenHexD
            // 
            this.btnFirmDirOpenHexD.Location = new System.Drawing.Point(325, 3);
            this.btnFirmDirOpenHexD.Name = "btnFirmDirOpenHexD";
            this.btnFirmDirOpenHexD.Size = new System.Drawing.Size(75, 23);
            this.btnFirmDirOpenHexD.TabIndex = 97;
            this.btnFirmDirOpenHexD.Text = "フォルダを開く";
            this.btnFirmDirOpenHexD.UseVisualStyleBackColor = true;
            this.btnFirmDirOpenHexD.Click += new System.EventHandler(this.btnFirmDirOpenHexD_Click);
            // 
            // btnBinFileChangeD
            // 
            this.btnBinFileChangeD.Location = new System.Drawing.Point(407, 29);
            this.btnBinFileChangeD.Name = "btnBinFileChangeD";
            this.btnBinFileChangeD.Size = new System.Drawing.Size(38, 23);
            this.btnBinFileChangeD.TabIndex = 97;
            this.btnBinFileChangeD.Text = "変更";
            this.btnBinFileChangeD.UseVisualStyleBackColor = true;
            this.btnBinFileChangeD.Click += new System.EventHandler(this.btnBinFileChangeD_Click);
            // 
            // btnHexFileChangeD
            // 
            this.btnHexFileChangeD.Location = new System.Drawing.Point(406, 3);
            this.btnHexFileChangeD.Name = "btnHexFileChangeD";
            this.btnHexFileChangeD.Size = new System.Drawing.Size(38, 23);
            this.btnHexFileChangeD.TabIndex = 97;
            this.btnHexFileChangeD.Text = "変更";
            this.btnHexFileChangeD.UseVisualStyleBackColor = true;
            this.btnHexFileChangeD.Click += new System.EventHandler(this.btnHexFileChangeD_Click);
            // 
            // tbHexFilePathD
            // 
            this.tbHexFilePathD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexFilePathD.Location = new System.Drawing.Point(448, 5);
            this.tbHexFilePathD.Name = "tbHexFilePathD";
            this.tbHexFilePathD.Size = new System.Drawing.Size(663, 19);
            this.tbHexFilePathD.TabIndex = 96;
            // 
            // btnEepromWriteD
            // 
            this.btnEepromWriteD.Location = new System.Drawing.Point(188, 29);
            this.btnEepromWriteD.Name = "btnEepromWriteD";
            this.btnEepromWriteD.Size = new System.Drawing.Size(131, 23);
            this.btnEepromWriteD.TabIndex = 95;
            this.btnEepromWriteD.Text = "EEPROM設定値書込";
            this.btnEepromWriteD.UseVisualStyleBackColor = true;
            this.btnEepromWriteD.Click += new System.EventHandler(this.btnEepromWriteD_Click);
            // 
            // btnFirmUpdateD
            // 
            this.btnFirmUpdateD.Location = new System.Drawing.Point(188, 3);
            this.btnFirmUpdateD.Name = "btnFirmUpdateD";
            this.btnFirmUpdateD.Size = new System.Drawing.Size(131, 23);
            this.btnFirmUpdateD.TabIndex = 95;
            this.btnFirmUpdateD.Text = "ファーム書込";
            this.btnFirmUpdateD.UseVisualStyleBackColor = true;
            this.btnFirmUpdateD.Click += new System.EventHandler(this.btnFirmUpdateD_Click);
            // 
            // cbPortSelectDensei
            // 
            this.cbPortSelectDensei.FormattingEnabled = true;
            this.cbPortSelectDensei.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPortSelectDensei.Location = new System.Drawing.Point(593, 15);
            this.cbPortSelectDensei.Name = "cbPortSelectDensei";
            this.cbPortSelectDensei.Size = new System.Drawing.Size(241, 20);
            this.cbPortSelectDensei.TabIndex = 119;
            this.cbPortSelectDensei.Visible = false;
            this.cbPortSelectDensei.MouseHover += new System.EventHandler(this.cbPortSelectDensei_MouseHover);
            // 
            // btnFirmBackupD
            // 
            this.btnFirmBackupD.Location = new System.Drawing.Point(330, 13);
            this.btnFirmBackupD.Name = "btnFirmBackupD";
            this.btnFirmBackupD.Size = new System.Drawing.Size(131, 23);
            this.btnFirmBackupD.TabIndex = 100;
            this.btnFirmBackupD.Text = "ファームバックアップ";
            this.btnFirmBackupD.UseVisualStyleBackColor = true;
            this.btnFirmBackupD.Click += new System.EventHandler(this.btnFirmBackupD_Click);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(68, 18);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(119, 12);
            this.label115.TabIndex = 106;
            this.label115.Text = "現在の表示灯基板Ver.";
            // 
            // btnEepromLoadD
            // 
            this.btnEepromLoadD.Location = new System.Drawing.Point(467, 13);
            this.btnEepromLoadD.Name = "btnEepromLoadD";
            this.btnEepromLoadD.Size = new System.Drawing.Size(120, 23);
            this.btnEepromLoadD.TabIndex = 95;
            this.btnEepromLoadD.Text = "EEPROM設定値読出";
            this.btnEepromLoadD.UseVisualStyleBackColor = true;
            this.btnEepromLoadD.Click += new System.EventHandler(this.btnEepromLoadD_Click);
            // 
            // btnOpenDensei
            // 
            this.btnOpenDensei.Location = new System.Drawing.Point(840, 14);
            this.btnOpenDensei.Name = "btnOpenDensei";
            this.btnOpenDensei.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDensei.TabIndex = 118;
            this.btnOpenDensei.Text = "通信開始";
            this.btnOpenDensei.UseVisualStyleBackColor = true;
            this.btnOpenDensei.Visible = false;
            this.btnOpenDensei.Click += new System.EventHandler(this.btnOpenDensei_Click);
            // 
            // tbDispBoardVersion
            // 
            this.tbDispBoardVersion.Location = new System.Drawing.Point(193, 15);
            this.tbDispBoardVersion.Name = "tbDispBoardVersion";
            this.tbDispBoardVersion.Size = new System.Drawing.Size(131, 19);
            this.tbDispBoardVersion.TabIndex = 105;
            // 
            // gpbControllerBoard
            // 
            this.gpbControllerBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbControllerBoard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpbControllerBoard.Controls.Add(this.cbVersionListCBin);
            this.gpbControllerBoard.Controls.Add(this.cbVersionListCHex);
            this.gpbControllerBoard.Controls.Add(this.label114);
            this.gpbControllerBoard.Controls.Add(this.btnFirmBackupC);
            this.gpbControllerBoard.Controls.Add(this.btnFirmDirOpenBinC);
            this.gpbControllerBoard.Controls.Add(this.btnFirmDirOpenHexC);
            this.gpbControllerBoard.Controls.Add(this.tbControlBoardVersion);
            this.gpbControllerBoard.Controls.Add(this.btnBinFileChangeC);
            this.gpbControllerBoard.Controls.Add(this.btnHexFileChangeC);
            this.gpbControllerBoard.Controls.Add(this.tbBinFilePathC);
            this.gpbControllerBoard.Controls.Add(this.tbHexFilePathC);
            this.gpbControllerBoard.Controls.Add(this.btnEepromWriteC);
            this.gpbControllerBoard.Controls.Add(this.btnEepromLoadC);
            this.gpbControllerBoard.Controls.Add(this.btnFirmUpdateC);
            this.gpbControllerBoard.Location = new System.Drawing.Point(8, 35);
            this.gpbControllerBoard.Name = "gpbControllerBoard";
            this.gpbControllerBoard.Size = new System.Drawing.Size(1133, 98);
            this.gpbControllerBoard.TabIndex = 103;
            this.gpbControllerBoard.TabStop = false;
            this.gpbControllerBoard.Text = "SELD Controller メイン制御基板";
            // 
            // cbVersionListCBin
            // 
            this.cbVersionListCBin.FormattingEnabled = true;
            this.cbVersionListCBin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVersionListCBin.Location = new System.Drawing.Point(22, 72);
            this.cbVersionListCBin.Name = "cbVersionListCBin";
            this.cbVersionListCBin.Size = new System.Drawing.Size(167, 20);
            this.cbVersionListCBin.TabIndex = 120;
            this.cbVersionListCBin.SelectedIndexChanged += new System.EventHandler(this.cbVersionListCBin_SelectedIndexChanged);
            // 
            // cbVersionListCHex
            // 
            this.cbVersionListCHex.FormattingEnabled = true;
            this.cbVersionListCHex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVersionListCHex.Location = new System.Drawing.Point(22, 43);
            this.cbVersionListCHex.Name = "cbVersionListCHex";
            this.cbVersionListCHex.Size = new System.Drawing.Size(167, 20);
            this.cbVersionListCHex.TabIndex = 120;
            this.cbVersionListCHex.SelectedIndexChanged += new System.EventHandler(this.cbVersionListCHex_SelectedIndexChanged);
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(82, 19);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(107, 12);
            this.label114.TabIndex = 106;
            this.label114.Text = "現在の制御基板Ver.";
            // 
            // btnFirmBackupC
            // 
            this.btnFirmBackupC.Location = new System.Drawing.Point(330, 14);
            this.btnFirmBackupC.Name = "btnFirmBackupC";
            this.btnFirmBackupC.Size = new System.Drawing.Size(131, 23);
            this.btnFirmBackupC.TabIndex = 100;
            this.btnFirmBackupC.Text = "ファームバックアップ";
            this.btnFirmBackupC.UseVisualStyleBackColor = true;
            this.btnFirmBackupC.Click += new System.EventHandler(this.btnFirmBackupC_Click);
            // 
            // btnFirmDirOpenBinC
            // 
            this.btnFirmDirOpenBinC.Location = new System.Drawing.Point(330, 70);
            this.btnFirmDirOpenBinC.Name = "btnFirmDirOpenBinC";
            this.btnFirmDirOpenBinC.Size = new System.Drawing.Size(75, 23);
            this.btnFirmDirOpenBinC.TabIndex = 97;
            this.btnFirmDirOpenBinC.Text = "フォルダを開く";
            this.btnFirmDirOpenBinC.UseVisualStyleBackColor = true;
            this.btnFirmDirOpenBinC.Click += new System.EventHandler(this.btnFirmDirOpenBin_Click);
            // 
            // btnFirmDirOpenHexC
            // 
            this.btnFirmDirOpenHexC.Location = new System.Drawing.Point(330, 41);
            this.btnFirmDirOpenHexC.Name = "btnFirmDirOpenHexC";
            this.btnFirmDirOpenHexC.Size = new System.Drawing.Size(75, 23);
            this.btnFirmDirOpenHexC.TabIndex = 97;
            this.btnFirmDirOpenHexC.Text = "フォルダを開く";
            this.btnFirmDirOpenHexC.UseVisualStyleBackColor = true;
            this.btnFirmDirOpenHexC.Click += new System.EventHandler(this.btnFirmDirOpenHexC_Click);
            // 
            // tbControlBoardVersion
            // 
            this.tbControlBoardVersion.Location = new System.Drawing.Point(193, 16);
            this.tbControlBoardVersion.Name = "tbControlBoardVersion";
            this.tbControlBoardVersion.Size = new System.Drawing.Size(131, 19);
            this.tbControlBoardVersion.TabIndex = 105;
            // 
            // btnBinFileChangeC
            // 
            this.btnBinFileChangeC.Location = new System.Drawing.Point(409, 70);
            this.btnBinFileChangeC.Name = "btnBinFileChangeC";
            this.btnBinFileChangeC.Size = new System.Drawing.Size(39, 23);
            this.btnBinFileChangeC.TabIndex = 97;
            this.btnBinFileChangeC.Text = "変更";
            this.btnBinFileChangeC.UseVisualStyleBackColor = true;
            this.btnBinFileChangeC.Click += new System.EventHandler(this.btnBinFileChange_Click);
            // 
            // btnHexFileChangeC
            // 
            this.btnHexFileChangeC.Location = new System.Drawing.Point(409, 41);
            this.btnHexFileChangeC.Name = "btnHexFileChangeC";
            this.btnHexFileChangeC.Size = new System.Drawing.Size(39, 23);
            this.btnHexFileChangeC.TabIndex = 97;
            this.btnHexFileChangeC.Text = "変更";
            this.btnHexFileChangeC.UseVisualStyleBackColor = true;
            this.btnHexFileChangeC.Click += new System.EventHandler(this.btnHexFileChange_Click);
            // 
            // tbBinFilePathC
            // 
            this.tbBinFilePathC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinFilePathC.Location = new System.Drawing.Point(454, 72);
            this.tbBinFilePathC.Name = "tbBinFilePathC";
            this.tbBinFilePathC.Size = new System.Drawing.Size(661, 19);
            this.tbBinFilePathC.TabIndex = 96;
            // 
            // tbHexFilePathC
            // 
            this.tbHexFilePathC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexFilePathC.Location = new System.Drawing.Point(453, 43);
            this.tbHexFilePathC.Name = "tbHexFilePathC";
            this.tbHexFilePathC.Size = new System.Drawing.Size(662, 19);
            this.tbHexFilePathC.TabIndex = 96;
            // 
            // btnEepromWriteC
            // 
            this.btnEepromWriteC.Location = new System.Drawing.Point(193, 70);
            this.btnEepromWriteC.Name = "btnEepromWriteC";
            this.btnEepromWriteC.Size = new System.Drawing.Size(131, 23);
            this.btnEepromWriteC.TabIndex = 95;
            this.btnEepromWriteC.Text = "EEPROM設定値書込";
            this.btnEepromWriteC.UseVisualStyleBackColor = true;
            this.btnEepromWriteC.Click += new System.EventHandler(this.btnEepromWrite_Click);
            // 
            // btnEepromLoadC
            // 
            this.btnEepromLoadC.Location = new System.Drawing.Point(467, 14);
            this.btnEepromLoadC.Name = "btnEepromLoadC";
            this.btnEepromLoadC.Size = new System.Drawing.Size(120, 23);
            this.btnEepromLoadC.TabIndex = 95;
            this.btnEepromLoadC.Text = "EEPROM設定値読出";
            this.btnEepromLoadC.UseVisualStyleBackColor = true;
            this.btnEepromLoadC.Click += new System.EventHandler(this.btnEepromRoadC_Click);
            // 
            // btnFirmUpdateC
            // 
            this.btnFirmUpdateC.Location = new System.Drawing.Point(193, 41);
            this.btnFirmUpdateC.Name = "btnFirmUpdateC";
            this.btnFirmUpdateC.Size = new System.Drawing.Size(131, 23);
            this.btnFirmUpdateC.TabIndex = 95;
            this.btnFirmUpdateC.Text = "ファーム書込";
            this.btnFirmUpdateC.UseVisualStyleBackColor = true;
            this.btnFirmUpdateC.Click += new System.EventHandler(this.btnFirmUpdateC_Click);
            // 
            // btnDriverInstall
            // 
            this.btnDriverInstall.Location = new System.Drawing.Point(30, 6);
            this.btnDriverInstall.Name = "btnDriverInstall";
            this.btnDriverInstall.Size = new System.Drawing.Size(130, 23);
            this.btnDriverInstall.TabIndex = 102;
            this.btnDriverInstall.Text = "ドライバのインストール";
            this.btnDriverInstall.UseVisualStyleBackColor = true;
            this.btnDriverInstall.Visible = false;
            this.btnDriverInstall.Click += new System.EventHandler(this.btnDriverInstall_Click);
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(11, 402);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(521, 12);
            this.label118.TabIndex = 99;
            this.label118.Text = "※書き込みができなくなった場合、Arduinoのブートローダーの書き込みを行うことで復活する可能性があります。";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(11, 368);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(638, 24);
            this.label117.TabIndex = 99;
            this.label117.Text = "※一部の変換コネクタや変換ケーブル、USBハブを使用すると電源容量不足によってマイコンが書き込みできず破損する場合があります。\r\n　PCと直接接続するケーブルを極" +
    "力使用してください。";
            // 
            // lblArduinoInstall
            // 
            this.lblArduinoInstall.AutoSize = true;
            this.lblArduinoInstall.Location = new System.Drawing.Point(162, 11);
            this.lblArduinoInstall.Name = "lblArduinoInstall";
            this.lblArduinoInstall.Size = new System.Drawing.Size(498, 12);
            this.lblArduinoInstall.TabIndex = 99;
            this.lblArduinoInstall.Text = "Arduino Microが認識されていません。ドライバをインストールするかArduino IDEをインストールしてください。";
            this.lblArduinoInstall.Visible = false;
            // 
            // llArduinoIde
            // 
            this.llArduinoIde.AutoSize = true;
            this.llArduinoIde.Location = new System.Drawing.Point(662, 11);
            this.llArduinoIde.Name = "llArduinoIde";
            this.llArduinoIde.Size = new System.Drawing.Size(135, 12);
            this.llArduinoIde.TabIndex = 98;
            this.llArduinoIde.TabStop = true;
            this.llArduinoIde.Text = "Arduino IDE のダウンロード";
            this.llArduinoIde.Visible = false;
            this.llArduinoIde.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llArduinoIde_LinkClicked);
            // 
            // tpExtra
            // 
            this.tpExtra.Controls.Add(this.label110);
            this.tpExtra.Location = new System.Drawing.Point(4, 22);
            this.tpExtra.Name = "tpExtra";
            this.tpExtra.Size = new System.Drawing.Size(1149, 555);
            this.tpExtra.TabIndex = 7;
            this.tpExtra.Text = "その他";
            this.tpExtra.UseVisualStyleBackColor = true;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(6, 9);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(582, 168);
            this.label110.TabIndex = 67;
            this.label110.Text = resources.GetString("label110.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.cbPortSelect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSerialPortOpen);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 96);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "シリアル通信";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(27, 56);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(271, 24);
            this.label55.TabIndex = 78;
            this.label55.Text = "適切なシリアル通信COMポート番号を選択し、\r\n[通信開始]を押す。(番号はデバイスマネージャーで確認)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 789);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1169, 22);
            this.statusStrip1.TabIndex = 65;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "ポートを開いてください";
            // 
            // tsslError
            // 
            this.tsslError.Name = "tsslError";
            this.tsslError.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnBrkMinus
            // 
            this.btnBrkMinus.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBrkMinus.Location = new System.Drawing.Point(773, 29);
            this.btnBrkMinus.Name = "btnBrkMinus";
            this.btnBrkMinus.Size = new System.Drawing.Size(27, 31);
            this.btnBrkMinus.TabIndex = 79;
            this.btnBrkMinus.Text = "-";
            this.btnBrkMinus.UseVisualStyleBackColor = true;
            this.btnBrkMinus.Click += new System.EventHandler(this.btnBrkMinus_Click);
            // 
            // btnBrkPlus
            // 
            this.btnBrkPlus.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBrkPlus.Location = new System.Drawing.Point(856, 29);
            this.btnBrkPlus.Name = "btnBrkPlus";
            this.btnBrkPlus.Size = new System.Drawing.Size(27, 31);
            this.btnBrkPlus.TabIndex = 79;
            this.btnBrkPlus.Text = "+";
            this.btnBrkPlus.UseVisualStyleBackColor = true;
            this.btnBrkPlus.Click += new System.EventHandler(this.btnBrkPlus_Click);
            // 
            // tbBrkNumTop
            // 
            this.tbBrkNumTop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBrkNumTop.Location = new System.Drawing.Point(802, 29);
            this.tbBrkNumTop.Name = "tbBrkNumTop";
            this.tbBrkNumTop.Size = new System.Drawing.Size(52, 31);
            this.tbBrkNumTop.TabIndex = 30;
            this.tbBrkNumTop.Text = "8";
            this.tbBrkNumTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBrkNumTop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBrkNum_KeyDown);
            // 
            // lblBrkSetTop
            // 
            this.lblBrkSetTop.AutoSize = true;
            this.lblBrkSetTop.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBrkSetTop.Location = new System.Drawing.Point(542, 37);
            this.lblBrkSetTop.Name = "lblBrkSetTop";
            this.lblBrkSetTop.Size = new System.Drawing.Size(113, 19);
            this.lblBrkSetTop.TabIndex = 80;
            this.lblBrkSetTop.Text = "ブレーキ段数";
            // 
            // btnBve5Start
            // 
            this.btnBve5Start.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBve5Start.Location = new System.Drawing.Point(889, 29);
            this.btnBve5Start.Name = "btnBve5Start";
            this.btnBve5Start.Size = new System.Drawing.Size(125, 47);
            this.btnBve5Start.TabIndex = 81;
            this.btnBve5Start.Text = "BVE5起動";
            this.btnBve5Start.UseVisualStyleBackColor = true;
            this.btnBve5Start.Click += new System.EventHandler(this.btnBve5Start_Click);
            // 
            // tbMcNumTop
            // 
            this.tbMcNumTop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMcNumTop.Location = new System.Drawing.Point(802, 96);
            this.tbMcNumTop.Name = "tbMcNumTop";
            this.tbMcNumTop.Size = new System.Drawing.Size(52, 31);
            this.tbMcNumTop.TabIndex = 30;
            this.tbMcNumTop.Text = "5";
            this.tbMcNumTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMcNumTop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMcNum_KeyDown);
            // 
            // btnMcMinus
            // 
            this.btnMcMinus.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMcMinus.Location = new System.Drawing.Point(773, 96);
            this.btnMcMinus.Name = "btnMcMinus";
            this.btnMcMinus.Size = new System.Drawing.Size(27, 31);
            this.btnMcMinus.TabIndex = 79;
            this.btnMcMinus.Text = "-";
            this.btnMcMinus.UseVisualStyleBackColor = true;
            this.btnMcMinus.Click += new System.EventHandler(this.btnMcMinus_Click);
            // 
            // btnMcPlus
            // 
            this.btnMcPlus.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMcPlus.Location = new System.Drawing.Point(856, 96);
            this.btnMcPlus.Name = "btnMcPlus";
            this.btnMcPlus.Size = new System.Drawing.Size(27, 31);
            this.btnMcPlus.TabIndex = 79;
            this.btnMcPlus.Text = "+";
            this.btnMcPlus.UseVisualStyleBackColor = true;
            this.btnMcPlus.Click += new System.EventHandler(this.btnMcPlus_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(542, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 19);
            this.label12.TabIndex = 80;
            this.label12.Text = "マスコン段数(BVE車両)";
            // 
            // btnBve6Start
            // 
            this.btnBve6Start.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBve6Start.Location = new System.Drawing.Point(889, 80);
            this.btnBve6Start.Name = "btnBve6Start";
            this.btnBve6Start.Size = new System.Drawing.Size(125, 47);
            this.btnBve6Start.TabIndex = 81;
            this.btnBve6Start.Text = "BVE6起動";
            this.btnBve6Start.UseVisualStyleBackColor = true;
            this.btnBve6Start.Click += new System.EventHandler(this.btnBve6Start_Click);
            // 
            // tbMcNumMaxTop
            // 
            this.tbMcNumMaxTop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMcNumMaxTop.Location = new System.Drawing.Point(802, 63);
            this.tbMcNumMaxTop.Name = "tbMcNumMaxTop";
            this.tbMcNumMaxTop.Size = new System.Drawing.Size(52, 31);
            this.tbMcNumMaxTop.TabIndex = 30;
            this.tbMcNumMaxTop.Text = "5";
            this.tbMcNumMaxTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMcNumMaxTop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMcNumMax_KeyDown);
            // 
            // btnMcMaxMinus
            // 
            this.btnMcMaxMinus.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMcMaxMinus.Location = new System.Drawing.Point(773, 63);
            this.btnMcMaxMinus.Name = "btnMcMaxMinus";
            this.btnMcMaxMinus.Size = new System.Drawing.Size(27, 31);
            this.btnMcMaxMinus.TabIndex = 79;
            this.btnMcMaxMinus.Text = "-";
            this.btnMcMaxMinus.UseVisualStyleBackColor = true;
            this.btnMcMaxMinus.Click += new System.EventHandler(this.btnMcMaxMinus_Click);
            // 
            // btnMcMaxPlus
            // 
            this.btnMcMaxPlus.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMcMaxPlus.Location = new System.Drawing.Point(856, 63);
            this.btnMcMaxPlus.Name = "btnMcMaxPlus";
            this.btnMcMaxPlus.Size = new System.Drawing.Size(27, 31);
            this.btnMcMaxPlus.TabIndex = 79;
            this.btnMcMaxPlus.Text = "+";
            this.btnMcMaxPlus.UseVisualStyleBackColor = true;
            this.btnMcMaxPlus.Click += new System.EventHandler(this.btnMcMaxPlus_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(542, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 19);
            this.label13.TabIndex = 80;
            this.label13.Text = "マスコン段数(コントローラー)";
            // 
            // btnSetReadAll
            // 
            this.btnSetReadAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetReadAll.Enabled = false;
            this.btnSetReadAll.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSetReadAll.Location = new System.Drawing.Point(346, 41);
            this.btnSetReadAll.Name = "btnSetReadAll";
            this.btnSetReadAll.Size = new System.Drawing.Size(112, 35);
            this.btnSetReadAll.TabIndex = 92;
            this.btnSetReadAll.Text = "全設定値読込";
            this.btnSetReadAll.UseVisualStyleBackColor = false;
            this.btnSetReadAll.Click += new System.EventHandler(this.btnSetReadAll_Click);
            // 
            // btnSetSaveAll
            // 
            this.btnSetSaveAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetSaveAll.Enabled = false;
            this.btnSetSaveAll.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSetSaveAll.Location = new System.Drawing.Point(346, 83);
            this.btnSetSaveAll.Name = "btnSetSaveAll";
            this.btnSetSaveAll.Size = new System.Drawing.Size(112, 35);
            this.btnSetSaveAll.TabIndex = 91;
            this.btnSetSaveAll.Text = "全設定値保存";
            this.btnSetSaveAll.UseVisualStyleBackColor = false;
            this.btnSetSaveAll.Click += new System.EventHandler(this.btnSetSaveAll_Click);
            // 
            // tbSerialSend
            // 
            this.tbSerialSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerialSend.Location = new System.Drawing.Point(79, 718);
            this.tbSerialSend.Name = "tbSerialSend";
            this.tbSerialSend.Size = new System.Drawing.Size(1081, 19);
            this.tbSerialSend.TabIndex = 52;
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(20, 746);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(50, 12);
            this.label54.TabIndex = 93;
            this.label54.Text = "受信(Int)";
            // 
            // label57
            // 
            this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(20, 721);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(50, 12);
            this.label57.TabIndex = 93;
            this.label57.Text = "送信(Int)";
            // 
            // serialPortAirSimDebug
            // 
            this.serialPortAirSimDebug.BaudRate = 115200;
            this.serialPortAirSimDebug.WriteTimeout = 1000;
            this.serialPortAirSimDebug.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // tbSerialRcv2
            // 
            this.tbSerialRcv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerialRcv2.Location = new System.Drawing.Point(79, 767);
            this.tbSerialRcv2.Name = "tbSerialRcv2";
            this.tbSerialRcv2.Size = new System.Drawing.Size(1081, 19);
            this.tbSerialRcv2.TabIndex = 52;
            this.tbSerialRcv2.Visible = false;
            // 
            // lblSerialRcv2
            // 
            this.lblSerialRcv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSerialRcv2.AutoSize = true;
            this.lblSerialRcv2.Location = new System.Drawing.Point(20, 770);
            this.lblSerialRcv2.Name = "lblSerialRcv2";
            this.lblSerialRcv2.Size = new System.Drawing.Size(54, 12);
            this.lblSerialRcv2.TabIndex = 93;
            this.lblSerialRcv2.Text = "受信(Ext)";
            this.lblSerialRcv2.Visible = false;
            // 
            // cbTS185
            // 
            this.cbTS185.AutoSize = true;
            this.cbTS185.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbTS185.Location = new System.Drawing.Point(1050, 79);
            this.cbTS185.Name = "cbTS185";
            this.cbTS185.Size = new System.Drawing.Size(80, 23);
            this.cbTS185.TabIndex = 79;
            this.cbTS185.Text = "TS185";
            this.cbTS185.UseVisualStyleBackColor = true;
            this.cbTS185.CheckedChanged += new System.EventHandler(this.cbTS185_CheckedChanged);
            this.cbTS185.Click += new System.EventHandler(this.cbAutoairUse_Click);
            // 
            // btnJreTsStart
            // 
            this.btnJreTsStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnJreTsStart.Location = new System.Drawing.Point(1021, 29);
            this.btnJreTsStart.Name = "btnJreTsStart";
            this.btnJreTsStart.Size = new System.Drawing.Size(141, 47);
            this.btnJreTsStart.TabIndex = 94;
            this.btnJreTsStart.Text = "JRETS起動";
            this.btnJreTsStart.UseVisualStyleBackColor = true;
            this.btnJreTsStart.Click += new System.EventHandler(this.btnJreTsStart_Click_1);
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(1041, 104);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(121, 24);
            this.label109.TabIndex = 79;
            this.label109.Text = "JRETSモードでは\r\nプレイ中に切換可能です";
            // 
            // serialPortDensei
            // 
            this.serialPortDensei.BaudRate = 115200;
            this.serialPortDensei.WriteTimeout = 1000;
            // 
            // timerDispBoardFinder
            // 
            this.timerDispBoardFinder.Interval = 500;
            this.timerDispBoardFinder.Tick += new System.EventHandler(this.timerDispBoardFinder_Tick);
            // 
            // timerATSPBoardFinder
            // 
            this.timerATSPBoardFinder.Interval = 500;
            this.timerATSPBoardFinder.Tick += new System.EventHandler(this.timerATSPBoardFinder_Tick);
            // 
            // btnSaveParamXml
            // 
            this.btnSaveParamXml.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveParamXml.Enabled = false;
            this.btnSaveParamXml.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSaveParamXml.Location = new System.Drawing.Point(460, 83);
            this.btnSaveParamXml.Name = "btnSaveParamXml";
            this.btnSaveParamXml.Size = new System.Drawing.Size(82, 35);
            this.btnSaveParamXml.TabIndex = 95;
            this.btnSaveParamXml.Text = "XML保存";
            this.btnSaveParamXml.UseVisualStyleBackColor = false;
            this.btnSaveParamXml.Click += new System.EventHandler(this.btnSaveParamXml_Click);
            // 
            // btnLoadParamXml
            // 
            this.btnLoadParamXml.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadParamXml.Enabled = false;
            this.btnLoadParamXml.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadParamXml.Location = new System.Drawing.Point(460, 41);
            this.btnLoadParamXml.Name = "btnLoadParamXml";
            this.btnLoadParamXml.Size = new System.Drawing.Size(82, 35);
            this.btnLoadParamXml.TabIndex = 95;
            this.btnLoadParamXml.Text = "XML読込";
            this.btnLoadParamXml.UseVisualStyleBackColor = false;
            this.btnLoadParamXml.Click += new System.EventHandler(this.btnLoadParamXml_Click);
            // 
            // serialPortChecker
            // 
            this.serialPortChecker.Interval = 500;
            this.serialPortChecker.Tick += new System.EventHandler(this.serialPortChecker_Tick);
            // 
            // timerControllerBoardFinder
            // 
            this.timerControllerBoardFinder.Interval = 500;
            this.timerControllerBoardFinder.Tick += new System.EventHandler(this.timerControllerBoardFinder_Tick);
            // 
            // serialPortATSP
            // 
            this.serialPortATSP.BaudRate = 115200;
            this.serialPortATSP.WriteTimeout = 1000;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 811);
            this.Controls.Add(this.btnLoadParamXml);
            this.Controls.Add(this.btnSaveParamXml);
            this.Controls.Add(this.label109);
            this.Controls.Add(this.btnJreTsStart);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.cbTS185);
            this.Controls.Add(this.lblSerialRcv2);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.btnBve6Start);
            this.Controls.Add(this.btnBve5Start);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblBrkSetTop);
            this.Controls.Add(this.btnMcMaxPlus);
            this.Controls.Add(this.btnMcPlus);
            this.Controls.Add(this.btnBrkPlus);
            this.Controls.Add(this.btnMcMinus);
            this.Controls.Add(this.btnMcMaxMinus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBrkMinus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbMcNumTop);
            this.Controls.Add(this.tbSerialSend);
            this.Controls.Add(this.tbSerialRcv2);
            this.Controls.Add(this.tbSerialRcv);
            this.Controls.Add(this.tbBrkNumTop);
            this.Controls.Add(this.tbMcNumMaxTop);
            this.Controls.Add(this.btnSetReadAll);
            this.Controls.Add(this.btnSetSaveAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SELD Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbBCTop.ResumeLayout(false);
            this.gbBCTop.PerformLayout();
            this.gbBC.ResumeLayout(false);
            this.gbBC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBc)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.pnlDisp.ResumeLayout(false);
            this.pnlDisp.PerformLayout();
            this.pnlATSP.ResumeLayout(false);
            this.pnlATSP.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSpdTest)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarCurrentTest)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.pnlAutoair.ResumeLayout(false);
            this.pnlAutoair.PerformLayout();
            this.tpPressTest.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tpRealAutoAir.ResumeLayout(false);
            this.pnlPress.ResumeLayout(false);
            this.pnlPress.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpA.ResumeLayout(false);
            this.tpA.PerformLayout();
            this.tpE.ResumeLayout(false);
            this.tpE.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBCPress)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFV)).EndInit();
            this.tpSimAutoAir.ResumeLayout(false);
            this.tpSimAutoAir.PerformLayout();
            this.gbAirMeterDebug.ResumeLayout(false);
            this.gbAirMeterDebug.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadER)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadMR)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadBC)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadSAP)).EndInit();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadBP)).EndInit();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirReadFV)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirER)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirMR)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirBC)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirSAP)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirBP)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSimAirFV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpBvePlugin.ResumeLayout(false);
            this.tpBvePlugin.PerformLayout();
            this.tpFirmware.ResumeLayout(false);
            this.tpFirmware.PerformLayout();
            this.gpbATSP.ResumeLayout(false);
            this.gpbATSP.PerformLayout();
            this.pnlATSPBoard.ResumeLayout(false);
            this.pnlATSPBoard.PerformLayout();
            this.gpbDispBoard.ResumeLayout(false);
            this.gpbDispBoard.PerformLayout();
            this.pnlDispBoard.ResumeLayout(false);
            this.pnlDispBoard.PerformLayout();
            this.gpbControllerBoard.ResumeLayout(false);
            this.gpbControllerBoard.PerformLayout();
            this.tpExtra.ResumeLayout(false);
            this.tpExtra.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStripMenuItemDisplay_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Button btnSerialPortOpen;
        private System.Windows.Forms.ComboBox cbPortSelect;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.TextBox messageTextBox1;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPortMain;
        private System.Windows.Forms.TextBox tbSerialRcv;
        private System.Windows.Forms.Button btn010;
        private System.Windows.Forms.Button btn020;
        private System.Windows.Forms.Button btn030;
        private System.Windows.Forms.Button btn040;
        private System.Windows.Forms.Button btn050;
        private System.Windows.Forms.Button btn060;
        private System.Windows.Forms.Button btn070;
        private System.Windows.Forms.Button btn080;
        private System.Windows.Forms.Button btn090;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn110;
        private System.Windows.Forms.Button btn120;
        private System.Windows.Forms.Button btn130;
        private System.Windows.Forms.Button btn140;
        private System.Windows.Forms.Button btn150;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb010;
        private System.Windows.Forms.TextBox tb020;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn160;
        private System.Windows.Forms.TextBox tb160;
        private System.Windows.Forms.TextBox tb120;
        private System.Windows.Forms.TextBox tb080;
        private System.Windows.Forms.TextBox tb040;
        private System.Windows.Forms.TextBox tb150;
        private System.Windows.Forms.TextBox tb110;
        private System.Windows.Forms.TextBox tb070;
        private System.Windows.Forms.TextBox tb030;
        private System.Windows.Forms.TextBox tb140;
        private System.Windows.Forms.TextBox tb100;
        private System.Windows.Forms.TextBox tb060;
        private System.Windows.Forms.TextBox tb130;
        private System.Windows.Forms.TextBox tb090;
        private System.Windows.Forms.TextBox tb050;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Button btnLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpdTest;
        private System.Windows.Forms.Button btnSpdTest;
        private System.Windows.Forms.TextBox tbCurrentTest;
        private System.Windows.Forms.Button btnCurrentTest;
        private System.Windows.Forms.CheckBox cbKaisei;
        private System.Windows.Forms.RadioButton rbVolt;
        private System.Windows.Forms.RadioButton rbCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbBrkNum;
        private System.Windows.Forms.TextBox tbSapAngl;
        private System.Windows.Forms.TextBox tbEBAngl;
        private System.Windows.Forms.TextBox tbBrkFullAngl;
        private System.Windows.Forms.Button btnBrkNum;
        private System.Windows.Forms.Button btnSapAngl;
        private System.Windows.Forms.Button btnEBAngl;
        private System.Windows.Forms.Button btnBrkFullAngl;
        private System.Windows.Forms.TextBox tbOhm;
        private System.Windows.Forms.Button btnOhm;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.TrackBar tbarSpdTest;
        private System.Windows.Forms.Label lblTbarMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbModeN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbarCurrentTest;
        private System.Windows.Forms.Button btnBrkRead;
        private System.Windows.Forms.Button btnSpdRead;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbPotMode;
        private System.Windows.Forms.TextBox tbBrkSapMaxAngl;
        private System.Windows.Forms.TextBox tbChatFilter;
        private System.Windows.Forms.Button btnBrkSapMaxAngl;
        private System.Windows.Forms.Button btnChatFilter;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.Label lblChatFilter;
        private System.Windows.Forms.Label lblBrkNotch;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnBrkPlus;
        private System.Windows.Forms.Button btnBrkMinus;
        private System.Windows.Forms.TextBox tbBrkNumTop;
        private System.Windows.Forms.Label lblBrkSetTop;
        private System.Windows.Forms.Button btnBve5Start;
        private System.Windows.Forms.TextBox tbBrkSapMinAngl;
        private System.Windows.Forms.Button btnBrkSapMinAngl;
        private System.Windows.Forms.Button btnBrkSave;
        private System.Windows.Forms.TextBox tbKeep;
        private System.Windows.Forms.TextBox tbKeepFull;
        private System.Windows.Forms.Button tbnKeep;
        private System.Windows.Forms.Button btnKeepFull;
        private System.Windows.Forms.TextBox tbBpSpanDown;
        private System.Windows.Forms.TextBox tbBpSpanUp;
        private System.Windows.Forms.Button btnBpSpanDown;
        private System.Windows.Forms.Button btnBpSpanUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbAutoairUse;
        private System.Windows.Forms.Button btnSpdSave;
        private System.Windows.Forms.Panel pnlAutoair;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbarBc;
        private System.Windows.Forms.TextBox tbMcNumTop;
        private System.Windows.Forms.Button btnMcMinus;
        private System.Windows.Forms.Button btnMcPlus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMcNum;
        private System.Windows.Forms.TextBox tbMcNum;
        private System.Windows.Forms.Button btnMcNumMax;
        private System.Windows.Forms.TextBox tbMcNumMax;
        private System.Windows.Forms.Button btnBve6Start;
        private System.Windows.Forms.TextBox tbMcNumMaxTop;
        private System.Windows.Forms.Button btnMcMaxMinus;
        private System.Windows.Forms.Button btnMcMaxPlus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTbarBC500;
        private System.Windows.Forms.Label lblTbarBC0;
        private System.Windows.Forms.TextBox tbBC;
        private System.Windows.Forms.Label lblBCkPa;
        private System.Windows.Forms.CheckBox cbBpEvac;
        private System.Windows.Forms.CheckBox cbAtsConf;
        private System.Windows.Forms.CheckBox cbAtsCont;
        private System.Windows.Forms.GroupBox gbBC;
        private System.Windows.Forms.CheckBox cbRealAutoAir;
        private System.Windows.Forms.TabPage tpPressTest;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar tbarBCPress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbBCMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbBPMin;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.TextBox tbBPPressMin;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblBP_B;
        private System.Windows.Forms.TextBox tbBPPressMax;
        private System.Windows.Forms.TextBox tbBP;
        private System.Windows.Forms.TextBox tbBP_V;
        private System.Windows.Forms.TextBox tbBPMax;
        private System.Windows.Forms.TrackBar tbarBP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFVPressMax;
        private System.Windows.Forms.TextBox tbFVMax;
        private System.Windows.Forms.TextBox tbFVMin;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblFV_V;
        private System.Windows.Forms.TextBox tbFV_V;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbFV;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbFVPressMin;
        private System.Windows.Forms.Label lblFV;
        private System.Windows.Forms.TrackBar tbarFV;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.CheckBox cbModeMON;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tbBCMultiNorm;
        private System.Windows.Forms.TextBox tbBCMaxNorm;
        private System.Windows.Forms.TextBox tbBCMulti;
        private System.Windows.Forms.TextBox tbBCMax;
        private System.Windows.Forms.TextBox tbMonInterval;
        private System.Windows.Forms.TextBox tbAveRatio;
        private System.Windows.Forms.Button btnPressRead;
        private System.Windows.Forms.Button btnPressSave;
        private System.Windows.Forms.CheckBox cbBpEvacPress;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbEBInterval;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnSetReadAll;
        private System.Windows.Forms.Button btnSetSaveAll;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbBCPress;
        private System.Windows.Forms.TextBox tbLogRows;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbAtsConf;
        private System.Windows.Forms.TextBox tbAtsCont;
        private System.Windows.Forms.CheckBox cbPBroken;
        private System.Windows.Forms.CheckBox cbPMode;
        private System.Windows.Forms.CheckBox cbPFree;
        private System.Windows.Forms.CheckBox cbPBreak;
        private System.Windows.Forms.CheckBox cbPPettern;
        private System.Windows.Forms.CheckBox cbPDengen;
        private System.Windows.Forms.CheckBox cbDoor;
        private System.Windows.Forms.CheckBox cbLampSap;
        private System.Windows.Forms.CheckBox cbLampHatsuden;
        private System.Windows.Forms.CheckBox cbLampYokusoku;
        private System.Windows.Forms.CheckBox cbLampAts;
        private System.Windows.Forms.CheckBox cbLampAtsAlm;
        private System.Windows.Forms.CheckBox cbLampEb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbBCTop;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox cbAtsDengenMode;
        private System.Windows.Forms.RadioButton rbPWest;
        private System.Windows.Forms.RadioButton rbPEast;
        private System.Windows.Forms.CheckBox cbAtsPDengenAuto;
        private System.Windows.Forms.CheckBox cbAtsContactUse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbAtsSDengenTounyuTime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbBPvelocityKyudouThreshold;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpA;
        private System.Windows.Forms.TabPage tpE;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox tbBCMaxE;
        private System.Windows.Forms.TextBox tbAveRatioE;
        private System.Windows.Forms.TextBox tbBCMultiE;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox tbEBOndelay;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tbEBThreshold;
        private System.Windows.Forms.Button btnSpdSetSave;
        private System.Windows.Forms.Button btnSpdSetRead;
        private System.Windows.Forms.ToolStripMenuItem 基板設定ToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDisp;
        private System.Windows.Forms.ToolStripMenuItem オプション基板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDispBoard;
        private System.Windows.Forms.ToolStripMenuItem tsmiATSPBoard;
        private System.Windows.Forms.Panel pnlATSP;
        private System.Windows.Forms.Panel pnlPress;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbSerialSend;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tbEB;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbAtsRec;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ToolStripStatusLabel tsslError;
        private System.Windows.Forms.TextBox tbHorn2;
        private System.Windows.Forms.TextBox tbHorn1;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox tbEm;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbComma;
        private System.Windows.Forms.TextBox tbDown;
        private System.Windows.Forms.TextBox tbUp;
        private System.Windows.Forms.TextBox tbBrakeCount;
        private System.Windows.Forms.TextBox tbMcCount;
        private System.Windows.Forms.TextBox tbRev;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.CheckBox cbAtsRec;
        private System.Windows.Forms.CheckBox cbHorn2;
        private System.Windows.Forms.CheckBox cbHorn1;
        private System.Windows.Forms.CheckBox cbEB;
        private System.Windows.Forms.CheckBox cbDecEB;
        private System.Windows.Forms.Button btnAdjN;
        private System.Windows.Forms.Button btnAdjEB;
        private System.Windows.Forms.CheckBox cbUnit4;
        private System.Windows.Forms.CheckBox cbUnit3;
        private System.Windows.Forms.CheckBox cbUnit2;
        private System.Windows.Forms.CheckBox cbUnit1;
        private System.Windows.Forms.CheckBox cbUnitDisp;
        private System.Windows.Forms.TextBox tbUnitNum;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tbRegOffDelay;
        private System.Windows.Forms.CheckBox cbAutoAirEX;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tpRealAutoAir;
        private System.Windows.Forms.TabPage tpSimAutoAir;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TrackBar tbarSimAirBC;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TrackBar tbarSimAirBP;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TrackBar tbarSimAirFV;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TrackBar tbarSimAirER;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TrackBar tbarSimAirMR;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TrackBar tbarSimAirSAP;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox tbSimPressER;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox tbSimPressMR;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox tbSimPressBC;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox tbSimPressSAP;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox tbSimPressBP;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox tbSimPressFV;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox tbSimPressReadER;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TrackBar tbarSimAirReadER;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox tbSimPressReadMR;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TrackBar tbarSimAirReadMR;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox tbSimPressReadBC;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TrackBar tbarSimAirReadBC;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TextBox tbSimPressReadSAP;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TrackBar tbarSimAirReadSAP;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.TextBox tbSimPressReadBP;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.TrackBar tbarSimAirReadBP;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox tbSimPressReadFV;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TrackBar tbarSimAirReadFV;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.ComboBox cbPortSelectAirRead;
        private System.Windows.Forms.Button btnSerialPortOpenDensei;
        private System.IO.Ports.SerialPort serialPortAirSimDebug;
        private System.Windows.Forms.TextBox tbSerialRcv2;
        private System.Windows.Forms.Label lblSerialRcv2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAirMeterDebug;
        private System.Windows.Forms.GroupBox gbAirMeterDebug;
        private System.Windows.Forms.Button btnDispTestAtsAlm;
        private System.Windows.Forms.Button btnDsipTestAts;
        private System.Windows.Forms.Button btnDispTestYokusoku;
        private System.Windows.Forms.Button btnDispTestHatsuden;
        private System.Windows.Forms.Button btnDispTestSAP;
        private System.Windows.Forms.TabPage tpBvePlugin;
        private System.Windows.Forms.Button btnPluginUnInstall;
        private System.Windows.Forms.TextBox tbInstallLog;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.TextBox tbPluginDirectory;
        private System.Windows.Forms.Button btnPluginInstall;
        private System.Windows.Forms.CheckBox cbTS185;
        private System.Windows.Forms.CheckBox cbOERMode;
        private System.Windows.Forms.CheckBox cbLampOERKaisei;
        private System.Windows.Forms.CheckBox cbLampOERStop;
        private System.Windows.Forms.CheckBox cbLampOERAtt;
        private System.Windows.Forms.CheckBox cbOER1000Console;
        private System.Windows.Forms.CheckBox cbLampOERLight;
        private System.Windows.Forms.RadioButton rbATS3;
        private System.Windows.Forms.RadioButton rbATS2;
        private System.Windows.Forms.RadioButton rbATS;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.RadioButton rbAC;
        private System.Windows.Forms.RadioButton rbDC;
        private System.Windows.Forms.RadioButton rbSection;
        private System.Windows.Forms.Button btnReferenceChange;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Button btnJreTsStart;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.CheckBox cbMeterCheck;
        private System.Windows.Forms.CheckBox cbXmlCopy;
        private System.Windows.Forms.CheckBox cbSOUninstall;
        private System.Windows.Forms.CheckBox cbFVhold;
        private System.Windows.Forms.Button btnFirmUpdateC;
        private System.Windows.Forms.TabPage tpFirmware;
        private System.Windows.Forms.Button btnHexFileChangeC;
        private System.Windows.Forms.TextBox tbHexFilePathC;
        private System.Windows.Forms.LinkLabel llArduinoIde;
        private System.Windows.Forms.Label lblArduinoInstall;
        private System.Windows.Forms.Button btnEepromLoadC;
        private System.Windows.Forms.Button btnEepromWriteC;
        private System.Windows.Forms.Button btnFirmDirOpenHexC;
        private System.Windows.Forms.Button btnFirmBackupC;
        private System.Windows.Forms.Button btnBveExDirOpen;
        private System.Windows.Forms.TabPage tpExtra;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Button btnDriverInstall;
        private System.Windows.Forms.GroupBox gpbControllerBoard;
        private System.Windows.Forms.GroupBox gpbDispBoard;
        private System.Windows.Forms.Button btnFirmBackupD;
        private System.Windows.Forms.Button btnFirmDirOpenHexD;
        private System.Windows.Forms.Button btnHexFileChangeD;
        private System.Windows.Forms.TextBox tbHexFilePathD;
        private System.Windows.Forms.Button btnEepromWriteD;
        private System.Windows.Forms.Button btnEepromLoadD;
        private System.Windows.Forms.Button btnFirmUpdateD;
        private System.IO.Ports.SerialPort serialPortDensei;
        private System.Windows.Forms.ComboBox cbPortSelectDensei;
        private System.Windows.Forms.Button btnOpenDensei;
        private System.Windows.Forms.Button btnBPMaxSet;
        private System.Windows.Forms.Button btnFVMaxSet;
        private System.Windows.Forms.Button btnBPMinSet;
        private System.Windows.Forms.Button btnFVMinSet;
        private System.Windows.Forms.Label lblAutoNotch;
        private System.Windows.Forms.ComboBox cbxAutoNotch;
        private System.Windows.Forms.Label lblPanto;
        private System.Windows.Forms.ComboBox cbxPanto;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.ComboBox cbxB1Dengen;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.ComboBox cbxATSDengen;
        private System.Windows.Forms.Button btnATSDengenAngle;
        private System.Windows.Forms.TextBox tbATSDengenAngle;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.TextBox tbAtsPDengenTounyuTime;
        private System.Windows.Forms.CheckBox cbAtsActiveMode;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TextBox tbControlBoardVersion;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TextBox tbDispBoardVersion;
        private System.Windows.Forms.Timer timerDispBoardFinder;
        private System.Windows.Forms.GroupBox gpbATSP;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.ComboBox cbPortSelectATSP;
        private System.Windows.Forms.Button btnOpenATSP;
        private System.Windows.Forms.TextBox tbATSPBoardVersion;
        private System.Windows.Forms.Button btnFirmBackupP;
        private System.Windows.Forms.Button btnFirmDirOpenHexP;
        private System.Windows.Forms.Button btnHexFileChangeP;
        private System.Windows.Forms.TextBox tbHexFilePathP;
        private System.Windows.Forms.Button btnEepromWriteP;
        private System.Windows.Forms.Button btnEepromLoadP;
        private System.Windows.Forms.Button btnFirmUpdateP;
        private System.Windows.Forms.Timer timerATSPBoardFinder;
        private System.Windows.Forms.CheckBox cbTransferEBState;
        private System.Windows.Forms.CheckBox cbBVEForceMode;
        private System.Windows.Forms.Button btnSaveParamXml;
        private System.Windows.Forms.Button btnLoadParamXml;
        private System.Windows.Forms.Timer serialPortChecker;
        private System.Windows.Forms.TextBox tbAdjEB;
        private System.Windows.Forms.TextBox tbAdjN;
        private System.Windows.Forms.ComboBox cbVersionListCHex;
        private System.Windows.Forms.ComboBox cbVersionListCBin;
        private System.Windows.Forms.TextBox tbBinFilePathC;
        private System.Windows.Forms.Button btnFirmDirOpenBinC;
        private System.Windows.Forms.Button btnBinFileChangeC;
        private System.Windows.Forms.Timer timerControllerBoardFinder;
        private System.Windows.Forms.TextBox tbBinFilePathD;
        private System.Windows.Forms.Button btnFirmDirOpenBinD;
        private System.Windows.Forms.Button btnBinFileChangeD;
        private System.Windows.Forms.ComboBox cbVersionListDHex;
        private System.Windows.Forms.ComboBox cbVersionListDBin;
        private System.Windows.Forms.Panel pnlDispBoard;
        private System.Windows.Forms.Panel pnlATSPBoard;
        private System.Windows.Forms.ComboBox cbVersionListPHex;
        private System.Windows.Forms.ComboBox cbVersionListPBin;
        private System.Windows.Forms.TextBox tbBinFilePathP;
        private System.Windows.Forms.Button btnFirmDirOpenBinP;
        private System.Windows.Forms.Button btnBinFileChangeP;
        private System.IO.Ports.SerialPort serialPortATSP;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

