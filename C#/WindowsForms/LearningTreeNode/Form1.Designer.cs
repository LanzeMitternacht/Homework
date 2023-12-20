namespace WindowsFormsApp5
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
            this.TVMain = new System.Windows.Forms.TreeView();
            this.CMGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BMenuGroup = new System.Windows.Forms.Button();
            this.TBNew = new System.Windows.Forms.TextBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.LError = new System.Windows.Forms.Label();
            this.LCheck = new System.Windows.Forms.Label();
            this.BDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TVMain
            // 
            this.TVMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TVMain.HideSelection = false;
            this.TVMain.Location = new System.Drawing.Point(32, 73);
            this.TVMain.Name = "TVMain";
            this.TVMain.Size = new System.Drawing.Size(245, 349);
            this.TVMain.TabIndex = 0;
            // 
            // CMGroup
            // 
            this.CMGroup.Name = "CMGroup";
            this.CMGroup.Size = new System.Drawing.Size(61, 4);
            this.CMGroup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMGroup_ItemClicked);
            // 
            // BMenuGroup
            // 
            this.BMenuGroup.ContextMenuStrip = this.CMGroup;
            this.BMenuGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMenuGroup.Location = new System.Drawing.Point(42, 22);
            this.BMenuGroup.Name = "BMenuGroup";
            this.BMenuGroup.Size = new System.Drawing.Size(113, 36);
            this.BMenuGroup.TabIndex = 2;
            this.BMenuGroup.Text = "Группа ";
            this.BMenuGroup.UseVisualStyleBackColor = true;
            this.BMenuGroup.Click += new System.EventHandler(this.BMenuGroup_Click);
            // 
            // TBNew
            // 
            this.TBNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBNew.Location = new System.Drawing.Point(276, 29);
            this.TBNew.Name = "TBNew";
            this.TBNew.Size = new System.Drawing.Size(283, 29);
            this.TBNew.TabIndex = 3;
            // 
            // BAdd
            // 
            this.BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.Location = new System.Drawing.Point(446, 111);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(113, 36);
            this.BAdd.TabIndex = 4;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // LError
            // 
            this.LError.AutoEllipsis = true;
            this.LError.AutoSize = true;
            this.LError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(3, 0);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(0, 20);
            this.LError.TabIndex = 5;
            // 
            // LCheck
            // 
            this.LCheck.AutoSize = true;
            this.LCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCheck.Location = new System.Drawing.Point(284, 73);
            this.LCheck.Name = "LCheck";
            this.LCheck.Size = new System.Drawing.Size(0, 20);
            this.LCheck.TabIndex = 6;
            // 
            // BDelete
            // 
            this.BDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDelete.Location = new System.Drawing.Point(446, 162);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(113, 36);
            this.BDelete.TabIndex = 7;
            this.BDelete.Text = "Удалить";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LError);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(288, 287);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 100);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // BClose
            // 
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.Location = new System.Drawing.Point(446, 214);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(113, 36);
            this.BClose.TabIndex = 9;
            this.BClose.Text = "Закрыть";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.LCheck);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TBNew);
            this.Controls.Add(this.BMenuGroup);
            this.Controls.Add(this.TVMain);
            this.MaximumSize = new System.Drawing.Size(587, 489);
            this.MinimumSize = new System.Drawing.Size(587, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TVMain;
        private System.Windows.Forms.ContextMenuStrip CMGroup;
        private System.Windows.Forms.Button BMenuGroup;
        private System.Windows.Forms.TextBox TBNew;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.Label LCheck;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BClose;
    }
}

