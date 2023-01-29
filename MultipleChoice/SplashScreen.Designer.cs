﻿namespace MultipleChoice
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.Progressbar = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblLoading = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerCircular = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Progressbar
            // 
            this.Progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Progressbar.CustomBackground = false;
            this.Progressbar.Location = new System.Drawing.Point(246, 206);
            this.Progressbar.Maximum = 100;
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(83, 72);
            this.Progressbar.Style = MetroFramework.MetroColorStyle.Blue;
            this.Progressbar.StyleManager = null;
            this.Progressbar.TabIndex = 1;
            this.Progressbar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Progressbar.UseWaitCursor = true;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.lblLoading.Location = new System.Drawing.Point(457, 301);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(47, 13);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "loading";
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 300;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(403, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "●       ●       ●       ●       ●       ●";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(403, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "  ●       ●       ●        ●      ●        ●";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.label4.Location = new System.Drawing.Point(403, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "    ●       ●       ●        ●      ●        ●";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.label5.Location = new System.Drawing.Point(410, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "      ●       ●       ●        ●      ●        ●";
            // 
            // timerCircular
            // 
            this.timerCircular.Interval = 200;
            this.timerCircular.Tick += new System.EventHandler(this.timerCircular_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MultipleChoice.Properties.Resources.minhaj_university_lahore;
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "MUL QUIZ Portal";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Progressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressSpinner Progressbar;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerCircular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}