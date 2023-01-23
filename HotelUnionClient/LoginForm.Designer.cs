
namespace HotelUnionClient
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.BT_Login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.IdCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(659, 185);
            this.TB_ID.Multiline = true;
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(293, 40);
            this.TB_ID.TabIndex = 0;
            this.TB_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_ID_KeyDown);
            // 
            // TB_PW
            // 
            this.TB_PW.Location = new System.Drawing.Point(659, 263);
            this.TB_PW.Multiline = true;
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.PasswordChar = '*';
            this.TB_PW.Size = new System.Drawing.Size(293, 38);
            this.TB_PW.TabIndex = 1;
            this.TB_PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_PW_KeyDown);
            // 
            // BT_Login
            // 
            this.BT_Login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Login.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.Location = new System.Drawing.Point(810, 409);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(141, 70);
            this.BT_Login.TabIndex = 4;
            this.BT_Login.Text = "로그인";
            this.BT_Login.UseVisualStyleBackColor = false;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 22);
            this.linkLabel1.TabIndex = 10;
            // 
            // IdCheck
            // 
            this.IdCheck.AutoSize = true;
            this.IdCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCheck.Location = new System.Drawing.Point(590, 341);
            this.IdCheck.Name = "IdCheck";
            this.IdCheck.Size = new System.Drawing.Size(141, 33);
            this.IdCheck.TabIndex = 2;
            this.IdCheck.Text = "아이디 저장\r\n";
            this.IdCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(659, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BT_NewM_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(329, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "<Copyright 2023. HotelUnion All Right Reserved>\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::HotelUnionClient.Properties.Resources.LogoSample_ByTailorBrands;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(552, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 113);
            this.panel3.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HotelUnionClient.Properties.Resources.hotel_union__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(50, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 445);
            this.panel1.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1007, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IdCheck);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.TB_PW);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인 페이지";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_PW;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox IdCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
    }
}

