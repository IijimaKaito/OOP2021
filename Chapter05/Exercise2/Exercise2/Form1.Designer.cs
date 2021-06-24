
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.Button5_2_ = new System.Windows.Forms.Button();
            this.inStrNum = new System.Windows.Forms.TextBox();
            this.outStrNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button5_2_
            // 
            this.Button5_2_.Location = new System.Drawing.Point(434, 52);
            this.Button5_2_.Name = "Button5_2_";
            this.Button5_2_.Size = new System.Drawing.Size(76, 41);
            this.Button5_2_.TabIndex = 0;
            this.Button5_2_.Text = "問題5.2";
            this.Button5_2_.UseVisualStyleBackColor = true;
            // 
            // inStrNum
            // 
            this.inStrNum.Location = new System.Drawing.Point(102, 36);
            this.inStrNum.Multiline = true;
            this.inStrNum.Name = "inStrNum";
            this.inStrNum.Size = new System.Drawing.Size(100, 57);
            this.inStrNum.TabIndex = 1;
            // 
            // outStrNum
            // 
            this.outStrNum.Location = new System.Drawing.Point(102, 150);
            this.outStrNum.Multiline = true;
            this.outStrNum.Name = "outStrNum";
            this.outStrNum.Size = new System.Drawing.Size(117, 50);
            this.outStrNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "変換前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "変換後";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outStrNum);
            this.Controls.Add(this.inStrNum);
            this.Controls.Add(this.Button5_2_);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button5_2_;
        private System.Windows.Forms.TextBox inStrNum;
        private System.Windows.Forms.TextBox outStrNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

