
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.TextBoxWordChage = new System.Windows.Forms.TextBox();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.Button5_3_3 = new System.Windows.Forms.Button();
            this.tbWordCount = new System.Windows.Forms.TextBox();
            this.Button5_3_4 = new System.Windows.Forms.Button();
            this.tbWordCount4 = new System.Windows.Forms.TextBox();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.tbStrBuilder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputStrDate = new System.Windows.Forms.TextBox();
            this.outputStrDate = new System.Windows.Forms.TextBox();
            this.Button5_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Location = new System.Drawing.Point(223, 47);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(508, 19);
            this.inputStrText.TabIndex = 1;
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.Location = new System.Drawing.Point(76, 114);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(109, 19);
            this.Button5_3_1.TabIndex = 2;
            this.Button5_3_1.Text = "空白をカウント";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // TextBoxWordChage
            // 
            this.TextBoxWordChage.Location = new System.Drawing.Point(375, 155);
            this.TextBoxWordChage.Name = "TextBoxWordChage";
            this.TextBoxWordChage.Size = new System.Drawing.Size(356, 19);
            this.TextBoxWordChage.TabIndex = 4;
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(375, 114);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(356, 19);
            this.TextBoxSpaceCount.TabIndex = 6;
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.Location = new System.Drawing.Point(76, 155);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(109, 19);
            this.Button5_3_2.TabIndex = 5;
            this.Button5_3_2.Text = "置換";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.Button5_3_2_Click);
            // 
            // Button5_3_3
            // 
            this.Button5_3_3.Location = new System.Drawing.Point(76, 194);
            this.Button5_3_3.Name = "Button5_3_3";
            this.Button5_3_3.Size = new System.Drawing.Size(109, 19);
            this.Button5_3_3.TabIndex = 11;
            this.Button5_3_3.Text = "単語の数";
            this.Button5_3_3.UseVisualStyleBackColor = true;
            this.Button5_3_3.Click += new System.EventHandler(this.Button5_3_3_Click);
            // 
            // tbWordCount
            // 
            this.tbWordCount.Location = new System.Drawing.Point(375, 194);
            this.tbWordCount.Name = "tbWordCount";
            this.tbWordCount.Size = new System.Drawing.Size(356, 19);
            this.tbWordCount.TabIndex = 12;
            // 
            // Button5_3_4
            // 
            this.Button5_3_4.Location = new System.Drawing.Point(76, 227);
            this.Button5_3_4.Name = "Button5_3_4";
            this.Button5_3_4.Size = new System.Drawing.Size(109, 19);
            this.Button5_3_4.TabIndex = 13;
            this.Button5_3_4.Text = "4文字以下の単語";
            this.Button5_3_4.UseVisualStyleBackColor = true;
            this.Button5_3_4.Click += new System.EventHandler(this.Button5_3_4_Click);
            // 
            // tbWordCount4
            // 
            this.tbWordCount4.Location = new System.Drawing.Point(375, 227);
            this.tbWordCount4.Name = "tbWordCount4";
            this.tbWordCount4.Size = new System.Drawing.Size(356, 19);
            this.tbWordCount4.TabIndex = 14;
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.Location = new System.Drawing.Point(76, 270);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(109, 19);
            this.Button5_3_5.TabIndex = 15;
            this.Button5_3_5.Text = "StringBuilder";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // tbStrBuilder
            // 
            this.tbStrBuilder.Location = new System.Drawing.Point(375, 270);
            this.tbStrBuilder.Name = "tbStrBuilder";
            this.tbStrBuilder.Size = new System.Drawing.Size(356, 19);
            this.tbStrBuilder.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(27, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "問題5.4";
            // 
            // inputStrDate
            // 
            this.inputStrDate.Location = new System.Drawing.Point(223, 393);
            this.inputStrDate.Name = "inputStrDate";
            this.inputStrDate.Size = new System.Drawing.Size(678, 19);
            this.inputStrDate.TabIndex = 18;
            // 
            // outputStrDate
            // 
            this.outputStrDate.Location = new System.Drawing.Point(223, 418);
            this.outputStrDate.Multiline = true;
            this.outputStrDate.Name = "outputStrDate";
            this.outputStrDate.Size = new System.Drawing.Size(678, 107);
            this.outputStrDate.TabIndex = 19;
            // 
            // Button5_4
            // 
            this.Button5_4.Location = new System.Drawing.Point(76, 415);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(109, 83);
            this.Button5_4.TabIndex = 20;
            this.Button5_4.Text = "問題5.4";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 570);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.outputStrDate);
            this.Controls.Add(this.inputStrDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStrBuilder);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.tbWordCount4);
            this.Controls.Add(this.Button5_3_4);
            this.Controls.Add(this.tbWordCount);
            this.Controls.Add(this.Button5_3_3);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.TextBoxWordChage);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button Button5_3_1;
        private System.Windows.Forms.TextBox TextBoxWordChage;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.Button Button5_3_3;
        private System.Windows.Forms.TextBox tbWordCount;
        private System.Windows.Forms.Button Button5_3_4;
        private System.Windows.Forms.TextBox tbWordCount4;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.TextBox tbStrBuilder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputStrDate;
        private System.Windows.Forms.TextBox outputStrDate;
        private System.Windows.Forms.Button Button5_4;
    }
}

