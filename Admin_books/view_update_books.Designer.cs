namespace Library_Management
{
    partial class view_update_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_update_books));
            this.lblUpdateBooks = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVolumes = new System.Windows.Forms.Label();
            this.lblNr_Books = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblFreeBooks = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.lblISBN_NO = new System.Windows.Forms.Label();
            this.lblNr_Inventory = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.comType = new System.Windows.Forms.ComboBox();
            this.numVolumes = new System.Windows.Forms.NumericUpDown();
            this.numBooks = new System.Windows.Forms.NumericUpDown();
            this.comAvailable = new System.Windows.Forms.ComboBox();
            this.numFree_Books = new System.Windows.Forms.NumericUpDown();
            this.numBorrowed_Books = new System.Windows.Forms.NumericUpDown();
            this.txtISBN_NO = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblID_Book = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFree_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorrowed_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdateBooks
            // 
            this.lblUpdateBooks.AutoSize = true;
            this.lblUpdateBooks.Location = new System.Drawing.Point(276, 24);
            this.lblUpdateBooks.Name = "lblUpdateBooks";
            this.lblUpdateBooks.Size = new System.Drawing.Size(118, 21);
            this.lblUpdateBooks.TabIndex = 0;
            this.lblUpdateBooks.Text = "Update Books";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBrowse, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(432, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.72277F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.27723F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(135, 202);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Location = new System.Drawing.Point(24, 163);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(87, 32);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.no_book;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.13475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.86525F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPublisher, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblType, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblVolumes, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblNr_Books, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblAvailable, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblFreeBooks, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblBorrowed, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblISBN_NO, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblNr_Inventory, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPublisher, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLocation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comType, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numVolumes, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numBooks, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.comAvailable, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.numFree_Books, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.numBorrowed_Books, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtISBN_NO, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtInventory, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.numYear, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 526);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.AutoSize = true;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(79, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAuthor.Location = new System.Drawing.Point(59, 42);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(64, 21);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPublisher.Location = new System.Drawing.Point(39, 78);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(84, 21);
            this.lblPublisher.TabIndex = 2;
            this.lblPublisher.Text = "Publisher";
            this.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLocation.AutoSize = true;
            this.lblLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLocation.Location = new System.Drawing.Point(46, 114);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(77, 21);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYear.AutoSize = true;
            this.lblYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblYear.Location = new System.Drawing.Point(78, 150);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 21);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblType.Location = new System.Drawing.Point(76, 186);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 21);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolumes
            // 
            this.lblVolumes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVolumes.AutoSize = true;
            this.lblVolumes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVolumes.Location = new System.Drawing.Point(45, 222);
            this.lblVolumes.Name = "lblVolumes";
            this.lblVolumes.Size = new System.Drawing.Size(78, 21);
            this.lblVolumes.TabIndex = 6;
            this.lblVolumes.Text = "Volumes";
            this.lblVolumes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNr_Books
            // 
            this.lblNr_Books.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNr_Books.AutoSize = true;
            this.lblNr_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNr_Books.Location = new System.Drawing.Point(41, 258);
            this.lblNr_Books.Name = "lblNr_Books";
            this.lblNr_Books.Size = new System.Drawing.Size(82, 21);
            this.lblNr_Books.TabIndex = 7;
            this.lblNr_Books.Text = "Nr books";
            this.lblNr_Books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable
            // 
            this.lblAvailable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAvailable.Location = new System.Drawing.Point(41, 294);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(82, 21);
            this.lblAvailable.TabIndex = 8;
            this.lblAvailable.Text = "Available";
            this.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFreeBooks
            // 
            this.lblFreeBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFreeBooks.AutoSize = true;
            this.lblFreeBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFreeBooks.Location = new System.Drawing.Point(27, 329);
            this.lblFreeBooks.Name = "lblFreeBooks";
            this.lblFreeBooks.Size = new System.Drawing.Size(96, 21);
            this.lblFreeBooks.TabIndex = 9;
            this.lblFreeBooks.Text = "Free books";
            this.lblFreeBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBorrowed.Location = new System.Drawing.Point(37, 364);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(86, 21);
            this.lblBorrowed.TabIndex = 10;
            this.lblBorrowed.Text = "Borrowed";
            this.lblBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblISBN_NO
            // 
            this.lblISBN_NO.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblISBN_NO.AutoSize = true;
            this.lblISBN_NO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblISBN_NO.Location = new System.Drawing.Point(41, 402);
            this.lblISBN_NO.Name = "lblISBN_NO";
            this.lblISBN_NO.Size = new System.Drawing.Size(82, 21);
            this.lblISBN_NO.TabIndex = 11;
            this.lblISBN_NO.Text = "ISBN_NO";
            this.lblISBN_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNr_Inventory
            // 
            this.lblNr_Inventory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNr_Inventory.AutoSize = true;
            this.lblNr_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNr_Inventory.Location = new System.Drawing.Point(13, 441);
            this.lblNr_Inventory.Name = "lblNr_Inventory";
            this.lblNr_Inventory.Size = new System.Drawing.Size(110, 21);
            this.lblNr_Inventory.TabIndex = 12;
            this.lblNr_Inventory.Text = "Nr Inventory";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(129, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(175, 29);
            this.txtTitle.TabIndex = 13;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(129, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(175, 29);
            this.txtAuthor.TabIndex = 14;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(129, 74);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(175, 29);
            this.txtPublisher.TabIndex = 15;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(129, 110);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(175, 29);
            this.txtLocation.TabIndex = 16;
            // 
            // comType
            // 
            this.comType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "Engineering",
            "Design",
            "Games",
            "Geography",
            "History",
            "Languages",
            "Literature",
            "Math",
            "Physics",
            "Philosophy",
            "Programming",
            "Religion",
            "Others",
            ""});
            this.comType.Location = new System.Drawing.Point(129, 182);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(173, 29);
            this.comType.TabIndex = 18;
            // 
            // numVolumes
            // 
            this.numVolumes.Location = new System.Drawing.Point(129, 218);
            this.numVolumes.Name = "numVolumes";
            this.numVolumes.Size = new System.Drawing.Size(62, 29);
            this.numVolumes.TabIndex = 19;
            // 
            // numBooks
            // 
            this.numBooks.Location = new System.Drawing.Point(129, 254);
            this.numBooks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBooks.Name = "numBooks";
            this.numBooks.Size = new System.Drawing.Size(62, 29);
            this.numBooks.TabIndex = 20;
            this.numBooks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comAvailable
            // 
            this.comAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comAvailable.FormattingEnabled = true;
            this.comAvailable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comAvailable.Location = new System.Drawing.Point(129, 289);
            this.comAvailable.Name = "comAvailable";
            this.comAvailable.Size = new System.Drawing.Size(173, 29);
            this.comAvailable.TabIndex = 21;
            // 
            // numFree_Books
            // 
            this.numFree_Books.Location = new System.Drawing.Point(129, 326);
            this.numFree_Books.Name = "numFree_Books";
            this.numFree_Books.Size = new System.Drawing.Size(62, 29);
            this.numFree_Books.TabIndex = 22;
            // 
            // numBorrowed_Books
            // 
            this.numBorrowed_Books.Location = new System.Drawing.Point(129, 360);
            this.numBorrowed_Books.Name = "numBorrowed_Books";
            this.numBorrowed_Books.Size = new System.Drawing.Size(62, 29);
            this.numBorrowed_Books.TabIndex = 23;
            // 
            // txtISBN_NO
            // 
            this.txtISBN_NO.Location = new System.Drawing.Point(129, 396);
            this.txtISBN_NO.Name = "txtISBN_NO";
            this.txtISBN_NO.Size = new System.Drawing.Size(168, 29);
            this.txtISBN_NO.TabIndex = 24;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(129, 436);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(168, 29);
            this.txtInventory.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(167, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 30);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(129, 145);
            this.numYear.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(73, 29);
            this.numYear.TabIndex = 29;
            this.numYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(55, 598);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(17, 21);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "-";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(100, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(14, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "-";
            // 
            // lblID_Book
            // 
            this.lblID_Book.AutoSize = true;
            this.lblID_Book.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Book.Location = new System.Drawing.Point(35, 37);
            this.lblID_Book.Name = "lblID_Book";
            this.lblID_Book.Size = new System.Drawing.Size(63, 17);
            this.lblID_Book.TabIndex = 5;
            this.lblID_Book.Text = "Id Book:";
            // 
            // view_update_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 635);
            this.Controls.Add(this.lblID_Book);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblUpdateBooks);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "view_update_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.view_update_books_FormClosing);
            this.Load += new System.EventHandler(this.view_update_books_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFree_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorrowed_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateBooks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVolumes;
        private System.Windows.Forms.Label lblNr_Books;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblFreeBooks;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Label lblISBN_NO;
        private System.Windows.Forms.Label lblNr_Inventory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.NumericUpDown numVolumes;
        private System.Windows.Forms.NumericUpDown numBooks;
        private System.Windows.Forms.ComboBox comAvailable;
        private System.Windows.Forms.NumericUpDown numFree_Books;
        private System.Windows.Forms.NumericUpDown numBorrowed_Books;
        private System.Windows.Forms.TextBox txtISBN_NO;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblID_Book;
        private System.Windows.Forms.NumericUpDown numYear;
    }
}