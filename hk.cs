using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace L
{
    partial class m : Form
    {
        class mr : UserControl
        {
            private System.ComponentModel.IContainer components = null;
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            private TextBox tt;
            private Button nl;
            private Button lp;
            public static mr ii { get; set; }
            public static void ss(string jj, Control kk)
            {
                foreach (Control c in kk.Controls)
                    c.Hide();

                ii = new mr() { Dock = DockStyle.Fill, Text = jj };
                ii.Parent = kk;
          


         

                ii.BringToFront();
            }
            public mr()
            {
                tt = new TextBox();
                nl = new Button();
                lp = new Button();
                SuspendLayout();
                // 
                // textBox1
                // 
                tt.BackColor = Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
                tt.BorderStyle = BorderStyle.None;
                tt.Dock = DockStyle.Fill;
                tt.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tt.ForeColor = Color.White;
                tt.Location = new Point(5, 5);
                tt.Multiline = true;
                tt.Name = "textBox1";
                tt.ReadOnly = true;
                tt.Size = new Size(385, 422);

                // 
                // nl
                // 
                nl.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left)
                | AnchorStyles.Right)));
                nl.BackColor = Color.White;
                nl.FlatAppearance.BorderSize = 0;
                nl.FlatStyle = FlatStyle.Flat;
                nl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                nl.ForeColor = SystemColors.GrayText;
                nl.Location = new Point(115, 394);
                nl.Name = "nl";
                nl.Size = new Size(275, 33);

                nl.Text = "Ok";
                nl.UseVisualStyleBackColor = false;
                nl.Click += new System.EventHandler(hu);
                // 
                // lp
                // 
                lp.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
                lp.BackColor = Color.White;
                lp.FlatAppearance.BorderSize = 0;
                lp.FlatStyle = FlatStyle.Flat;
                lp.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lp.ForeColor = SystemColors.GrayText;
                lp.Location = new Point(5, 394);
                lp.Name = "lp";
                lp.Size = new Size(111, 33);

                lp.Text = "Cancel";
                lp.UseVisualStyleBackColor = false;
                lp.Click += new System.EventHandler(lo);
                // 
                // mr
                // 
                AutoScaleDimensions = new SizeF(6F, 13F);
                AutoScaleMode = AutoScaleMode.Font;
                BackColor = Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
                Controls.Add(lp);
                Controls.Add(nl);
                Controls.Add(tt);
                Name = "mr";
                Padding = new Padding(5);
                Size = new Size(395, 432);
                Load += new System.EventHandler(ll);
                ResumeLayout(false);
                PerformLayout();
            }
            private void ll(object sender, EventArgs e)
            {
                tt.BackColor = Color.FromArgb(15, 157, 88);
                tt.ForeColor = Color.White;
            }

            public override string Text
            {
                set
                {
                    tt.Text = value;
                }
            }

            public EventHandler gt { get; set; }
            private void hu(object sender, EventArgs e)
            {
                if (gt != null)
                {
                    gt.Invoke(this, null);
                }
                foreach (Control c in this.Parent.Controls)
                    c.Show();

                Dispose();
            }
            private void lo(object sender, EventArgs e)
            {
                foreach (Control c in this.Parent.Controls)
                    c.Show();
                Dispose();
            }
        }
        class lo
        {
            public string ki { get; set; } = string.Empty;
            public string mi { get; set; } = string.Empty;
            public override int GetHashCode()
            {
                return ("[" + ki + "]" + mi).GetHashCode();
            }
            public override bool Equals(object obj)
            {
                return obj != null && (obj as lo).ki == ki && (obj as lo).mi == mi;
            }
        }



      
   

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
        private ToolStripMenuItem ex;
        private NotifyIcon hk;
        private ContextMenuStrip lk;
        private ToolStripMenuItem ot;
     
        private static void d()
        {
            //Get the assembly that contains the internal class
            Assembly a = Assembly.GetAssembly(typeof(System.Net.Configuration.SettingsSection));
            if (a != null)
            {
                //Use the assembly in order to get the internal type for the internal class
                Type b = a.GetType("System.Net.Configuration.SettingsSectionInternal");
                if (b != null)
                {
                    //Use the internal static property to get an instance of the internal settings class.
                    //If the static instance isn't created allready the property will create it for us.
                    object c = b.InvokeMember("Section",
                    BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.NonPublic, null, null, new object[] { });

                    if (c != null)
                    {
                        //Locate the private bool field that tells the framework is unsafe header parsing should be allowed or not
                        FieldInfo d = b.GetField("useUnsafeHeaderParsing", BindingFlags.NonPublic | BindingFlags.Instance);
                        if (d != null)
                        {
                            d.SetValue(c, true);
                        }
                    }
                }
            }

            ServicePointManager.DefaultConnectionLimit = int.MaxValue;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, error) =>
            {
                return true;
            };
            ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, error) =>
            {
                return true;
            };
        }

        public static string CURL_GET(string u)
        {
            var r = (HttpWebRequest)WebRequest.Create(u);
            r.Method = "GET";
            r.AllowAutoRedirect = true;
            r.Proxy = null;
            r.ServicePoint.Expect100Continue = false;
            r.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
            using (var p = (HttpWebResponse)r.GetResponse())
            {
                using (var s = new StreamReader(p.GetResponseStream()))
                {
                    return s.ReadToEnd();
                }
            }
        }
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);


        private void gj(object sender, EventArgs e)
        {
            p.PasswordChar = kk.Checked ? '\0' : '*';
        }

        static string ss = Guid.NewGuid().ToString().Substring(0, 6);

        private void lu(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnReg.Enabled = false;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    var ju = CURL_GET(Server + "?tieudattai=login&user=" + HttpUtility.UrlEncode(u.Text) + "&pass=" + HttpUtility.UrlEncode(p.Text) + "&hwid=" + ss);
                    if (ju == "success")
                    {
                        using (WebClient c = new WebClient())
                        {
                            using (var ki = new ZipArchive(new MemoryStream(c.DownloadData(Server + "?tieudattai=zip&user=" + HttpUtility.UrlEncode(u.Text) + "&pass=" + HttpUtility.UrlEncode(p.Text) + "&hwid=" + ss))))
                            {
                                ZipArchiveEntry wi = ki.Entries.FirstOrDefault();
                                using (var mj = wi.Open())
                                {
                                    using (var nh = new MemoryStream())
                                    {
                                        mj.CopyTo(nh);
                                        var ih = Assembly.Load(nh.ToArray());
                                        foreach (Type tt in ih.GetTypes())
                                        {
                                            if (tt.FullName.EndsWith("GUI"))
                                            {
                                                this.Invoke(() =>
                                                {
                                                    object on = ih.CreateInstance(tt.FullName);
                                                    Type t = on.GetType();

                                                    MethodInfo lq = t.GetMethod("Create");
                                                    //654, 197
                                                    var nu = (UserControl)lq.Invoke(on, new object[] { u.Text, p.Text });
                                                    Width = nu.Width;
                                                    Height = nu.Height;
                                                    nu.Dock = DockStyle.Fill;
                                                    Controls.Add(nu);
                                                    nu.BringToFront();


                                                    nu.Disposed += (object ss, EventArgs ee) =>
                                                    {
                                                        Width = 654;
                                                        Height = 197;
                                                        ih = null;
                                                    };
                                                });
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        this.Invoke(() =>
                        {
                            mr.ss(ju, this);
                        });
                    }
                }
                catch (Exception r)
                {
                    this.Invoke(() =>
                    {
                        mr.ss(r.ToString(), this);
                    });
                }
                finally
                {
                    this.Invoke(() =>
                    {
                        btnLogin.Enabled = true;
                        btnReg.Enabled = true;
                    });
                }
               
            });           
        }
        private void np(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lu(this, e);
        }

        private void yh(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                p.Select();
        }

        private void ti(object sender, CancelEventArgs e)
        {
            ot.Checked = TopMost;
        }

        private void ls(object sender, EventArgs e)
        {
            TopMost = !ot.Checked;
        }

        private void no(object sender, EventArgs e)
        {
            hk.Dispose();
            Dispose();
        }

        private void fi(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                Hide();
                e.Cancel = true;
            }
        }


        public static string Server = string.Empty;

        private void m_Load(object sender, EventArgs e)
        {
            timerCheckServer.Interval = 100;
            timerCheckServer.Tick += TimerCheckServer_Tick;
            txtServer.WaterMark = DefaultServer;
        }

        static string lastlive = string.Empty;

        private void TimerCheckServer_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "...";
            lblStatus.ForeColor = Color.Gray;
            Task.Run(() =>
            {
                try
                {
                    var author = CURL_GET(Server + "?tieudattai=who");
                    if(author == "tieudattai.org")
                    {
                        this.Invoke(() =>
                        {
                            lastlive = Server;
                            lblStatus.Text = "LIVE";
                            lblStatus.ForeColor = Color.Green;
                            INI.Write("User", "Server", txtServer.Text);
                            INI.Save("iAuto.ini");
                        });
                        
                    }
                    else
                    {
                        this.Invoke(() =>
                        {
                            if (!string.IsNullOrEmpty(lastlive))
                                Server = lastlive;
                            lblStatus.Text = "DIE";
                            lblStatus.ForeColor = Color.Red;
                        });
                    }
                }
                catch
                {
                    this.Invoke(() =>
                    {
                        if (!string.IsNullOrEmpty(lastlive))
                            Server = lastlive;
                        lblStatus.Text = "ERROR";
                        lblStatus.ForeColor = Color.Orange;
                    });
                }
                finally
                {                    
                    timerCheckServer.Stop();
                }
            });

           
        }

      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = txtReTypePass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnReg.Enabled = false;
            btnLogin.Enabled = false;
            Task.Run(() =>
            {
                try
                {
                    var ju = CURL_GET(Server + "?tieudattai=reg&user=" + HttpUtility.UrlEncode(txtU.Text) + "&pass=" + HttpUtility.UrlEncode(txtPass.Text) + "&repass=" + HttpUtility.UrlEncode(txtReTypePass.Text) + "&hwid=" + ss);
                    this.Invoke(() =>
                    {
                        mr.ss(ju, this);
                    });
                }
                catch (Exception ex)
                {
                    this.Invoke(() =>
                    {
                        mr.ss(ex.ToString(), this);
                    });
                }
                finally
                {
                    this.Invoke(() =>
                    {
                        btnReg.Enabled = true;
                        btnLogin.Enabled = true;
                    });
        
                }
            });
           
        }


        System.Windows.Forms.Timer timerCheckServer = new System.Windows.Forms.Timer();

        private void textBoxEx1_TextChanged(object sender, EventArgs e)
        {
            Server = txtServer.Text.Trim();
            if (string.IsNullOrEmpty(Server.Trim()))
            {
                Server = DefaultServer;
            }
            lblStatus.Text = "...";
            lblStatus.ForeColor = Color.Gray;
            timerCheckServer.Stop();
            timerCheckServer.Interval = 333;
            timerCheckServer.Start();

        }

        public static string DefaultServer = "http://tieudattai.org";

        private void txtU_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
