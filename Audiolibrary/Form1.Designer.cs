namespace Audiolibrary
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            PanelMenu = new Panel();
            ButtonAdd = new Button();
            ButtonSettings = new Button();
            ButtonFavorites = new Button();
            ButtonLibrary = new Button();
            PanelMiniPlayer = new Panel();
            panelContent = new Panel();
            FlowLayoutPanel = new FlowLayoutPanel();
            SearchButton = new Button();
            SearchBox = new TextBox();
            NameLabel = new Label();
            PanelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(ButtonAdd);
            PanelMenu.Controls.Add(ButtonSettings);
            PanelMenu.Controls.Add(ButtonFavorites);
            PanelMenu.Controls.Add(ButtonLibrary);
            PanelMenu.Location = new Point(12, 68);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(230, 400);
            PanelMenu.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(3, 339);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(224, 35);
            ButtonAdd.TabIndex = 3;
            ButtonAdd.Text = "Добавить аудиофайл";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonSettings
            // 
            ButtonSettings.Location = new Point(3, 127);
            ButtonSettings.Name = "ButtonSettings";
            ButtonSettings.Size = new Size(224, 35);
            ButtonSettings.TabIndex = 2;
            ButtonSettings.Text = "Настройки";
            ButtonSettings.UseVisualStyleBackColor = true;
            // 
            // ButtonFavorites
            // 
            ButtonFavorites.Location = new Point(3, 71);
            ButtonFavorites.Name = "ButtonFavorites";
            ButtonFavorites.Size = new Size(224, 35);
            ButtonFavorites.TabIndex = 1;
            ButtonFavorites.Text = "Избранные";
            ButtonFavorites.UseVisualStyleBackColor = true;
            // 
            // ButtonLibrary
            // 
            ButtonLibrary.Location = new Point(3, 15);
            ButtonLibrary.Name = "ButtonLibrary";
            ButtonLibrary.Size = new Size(224, 35);
            ButtonLibrary.TabIndex = 0;
            ButtonLibrary.Text = "Библиотека";
            ButtonLibrary.UseVisualStyleBackColor = true;
            ButtonLibrary.Click += ButtonLibrary_Click;
            // 
            // PanelMiniPlayer
            // 
            PanelMiniPlayer.Location = new Point(12, 474);
            PanelMiniPlayer.Name = "PanelMiniPlayer";
            PanelMiniPlayer.Size = new Size(942, 90);
            PanelMiniPlayer.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(FlowLayoutPanel);
            panelContent.Controls.Add(SearchButton);
            panelContent.Controls.Add(SearchBox);
            panelContent.Location = new Point(248, 68);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(706, 400);
            panelContent.TabIndex = 3;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.Location = new Point(3, 35);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(700, 362);
            FlowLayoutPanel.TabIndex = 2;
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
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Поиск";
            SearchButton.TextImageRelation = TextImageRelation.TextAboveImage;
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBox.ForeColor = SystemColors.GrayText;
            SearchBox.Location = new Point(3, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(559, 26);
            SearchBox.TabIndex = 0;
            SearchBox.Text = "Поиск";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Calibri", 30.75F);
            NameLabel.ForeColor = SystemColors.ActiveCaption;
            NameLabel.Location = new Point(12, 15);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(227, 50);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Audiolibrary";
            NameLabel.Click += NameLabel_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 576);
            Controls.Add(NameLabel);
            Controls.Add(panelContent);
            Controls.Add(PanelMiniPlayer);
            Controls.Add(PanelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Библиотека аудиокниг";
            Load += Form1_Load;
            PanelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelMiniPlayer;
        private Panel panelContent;
        private Label NameLabel;
        private TextBox SearchBox;
        private Button SearchButton;
        private Button ButtonSettings;
        private Button ButtonFavorites;
        private Button ButtonLibrary;
        private FlowLayoutPanel FlowLayoutPanel;
        private Button ButtonAdd;
    }
}
