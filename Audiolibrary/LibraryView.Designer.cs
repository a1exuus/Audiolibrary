namespace Audiolibrary
{
    partial class LibraryView
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
            SearchBox = new TextBox();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBox.ForeColor = SystemColors.GrayText;
            SearchBox.Location = new Point(3, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(559, 26);
            SearchBox.TabIndex = 1;
            SearchBox.Text = "Поиск";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ActiveCaption;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchButton.ForeColor = SystemColors.ActiveCaptionText;
            SearchButton.Location = new Point(568, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(135, 26);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Поиск";
            SearchButton.TextImageRelation = TextImageRelation.TextAboveImage;
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchButton);
            Controls.Add(SearchBox);
            Name = "LibraryView";
            Size = new Size(706, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button SearchButton;
    }
}
