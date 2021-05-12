
namespace test
{
    partial class UserRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoomForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userName__Label = new System.Windows.Forms.Label();
            this.addCinema__Button = new System.Windows.Forms.Button();
            this.editCinema__Button = new System.Windows.Forms.Button();
            this.userPhoto__RoundPictureBox = new test.RoundPictureBox();
            this.deleteCinemaButton = new System.Windows.Forms.Button();
            this.cinemaTable__DataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenAdminPanel__Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto__RoundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaTable__DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userName__Label
            // 
            this.userName__Label.AutoSize = true;
            this.userName__Label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.userName__Label.Location = new System.Drawing.Point(130, 32);
            this.userName__Label.Name = "userName__Label";
            this.userName__Label.Size = new System.Drawing.Size(214, 28);
            this.userName__Label.TabIndex = 1;
            this.userName__Label.Text = "Имя пользователя";
            // 
            // addCinema__Button
            // 
            this.addCinema__Button.BackColor = System.Drawing.Color.LightSalmon;
            this.addCinema__Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCinema__Button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCinema__Button.Location = new System.Drawing.Point(41, 165);
            this.addCinema__Button.Name = "addCinema__Button";
            this.addCinema__Button.Size = new System.Drawing.Size(101, 47);
            this.addCinema__Button.TabIndex = 2;
            this.addCinema__Button.Text = "Добавить";
            this.addCinema__Button.UseVisualStyleBackColor = false;
            this.addCinema__Button.Click += new System.EventHandler(this.addCinema__Button_Click);
            // 
            // editCinema__Button
            // 
            this.editCinema__Button.BackColor = System.Drawing.Color.LightSalmon;
            this.editCinema__Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCinema__Button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCinema__Button.Location = new System.Drawing.Point(783, 165);
            this.editCinema__Button.Name = "editCinema__Button";
            this.editCinema__Button.Size = new System.Drawing.Size(108, 47);
            this.editCinema__Button.TabIndex = 3;
            this.editCinema__Button.Text = "Изменить";
            this.editCinema__Button.UseVisualStyleBackColor = false;
            this.editCinema__Button.Click += new System.EventHandler(this.editCinema__Button_Click);
            // 
            // userPhoto__RoundPictureBox
            // 
            this.userPhoto__RoundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPhoto__RoundPictureBox.Image")));
            this.userPhoto__RoundPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("userPhoto__RoundPictureBox.InitialImage")));
            this.userPhoto__RoundPictureBox.Location = new System.Drawing.Point(12, 32);
            this.userPhoto__RoundPictureBox.Name = "userPhoto__RoundPictureBox";
            this.userPhoto__RoundPictureBox.Size = new System.Drawing.Size(112, 103);
            this.userPhoto__RoundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPhoto__RoundPictureBox.TabIndex = 0;
            this.userPhoto__RoundPictureBox.TabStop = false;
            this.userPhoto__RoundPictureBox.Click += new System.EventHandler(this.userPhoto__RoundPictureBox_Click);
            // 
            // deleteCinemaButton
            // 
            this.deleteCinemaButton.BackColor = System.Drawing.Color.LightSalmon;
            this.deleteCinemaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCinemaButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCinemaButton.Location = new System.Drawing.Point(790, 611);
            this.deleteCinemaButton.Name = "deleteCinemaButton";
            this.deleteCinemaButton.Size = new System.Drawing.Size(101, 44);
            this.deleteCinemaButton.TabIndex = 5;
            this.deleteCinemaButton.Text = "Удалить";
            this.deleteCinemaButton.UseVisualStyleBackColor = false;
            this.deleteCinemaButton.Click += new System.EventHandler(this.deleteCinemaButton_Click);
            // 
            // cinemaTable__DataGridView
            // 
            this.cinemaTable__DataGridView.AllowUserToAddRows = false;
            this.cinemaTable__DataGridView.AllowUserToDeleteRows = false;
            this.cinemaTable__DataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaTable__DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cinemaTable__DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cinemaTable__DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.cinemaTable__DataGridView.Location = new System.Drawing.Point(41, 218);
            this.cinemaTable__DataGridView.MultiSelect = false;
            this.cinemaTable__DataGridView.Name = "cinemaTable__DataGridView";
            this.cinemaTable__DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaTable__DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cinemaTable__DataGridView.RowTemplate.Height = 25;
            this.cinemaTable__DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cinemaTable__DataGridView.ShowEditingIcon = false;
            this.cinemaTable__DataGridView.ShowRowErrors = false;
            this.cinemaTable__DataGridView.Size = new System.Drawing.Size(850, 387);
            this.cinemaTable__DataGridView.TabIndex = 0;
            this.cinemaTable__DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cinemaTable__DataGridView_CellClick);
            this.cinemaTable__DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cinemaTable__DataGridView_CellContentClick);
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
            this.Status.Width = 180;
            // 
            // Description
            // 
            this.Description.HeaderText = "Примечание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 235;
            // 
            // OpenAdminPanel__Button
            // 
            this.OpenAdminPanel__Button.BackColor = System.Drawing.Color.DarkOrange;
            this.OpenAdminPanel__Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAdminPanel__Button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAdminPanel__Button.Location = new System.Drawing.Point(739, 31);
            this.OpenAdminPanel__Button.Name = "OpenAdminPanel__Button";
            this.OpenAdminPanel__Button.Size = new System.Drawing.Size(152, 35);
            this.OpenAdminPanel__Button.TabIndex = 6;
            this.OpenAdminPanel__Button.Text = "Админ-панель";
            this.OpenAdminPanel__Button.UseVisualStyleBackColor = false;
            this.OpenAdminPanel__Button.Visible = false;
            this.OpenAdminPanel__Button.Click += new System.EventHandler(this.OpenAdminPanel__Button_Click);
            // 
            // UserRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(935, 667);
            this.Controls.Add(this.OpenAdminPanel__Button);
            this.Controls.Add(this.cinemaTable__DataGridView);
            this.Controls.Add(this.deleteCinemaButton);
            this.Controls.Add(this.userPhoto__RoundPictureBox);
            this.Controls.Add(this.editCinema__Button);
            this.Controls.Add(this.addCinema__Button);
            this.Controls.Add(this.userName__Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRoomForm";
            this.Text = "Личный кабинет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserRoomForm_FormClosed);
            this.Load += new System.EventHandler(this.UserRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto__RoundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaTable__DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addCinema__Button;
        private System.Windows.Forms.Button editCinema__Button;
        private System.Windows.Forms.Button deleteCinemaButton;
        public System.Windows.Forms.DataGridView cinemaTable__DataGridView;
        private System.Windows.Forms.Button OpenAdminPanel__Button;
        public System.Windows.Forms.Label userName__Label;
        public RoundPictureBox userPhoto__RoundPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}