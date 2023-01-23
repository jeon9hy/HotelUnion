using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelUnionClient.Model;
using MySql.Data.MySqlClient;

namespace HotelUnionClient
{
    public partial class ReservationForm : Form
    {
        string loginid = Properties.Settings.Default.LoginIDnow;
        public static string sign;
        public string room_id;
        public string room_name;
        string date_s;
        string date_e;
        string price;
        string ds;
        string de;

        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            Date_Start.Value = DateTime.Now;
            date_s = Date_Start.Value.ToString("yyyyMMdd");
            ds = Date_Start.Value.ToString();
            Date_End.Value = DateTime.Now.AddDays(1);
            date_e = Date_End.Value.ToString("yyyyMMdd");
            de= Date_End.Value.ToString();
            label_location.Text = "HotelUnion "+sign+"";
            DataView();


        }
        private void Room_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_id = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[0].Value.ToString();
            room_name = TB_RoomSelect.Text = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[1].Value.ToString();
            price = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[4].Value.ToString();

        }

        private void BT_RoomSelect_Click(object sender, EventArgs e)
        {
            room_id = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[0].Value.ToString();
            room_name = TB_RoomSelect.Text = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[1].Value.ToString();
            price = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[4].Value.ToString();
        }

        private void Date_Start_ValueChanged(object sender, EventArgs e)
        {
            date_s = Date_Start.Value.ToString("yyyyMMdd");
            ds = Date_Start.Value.ToString();
            DataView();
        }

        private void Date_End_ValueChanged(object sender, EventArgs e)
        {
            date_e = Date_End.Value.ToString("yyyyMMdd");
            de = Date_End.Value.ToString();
            DataView();
        }

        private void BT_RevFormNext(object sender, EventArgs e)
        {
            if (room_name == null)
            {
                MessageBox.Show("객실을 선택해주세요!!");
                return;
            }
            else {

                if (MessageBox.Show(room_name + "(으)로 예약하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ts = TS(ds, de);
                    label_Price.Text = "입금하실금액 : " + int.Parse(price) * ts + "원";
                    panel1.Visible = true;
                }
                else
                {
                    return;
                }
            }

        }

        private void BT_RevFormNext2(object sender, EventArgs e)
        {
            bool result = API.API.Reservation(loginid, TB_NAME.Text,TB_Birth.Text,TB_Address.Text,TB_HP.Text,TB_Email.Text,room_id,room_name,sign,date_s, date_e);

            #region 누락정보 알림 조건
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

            if (this.TB_Address.Text == string.Empty)
            {

                MessageBox.Show("주소를 입력해주세요!");
                this.TB_Address.Focus();
                return;

            }

            if (this.TB_HP.Text == string.Empty)
            {

                MessageBox.Show("전화번호를 입력해주세요!");
                this.TB_HP.Focus();
                return;

            }
            if (this.TB_Email.Text == string.Empty)
            {

                MessageBox.Show("이메일을 입력해주세요!");
                this.TB_Email.Focus();
                return;

            }
            #endregion

            if (result)
            {
                //다음페이지 관련
                panel2.Visible = true;
                label_Name.Text ="[호텔유니온]"+ TB_NAME.Text + "님의 예약이 접수되었습니다,";
                label_RevNum.Text = "예약번호 : 12314871984";
                label_Deadline.Text = "입금기한 : "+DateTime.Now.AddDays(3).ToString();
            }
            else {
                MessageBox.Show("예약이 실패되었습니다.");
            }
        }

        private void BT_GotoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frm = new MainForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void ReservationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BT_RevFormPrev1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frm = new MainForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }

        private void BT_RevFormPrev2(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

     
        public void DataView()
        {
            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "hotelunion",
            "root",
            "kim39422@"));

            connection.Open();
            string sql =
                         "SELECT room_id, room_name, num_beds, max_people, price FROM room_info WHERE location = '" + sign + "' AND room_id NOT IN(SELECT room_id FROM reservation_info WHERE NOT(start_date>= '" + date_e + "' OR end_date<= '" + date_s + "'))";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Room_info.DataSource = dt;
            connection.Close();
        }

        public int TS(string ds, string de) {
            TimeSpan ts;

            DateTime DS = Convert.ToDateTime(ds);
            DateTime DE = Convert.ToDateTime(de);

            ts = DE-DS;

            int Days = ts.Days;

            return Days;
        }
    }
}
