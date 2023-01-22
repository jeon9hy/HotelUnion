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
        public static string sign;
        public string room_id;
        public string room_name;
        string date_s;
        string date_e;

        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            Date_Start.Value = DateTime.Now;
            date_s = Date_Start.Value.ToString("yyyyMMdd");
            Date_End.Value = DateTime.Now.AddDays(1);
            date_e = Date_End.Value.ToString("yyyyMMdd");
            label_location.Text = sign;

            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "hotelunion",
            "root",
            "kim39422@"));

            connection.Open();
            string sql = "SELECT room_id, room_name, num_beds, max_people, price FROM room_info WHERE location = '"+sign+"'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Room_info.DataSource = dt;
            connection.Close();
        }

        private void BT_RevFormNext(object sender, EventArgs e)
        {
            if (MessageBox.Show("예약하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
            else
            {
                return;
            }

            panel1.Visible = true;
        }

        private void BT_RevFormNext2(object sender, EventArgs e)
        {
            bool result = API.API.Reservation(TB_NAME.Text,TB_Birth.Text,TB_Address.Text,TB_HP.Text,TB_Email.Text,room_id,room_name,sign,date_s, date_e);
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

        private void Room_info_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Room_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_id= Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[0].Value.ToString();
            room_name =TB_RoomSelect.Text = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[1].Value.ToString();
            label_Price.Text = "입금하실금액: "+Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[4].Value.ToString()+"원";
        }

        private void BT_RoomSelect_Click(object sender, EventArgs e)
        {
            room_id = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[0].Value.ToString();
            room_name =TB_RoomSelect.Text = Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[1].Value.ToString();
            label_Price.Text = "입금하실금액 : " + Room_info.Rows[this.Room_info.CurrentCellAddress.Y].Cells[4].Value.ToString()+"원";
        }

        private void Date_Start_ValueChanged(object sender, EventArgs e)
        {
            date_s = Date_Start.Value.ToString("yyyyMMdd");
           
        }

        private void Date_End_ValueChanged(object sender, EventArgs e)
        {
            date_e = Date_End.Value.ToString("yyyyMMdd");
        }

    }
}
