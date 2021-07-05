
namespace Exercise1 {
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.birthdayYear = new System.Windows.Forms.NumericUpDown();
            this.birthdayMonth = new System.Windows.Forms.NumericUpDown();
            this.birthdayDay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLeapYear = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(64, 217);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(224, 31);
            this.tbOutput.TabIndex = 0;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(447, 169);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(232, 64);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // birthdayYear
            // 
            this.birthdayYear.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.birthdayYear.Location = new System.Drawing.Point(64, 53);
            this.birthdayYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.birthdayYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.birthdayYear.Name = "birthdayYear";
            this.birthdayYear.Size = new System.Drawing.Size(66, 27);
            this.birthdayYear.TabIndex = 2;
            this.birthdayYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // birthdayMonth
            // 
            this.birthdayMonth.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.birthdayMonth.Location = new System.Drawing.Point(171, 53);
            this.birthdayMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.birthdayMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.birthdayMonth.Name = "birthdayMonth";
            this.birthdayMonth.Size = new System.Drawing.Size(46, 27);
            this.birthdayMonth.TabIndex = 2;
            this.birthdayMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.birthdayMonth.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // birthdayDay
            // 
            this.birthdayDay.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.birthdayDay.Location = new System.Drawing.Point(258, 51);
            this.birthdayDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.birthdayDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.birthdayDay.Name = "birthdayDay";
            this.birthdayDay.Size = new System.Drawing.Size(52, 27);
            this.birthdayDay.TabIndex = 2;
            this.birthdayDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.birthdayDay.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(136, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(223, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(316, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "日";
            // 
            // tbLeapYear
            // 
            this.tbLeapYear.Location = new System.Drawing.Point(64, 192);
            this.tbLeapYear.Name = "tbLeapYear";
            this.tbLeapYear.Size = new System.Drawing.Size(224, 19);
            this.tbLeapYear.TabIndex = 4;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(64, 254);
            this.age.Multiline = true;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(224, 47);
            this.age.TabIndex = 5;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(64, 124);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(240, 19);
            this.dtpDateTime.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.age);
            this.Controls.Add(this.tbLeapYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdayDay);
            this.Controls.Add(this.birthdayMonth);
            this.Controls.Add(this.birthdayYear);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birthdayYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.NumericUpDown birthdayYear;
        private System.Windows.Forms.NumericUpDown birthdayMonth;
        private System.Windows.Forms.NumericUpDown birthdayDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLeapYear;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
    }
}

