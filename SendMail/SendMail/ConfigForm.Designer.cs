﻿
namespace SendMail
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSsl = new System.Windows.Forms.CheckBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btDefault = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSsl);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "サーバー情報";
            // 
            // cbSsl
            // 
            this.cbSsl.AutoSize = true;
            this.cbSsl.Location = new System.Drawing.Point(455, 110);
            this.cbSsl.Name = "cbSsl";
            this.cbSsl.Size = new System.Drawing.Size(68, 16);
            this.cbSsl.TabIndex = 1;
            this.cbSsl.Text = "SSL有効";
            this.cbSsl.UseVisualStyleBackColor = true;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(479, 16);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(181, 19);
            this.tbPort.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(479, 49);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(181, 19);
            this.tbPass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ポート";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "パスワード";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(98, 49);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(219, 19);
            this.tbUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ユーザー名";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(98, 12);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(219, 19);
            this.tbHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "送信サーバー";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSender);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(20, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ユーザー情報";
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(90, 31);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(219, 19);
            this.tbSender.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "送信元";
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(12, 383);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(75, 23);
            this.btDefault.TabIndex = 3;
            this.btDefault.Text = "デフォルト";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(551, 393);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(632, 393);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(713, 393);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 3;
            this.btApply.Text = "適用";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btDefault);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbSsl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btApply;
    }
}