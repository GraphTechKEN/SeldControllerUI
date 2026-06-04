using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SELDController
{
    class ParamData
    {
        /// <summary>
        /// 番号
        /// </summary>
        [DisplayName("番号")]
        public string Num { get; set; } = "";

        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("名称")]
        public string Name { get; set; } = "";


        /// <summary>
        /// 値
        /// </summary>
        [DisplayName("データ")]
        public string Data { get; set; } = "";

        public ParamData(string num = "", string name = "", string data = "")
        {
            Num = num;                   //番号
            Name = name;    //名称
            Data = data;      //データ

        }
    }
}
