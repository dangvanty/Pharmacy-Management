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
    public partial class Adminstrator : Form
    {
        String user = "";
        public Adminstrator()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }
        public Adminstrator(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
            uC_profile1.ID = ID;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            uC_ThongTin1.Visible = true;
            uC_ThongTin1.BringToFront();

        }

       

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_ThongTin1.Visible = false;
            uC_addUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_profile1.Visible = false;
            btnThongTin.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_addUser1.Visible = true;
            uC_addUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_profile1.Visible = true;
            uC_profile1.BringToFront();
        }

        
    }
}
