using MySql.Data.MySqlClient;
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
    public partial class ResvInfoForm : Form
    {
        string loginid = Properties.Settings.Default.LoginIDnow;
        string room_id;

        public ResvInfoForm()
        {
            InitializeComponent();
        }

        private void ResvInfoForm_Load(object sender, EventArgs e)
        {
            DataView();
            label_Top.Text = loginid + "님의 예약현황입니다.";
        }


        private void BT_GoPolicy_Click(object sender, EventArgs e)
        {
            PolicyForm frm = new PolicyForm();
            frm.Show();
        }
        
        private void BT_RoomSelect_Click(object sender, EventArgs e)
        {
            room_id = Resv_info.Rows[this.Resv_info.CurrentCellAddress.Y].Cells[5].Value.ToString();
            TB_RoomSelected.Text = Resv_info.Rows[this.Resv_info.CurrentCellAddress.Y].Cells[6].Value.ToString();
        }

        private void Resv_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_id = Resv_info.Rows[this.Resv_info.CurrentCellAddress.Y].Cells[5].Value.ToString();
            TB_RoomSelected.Text = Resv_info.Rows[this.Resv_info.CurrentCellAddress.Y].Cells[6].Value.ToString();
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
                         "SELECT name,birth,address,hp,email, room_id, room_name, start_date, end_date FROM cust_info WHERE loginid='" + loginid + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Resv_info.DataSource = dt;
            connection.Close();
        }

        private void ResvInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BT_Refund_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말, 예약을 취소하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool result = API.API.Cancel(room_id);

                if (result)
                {
                    MessageBox.Show("예약이 취소되었습니다. 환불금액은 환불규정에 따라 지급됩니다.");
                    TB_RoomSelected.Text = string.Empty;
                    DataView();
                }
                else
                {
                    MessageBox.Show("예약 취소가 실패하였습니다.");
                }
            }
            else
            {
                return;
            }
        }

        private void BT_Prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frm = new MainForm();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }
    }
}
