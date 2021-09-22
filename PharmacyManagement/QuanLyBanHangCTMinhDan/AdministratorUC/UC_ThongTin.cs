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
    public partial class UC_ThongTin : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_ThongTin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void setlabel(DataSet ds,Label lbl)
        {
            if(ds.Tables[0].Rows.Count!=0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            else
            {
                lbl.Text = "0";

            }
        }

        private void UC_ThongTin_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole=N'Quản lý'";
            ds = fn.getData(query);
            setlabel(ds, AminLabel);

            query = "select count(userRole) from users where userRole=N'Nhân viên'";
            ds = fn.getData(query);
            setlabel(ds, NVlabel);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ThongTin_Load(this, null);
        }

       
    }
}
