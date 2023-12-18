namespace TextEditor
{
    partial class TextEditorMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MColorText = new System.Windows.Forms.ToolStripMenuItem();
            this.OwnTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorText = new System.Windows.Forms.ToolStripMenuItem();
            this.MColorBG = new System.Windows.Forms.ToolStripMenuItem();
            this.OwnMenuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MText = new System.Windows.Forms.ToolStripMenuItem();
            this.OwnMenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RTBMain = new System.Windows.Forms.RichTextBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.FDOpen = new System.Windows.Forms.OpenFileDialog();
            this.FDSave = new System.Windows.Forms.SaveFileDialog();
            this.InfoProg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.InfoProg});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(229, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MFileOpen,
            this.MFileSave,
            this.MFileNew});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MFileOpen
            // 
            this.MFileOpen.Name = "MFileOpen";
            this.MFileOpen.Size = new System.Drawing.Size(180, 22);
            this.MFileOpen.Text = "Открыть";
            this.MFileOpen.Click += new System.EventHandler(this.MFileOpen_Click);
            // 
            // MFileSave
            // 
            this.MFileSave.Name = "MFileSave";
            this.MFileSave.Size = new System.Drawing.Size(180, 22);
            this.MFileSave.Text = "Сохранить";
            this.MFileSave.Click += new System.EventHandler(this.MFileSave_Click);
            // 
            // MFileNew
            // 
            this.MFileNew.Name = "MFileNew";
            this.MFileNew.Size = new System.Drawing.Size(180, 22);
            this.MFileNew.Text = "Новый документ";
            this.MFileNew.Click += new System.EventHandler(this.MFileNew_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.MText});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MColorText,
            this.MColorBG});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // MColorText
            // 
            this.MColorText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OwnTextColor,
            this.ColorText});
            this.MColorText.Name = "MColorText";
            this.MColorText.Size = new System.Drawing.Size(180, 22);
            this.MColorText.Text = "Цвет шрифта";
            // 
            // OwnTextColor
            // 
            this.OwnTextColor.Name = "OwnTextColor";
            this.OwnTextColor.Size = new System.Drawing.Size(181, 22);
            this.OwnTextColor.Text = "Собственное меню";
            this.OwnTextColor.Click += new System.EventHandler(this.OwnTextColor_Click);
            // 
            // ColorText
            // 
            this.ColorText.Name = "ColorText";
            this.ColorText.Size = new System.Drawing.Size(181, 22);
            this.ColorText.Text = "Обычное меню";
            this.ColorText.Click += new System.EventHandler(this.ColorText_Click);
            // 
            // MColorBG
            // 
            this.MColorBG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OwnMenuColor,
            this.ColorMenu});
            this.MColorBG.Name = "MColorBG";
            this.MColorBG.Size = new System.Drawing.Size(180, 22);
            this.MColorBG.Text = "Цвет фона";
            // 
            // OwnMenuColor
            // 
            this.OwnMenuColor.Name = "OwnMenuColor";
            this.OwnMenuColor.Size = new System.Drawing.Size(181, 22);
            this.OwnMenuColor.Text = "Собственное меню";
            this.OwnMenuColor.Click += new System.EventHandler(this.OwnMenuColor_Click);
            // 
            // ColorMenu
            // 
            this.ColorMenu.Name = "ColorMenu";
            this.ColorMenu.Size = new System.Drawing.Size(181, 22);
            this.ColorMenu.Text = "Обычное меню";
            this.ColorMenu.Click += new System.EventHandler(this.ColorMenu_Click);
            // 
            // MText
            // 
            this.MText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OwnMenuFont,
            this.FontMenu});
            this.MText.Name = "MText";
            this.MText.Size = new System.Drawing.Size(180, 22);
            this.MText.Text = "Шрифт";
            // 
            // OwnMenuFont
            // 
            this.OwnMenuFont.Name = "OwnMenuFont";
            this.OwnMenuFont.Size = new System.Drawing.Size(181, 22);
            this.OwnMenuFont.Text = "Собственное меню";
            this.OwnMenuFont.Click += new System.EventHandler(this.OwnMenuFont_Click);
            // 
            // FontMenu
            // 
            this.FontMenu.Name = "FontMenu";
            this.FontMenu.Size = new System.Drawing.Size(181, 22);
            this.FontMenu.Text = "Обычное меню";
            this.FontMenu.Click += new System.EventHandler(this.FontMenu_Click);
            // 
            // RTBMain
            // 
            this.RTBMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTBMain.Location = new System.Drawing.Point(0, 36);
            this.RTBMain.Name = "RTBMain";
            this.RTBMain.Size = new System.Drawing.Size(932, 447);
            this.RTBMain.TabIndex = 1;
            this.RTBMain.Text = "";
            this.RTBMain.TextChanged += new System.EventHandler(this.RTBMain_TextChanged);
            // 
            // FDOpen
            // 
            this.FDOpen.FileName = "openFileDialog1";
            // 
            // InfoProg
            // 
            this.InfoProg.Name = "InfoProg";
            this.InfoProg.Size = new System.Drawing.Size(94, 20);
            this.InfoProg.Text = "О программе";
            this.InfoProg.Click += new System.EventHandler(this.InfoProg_Click);
            // 
            // TextEditorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 483);
            this.Controls.Add(this.RTBMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(292, 277);
            this.Name = "TextEditorMain";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MFileSave;
        private System.Windows.Forms.ToolStripMenuItem MFileNew;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MColorText;
        private System.Windows.Forms.ToolStripMenuItem MColorBG;
        private System.Windows.Forms.ToolStripMenuItem MText;
        private System.Windows.Forms.RichTextBox RTBMain;
        private System.Windows.Forms.ToolStripMenuItem OwnMenuColor;
        private System.Windows.Forms.ToolStripMenuItem OwnTextColor;
        private System.Windows.Forms.ToolStripMenuItem ColorText;
        private System.Windows.Forms.ToolStripMenuItem ColorMenu;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripMenuItem OwnMenuFont;
        private System.Windows.Forms.ToolStripMenuItem FontMenu;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.OpenFileDialog FDOpen;
        private System.Windows.Forms.SaveFileDialog FDSave;
        private System.Windows.Forms.ToolStripMenuItem InfoProg;
    }
}

