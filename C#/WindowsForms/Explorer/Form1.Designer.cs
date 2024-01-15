namespace Explorer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TreeDisk = new System.Windows.Forms.TreeView();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.LVFile = new System.Windows.Forms.ListView();
            this.BBack = new System.Windows.Forms.Button();
            this.BForward = new System.Windows.Forms.Button();
            this.ConMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenConStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitConStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConMenuStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeDisk
            // 
            this.TreeDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeDisk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TreeDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeDisk.Location = new System.Drawing.Point(12, 89);
            this.TreeDisk.MinimumSize = new System.Drawing.Size(251, 433);
            this.TreeDisk.Name = "TreeDisk";
            this.TreeDisk.Size = new System.Drawing.Size(251, 447);
            this.TreeDisk.TabIndex = 0;
            this.TreeDisk.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeDisk_AfterExpand);
            this.TreeDisk.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeDisk_NodeMouseDoubleClick);
            // 
            // TBAddress
            // 
            this.TBAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAddress.Location = new System.Drawing.Point(129, 43);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(771, 26);
            this.TBAddress.TabIndex = 1;
            this.TBAddress.TextChanged += new System.EventHandler(this.TBAddress_TextChanged);
            // 
            // LVFile
            // 
            this.LVFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LVFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LVFile.HideSelection = false;
            this.LVFile.Location = new System.Drawing.Point(278, 89);
            this.LVFile.Name = "LVFile";
            this.LVFile.Size = new System.Drawing.Size(622, 447);
            this.LVFile.TabIndex = 2;
            this.LVFile.UseCompatibleStateImageBehavior = false;
            this.LVFile.ItemActivate += new System.EventHandler(this.LVFile_ItemActivate);
            // 
            // BBack
            // 
            this.BBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBack.Location = new System.Drawing.Point(12, 40);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(41, 35);
            this.BBack.TabIndex = 3;
            this.BBack.Text = "←";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // BForward
            // 
            this.BForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BForward.Location = new System.Drawing.Point(64, 40);
            this.BForward.Name = "BForward";
            this.BForward.Size = new System.Drawing.Size(41, 35);
            this.BForward.TabIndex = 4;
            this.BForward.Text = "→";
            this.BForward.UseVisualStyleBackColor = true;
            this.BForward.Click += new System.EventHandler(this.BForward_Click);
            // 
            // ConMenuStrip
            // 
            this.ConMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.закрытьToolStripMenuItem1});
            this.ConMenuStrip.Name = "ConMenuStrip";
            this.ConMenuStrip.Size = new System.Drawing.Size(122, 48);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(922, 24);
            this.MenuStrip.TabIndex = 6;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenConStripMenuItem,
            this.ExitConStripMenuItem,
            this.ReloadStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenConStripMenuItem
            // 
            this.OpenConStripMenuItem.Name = "OpenConStripMenuItem";
            this.OpenConStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.OpenConStripMenuItem.Text = "Открыть";
            this.OpenConStripMenuItem.Click += new System.EventHandler(this.OpenConStripMenuItem_Click);
            // 
            // ExitConStripMenuItem
            // 
            this.ExitConStripMenuItem.Name = "ExitConStripMenuItem";
            this.ExitConStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ExitConStripMenuItem.Text = "Закрыть";
            this.ExitConStripMenuItem.Click += new System.EventHandler(this.ExitConStripMenuItem_Click);
            // 
            // ReloadStripMenuItem
            // 
            this.ReloadStripMenuItem.Name = "ReloadStripMenuItem";
            this.ReloadStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ReloadStripMenuItem.Text = "Обновить";
            this.ReloadStripMenuItem.Click += new System.EventHandler(this.RefreshStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 558);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.BForward);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.LVFile);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TreeDisk);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ConMenuStrip.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeDisk;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.ListView LVFile;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BForward;
        private System.Windows.Forms.ContextMenuStrip ConMenuStrip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenConStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitConStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReloadStripMenuItem;
    }
}

