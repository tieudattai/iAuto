using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L
{
    partial class m
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer cs = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (cs != null))
            {
                cs.Dispose();
            }
            base.Dispose(disposing);
        }

        public m()
        {

            InitializeComponent();
            u.Select();
            try
            {
                d();
            }
            catch { }
            Icon = hk.Icon = Properties.Resources.icon;

            hk.MouseClick += (ss, eee) =>
            {
                if (eee.Button == MouseButtons.Left)
                {
                    if (Visible && WindowState == FormWindowState.Normal)
                    {
                        Hide();
                    }
                    else
                    {
                        Visible = true;
                        WindowState = FormWindowState.Normal;
                        SetForegroundWindow(Handle);
                    }
                }
                if (eee.Button == MouseButtons.Middle)
                {
                    Dispose();
                }
            };

            INI = IniParser.Load("iAuto.ini");
            u.Text = INI.Read("User", "Email");
            p.Text = INI.Read("User", "Pass");
            txtServer.Text = INI.Read("User", "Server").Trim();
            TopMost = INI.Read("User", "TopMost") == "True";
        }

        static IniParser INI;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ex = new System.Windows.Forms.ToolStripMenuItem();
            this.hk = new System.Windows.Forms.NotifyIcon(this.components);
            this.lk = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ot = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelPass = new System.Windows.Forms.Panel();
            this.p = new L.TextBoxEx();
            this.kk = new System.Windows.Forms.CheckBox();
            this.gr = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.u = new L.TextBoxEx();
            this.fd = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.panelRegPass = new System.Windows.Forms.Panel();
            this.txtPass = new L.TextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.panelReRegPass = new System.Windows.Forms.Panel();
            this.txtReTypePass = new L.TextBoxEx();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegUser = new System.Windows.Forms.Panel();
            this.txtU = new L.TextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.panelServer = new System.Windows.Forms.Panel();
            this.txtServer = new L.TextBoxEx();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lk.SuspendLayout();
            this.panelPass.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelRegPass.SuspendLayout();
            this.panelReRegPass.SuspendLayout();
            this.panelRegUser.SuspendLayout();
            this.panelServer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ex
            // 
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(110, 22);
            this.ex.Text = "Exit";
            this.ex.Click += new System.EventHandler(this.no);
            // 
            // hk
            // 
            this.hk.ContextMenuStrip = this.lk;
            this.hk.Text = "iAuto";
            this.hk.Visible = true;
            // 
            // lk
            // 
            this.lk.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ot,
            this.ex});
            this.lk.Name = "contextMenuStrip";
            this.lk.Size = new System.Drawing.Size(111, 48);
            this.lk.Opening += new System.ComponentModel.CancelEventHandler(this.ti);
            // 
            // ot
            // 
            this.ot.Name = "ot";
            this.ot.Size = new System.Drawing.Size(110, 22);
            this.ot.Text = "OnTop";
            this.ot.Click += new System.EventHandler(this.ls);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 81);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(323, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login [Đăng Nhập]";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.lu);
            // 
            // panelPass
            // 
            this.panelPass.Controls.Add(this.p);
            this.panelPass.Controls.Add(this.kk);
            this.panelPass.Controls.Add(this.gr);
            this.panelPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPass.Location = new System.Drawing.Point(0, 27);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(323, 27);
            this.panelPass.TabIndex = 1;
            // 
            // p
            // 
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(69, 0);
            this.p.Margin = new System.Windows.Forms.Padding(4);
            this.p.Name = "p";
            this.p.PasswordChar = '*';
            this.p.Size = new System.Drawing.Size(234, 20);
            this.p.TabIndex = 0;
            this.p.WaterMark = "Mật Khẩu";
            this.p.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.p.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.p.KeyDown += new System.Windows.Forms.KeyEventHandler(this.np);
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Dock = System.Windows.Forms.DockStyle.Right;
            this.kk.Location = new System.Drawing.Point(303, 0);
            this.kk.Name = "kk";
            this.kk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.kk.Size = new System.Drawing.Size(20, 27);
            this.kk.TabIndex = 0;
            this.kk.TabStop = false;
            this.kk.UseVisualStyleBackColor = true;
            this.kk.CheckedChanged += new System.EventHandler(this.gj);
            // 
            // gr
            // 
            this.gr.Dock = System.Windows.Forms.DockStyle.Left;
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gr.Location = new System.Drawing.Point(0, 0);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(69, 27);
            this.gr.TabIndex = 0;
            this.gr.Text = "Pass:";
            this.gr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.u);
            this.panelUser.Controls.Add(this.fd);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(323, 27);
            this.panelUser.TabIndex = 0;
            // 
            // u
            // 
            this.u.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.u.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u.Location = new System.Drawing.Point(69, 0);
            this.u.Margin = new System.Windows.Forms.Padding(4);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(254, 20);
            this.u.TabIndex = 0;
            this.u.WaterMark = "Tài Khoản";
            this.u.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.u.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.u.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yh);
            // 
            // fd
            // 
            this.fd.Dock = System.Windows.Forms.DockStyle.Left;
            this.fd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fd.Location = new System.Drawing.Point(0, 0);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(69, 27);
            this.fd.TabIndex = 0;
            this.fd.Text = "User:";
            this.fd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(0, 81);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(287, 33);
            this.btnReg.TabIndex = 0;
            this.btnReg.TabStop = false;
            this.btnReg.Text = "Register [Đăng Ký]";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelRegPass
            // 
            this.panelRegPass.Controls.Add(this.txtPass);
            this.panelRegPass.Controls.Add(this.label3);
            this.panelRegPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegPass.Location = new System.Drawing.Point(0, 27);
            this.panelRegPass.Name = "panelRegPass";
            this.panelRegPass.Size = new System.Drawing.Size(287, 27);
            this.panelRegPass.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(110, 0);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(177, 20);
            this.txtPass.TabIndex = 0;
            this.txtPass.WaterMark = "Mật Khẩu";
            this.txtPass.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtU_KeyDown);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pass:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelReRegPass
            // 
            this.panelReRegPass.Controls.Add(this.txtReTypePass);
            this.panelReRegPass.Controls.Add(this.checkBox1);
            this.panelReRegPass.Controls.Add(this.label1);
            this.panelReRegPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReRegPass.Location = new System.Drawing.Point(0, 54);
            this.panelReRegPass.Name = "panelReRegPass";
            this.panelReRegPass.Size = new System.Drawing.Size(287, 27);
            this.panelReRegPass.TabIndex = 4;
            // 
            // txtReTypePass
            // 
            this.txtReTypePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReTypePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReTypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReTypePass.Location = new System.Drawing.Point(110, 0);
            this.txtReTypePass.Margin = new System.Windows.Forms.Padding(4);
            this.txtReTypePass.Name = "txtReTypePass";
            this.txtReTypePass.PasswordChar = '*';
            this.txtReTypePass.Size = new System.Drawing.Size(157, 20);
            this.txtReTypePass.TabIndex = 0;
            this.txtReTypePass.WaterMark = "Nhập Lại Mật Khẩu";
            this.txtReTypePass.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtReTypePass.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReTypePass.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txtReTypePass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtU_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(267, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(20, 27);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.TabStop = false;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retype Pass:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRegUser
            // 
            this.panelRegUser.Controls.Add(this.txtU);
            this.panelRegUser.Controls.Add(this.label2);
            this.panelRegUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegUser.Location = new System.Drawing.Point(0, 0);
            this.panelRegUser.Name = "panelRegUser";
            this.panelRegUser.Size = new System.Drawing.Size(287, 27);
            this.panelRegUser.TabIndex = 2;
            // 
            // txtU
            // 
            this.txtU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU.Location = new System.Drawing.Point(110, 0);
            this.txtU.Margin = new System.Windows.Forms.Padding(4);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(177, 20);
            this.txtU.TabIndex = 0;
            this.txtU.WaterMark = "Tài Khoản";
            this.txtU.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtU.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txtU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtU_KeyDown);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "User:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelServer
            // 
            this.panelServer.Controls.Add(this.txtServer);
            this.panelServer.Controls.Add(this.lblStatus);
            this.panelServer.Controls.Add(this.label4);
            this.panelServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServer.Location = new System.Drawing.Point(0, 54);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(323, 27);
            this.panelServer.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(69, 0);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(182, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = " ";
            this.txtServer.WaterMark = "Default Watermark...";
            this.txtServer.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txtServer.TextChanged += new System.EventHandler(this.textBoxEx1_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(251, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 27);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Controls.Add(this.panelReRegPass);
            this.panel2.Controls.Add(this.panelRegPass);
            this.panel2.Controls.Add(this.panelRegUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 134);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.panelServer);
            this.panel3.Controls.Add(this.panelPass);
            this.panel3.Controls.Add(this.panelUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 134);
            this.panel3.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(614, 134);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.TabStop = false;
            // 
            // m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 158);
            this.Controls.Add(this.splitContainer1);
            this.Name = "m";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iAuto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fi);
            this.Load += new System.EventHandler(this.m_Load);
            this.lk.ResumeLayout(false);
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelRegPass.ResumeLayout(false);
            this.panelRegPass.PerformLayout();
            this.panelReRegPass.ResumeLayout(false);
            this.panelReRegPass.PerformLayout();
            this.panelRegUser.ResumeLayout(false);
            this.panelRegUser.PerformLayout();
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.ComponentModel.IContainer components;
        private Button btnReg;
        private Panel panelReRegPass;
        private TextBoxEx txtReTypePass;
        private CheckBox checkBox1;
        private Label label1;
        private Panel panelRegUser;
        private TextBoxEx txtU;
        private Label label2;
        private Panel panelRegPass;
        private TextBoxEx txtPass;
        private Label label3;
        private Panel panelServer;
        private TextBoxEx txtServer;
        private Label label4;
        private Button btnLogin;
        private Panel panelPass;
        private TextBoxEx p;
        private CheckBox kk;
        private Label gr;
        private Panel panelUser;
        private TextBoxEx u;
        private Label fd;
        private Label lblStatus;
        private Panel panel2;
        private Panel panel3;
        private SplitContainer splitContainer1;
    }
}
