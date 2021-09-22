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
    public partial class UC_nv_ThemHangHoa : UserControl
    {
        function fn = new function();
        String query;

        public UC_nv_ThemHangHoa()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if( txtIDhanghoa.Text !="" && txtLoaiHangHoa.Text != "" && txtPriceOfUnit.Text !="" && txtSL.Text !="" && txtTenHangHoa.Text != "")
            {
                String idHangHoa = txtIDhanghoa.Text;
                String HHname = txtTenHangHoa.Text;
                String HHnumber = txtLoaiHangHoa.Text;
                String mDate = txtMdate.Text;
                String eDate = txtEdate.Text;
                Int64 quantity = Int64.Parse(txtSL.Text);
                Int64 perUnit = Int64.Parse(txtPriceOfUnit.Text);

                query = "insert into HangHoa(idHangHoa,HHname,HHnumber,mDate,eDate,quantity,perUnit) values( '"+idHangHoa+ "', N'"+HHname+ "',N'"+HHnumber+ "','"+mDate+ "','"+eDate+ "','"+quantity+ "','"+perUnit+"')";
                fn.setData(query, "Thêm dữ liệu hàng hóa thành công!");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtIDhanghoa.Clear();
            txtLoaiHangHoa.Clear();
            txtPriceOfUnit.Clear();
            txtSL.Clear();
            txtTenHangHoa.Clear();
            txtMdate.ResetText();
            txtEdate.ResetText();

        }

        
    }
}
