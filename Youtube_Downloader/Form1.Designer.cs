namespace Youtube_Downloader
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
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.link = new Guna.UI2.WinForms.Guna2TextBox();
            this.resolution = new Guna.UI2.WinForms.Guna2ComboBox();
            this.status = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.zeroitLollipopButton1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.path = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BorderRadius = 20;
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(80, 278);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(190, 51);
            this.guna2GradientTileButton1.TabIndex = 0;
            this.guna2GradientTileButton1.Text = "Download";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.download);
            // 
            // link
            // 
            this.link.BorderRadius = 18;
            this.link.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.link.DefaultText = "";
            this.link.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.link.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.link.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.link.DisabledState.Parent = this.link;
            this.link.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.link.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.link.FocusedState.Parent = this.link;
            this.link.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.link.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.link.HoverState.Parent = this.link;
            this.link.Location = new System.Drawing.Point(63, 84);
            this.link.Name = "link";
            this.link.PasswordChar = '\0';
            this.link.PlaceholderForeColor = System.Drawing.Color.Black;
            this.link.PlaceholderText = "Link";
            this.link.SelectedText = "";
            this.link.ShadowDecoration.Parent = this.link;
            this.link.Size = new System.Drawing.Size(313, 36);
            this.link.TabIndex = 1;
            // 
            // resolution
            // 
            this.resolution.BackColor = System.Drawing.Color.Transparent;
            this.resolution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolution.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resolution.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resolution.FocusedState.Parent = this.resolution;
            this.resolution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.resolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.resolution.HoverState.Parent = this.resolution;
            this.resolution.ItemHeight = 30;
            this.resolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720",
            "1080"});
            this.resolution.ItemsAppearance.Parent = this.resolution;
            this.resolution.Location = new System.Drawing.Point(545, 84);
            this.resolution.Name = "resolution";
            this.resolution.ShadowDecoration.Parent = this.resolution;
            this.resolution.Size = new System.Drawing.Size(140, 36);
            this.resolution.StartIndex = 0;
            this.resolution.TabIndex = 3;
            // 
            // status
            // 
            this.status.AllowTransparency = true;
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.status.Location = new System.Drawing.Point(567, 278);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 25);
            this.status.TabIndex = 4;
            this.status.Text = "status";
            // 
            // zeroitLollipopButton1
            // 
            this.zeroitLollipopButton1.AllowTransparency = true;
            this.zeroitLollipopButton1.AnimationInterval = 1;
            this.zeroitLollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitLollipopButton1.BGColor = "#508ef5";
            this.zeroitLollipopButton1.Corners = 1F;
            this.zeroitLollipopButton1.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.zeroitLollipopButton1.DoubleRipple = false;
            this.zeroitLollipopButton1.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.zeroitLollipopButton1.FontColor = "#ffffff";
            this.zeroitLollipopButton1.Location = new System.Drawing.Point(542, 149);
            this.zeroitLollipopButton1.Name = "zeroitLollipopButton1";
            this.zeroitLollipopButton1.RippleEffectColor = System.Drawing.Color.Black;
            this.zeroitLollipopButton1.RippleOpacity = 25;
            this.zeroitLollipopButton1.Size = new System.Drawing.Size(143, 41);
            this.zeroitLollipopButton1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitLollipopButton1.TabIndex = 5;
            this.zeroitLollipopButton1.Text = "Select path";
            this.zeroitLollipopButton1.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.zeroitLollipopButton1.Click += new System.EventHandler(this.zeroitLollipopButton1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(412, 84);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 27);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Resolution";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(214, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(189, 27);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Youtube Downloader";
            // 
            // path
            // 
            this.path.BorderRadius = 18;
            this.path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.path.DefaultText = "";
            this.path.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.path.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.path.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.path.DisabledState.Parent = this.path;
            this.path.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.path.Enabled = false;
            this.path.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.path.FocusedState.Parent = this.path;
            this.path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.path.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.path.HoverState.Parent = this.path;
            this.path.Location = new System.Drawing.Point(63, 149);
            this.path.Name = "path";
            this.path.PasswordChar = '\0';
            this.path.PlaceholderForeColor = System.Drawing.Color.Black;
            this.path.PlaceholderText = "Path";
            this.path.SelectedText = "";
            this.path.ShadowDecoration.Parent = this.path;
            this.path.Size = new System.Drawing.Size(313, 36);
            this.path.TabIndex = 8;
            this.path.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.path);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.zeroitLollipopButton1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.link);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private Guna.UI2.WinForms.Guna2TextBox link;
        private Guna.UI2.WinForms.Guna2ComboBox resolution;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel status;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton zeroitLollipopButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox path;
        private System.Windows.Forms.Timer timer1;
    }
}

