using HotelUnionClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelUnionClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        #region 호텔유니온 예약 폼으로 이동
        private void BT_Seoul(object sender, EventArgs e)
        {
            ReservationForm.sign = "s";
            this.Hide();
            ReservationForm frm = new ReservationForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void BT_Jeju(object sender, EventArgs e)
        {
            ReservationForm.sign = "j";
            this.Hide();
            ReservationForm frm = new ReservationForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void BT_Busan(object sender, EventArgs e)
        {
            ReservationForm.sign = "b";
            this.Hide();
            ReservationForm frm = new ReservationForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }
        #endregion

        //메인페이지 종료
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //로그아웃
        private void Logout_link(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BT_MyPage_Perinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeinfoForm frm = new ChangeinfoForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void BT_MyPage_Review_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewForm frm = new ReviewForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void BT_GoResvinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResvInfoForm frm = new ResvInfoForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void BT_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }
    }
}
