using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DTO;
using BUS;

namespace GD
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        eBUS da = new eBUS();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.LoadHD();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hoadon d = new Hoadon();
            d.MaHD = textBox1.Text;
            d.MaKH = textBox2.Text;
            d.MaNV = (textBox3.Text);
            d.NgayLapHD = dateTimePicker1.Value;
            da.ThemHD(d);
            dataGridView1.DataSource = da.LoadHD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hoadon d = new Hoadon();
            d.MaHD = textBox1.Text;
            d.MaKH = textBox2.Text;
            d.MaNV = (textBox3.Text);
            d.NgayLapHD = dateTimePicker1.Value;
            da.SuaHD(d);
            dataGridView1.DataSource = da.LoadHD();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hoadon d = new Hoadon();
            d.MaHD = textBox1.Text;
            da.XoaHD(d);
            dataGridView1.DataSource = da.LoadHD();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
