using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class DangKi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public DangKi()
        {
            InitializeComponent();
        }
        private void DangKi_Load(object sender, EventArgs e)
        {
            conn.Open();
            pc_nhan.Visible = false;
            pc_tich.Visible = false;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            txt_MatKhau.PasswordChar = '*';
            if (txt_cfMk.Text == txt_MatKhau.Text)
            {
                pc_tich.Visible = true;
                pc_nhan.Visible = false;
            }
            else
            {
                pc_nhan.Visible = true;
                pc_tich.Visible = false;
            }

        }
        private void txt_cfMk_TextChanged(object sender, EventArgs e)
        {
            txt_cfMk.PasswordChar = '*';
            if (txt_cfMk.Text == txt_MatKhau.Text)
            {
                pc_tich.Visible = true;
                pc_nhan.Visible = false;
            }
            else
            {
                pc_nhan.Visible = true;
                pc_tich.Visible = false;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_DK_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.");
            }
            string tk = txt_TaiKhoan.Text;
            string mk = txt_MatKhau.Text;
            string email = txtEmail.Text;
            if (txt_MatKhau.Text == txt_cfMk.Text)
            {
                string sql = "INSERT INTO TAI_KHOAN (TaiKhoan, MatKhau, Email) VALUES (@TaiKhoan, @MatKhau, @Email)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TaiKhoan", tk);
                cmd.Parameters.AddWithValue("@MatKhau", mk);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
               DialogResult tb = MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                if (tb == DialogResult.OK)
                {
                    this.Hide();
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu", "Thông báo");
            }
        }

        private void pc_nhan_Click(object sender, EventArgs e) { }
     
        private void txt_cfMk_Click(object sender, EventArgs e) { }
   
        private void cbx_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_hienthi.Checked)
            {
                txt_MatKhau.PasswordChar = '\0';
                txt_cfMk.PasswordChar = '\0';
            } else
            {
                txt_MatKhau.PasswordChar = '*';
                txt_cfMk.PasswordChar = '*';
            }
        }
        private void DangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

    }
}
