
namespace Sample0823
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.Jyou = new System.Windows.Forms.TextBox();
            this.exec = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(189, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "の";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label2.Location = new System.Drawing.Point(392, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "乗";
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(55, 72);
            this.Value.Multiline = true;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(128, 50);
            this.Value.TabIndex = 1;
            // 
            // Jyou
            // 
            this.Jyou.Location = new System.Drawing.Point(258, 72);
            this.Jyou.Multiline = true;
            this.Jyou.Name = "Jyou";
            this.Jyou.Size = new System.Drawing.Size(128, 50);
            this.Jyou.TabIndex = 1;
            // 
            // exec
            // 
            this.exec.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exec.Location = new System.Drawing.Point(470, 72);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(117, 50);
            this.exec.TabIndex = 2;
            this.exec.Text = "結果　→";
            this.exec.UseVisualStyleBackColor = true;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(593, 72);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(128, 50);
            this.Result.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exec);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Jyou);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox Jyou;
        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.TextBox Result;
    }
}

