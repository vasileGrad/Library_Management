namespace Library_Management
{
    partial class book_users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_users));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblText_Id = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblList_borrowed_books = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblYear_Text = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTitle_Text = new System.Windows.Forms.Label();
            this.lblAuthor_Text = new System.Windows.Forms.Label();
            this.lblPublisher_Text = new System.Windows.Forms.Label();
            this.lblLocation_Text = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBorrowed_books = new System.Windows.Forms.Label();
            this.lblBorrowed_Books_Text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNo_Borrow_book = new System.Windows.Forms.Label();
            this.dataGridViewBorrow_Return_Book = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow_Return_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Library_Management.Properties.Resources.BlueTransparent;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.lblText_Id);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.lblList_borrowed_books);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblNo_Borrow_book);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewBorrow_Return_Book);
            this.splitContainer1.Size = new System.Drawing.Size(864, 651);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblText_Id
            // 
            this.lblText_Id.AutoSize = true;
            this.lblText_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblText_Id.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblText_Id.Location = new System.Drawing.Point(82, 45);
            this.lblText_Id.Name = "lblText_Id";
            this.lblText_Id.Size = new System.Drawing.Size(21, 17);
            this.lblText_Id.TabIndex = 4;
            this.lblText_Id.Text = "Id";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(109, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(14, 17);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "-";
            // 
            // lblList_borrowed_books
            // 
            this.lblList_borrowed_books.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblList_borrowed_books.AutoSize = true;
            this.lblList_borrowed_books.BackColor = System.Drawing.Color.Transparent;
            this.lblList_borrowed_books.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList_borrowed_books.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblList_borrowed_books.Location = new System.Drawing.Point(347, 299);
            this.lblList_borrowed_books.Name = "lblList_borrowed_books";
            this.lblList_borrowed_books.Size = new System.Drawing.Size(183, 21);
            this.lblList_borrowed_books.TabIndex = 2;
            this.lblList_borrowed_books.Text = "The list with the users";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.4023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.5977F));
            this.tableLayoutPanel1.Controls.Add(this.lblYear_Text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPublisher, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle_Text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor_Text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPublisher_Text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation_Text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBorrowed_books, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBorrowed_Books_Text, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(169, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 263);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblYear_Text
            // 
            this.lblYear_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYear_Text.AutoSize = true;
            this.lblYear_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear_Text.Location = new System.Drawing.Point(178, 155);
            this.lblYear_Text.Name = "lblYear_Text";
            this.lblYear_Text.Size = new System.Drawing.Size(17, 21);
            this.lblYear_Text.TabIndex = 9;
            this.lblYear_Text.Text = "-";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(123, 155);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(49, 21);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(124, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 21);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(104, 47);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(68, 21);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(84, 83);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(88, 21);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Publisher:";
            this.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle_Text
            // 
            this.lblTitle_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle_Text.AutoSize = true;
            this.lblTitle_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_Text.Location = new System.Drawing.Point(178, 9);
            this.lblTitle_Text.Name = "lblTitle_Text";
            this.lblTitle_Text.Size = new System.Drawing.Size(17, 21);
            this.lblTitle_Text.TabIndex = 6;
            this.lblTitle_Text.Text = "-";
            // 
            // lblAuthor_Text
            // 
            this.lblAuthor_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAuthor_Text.AutoSize = true;
            this.lblAuthor_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor_Text.Location = new System.Drawing.Point(178, 47);
            this.lblAuthor_Text.Name = "lblAuthor_Text";
            this.lblAuthor_Text.Size = new System.Drawing.Size(17, 21);
            this.lblAuthor_Text.TabIndex = 6;
            this.lblAuthor_Text.Text = "-";
            // 
            // lblPublisher_Text
            // 
            this.lblPublisher_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPublisher_Text.AutoSize = true;
            this.lblPublisher_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher_Text.Location = new System.Drawing.Point(178, 83);
            this.lblPublisher_Text.Name = "lblPublisher_Text";
            this.lblPublisher_Text.Size = new System.Drawing.Size(17, 21);
            this.lblPublisher_Text.TabIndex = 6;
            this.lblPublisher_Text.Text = "-";
            // 
            // lblLocation_Text
            // 
            this.lblLocation_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocation_Text.AutoSize = true;
            this.lblLocation_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation_Text.Location = new System.Drawing.Point(178, 118);
            this.lblLocation_Text.Name = "lblLocation_Text";
            this.lblLocation_Text.Size = new System.Drawing.Size(17, 21);
            this.lblLocation_Text.TabIndex = 6;
            this.lblLocation_Text.Text = "-";
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(91, 118);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(81, 21);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBorrowed_books
            // 
            this.lblBorrowed_books.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowed_books.AutoSize = true;
            this.lblBorrowed_books.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed_books.Location = new System.Drawing.Point(30, 192);
            this.lblBorrowed_books.Name = "lblBorrowed_books";
            this.lblBorrowed_books.Size = new System.Drawing.Size(142, 21);
            this.lblBorrowed_books.TabIndex = 5;
            this.lblBorrowed_books.Text = "Borrowed Books:";
            this.lblBorrowed_books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBorrowed_Books_Text
            // 
            this.lblBorrowed_Books_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBorrowed_Books_Text.AutoSize = true;
            this.lblBorrowed_Books_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed_Books_Text.Location = new System.Drawing.Point(178, 192);
            this.lblBorrowed_Books_Text.Name = "lblBorrowed_Books_Text";
            this.lblBorrowed_Books_Text.Size = new System.Drawing.Size(17, 21);
            this.lblBorrowed_Books_Text.TabIndex = 6;
            this.lblBorrowed_Books_Text.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.no_image;
            this.pictureBox1.Location = new System.Drawing.Point(655, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNo_Borrow_book
            // 
            this.lblNo_Borrow_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNo_Borrow_book.AutoSize = true;
            this.lblNo_Borrow_book.BackColor = System.Drawing.Color.Transparent;
            this.lblNo_Borrow_book.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo_Borrow_book.ForeColor = System.Drawing.Color.Maroon;
            this.lblNo_Borrow_book.Location = new System.Drawing.Point(291, 79);
            this.lblNo_Borrow_book.Name = "lblNo_Borrow_book";
            this.lblNo_Borrow_book.Size = new System.Drawing.Size(265, 50);
            this.lblNo_Borrow_book.TabIndex = 1;
            this.lblNo_Borrow_book.Text = "               No users!\r\nThe book wasn\'t borrowed!";
            this.lblNo_Borrow_book.Visible = false;
            // 
            // dataGridViewBorrow_Return_Book
            // 
            this.dataGridViewBorrow_Return_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrow_Return_Book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBorrow_Return_Book.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBorrow_Return_Book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBorrow_Return_Book.Name = "dataGridViewBorrow_Return_Book";
            this.dataGridViewBorrow_Return_Book.Size = new System.Drawing.Size(864, 312);
            this.dataGridViewBorrow_Return_Book.TabIndex = 0;
            // 
            // book_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 651);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "book_users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.book_users_FormClosing);
            this.Load += new System.EventHandler(this.book_users_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow_Return_Book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblList_borrowed_books;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBorrowed_books;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle_Text;
        private System.Windows.Forms.Label lblAuthor_Text;
        private System.Windows.Forms.Label lblPublisher_Text;
        private System.Windows.Forms.Label lblLocation_Text;
        private System.Windows.Forms.Label lblBorrowed_Books_Text;
        private System.Windows.Forms.DataGridView dataGridViewBorrow_Return_Book;
        private System.Windows.Forms.Label lblText_Id;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNo_Borrow_book;
        private System.Windows.Forms.Label lblYear_Text;
        private System.Windows.Forms.Label lblYear;
    }
}