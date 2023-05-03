
namespace Scanan_go
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.slideLoginPanel = new System.Windows.Forms.Panel();
            this.slideRegisterPanel = new System.Windows.Forms.Panel();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFormReg = new Guna.UI2.WinForms.Guna2Button();
            this.tbPhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMI = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbHolder = new System.Windows.Forms.TextBox();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignin = new Guna.UI2.WinForms.Guna2Button();
            this.toggleLogin = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.slidePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdminLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseMainForm = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.slideLoginPanel.SuspendLayout();
            this.slideRegisterPanel.SuspendLayout();
            this.slidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMainForm)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // slideLoginPanel
            // 
            this.slideLoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slideLoginPanel.BackColor = System.Drawing.Color.White;
            this.slideLoginPanel.Controls.Add(this.slideRegisterPanel);
            this.slideLoginPanel.Controls.Add(this.tbUsername);
            this.slideLoginPanel.Controls.Add(this.label1);
            this.slideLoginPanel.Controls.Add(this.btnSignin);
            this.slideLoginPanel.Controls.Add(this.toggleLogin);
            this.slideLoginPanel.Controls.Add(this.tbPassword);
            this.slideLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.slideLoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.slideLoginPanel.Name = "slideLoginPanel";
            this.slideLoginPanel.Size = new System.Drawing.Size(433, 521);
            this.slideLoginPanel.TabIndex = 1;
            // 
            // slideRegisterPanel
            // 
            this.slideRegisterPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slideRegisterPanel.Controls.Add(this.tbAddress);
            this.slideRegisterPanel.Controls.Add(this.tbEmail);
            this.slideRegisterPanel.Controls.Add(this.btnFormReg);
            this.slideRegisterPanel.Controls.Add(this.tbPhoneNum);
            this.slideRegisterPanel.Controls.Add(this.tbLname);
            this.slideRegisterPanel.Controls.Add(this.label2);
            this.slideRegisterPanel.Controls.Add(this.tbMI);
            this.slideRegisterPanel.Controls.Add(this.tbFname);
            this.slideRegisterPanel.Controls.Add(this.tbHolder);
            this.slideRegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.slideRegisterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.slideRegisterPanel.Name = "slideRegisterPanel";
            this.slideRegisterPanel.Size = new System.Drawing.Size(433, 521);
            this.slideRegisterPanel.TabIndex = 5;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderColor = System.Drawing.Color.Silver;
            this.tbAddress.BorderRadius = 3;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.DisabledState.Parent = this.tbAddress;
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.FocusedState.Parent = this.tbAddress;
            this.tbAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddress.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAddress.HoverState.Parent = this.tbAddress;
            this.tbAddress.Location = new System.Drawing.Point(61, 353);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(5);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.PlaceholderText = "Address";
            this.tbAddress.SelectedText = "";
            this.tbAddress.ShadowDecoration.Parent = this.tbAddress;
            this.tbAddress.Size = new System.Drawing.Size(323, 86);
            this.tbAddress.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.BorderColor = System.Drawing.Color.Silver;
            this.tbEmail.BorderRadius = 3;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEmail.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(61, 255);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(323, 32);
            this.tbEmail.TabIndex = 9;
            // 
            // btnFormReg
            // 
            this.btnFormReg.Animated = true;
            this.btnFormReg.BackColor = System.Drawing.Color.Transparent;
            this.btnFormReg.BorderRadius = 15;
            this.btnFormReg.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnFormReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFormReg.CheckedState.Parent = this.btnFormReg;
            this.btnFormReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormReg.CustomImages.Parent = this.btnFormReg;
            this.btnFormReg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(82)))), ((int)(((byte)(67)))));
            this.btnFormReg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFormReg.ForeColor = System.Drawing.Color.White;
            this.btnFormReg.HoverState.Parent = this.btnFormReg;
            this.btnFormReg.Location = new System.Drawing.Point(252, 459);
            this.btnFormReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormReg.Name = "btnFormReg";
            this.btnFormReg.ShadowDecoration.Parent = this.btnFormReg;
            this.btnFormReg.Size = new System.Drawing.Size(129, 46);
            this.btnFormReg.TabIndex = 5;
            this.btnFormReg.Text = "Register";
            this.btnFormReg.Click += new System.EventHandler(this.btnFormReg_Click);
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.BorderColor = System.Drawing.Color.Silver;
            this.tbPhoneNum.BorderRadius = 3;
            this.tbPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNum.DefaultText = "";
            this.tbPhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNum.DisabledState.Parent = this.tbPhoneNum;
            this.tbPhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNum.FocusedState.Parent = this.tbPhoneNum;
            this.tbPhoneNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPhoneNum.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbPhoneNum.HoverState.Parent = this.tbPhoneNum;
            this.tbPhoneNum.Location = new System.Drawing.Point(61, 303);
            this.tbPhoneNum.Margin = new System.Windows.Forms.Padding(5);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.PasswordChar = '\0';
            this.tbPhoneNum.PlaceholderText = "Phone Number";
            this.tbPhoneNum.SelectedText = "";
            this.tbPhoneNum.ShadowDecoration.Parent = this.tbPhoneNum;
            this.tbPhoneNum.Size = new System.Drawing.Size(323, 32);
            this.tbPhoneNum.TabIndex = 8;
            this.tbPhoneNum.TextChanged += new System.EventHandler(this.tbPhoneNum_TextChanged);
            this.tbPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNum_KeyPress);
            // 
            // tbLname
            // 
            this.tbLname.BorderColor = System.Drawing.Color.Silver;
            this.tbLname.BorderRadius = 3;
            this.tbLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLname.DefaultText = "";
            this.tbLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLname.DisabledState.Parent = this.tbLname;
            this.tbLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLname.FocusedState.Parent = this.tbLname;
            this.tbLname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbLname.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbLname.HoverState.Parent = this.tbLname;
            this.tbLname.Location = new System.Drawing.Point(61, 203);
            this.tbLname.Margin = new System.Windows.Forms.Padding(5);
            this.tbLname.Name = "tbLname";
            this.tbLname.PasswordChar = '\0';
            this.tbLname.PlaceholderText = "Last Name";
            this.tbLname.SelectedText = "";
            this.tbLname.ShadowDecoration.Parent = this.tbLname;
            this.tbLname.Size = new System.Drawing.Size(323, 32);
            this.tbLname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "REGISTER";
            // 
            // tbMI
            // 
            this.tbMI.BorderColor = System.Drawing.Color.Silver;
            this.tbMI.BorderRadius = 3;
            this.tbMI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMI.DefaultText = "";
            this.tbMI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMI.DisabledState.Parent = this.tbMI;
            this.tbMI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMI.FocusedState.Parent = this.tbMI;
            this.tbMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbMI.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMI.HoverState.Parent = this.tbMI;
            this.tbMI.Location = new System.Drawing.Point(61, 155);
            this.tbMI.Margin = new System.Windows.Forms.Padding(5);
            this.tbMI.Name = "tbMI";
            this.tbMI.PasswordChar = '\0';
            this.tbMI.PlaceholderText = "M.I";
            this.tbMI.SelectedText = "";
            this.tbMI.ShadowDecoration.Parent = this.tbMI;
            this.tbMI.Size = new System.Drawing.Size(323, 32);
            this.tbMI.TabIndex = 1;
            // 
            // tbFname
            // 
            this.tbFname.BorderColor = System.Drawing.Color.Silver;
            this.tbFname.BorderRadius = 3;
            this.tbFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFname.DefaultText = "";
            this.tbFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFname.DisabledState.Parent = this.tbFname;
            this.tbFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFname.FocusedState.Parent = this.tbFname;
            this.tbFname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbFname.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbFname.HoverState.Parent = this.tbFname;
            this.tbFname.Location = new System.Drawing.Point(61, 107);
            this.tbFname.Margin = new System.Windows.Forms.Padding(5);
            this.tbFname.Name = "tbFname";
            this.tbFname.PasswordChar = '\0';
            this.tbFname.PlaceholderText = "First Name";
            this.tbFname.SelectedText = "";
            this.tbFname.ShadowDecoration.Parent = this.tbFname;
            this.tbFname.Size = new System.Drawing.Size(323, 32);
            this.tbFname.TabIndex = 0;
            // 
            // tbHolder
            // 
            this.tbHolder.Location = new System.Drawing.Point(101, 459);
            this.tbHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHolder.Name = "tbHolder";
            this.tbHolder.Size = new System.Drawing.Size(9, 22);
            this.tbHolder.TabIndex = 11;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderColor = System.Drawing.Color.Silver;
            this.tbUsername.BorderRadius = 3;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUsername.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbUsername.IconLeft")));
            this.tbUsername.Location = new System.Drawing.Point(59, 167);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "Username";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(323, 32);
            this.tbUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN ";
            // 
            // btnSignin
            // 
            this.btnSignin.Animated = true;
            this.btnSignin.BackColor = System.Drawing.Color.Transparent;
            this.btnSignin.BorderRadius = 15;
            this.btnSignin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSignin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSignin.CheckedState.Parent = this.btnSignin;
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.CustomImages.Parent = this.btnSignin;
            this.btnSignin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(82)))), ((int)(((byte)(67)))));
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.HoverState.Parent = this.btnSignin;
            this.btnSignin.Location = new System.Drawing.Point(252, 303);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.ShadowDecoration.Parent = this.btnSignin;
            this.btnSignin.Size = new System.Drawing.Size(129, 46);
            this.btnSignin.TabIndex = 5;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // toggleLogin
            // 
            this.toggleLogin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(59)))));
            this.toggleLogin.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLogin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleLogin.CheckedState.Parent = this.toggleLogin;
            this.toggleLogin.Location = new System.Drawing.Point(59, 274);
            this.toggleLogin.Margin = new System.Windows.Forms.Padding(4);
            this.toggleLogin.Name = "toggleLogin";
            this.toggleLogin.ShadowDecoration.Parent = this.toggleLogin;
            this.toggleLogin.Size = new System.Drawing.Size(53, 25);
            this.toggleLogin.TabIndex = 2;
            this.toggleLogin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLogin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLogin.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLogin.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleLogin.UncheckedState.Parent = this.toggleLogin;
            this.toggleLogin.CheckedChanged += new System.EventHandler(this.toggleLogin_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderColor = System.Drawing.Color.Silver;
            this.tbPassword.BorderRadius = 3;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPassword.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbPassword.IconLeft")));
            this.tbPassword.Location = new System.Drawing.Point(59, 226);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(323, 32);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1288, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // slidePanel
            // 
            this.slidePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(59)))));
            this.slidePanel.Controls.Add(this.label6);
            this.slidePanel.Controls.Add(this.label5);
            this.slidePanel.Controls.Add(this.label4);
            this.slidePanel.Controls.Add(this.label3);
            this.slidePanel.Controls.Add(this.btnAdminLogin);
            this.slidePanel.Controls.Add(this.btnRegister);
            this.slidePanel.Controls.Add(this.pictureBox1);
            this.slidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(59)))));
            this.slidePanel.FillColor2 = System.Drawing.Color.Silver;
            this.slidePanel.Location = new System.Drawing.Point(433, 0);
            this.slidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.ShadowDecoration.Parent = this.slidePanel;
            this.slidePanel.Size = new System.Drawing.Size(433, 521);
            this.slidePanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "to Generate your own QR Code";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Register with your Basic Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 51);
            this.label4.TabIndex = 11;
            this.label4.Text = "Register to Scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(36, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hello, Welcome!";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.BorderRadius = 15;
            this.btnAdminLogin.CheckedState.Parent = this.btnAdminLogin;
            this.btnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogin.CustomImages.Parent = this.btnAdminLogin;
            this.btnAdminLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(82)))), ((int)(((byte)(67)))));
            this.btnAdminLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.HoverState.Parent = this.btnAdminLogin;
            this.btnAdminLogin.Location = new System.Drawing.Point(80, 406);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.ShadowDecoration.Parent = this.btnAdminLogin;
            this.btnAdminLogin.Size = new System.Drawing.Size(129, 46);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderRadius = 15;
            this.btnRegister.CheckedState.Parent = this.btnRegister;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.CustomImages.Parent = this.btnRegister;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(82)))), ((int)(((byte)(67)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.HoverState.Parent = this.btnRegister;
            this.btnRegister.Location = new System.Drawing.Point(251, 406);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ShadowDecoration.Parent = this.btnRegister;
            this.btnRegister.Size = new System.Drawing.Size(129, 46);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCloseMainForm
            // 
            this.btnCloseMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMainForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseMainForm.Image")));
            this.btnCloseMainForm.Location = new System.Drawing.Point(1297, 0);
            this.btnCloseMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseMainForm.Name = "btnCloseMainForm";
            this.btnCloseMainForm.Size = new System.Drawing.Size(37, 27);
            this.btnCloseMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCloseMainForm.TabIndex = 2;
            this.btnCloseMainForm.TabStop = false;
            this.btnCloseMainForm.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CustomGradientPanel1.Controls.Add(this.slidePanel);
            this.guna2CustomGradientPanel1.Controls.Add(this.slideLoginPanel);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(241, 48);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(867, 521);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCloseMainForm);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.slideLoginPanel.ResumeLayout(false);
            this.slideLoginPanel.PerformLayout();
            this.slideRegisterPanel.ResumeLayout(false);
            this.slideRegisterPanel.PerformLayout();
            this.slidePanel.ResumeLayout(false);
            this.slidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMainForm)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel slideLoginPanel;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleLogin;
        private System.Windows.Forms.Panel slideRegisterPanel;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2Button btnFormReg;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneNum;
        private Guna.UI2.WinForms.Guna2TextBox tbLname;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbMI;
        private Guna.UI2.WinForms.Guna2TextBox tbFname;
        private Guna.UI2.WinForms.Guna2GradientPanel slidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAdminLogin;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private System.Windows.Forms.PictureBox btnCloseMainForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHolder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
    }
}

