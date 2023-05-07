using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Nhom10
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        List<string> list_username = new List<string>();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txt_TK.Text = Properties.Settings.Default.username;
            txt_MK.Text = Properties.Settings.Default.password;
            if(Properties.Settings.Default.username != "" )
            {
                checkluuTT.Checked = true;
            }
          
        }

        private void txt_MK_TextChanged(object sender, EventArgs e) { }
        

        private void btn_DN_Click(object sender, EventArgs e)
        {
            conn.Open();
            string tk = txt_TK.Text;
            string mk = txt_MK.Text;
            string sql = "select TaiKhoan, MatKhau from  TAI_KHOAN where TaiKhoan = @tk and MatKhau = @mk";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.Add("@tk", tk);
            cmd.Parameters.Add("@mk", mk);
            SqlDataReader dta  =   cmd.ExecuteReader();
            if(dta.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                TrangChu trangchu = new TrangChu();
                trangchu.ShowDialog();
            } else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void cbx_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_hienthi.Checked)
            {
                txt_MK.PasswordChar = '\0';
            } else
            {
                txt_MK.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void link_Dki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            DangKi dangki  = new DangKi();
            dangki.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_TK_TextChanged(object sender, EventArgs e) { }
        
        private void checkluuTT_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_TK.Text != "" && txt_MK.Text != "")
            {
                if(checkluuTT.Checked)
                {
                    string taikhoan = txt_TK.Text;
                    string matkhau = txt_MK.Text;
                    Properties.Settings.Default.username = taikhoan;
                    Properties.Settings.Default.password = matkhau;
                    Properties.Settings.Default.Save();
                } else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }
       
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        
    }
}
