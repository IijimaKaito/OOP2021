
namespace RssReader
{
    partial class Form2
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
            this.btMove = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.wbBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btMove
            // 
            this.btMove.Location = new System.Drawing.Point(153, 12);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(94, 33);
            this.btMove.TabIndex = 0;
            this.btMove.Text = "進む";
            this.btMove.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(33, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(83, 33);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // wbBrowser2
            // 
            this.wbBrowser2.Location = new System.Drawing.Point(33, 64);
            this.wbBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser2.Name = "wbBrowser2";
            this.wbBrowser2.Size = new System.Drawing.Size(711, 374);
            this.wbBrowser2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbBrowser2);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btMove);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.WebBrowser wbBrowser2;
    }
}