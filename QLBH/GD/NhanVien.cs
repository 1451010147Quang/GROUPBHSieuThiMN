using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


using DTO;
using BUS;
namespace GD
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        eBUS da = new eBUS();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.LoadNV();
        }

        

    
        private void button1_Click(object sender, EventArgs e)
        {
            NVien a = new NVien();
            a.MaNV = (textBox1.Text);
            a.HoNV = textBox2.Text;
            a.Ten = textBox3.Text;
            a.DiaChi = textBox4.Text;
            a.DienThoai = textBox5.Text;
            da.ThemNV(a);
            dataGridView1.DataSource = da.LoadNV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NVien a = new NVien();
            a.MaNV = (textBox1.Text);
            a.HoNV = textBox2.Text;
            a.Ten = textBox3.Text;
            a.DiaChi = textBox4.Text;
            a.DienThoai = textBox5.Text;
            da.SuaNV(a);
            dataGridView1.DataSource = da.LoadNV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NVien a = new NVien();
            a.MaNV = (textBox1.Text);
            da.XoaNV(a);
            dataGridView1.DataSource = da.LoadNV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NVien n = new NVien();
            if (radioButton2.Checked == true)
            {
                n.Ten =textBox6.Text;
                dataGridView1.DataSource = da.TimtheotenNV(n);
            }
            else
            {
                n.MaNV = (textBox6.Text.Trim());
                dataGridView1.DataSource = da.TimNV(n);      
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.LoadNV();
        }


    }
}
