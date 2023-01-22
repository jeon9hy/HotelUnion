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
    public partial class ChangeinfoForm : Form
    {
        string loginid = Properties.Settings.Default.LoginIDnow;
        string loginpw = Properties.Settings.Default.LoginPWnow;

        public ChangeinfoForm()
        {
            InitializeComponent();
        }

        private void ChangeinfoForm_Load(object sender, EventArgs e)
        {
            label_ID.Text = Properties.Settings.Default.LoginIDnow;

        }
        private void ChangeinfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void BT_PerinfoPrev_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frm = new MainForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void BT_ChangePW_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말, 변경하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TB_BeforePW.Text == loginpw && TB_AfterPW1.Text == TB_AfterPW2.Text)
                {
                    bool result = API.API.ChangeInfo(loginid, TB_AfterPW1.Text, null);

                    if (result)
                    {
                        MessageBox.Show("변경완료 되었습니다. 새로운 비밀번호로 로그인해주세요!");
                        this.Hide();
                        LoginForm frm = new LoginForm();
                        frm.Owner = this.Owner;
                        frm.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("변경실패하였습니다.");
                        TB_BeforePW.Clear(); TB_AfterPW1.Clear(); TB_AfterPW2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("현재 비밀번호 또는 비밀번호 확인이 일치하지않습니다.");
                }
            }
            else {
                return;
            }
            
        }

        private void BT_ChangeHP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말, 변경하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool result = API.API.ChangeInfo(loginid, null, TB_HP.Text);

                if (result)
                {
                    MessageBox.Show("변경완료 되었습니다.");
                    TB_HP.Clear();

                }
                else
                {
                    MessageBox.Show("변경실패하였습니다.");
                    TB_HP.Clear();
                }
            }
            else
            {
                return;
            }
           
        }

        private void BT_Withdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말, 탈퇴하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool result = API.API.Withdraw(loginid);

                if (result)
                {
                    MessageBox.Show("회원탈퇴되었습니다. 이용해주셔서 감사합니다.");
                    this.Hide();
                    LoginForm frm = new LoginForm();
                    frm.Owner = this.Owner;
                    frm.ShowDialog();
                }

            }
            else
            {
                return;
            }
        }


    }
}
