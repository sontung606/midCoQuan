using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhóm_2
{
    public partial class frmDonVi : Form
    {
        bool trangthai;// false là thêm , true là sửa

        public frmDonVi()
        {
            InitializeComponent();
        }
        midCoQuanDataContext db = new midCoQuanDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cboBP.DataSource = db.BoPhans.OrderBy(p => p.TenBP);
            cboBP.DisplayMember = "TenBP";
            cboBP.ValueMember = "MaBP";
            cboBP.SelectedIndex = 0;
            string mabophan = cboBP.SelectedValue.ToString();
            LoadDSDV(mabophan);

        }
        private void cboBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mabophan = cboBP.SelectedValue.ToString();
            LoadDSDV(mabophan);
        }


        private void LoadDSDV(string mabophan)
        {
            if (trangthai == false)
            {
                dgvDonVi.DataSource = db.DonVis.Where(p => p.MaBP == mabophan)
                               .Select(p => new
                               {
                                   p.MaDV,
                                   p.TenDV,
                                   p.NgayTL,
                                   p.MaBP
                               }); ;
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrowclick = e.RowIndex;
            if (idrowclick >= 0)
            {
                string madv = dgvDonVi.Rows[idrowclick].Cells[0].Value.ToString();
                DonVi dv = db.DonVis.Where(p => p.MaDV == madv).SingleOrDefault();
                if (dv != null)
                {
                    txtMaDV.Text = dv.MaDV;
                    txtTenDV.Text = dv.TenDV;
                    dtpNgayTL.Value = dv.NgayTL;
                    cboBP.SelectedValue = dv.MaBP;
                }
            }
        }

        private void dgvDonVi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // nut sua 
        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = true;
            txtTenDV.Enabled = true;
            cboBP.Enabled = true;
            dtpNgayTL.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa dữ liệu này ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {   //hàm xóa
                string madv = txtMaDV.Text;

                DonVi dv = db.DonVis.Where(p => p.MaDV == madv).SingleOrDefault();
                if (dv != null)
                {
                    //co dv -> xoa dv
                    db.DonVis.DeleteOnSubmit(dv);
                    db.SubmitChanges();
                    //load lai data 
                    string mabophan = cboBP.SelectedValue.ToString();
                    LoadDSDV(mabophan);
                    //thông báo
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    // k co don vi
                    MessageBox.Show("Không tồn tại đơn vị", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaDV.Enabled = true;
            txtTenDV.Enabled = true;
            dtpNgayTL.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            trangthai = false;
            // Set textbox empty 
            txtMaDV.Text = "";
            txtTenDV.Text = "";

            dtpNgayTL.Value = DateTime.Now.Date;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DonVi dv = db.DonVis.Where(p => p.MaDV == txtMaDV.Text).SingleOrDefault();
                if (trangthai == false)// trạng thái thêm
                {
                    //// bắt lỗi tồn tại maDV
                    if (dv != null)
                    {
                        MessageBox.Show("Mã đơn vị đã tồn tại.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dv = new DonVi();
                    dv.MaDV = txtMaDV.Text;
                    dv.TenDV = txtTenDV.Text;
                    dv.NgayTL = dtpNgayTL.Value;
                    dv.MaBP = cboBP.SelectedValue.ToString();
                    // nhập dữ liệu vào database
                    if (validition(dv) == true)
                    {
                        db.DonVis.InsertOnSubmit(dv);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm vào thành công.");
                    }
                }

                if (trangthai == true) // trạng thái sửa
                {
                    dv.TenDV = txtTenDV.Text;
                    dv.NgayTL = dtpNgayTL.Value;
                    dv.MaBP = cboBP.SelectedValue.ToString();
                    if (validition(dv) == true)
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công.");
                        trangthai = false;
                    }
                }
                string mabophan = cboBP.SelectedValue.ToString();
                LoadDSDV(mabophan);
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                txtMaDV.Enabled = false;
                txtTenDV.Enabled = false;
                dtpNgayTL.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới thất bại.", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validition(DonVi dv) // bắt lỗi
        {
            // bắt lỗi maDV để trống
            if (dv.MaDV == "")
            {
                MessageBox.Show("Mã đơn vị không được để trống.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // bắt lỗi ngày thành lập 
            if (dv.NgayTL > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày thành lập không hợp lệ.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtMaDV.Enabled = false;
            txtTenDV.Enabled = false;
            dtpNgayTL.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaDV.Text = "";
            txtTenDV.Text = "";
            dtpNgayTL.Value = DateTime.Now.Date;
            trangthai = false;
        }
    }

}
