
namespace test
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginTitle__Label = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.LinkLabel();
            this.inputNickname__Label = new System.Windows.Forms.Label();
            this.inputNickname__TextBox = new System.Windows.Forms.TextBox();
            this.inputPassword__TextBox = new System.Windows.Forms.TextBox();
            this.inputPassword__Label = new System.Windows.Forms.Label();
            this.login__Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTitle__Label
            // 
            this.loginTitle__Label.AutoSize = true;
            this.loginTitle__Label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginTitle__Label.Location = new System.Drawing.Point(126, 75);
            this.loginTitle__Label.Name = "loginTitle__Label";
            this.loginTitle__Label.Size = new System.Drawing.Size(166, 28);
            this.loginTitle__Label.TabIndex = 0;
            this.loginTitle__Label.Text = "Авторизация";
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register.Location = new System.Drawing.Point(264, 9);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(119, 22);
            this.register.TabIndex = 3;
            this.register.TabStop = true;
            this.register.Text = "Регистрация";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // inputNickname__Label
            // 
            this.inputNickname__Label.AutoSize = true;
            this.inputNickname__Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNickname__Label.Location = new System.Drawing.Point(94, 147);
            this.inputNickname__Label.Name = "inputNickname__Label";
            this.inputNickname__Label.Size = new System.Drawing.Size(154, 25);
            this.inputNickname__Label.TabIndex = 3;
            this.inputNickname__Label.Text = "Введите Логин";
            // 
            // inputNickname__TextBox
            // 
            this.inputNickname__TextBox.Location = new System.Drawing.Point(94, 175);
            this.inputNickname__TextBox.Name = "inputNickname__TextBox";
            this.inputNickname__TextBox.Size = new System.Drawing.Size(219, 23);
            this.inputNickname__TextBox.TabIndex = 0;
            // 
            // inputPassword__TextBox
            // 
            this.inputPassword__TextBox.Location = new System.Drawing.Point(92, 255);
            this.inputPassword__TextBox.Name = "inputPassword__TextBox";
            this.inputPassword__TextBox.Size = new System.Drawing.Size(219, 23);
            this.inputPassword__TextBox.TabIndex = 1;
            this.inputPassword__TextBox.TextChanged += new System.EventHandler(this.inputPassword__TextBox_TextChanged);
            // 
            // inputPassword__Label
            // 
            this.inputPassword__Label.AutoSize = true;
            this.inputPassword__Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPassword__Label.Location = new System.Drawing.Point(92, 227);
            this.inputPassword__Label.Name = "inputPassword__Label";
            this.inputPassword__Label.Size = new System.Drawing.Size(166, 25);
            this.inputPassword__Label.TabIndex = 5;
            this.inputPassword__Label.Text = "Введите Пароль";
            // 
            // login__Button
            // 
            this.login__Button.BackColor = System.Drawing.Color.DarkOrange;
            this.login__Button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login__Button.Location = new System.Drawing.Point(42, 312);
            this.login__Button.Name = "login__Button";
            this.login__Button.Size = new System.Drawing.Size(322, 37);
            this.login__Button.TabIndex = 2;
            this.login__Button.Text = "Войти в кабинет";
            this.login__Button.UseVisualStyleBackColor = false;
            this.login__Button.Click += new System.EventHandler(this.login__Button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(399, 382);
            this.Controls.Add(this.login__Button);
            this.Controls.Add(this.inputPassword__TextBox);
            this.Controls.Add(this.inputPassword__Label);
            this.Controls.Add(this.inputNickname__TextBox);
            this.Controls.Add(this.inputNickname__Label);
            this.Controls.Add(this.register);
            this.Controls.Add(this.loginTitle__Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма авторизации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTitle__Label;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.Label inputNickname__Label;
        private System.Windows.Forms.TextBox inputNickname__TextBox;
        private System.Windows.Forms.TextBox inputPassword__TextBox;
        private System.Windows.Forms.Label inputPassword__Label;
        private System.Windows.Forms.Button login__Button;
    }
}

