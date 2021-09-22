using System;
using System.Windows.Forms;
using System.Data;

namespace QuanLyBanHangCTMinhDan.AdministratorUC
{
    public partial class UC_addUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_addUser()
        {
            InitializeComponent();
        }

       

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse( txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into users(userRole,name,dob,mobile,email,username,pass) values (N'"+role+ "',N'" +name+"','"+dob+"','"+mobile+"','"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Đăng ký thành công");

            }
            catch(Exception)
            {
                MessageBox.Show("Username đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex =-1;
            txtUsername.Clear();

        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select *from users where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"D:\Pharmacy-Mangment-System\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"D:\Pharmacy-Mangment-System\Pharmacy Management System in C#\no.png";
            }
        }
        private void UC_addUser_Load(object sender, EventArgs e)
        {



      
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
