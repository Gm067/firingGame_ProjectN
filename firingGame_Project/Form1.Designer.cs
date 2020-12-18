namespace firingGame_Project
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
            this.show_pic = new System.Windows.Forms.PictureBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.shoot_away_btn = new System.Windows.Forms.Button();
            this.shoot_fire_btn = new System.Windows.Forms.Button();
            this.spin_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // show_pic
            // 
            this.show_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.show_pic.Image = global::firingGame_Project.Properties.Resources.pf;
            this.show_pic.Location = new System.Drawing.Point(3, 305);
            this.show_pic.Name = "show_pic";
            this.show_pic.Size = new System.Drawing.Size(367, 187);
            this.show_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show_pic.TabIndex = 0;
            this.show_pic.TabStop = false;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.Red;
            this.start_btn.Location = new System.Drawing.Point(717, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(172, 47);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start Game";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_btn.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.ForeColor = System.Drawing.Color.Red;
            this.load_btn.Location = new System.Drawing.Point(717, 80);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(172, 47);
            this.load_btn.TabIndex = 2;
            this.load_btn.Text = "Load Gun";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_btn.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_btn.ForeColor = System.Drawing.Color.Red;
            this.restart_btn.Location = new System.Drawing.Point(717, 378);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(172, 47);
            this.restart_btn.TabIndex = 3;
            this.restart_btn.Text = "Restart Game";
            this.restart_btn.UseVisualStyleBackColor = false;
            // 
            // shoot_away_btn
            // 
            this.shoot_away_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shoot_away_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoot_away_btn.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_away_btn.ForeColor = System.Drawing.Color.Red;
            this.shoot_away_btn.Location = new System.Drawing.Point(717, 305);
            this.shoot_away_btn.Name = "shoot_away_btn";
            this.shoot_away_btn.Size = new System.Drawing.Size(172, 47);
            this.shoot_away_btn.TabIndex = 4;
            this.shoot_away_btn.Text = "Shoot Away";
            this.shoot_away_btn.UseVisualStyleBackColor = false;
            this.shoot_away_btn.Click += new System.EventHandler(this.shoot_away_btn_Click);
            // 
            // shoot_fire_btn
            // 
            this.shoot_fire_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shoot_fire_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoot_fire_btn.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_fire_btn.ForeColor = System.Drawing.Color.Red;
            this.shoot_fire_btn.Location = new System.Drawing.Point(717, 229);
            this.shoot_fire_btn.Name = "shoot_fire_btn";
            this.shoot_fire_btn.Size = new System.Drawing.Size(172, 47);
            this.shoot_fire_btn.TabIndex = 5;
            this.shoot_fire_btn.Text = "Shoot Fire";
            this.shoot_fire_btn.UseVisualStyleBackColor = false;
            this.shoot_fire_btn.Click += new System.EventHandler(this.shoot_fire_btn_Click);
            // 
            // spin_btn
            // 
            this.spin_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spin_btn.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_btn.ForeColor = System.Drawing.Color.Red;
            this.spin_btn.Location = new System.Drawing.Point(717, 152);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(172, 47);
            this.spin_btn.TabIndex = 6;
            this.spin_btn.Text = "Spin Game";
            this.spin_btn.UseVisualStyleBackColor = false;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::firingGame_Project.Properties.Resources.pf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 504);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.shoot_fire_btn);
            this.Controls.Add(this.shoot_away_btn);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.show_pic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.show_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox show_pic;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button shoot_away_btn;
        private System.Windows.Forms.Button shoot_fire_btn;
        private System.Windows.Forms.Button spin_btn;
    }
}

