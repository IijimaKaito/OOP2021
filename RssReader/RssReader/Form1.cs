using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        IEnumerable<ItemData> items = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
        }
        //指定したURL先からXMLデータを取得しtitle要素を取得し、リストボックスへセットする
        private void setRssTitle(string uri)
        {
            try
            {
                using (var wc = new WebClient())
                {
                    wc.Headers.Add("Content-type", "charset=UTF-8");

                    var stream = wc.OpenRead(uri);
                    XDocument xdoc = XDocument.Load(stream);
                    items = xdoc.Root.Descendants("item").Select(x => new ItemData
                    {
                        Title = (string)x.Element("title"),
                        Link = (string)x.Element("link"),
                        PubDate = (DateTime)x.Element("pubDate"),
                        Description = (string)x.Element("description")
                    }).ToList();

                    foreach (var item in items)
                    {
                        lbTitles.Items.Add(item.Title);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void lbTitles_Click(object sender, EventArgs e)
        {
           // string link = (this.items.ToArray())[lbTitles.SelectedIndex].Link;//配置を変換して[]でアクセス
           // wbBrowser.Url = new Uri(link);
            var item = items.Title.SelectedIndex;
            lbdescription.Text = "概要:" + item.Description + "\r\n更新時間："+item.PubDate.ToString("F");
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            var link = items.Titles.SelectedIndex.Link;
            //新しいFormへ表示するリンク先を渡す処理を追加
            var wbForm = new Form2(link);
            wbForm.Show();
        }
    }
}