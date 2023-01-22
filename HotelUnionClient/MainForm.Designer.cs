
using System.Drawing;

namespace HotelUnionClient
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BT_MyPage_Review = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BT_MyPage_Perinfo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(961, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "공지사항";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "계묘년! 새해 복 많이 받으시고 좋은 일만 가득하길 바랍니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "호텔 유니온은 고객님께 최상의 기능을 제공하기위하여 항상 노력중입니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "호텔 유니온에 오신 여러분 환영합니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 70);
            this.label1.TabIndex = 16;
            this.label1.Text = "[ HotelUnion ]";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HotelUnionClient.Properties.Resources.dami;
            this.panel1.Location = new System.Drawing.Point(26, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 243);
            this.panel1.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(637, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(297, 386);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(961, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "예약관리";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(94, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 43);
            this.label6.TabIndex = 17;
            this.label6.Text = "HotelUnion, Seoul";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(544, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 35);
            this.label8.TabIndex = 19;
            this.label8.Text = "HotelUnion, Jeju";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(590, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "HotelUnion, Busan";
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::HotelUnionClient.Properties.Resources.Jeju;
            this.button9.Location = new System.Drawing.Point(489, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(357, 244);
            this.button9.TabIndex = 1;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BT_Jeju);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::HotelUnionClient.Properties.Resources.Busan;
            this.button8.Location = new System.Drawing.Point(531, 298);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(396, 201);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BT_Busan);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::HotelUnionClient.Properties.Resources.Seoul;
            this.button5.Location = new System.Drawing.Point(54, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(389, 405);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BT_Seoul);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MintCream;
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.BT_MyPage_Review);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.BT_MyPage_Perinfo);
            this.tabPage3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(961, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "마이페이지";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(414, 457);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 40);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "로그아웃";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_link);
            // 
            // BT_MyPage_Review
            // 
            this.BT_MyPage_Review.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_MyPage_Review.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MyPage_Review.Location = new System.Drawing.Point(317, 275);
            this.BT_MyPage_Review.Name = "BT_MyPage_Review";
            this.BT_MyPage_Review.Size = new System.Drawing.Size(343, 134);
            this.BT_MyPage_Review.TabIndex = 2;
            this.BT_MyPage_Review.Text = "리뷰관리";
            this.BT_MyPage_Review.UseVisualStyleBackColor = false;
            this.BT_MyPage_Review.Click += new System.EventHandler(this.BT_MyPage_Review_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(516, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 134);
            this.button2.TabIndex = 1;
            this.button2.Text = "예약정보확인";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BT_MyPage_Perinfo
            // 
            this.BT_MyPage_Perinfo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_MyPage_Perinfo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MyPage_Perinfo.Location = new System.Drawing.Point(101, 87);
            this.BT_MyPage_Perinfo.Name = "BT_MyPage_Perinfo";
            this.BT_MyPage_Perinfo.Size = new System.Drawing.Size(343, 134);
            this.BT_MyPage_Perinfo.TabIndex = 0;
            this.BT_MyPage_Perinfo.Text = "개인정보 변경";
            this.BT_MyPage_Perinfo.UseVisualStyleBackColor = false;
            this.BT_MyPage_Perinfo.Click += new System.EventHandler(this.BT_MyPage_Perinfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인 페이지";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BT_MyPage_Review;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT_MyPage_Perinfo;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}