namespace TextEditor
{
    partial class OwnFont
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.LBFont = new System.Windows.Forms.ListBox();
            this.BOk = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шрифт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(179, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер";
            // 
            // TBNumber
            // 
            this.TBNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBNumber.Location = new System.Drawing.Point(250, 24);
            this.TBNumber.MaxLength = 399;
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(105, 26);
            this.TBNumber.TabIndex = 2;
            this.TBNumber.TextChanged += new System.EventHandler(this.TBNumber_TextChanged);
            // 
            // LBFont
            // 
            this.LBFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBFont.FormattingEnabled = true;
            this.LBFont.ItemHeight = 20;
            this.LBFont.Location = new System.Drawing.Point(12, 58);
            this.LBFont.MaximumSize = new System.Drawing.Size(159, 184);
            this.LBFont.MinimumSize = new System.Drawing.Size(159, 184);
            this.LBFont.Name = "LBFont";
            this.LBFont.Size = new System.Drawing.Size(159, 184);
            this.LBFont.TabIndex = 3;
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(250, 94);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(104, 56);
            this.BOk.TabIndex = 4;
            this.BOk.Text = "Применить";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(250, 170);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(104, 56);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Отменить";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // OwnFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 253);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.LBFont);
            this.Controls.Add(this.TBNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OwnFont";
            this.Text = "OwnFont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNumber;
        private System.Windows.Forms.ListBox LBFont;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Button BCancel;
    }
}