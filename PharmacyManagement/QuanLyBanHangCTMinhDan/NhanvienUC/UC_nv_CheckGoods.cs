using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangCTMinhDan.NhanvienUC
{
    public partial class UC_nv_CheckGoods : UserControl
    {
        function fn = new function();
        String query;

        public UC_nv_CheckGoods()
        {
            InitializeComponent();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex==0)
            {
                query = "select * from HangHoa where eDate< format(getDate(),'dd/MM/yyy')";
               DataSet ds= fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Danh sách hàng hóa hết hạn";
                setLabel.ForeColor = Color.Red;


            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from HangHoa where eDate>= format(getDate(),'dd/MM/yyy')";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Danh sách hàng hóa còn hạn sử dụng";
                setLabel.ForeColor = Color.MediumSeaGreen;
            }
            else if(txtCheck.SelectedIndex==2)
            {
                query = "select * from HangHoa ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Danh sách hàng hóa ";
                setLabel.ForeColor = Color.Black;
            }
        }

        private void UC_nv_CheckGoods_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }
    }
}
