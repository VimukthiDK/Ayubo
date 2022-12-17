namespace Ayubo
{
    partial class frmWelcome
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
            this.lbAD = new System.Windows.Forms.Label();
            this.pgbWelcome = new System.Windows.Forms.ProgressBar();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pbWelcom = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcom)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAD
            // 
            this.lbAD.AutoSize = true;
            this.lbAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAD.ForeColor = System.Drawing.Color.Black;
            this.lbAD.Location = new System.Drawing.Point(209, 75);
            this.lbAD.Name = "lbAD";
            this.lbAD.Size = new System.Drawing.Size(119, 25);
            this.lbAD.TabIndex = 8;
            this.lbAD.Text = "Ayubo Drive";
            this.lbAD.Click += new System.EventHandler(this.lbAD_Click);
            // 
            // pgbWelcome
            // 
            this.pgbWelcome.Location = new System.Drawing.Point(97, 368);
            this.pgbWelcome.MarqueeAnimationSpeed = 50;
            this.pgbWelcome.Name = "pgbWelcome";
            this.pgbWelcome.Size = new System.Drawing.Size(374, 23);
            this.pgbWelcome.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbWelcome.TabIndex = 7;
            this.pgbWelcome.Click += new System.EventHandler(this.pgbWelcome_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Firebrick;
            this.lbWelcome.Location = new System.Drawing.Point(178, 14);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(193, 39);
            this.lbWelcome.TabIndex = 6;
            this.lbWelcome.Text = "WELCOME";
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // pbWelcom
            // 
            this.pbWelcom.Image = global::Ayubo.Properties.Resources._3_cars__2_;
            this.pbWelcom.Location = new System.Drawing.Point(55, 61);
            this.pbWelcom.Name = "pbWelcom";
            this.pbWelcom.Size = new System.Drawing.Size(463, 273);
            this.pbWelcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWelcom.TabIndex = 5;
            this.pbWelcom.TabStop = false;
            this.pbWelcom.Click += new System.EventHandler(this.pbWelcom_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lbAD);
            this.Controls.Add(this.pgbWelcome);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.pbWelcom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWelcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.Shown += new System.EventHandler(this.frmWelcome_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAD;
        private System.Windows.Forms.ProgressBar pgbWelcome;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.PictureBox pbWelcom;
        private System.Windows.Forms.Timer timer1;
    }
}