using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace QuanLyBanHangCTMinhDan.NhanvienUC
{
    public partial class UC_nv_SellGoods : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_nv_SellGoods()
        {
            InitializeComponent();
        }

        private void UC_nv_SellGoods_Load(object sender, EventArgs e)
        {
            listBoxGoods.Items.Clear();

            query = "select HHname from HangHoa where eDate>= format(getDate(),'dd/MM/yyy') and quantity >'0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxGoods.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_nv_SellGoods_Load(this, null);
        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxGoods.Items.Clear();
            
            query="select HHname from HangHoa where HHname like '"+btnSearch.Text+ "%' and eDate>= format(getDate(),'dd/MM/yyy') and quantity >'0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxGoods.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void listBoxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPerUnit.Clear();
            String name = listBoxGoods.GetItemText(listBoxGoods.SelectedItem);
            txtTenHangHoa.Text = name;

            query = "select idHangHoa,eDate,perUnit from HangHoa where HHname=N'" + name + "'";
            ds = fn.getData(query);
            txtIDhanghoa.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExprireDay.Text= ds.Tables[0].Rows[0][1].ToString();
            txtPerUnit.Text= ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if(txtSL.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtSL.Text);
                Int64 totalAmount = unitPrice * noOfUnit;

                txtTotalPrice.Text = totalAmount.ToString();


            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        // xử lý btn add to card

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

      

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtIDhanghoa.Text != "")
            {
                query="select quantity from HangHoa where idHangHoa ='"+txtIDhanghoa.Text+"'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtSL.Text);

                if(newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtIDhanghoa.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtTenHangHoa.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExprireDay.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtSL.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;


                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    TotalLabel.Text = "Rs." + totalAmount.ToString();

                    query = "update HangHoa set quantity='" + newQuantity + "'where idHangHoa='" + txtIDhanghoa + "'";
                    fn.setData(query, "Thêm hàng hóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không đủ số lượng hàng hóa yêu cầu.\n Chỉ còn" + quantity + "đơn vị", "Lưu ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                UC_nv_SellGoods_Load(this, null);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn hàng hóa trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        // xử lý hóa đơn 
        int valueAmount;
        String valueId;
        protected Int64 noOfunit;



        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }

        }

        public void clearAll()
        {
            txtIDhanghoa.Clear();
            txtExprireDay.ResetText();
            txtPerUnit.Clear();
            txtSL.Clear();
            txtTenHangHoa.Clear();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueId !=null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);

                }
                catch
                {

                }
                finally
                {
                    query = "select quantity  from  HangHoa where idHangHoa ='" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "update HangHoa set quantity ='" + newQuantity + "' where idHangHoa='" + valueId + "'";
                    fn.setData(query, "Xóa hàng hóa khỏi giỏ hàng thành công!");
                    totalAmount = totalAmount - totalAmount;
                    TotalLabel.Text = "Rs." + totalAmount.ToString();
                }
                UC_nv_SellGoods_Load(this, null);
            }
        }

        // Xử lý thanh toán và in hóa đơn
        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Hóa đơn bán hàng Công ty Minh Dân";
            print.SubTitle = String.Format("Date:-{0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Tổng tiền: " + TotalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            TotalLabel.Text = "Rs. 00";
            guna2DataGridView1.DataSource = 0;

        }
    }
}
