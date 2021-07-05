using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            age.Text = GetAge(dtpDateTime.Value, today).ToString();
            //うるう年判定
            var isLeapYear = DateTime.IsLeapYear((int)birthdayYear.Value);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です";
            } else {
                tbLeapYear.Text = "閏年ではありません";
            }

            DayOfWeek dayOfWeek = today.DayOfWeek;


            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    tbOutput.Text = "日曜日です";
                    break;
                case DayOfWeek.Monday:
                    tbOutput.Text = "月曜日です";
                    break;
                case DayOfWeek.Tuesday:
                    tbOutput.Text = "火曜日です";
                    break;
                case DayOfWeek.Wednesday:
                    tbOutput.Text = "水曜日です";
                    break;
                case DayOfWeek.Thursday:
                    tbOutput.Text = "木曜日です";
                    break;
                case DayOfWeek.Friday:
                    tbOutput.Text = "金曜日です";
                    break;
                case DayOfWeek.Saturday:
                    tbOutput.Text = "土曜日です";
                    break;
            }
            //tbOutput.Text = DateTime.Now.DayOfYear.ToString();
            //年齢を求めるメソッド
            
        }      
        public int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            } 
            return age;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
