
namespace HotelUnionClient
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_GotoHome = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_RevNum = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Deadline = new System.Windows.Forms.Label();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_HP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TB_Birth = new System.Windows.Forms.TextBox();
            this.TB_RoomSelect = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Date_Start = new System.Windows.Forms.DateTimePicker();
            this.Date_End = new System.Windows.Forms.DateTimePicker();
            this.A = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.BT_RoomSelect = new System.Windows.Forms.Button();
            this.Room_info = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TB_Address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_Email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TB_HP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_NAME);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.TB_Birth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 509);
            this.panel1.TabIndex = 55;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BT_GotoHome);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label_Name);
            this.panel2.Controls.Add(this.label_RevNum);
            this.panel2.Controls.Add(this.label_Price);
            this.panel2.Controls.Add(this.label_Deadline);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 509);
            this.panel2.TabIndex = 70;
            this.panel2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(495, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "입금계좌 : 123-456-789(예금주 : 호텔유니온)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "입금은행 : 국민은행";
            // 
            // BT_GotoHome
            // 
            this.BT_GotoHome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_GotoHome.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GotoHome.Location = new System.Drawing.Point(190, 414);
            this.BT_GotoHome.Name = "BT_GotoHome";
            this.BT_GotoHome.Size = new System.Drawing.Size(248, 68);
            this.BT_GotoHome.TabIndex = 6;
            this.BT_GotoHome.Text = "홈화면으로";
            this.BT_GotoHome.UseVisualStyleBackColor = false;
            this.BT_GotoHome.Click += new System.EventHandler(this.BT_GotoHome_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(63, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(503, 115);
            this.label10.TabIndex = 5;
            this.label10.Text = "[ 예약완료 ]";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(59, 164);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(30, 32);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "a";
            // 
            // label_RevNum
            // 
            this.label_RevNum.AutoSize = true;
            this.label_RevNum.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RevNum.Location = new System.Drawing.Point(59, 206);
            this.label_RevNum.Name = "label_RevNum";
            this.label_RevNum.Size = new System.Drawing.Size(31, 32);
            this.label_RevNum.TabIndex = 3;
            this.label_RevNum.Text = "b";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(59, 248);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(29, 32);
            this.label_Price.TabIndex = 2;
            this.label_Price.Text = "c";
            // 
            // label_Deadline
            // 
            this.label_Deadline.AutoSize = true;
            this.label_Deadline.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Deadline.Location = new System.Drawing.Point(59, 374);
            this.label_Deadline.Name = "label_Deadline";
            this.label_Deadline.Size = new System.Drawing.Size(31, 32);
            this.label_Deadline.TabIndex = 0;
            this.label_Deadline.Text = "d";
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(211, 240);
            this.TB_Address.Multiline = true;
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(297, 39);
            this.TB_Address.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(182, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 56);
            this.label3.TabIndex = 67;
            this.label3.Text = "예약정보입력";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(140, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "주소";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(211, 344);
            this.TB_Email.Multiline = true;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(297, 39);
            this.TB_Email.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(130, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 63;
            this.label8.Text = "이메일";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(121, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 61;
            this.label7.Text = "전화번호";
            // 
            // TB_HP
            // 
            this.TB_HP.Location = new System.Drawing.Point(211, 294);
            this.TB_HP.Multiline = true;
            this.TB_HP.Name = "TB_HP";
            this.TB_HP.Size = new System.Drawing.Size(297, 35);
            this.TB_HP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(121, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "생년월일";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(211, 145);
            this.TB_NAME.Multiline = true;
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(297, 32);
            this.TB_NAME.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(140, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "이름";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "제출하기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BT_RevFormNext2);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(163, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 59);
            this.button4.TabIndex = 12;
            this.button4.Text = "이전";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BT_RevFormPrev2);
            // 
            // TB_Birth
            // 
            this.TB_Birth.Location = new System.Drawing.Point(211, 192);
            this.TB_Birth.Multiline = true;
            this.TB_Birth.Name = "TB_Birth";
            this.TB_Birth.Size = new System.Drawing.Size(297, 32);
            this.TB_Birth.TabIndex = 8;
            // 
            // TB_RoomSelect
            // 
            this.TB_RoomSelect.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RoomSelect.Location = new System.Drawing.Point(187, 153);
            this.TB_RoomSelect.Name = "TB_RoomSelect";
            this.TB_RoomSelect.Size = new System.Drawing.Size(255, 33);
            this.TB_RoomSelect.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(479, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "예약하기";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BT_RevFormNext);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(360, 458);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "이전";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BT_RevFormPrev1);
            // 
            // Date_Start
            // 
            this.Date_Start.CustomFormat = "";
            this.Date_Start.Location = new System.Drawing.Point(96, 106);
            this.Date_Start.Name = "Date_Start";
            this.Date_Start.Size = new System.Drawing.Size(200, 28);
            this.Date_Start.TabIndex = 1;
            this.Date_Start.ValueChanged += new System.EventHandler(this.Date_Start_ValueChanged);
            // 
            // Date_End
            // 
            this.Date_End.CustomFormat = "";
            this.Date_End.Location = new System.Drawing.Point(324, 106);
            this.Date_End.Name = "Date_End";
            this.Date_End.Size = new System.Drawing.Size(200, 28);
            this.Date_End.TabIndex = 2;
            this.Date_End.ValueChanged += new System.EventHandler(this.Date_End_ValueChanged);
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.A.Location = new System.Drawing.Point(181, 31);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(224, 56);
            this.A.TabIndex = 83;
            this.A.Text = "호텔유니온";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label_location.Location = new System.Drawing.Point(396, 31);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(51, 56);
            this.label_location.TabIndex = 84;
            this.label_location.Text = "s";
            // 
            // BT_RoomSelect
            // 
            this.BT_RoomSelect.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_RoomSelect.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_RoomSelect.Location = new System.Drawing.Point(504, 148);
            this.BT_RoomSelect.Name = "BT_RoomSelect";
            this.BT_RoomSelect.Size = new System.Drawing.Size(88, 42);
            this.BT_RoomSelect.TabIndex = 4;
            this.BT_RoomSelect.Text = "선택";
            this.BT_RoomSelect.UseVisualStyleBackColor = false;
            this.BT_RoomSelect.Click += new System.EventHandler(this.BT_RoomSelect_Click);
            // 
            // Room_info
            // 
            this.Room_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_info.Location = new System.Drawing.Point(36, 205);
            this.Room_info.Name = "Room_info";
            this.Room_info.RowHeadersWidth = 62;
            this.Room_info.RowTemplate.Height = 30;
            this.Room_info.Size = new System.Drawing.Size(556, 234);
            this.Room_info.TabIndex = 5;
            this.Room_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Room_info_CellContentClick);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(628, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TB_RoomSelect);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Room_info);
            this.Controls.Add(this.BT_RoomSelect);
            this.Controls.Add(this.Date_End);
            this.Controls.Add(this.Date_Start);
            this.Controls.Add(this.label_location);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "예약 페이지";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationForm_FormClosed);
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_HP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_RoomSelect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Deadline;
        private System.Windows.Forms.Label label_RevNum;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button BT_GotoHome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker Date_Start;
        private System.Windows.Forms.DateTimePicker Date_End;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Button BT_RoomSelect;
        private System.Windows.Forms.DataGridView Room_info;
        private System.Windows.Forms.TextBox TB_Birth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
    }
}