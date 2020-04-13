namespace Nhóm_2
{
    partial class frmDonVi
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
            this.dgvDonVi = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboBP = new System.Windows.Forms.ComboBox();
            this.dtpNgayTL = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSuaLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonVi
            // 
            this.dgvDonVi.AllowUserToAddRows = false;
            this.dgvDonVi.AllowUserToDeleteRows = false;
            this.dgvDonVi.AllowUserToOrderColumns = true;
            this.dgvDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.NgayTL,
            this.MaBP});
            this.dgvDonVi.Location = new System.Drawing.Point(1, 337);
            this.dgvDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonVi.Name = "dgvDonVi";
            this.dgvDonVi.ReadOnly = true;
            this.dgvDonVi.RowHeadersWidth = 51;
            this.dgvDonVi.Size = new System.Drawing.Size(1068, 219);
            this.dgvDonVi.TabIndex = 13;
            this.dgvDonVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvDonVi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonVi_CellContentClick);
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã đơn vị";
            this.MaDV.MinimumWidth = 6;
            this.MaDV.Name = "MaDV";
            this.MaDV.ReadOnly = true;
            // 
            // TenDV
            // 
            this.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên đơn vị";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            // 
            // NgayTL
            // 
            this.NgayTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayTL.DataPropertyName = "NgayTL";
            this.NgayTL.HeaderText = "Ngày thành lập";
            this.NgayTL.MinimumWidth = 6;
            this.NgayTL.Name = "NgayTL";
            this.NgayTL.ReadOnly = true;
            // 
            // MaBP
            // 
            this.MaBP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBP.DataPropertyName = "MaBP";
            this.MaBP.HeaderText = "bộ phận";
            this.MaBP.MinimumWidth = 6;
            this.MaBP.Name = "MaBP";
            this.MaBP.ReadOnly = true;
            // 
            // cboBP
            // 
            this.cboBP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboBP.FormattingEnabled = true;
            this.cboBP.Location = new System.Drawing.Point(271, 103);
            this.cboBP.Margin = new System.Windows.Forms.Padding(4);
            this.cboBP.Name = "cboBP";
            this.cboBP.Size = new System.Drawing.Size(228, 24);
            this.cboBP.TabIndex = 45;
            this.cboBP.SelectedIndexChanged += new System.EventHandler(this.cboBP_SelectedIndexChanged);
            // 
            // dtpNgayTL
            // 
            this.dtpNgayTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayTL.CustomFormat = "";
            this.dtpNgayTL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTL.Location = new System.Drawing.Point(272, 241);
            this.dtpNgayTL.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTL.Name = "dtpNgayTL";
            this.dtpNgayTL.Size = new System.Drawing.Size(272, 22);
            this.dtpNgayTL.TabIndex = 44;
            this.dtpNgayTL.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(448, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "QUẢN LÝ ĐƠN VỊ";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(856, 204);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 41);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLuu.Location = new System.Drawing.Point(856, 154);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 41);
            this.btnLuu.TabIndex = 41;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoa.Location = new System.Drawing.Point(856, 105);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 41);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSuaLai
            // 
            this.btnSuaLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSuaLai.Location = new System.Drawing.Point(715, 204);
            this.btnSuaLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaLai.Name = "btnSuaLai";
            this.btnSuaLai.Size = new System.Drawing.Size(109, 41);
            this.btnSuaLai.TabIndex = 39;
            this.btnSuaLai.Text = "Tải lại";
            this.btnSuaLai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSua.Location = new System.Drawing.Point(715, 154);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 41);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThem.Location = new System.Drawing.Point(715, 106);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 41);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ngày Thành Lập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tên Đơn Vị";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã Đơn Vị";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Bộ phận";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDV.Location = new System.Drawing.Point(271, 188);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(228, 22);
            this.txtTenDV.TabIndex = 32;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Location = new System.Drawing.Point(271, 150);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(228, 22);
            this.txtMaDV.TabIndex = 31;
            // 
            // frmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cboBP);
            this.Controls.Add(this.dtpNgayTL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaLai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.dgvDonVi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonVi";
            this.Text = "DANH MỤC ĐƠN VỊ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBP;
        private System.Windows.Forms.ComboBox cboBP;
        private System.Windows.Forms.DateTimePicker dtpNgayTL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
    }
}

