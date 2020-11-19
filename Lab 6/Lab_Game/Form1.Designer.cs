namespace Lab_Game
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
            this.dragon = new System.Windows.Forms.PictureBox();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.go_up = new System.Windows.Forms.Timer(this.components);
            this.do_down = new System.Windows.Forms.Timer(this.components);
            this.obstacle = new System.Windows.Forms.Timer(this.components);
            this.obstacle_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // dragon
            // 
            this.dragon.Image = global::Lab_Game.Properties.Resources.running;
            this.dragon.Location = new System.Drawing.Point(37, 383);
            this.dragon.Name = "dragon";
            this.dragon.Size = new System.Drawing.Size(40, 43);
            this.dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dragon.TabIndex = 1;
            this.dragon.TabStop = false;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(378, 54);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score :";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(81, 43);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 13);
            this.Score.TabIndex = 4;
            // 
            // go_up
            // 
            this.go_up.Interval = 2;
            this.go_up.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // do_down
            // 
            this.do_down.Interval = 1;
            this.do_down.Tick += new System.EventHandler(this.do_down_Tick);
            // 
            // obstacle
            // 
            this.obstacle.Enabled = true;
            this.obstacle.Interval = 10;
            this.obstacle.Tick += new System.EventHandler(this.obstacle_Tick);
            // 
            // obstacle_pic
            // 
            this.obstacle_pic.Image = global::Lab_Game.Properties.Resources.obstacle_1;
            this.obstacle_pic.Location = new System.Drawing.Point(903, 383);
            this.obstacle_pic.Name = "obstacle_pic";
            this.obstacle_pic.Size = new System.Drawing.Size(27, 50);
            this.obstacle_pic.TabIndex = 7;
            this.obstacle_pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 470);
            this.Controls.Add(this.obstacle_pic);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.dragon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dragon;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer go_up;
        private System.Windows.Forms.Timer do_down;
        private System.Windows.Forms.Timer obstacle;
        private System.Windows.Forms.PictureBox obstacle_pic;
    }
}

