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
    }

}
