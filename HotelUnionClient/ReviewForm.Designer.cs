
namespace HotelUnionClient
{
    partial class ReviewForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Review = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Review1 = new System.Windows.Forms.DataGridView();
            this.Review2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Prev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Prev2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_Review = new System.Windows.Forms.TextBox();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Review1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Review2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "작성 가능한 리뷰";
            // 
            // BT_Review
            // 
            this.BT_Review.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Review.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Review.Location = new System.Drawing.Point(424, 207);
            this.BT_Review.Name = "BT_Review";
            this.BT_Review.Size = new System.Drawing.Size(137, 48);
            this.BT_Review.TabIndex = 9;
            this.BT_Review.Text = "리뷰쓰기";
            this.BT_Review.UseVisualStyleBackColor = false;
            this.BT_Review.Click += new System.EventHandler(this.BT_Review_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "리뷰관리";
            // 
            // Review1
            // 
            this.Review1.AllowUserToAddRows = false;
            this.Review1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Review1.BackgroundColor = System.Drawing.Color.White;
            this.Review1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Review1.Location = new System.Drawing.Point(32, 111);
            this.Review1.Name = "Review1";
            this.Review1.RowHeadersWidth = 62;
            this.Review1.RowTemplate.Height = 30;
            this.Review1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Review1.Size = new System.Drawing.Size(529, 90);
            this.Review1.TabIndex = 14;
            // 
            // Review2
            // 
            this.Review2.AllowUserToAddRows = false;
            this.Review2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Review2.BackgroundColor = System.Drawing.Color.White;
            this.Review2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Review2.Location = new System.Drawing.Point(32, 276);
            this.Review2.Name = "Review2";
            this.Review2.RowHeadersWidth = 62;
            this.Review2.RowTemplate.Height = 30;
            this.Review2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Review2.Size = new System.Drawing.Size(529, 90);
            this.Review2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "작성한 리뷰";
            // 
            // BT_Prev
            // 
            this.BT_Prev.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Prev.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Prev.Location = new System.Drawing.Point(424, 372);
            this.BT_Prev.Name = "BT_Prev";
            this.BT_Prev.Size = new System.Drawing.Size(137, 48);
            this.BT_Prev.TabIndex = 15;
            this.BT_Prev.Text = "이전";
            this.BT_Prev.UseVisualStyleBackColor = false;
            this.BT_Prev.Click += new System.EventHandler(this.BT_Prev_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_Prev2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BT_Submit);
            this.panel1.Location = new System.Drawing.Point(4, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 373);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // BT_Prev2
            // 
            this.BT_Prev2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Prev2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Prev2.Location = new System.Drawing.Point(384, 329);
            this.BT_Prev2.Name = "BT_Prev2";
            this.BT_Prev2.Size = new System.Drawing.Size(90, 40);
            this.BT_Prev2.TabIndex = 4;
            this.BT_Prev2.Text = "이전";
            this.BT_Prev2.UseVisualStyleBackColor = false;
            this.BT_Prev2.Click += new System.EventHandler(this.BT_Prev2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TB_Review);
            this.panel2.Location = new System.Drawing.Point(16, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 309);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // TB_Review
            // 
            this.TB_Review.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Review.Font = new System.Drawing.Font("Arial", 12F);
            this.TB_Review.Location = new System.Drawing.Point(0, 0);
            this.TB_Review.Multiline = true;
            this.TB_Review.Name = "TB_Review";
            this.TB_Review.Size = new System.Drawing.Size(554, 309);
            this.TB_Review.TabIndex = 0;
            // 
            // BT_Submit
            // 
            this.BT_Submit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Submit.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Submit.Location = new System.Drawing.Point(480, 329);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(90, 40);
            this.BT_Submit.TabIndex = 2;
            this.BT_Submit.Text = "제출하기";
            this.BT_Submit.UseVisualStyleBackColor = false;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(120, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "<Copyright 2023. HotelUnion All Right Reserved>\r\n";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(588, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Review2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_Prev);
            this.Controls.Add(this.Review1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Review);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewForm_FormClosed);
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Review1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Review2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Review1;
        private System.Windows.Forms.DataGridView Review2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Prev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_Prev2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_Review;
        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.Label label11;
    }
}