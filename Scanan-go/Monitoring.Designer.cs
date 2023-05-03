
namespace Scanan_go
{
    partial class Monitoring
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitoring));
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvMonitoring = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFetch = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpMntrngFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMntrngTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbMntrngSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvMonitoring);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(72, 57);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(923, 440);
            this.panel4.TabIndex = 13;
            // 
            // dgvMonitoring
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMonitoring.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonitoring.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonitoring.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonitoring.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonitoring.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonitoring.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonitoring.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonitoring.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonitoring.EnableHeadersVisualStyles = false;
            this.dgvMonitoring.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonitoring.Location = new System.Drawing.Point(0, 0);
            this.dgvMonitoring.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMonitoring.Name = "dgvMonitoring";
            this.dgvMonitoring.ReadOnly = true;
            this.dgvMonitoring.RowHeadersVisible = false;
            this.dgvMonitoring.RowHeadersWidth = 51;
            this.dgvMonitoring.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonitoring.Size = new System.Drawing.Size(923, 440);
            this.dgvMonitoring.TabIndex = 0;
            this.dgvMonitoring.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMonitoring.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonitoring.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonitoring.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMonitoring.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMonitoring.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMonitoring.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvMonitoring.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonitoring.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMonitoring.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonitoring.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMonitoring.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonitoring.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonitoring.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMonitoring.ThemeStyle.ReadOnly = true;
            this.dgvMonitoring.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonitoring.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonitoring.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMonitoring.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonitoring.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMonitoring.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonitoring.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFetch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpMntrngFrom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpMntrngTo);
            this.panel2.Controls.Add(this.tbMntrngSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(72, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 57);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnFetch
            // 
            this.btnFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetch.BackColor = System.Drawing.Color.Transparent;
            this.btnFetch.BorderRadius = 6;
            this.btnFetch.CheckedState.Parent = this.btnFetch;
            this.btnFetch.CustomImages.Parent = this.btnFetch;
            this.btnFetch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(59)))));
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFetch.ForeColor = System.Drawing.Color.White;
            this.btnFetch.HoverState.Parent = this.btnFetch;
            this.btnFetch.Location = new System.Drawing.Point(496, 15);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.ShadowDecoration.Parent = this.btnFetch;
            this.btnFetch.Size = new System.Drawing.Size(62, 27);
            this.btnFetch.TabIndex = 26;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "To:";
            // 
            // dtpMntrngFrom
            // 
            this.dtpMntrngFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMntrngFrom.BorderRadius = 3;
            this.dtpMntrngFrom.CheckedState.Parent = this.dtpMntrngFrom;
            this.dtpMntrngFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(59)))));
            this.dtpMntrngFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMntrngFrom.HoverState.Parent = this.dtpMntrngFrom;
            this.dtpMntrngFrom.Location = new System.Drawing.Point(131, 15);
            this.dtpMntrngFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMntrngFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMntrngFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMntrngFrom.Name = "dtpMntrngFrom";
            this.dtpMntrngFrom.ShadowDecoration.Parent = this.dtpMntrngFrom;
            this.dtpMntrngFrom.Size = new System.Drawing.Size(145, 31);
            this.dtpMntrngFrom.TabIndex = 23;
            this.dtpMntrngFrom.Value = new System.DateTime(2021, 5, 26, 21, 37, 59, 355);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "From:";
            // 
            // dtpMntrngTo
            // 
            this.dtpMntrngTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMntrngTo.BorderRadius = 3;
            this.dtpMntrngTo.CheckedState.Parent = this.dtpMntrngTo;
            this.dtpMntrngTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(59)))));
            this.dtpMntrngTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMntrngTo.HoverState.Parent = this.dtpMntrngTo;
            this.dtpMntrngTo.Location = new System.Drawing.Point(330, 15);
            this.dtpMntrngTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMntrngTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMntrngTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMntrngTo.Name = "dtpMntrngTo";
            this.dtpMntrngTo.ShadowDecoration.Parent = this.dtpMntrngTo;
            this.dtpMntrngTo.Size = new System.Drawing.Size(145, 31);
            this.dtpMntrngTo.TabIndex = 21;
            this.dtpMntrngTo.Value = new System.DateTime(2021, 5, 26, 21, 37, 59, 355);
            // 
            // tbMntrngSearch
            // 
            this.tbMntrngSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMntrngSearch.BorderRadius = 15;
            this.tbMntrngSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMntrngSearch.DefaultText = "";
            this.tbMntrngSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMntrngSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMntrngSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMntrngSearch.DisabledState.Parent = this.tbMntrngSearch;
            this.tbMntrngSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMntrngSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMntrngSearch.FocusedState.Parent = this.tbMntrngSearch;
            this.tbMntrngSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMntrngSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMntrngSearch.HoverState.Parent = this.tbMntrngSearch;
            this.tbMntrngSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbMntrngSearch.IconLeft")));
            this.tbMntrngSearch.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.tbMntrngSearch.Location = new System.Drawing.Point(613, 11);
            this.tbMntrngSearch.Margin = new System.Windows.Forms.Padding(5);
            this.tbMntrngSearch.Name = "tbMntrngSearch";
            this.tbMntrngSearch.PasswordChar = '\0';
            this.tbMntrngSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbMntrngSearch.PlaceholderText = "   Search  ";
            this.tbMntrngSearch.SelectedText = "";
            this.tbMntrngSearch.ShadowDecoration.Parent = this.tbMntrngSearch;
            this.tbMntrngSearch.Size = new System.Drawing.Size(305, 36);
            this.tbMntrngSearch.TabIndex = 20;
            this.tbMntrngSearch.TextChanged += new System.EventHandler(this.tbMntrngSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(72, 497);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 57);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 554);
            this.panel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(995, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 554);
            this.panel5.TabIndex = 14;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMonitoring;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMntrngFrom;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMntrngTo;
        private Guna.UI2.WinForms.Guna2TextBox tbMntrngSearch;
        private Guna.UI2.WinForms.Guna2Button btnFetch;
    }
}