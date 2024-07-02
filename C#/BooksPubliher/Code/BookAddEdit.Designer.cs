namespace BooksPublish
{
    partial class BookAddEdit
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
            this.LName = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LIdAutor = new System.Windows.Forms.Label();
            this.LCountPages = new System.Windows.Forms.Label();
            this.LPriceBook = new System.Windows.Forms.Label();
            this.LIdPunisher = new System.Windows.Forms.Label();
            this.TBIdAutor = new System.Windows.Forms.TextBox();
            this.TBCountPages = new System.Windows.Forms.TextBox();
            this.TBPriceBook = new System.Windows.Forms.TextBox();
            this.TBPunisher = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BEnter
            // 
            this.BEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEnter.Location = new System.Drawing.Point(54, 385);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(130, 49);
            this.BEnter.TabIndex = 0;
            this.BEnter.Text = "Применить";
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.BEnter_Click);
            // 
            // BClose
            // 
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.Location = new System.Drawing.Point(234, 385);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(130, 49);
            this.BClose.TabIndex = 1;
            this.BClose.Text = "Отменить";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(25, 36);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(129, 20);
            this.LName.TabIndex = 2;
            this.LName.Text = "Название книги";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.Location = new System.Drawing.Point(198, 33);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(225, 26);
            this.TBName.TabIndex = 3;
            // 
            // LIdAutor
            // 
            this.LIdAutor.AutoSize = true;
            this.LIdAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LIdAutor.Location = new System.Drawing.Point(25, 97);
            this.LIdAutor.Name = "LIdAutor";
            this.LIdAutor.Size = new System.Drawing.Size(81, 20);
            this.LIdAutor.TabIndex = 4;
            this.LIdAutor.Text = "Id автора";
            // 
            // LCountPages
            // 
            this.LCountPages.AutoSize = true;
            this.LCountPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCountPages.Location = new System.Drawing.Point(25, 164);
            this.LCountPages.Name = "LCountPages";
            this.LCountPages.Size = new System.Drawing.Size(166, 20);
            this.LCountPages.TabIndex = 5;
            this.LCountPages.Text = "Количество страниц";
            // 
            // LPriceBook
            // 
            this.LPriceBook.AutoSize = true;
            this.LPriceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPriceBook.Location = new System.Drawing.Point(25, 235);
            this.LPriceBook.Name = "LPriceBook";
            this.LPriceBook.Size = new System.Drawing.Size(94, 20);
            this.LPriceBook.TabIndex = 6;
            this.LPriceBook.Text = "Цена книги";
            // 
            // LIdPunisher
            // 
            this.LIdPunisher.AutoSize = true;
            this.LIdPunisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LIdPunisher.Location = new System.Drawing.Point(25, 309);
            this.LIdPunisher.Name = "LIdPunisher";
            this.LIdPunisher.Size = new System.Drawing.Size(101, 20);
            this.LIdPunisher.TabIndex = 7;
            this.LIdPunisher.Text = "Id издателя";
            // 
            // TBIdAutor
            // 
            this.TBIdAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBIdAutor.Location = new System.Drawing.Point(198, 94);
            this.TBIdAutor.Name = "TBIdAutor";
            this.TBIdAutor.Size = new System.Drawing.Size(225, 26);
            this.TBIdAutor.TabIndex = 8;
            // 
            // TBCountPages
            // 
            this.TBCountPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCountPages.Location = new System.Drawing.Point(198, 161);
            this.TBCountPages.Name = "TBCountPages";
            this.TBCountPages.Size = new System.Drawing.Size(225, 26);
            this.TBCountPages.TabIndex = 9;
            // 
            // TBPriceBook
            // 
            this.TBPriceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPriceBook.Location = new System.Drawing.Point(198, 232);
            this.TBPriceBook.Name = "TBPriceBook";
            this.TBPriceBook.Size = new System.Drawing.Size(225, 26);
            this.TBPriceBook.TabIndex = 10;
            // 
            // TBPunisher
            // 
            this.TBPunisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPunisher.Location = new System.Drawing.Point(198, 306);
            this.TBPunisher.Name = "TBPunisher";
            this.TBPunisher.Size = new System.Drawing.Size(225, 26);
            this.TBPunisher.TabIndex = 11;
            // 
            // BookAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 458);
            this.Controls.Add(this.TBPunisher);
            this.Controls.Add(this.TBPriceBook);
            this.Controls.Add(this.TBCountPages);
            this.Controls.Add(this.TBIdAutor);
            this.Controls.Add(this.LIdPunisher);
            this.Controls.Add(this.LPriceBook);
            this.Controls.Add(this.LCountPages);
            this.Controls.Add(this.LIdAutor);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BEnter);
            this.Name = "BookAddEdit";
            this.Text = "BookAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEnter;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LIdAutor;
        private System.Windows.Forms.Label LCountPages;
        private System.Windows.Forms.Label LPriceBook;
        private System.Windows.Forms.Label LIdPunisher;
        private System.Windows.Forms.TextBox TBIdAutor;
        private System.Windows.Forms.TextBox TBCountPages;
        private System.Windows.Forms.TextBox TBPriceBook;
        private System.Windows.Forms.TextBox TBPunisher;
    }
}