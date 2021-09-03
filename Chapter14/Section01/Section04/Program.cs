using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        //コンストラクタ
        public Program()
        {

            //DownloadFileAsync();
            int code;
            Console.WriteLine("地域コードを入力");
            Console.WriteLine("1:前橋\n2:みなかみ\n3:宇都宮\n4:水戸\n9:その他(直接入力)");
            Console.Write(">");

            code = int.Parse(Console.ReadLine());
            //コード番号判別
                switch(code)
            {
                case 1:
                    code= 4210;
            break;
                case 2:
                    code= 4220;
                    break;
                case 3:
                    code= 4110;
                    break;
                case 4:
                    code = 4010;
                    break;
                case 9:
                    Console.WriteLine("コードを入力してください");
                    Console.Write(">");
                    code = code = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("正しく入力してください");
                    new Program();
                    break;
            }

            var results = GetWeatherReportFromYahoo(code);
                foreach(var s in results)
            {
                Console.WriteLine(s);
               
            }
        }
        //リスト14.15
            public void DownloadString()
        {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html);
        }
        //リスト14.17（非同期処理）
        private void DownloadFileAsync()
        {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\ki32072\Downloads\pleiades - win.zip");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();//アプリケーションが終わんないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("ダウンロード完了");
        }
        //リスト14.18(ストリームとしてダウンロード)
        public void OpenReadSample()
        {
            var wc = new WebClient();
            using (var stream = wc.OpenRead(@"https://yahoo.co.jp"))
            using (var sr = new StreamReader(stream, Encoding.UTF8))
            {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
        }
        //リスト14.19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
           

            using (var wc = new WebClient())
            { 
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}
