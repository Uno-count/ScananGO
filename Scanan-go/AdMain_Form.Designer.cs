
namespace Scanan_go
{
    partial class AdMain_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdMain_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.headerLine = new System.Windows.Forms.Panel();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistered = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonitoring = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblHeaderTitle);
            this.panel1.Controls.Add(this.headerLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(271, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 143);
            this.panel1.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(551, 105);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(788, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMazimize_Click);
            this.btnMaximize.MouseHover += new System.EventHandler(this.btnMazimize_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Type";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(760, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(816, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 60);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(161, 32);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Header Title";
            // 
            // headerLine
            // 
            this.headerLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLine.BackColor = System.Drawing.Color.Silver;
            this.headerLine.Location = new System.Drawing.Point(24, 137);
            this.headerLine.Margin = new System.Windows.Forms.Padding(4);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(785, 1);
            this.headerLine.TabIndex = 0;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.White;
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(271, 143);
            this.PanelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(844, 449);
            this.PanelDesktop.TabIndex = 1;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(59)))));
            this.guna2GradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2GradientPanel1.BackgroundImage")));
            this.guna2GradientPanel1.Controls.Add(this.btnLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnAccSettings);
            this.guna2GradientPanel1.Controls.Add(this.btnRegistered);
            this.guna2GradientPanel1.Controls.Add(this.btnMonitoring);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(271, 592);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 6;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(16, 526);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(237, 52);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnAccSettings
            // 
            this.btnAccSettings.BorderRadius = 6;
            this.btnAccSettings.CheckedState.Parent = this.btnAccSettings;
            this.btnAccSettings.CustomImages.Parent = this.btnAccSettings;
            this.btnAccSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnAccSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAccSettings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAccSettings.HoverState.Parent = this.btnAccSettings;
            this.btnAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnAccSettings.Image")));
            this.btnAccSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccSettings.Location = new System.Drawing.Point(16, 358);
            this.btnAccSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccSettings.Name = "btnAccSettings";
            this.btnAccSettings.ShadowDecoration.Parent = this.btnAccSettings;
            this.btnAccSettings.Size = new System.Drawing.Size(237, 52);
            this.btnAccSettings.TabIndex = 8;
            this.btnAccSettings.Text = "Account Settings";
            this.btnAccSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccSettings.Click += new System.EventHandler(this.btnAccSettings_Click_1);
            // 
            // btnRegistered
            // 
            this.btnRegistered.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistered.BorderRadius = 6;
            this.btnRegistered.CheckedState.Parent = this.btnRegistered;
            this.btnRegistered.CustomImages.Parent = this.btnRegistered;
            this.btnRegistered.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegistered.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistered.HoverState.Parent = this.btnRegistered;
            this.btnRegistered.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistered.Image")));
            this.btnRegistered.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRegistered.Location = new System.Drawing.Point(16, 299);
            this.btnRegistered.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistered.Name = "btnRegistered";
            this.btnRegistered.ShadowDecoration.Parent = this.btnRegistered;
            this.btnRegistered.Size = new System.Drawing.Size(237, 52);
            this.btnRegistered.TabIndex = 7;
            this.btnRegistered.Text = "Registered";
            this.btnRegistered.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRegistered.Click += new System.EventHandler(this.btnRegistered_Click_1);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btnMonitoring.BorderRadius = 6;
            this.btnMonitoring.CheckedState.Parent = this.btnMonitoring;
            this.btnMonitoring.CustomImages.Parent = this.btnMonitoring;
            this.btnMonitoring.FillColor = System.Drawing.Color.Transparent;
            this.btnMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMonitoring.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMonitoring.HoverState.Parent = this.btnMonitoring;
            this.btnMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitoring.Image")));
            this.btnMonitoring.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonitoring.Location = new System.Drawing.Point(19, 240);
            this.btnMonitoring.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.ShadowDecoration.Parent = this.btnMonitoring;
            this.btnMonitoring.Size = new System.Drawing.Size(237, 52);
            this.btnMonitoring.TabIndex = 0;
            this.btnMonitoring.Text = "Monitoring";
            this.btnMonitoring.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitring_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdMain_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 592);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdMain_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdMain_Form";
            this.Load += new System.EventHandler(this.AdMain_Form_Load);
            this.SizeChanged += new System.EventHandler(this.AdMain_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headerLine;
        private System.Windows.Forms.Label lblHeaderTitle;
        public System.Windows.Forms.Panel PanelDesktop;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnAccSettings;
        private Guna.UI2.WinForms.Guna2Button btnRegistered;
        private Guna.UI2.WinForms.Guna2Button btnMonitoring;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}