using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class Form1 : Form
    {
        
        //設定画面
        private ConfigForm configForm = new ConfigForm();
        //設定情報
        Settings settings = Settings.getInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (!Settings.Set)
            {
                MessageBox.Show("送信情報を設定してください");
                return;
            }
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                if(tbCc.Text !="")
                { 
                    mailMessage.CC.Add(tbCc.Text);
                }
                if(tbBcc.Text != "")
                {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                
                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;

                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials = new NetworkCredential(settings.MailAddr,settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;

                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += smtpClient_SendCompleted;
                string userState = "sendMail";
                smtpClient.SendAsync(mailMessage, userState);

                //MessageBox.Show("送信完了");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //送信が完了すると呼ばれるコールバックメソッド
        private void smtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        { 
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
                Clear();
            }

        }    

        private void btConfig_Click(object sender, EventArgs e)
        {
            configForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //起動時に送信情報が未設定の場合設定画面を表示する
            if (!Settings.Set)
            {
                configForm.ShowDialog();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();

        }
        //削除メソッド
        private void Clear()
        {
            tbBcc.Clear();
            tbCc.Clear();
            tbMessage.Clear();
            tbTitle.Clear();
            tbTo.Clear();
        }
    }
}
