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
    public partial class UC_nv_ThongTin : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;
        public UC_nv_ThongTin()
        {
            InitializeComponent();
        }

        

        private void UC_nv_ThongTin_Load(object sender, EventArgs e)
        {
            loadChart();
        }
        public void loadChart()
        {
            // set cột giá trị :hàng còn hạn
            query = "select count(HHname) from HangHoa where eDate>=format(getDate(),'dd/MM/yyy')";
            ds = fn.getData(query); 
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Còn hạn"].Points.AddXY("Biểu đồ hàng hóa",count);

            //set cột giá trị hàng hết hạn
            query = "select count(HHname) from HangHoa where eDate<=format(getDate(),'dd/MM/yyy')";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Hết hạn"].Points.AddXY("Biểu đồ hàng hóa", count);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Còn hạn"].Points.Clear();
            chart1.Series["Hết hạn"].Points.Clear();
            loadChart();
        }
    }
}
