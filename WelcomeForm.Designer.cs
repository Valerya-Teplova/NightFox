
namespace test
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcomeImage__PictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeTimer__Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.welcomeImage__PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeImage__PictureBox
            // 
            this.welcomeImage__PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeImage__PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("welcomeImage__PictureBox.Image")));
            this.welcomeImage__PictureBox.Location = new System.Drawing.Point(0, 0);
            this.welcomeImage__PictureBox.Name = "welcomeImage__PictureBox";
            this.welcomeImage__PictureBox.Size = new System.Drawing.Size(605, 343);
            this.welcomeImage__PictureBox.TabIndex = 1;
            this.welcomeImage__PictureBox.TabStop = false;
            // 
            // welcomeTimer__Timer
            // 
            this.welcomeTimer__Timer.Enabled = true;
            this.welcomeTimer__Timer.Interval = 3000;
            this.welcomeTimer__Timer.Tick += new System.EventHandler(this.welcomeTimer__Timer_Tick);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 343);
            this.Controls.Add(this.welcomeImage__PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.Activated += new System.EventHandler(this.WelcomeForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.welcomeImage__PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox welcomeImage__PictureBox;
        private System.Windows.Forms.Timer welcomeTimer__Timer;
    }
}