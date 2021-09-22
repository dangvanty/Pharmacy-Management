using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangCTMinhDan.AdministratorUC
{
    public partial class UC_profile : UserControl
    {
        function fn = new function();
        String query;
        public UC_profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { userNameLabel.Text = value; }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = userNameLabel.Text;
            String pass = txtPassword.Text;



            query = "update users set userRole= N'"+role+"',name=N'" + name + "',dob='" + dob + "',mobile='" + mobile + "',email='" + email + "',pass='" + pass + "' where username='" + username + "'";
            fn.setData(query, "Cập nhật hồ sơ thành công.");
        }
    
        private void UC_profile_Enter(object sender, EventArgs e)
        {
            query="select * from users where username='"+userNameLabel.Text+"'";
            DataSet ds = fn.getData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobileNo.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_profile_Enter(this, null);
        }
    }
}
