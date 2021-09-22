namespace QuanLyBanHangCTMinhDan
{
    partial class Nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.Administrator_Load = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckGoods = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewGoods = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddGoods = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSell = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_nv_SellGoods1 = new QuanLyBanHangCTMinhDan.NhanvienUC.UC_nv_SellGoods();
            this.uC_nv_CheckGoods1 = new QuanLyBanHangCTMinhDan.NhanvienUC.UC_nv_CheckGoods();
            this.uC_editHangHoa1 = new QuanLyBanHangCTMinhDan.NhanvienUC.UC_editHangHoa();
            this.uC_nv_viewHangHoa1 = new QuanLyBanHangCTMinhDan.NhanvienUC.UC_nv_viewHangHoa();
            this.uC_nv_ThemHangHoa1 = new QuanLyBanHangCTMinhDan.NhanvienUC.UC_nv_ThemHangHoa();
            this.uC_nv_ThongTin1 = new QuanLyBanHangCTMinhDan.NhanvienUC.UC_nv_ThongTin();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Administrator_Load.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Administrator_Load
            // 
            this.Administrator_Load.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Administrator_Load.Controls.Add(this.btnSell);
            this.Administrator_Load.Controls.Add(this.userNameLabel);
            this.Administrator_Load.Controls.Add(this.btnSignOut);
            this.Administrator_Load.Controls.Add(this.btnCheckGoods);
            this.Administrator_Load.Controls.Add(this.btnEdit);
            this.Administrator_Load.Controls.Add(this.btnViewGoods);
            this.Administrator_Load.Controls.Add(this.btnAddGoods);
            this.Administrator_Load.Controls.Add(this.btnThongTin);
            this.Administrator_Load.Controls.Add(this.label1);
            this.Administrator_Load.Controls.Add(this.pictureBox1);
            this.Administrator_Load.Location = new System.Drawing.Point(0, 0);
            this.Administrator_Load.Name = "Administrator_Load";
            this.Administrator_Load.Size = new System.Drawing.Size(275, 780);
            this.Administrator_Load.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.userNameLabel.Location = new System.Drawing.Point(0, 673);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(272, 43);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Admin";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSignOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSignOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.btnSignOut.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignOut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSignOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignOut.Location = new System.Drawing.Point(28, 601);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(247, 45);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Đăng Xuất";
            this.btnSignOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSignOut.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnCheckGoods
            // 
            this.btnCheckGoods.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckGoods.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckGoods.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckGoods.CheckedState.Parent = this.btnCheckGoods;
            this.btnCheckGoods.CustomImages.Parent = this.btnCheckGoods;
            this.btnCheckGoods.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCheckGoods.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckGoods.ForeColor = System.Drawing.Color.White;
            this.btnCheckGoods.HoverState.Parent = this.btnCheckGoods;
            this.btnCheckGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckGoods.Image")));
            this.btnCheckGoods.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckGoods.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckGoods.Location = new System.Drawing.Point(28, 480);
            this.btnCheckGoods.Name = "btnCheckGoods";
            this.btnCheckGoods.ShadowDecoration.Parent = this.btnCheckGoods;
            this.btnCheckGoods.Size = new System.Drawing.Size(247, 45);
            this.btnCheckGoods.TabIndex = 2;
            this.btnCheckGoods.Text = "Kiểm tra hàng hóa";
            this.btnCheckGoods.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckGoods.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCheckGoods.Click += new System.EventHandler(this.btnCheckGoods_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEdit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEdit.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(28, 429);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(247, 45);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.TextOffset = new System.Drawing.Point(20, 0);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnViewGoods
            // 
            this.btnViewGoods.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewGoods.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewGoods.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewGoods.CheckedState.Parent = this.btnViewGoods;
            this.btnViewGoods.CustomImages.Parent = this.btnViewGoods;
            this.btnViewGoods.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnViewGoods.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnViewGoods.ForeColor = System.Drawing.Color.White;
            this.btnViewGoods.HoverState.Parent = this.btnViewGoods;
            this.btnViewGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnViewGoods.Image")));
            this.btnViewGoods.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewGoods.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewGoods.Location = new System.Drawing.Point(28, 378);
            this.btnViewGoods.Name = "btnViewGoods";
            this.btnViewGoods.ShadowDecoration.Parent = this.btnViewGoods;
            this.btnViewGoods.Size = new System.Drawing.Size(247, 45);
            this.btnViewGoods.TabIndex = 2;
            this.btnViewGoods.Text = "Danh sách hàng hóa";
            this.btnViewGoods.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewGoods.TextOffset = new System.Drawing.Point(20, 0);
            this.btnViewGoods.Click += new System.EventHandler(this.btnViewGoods_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddGoods.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddGoods.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddGoods.CheckedState.Parent = this.btnAddGoods;
            this.btnAddGoods.CustomImages.Parent = this.btnAddGoods;
            this.btnAddGoods.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddGoods.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddGoods.ForeColor = System.Drawing.Color.White;
            this.btnAddGoods.HoverState.Parent = this.btnAddGoods;
            this.btnAddGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGoods.Image")));
            this.btnAddGoods.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddGoods.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddGoods.Location = new System.Drawing.Point(28, 327);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.ShadowDecoration.Parent = this.btnAddGoods;
            this.btnAddGoods.Size = new System.Drawing.Size(247, 45);
            this.btnAddGoods.TabIndex = 2;
            this.btnAddGoods.Text = "Thêm hàng hóa";
            this.btnAddGoods.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddGoods.TextOffset = new System.Drawing.Point(20, 0);
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTin.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThongTin.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnThongTin.CheckedState.Parent = this.btnThongTin;
            this.btnThongTin.CustomImages.Parent = this.btnThongTin;
            this.btnThongTin.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThongTin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.HoverState.Parent = this.btnThongTin;
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongTin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThongTin.Location = new System.Drawing.Point(28, 276);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.ShadowDecoration.Parent = this.btnThongTin;
            this.btnThongTin.Size = new System.Drawing.Size(247, 45);
            this.btnThongTin.TabIndex = 2;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongTin.TextOffset = new System.Drawing.Point(20, 0);
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSell
            // 
            this.btnSell.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSell.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSell.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSell.CheckedState.Parent = this.btnSell;
            this.btnSell.CustomImages.Parent = this.btnSell;
            this.btnSell.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSell.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.HoverState.Parent = this.btnSell;
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSell.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSell.Location = new System.Drawing.Point(28, 540);
            this.btnSell.Name = "btnSell";
            this.btnSell.ShadowDecoration.Parent = this.btnSell;
            this.btnSell.Size = new System.Drawing.Size(244, 45);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "Bán hàng";
            this.btnSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSell.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_nv_SellGoods1);
            this.panel1.Controls.Add(this.uC_nv_CheckGoods1);
            this.panel1.Controls.Add(this.uC_editHangHoa1);
            this.panel1.Controls.Add(this.uC_nv_viewHangHoa1);
            this.panel1.Controls.Add(this.uC_nv_ThemHangHoa1);
            this.panel1.Controls.Add(this.uC_nv_ThongTin1);
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 780);
            this.panel1.TabIndex = 2;
            // 
            // uC_nv_SellGoods1
            // 
            this.uC_nv_SellGoods1.BackColor = System.Drawing.Color.White;
            this.uC_nv_SellGoods1.Location = new System.Drawing.Point(0, 3);
            this.uC_nv_SellGoods1.Name = "uC_nv_SellGoods1";
            this.uC_nv_SellGoods1.Size = new System.Drawing.Size(1098, 780);
            this.uC_nv_SellGoods1.TabIndex = 5;
            // 
            // uC_nv_CheckGoods1
            // 
            this.uC_nv_CheckGoods1.BackColor = System.Drawing.Color.White;
            this.uC_nv_CheckGoods1.Location = new System.Drawing.Point(0, -3);
            this.uC_nv_CheckGoods1.Name = "uC_nv_CheckGoods1";
            this.uC_nv_CheckGoods1.Size = new System.Drawing.Size(1098, 780);
            this.uC_nv_CheckGoods1.TabIndex = 4;
            // 
            // uC_editHangHoa1
            // 
            this.uC_editHangHoa1.BackColor = System.Drawing.Color.White;
            this.uC_editHangHoa1.Location = new System.Drawing.Point(0, -3);
            this.uC_editHangHoa1.Name = "uC_editHangHoa1";
            this.uC_editHangHoa1.Size = new System.Drawing.Size(1098, 780);
            this.uC_editHangHoa1.TabIndex = 3;
            // 
            // uC_nv_viewHangHoa1
            // 
            this.uC_nv_viewHangHoa1.BackColor = System.Drawing.Color.White;
            this.uC_nv_viewHangHoa1.Location = new System.Drawing.Point(0, 0);
            this.uC_nv_viewHangHoa1.Name = "uC_nv_viewHangHoa1";
            this.uC_nv_viewHangHoa1.Size = new System.Drawing.Size(1098, 780);
            this.uC_nv_viewHangHoa1.TabIndex = 2;
            // 
            // uC_nv_ThemHangHoa1
            // 
            this.uC_nv_ThemHangHoa1.BackColor = System.Drawing.Color.White;
            this.uC_nv_ThemHangHoa1.Location = new System.Drawing.Point(0, 0);
            this.uC_nv_ThemHangHoa1.Name = "uC_nv_ThemHangHoa1";
            this.uC_nv_ThemHangHoa1.Size = new System.Drawing.Size(1098, 780);
            this.uC_nv_ThemHangHoa1.TabIndex = 1;
            // 
            // uC_nv_ThongTin1
            // 
            this.uC_nv_ThongTin1.BackColor = System.Drawing.Color.White;
            this.uC_nv_ThongTin1.Location = new System.Drawing.Point(-3, -3);
            this.uC_nv_ThongTin1.Name = "uC_nv_ThongTin1";
            this.uC_nv_ThongTin1.Size = new System.Drawing.Size(1098, 780);
            this.uC_nv_ThongTin1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel1;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel1;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel1;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Administrator_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.Administrator_Load.ResumeLayout(false);
            this.Administrator_Load.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Administrator_Load;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnViewGoods;
        private Guna.UI2.WinForms.Guna2Button btnAddGoods;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCheckGoods;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private NhanvienUC.UC_nv_ThongTin uC_nv_ThongTin1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private NhanvienUC.UC_nv_ThemHangHoa uC_nv_ThemHangHoa1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private NhanvienUC.UC_nv_viewHangHoa uC_nv_viewHangHoa1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private NhanvienUC.UC_editHangHoa uC_editHangHoa1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private NhanvienUC.UC_nv_CheckGoods uC_nv_CheckGoods1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private NhanvienUC.UC_nv_SellGoods uC_nv_SellGoods1;
        private Guna.UI2.WinForms.Guna2Button btnSell;
    }
}