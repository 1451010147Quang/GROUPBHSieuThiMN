using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GD
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (this.textBox1.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Username", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBox2.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (textBox1.Text == "aceit" && textBox2.Text == "9999")
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormMain form2 = new FormMain();
                form2.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("Tên Đăng Nhập không Đúng,Vui Lòng Kiểm Tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult thoat = new DialogResult();
            thoat = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
