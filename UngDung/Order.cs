﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        public string connect;
        public string username;
        List<string> rowsList;
        string masp;
        string tensp;
        string makh;


        private void sanpham_Load(object sender, EventArgs e)
        {
            lbl_username.Text = username;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            if (username == "sa")
            {
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
            }
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }

            string query_before = $@"EXEC LAY_MASP_TU_SP_SANPHAM";

            string connectionString = connect;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query_before, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Tạo một danh sách để lưu các hàng dưới dạng chuỗi
                rowsList = new List<string>();

                // Duyệt qua các hàng trong DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // Chuyển đổi mỗi hàng thành chuỗi và thêm vào danh sách
                    string rowString = string.Join(", ", row.ItemArray);
                    rowsList.Add(rowString);
                }

                //// Hiển thị kết quả
                //foreach (var row in rowsList)
                //{
                //    cbo_danhsach_table.Items.Add(row);
                //}

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            
            string giatien = txt_sanpham_giatien.Text;
            string trangthai = txt_sanpham_trangthai.Text;

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (masp == row)
                {
                    MessageBox.Show($"Đã tồn tại sản phẩm có mã: {masp}", "Thông báo");
        
        
                    txt_sanpham_giatien.Clear();
                    txt_sanpham_trangthai.Clear();
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "InsertSanPham @masp, @tensp, @giatien, @trangthai";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Truyền tham số cho thủ tục
                    
                    
                    cmd.Parameters.AddWithValue("@giatien", giatien);
                    cmd.Parameters.AddWithValue("@trangthai", trangthai);

                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi {ex}");
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }


            txt_sanpham_giatien.Clear();
            txt_sanpham_trangthai.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            
            string giatien = txt_sanpham_giatien.Text;
            string trangthai = txt_sanpham_trangthai.Text;

            if (masp.Length == 0)
            {
                MessageBox.Show($"cần mã sản phẩm để xóa", "Thông báo");
    
    
                txt_sanpham_giatien.Clear();
                txt_sanpham_trangthai.Clear();
                return;
            }

            //foreach (var row in rowsList)
            //{
            //    //cbo_danhsach_table.Items.Add(row);
            //    if (masp != row)
            //    {
            //        MessageBox.Show($"Không tồn tại sản phẩm có mã khớp với mã cần xóa: {masp}", "Thông báo");
            //        txt_sanpham_ma.Clear();
            //        txt_sanpham_ten.Clear();
            //        txt_sanpham_giatien.Clear();
            //        txt_sanpham_trangthai.Clear();
            //        return;
            //    }
            //}

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = $"DeleteSanPham @masp";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi {ex}");
                }
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }

            foreach (var row in rowsList)
            {
                //cbo_danhsach_table.Items.Add(row);
                if (masp == row)
                {
                    MessageBox.Show($"Đã xóa sản phẩm có mã: {masp}", "Thông báo");
                    rowsList.Remove(row);
        
        
                    txt_sanpham_giatien.Clear();
                    txt_sanpham_trangthai.Clear();
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            
            string giatien = txt_sanpham_giatien.Text;
            string trangthai = txt_sanpham_trangthai.Text;
            string masp_sua = txt_sanpham_sua.Text;

            //if (masp.Length == 0)
            //{
            //    MessageBox.Show($"cần mã sản phẩm để xóa", "Thông báo");
            //    txt_sanpham_ma.Clear();
            //    txt_sanpham_ten.Clear();
            //    txt_sanpham_giatien.Clear();
            //    txt_sanpham_trangthai.Clear();
            //    return;
            //}

            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC UpdateSanPham @masp_sua, @tensp, @giatien, @trangthai ;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        
                        cmd.Parameters.AddWithValue("@giatien", giatien);
                        cmd.Parameters.AddWithValue("@trangthai", trangthai);
                        cmd.Parameters.AddWithValue("@masp_sua", masp_sua);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception and possibly log it
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật sản phẩm. {ex}");
                    // Log the exception (not shown here)
                }
            }


            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            string connectionString = connect;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Quay lại Trang Chủ Home!");

                    //Logout(userid, connectionString);
                    //IsUserLoggedIn(userid, connectionString);


                    // Mở form chính hoặc thực hiện hành động khác sau khi đăng nhập thành công
                    Order order = this;
                    order.Hide();
                    Home homeForm = new Home();
                    homeForm.connect = connectionString;
                    homeForm.username = username;
                    homeForm.ShowDialog();
                    order.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi quay lại");
            }
        }

        private void btn_sanpham_tim_Click(object sender, EventArgs e)
        {
            
            
            string giatien = txt_sanpham_giatien.Text.Trim();
            string trangthai = txt_sanpham_trangthai.Text.Trim();
            

            //foreach (var row in rowsList)
            //{
            //    //cbo_danhsach_table.Items.Add(row);
            //    if (masp == row)
            //    {
            //        MessageBox.Show($"Đã tồn tại sản phẩm có mã: {masp}", "Thông báo");
            //        txt_sanpham_ma.Clear();
            //        txt_sanpham_ten.Clear();
            //        txt_sanpham_giatien.Clear();
            //        txt_sanpham_trangthai.Clear();
            //        return;
            //    }
            //}


            if (masp.Length == 0 && tensp.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = "SelectSanPhamByTen @tensp";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@tensp", tensp);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi {ex}");
                    }
                }

                //using (SqlConnection connection = new SqlConnection(connect))
                //{
                //    try
                //    {
                //        connection.Open();
                //        string query = "SELECT * FROM SANPHAM";
                //        SqlCommand command = new SqlCommand(query, connection);
                //        SqlDataAdapter adapter = new SqlDataAdapter(command);
                //        DataTable dataTable = new DataTable();
                //        adapter.Fill(dataTable);

                //        dataGridView1.DataSource = dataTable;
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                //    }
                //}
            }

            if (tensp.Length == 0 && masp.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = $"SelectSanPhamByMa @masp";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@masp", masp);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi {ex}");
                    }
                }

                //using (SqlConnection connection = new SqlConnection(connect))
                //{
                //    try
                //    {
                //        connection.Open();
                //        string query = "SELECT * FROM SANPHAM";
                //        SqlCommand command = new SqlCommand(query, connection);
                //        SqlDataAdapter adapter = new SqlDataAdapter(command);
                //        DataTable dataTable = new DataTable();
                //        adapter.Fill(dataTable);

                //        dataGridView1.DataSource = dataTable;
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                //    }
                //}
            }

            if (makh.Length != 0)
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = "SelectDonHangByMaKhach @makh";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@makh", makh);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi {ex}");
                    }
                }

                //using (SqlConnection connection = new SqlConnection(connect))
                //{
                //    try
                //    {
                //        connection.Open();
                //        string query = "SELECT * FROM SANPHAM";
                //        SqlCommand command = new SqlCommand(query, connection);
                //        SqlDataAdapter adapter = new SqlDataAdapter(command);
                //        DataTable dataTable = new DataTable();
                //        adapter.Fill(dataTable);

                //        dataGridView1.DataSource = dataTable;
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                //    }
                //}
            }




            txt_sanpham_giatien.Clear();
            txt_sanpham_trangthai.Clear();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "EXEC XEM_BANG_SANPHAM";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }
        }

        private void btn_mon_chuadathang_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    string query = "SelectSanPhamNotInChiTietDonHang";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: Bạn không có quyền hạn lấy dữ liệu");
                }
            }
        }
    }
}
