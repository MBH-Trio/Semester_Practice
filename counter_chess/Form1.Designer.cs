namespace counter_chess
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
            this.player_2 = new Guna.UI2.WinForms.Guna2Button();
            this.player_1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Reset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // player_2
            // 
            this.player_2.BorderRadius = 30;
            this.player_2.CheckedState.Parent = this.player_2;
            this.player_2.CustomImages.Parent = this.player_2;
            this.player_2.FillColor = System.Drawing.Color.Gray;
            this.player_2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_2.ForeColor = System.Drawing.Color.White;
            this.player_2.HoverState.Parent = this.player_2;
            this.player_2.Location = new System.Drawing.Point(453, 37);
            this.player_2.Name = "player_2";
            this.player_2.ShadowDecoration.Parent = this.player_2;
            this.player_2.Size = new System.Drawing.Size(298, 282);
            this.player_2.TabIndex = 0;
            this.player_2.Text = "Player_2";
            this.player_2.Click += new System.EventHandler(this.player_2_Click);
            // 
            // player_1
            // 
            this.player_1.BorderRadius = 30;
            this.player_1.CheckedState.Parent = this.player_1;
            this.player_1.CustomImages.Parent = this.player_1;
            this.player_1.FillColor = System.Drawing.Color.Gray;
            this.player_1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_1.ForeColor = System.Drawing.Color.White;
            this.player_1.HoverState.Parent = this.player_1;
            this.player_1.Location = new System.Drawing.Point(26, 37);
            this.player_1.Name = "player_1";
            this.player_1.ShadowDecoration.Parent = this.player_1;
            this.player_1.Size = new System.Drawing.Size(298, 282);
            this.player_1.TabIndex = 1;
            this.player_1.Text = "Player_1";
            this.player_1.Click += new System.EventHandler(this.player_1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(596, 375);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Exit";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Reset
            // 
            this.Reset.CheckedState.Parent = this.Reset;
            this.Reset.CustomImages.Parent = this.Reset;
            this.Reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Reset.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.HoverState.Parent = this.Reset;
            this.Reset.Location = new System.Drawing.Point(397, 375);
            this.Reset.Name = "Reset";
            this.Reset.ShadowDecoration.Parent = this.Reset;
            this.Reset.Size = new System.Drawing.Size(180, 45);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(197, 375);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Pause";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(5, 375);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = " Play";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.player_1);
            this.Controls.Add(this.player_2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button player_2;
        private Guna.UI2.WinForms.Guna2Button player_1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button Reset;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

