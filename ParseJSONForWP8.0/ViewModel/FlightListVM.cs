using ParseJSONForWP8._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseJSONForWP8._0.ViewModel
{
    public class FlightListVM
    {
        /// <summary>
        /// 状态码 
        /// </summary>
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }




        /// <summary>
        /// 文字内容 
        /// </summary>
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }



        /// <summary>
        /// 航班
        /// </summary>
        private List<FlightM> list;

        public List<FlightM> List
        {
            get { return list; }
            set { list = value; }
        }

    }
}
