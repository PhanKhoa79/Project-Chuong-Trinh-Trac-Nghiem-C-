using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }
        private Form cchildForm;
        private void openForm(Form childForm)
        {
            if (cchildForm != null)
            {
                cchildForm.Close();
            }
            cchildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_baiThi_Click(object sender, EventArgs e)
        {
            openForm(new fBaiThi());
            label1.Text = "Bài Thi";
        }

        private void button_ttTK_Click(object sender, EventArgs e)
        {
            openForm(new fThongTinTaiKhoan());
            label1.Text = "Thông Tin Tài Khoản";
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void fSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
