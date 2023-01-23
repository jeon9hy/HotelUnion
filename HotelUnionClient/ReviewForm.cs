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
    public partial class ReviewForm : Form
    {
        string loginid = Properties.Settings.Default.LoginIDnow;
        string room_id;

        public ReviewForm()
        {
            InitializeComponent();
        }
        private void ReviewForm_Load(object sender, EventArgs e)
        {
            DataView1();
            DataView2();
        }

        private void ReviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void BT_Review_Click(object sender, EventArgs e)
        {


            if (Review1.Rows.Count>0)
            {
                room_id = Review1.Rows[this.Review1.CurrentCellAddress.Y].Cells[0].Value.ToString();
                panel1.Visible = true;
                panel2.Visible = true;

            }
            else {
                MessageBox.Show("작성가능한 리뷰가 존재하지 않습니다.");
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

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            bool result = API.API.Review(loginid, room_id, TB_Review.Text);

            if (result&&TB_Review.Text!=string.Empty)
            {
                MessageBox.Show("제출완료!");
                TB_Review.Text = string.Empty;
                panel1.Visible = false;
                panel2.Visible = false;
               
            }
            else
            {
                MessageBox.Show("리뷰를 작성해주세요!");
                this.TB_Review.Focus();
                return;
            }
        }

        private void BT_Prev2_Click(object sender, EventArgs e)
        {
            TB_Review.Text = string.Empty;
            panel1.Visible = false;
            panel2.Visible = false;
            
        }
        public void DataView1()
        {
            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "hotelunion",
            "root",
            "kim39422@"));

            connection.Open();
            string sql =
                         "SELECT room_id, room_name, start_date, end_date FROM cust_info WHERE loginid='"+ loginid +"' AND room_id NOT IN(SELECT room_id from review_info WHERE loginid ='"+loginid+"')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Review1.DataSource = dt;
            connection.Close();
        }
        public void DataView2()
        {
            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "hotelunion",
            "root",
            "kim39422@"));

            connection.Open();
            string sql =
                         "SELECT room_id, content FROM review_info WHERE loginid='"+loginid+"'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Review2.DataSource = dt;
            connection.Close();
        }

    }
}
