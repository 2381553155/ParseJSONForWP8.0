using Newtonsoft.Json;
using ParseJSONForWP8._0.ViewModel;
using ParseJSONForWP8._0.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParseJSONForWP8._0.Controllers
{
    class FlightListC
    {
        FlightListV flightListV = new FlightListV();
        public FlightListC(FlightListV flightListV )
        {
            this.flightListV = flightListV;
        }


        /// <summary>
        /// 图灵机器人的key值
        /// </summary>
        private string[] key = { "2b15219bcc2fc0c93e6beab1719da82a", 
                                 "2f6ad3d1ab8d7ea7be90987674ab0f3c" 
                               };
        /// <summary>
        /// 访问图灵机器人的url
        /// </summary>
        string url;

        private string urlHelp(string key, string info)
        {
            url = "http://www.tuling123.com/openapi/api?key=" + key + "&info=" + info;
            return url;
        }

        public void getTuRingReply(string info)
        {
            url = this.urlHelp("2b15219bcc2fc0c93e6beab1719da82a", info);
            this.DoHttpWebRequest(url);
        }

        private void DoHttpWebRequest(string url)
        {

            //创建WebRequest类
            WebRequest request = HttpWebRequest.Create(url);


            //返回异步操作的状态
            IAsyncResult result = (IAsyncResult)request.BeginGetResponse(ResponseCallback, request);

        }

        private void ResponseCallback(IAsyncResult result)
        {
            //获取异步操作返回的的信息
            HttpWebRequest request = (HttpWebRequest)result.AsyncState;

            //结束对 Internet 资源的异步请求
            WebResponse response = request.EndGetResponse(result);

            try
            {
                Stream stream = response.GetResponseStream();

                Encoding ec = Encoding.UTF8;

                StreamReader reader = new StreamReader(stream, ec);
                string tuRingResponse = reader.ReadToEnd();//读取返回的json数据

                Debug.WriteLine(tuRingResponse);
                Debug.WriteLine("序列化:");

                string code = tuRingResponse.Substring(8, 6);
            
                ////航班类回复实体类对象
                FlightListVM txtrs = null;

                if (code == "306000")
                {
                    txtrs = this.DeserializeFromJson<FlightListVM>(tuRingResponse);
                    this.flightListV.updateContent(txtrs);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public T DeserializeFromJson<T>(string jsonString) where T : class
        {
            T obj = JsonConvert.DeserializeObject<T>(jsonString);
            return obj;
        }
    }
}
