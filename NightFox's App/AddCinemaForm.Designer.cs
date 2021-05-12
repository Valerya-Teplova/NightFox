
namespace test
{
    partial class AddCinemaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCinemaForm));
            this.selectCinema__Label = new System.Windows.Forms.Label();
            this.selectCinemaStatus__Label = new System.Windows.Forms.Label();
            this.selectCinemaStatus__ComboBox = new System.Windows.Forms.ComboBox();
            this.inputCinemaDescription__Label = new System.Windows.Forms.Label();
            this.inputCinemaDescription__TextBox = new System.Windows.Forms.TextBox();
            this.addCinema__Button = new System.Windows.Forms.Button();
            this.selectCategory__ComboBox = new System.Windows.Forms.ComboBox();
            this.selectCategory__Label = new System.Windows.Forms.Label();
            this.selectCinema__ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectCinema__Label
            // 
            this.selectCinema__Label.AutoSize = true;
            this.selectCinema__Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCinema__Label.Location = new System.Drawing.Point(53, 89);
            this.selectCinema__Label.Name = "selectCinema__Label";
            this.selectCinema__Label.Size = new System.Drawing.Size(288, 22);
            this.selectCinema__Label.TabIndex = 1;
            this.selectCinema__Label.Text = "Выберите фильм/сериал/аниме";
            // 
            // selectCinemaStatus__Label
            // 
            this.selectCinemaStatus__Label.AutoSize = true;
            this.selectCinemaStatus__Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCinemaStatus__Label.Location = new System.Drawing.Point(53, 155);
            this.selectCinemaStatus__Label.Name = "selectCinemaStatus__Label";
            this.selectCinemaStatus__Label.Size = new System.Drawing.Size(365, 22);
            this.selectCinemaStatus__Label.TabIndex = 3;
            this.selectCinemaStatus__Label.Text = "Выберите статус фильма/сериала/аниме";
            // 
            // selectCinemaStatus__ComboBox
            // 
            this.selectCinemaStatus__ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCinemaStatus__ComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCinemaStatus__ComboBox.FormattingEnabled = true;
            this.selectCinemaStatus__ComboBox.Items.AddRange(new object[] {
            "Просмотрено",
            "Смотрю",
            "Собираюсь посмотреть"});
            this.selectCinemaStatus__ComboBox.Location = new System.Drawing.Point(53, 179);
            this.selectCinemaStatus__ComboBox.Name = "selectCinemaStatus__ComboBox";
            this.selectCinemaStatus__ComboBox.Size = new System.Drawing.Size(361, 27);
            this.selectCinemaStatus__ComboBox.TabIndex = 4;
            // 
            // inputCinemaDescription__Label
            // 
            this.inputCinemaDescription__Label.AutoSize = true;
            this.inputCinemaDescription__Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputCinemaDescription__Label.Location = new System.Drawing.Point(53, 221);
            this.inputCinemaDescription__Label.Name = "inputCinemaDescription__Label";
            this.inputCinemaDescription__Label.Size = new System.Drawing.Size(191, 22);
            this.inputCinemaDescription__Label.TabIndex = 6;
            this.inputCinemaDescription__Label.Text = "Введите примечание";
            // 
            // inputCinemaDescription__TextBox
            // 
            this.inputCinemaDescription__TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputCinemaDescription__TextBox.Location = new System.Drawing.Point(53, 245);
            this.inputCinemaDescription__TextBox.Name = "inputCinemaDescription__TextBox";
            this.inputCinemaDescription__TextBox.PlaceholderText = "Примечание не обязательно";
            this.inputCinemaDescription__TextBox.Size = new System.Drawing.Size(361, 26);
            this.inputCinemaDescription__TextBox.TabIndex = 5;
            // 
            // addCinema__Button
            // 
            this.addCinema__Button.BackColor = System.Drawing.Color.LightSalmon;
            this.addCinema__Button.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCinema__Button.Location = new System.Drawing.Point(313, 292);
            this.addCinema__Button.Name = "addCinema__Button";
            this.addCinema__Button.Size = new System.Drawing.Size(101, 47);
            this.addCinema__Button.TabIndex = 7;
            this.addCinema__Button.Text = "Добавить";
            this.addCinema__Button.UseVisualStyleBackColor = false;
            this.addCinema__Button.Click += new System.EventHandler(this.addCinema__Button_Click);
            // 
            // selectCategory__ComboBox
            // 
            this.selectCategory__ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategory__ComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCategory__ComboBox.FormattingEnabled = true;
            this.selectCategory__ComboBox.Location = new System.Drawing.Point(53, 51);
            this.selectCategory__ComboBox.Name = "selectCategory__ComboBox";
            this.selectCategory__ComboBox.Size = new System.Drawing.Size(361, 27);
            this.selectCategory__ComboBox.TabIndex = 9;
            this.selectCategory__ComboBox.SelectedIndexChanged += new System.EventHandler(this.selectCategory__ComboBox_SelectedIndexChanged);
            // 
            // selectCategory__Label
            // 
            this.selectCategory__Label.AutoSize = true;
            this.selectCategory__Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCategory__Label.Location = new System.Drawing.Point(53, 27);
            this.selectCategory__Label.Name = "selectCategory__Label";
            this.selectCategory__Label.Size = new System.Drawing.Size(193, 22);
            this.selectCategory__Label.TabIndex = 8;
            this.selectCategory__Label.Text = "Выберите категорию";
            // 
            // selectCinema__ComboBox
            // 
            this.selectCinema__ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCinema__ComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCinema__ComboBox.FormattingEnabled = true;
            this.selectCinema__ComboBox.Location = new System.Drawing.Point(53, 114);
            this.selectCinema__ComboBox.Name = "selectCinema__ComboBox";
            this.selectCinema__ComboBox.Size = new System.Drawing.Size(361, 27);
            this.selectCinema__ComboBox.TabIndex = 10;
            // 
            // AddCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(437, 369);
            this.Controls.Add(this.selectCinema__ComboBox);
            this.Controls.Add(this.selectCategory__ComboBox);
            this.Controls.Add(this.selectCategory__Label);
            this.Controls.Add(this.addCinema__Button);
            this.Controls.Add(this.inputCinemaDescription__Label);
            this.Controls.Add(this.inputCinemaDescription__TextBox);
            this.Controls.Add(this.selectCinemaStatus__ComboBox);
            this.Controls.Add(this.selectCinemaStatus__Label);
            this.Controls.Add(this.selectCinema__Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCinemaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фильма в коллекцию";
            this.Load += new System.EventHandler(this.AddCinemaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectCinema__Label;
        private System.Windows.Forms.Label selectCinemaStatus__Label;
        private System.Windows.Forms.ComboBox selectCinemaStatus__ComboBox;
        private System.Windows.Forms.Label inputCinemaDescription__Label;
        private System.Windows.Forms.TextBox inputCinemaDescription__TextBox;
        private System.Windows.Forms.Button addCinema__Button;
        private System.Windows.Forms.ComboBox selectCategory__ComboBox;
        private System.Windows.Forms.Label selectCategory__Label;
        private System.Windows.Forms.ComboBox selectCinema__ComboBox;
    }
}