using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotelUnionClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            TB_ID.Text = Properties.Settings.Default.LoginIDSave;
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            //api서버 연결없이 폼 수정할 때 관리자 ID&PW : admin 입력
            if (TB_ID.Text == "admin" && TB_PW.Text == "admin")
            {

                // 로그인 OK 버튼 실행할 때 저장
                if (IdCheck.Checked)
                {
                    Properties.Settings.Default.LoginIDSave = TB_ID.Text;
                    Properties.Settings.Default.Save();
                }

                Properties.Settings.Default.LoginIDnow = TB_ID.Text;
                Properties.Settings.Default.LoginPWnow = TB_PW.Text;
                Properties.Settings.Default.Save();
                this.Hide();
                MainForm frm = new MainForm();
                frm.Owner = this.Owner;
                frm.ShowDialog();
            }
            else
            {
                bool result = API.API.Login_API(TB_ID.Text, TB_PW.Text);

                if (result)
                {

                    // 로그인 OK 버튼 실행할 때 저장
                    if (IdCheck.Checked)
                    {
                        Properties.Settings.Default.LoginIDSave = TB_ID.Text;
                        Properties.Settings.Default.Save();
                    }

                    Properties.Settings.Default.LoginIDnow = TB_ID.Text;
                    Properties.Settings.Default.LoginPWnow = TB_PW.Text;
                    Properties.Settings.Default.Save();

                    this.Hide();
                    MainForm frm = new MainForm();
                    frm.Owner = this.Owner;
                    frm.ShowDialog();
                }

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TB_ID.Text = Properties.Settings.Default.LoginIDSave;
        }

        private void BT_NewM_Click(object sender, EventArgs e)
        {
            NewMemberForm sign = new NewMemberForm();
            sign.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //패스워드 입력 후 엔터키 누르면 로그인버튼 눌리는 매서드
        private void TB_PW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    BT_Login_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TB_PW.Clear();
                }
            }
        }

    }
}
