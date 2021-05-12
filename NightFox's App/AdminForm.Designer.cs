
namespace test
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.userPhoto__RoundPictureBox = new test.RoundPictureBox();
            this.userName__Label = new System.Windows.Forms.Label();
            this.editUserData__Button = new System.Windows.Forms.Button();
            this.EditUserData__Panel = new System.Windows.Forms.Panel();
            this.editListCinema__Button = new System.Windows.Forms.Button();
            this.EditUserDataTitle__Panel = new System.Windows.Forms.Panel();
            this.EditUserDataTitle__Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto__RoundPictureBox)).BeginInit();
            this.EditUserData__Panel.SuspendLayout();
            this.EditUserDataTitle__Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPhoto__RoundPictureBox
            // 
            this.userPhoto__RoundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPhoto__RoundPictureBox.Image")));
            this.userPhoto__RoundPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("userPhoto__RoundPictureBox.InitialImage")));
            this.userPhoto__RoundPictureBox.Location = new System.Drawing.Point(20, 26);
            this.userPhoto__RoundPictureBox.Name = "userPhoto__RoundPictureBox";
            this.userPhoto__RoundPictureBox.Size = new System.Drawing.Size(100, 95);
            this.userPhoto__RoundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPhoto__RoundPictureBox.TabIndex = 4;
            this.userPhoto__RoundPictureBox.TabStop = false;
            // 
            // userName__Label
            // 
            this.userName__Label.AutoSize = true;
            this.userName__Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.userName__Label.Location = new System.Drawing.Point(138, 26);
            this.userName__Label.Name = "userName__Label";
            this.userName__Label.Size = new System.Drawing.Size(189, 25);
            this.userName__Label.TabIndex = 5;
            this.userName__Label.Text = "Имя пользователя";
            // 
            // editUserData__Button
            // 
            this.editUserData__Button.BackColor = System.Drawing.Color.DarkOrange;
            this.editUserData__Button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editUserData__Button.Location = new System.Drawing.Point(0, 35);
            this.editUserData__Button.Name = "editUserData__Button";
            this.editUserData__Button.Size = new System.Drawing.Size(433, 35);
            this.editUserData__Button.TabIndex = 8;
            this.editUserData__Button.Text = "Изменить данные пользователя";
            this.editUserData__Button.UseVisualStyleBackColor = false;
            this.editUserData__Button.Click += new System.EventHandler(this.editUserData__Button_Click);
            // 
            // EditUserData__Panel
            // 
            this.EditUserData__Panel.BackColor = System.Drawing.Color.Bisque;
            this.EditUserData__Panel.Controls.Add(this.editListCinema__Button);
            this.EditUserData__Panel.Controls.Add(this.EditUserDataTitle__Panel);
            this.EditUserData__Panel.Controls.Add(this.editUserData__Button);
            this.EditUserData__Panel.Location = new System.Drawing.Point(83, 155);
            this.EditUserData__Panel.Name = "EditUserData__Panel";
            this.EditUserData__Panel.Size = new System.Drawing.Size(433, 157);
            this.EditUserData__Panel.TabIndex = 9;
            // 
            // editListCinema__Button
            // 
            this.editListCinema__Button.BackColor = System.Drawing.Color.DarkOrange;
            this.editListCinema__Button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editListCinema__Button.Location = new System.Drawing.Point(0, 74);
            this.editListCinema__Button.Name = "editListCinema__Button";
            this.editListCinema__Button.Size = new System.Drawing.Size(433, 35);
            this.editListCinema__Button.TabIndex = 10;
            this.editListCinema__Button.Text = "Редактировать список фильмов";
            this.editListCinema__Button.UseVisualStyleBackColor = false;
            this.editListCinema__Button.Click += new System.EventHandler(this.editListCinema__Button_Click);
            // 
            // EditUserDataTitle__Panel
            // 
            this.EditUserDataTitle__Panel.BackColor = System.Drawing.Color.LightSalmon;
            this.EditUserDataTitle__Panel.Controls.Add(this.EditUserDataTitle__Label);
            this.EditUserDataTitle__Panel.Location = new System.Drawing.Point(0, 0);
            this.EditUserDataTitle__Panel.Name = "EditUserDataTitle__Panel";
            this.EditUserDataTitle__Panel.Size = new System.Drawing.Size(433, 26);
            this.EditUserDataTitle__Panel.TabIndex = 9;
            // 
            // EditUserDataTitle__Label
            // 
            this.EditUserDataTitle__Label.AutoSize = true;
            this.EditUserDataTitle__Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditUserDataTitle__Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditUserDataTitle__Label.Location = new System.Drawing.Point(21, 3);
            this.EditUserDataTitle__Label.Name = "EditUserDataTitle__Label";
            this.EditUserDataTitle__Label.Size = new System.Drawing.Size(380, 22);
            this.EditUserDataTitle__Label.TabIndex = 0;
            this.EditUserDataTitle__Label.Text = "Редактирование данных пользователей";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(559, 329);
            this.Controls.Add(this.EditUserData__Panel);
            this.Controls.Add(this.userPhoto__RoundPictureBox);
            this.Controls.Add(this.userName__Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto__RoundPictureBox)).EndInit();
            this.EditUserData__Panel.ResumeLayout(false);
            this.EditUserDataTitle__Panel.ResumeLayout(false);
            this.EditUserDataTitle__Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundPictureBox userPhoto__RoundPictureBox;
        private System.Windows.Forms.Label userName__Label;
        private System.Windows.Forms.Button editUserData__Button;
        private System.Windows.Forms.Panel EditUserData__Panel;
        private System.Windows.Forms.Panel EditUserDataTitle__Panel;
        private System.Windows.Forms.Label EditUserDataTitle__Label;
        private System.Windows.Forms.Button editListCinema__Button;
    }
}