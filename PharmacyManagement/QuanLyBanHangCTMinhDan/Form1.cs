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
    public partial class Form1 : Form
    {
        // gọi class function

       function fn = new function();
       string query;
       DataSet ds;
        //---------------
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            query = "select *from users";
              ds = fn.getData(query);
             if (ds.Tables[0].Rows.Count == 0)
             {  
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    Adminstrator am = new Adminstrator();
                    am.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai Username hoặc Password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         else
         {
             query = "select *from users where username='" + txtUsername.Text + "'and pass='" + txtPassword.Text + "'";
             ds = fn.getData(query);
             if (ds.Tables[0].Rows.Count != 0)
             {
                 String role = ds.Tables[0].Rows[0][1].ToString();
                 if(role =="Quản lý")
                 {
                     Adminstrator admin = new Adminstrator(txtUsername.Text);
                     admin.Show();
                     this.Hide();
                 }
                 else if(role=="Nhân viên")
                 {
                     Nhanvien nv = new Nhanvien();
                     nv.Show();
                     this.Hide();
                 }
             }
                else
                {
                    MessageBox.Show("Sai Username hoặc Password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         }
             //test nhanvien
            
        }
    }
}
