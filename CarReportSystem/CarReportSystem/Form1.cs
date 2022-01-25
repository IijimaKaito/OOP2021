﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            carReportDataGridView.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit(); //アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            listCarReport.Add(carReport);   //１レコード追加

            //コンボボックスの履歴登録
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }

        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {

            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbT.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbN.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbH.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbS.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default:    //その他
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(carReportDataGridView.CurrentRow.Index);
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[carReportDataGridView.CurrentRow.Index].UpDate(dtpDate.Value,
                                                                cbAuthor.Text,
                                                                selectedGroup(),
                                                                cbCarName.Text,
                                                                tbReport.Text,
                                                                pbPicture.Image
                                                                );
            carReportDataGridView.Refresh();//コントロールの強制再起動
        }




        private void fmMain_Load_1(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202111DataSet1.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202111DataSet.CarReport);
            carReportDataGridView.Columns[5].Visible = false;

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btConnect_Click(object sender, EventArgs e)
        {

        }
    } 
}
