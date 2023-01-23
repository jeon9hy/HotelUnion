
namespace HotelUnionClient
{
    partial class ResvInfoForm
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
            this.BT_Refund = new System.Windows.Forms.Button();
            this.label_Top = new System.Windows.Forms.Label();
            this.Resv_info = new System.Windows.Forms.DataGridView();
            this.TB_RoomSelected = new System.Windows.Forms.TextBox();
            this.BT_RoomSelect = new System.Windows.Forms.Button();
            this.BT_Prev = new System.Windows.Forms.Button();
            this.BT_GoPolicy = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Resv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Refund
            // 
            this.BT_Refund.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Refund.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Refund.Location = new System.Drawing.Point(595, 310);
            this.BT_Refund.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT_Refund.Name = "BT_Refund";
            this.BT_Refund.Size = new System.Drawing.Size(110, 46);
            this.BT_Refund.TabIndex = 0;
            this.BT_Refund.Text = "예약취소";
            this.BT_Refund.UseVisualStyleBackColor = false;
            this.BT_Refund.Click += new System.EventHandler(this.BT_Refund_Click);
            // 
            // label_Top
            // 
            this.label_Top.AutoSize = true;
            this.label_Top.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Top.Location = new System.Drawing.Point(25, 25);
            this.label_Top.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(110, 35);
            this.label_Top.TabIndex = 1;
            this.label_Top.Text = "(인사말)";
            // 
            // Resv_info
            // 
            this.Resv_info.AllowUserToAddRows = false;
            this.Resv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Resv_info.BackgroundColor = System.Drawing.Color.White;
            this.Resv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resv_info.Location = new System.Drawing.Point(31, 121);
            this.Resv_info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Resv_info.Name = "Resv_info";
            this.Resv_info.RowHeadersWidth = 62;
            this.Resv_info.RowTemplate.Height = 30;
            this.Resv_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Resv_info.Size = new System.Drawing.Size(674, 171);
            this.Resv_info.TabIndex = 2;
            this.Resv_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Resv_info_CellContentClick);
            // 
            // TB_RoomSelected
            // 
            this.TB_RoomSelected.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RoomSelected.Location = new System.Drawing.Point(236, 73);
            this.TB_RoomSelected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_RoomSelected.Name = "TB_RoomSelected";
            this.TB_RoomSelected.Size = new System.Drawing.Size(263, 33);
            this.TB_RoomSelected.TabIndex = 7;
            // 
            // BT_RoomSelect
            // 
            this.BT_RoomSelect.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_RoomSelect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_RoomSelect.Location = new System.Drawing.Point(514, 73);
            this.BT_RoomSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT_RoomSelect.Name = "BT_RoomSelect";
            this.BT_RoomSelect.Size = new System.Drawing.Size(75, 33);
            this.BT_RoomSelect.TabIndex = 8;
            this.BT_RoomSelect.Text = "선택";
            this.BT_RoomSelect.UseVisualStyleBackColor = false;
            this.BT_RoomSelect.Click += new System.EventHandler(this.BT_RoomSelect_Click);
            // 
            // BT_Prev
            // 
            this.BT_Prev.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_Prev.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Prev.Location = new System.Drawing.Point(479, 310);
            this.BT_Prev.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT_Prev.Name = "BT_Prev";
            this.BT_Prev.Size = new System.Drawing.Size(110, 46);
            this.BT_Prev.TabIndex = 9;
            this.BT_Prev.Text = "이전";
            this.BT_Prev.UseVisualStyleBackColor = false;
            this.BT_Prev.Click += new System.EventHandler(this.BT_Prev_Click);
            // 
            // BT_GoPolicy
            // 
            this.BT_GoPolicy.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BT_GoPolicy.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GoPolicy.Location = new System.Drawing.Point(31, 310);
            this.BT_GoPolicy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BT_GoPolicy.Name = "BT_GoPolicy";
            this.BT_GoPolicy.Size = new System.Drawing.Size(110, 46);
            this.BT_GoPolicy.TabIndex = 10;
            this.BT_GoPolicy.Text = "환불규정";
            this.BT_GoPolicy.UseVisualStyleBackColor = false;
            this.BT_GoPolicy.Click += new System.EventHandler(this.BT_GoPolicy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(193, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "<Copyright 2023. HotelUnion All Right Reserved>\r\n";
            // 
            // ResvInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(735, 392);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BT_GoPolicy);
            this.Controls.Add(this.BT_Prev);
            this.Controls.Add(this.BT_RoomSelect);
            this.Controls.Add(this.TB_RoomSelected);
            this.Controls.Add(this.Resv_info);
            this.Controls.Add(this.label_Top);
            this.Controls.Add(this.BT_Refund);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ResvInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "예약관리";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResvInfoForm_FormClosed);
            this.Load += new System.EventHandler(this.ResvInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Resv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Refund;
        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.DataGridView Resv_info;
        private System.Windows.Forms.TextBox TB_RoomSelected;
        private System.Windows.Forms.Button BT_RoomSelect;
        private System.Windows.Forms.Button BT_Prev;
        private System.Windows.Forms.Button BT_GoPolicy;
        private System.Windows.Forms.Label label11;
    }
}