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
    public partial class NewMemberForm : Form
    {
        public NewMemberForm()
        {
            InitializeComponent();
        }

        int status;
        private void NewMemberForm_Load(object sender, EventArgs e)
        {
            status = 0;
        }

        private void BT_IdCheck_Click(object sender, EventArgs e)
        {
            bool result = API.API.IdCheck(TB_ID.Text);

            if (result)
            {
                MessageBox.Show("사용가능한 아이디 입니다!");
                status = 1;
            }
            else
            {
                MessageBox.Show("사용불가한 아이디입니다.");
            }
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            #region 회원가입 텍스트 박스별 조건
            if (this.TB_NAME.Text == string.Empty)
            {

                MessageBox.Show("이름을 입력해주세요!");
                this.TB_NAME.Focus();
                return;

            }
            if (this.TB_Birth.Text == string.Empty || TB_Birth.TextLength != 8)
            {

                MessageBox.Show("생년월일 8자리를 입력해주세요!");
                this.TB_Birth.Focus();
                return;
            }

            if (this.TB_ID.Text == string.Empty)
            {

                MessageBox.Show("아이디를 입력해주세요!");
                this.TB_ID.Focus();
                return;

            }

            if (this.TB_PW.Text == string.Empty)
            {

                MessageBox.Show("비밀번호를 입력해주세요!");
                this.TB_PW.Focus();
                return;

            }

            if (TB_PW.Text != TB_PW_Check.Text)
            {

                MessageBox.Show("비밀번호와 비밀번호 확인의 값이 불일치합니다.");

                this.TB_PW_Check.Focus();

                return;

            }

            if (this.TB_HP.Text == string.Empty)
            {

                MessageBox.Show("비밀번호를 입력해주세요!");
                this.TB_HP.Focus();
                return;

            }
            #endregion

            if (API.API.NewMember_API(TB_NAME.Text, TB_Birth.Text, TB_ID.Text, TB_PW.Text, TB_HP.Text)== true&&status==1)
            {
                MessageBox.Show(TB_NAME.Text + "님 회원가입 완료, 사용할 아이디는 " + TB_ID.Text + "입니다.");
                // 정상 회원가입 안내 메시지박스를 띄운다.

                Close();
                // Form2를 닫는다. (Form1의 로그인 창으로 돌아가기 위함)
            }
            else
            {
                MessageBox.Show("비정상 입력 정보, 재확인 요망");
                // 오류 메시지박스를 띄운다.
                return;
            }
        }
    }
}
