using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form2 : Form
    {
        string url = "";   //表示するURL 
        public Form2(string url)
        {
            this.url = url;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            wbBrowser2.Url = new Uri(url);
        }
        //ページの読み込みが完了すると呼ばれる
        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs)
        {
            btBack.Enabled = wbBrowser2
        }
    }
}
