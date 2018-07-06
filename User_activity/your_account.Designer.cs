namespace Library_Management
{
    partial class your_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(your_account));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblText_Id = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblList_borrowed_books = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblF_Name = new System.Windows.Forms.Label();
            this.lblL_Name = new System.Windows.Forms.Label();
            this.lblRoll_Id = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBorrowed_books = new System.Windows.Forms.Label();
            this.lblF_Name_Text = new System.Windows.Forms.Label();
            this.lblL_Name_Text = new System.Windows.Forms.Label();
            this.lblRoll_Id_Text = new System.Windows.Forms.Label();
            this.lblCategory_Text = new System.Windows.Forms.Label();
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
            this.lblList_borrowed_books.Location = new System.Drawing.Point(297, 286);
            this.lblList_borrowed_books.Name = "lblList_borrowed_books";
            this.lblList_borrowed_books.Size = new System.Drawing.Size(262, 21);
            this.lblList_borrowed_books.TabIndex = 2;
            this.lblList_borrowed_books.Text = "The list of your borrowed books";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.4023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.5977F));
            this.tableLayoutPanel1.Controls.Add(this.lblF_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblL_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRoll_Id, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBorrowed_books, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblF_Name_Text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblL_Name_Text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRoll_Id_Text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory_Text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBorrowed_Books_Text, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(246, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 212);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblF_Name
            // 
            this.lblF_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblF_Name.AutoSize = true;
            this.lblF_Name.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_Name.Location = new System.Drawing.Point(76, 9);
            this.lblF_Name.Name = "lblF_Name";
            this.lblF_Name.Size = new System.Drawing.Size(96, 21);
            this.lblF_Name.TabIndex = 2;
            this.lblF_Name.Text = "First Name";
            this.lblF_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblL_Name
            // 
            this.lblL_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblL_Name.AutoSize = true;
            this.lblL_Name.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL_Name.Location = new System.Drawing.Point(79, 48);
            this.lblL_Name.Name = "lblL_Name";
            this.lblL_Name.Size = new System.Drawing.Size(93, 21);
            this.lblL_Name.TabIndex = 3;
            this.lblL_Name.Text = "Last Name";
            this.lblL_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoll_Id
            // 
            this.lblRoll_Id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoll_Id.AutoSize = true;
            this.lblRoll_Id.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll_Id.Location = new System.Drawing.Point(111, 85);
            this.lblRoll_Id.Name = "lblRoll_Id";
            this.lblRoll_Id.Size = new System.Drawing.Size(61, 21);
            this.lblRoll_Id.TabIndex = 4;
            this.lblRoll_Id.Text = "Roll Id";
            this.lblRoll_Id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(91, 118);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 21);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBorrowed_books
            // 
            this.lblBorrowed_books.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowed_books.AutoSize = true;
            this.lblBorrowed_books.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed_books.Location = new System.Drawing.Point(34, 151);
            this.lblBorrowed_books.Name = "lblBorrowed_books";
            this.lblBorrowed_books.Size = new System.Drawing.Size(138, 21);
            this.lblBorrowed_books.TabIndex = 5;
            this.lblBorrowed_books.Text = "Borrowed Books";
            this.lblBorrowed_books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblF_Name_Text
            // 
            this.lblF_Name_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblF_Name_Text.AutoSize = true;
            this.lblF_Name_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_Name_Text.Location = new System.Drawing.Point(178, 9);
            this.lblF_Name_Text.Name = "lblF_Name_Text";
            this.lblF_Name_Text.Size = new System.Drawing.Size(17, 21);
            this.lblF_Name_Text.TabIndex = 6;
            this.lblF_Name_Text.Text = "-";
            // 
            // lblL_Name_Text
            // 
            this.lblL_Name_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblL_Name_Text.AutoSize = true;
            this.lblL_Name_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL_Name_Text.Location = new System.Drawing.Point(178, 48);
            this.lblL_Name_Text.Name = "lblL_Name_Text";
            this.lblL_Name_Text.Size = new System.Drawing.Size(17, 21);
            this.lblL_Name_Text.TabIndex = 6;
            this.lblL_Name_Text.Text = "-";
            // 
            // lblRoll_Id_Text
            // 
            this.lblRoll_Id_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRoll_Id_Text.AutoSize = true;
            this.lblRoll_Id_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll_Id_Text.Location = new System.Drawing.Point(178, 85);
            this.lblRoll_Id_Text.Name = "lblRoll_Id_Text";
            this.lblRoll_Id_Text.Size = new System.Drawing.Size(17, 21);
            this.lblRoll_Id_Text.TabIndex = 6;
            this.lblRoll_Id_Text.Text = "-";
            // 
            // lblCategory_Text
            // 
            this.lblCategory_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategory_Text.AutoSize = true;
            this.lblCategory_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory_Text.Location = new System.Drawing.Point(178, 118);
            this.lblCategory_Text.Name = "lblCategory_Text";
            this.lblCategory_Text.Size = new System.Drawing.Size(17, 21);
            this.lblCategory_Text.TabIndex = 6;
            this.lblCategory_Text.Text = "-";
            // 
            // lblBorrowed_Books_Text
            // 
            this.lblBorrowed_Books_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBorrowed_Books_Text.AutoSize = true;
            this.lblBorrowed_Books_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed_Books_Text.Location = new System.Drawing.Point(178, 151);
            this.lblBorrowed_Books_Text.Name = "lblBorrowed_Books_Text";
            this.lblBorrowed_Books_Text.Size = new System.Drawing.Size(17, 21);
            this.lblBorrowed_Books_Text.TabIndex = 6;
            this.lblBorrowed_Books_Text.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.no_image;
            this.pictureBox1.Location = new System.Drawing.Point(639, 13);
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
            this.lblNo_Borrow_book.Location = new System.Drawing.Point(279, 70);
            this.lblNo_Borrow_book.Name = "lblNo_Borrow_book";
            this.lblNo_Borrow_book.Size = new System.Drawing.Size(315, 25);
            this.lblNo_Borrow_book.TabIndex = 1;
            this.lblNo_Borrow_book.Text = "You don\'t have borrowed books!";
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
            // your_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 651);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "your_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Account";
            this.Load += new System.EventHandler(this.your_account_Load);
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
        private System.Windows.Forms.Label lblF_Name;
        private System.Windows.Forms.Label lblL_Name;
        private System.Windows.Forms.Label lblRoll_Id;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBorrowed_books;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblF_Name_Text;
        private System.Windows.Forms.Label lblL_Name_Text;
        private System.Windows.Forms.Label lblRoll_Id_Text;
        private System.Windows.Forms.Label lblCategory_Text;
        private System.Windows.Forms.Label lblBorrowed_Books_Text;
        private System.Windows.Forms.DataGridView dataGridViewBorrow_Return_Book;
        private System.Windows.Forms.Label lblText_Id;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNo_Borrow_book;
    }
}