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
    public partial class UC_editHangHoa : UserControl
    {
        function fn = new function();
        String query;
        public UC_editHangHoa()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if(txtIDhanghoa.Text!="")
            {
                query = "select *from HangHoa where idHangHoa='" + txtIDhanghoa.Text + "'";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtTenHangHoa.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtLoaiHangHoa.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMdate.Text= ds.Tables[0].Rows[0][4].ToString();
                    txtEdate.Text= ds.Tables[0].Rows[0][5].ToString();
                    txtSL.Text= ds.Tables[0].Rows[0][6].ToString();
                    txtPriceOfUnit.Text= ds.Tables[0].Rows[0][7].ToString();

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trùng với ID " + txtIDhanghoa.Text, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtIDhanghoa.Clear();
            txtLoaiHangHoa.Clear();
            txtPriceOfUnit.Clear();
            txtSL.Clear();
            txtTenHangHoa.Clear();
            txtMdate.ResetText();
            txtEdate.ResetText();
            txtAddSL.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String idHangHoa = txtIDhanghoa.Text;
            String HHname = txtTenHangHoa.Text;
            String HHnumber = txtLoaiHangHoa.Text;
            String mDate = txtMdate.Text;
            String eDate = txtEdate.Text;
            Int64 quantity = Int64.Parse(txtSL.Text);
            Int64 addQuantity = Int64.Parse(txtAddSL.Text);
            Int64 perUnit = Int64.Parse(txtPriceOfUnit.Text);

            totalQuantity = quantity + addQuantity;

            //idHangHoa,HHname,HHnumber,mDate,eDate,quantity,perUnit
            query = "update HangHoa set HHname =N'" + HHname + "',HHnumber=N'" + HHnumber + "',mDate='" + mDate + "',eDate='" + eDate + "',quantity='" + totalQuantity + "',perUnit='" + perUnit + "' where idHangHoa='"+txtIDhanghoa.Text+"'";
            fn.setData(query, "Dữ liệu hàng hóa được cập nhật");
        }
    }
}
