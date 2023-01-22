
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
            this.TB_Review = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BT_ReviewPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "작성 가능한 리뷰";
            // 
            // BT_Review
            // 
            this.BT_Review.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Review.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Review.Location = new System.Drawing.Point(425, 205);
            this.BT_Review.Name = "BT_Review";
            this.BT_Review.Size = new System.Drawing.Size(137, 48);
            this.BT_Review.TabIndex = 9;
            this.BT_Review.Text = "리뷰쓰기";
            this.BT_Review.UseVisualStyleBackColor = false;
            // 
            // TB_Review
            // 
            this.TB_Review.Location = new System.Drawing.Point(27, 109);
            this.TB_Review.Multiline = true;
            this.TB_Review.Name = "TB_Review";
            this.TB_Review.Size = new System.Drawing.Size(535, 90);
            this.TB_Review.TabIndex = 8;
            this.TB_Review.Text = "리뷰 쓰러가기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(218, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "리뷰관리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "작성한 리뷰";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(28, 281);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 30;
            this.DataGridView.Size = new System.Drawing.Size(529, 251);
            this.DataGridView.TabIndex = 12;
            // 
            // BT_ReviewPrev
            // 
            this.BT_ReviewPrev.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_ReviewPrev.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ReviewPrev.Location = new System.Drawing.Point(419, 542);
            this.BT_ReviewPrev.Name = "BT_ReviewPrev";
            this.BT_ReviewPrev.Size = new System.Drawing.Size(138, 41);
            this.BT_ReviewPrev.TabIndex = 13;
            this.BT_ReviewPrev.Text = "이전";
            this.BT_ReviewPrev.UseVisualStyleBackColor = false;
            this.BT_ReviewPrev.Click += new System.EventHandler(this.BT_ReviewPrev_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(588, 597);
            this.Controls.Add(this.BT_ReviewPrev);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Review);
            this.Controls.Add(this.TB_Review);
            this.Controls.Add(this.label1);
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Review;
        private System.Windows.Forms.TextBox TB_Review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BT_ReviewPrev;
    }
}