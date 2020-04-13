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
        public frmDonVi()
        {
            InitializeComponent();
            // lam nut nao bro ? :)) con bao nhieu 
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
            dgvDonVi.DataSource = db.DonVis.Where(p => p.MaBP == mabophan)
                .Select(p => new
                {
                    p.MaDV,
                    p.TenDV,
                    p.NgayTL,
                    p.MaBP
                }); ;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn xóa" + " ", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn thoát ", "Exit", MessageBoxButtons.YesNo);
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
            string madv = txtMaDV.Text;
            DonVi dv = db.DonVis.Where(p => p.MaDV == madv).SingleOrDefault();
            if (dv != null)
            {   // co nv ->sua
                dv.TenDV = txtTenDV.Text;
                dv.NgayTL = dtpNgayTL.Value;
                dv.MaBP = cboBP.SelectedValue.ToString();
                db.SubmitChanges();

                //load lai data
                MessageBox.Show("Sửa thành công.");
                string mabophan = cboBP.SelectedValue.ToString();
                LoadDSDV(mabophan);
                    
            }
            else
            {
                MessageBox.Show("Lỗi","Mã đơn vị không tồn tại.",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thông báo", "Bạn muốn xóa dữ liệu này ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if  (rs == DialogResult.Yes)
            {   //hàm xóa
                string madv = txtMaDV.Text;
                if ( madv  == "")
                {
                    DonVi dv = db.DonVis.Where(p => p.MaDV == madv).SingleOrDefault();
                    if ( dv != null)
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
        }
    }

}
