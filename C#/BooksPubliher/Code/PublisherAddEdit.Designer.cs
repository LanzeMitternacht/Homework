namespace BooksPublish
{
    partial class PublisherAddEdit
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
            this.BEnter = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.LPunishber = new System.Windows.Forms.Label();
            this.LAddress = new System.Windows.Forms.Label();
            this.TBPublisher = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BEnter
            // 
            this.BEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEnter.Location = new System.Drawing.Point(42, 164);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(121, 49);
            this.BEnter.TabIndex = 0;
            this.BEnter.Text = "Применить";
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.BEnter_Click);
            // 
            // BClose
            // 
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.Location = new System.Drawing.Point(195, 164);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(121, 49);
            this.BClose.TabIndex = 1;
            this.BClose.Text = "Отменить";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // LPunishber
            // 
            this.LPunishber.AutoSize = true;
            this.LPunishber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPunishber.Location = new System.Drawing.Point(21, 42);
            this.LPunishber.Name = "LPunishber";
            this.LPunishber.Size = new System.Drawing.Size(122, 20);
            this.LPunishber.TabIndex = 2;
            this.LPunishber.Text = "Наименование";
            // 
            // LAddress
            // 
            this.LAddress.AutoSize = true;
            this.LAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAddress.Location = new System.Drawing.Point(21, 91);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(57, 20);
            this.LAddress.TabIndex = 3;
            this.LAddress.Text = "Адрес";
            // 
            // TBPublisher
            // 
            this.TBPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPublisher.Location = new System.Drawing.Point(148, 39);
            this.TBPublisher.Name = "TBPublisher";
            this.TBPublisher.Size = new System.Drawing.Size(197, 26);
            this.TBPublisher.TabIndex = 4;
            // 
            // TBAddress
            // 
            this.TBAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAddress.Location = new System.Drawing.Point(148, 85);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(197, 26);
            this.TBAddress.TabIndex = 5;
            // 
            // PublisherAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 236);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TBPublisher);
            this.Controls.Add(this.LAddress);
            this.Controls.Add(this.LPunishber);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BEnter);
            this.Name = "PublisherAddEdit";
            this.Text = "PunisherAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEnter;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Label LPunishber;
        private System.Windows.Forms.Label LAddress;
        private System.Windows.Forms.TextBox TBPublisher;
        private System.Windows.Forms.TextBox TBAddress;
    }
}