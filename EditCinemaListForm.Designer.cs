
namespace test
{
    partial class EditCinemaListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCinemaListForm));
            this.selectCategory__ComboBox = new System.Windows.Forms.ComboBox();
            this.selectCategory__Label = new System.Windows.Forms.Label();
            this.InputCinemaName__Label = new System.Windows.Forms.Label();
            this.InputCinemaName__TextBox = new System.Windows.Forms.TextBox();
            this.InputCinemaDescription__TextBox = new System.Windows.Forms.TextBox();
            this.InputCinemaDescription__Label = new System.Windows.Forms.Label();
            this.AddNewCinema__Button = new System.Windows.Forms.Button();
            this.cinemaTable__DataGridView = new System.Windows.Forms.DataGridView();
            this.cinema_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinema_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinema_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinema_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCinemaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaTable__DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCategory__ComboBox
            // 
            this.selectCategory__ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategory__ComboBox.FormattingEnabled = true;
            this.selectCategory__ComboBox.Location = new System.Drawing.Point(12, 33);
            this.selectCategory__ComboBox.Name = "selectCategory__ComboBox";
            this.selectCategory__ComboBox.Size = new System.Drawing.Size(257, 23);
            this.selectCategory__ComboBox.TabIndex = 11;
            // 
            // selectCategory__Label
            // 
            this.selectCategory__Label.AutoSize = true;
            this.selectCategory__Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCategory__Label.Location = new System.Drawing.Point(12, 9);
            this.selectCategory__Label.Name = "selectCategory__Label";
            this.selectCategory__Label.Size = new System.Drawing.Size(161, 21);
            this.selectCategory__Label.TabIndex = 10;
            this.selectCategory__Label.Text = "Выберите категорию";
            // 
            // InputCinemaName__Label
            // 
            this.InputCinemaName__Label.AutoSize = true;
            this.InputCinemaName__Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputCinemaName__Label.Location = new System.Drawing.Point(12, 85);
            this.InputCinemaName__Label.Name = "InputCinemaName__Label";
            this.InputCinemaName__Label.Size = new System.Drawing.Size(197, 21);
            this.InputCinemaName__Label.TabIndex = 12;
            this.InputCinemaName__Label.Text = "Введите название фильма";
            // 
            // InputCinemaName__TextBox
            // 
            this.InputCinemaName__TextBox.Location = new System.Drawing.Point(12, 109);
            this.InputCinemaName__TextBox.Name = "InputCinemaName__TextBox";
            this.InputCinemaName__TextBox.Size = new System.Drawing.Size(257, 23);
            this.InputCinemaName__TextBox.TabIndex = 13;
            // 
            // InputCinemaDescription__TextBox
            // 
            this.InputCinemaDescription__TextBox.Location = new System.Drawing.Point(12, 180);
            this.InputCinemaDescription__TextBox.Name = "InputCinemaDescription__TextBox";
            this.InputCinemaDescription__TextBox.Size = new System.Drawing.Size(257, 23);
            this.InputCinemaDescription__TextBox.TabIndex = 15;
            // 
            // InputCinemaDescription__Label
            // 
            this.InputCinemaDescription__Label.AutoSize = true;
            this.InputCinemaDescription__Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputCinemaDescription__Label.Location = new System.Drawing.Point(16, 156);
            this.InputCinemaDescription__Label.Name = "InputCinemaDescription__Label";
            this.InputCinemaDescription__Label.Size = new System.Drawing.Size(199, 21);
            this.InputCinemaDescription__Label.TabIndex = 14;
            this.InputCinemaDescription__Label.Text = "Введите описание фильма";
            // 
            // AddNewCinema__Button
            // 
            this.AddNewCinema__Button.BackColor = System.Drawing.Color.Plum;
            this.AddNewCinema__Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewCinema__Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewCinema__Button.Location = new System.Drawing.Point(12, 224);
            this.AddNewCinema__Button.Name = "AddNewCinema__Button";
            this.AddNewCinema__Button.Size = new System.Drawing.Size(93, 35);
            this.AddNewCinema__Button.TabIndex = 16;
            this.AddNewCinema__Button.Text = "Добавить";
            this.AddNewCinema__Button.UseVisualStyleBackColor = false;
            this.AddNewCinema__Button.Click += new System.EventHandler(this.AddNewCinema__Button_Click);
            // 
            // cinemaTable__DataGridView
            // 
            this.cinemaTable__DataGridView.AllowUserToAddRows = false;
            this.cinemaTable__DataGridView.AllowUserToDeleteRows = false;
            this.cinemaTable__DataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaTable__DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cinemaTable__DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cinemaTable__DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cinemaTable__DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cinemaTable__DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cinemaTable__DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinema_id,
            this.cinema_category,
            this.cinema_name,
            this.cinema_description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cinemaTable__DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cinemaTable__DataGridView.Location = new System.Drawing.Point(310, 9);
            this.cinemaTable__DataGridView.MultiSelect = false;
            this.cinemaTable__DataGridView.Name = "cinemaTable__DataGridView";
            this.cinemaTable__DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinemaTable__DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.cinemaTable__DataGridView.RowTemplate.Height = 25;
            this.cinemaTable__DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cinemaTable__DataGridView.ShowEditingIcon = false;
            this.cinemaTable__DataGridView.ShowRowErrors = false;
            this.cinemaTable__DataGridView.Size = new System.Drawing.Size(668, 387);
            this.cinemaTable__DataGridView.TabIndex = 17;
            this.cinemaTable__DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cinemaTable__DataGridView_CellClick);
            // 
            // cinema_id
            // 
            this.cinema_id.HeaderText = "№";
            this.cinema_id.Name = "cinema_id";
            this.cinema_id.ReadOnly = true;
            this.cinema_id.Width = 40;
            // 
            // cinema_category
            // 
            this.cinema_category.HeaderText = "Категория";
            this.cinema_category.Name = "cinema_category";
            this.cinema_category.ReadOnly = true;
            // 
            // cinema_name
            // 
            this.cinema_name.HeaderText = "Фильм";
            this.cinema_name.Name = "cinema_name";
            this.cinema_name.ReadOnly = true;
            this.cinema_name.Width = 250;
            // 
            // cinema_description
            // 
            this.cinema_description.HeaderText = "Примечание";
            this.cinema_description.Name = "cinema_description";
            this.cinema_description.ReadOnly = true;
            this.cinema_description.Width = 235;
            // 
            // deleteCinemaButton
            // 
            this.deleteCinemaButton.BackColor = System.Drawing.Color.MediumPurple;
            this.deleteCinemaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCinemaButton.Location = new System.Drawing.Point(877, 417);
            this.deleteCinemaButton.Name = "deleteCinemaButton";
            this.deleteCinemaButton.Size = new System.Drawing.Size(101, 44);
            this.deleteCinemaButton.TabIndex = 18;
            this.deleteCinemaButton.Text = "Удалить";
            this.deleteCinemaButton.UseVisualStyleBackColor = false;
            this.deleteCinemaButton.Click += new System.EventHandler(this.deleteCinemaButton_Click);
            // 
            // EditCinemaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1007, 478);
            this.Controls.Add(this.cinemaTable__DataGridView);
            this.Controls.Add(this.deleteCinemaButton);
            this.Controls.Add(this.AddNewCinema__Button);
            this.Controls.Add(this.InputCinemaDescription__TextBox);
            this.Controls.Add(this.InputCinemaDescription__Label);
            this.Controls.Add(this.InputCinemaName__TextBox);
            this.Controls.Add(this.InputCinemaName__Label);
            this.Controls.Add(this.selectCategory__ComboBox);
            this.Controls.Add(this.selectCategory__Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCinemaListForm";
            this.Text = "Редактирование новых фильмов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCinemaListForm_FormClosed);
            this.Load += new System.EventHandler(this.EditListCinemaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaTable__DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCategory__ComboBox;
        private System.Windows.Forms.Label selectCategory__Label;
        private System.Windows.Forms.Label InputCinemaName__Label;
        private System.Windows.Forms.TextBox InputCinemaName__TextBox;
        private System.Windows.Forms.TextBox InputCinemaDescription__TextBox;
        private System.Windows.Forms.Label InputCinemaDescription__Label;
        private System.Windows.Forms.Button AddNewCinema__Button;
        public System.Windows.Forms.DataGridView cinemaTable__DataGridView;
        private System.Windows.Forms.Button deleteCinemaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinema_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinema_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinema_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinema_description;
    }
}