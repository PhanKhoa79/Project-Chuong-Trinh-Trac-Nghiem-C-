using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class Formdethi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4O4HG3O2\\SQLEXPRESS;Initial Catalog=ThiTracNghiem;Integrated Security=True");
        public Formdethi()
        {
            InitializeComponent();
        }

        private void Formdethi_Load(object sender, EventArgs e)
        {
            loadMonThi();
            loadmucdo();
            if (comboBox_chuong.Text == "")
            {
                comboBox_chuong.Text = "Chọn Chương";
            }
        }
        private void load_dtagrv(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("hienthi_cauhoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();

        }
        private void loadMonThi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from MONTHI", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            DataRow r = dt.NewRow();
            r["IdMonThi"] = "";
            r["TenMonThi"] = "Chọn môn thi";
            dt.Rows.InsertAt(r, 0);
            comboBox_monthi.DataSource = dt;
            comboBox_monthi.DisplayMember = "TenMonThi";
            comboBox_monthi.ValueMember = "IdMonThi";
        }
        private void loadmucdo()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from MUCDO", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            DataRow r = dt.NewRow();
            r["IdMucDo"] = "";
            r["TenMucDo"] = "Chọn Mức Độ";
            dt.Rows.InsertAt(r, 0);
            comboBox_mucdo.DataSource = dt;
            comboBox_mucdo.DisplayMember = "TenMucDo";
            comboBox_mucdo.ValueMember = "IdMucDo";

        }

        private void dataGridView_cauhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_cauhoi.Rows.Count)
            {
                int i = e.RowIndex;
                textBox_maCauHoi.Text = dataGridView_cauhoi.Rows[i].Cells[0].Value.ToString();
                textBox_cauhoi.Text = dataGridView_cauhoi.Rows[i].Cells[1].Value.ToString();
                textBox_daA.Text = dataGridView_cauhoi.Rows[i].Cells[2].Value.ToString();
                textBox_daB.Text = dataGridView_cauhoi.Rows[i].Cells[3].Value.ToString();
                textBox_daC.Text = dataGridView_cauhoi.Rows[i].Cells[4].Value.ToString();
                textBox_daD.Text = dataGridView_cauhoi.Rows[i].Cells[5].Value.ToString();
                textBox_daDung.Text = dataGridView_cauhoi.Rows[i].Cells[6].Value.ToString();
                comboBox_mucdo.Text = dataGridView_cauhoi.Rows[i].Cells[8].Value.ToString();
                comboBox_chuong.Text = dataGridView_cauhoi.Rows[i].Cells[9].Value.ToString();
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int macauhoi = int.Parse(textBox_maCauHoi.Text);
            string cauhoi = textBox_cauhoi.Text;
            string dapana = textBox_daA.Text;
            string dapanb = textBox_daB.Text;
            string dapanc = textBox_daC.Text;
            string dapand = textBox_daD.Text;
            string dapandung = textBox_daDung.Text;
            string monthi = comboBox_monthi.SelectedValue.ToString();
            string mucdo = comboBox_mucdo.SelectedValue.ToString();
            string chuong = comboBox_chuong.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("up_cauhoi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdCauHoi", SqlDbType.Int).Value = macauhoi;
            cmd.Parameters.Add("@CauHoi", SqlDbType.NVarChar, 200).Value = cauhoi;
            cmd.Parameters.Add("@Dap_An_A", SqlDbType.NVarChar, 100).Value = dapana;
            cmd.Parameters.Add("@Dap_An_B", SqlDbType.NVarChar, 100).Value = dapanb;
            cmd.Parameters.Add("@Dap_An_C", SqlDbType.NVarChar, 100).Value = dapanc;
            cmd.Parameters.Add("@Dap_An_D", SqlDbType.NVarChar, 100).Value = dapand;
            cmd.Parameters.Add("@DapAnDung", SqlDbType.NVarChar, 100).Value = dapandung;
            cmd.Parameters.Add("IdMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd.Parameters.Add("@IdMucDo", SqlDbType.NVarChar, 20).Value = mucdo;
            cmd.Parameters.Add("IdChuong", SqlDbType.NVarChar, 20).Value = chuong;
            if (textBox_cauhoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung câu hỏi");
                textBox_cauhoi.Focus();
            }
            else
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                hienThiTheoMon();
                conn.Close();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
        }

        private void comboBox_chuong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string idchuong = comboBox_chuong.SelectedValue.ToString();
            string monthi = comboBox_monthi.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("hienthi_cauhoi_3", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chuong", idchuong);
            cmd.Parameters.AddWithValue("@monthi", monthi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            string nd_cauHoi = textBox_cauhoi.Text;
            string monthi = comboBox_monthi.SelectedValue.ToString();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("xoa_cauHoii", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cauhoi", SqlDbType.NVarChar, 200).Value = nd_cauHoi;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            hienThiTheoMon();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }
        private void hienThiTheoMon()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string chonMonThi = comboBox_monthi.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("hienthi_cauhoi_1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@monthi", chonMonThi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();
            conn.Close();
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (textBox_maCauHoi.Text != "")
            {
                textBox_maCauHoi.Text = "";
            }
            if (textBox_cauhoi.Text != "")
            {
                textBox_cauhoi.Text = "";
            }
            if (textBox_daA.Text != "")
            {
                textBox_daA.Text = "";
            }
            if (textBox_daC.Text != "")
            {
                textBox_daB.Text = "";
            }
            if (textBox_daC.Text != "")
            {
                textBox_daC.Text = "";
            }
            if (textBox_daD.Text != "")
            {
                textBox_daD.Text = "";
            }
            if (textBox_daDung.Text != "")
            {
                textBox_daDung.Text = "";
            }
            if (comboBox_chuong.Text != "")
            {
                comboBox_chuong.Text = "Chọn Chương";
            }
            if (comboBox_mucdo.Text != "")
            {
                comboBox_mucdo.Text = "Chọn Mức Độ";
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int macauhoi = int.Parse(textBox_maCauHoi.Text);
            string cauhoi = textBox_cauhoi.Text;
            string dapana = textBox_daA.Text;
            string dapanb = textBox_daB.Text;
            string dapanc = textBox_daC.Text;
            string dapand = textBox_daD.Text;
            string dapandung = textBox_daDung.Text;
            string monthi = comboBox_monthi.SelectedValue.ToString();
            string mucdo = comboBox_mucdo.SelectedValue.ToString();
            string chuong = comboBox_chuong.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("update_CauHoii", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdCauHoi", SqlDbType.Int).Value = macauhoi;
            cmd.Parameters.Add("@CauHoi", SqlDbType.NVarChar, 200).Value = cauhoi;
            cmd.Parameters.Add("@Dap_An_A", SqlDbType.NVarChar, 100).Value = dapana;
            cmd.Parameters.Add("@Dap_An_B", SqlDbType.NVarChar, 100).Value = dapanb;
            cmd.Parameters.Add("@Dap_An_C", SqlDbType.NVarChar, 100).Value = dapanc;
            cmd.Parameters.Add("@Dap_An_D", SqlDbType.NVarChar, 100).Value = dapand;
            cmd.Parameters.Add("@DapAnDung", SqlDbType.NVarChar, 100).Value = dapandung;
            cmd.Parameters.Add("IdMonThi", SqlDbType.NVarChar, 20).Value = monthi;
            cmd.Parameters.Add("@IdMucDo", SqlDbType.NVarChar, 20).Value = mucdo;
            cmd.Parameters.Add("IdChuong", SqlDbType.NVarChar, 20).Value = chuong;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            hienThiTheoMon();
            conn.Close();
            MessageBox.Show("Sửa thành công", "Thông báo");
        }
        private void comboBox_monthi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string chonMonThi = comboBox_monthi.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Chuong WHERE IdMonThi = @monthi", conn);
            cmd.Parameters.AddWithValue("@monthi", chonMonThi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r["IdChuong"] = "";
            r["TenChuong"] = "Chọn chương";
            comboBox_chuong.DataSource = dt;
            comboBox_chuong.DisplayMember = "TenChuong";
            comboBox_chuong.ValueMember = "IdChuong";
            if (comboBox_monthi.Text != "Chọn môn thi")
            {

                SqlCommand cmd2 = new SqlCommand("hienthi_cauhoi_1", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@monthi", chonMonThi);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cmd2.Dispose();
                dataGridView_cauhoi.DataSource = dt2;
                dataGridView_cauhoi.Refresh();
            }
            else
            {
                load_dtagrv(sender, e);
            }
            button_refresh_Click(sender, e);
            conn.Close();
        }

        private void button_timKiem_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string ndCauHoi = textBox_cauhoi.Text;
            SqlCommand cmd = new SqlCommand("timkiem_CauHoii", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cauhoi", SqlDbType.NVarChar, 200).Value = ndCauHoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            conn.Close();
            dataGridView_cauhoi.DataSource = dt;
            dataGridView_cauhoi.Refresh();
        }

       
       
    }
}
