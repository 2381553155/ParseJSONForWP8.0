using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseJSONForWP8._0.Models
{
    public class FlightM
    {
        ///// <summary>
        ///// 航班
        ///// </summary>
        //private string flight;

        //public string Flight
        //{
        //    get { return flight; }
        //    set { flight = value; }
        //}



        ///// <summary>
        ///// 航班路线 
        ///// </summary>
        //private string route;

        //public string Route
        //{
        //    get { return route; }
        //    set { route = value; }
        //}

      
        

        ///// <summary>
        ///// 起飞时间
        ///// </summary>
        //private string starttime;

        //public string Starttime
        //{
        //    get { return starttime; }
        //    set { starttime = value; }
        //}



        ///// <summary>
        ///// 到达时间
        ///// </summary>
        //private string endtime;

        //public string Endtime
        //{
        //    get { return endtime; }
        //    set { endtime = value; }
        //}



        ///// <summary>
        ///// 航班状态
        ///// </summary>
        //private string state;

        //public string State
        //{
        //    get { return state; }
        //    set { state = value; }
        //}



        ///// <summary>
        ///// 详情
        ///// </summary>
        //private string detailurl;

        //public string Detailurl
        //{
        //    get { return detailurl; }
        //    set { detailurl = value; }
        //}




        ///// <summary>
        ///// 图标地址
        ///// </summary>
        //private string icon;

        //public string Icon
        //{
        //    get { return icon; }
        //    set { icon = value; }
        //}


        /// <summary>
        /// 航班
        /// </summary>
        public string flight { get; set; }

        /// <summary>
        /// 航班航线
        /// </summary>


        public string route
        {
            get;
            set;
        }

        /// <summary>
        /// 起飞时间
        /// </summary>
        public string starttime { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public string endtime { get; set; }

        /// <summary>
        /// 航班状态
        /// </summary>


        public string state
        {
            get;
            set;
        }

        /// <summary>
        /// 详情
        /// </summary>

        public string detailurl
        {
            get;
            set;
        }

        /// <summary>
        /// 图标地址
        /// </summary>
        public string icon { get; set; }
    }
}
