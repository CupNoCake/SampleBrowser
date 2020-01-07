namespace SampleBrowser
{
    partial class WebPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_go = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.exWebBrowser1 = new ExControls.ExWebBrowser();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 35);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 35);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tb_address);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(124, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(556, 35);
            this.panel5.TabIndex = 1;
            // 
            // tb_address
            // 
            this.tb_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_address.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_address.Location = new System.Drawing.Point(5, 5);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(546, 23);
            this.tb_address.TabIndex = 2;
            this.tb_address.Enter += new System.EventHandler(this.tb_address_Enter);
            this.tb_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_address_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_home);
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Controls.Add(this.btn_back);
            this.panel4.Controls.Add(this.btn_forward);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 35);
            this.panel4.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.AutoSize = true;
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = global::SampleBrowser.Properties.Resources.Home;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(96, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(25, 25);
            this.btn_home.TabIndex = 3;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AutoSize = true;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BackgroundImage = global::SampleBrowser.Properties.Resources.Refresh;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Location = new System.Drawing.Point(65, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(25, 25);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::SampleBrowser.Properties.Resources.Forward;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(34, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(25, 25);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.AutoSize = true;
            this.btn_forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_forward.BackgroundImage = global::SampleBrowser.Properties.Resources.Back;
            this.btn_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_forward.FlatAppearance.BorderSize = 0;
            this.btn_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forward.Location = new System.Drawing.Point(3, 3);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(25, 25);
            this.btn_forward.TabIndex = 0;
            this.btn_forward.UseVisualStyleBackColor = false;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_go);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(680, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 35);
            this.panel2.TabIndex = 0;
            // 
            // btn_go
            // 
            this.btn_go.AutoSize = true;
            this.btn_go.BackColor = System.Drawing.Color.Transparent;
            this.btn_go.BackgroundImage = global::SampleBrowser.Properties.Resources.Forward;
            this.btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_go.FlatAppearance.BorderSize = 0;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Location = new System.Drawing.Point(6, 4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(25, 25);
            this.btn_go.TabIndex = 2;
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 35);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(717, 1);
            this.panel6.TabIndex = 2;
            // 
            // exWebBrowser1
            // 
            this.exWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exWebBrowser1.Location = new System.Drawing.Point(0, 36);
            this.exWebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.exWebBrowser1.Name = "exWebBrowser1";
            this.exWebBrowser1.ScriptErrorsSuppressed = true;
            this.exWebBrowser1.Size = new System.Drawing.Size(717, 552);
            this.exWebBrowser1.TabIndex = 3;
            this.exWebBrowser1.BeforeNavigate2 += new System.EventHandler<ExControls.ComponentModel.ExWebBrowserBeforeNavigate2EventArgs>(this.exWebBrowser1_BeforeNavigate2);
            this.exWebBrowser1.NewWindow3 += new System.EventHandler<ExControls.ComponentModel.ExWebBrowserNewWindow3EventArgs>(this.exWebBrowser1_NewWindow3);
            this.exWebBrowser1.StatusTextChange += new System.EventHandler<ExControls.ComponentModel.ExWebBrowserStatusTextChangeEventArgs>(this.exWebBrowser1_StatusTextChange);
            this.exWebBrowser1.TitleChange += new System.EventHandler<ExControls.ComponentModel.ExWebBrowserTitleChangeEventArgs>(this.exWebBrowser1_TitleChange);
            this.exWebBrowser1.Quit += new System.EventHandler(this.exWebBrowser1_Quit);
            this.exWebBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.exWebBrowser1_Navigated);
            // 
            // WebPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exWebBrowser1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "WebPage";
            this.Size = new System.Drawing.Size(717, 588);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Panel panel6;
        private ExControls.ExWebBrowser exWebBrowser1;
    }
}
