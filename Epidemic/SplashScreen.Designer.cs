﻿namespace Epidemic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.m_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pictureBox1
            // 
            this.m_pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("m_pictureBox1.Image")));
            this.m_pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("m_pictureBox1.InitialImage")));
            this.m_pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.m_pictureBox1.Name = "m_pictureBox1";
            this.m_pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.m_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBox1.TabIndex = 0;
            this.m_pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.m_pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pictureBox1;
    }
}