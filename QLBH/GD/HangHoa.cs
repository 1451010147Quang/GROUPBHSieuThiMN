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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        eBUS da = new eBUS();
        private void Hanghoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.LoadHH();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Hanghoa h = new Hanghoa();
            h.MaSP = textBox1.Text;
            h.TenSP = textBox2.Text;
            h.Donvitinh = textBox3.Text;
            h.Dongia = textBox4.Text;
            h.MaLoaiSP = (textBox5.Text);
            da.ThemHH(h);
            dataGridView1.DataSource = da.LoadHH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hanghoa h = new Hanghoa();
            h.MaSP = textBox1.Text;
            h.TenSP = textBox2.Text;
            h.Donvitinh = textBox3.Text;
            h.Dongia = textBox4.Text;
            h.MaLoaiSP = (textBox5.Text);
            da.SuaHH(h);
            dataGridView1.DataSource = da.LoadHH();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hanghoa h = new Hanghoa();
            h.MaSP = textBox1.Text;
            da.XoaHH(h);
            dataGridView1.DataSource = da.LoadHH();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
