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
    public partial class UC_nv_viewHangHoa : UserControl
    {
        function fn = new function();
        String query;
        public UC_nv_viewHangHoa()
        {
            InitializeComponent();
        }

        private void UC_nv_viewHangHoa_Load(object sender, EventArgs e)
        {
            query = "select * from HangHoa";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn ?", "Xác nhận xóa!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                    query = "delete from HangHoa where idHangHoa='" +idHangHoa+ "'";
                    fn.setData(query, "Bản ghi Hàng Hóa đã bị xóa.");
                    UC_nv_viewHangHoa_Load(this, null);
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query="select * from HangHoa where HHname like N'"+txtSearch+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String idHangHoa;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idHangHoa = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_nv_viewHangHoa_Load(this, null);
        }
    }
}
