namespace BooksPublish
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
            this.TabCnt = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksPublishDataSet = new BooksPublish.BooksPublishDataSet();
            this.BDeleteBook = new System.Windows.Forms.Button();
            this.BAddBook = new System.Windows.Forms.Button();
            this.BEditBook = new System.Windows.Forms.Button();
            this.tabAuthors = new System.Windows.Forms.TabPage();
            this.DGVAuthor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDeleteAuthor = new System.Windows.Forms.Button();
            this.BEditAuthor = new System.Windows.Forms.Button();
            this.BAddAuthor = new System.Windows.Forms.Button();
            this.tabPublisher = new System.Windows.Forms.TabPage();
            this.DGVPublisher = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDeletePunisher = new System.Windows.Forms.Button();
            this.BEditPunisher = new System.Windows.Forms.Button();
            this.BAddPunisher = new System.Windows.Forms.Button();
            this.authorTableAdapter = new BooksPublish.BooksPublishDataSetTableAdapters.AuthorTableAdapter();
            this.bookTableAdapter = new BooksPublish.BooksPublishDataSetTableAdapters.BookTableAdapter();
            this.publisherTableAdapter = new BooksPublish.BooksPublishDataSetTableAdapters.PublisherTableAdapter();
            this.TabCnt.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksPublishDataSet)).BeginInit();
            this.tabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.tabPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCnt
            // 
            this.TabCnt.Controls.Add(this.tabBooks);
            this.TabCnt.Controls.Add(this.tabAuthors);
            this.TabCnt.Controls.Add(this.tabPublisher);
            this.TabCnt.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabCnt.Location = new System.Drawing.Point(0, 0);
            this.TabCnt.Name = "TabCnt";
            this.TabCnt.SelectedIndex = 0;
            this.TabCnt.Size = new System.Drawing.Size(800, 438);
            this.TabCnt.TabIndex = 0;
            this.TabCnt.SelectedIndexChanged += new System.EventHandler(this.TabCnt_SelectedIndexChanged);
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.DGVBooks);
            this.tabBooks.Controls.Add(this.BDeleteBook);
            this.tabBooks.Controls.Add(this.BAddBook);
            this.tabBooks.Controls.Add(this.BEditBook);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Size = new System.Drawing.Size(792, 412);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // DGVBooks
            // 
            this.DGVBooks.AutoGenerateColumns = false;
            this.DGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.idAuthorDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idPublisherDataGridViewTextBoxColumn});
            this.DGVBooks.DataSource = this.bookBindingSource;
            this.DGVBooks.Location = new System.Drawing.Point(3, 3);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.Size = new System.Drawing.Size(786, 322);
            this.DGVBooks.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // idAuthorDataGridViewTextBoxColumn
            // 
            this.idAuthorDataGridViewTextBoxColumn.DataPropertyName = "IdAuthor";
            this.idAuthorDataGridViewTextBoxColumn.HeaderText = "IdAuthor";
            this.idAuthorDataGridViewTextBoxColumn.Name = "idAuthorDataGridViewTextBoxColumn";
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // idPublisherDataGridViewTextBoxColumn
            // 
            this.idPublisherDataGridViewTextBoxColumn.DataPropertyName = "IdPublisher";
            this.idPublisherDataGridViewTextBoxColumn.HeaderText = "IdPublisher";
            this.idPublisherDataGridViewTextBoxColumn.Name = "idPublisherDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.booksPublishDataSet;
            // 
            // booksPublishDataSet
            // 
            this.booksPublishDataSet.DataSetName = "BooksPublishDataSet";
            this.booksPublishDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDeleteBook
            // 
            this.BDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDeleteBook.Location = new System.Drawing.Point(586, 347);
            this.BDeleteBook.Name = "BDeleteBook";
            this.BDeleteBook.Size = new System.Drawing.Size(163, 46);
            this.BDeleteBook.TabIndex = 2;
            this.BDeleteBook.Text = "Удалить книгу";
            this.BDeleteBook.UseVisualStyleBackColor = true;
            this.BDeleteBook.Click += new System.EventHandler(this.BDeleteBook_Click);
            // 
            // BAddBook
            // 
            this.BAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddBook.Location = new System.Drawing.Point(27, 347);
            this.BAddBook.Name = "BAddBook";
            this.BAddBook.Size = new System.Drawing.Size(155, 46);
            this.BAddBook.TabIndex = 0;
            this.BAddBook.Text = "Добавить книгу";
            this.BAddBook.UseVisualStyleBackColor = true;
            this.BAddBook.Click += new System.EventHandler(this.BAddBook_Click);
            // 
            // BEditBook
            // 
            this.BEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEditBook.Location = new System.Drawing.Point(284, 347);
            this.BEditBook.Name = "BEditBook";
            this.BEditBook.Size = new System.Drawing.Size(183, 46);
            this.BEditBook.TabIndex = 1;
            this.BEditBook.Text = "Редактировать книгу";
            this.BEditBook.UseVisualStyleBackColor = true;
            this.BEditBook.Click += new System.EventHandler(this.BEditBook_Click);
            // 
            // tabAuthors
            // 
            this.tabAuthors.Controls.Add(this.DGVAuthor);
            this.tabAuthors.Controls.Add(this.BDeleteAuthor);
            this.tabAuthors.Controls.Add(this.BEditAuthor);
            this.tabAuthors.Controls.Add(this.BAddAuthor);
            this.tabAuthors.Location = new System.Drawing.Point(4, 22);
            this.tabAuthors.Name = "tabAuthors";
            this.tabAuthors.Size = new System.Drawing.Size(792, 412);
            this.tabAuthors.TabIndex = 1;
            this.tabAuthors.Text = "Authors";
            this.tabAuthors.UseVisualStyleBackColor = true;
            // 
            // DGVAuthor
            // 
            this.DGVAuthor.AutoGenerateColumns = false;
            this.DGVAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.DGVAuthor.DataSource = this.authorBindingSource;
            this.DGVAuthor.Location = new System.Drawing.Point(8, 12);
            this.DGVAuthor.Name = "DGVAuthor";
            this.DGVAuthor.Size = new System.Drawing.Size(776, 299);
            this.DGVAuthor.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.booksPublishDataSet;
            // 
            // BDeleteAuthor
            // 
            this.BDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDeleteAuthor.Location = new System.Drawing.Point(559, 331);
            this.BDeleteAuthor.Name = "BDeleteAuthor";
            this.BDeleteAuthor.Size = new System.Drawing.Size(155, 46);
            this.BDeleteAuthor.TabIndex = 3;
            this.BDeleteAuthor.Text = "Удалить автора";
            this.BDeleteAuthor.UseVisualStyleBackColor = true;
            this.BDeleteAuthor.Click += new System.EventHandler(this.BDeleteAuthor_Click);
            // 
            // BEditAuthor
            // 
            this.BEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEditAuthor.Location = new System.Drawing.Point(288, 331);
            this.BEditAuthor.Name = "BEditAuthor";
            this.BEditAuthor.Size = new System.Drawing.Size(200, 46);
            this.BEditAuthor.TabIndex = 2;
            this.BEditAuthor.Text = "Редактировать автора";
            this.BEditAuthor.UseVisualStyleBackColor = true;
            this.BEditAuthor.Click += new System.EventHandler(this.BEditAuthor_Click);
            // 
            // BAddAuthor
            // 
            this.BAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddAuthor.Location = new System.Drawing.Point(53, 331);
            this.BAddAuthor.Name = "BAddAuthor";
            this.BAddAuthor.Size = new System.Drawing.Size(155, 46);
            this.BAddAuthor.TabIndex = 1;
            this.BAddAuthor.Text = "Добавить автора";
            this.BAddAuthor.UseVisualStyleBackColor = true;
            this.BAddAuthor.Click += new System.EventHandler(this.BAddAuthor_Click);
            // 
            // tabPublisher
            // 
            this.tabPublisher.Controls.Add(this.DGVPublisher);
            this.tabPublisher.Controls.Add(this.BDeletePunisher);
            this.tabPublisher.Controls.Add(this.BEditPunisher);
            this.tabPublisher.Controls.Add(this.BAddPunisher);
            this.tabPublisher.Location = new System.Drawing.Point(4, 22);
            this.tabPublisher.Name = "tabPublisher";
            this.tabPublisher.Size = new System.Drawing.Size(792, 412);
            this.tabPublisher.TabIndex = 2;
            this.tabPublisher.Text = "Publisher";
            this.tabPublisher.UseVisualStyleBackColor = true;
            // 
            // DGVPublisher
            // 
            this.DGVPublisher.AutoGenerateColumns = false;
            this.DGVPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPublisher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.publisherNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.DGVPublisher.DataSource = this.publisherBindingSource;
            this.DGVPublisher.Location = new System.Drawing.Point(3, 3);
            this.DGVPublisher.Name = "DGVPublisher";
            this.DGVPublisher.Size = new System.Drawing.Size(786, 300);
            this.DGVPublisher.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.booksPublishDataSet;
            // 
            // BDeletePunisher
            // 
            this.BDeletePunisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDeletePunisher.Location = new System.Drawing.Point(565, 323);
            this.BDeletePunisher.Name = "BDeletePunisher";
            this.BDeletePunisher.Size = new System.Drawing.Size(197, 46);
            this.BDeletePunisher.TabIndex = 3;
            this.BDeletePunisher.Text = "Удалить издателя";
            this.BDeletePunisher.UseVisualStyleBackColor = true;
            this.BDeletePunisher.Click += new System.EventHandler(this.BDeletePunisher_Click);
            // 
            // BEditPunisher
            // 
            this.BEditPunisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEditPunisher.Location = new System.Drawing.Point(279, 323);
            this.BEditPunisher.Name = "BEditPunisher";
            this.BEditPunisher.Size = new System.Drawing.Size(244, 46);
            this.BEditPunisher.TabIndex = 2;
            this.BEditPunisher.Text = "Редактировать издателя";
            this.BEditPunisher.UseVisualStyleBackColor = true;
            this.BEditPunisher.Click += new System.EventHandler(this.BEditPunisher_Click);
            // 
            // BAddPunisher
            // 
            this.BAddPunisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddPunisher.Location = new System.Drawing.Point(52, 323);
            this.BAddPunisher.Name = "BAddPunisher";
            this.BAddPunisher.Size = new System.Drawing.Size(183, 46);
            this.BAddPunisher.TabIndex = 1;
            this.BAddPunisher.Text = "Добавить издателя";
            this.BAddPunisher.UseVisualStyleBackColor = true;
            this.BAddPunisher.Click += new System.EventHandler(this.BAddPunisher_Click);
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabCnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabCnt.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksPublishDataSet)).EndInit();
            this.tabAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.tabPublisher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCnt;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabAuthors;
        private System.Windows.Forms.TabPage tabPublisher;
        private System.Windows.Forms.Button BDeleteBook;
        private System.Windows.Forms.Button BEditBook;
        private System.Windows.Forms.Button BAddBook;
        private System.Windows.Forms.Button BDeleteAuthor;
        private System.Windows.Forms.Button BEditAuthor;
        private System.Windows.Forms.Button BAddAuthor;
        private System.Windows.Forms.Button BDeletePunisher;
        private System.Windows.Forms.Button BEditPunisher;
        private System.Windows.Forms.Button BAddPunisher;
        private System.Windows.Forms.DataGridView DGVAuthor;
        private BooksPublishDataSet booksPublishDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private BooksPublishDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DGVBooks;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BooksPublishDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DGVPublisher;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private BooksPublishDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

