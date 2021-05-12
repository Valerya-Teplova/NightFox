
namespace test
{
    partial class EditUserDataForm
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
            System.Windows.Forms.TabControl UserDataPageBook__TabControl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserDataForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UserDataBox__Panel = new System.Windows.Forms.Panel();
            this.UserDataTitle__Label = new System.Windows.Forms.Label();
            this.deleteAccount__Button = new System.Windows.Forms.Button();
            this.UserPhoto__PictureBox = new System.Windows.Forms.PictureBox();
            this.ConfirmEdit__Button = new System.Windows.Forms.Button();
            this.IsAdmin__ListBox = new System.Windows.Forms.ListBox();
            this.Password__TextBox = new System.Windows.Forms.TextBox();
            this.Email__TextBox = new System.Windows.Forms.TextBox();
            this.UserName__TextBox = new System.Windows.Forms.TextBox();
            this.IsAdmin__Label = new System.Windows.Forms.Label();
            this.Password__Label = new System.Windows.Forms.Label();
            this.Email__Label = new System.Windows.Forms.Label();
            this.UserName__Label = new System.Windows.Forms.Label();
            this.UserId__TextBox = new System.Windows.Forms.TextBox();
            this.UserId__Label = new System.Windows.Forms.Label();
            this.inputUsername__Label = new System.Windows.Forms.Label();
            this.inputUsername__TextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cinemaTable__Panel = new System.Windows.Forms.Panel();
            this.UserCinemaTitle__Label = new System.Windows.Forms.Label();
            this.cinemaTable__DataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserDataPageBook__TabControl = new System.Windows.Forms.TabControl();
            UserDataPageBook__TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.UserDataBox__Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto__PictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.cinemaTable__Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaTable__DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataPageBook__TabControl
            // 
            UserDataPageBook__TabControl.Controls.Add(this.tabPage1);
            UserDataPageBook__TabControl.Controls.Add(this.tabPage2);
            UserDataPageBook__TabControl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UserDataPageBook__TabControl.Location = new System.Drawing.Point(12, 0);
            UserDataPageBook__TabControl.Name = "UserDataPageBook__TabControl";
            UserDataPageBook__TabControl.SelectedIndex = 0;
            UserDataPageBook__TabControl.Size = new System.Drawing.Size(874, 488);
            UserDataPageBook__TabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.UserDataBox__Panel);
            this.tabPage1.Controls.Add(this.inputUsername__Label);
            this.tabPage1.Controls.Add(this.inputUsername__TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личная информация";
            // 
            // UserDataBox__Panel
            // 
            this.UserDataBox__Panel.BackColor = System.Drawing.SystemColors.Info;
            this.UserDataBox__Panel.Controls.Add(this.UserDataTitle__Label);
            this.UserDataBox__Panel.Controls.Add(this.deleteAccount__Button);
            this.UserDataBox__Panel.Controls.Add(this.UserPhoto__PictureBox);
            this.UserDataBox__Panel.Controls.Add(this.ConfirmEdit__Button);
            this.UserDataBox__Panel.Controls.Add(this.IsAdmin__ListBox);
            this.UserDataBox__Panel.Controls.Add(this.Password__TextBox);
            this.UserDataBox__Panel.Controls.Add(this.Email__TextBox);
            this.UserDataBox__Panel.Controls.Add(this.UserName__TextBox);
            this.UserDataBox__Panel.Controls.Add(this.IsAdmin__Label);
            this.UserDataBox__Panel.Controls.Add(this.Password__Label);
            this.UserDataBox__Panel.Controls.Add(this.Email__Label);
            this.UserDataBox__Panel.Controls.Add(this.UserName__Label);
            this.UserDataBox__Panel.Controls.Add(this.UserId__TextBox);
            this.UserDataBox__Panel.Controls.Add(this.UserId__Label);
            this.UserDataBox__Panel.Location = new System.Drawing.Point(3, 44);
            this.UserDataBox__Panel.Name = "UserDataBox__Panel";
            this.UserDataBox__Panel.Size = new System.Drawing.Size(860, 416);
            this.UserDataBox__Panel.TabIndex = 5;
            // 
            // UserDataTitle__Label
            // 
            this.UserDataTitle__Label.AutoSize = true;
            this.UserDataTitle__Label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserDataTitle__Label.Location = new System.Drawing.Point(139, 10);
            this.UserDataTitle__Label.Name = "UserDataTitle__Label";
            this.UserDataTitle__Label.Size = new System.Drawing.Size(255, 28);
            this.UserDataTitle__Label.TabIndex = 13;
            this.UserDataTitle__Label.Text = "Личная информация";
            // 
            // deleteAccount__Button
            // 
            this.deleteAccount__Button.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteAccount__Button.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAccount__Button.Location = new System.Drawing.Point(0, 363);
            this.deleteAccount__Button.Name = "deleteAccount__Button";
            this.deleteAccount__Button.Size = new System.Drawing.Size(362, 36);
            this.deleteAccount__Button.TabIndex = 12;
            this.deleteAccount__Button.Text = "Удалить аккаунт";
            this.deleteAccount__Button.UseVisualStyleBackColor = false;
            this.deleteAccount__Button.Click += new System.EventHandler(this.deleteAccount__Button_Click);
            // 
            // UserPhoto__PictureBox
            // 
            this.UserPhoto__PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPhoto__PictureBox.Image")));
            this.UserPhoto__PictureBox.Location = new System.Drawing.Point(15, 10);
            this.UserPhoto__PictureBox.Name = "UserPhoto__PictureBox";
            this.UserPhoto__PictureBox.Size = new System.Drawing.Size(100, 100);
            this.UserPhoto__PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPhoto__PictureBox.TabIndex = 11;
            this.UserPhoto__PictureBox.TabStop = false;
            // 
            // ConfirmEdit__Button
            // 
            this.ConfirmEdit__Button.BackColor = System.Drawing.Color.LightSalmon;
            this.ConfirmEdit__Button.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmEdit__Button.Location = new System.Drawing.Point(0, 321);
            this.ConfirmEdit__Button.Name = "ConfirmEdit__Button";
            this.ConfirmEdit__Button.Size = new System.Drawing.Size(362, 36);
            this.ConfirmEdit__Button.TabIndex = 10;
            this.ConfirmEdit__Button.Text = "Изменить";
            this.ConfirmEdit__Button.UseVisualStyleBackColor = false;
            this.ConfirmEdit__Button.Click += new System.EventHandler(this.ConfirmEdit__Button_Click);
            // 
            // IsAdmin__ListBox
            // 
            this.IsAdmin__ListBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsAdmin__ListBox.FormattingEnabled = true;
            this.IsAdmin__ListBox.ItemHeight = 19;
            this.IsAdmin__ListBox.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.IsAdmin__ListBox.Location = new System.Drawing.Point(166, 258);
            this.IsAdmin__ListBox.Name = "IsAdmin__ListBox";
            this.IsAdmin__ListBox.Size = new System.Drawing.Size(74, 42);
            this.IsAdmin__ListBox.TabIndex = 9;
            // 
            // Password__TextBox
            // 
            this.Password__TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password__TextBox.Location = new System.Drawing.Point(166, 222);
            this.Password__TextBox.Name = "Password__TextBox";
            this.Password__TextBox.Size = new System.Drawing.Size(226, 26);
            this.Password__TextBox.TabIndex = 8;
            // 
            // Email__TextBox
            // 
            this.Email__TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email__TextBox.Location = new System.Drawing.Point(166, 188);
            this.Email__TextBox.Name = "Email__TextBox";
            this.Email__TextBox.Size = new System.Drawing.Size(226, 26);
            this.Email__TextBox.TabIndex = 7;
            // 
            // UserName__TextBox
            // 
            this.UserName__TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserName__TextBox.Location = new System.Drawing.Point(166, 156);
            this.UserName__TextBox.Name = "UserName__TextBox";
            this.UserName__TextBox.Size = new System.Drawing.Size(226, 26);
            this.UserName__TextBox.TabIndex = 6;
            // 
            // IsAdmin__Label
            // 
            this.IsAdmin__Label.AutoSize = true;
            this.IsAdmin__Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsAdmin__Label.Location = new System.Drawing.Point(15, 258);
            this.IsAdmin__Label.Name = "IsAdmin__Label";
            this.IsAdmin__Label.Size = new System.Drawing.Size(129, 19);
            this.IsAdmin__Label.TabIndex = 5;
            this.IsAdmin__Label.Text = "Администратор:";
            // 
            // Password__Label
            // 
            this.Password__Label.AutoSize = true;
            this.Password__Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password__Label.Location = new System.Drawing.Point(15, 225);
            this.Password__Label.Name = "Password__Label";
            this.Password__Label.Size = new System.Drawing.Size(67, 19);
            this.Password__Label.TabIndex = 4;
            this.Password__Label.Text = "Пароль:";
            // 
            // Email__Label
            // 
            this.Email__Label.AutoSize = true;
            this.Email__Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email__Label.Location = new System.Drawing.Point(15, 195);
            this.Email__Label.Name = "Email__Label";
            this.Email__Label.Size = new System.Drawing.Size(81, 19);
            this.Email__Label.TabIndex = 3;
            this.Email__Label.Text = "Эл. почта:";
            // 
            // UserName__Label
            // 
            this.UserName__Label.AutoSize = true;
            this.UserName__Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserName__Label.Location = new System.Drawing.Point(15, 163);
            this.UserName__Label.Name = "UserName__Label";
            this.UserName__Label.Size = new System.Drawing.Size(149, 19);
            this.UserName__Label.TabIndex = 2;
            this.UserName__Label.Text = "Имя пользователя:";
            // 
            // UserId__TextBox
            // 
            this.UserId__TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserId__TextBox.Location = new System.Drawing.Point(166, 118);
            this.UserId__TextBox.Name = "UserId__TextBox";
            this.UserId__TextBox.ReadOnly = true;
            this.UserId__TextBox.Size = new System.Drawing.Size(111, 26);
            this.UserId__TextBox.TabIndex = 1;
            // 
            // UserId__Label
            // 
            this.UserId__Label.AutoSize = true;
            this.UserId__Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserId__Label.Location = new System.Drawing.Point(15, 125);
            this.UserId__Label.Name = "UserId__Label";
            this.UserId__Label.Size = new System.Drawing.Size(100, 19);
            this.UserId__Label.TabIndex = 0;
            this.UserId__Label.Text = "ID аккаунта:";
            // 
            // inputUsername__Label
            // 
            this.inputUsername__Label.AutoSize = true;
            this.inputUsername__Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputUsername__Label.Location = new System.Drawing.Point(12, 9);
            this.inputUsername__Label.Name = "inputUsername__Label";
            this.inputUsername__Label.Size = new System.Drawing.Size(249, 22);
            this.inputUsername__Label.TabIndex = 4;
            this.inputUsername__Label.Text = "Введите имя пользователя:";
            // 
            // inputUsername__TextBox
            // 
            this.inputUsername__TextBox.Location = new System.Drawing.Point(267, 9);
            this.inputUsername__TextBox.Name = "inputUsername__TextBox";
            this.inputUsername__TextBox.Size = new System.Drawing.Size(193, 26);
            this.inputUsername__TextBox.TabIndex = 3;
            this.inputUsername__TextBox.TextChanged += new System.EventHandler(this.inputUsername__TextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cinemaTable__Panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотры фильмов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cinemaTable__Panel
            // 
            this.cinemaTable__Panel.BackColor = System.Drawing.Color.LightSalmon;
            this.cinemaTable__Panel.Controls.Add(this.UserCinemaTitle__Label);
            this.cinemaTable__Panel.Controls.Add(this.cinemaTable__DataGridView);
            this.cinemaTable__Panel.Location = new System.Drawing.Point(3, 3);
            this.cinemaTable__Panel.Name = "cinemaTable__Panel";
            this.cinemaTable__Panel.Size = new System.Drawing.Size(860, 454);
            this.cinemaTable__Panel.TabIndex = 5;
            // 
            // UserCinemaTitle__Label
            // 
            this.UserCinemaTitle__Label.AutoSize = true;
            this.UserCinemaTitle__Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserCinemaTitle__Label.Location = new System.Drawing.Point(229, 9);
            this.UserCinemaTitle__Label.Name = "UserCinemaTitle__Label";
            this.UserCinemaTitle__Label.Size = new System.Drawing.Size(380, 22);
            this.UserCinemaTitle__Label.TabIndex = 14;
            this.UserCinemaTitle__Label.Text = "Информация о просмотренных фильмах";
            // 
            // cinemaTable__DataGridView
            // 
            this.cinemaTable__DataGridView.AllowUserToAddRows = false;
            this.cinemaTable__DataGridView.AllowUserToDeleteRows = false;
            this.cinemaTable__DataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaTable__DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cinemaTable__DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cinemaTable__DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cinemaTable__DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cinemaTable__DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cinemaTable__DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Category,
            this.cinema,
            this.Status,
            this.Description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cinemaTable__DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cinemaTable__DataGridView.Location = new System.Drawing.Point(12, 48);
            this.cinemaTable__DataGridView.MultiSelect = false;
            this.cinemaTable__DataGridView.Name = "cinemaTable__DataGridView";
            this.cinemaTable__DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cinemaTable__DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaTable__DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.cinemaTable__DataGridView.RowTemplate.Height = 25;
            this.cinemaTable__DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cinemaTable__DataGridView.ShowEditingIcon = false;
            this.cinemaTable__DataGridView.ShowRowErrors = false;
            this.cinemaTable__DataGridView.Size = new System.Drawing.Size(819, 398);
            this.cinemaTable__DataGridView.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "№";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // cinema
            // 
            this.cinema.HeaderText = "Фильм";
            this.cinema.Name = "cinema";
            this.cinema.ReadOnly = true;
            this.cinema.Width = 250;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Примечание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 235;
            // 
            // EditUserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(898, 493);
            this.Controls.Add(UserDataPageBook__TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUserDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр и изменение данных пользователя";
            UserDataPageBook__TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.UserDataBox__Panel.ResumeLayout(false);
            this.UserDataBox__Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto__PictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.cinemaTable__Panel.ResumeLayout(false);
            this.cinemaTable__Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaTable__DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel UserDataBox__Panel;
        private System.Windows.Forms.Label UserDataTitle__Label;
        private System.Windows.Forms.Button deleteAccount__Button;
        private System.Windows.Forms.PictureBox UserPhoto__PictureBox;
        private System.Windows.Forms.Button ConfirmEdit__Button;
        private System.Windows.Forms.ListBox IsAdmin__ListBox;
        private System.Windows.Forms.TextBox Password__TextBox;
        private System.Windows.Forms.TextBox Email__TextBox;
        private System.Windows.Forms.TextBox UserName__TextBox;
        private System.Windows.Forms.Label IsAdmin__Label;
        private System.Windows.Forms.Label Password__Label;
        private System.Windows.Forms.Label Email__Label;
        private System.Windows.Forms.Label UserName__Label;
        private System.Windows.Forms.TextBox UserId__TextBox;
        private System.Windows.Forms.Label UserId__Label;
        private System.Windows.Forms.Label inputUsername__Label;
        private System.Windows.Forms.TextBox inputUsername__TextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel cinemaTable__Panel;
        private System.Windows.Forms.Label UserCinemaTitle__Label;
        public System.Windows.Forms.DataGridView cinemaTable__DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}