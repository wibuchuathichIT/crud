using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-TC1J30JT\SQLEXPRESS02;Initial Catalog=QLCongTy;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable() ;

        void LoadData()
        {
            command = connection.CreateCommand();// khoi tao xu  ly ket noi
            command.CommandText = "select * from ThongtinNhanVien";//  cau truy van
            adapter.SelectCommand = command;// thuc thi cau truy van 
            table.Clear();// clear table
            adapter.Fill(table);// chuyen du lieu tu adater xg table
            dtgvThongTin.DataSource = table ;// hien thi du lieu
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
            connection.Close();
        }


        private void dtgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaNV.ReadOnly = true;
            int i;
            i = dtgvThongTin.CurrentRow.Index;
            txbMaNV.Text = dtgvThongTin.Rows[i].Cells[0].Value.ToString();
            txTenNV.Text = dtgvThongTin.Rows[i].Cells[1].Value.ToString();
            dtPNgaySinh.Text = dtgvThongTin.Rows[i].Cells[2].Value.ToString();
            cbGioiTinh.Text = dtgvThongTin.Rows[i].Cells[3].Value.ToString();
            txbChucVu.Text = dtgvThongTin.Rows[i].Cells[4].Value.ToString();
            TxbTienLuong.Text = dtgvThongTin.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(str)) // Sử dụng using để đóng kết nối tự động
            {
                connection.Open();

                string sql = "insert into thongtinnhanvien (MaNV, TenNV, NgaySinh, GioiTinh, ChucVu, TienLuong) values (@MaNV, @TenNV, @NgaySinh, @GioiTinh, @ChucVu, @TienLuong)";
                SqlCommand command = new SqlCommand(sql, connection);


                // Kiểm tra và hiển thị thông báo cho các ô trống
                if (string.IsNullOrEmpty(txbMaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã NV!");
                    return;
                }
                else
                {
                    command.Parameters.AddWithValue("@MaNV", txbMaNV.Text);
                }
                if (string.IsNullOrEmpty(txTenNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Tên NV!");
                    return;
                }
                else
                {
                    command.Parameters.AddWithValue("@TenNV", txTenNV.Text);
                }
                if (dtPNgaySinh.Value == null)
                {
                    MessageBox.Show("Vui lòng chọn Ngày Sinh!");
                    return;
                }
                else
                {
                    command.Parameters.AddWithValue("@NgaySinh", dtPNgaySinh.Value);
                }
                if (string.IsNullOrEmpty(cbGioiTinh.Text))
                {
                    MessageBox.Show("Vui lòng chọn Giới Tính!");
                    return;
                }
                else
                {
                    command.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                }
                if (string.IsNullOrEmpty(txbChucVu.Text))
                {
                    MessageBox.Show("Vui lòng nhập Chức Vụ!");
                    return;
                }
                else
                {
                    command.Parameters.AddWithValue("@ChucVu", txbChucVu.Text);
                }
                if (string.IsNullOrEmpty(TxbTienLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập Lương!");
                    return;
                }
                else
                {
                    command.Parameters.AddWithValue("@TienLuong", TxbTienLuong.Text);
                }


                int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        LoadData(); // Cập nhật dữ liệu trên DataGridView
                    }
               
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from thongtinnhanvien where manv like N'"+txbMaNV.Text +"' ";
            connection.Open();
            command.ExecuteNonQuery();
            LoadData();
            connection.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update thongtinnhanvien set TenNv = N'"+txTenNV.Text+ "',NgaySinh = N'"+dtPNgaySinh.Value+ "',GioiTinh = N'"+cbGioiTinh.Text+"',Chucvu = N'"+txbChucVu.Text+"',TienLuong = N'"+TxbTienLuong.Text+"'where manv = N'"+txbMaNV.Text+"' ";
            connection.Open();
            command.ExecuteNonQuery();
            LoadData();
            connection.Close();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txbMaNV.Text = "";
            txTenNV.Text = "";
            cbGioiTinh.Text = "";
            dtPNgaySinh.Text = "1/1/1999";
            txbChucVu.Text = "";
            TxbTienLuong.Text = " ";
        }
    }
}
