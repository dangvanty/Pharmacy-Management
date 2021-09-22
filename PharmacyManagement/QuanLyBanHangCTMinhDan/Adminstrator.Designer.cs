namespace QuanLyBanHangCTMinhDan
{
    partial class Adminstrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.Administrator_Load = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_profile1 = new QuanLyBanHangCTMinhDan.AdministratorUC.UC_profile();
            this.uC_ViewUser1 = new QuanLyBanHangCTMinhDan.AdministratorUC.UC_ViewUser();
            this.uC_addUser1 = new QuanLyBanHangCTMinhDan.AdministratorUC.UC_addUser();
            this.uC_ThongTin1 = new QuanLyBanHangCTMinhDan.AdministratorUC.UC_ThongTin();
            this.Administrator_Load.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Administrator_Load
            // 
            this.Administrator_Load.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Administrator_Load.Controls.Add(this.userNameLabel);
            this.Administrator_Load.Controls.Add(this.guna2Button5);
            this.Administrator_Load.Controls.Add(this.btnProfile);
            this.Administrator_Load.Controls.Add(this.btnViewUser);
            this.Administrator_Load.Controls.Add(this.btnAddUser);
            this.Administrator_Load.Controls.Add(this.btnThongTin);
            this.Administrator_Load.Controls.Add(this.label1);
            this.Administrator_Load.Controls.Add(this.pictureBox1);
            this.Administrator_Load.Location = new System.Drawing.Point(0, 0);
            this.Administrator_Load.Name = "Administrator_Load";
            this.Administrator_Load.Size = new System.Drawing.Size(275, 770);
            this.Administrator_Load.TabIndex = 0;
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
            // guna2Button5
            // 
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(28, 591);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(247, 45);
            this.guna2Button5.TabIndex = 2;
            this.guna2Button5.Text = "Đăng Xuất ";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.TextOffset = new System.Drawing.Point(20, 0);
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.CheckedState.Parent = this.btnProfile;
            this.btnProfile.CustomImages.Parent = this.btnProfile;
            this.btnProfile.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.Parent = this.btnProfile;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProfile.Location = new System.Drawing.Point(28, 519);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(247, 45);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Hồ Sơ";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.TextOffset = new System.Drawing.Point(20, 0);
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewUser.CheckedState.Parent = this.btnViewUser;
            this.btnViewUser.CustomImages.Parent = this.btnViewUser;
            this.btnViewUser.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.HoverState.Parent = this.btnViewUser;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewUser.Location = new System.Drawing.Point(28, 444);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.ShadowDecoration.Parent = this.btnViewUser;
            this.btnViewUser.Size = new System.Drawing.Size(247, 45);
            this.btnViewUser.TabIndex = 2;
            this.btnViewUser.Text = "Danh sách User";
            this.btnViewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewUser.TextOffset = new System.Drawing.Point(20, 0);
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddUser.Location = new System.Drawing.Point(28, 373);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(247, 45);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Thêm User";
            this.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.TextOffset = new System.Drawing.Point(20, 0);
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTin.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThongTin.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnThongTin.CheckedState.Parent = this.btnThongTin;
            this.btnThongTin.CustomImages.Parent = this.btnThongTin;
            this.btnThongTin.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnThongTin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.HoverState.Parent = this.btnThongTin;
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongTin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThongTin.Location = new System.Drawing.Point(28, 301);
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
            this.label1.Location = new System.Drawing.Point(41, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_profile1);
            this.panel2.Controls.Add(this.uC_ViewUser1);
            this.panel2.Controls.Add(this.uC_addUser1);
            this.panel2.Controls.Add(this.uC_ThongTin1);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 770);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uC_profile1
            // 
            this.uC_profile1.BackColor = System.Drawing.Color.White;
            this.uC_profile1.Location = new System.Drawing.Point(0, -1);
            this.uC_profile1.Name = "uC_profile1";
            this.uC_profile1.Size = new System.Drawing.Size(1103, 768);
            this.uC_profile1.TabIndex = 3;
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser1.Location = new System.Drawing.Point(-3, 0);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(1103, 768);
            this.uC_ViewUser1.TabIndex = 2;
            // 
            // uC_addUser1
            // 
            this.uC_addUser1.BackColor = System.Drawing.Color.White;
            this.uC_addUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_addUser1.Location = new System.Drawing.Point(-1, 0);
            this.uC_addUser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_addUser1.Name = "uC_addUser1";
            this.uC_addUser1.Size = new System.Drawing.Size(1103, 768);
            this.uC_addUser1.TabIndex = 1;
            // 
            // uC_ThongTin1
            // 
            this.uC_ThongTin1.BackColor = System.Drawing.Color.White;
            this.uC_ThongTin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_ThongTin1.Location = new System.Drawing.Point(-3, 0);
            this.uC_ThongTin1.Name = "uC_ThongTin1";
            this.uC_ThongTin1.Size = new System.Drawing.Size(1105, 770);
            this.uC_ThongTin1.TabIndex = 0;
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Administrator_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.Administrator_Load.ResumeLayout(false);
            this.Administrator_Load.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Administrator_Load;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdministratorUC.UC_ThongTin uC_ThongTin1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdministratorUC.UC_addUser uC_addUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdministratorUC.UC_ViewUser uC_ViewUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdministratorUC.UC_profile uC_profile1;
    }
}