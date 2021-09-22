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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";

        public UC_ViewUser()
        {
            InitializeComponent();
        }
        // edit cho btn delete begin
        public string ID
        {
            set { currentUser = value; }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn ?", "Xác nhận xóa!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                if (currentUser != userName)
                {
                    query = "delete from users where username='" + userName + "'";
                    fn.setData(query, "Bản ghi User đã bị xóa.");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn đang cố ý \n muốn xóa tài khoản hiện tại", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //end -> ở bên administrator nữa 
        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select*from users";
            DataSet ds= fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query="select*from users where username like '"+txtUsername.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
        String userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }
                
    }
}
