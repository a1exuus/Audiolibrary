namespace Audiolibrary
{
    partial class AddBookView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            HeadLabel = new Label();
            AuthorTextBox = new TextBox();
            BooknameTextBox = new TextBox();
            AudioPathTextBox = new TextBox();
            InspectButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeadLabel.ForeColor = SystemColors.ActiveCaption;
            HeadLabel.Location = new Point(233, 23);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(234, 33);
            HeadLabel.TabIndex = 0;
            HeadLabel.Text = "Добавление книги";
            HeadLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(100, 74);
            AuthorTextBox.MaxLength = 120;
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.PlaceholderText = "Имя автора книги";
            AuthorTextBox.Size = new Size(500, 23);
            AuthorTextBox.TabIndex = 1;
            // 
            // BooknameTextBox
            // 
            BooknameTextBox.Location = new Point(100, 103);
            BooknameTextBox.MaxLength = 120;
            BooknameTextBox.Name = "BooknameTextBox";
            BooknameTextBox.PlaceholderText = "Название книги";
            BooknameTextBox.Size = new Size(500, 23);
            BooknameTextBox.TabIndex = 2;
            BooknameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // AudioPathTextBox
            // 
            AudioPathTextBox.Location = new Point(100, 132);
            AudioPathTextBox.MaxLength = 120;
            AudioPathTextBox.Name = "AudioPathTextBox";
            AudioPathTextBox.PlaceholderText = "Путь до аудиокниги";
            AudioPathTextBox.ReadOnly = true;
            AudioPathTextBox.Size = new Size(367, 23);
            AudioPathTextBox.TabIndex = 3;
            // 
            // InspectButton
            // 
            InspectButton.BackColor = SystemColors.ActiveCaption;
            InspectButton.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InspectButton.Location = new Point(473, 132);
            InspectButton.Name = "InspectButton";
            InspectButton.Size = new Size(127, 23);
            InspectButton.TabIndex = 4;
            InspectButton.Text = "Обзор";
            InspectButton.UseVisualStyleBackColor = false;
            InspectButton.Click += InspectButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Title = "Выберите файл аудиокниги";
            // 
            // AddBookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InspectButton);
            Controls.Add(AudioPathTextBox);
            Controls.Add(BooknameTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(HeadLabel);
            Name = "AddBookView";
            Size = new Size(700, 362);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadLabel;
        private TextBox AuthorTextBox;
        private TextBox BooknameTextBox;
        private TextBox AudioPathTextBox;
        private Button InspectButton;
        private OpenFileDialog openFileDialog1;
    }
}
