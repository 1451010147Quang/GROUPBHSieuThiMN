using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BUS;
using DTO;
using System.Data.SqlClient;

namespace GD
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        eBUS da = new eBUS();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.LoadKH();
        }           



        private void Thêm_Click(object sender, EventArgs e)
        {
            Khachang a = new Khachang();
            a.MaKH = (textBox1.Text);
            a.TenKH = textBox2.Text;
            a.DiaChi = textBox3.Text;
            a.DienThoai = textBox4.Text;
            a.Fax = textBox5.Text;
            da.Them(a);
            dataGridView1.DataSource = da.LoadKH();
        }

        private void Sửa_Click(object sender, EventArgs e)
        {
            Khachang a = new Khachang();
            a.MaKH = (textBox1.Text);
            a.TenKH = textBox2.Text;
            a.DiaChi = textBox3.Text;
            a.DienThoai = textBox4.Text;
            a.Fax = textBox5.Text;
            da.Sua(a);
            dataGridView1.DataSource = da.LoadKH();
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            Khachang a = new Khachang();
            a.MaKH = (textBox1.Text);
            da.Xoap(a);
            dataGridView1.DataSource = da.LoadKH();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Khachang p = new Khachang();
            if (radioButton1.Checked == true)
            {
                p.MaKH = (textBox6.Text.Trim());
                dataGridView1.DataSource = da.TimKH(p);
            }
            else
            {
                p.TenKH = textBox6.Text ;
                dataGridView1.DataSource = da.TimaKH(p);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.LoadKH();
        }

       

            
        

        

      
        

       
    }
}
