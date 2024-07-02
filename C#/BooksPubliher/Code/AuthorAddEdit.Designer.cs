namespace BooksPublish
{
    partial class AuthorAddEdit
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
            this.LFName = new System.Windows.Forms.Label();
            this.LSName = new System.Windows.Forms.Label();
            this.TBFName = new System.Windows.Forms.TextBox();
            this.TBLName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BEnter
            // 
            this.BEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEnter.Location = new System.Drawing.Point(27, 178);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(123, 46);
            this.BEnter.TabIndex = 0;
            this.BEnter.Text = "Применить";
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.BEnter_Click);
            // 
            // BClose
            // 
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.Location = new System.Drawing.Point(198, 178);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(123, 46);
            this.BClose.TabIndex = 1;
            this.BClose.Text = "Отменить";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // LFName
            // 
            this.LFName.AutoSize = true;
            this.LFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LFName.Location = new System.Drawing.Point(27, 39);
            this.LFName.Name = "LFName";
            this.LFName.Size = new System.Drawing.Size(81, 20);
            this.LFName.TabIndex = 2;
            this.LFName.Text = "Фамилия";
            // 
            // LSName
            // 
            this.LSName.AutoSize = true;
            this.LSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSName.Location = new System.Drawing.Point(27, 92);
            this.LSName.Name = "LSName";
            this.LSName.Size = new System.Drawing.Size(40, 20);
            this.LSName.TabIndex = 3;
            this.LSName.Text = "Имя";
            // 
            // TBFName
            // 
            this.TBFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBFName.Location = new System.Drawing.Point(137, 39);
            this.TBFName.Name = "TBFName";
            this.TBFName.Size = new System.Drawing.Size(173, 26);
            this.TBFName.TabIndex = 4;
            // 
            // TBLName
            // 
            this.TBLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLName.Location = new System.Drawing.Point(137, 92);
            this.TBLName.Name = "TBLName";
            this.TBLName.Size = new System.Drawing.Size(173, 26);
            this.TBLName.TabIndex = 5;
            // 
            // AuthorAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 248);
            this.Controls.Add(this.TBLName);
            this.Controls.Add(this.TBFName);
            this.Controls.Add(this.LSName);
            this.Controls.Add(this.LFName);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BEnter);
            this.Name = "AuthorAddEdit";
            this.Text = "AutorAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEnter;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Label LFName;
        private System.Windows.Forms.Label LSName;
        private System.Windows.Forms.TextBox TBFName;
        private System.Windows.Forms.TextBox TBLName;
    }
}