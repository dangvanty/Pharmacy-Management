using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangCTMinhDan
{
    public partial class Nhanvien : Form
    {
        String user = "";
        public Nhanvien()
        {
            InitializeComponent();
        }
        public Nhanvien( String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;

        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            uC_nv_ThongTin1.Visible = true;
            uC_nv_ThongTin1.BringToFront();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            uC_nv_ThongTin1.Visible = false;
            uC_nv_ThemHangHoa1.Visible = false;
            uC_nv_viewHangHoa1.Visible = false;
            uC_editHangHoa1.Visible = false;
            uC_nv_CheckGoods1.Visible = false;
            uC_nv_SellGoods1.Visible = false;
            btnThongTin.PerformClick(); // để đặt mặc đinh khi vào cửa sổ nhân viên
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            uC_nv_ThemHangHoa1.Visible = true;
            uC_nv_ThemHangHoa1.BringToFront();
        }

        private void btnViewGoods_Click(object sender, EventArgs e)
        {
            uC_nv_viewHangHoa1.Visible = true;
            uC_nv_viewHangHoa1.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            uC_editHangHoa1.Visible = true;
            uC_editHangHoa1.BringToFront();
        }

        private void btnCheckGoods_Click(object sender, EventArgs e)
        {
            uC_nv_CheckGoods1.Visible = true;
            uC_nv_CheckGoods1.BringToFront();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            uC_nv_SellGoods1.Visible = true;
            uC_nv_SellGoods1.BringToFront();
        }

        
    }
}
