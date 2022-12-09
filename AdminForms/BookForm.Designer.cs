namespace Library.AdminForms
{
    partial class BookForm
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
            this.bookItemsList = new System.Windows.Forms.ListView();
            this.itemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.book = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.selectSubjectsButton = new System.Windows.Forms.Button();
            this.subjectSearch = new System.Windows.Forms.TextBox();
            this.searchSubjectsButton = new System.Windows.Forms.Button();
            this.subjectsList = new System.Windows.Forms.ListView();
            this.subjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectAuthorsButton = new System.Windows.Forms.Button();
            this.authorSearch = new System.Windows.Forms.TextBox();
            this.searchAuthorsButton = new System.Windows.Forms.Button();
            this.authorsList = new System.Windows.Forms.ListView();
            this.authorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authorsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookItems = new System.Windows.Forms.TabPage();
            this.deleteBookItemButton = new System.Windows.Forms.Button();
            this.updateBookItemsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.book.SuspendLayout();
            this.bookItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookItemsList
            // 
            this.bookItemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemId,
            this.temBarcode});
            this.bookItemsList.FullRowSelect = true;
            this.bookItemsList.HideSelection = false;
            this.bookItemsList.Location = new System.Drawing.Point(41, 78);
            this.bookItemsList.Name = "bookItemsList";
            this.bookItemsList.Size = new System.Drawing.Size(500, 268);
            this.bookItemsList.TabIndex = 0;
            this.bookItemsList.UseCompatibleStateImageBehavior = false;
            this.bookItemsList.View = System.Windows.Forms.View.Details;
            this.bookItemsList.DoubleClick += new System.EventHandler(this.BookItemsList_DoubleClick);
            // 
            // itemId
            // 
            this.itemId.Text = "itemId";
            this.itemId.Width = 0;
            // 
            // temBarcode
            // 
            this.temBarcode.Text = "Штрих-код";
            this.temBarcode.Width = 233;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.book);
            this.tabControl1.Controls.Add(this.bookItems);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 1;
            // 
            // book
            // 
            this.book.Controls.Add(this.label4);
            this.book.Controls.Add(this.dateTextBox);
            this.book.Controls.Add(this.selectSubjectsButton);
            this.book.Controls.Add(this.subjectSearch);
            this.book.Controls.Add(this.searchSubjectsButton);
            this.book.Controls.Add(this.subjectsList);
            this.book.Controls.Add(this.selectAuthorsButton);
            this.book.Controls.Add(this.authorSearch);
            this.book.Controls.Add(this.searchAuthorsButton);
            this.book.Controls.Add(this.authorsList);
            this.book.Controls.Add(this.subjectTextBox);
            this.book.Controls.Add(this.label3);
            this.book.Controls.Add(this.authorsTextBox);
            this.book.Controls.Add(this.label2);
            this.book.Controls.Add(this.updateButton);
            this.book.Controls.Add(this.titleTextBox);
            this.book.Controls.Add(this.label1);
            this.book.Location = new System.Drawing.Point(4, 22);
            this.book.Name = "book";
            this.book.Padding = new System.Windows.Forms.Padding(3);
            this.book.Size = new System.Drawing.Size(776, 535);
            this.book.TabIndex = 1;
            this.book.Text = "Книга";
            this.book.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(497, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Год публикации";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(500, 60);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(257, 20);
            this.dateTextBox.TabIndex = 29;
            // 
            // selectSubjectsButton
            // 
            this.selectSubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.selectSubjectsButton.Location = new System.Drawing.Point(634, 343);
            this.selectSubjectsButton.Name = "selectSubjectsButton";
            this.selectSubjectsButton.Size = new System.Drawing.Size(123, 30);
            this.selectSubjectsButton.TabIndex = 28;
            this.selectSubjectsButton.Text = "Выбрать";
            this.selectSubjectsButton.UseVisualStyleBackColor = true;
            this.selectSubjectsButton.Click += new System.EventHandler(this.SelectSubjectsButton_Click);
            // 
            // subjectSearch
            // 
            this.subjectSearch.Location = new System.Drawing.Point(500, 317);
            this.subjectSearch.Name = "subjectSearch";
            this.subjectSearch.Size = new System.Drawing.Size(257, 20);
            this.subjectSearch.TabIndex = 26;
            // 
            // searchSubjectsButton
            // 
            this.searchSubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchSubjectsButton.Location = new System.Drawing.Point(500, 343);
            this.searchSubjectsButton.Name = "searchSubjectsButton";
            this.searchSubjectsButton.Size = new System.Drawing.Size(123, 30);
            this.searchSubjectsButton.TabIndex = 27;
            this.searchSubjectsButton.Text = "Поиск";
            this.searchSubjectsButton.UseVisualStyleBackColor = true;
            this.searchSubjectsButton.Click += new System.EventHandler(this.SearchSubjectsButton_Click);
            // 
            // subjectsList
            // 
            this.subjectsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subjectId,
            this.subjectName});
            this.subjectsList.FullRowSelect = true;
            this.subjectsList.HideSelection = false;
            this.subjectsList.Location = new System.Drawing.Point(29, 317);
            this.subjectsList.Name = "subjectsList";
            this.subjectsList.Size = new System.Drawing.Size(465, 131);
            this.subjectsList.TabIndex = 25;
            this.subjectsList.UseCompatibleStateImageBehavior = false;
            this.subjectsList.View = System.Windows.Forms.View.Details;
            // 
            // subjectId
            // 
            this.subjectId.Text = "subjectId";
            this.subjectId.Width = 0;
            // 
            // subjectName
            // 
            this.subjectName.Text = "Название";
            this.subjectName.Width = 322;
            // 
            // selectAuthorsButton
            // 
            this.selectAuthorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.selectAuthorsButton.Location = new System.Drawing.Point(634, 155);
            this.selectAuthorsButton.Name = "selectAuthorsButton";
            this.selectAuthorsButton.Size = new System.Drawing.Size(123, 30);
            this.selectAuthorsButton.TabIndex = 24;
            this.selectAuthorsButton.Text = "Выбрать";
            this.selectAuthorsButton.UseVisualStyleBackColor = true;
            this.selectAuthorsButton.Click += new System.EventHandler(this.SelectAuthorsButton_Click);
            // 
            // authorSearch
            // 
            this.authorSearch.Location = new System.Drawing.Point(500, 129);
            this.authorSearch.Name = "authorSearch";
            this.authorSearch.Size = new System.Drawing.Size(257, 20);
            this.authorSearch.TabIndex = 22;
            // 
            // searchAuthorsButton
            // 
            this.searchAuthorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchAuthorsButton.Location = new System.Drawing.Point(500, 155);
            this.searchAuthorsButton.Name = "searchAuthorsButton";
            this.searchAuthorsButton.Size = new System.Drawing.Size(123, 30);
            this.searchAuthorsButton.TabIndex = 23;
            this.searchAuthorsButton.Text = "Поиск";
            this.searchAuthorsButton.UseVisualStyleBackColor = true;
            this.searchAuthorsButton.Click += new System.EventHandler(this.SearchAuthorsButton_Click);
            // 
            // authorsList
            // 
            this.authorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.authorId,
            this.authorFirstName,
            this.authorLastName});
            this.authorsList.FullRowSelect = true;
            this.authorsList.HideSelection = false;
            this.authorsList.Location = new System.Drawing.Point(29, 129);
            this.authorsList.Name = "authorsList";
            this.authorsList.Size = new System.Drawing.Size(465, 139);
            this.authorsList.TabIndex = 20;
            this.authorsList.UseCompatibleStateImageBehavior = false;
            this.authorsList.View = System.Windows.Forms.View.Details;
            // 
            // authorId
            // 
            this.authorId.Text = "authorId";
            this.authorId.Width = 0;
            // 
            // authorFirstName
            // 
            this.authorFirstName.Text = "Имя";
            this.authorFirstName.Width = 186;
            // 
            // authorLastName
            // 
            this.authorLastName.Text = "Фамилия";
            this.authorLastName.Width = 198;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Enabled = false;
            this.subjectTextBox.Location = new System.Drawing.Point(29, 291);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(465, 20);
            this.subjectTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(26, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Предмет";
            // 
            // authorsTextBox
            // 
            this.authorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorsTextBox.Enabled = false;
            this.authorsTextBox.Location = new System.Drawing.Point(29, 103);
            this.authorsTextBox.Name = "authorsTextBox";
            this.authorsTextBox.Size = new System.Drawing.Size(465, 20);
            this.authorsTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Автор(ы)";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(627, 489);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(141, 38);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(29, 60);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(465, 20);
            this.titleTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // bookItems
            // 
            this.bookItems.Controls.Add(this.deleteBookItemButton);
            this.bookItems.Controls.Add(this.updateBookItemsButton);
            this.bookItems.Controls.Add(this.bookItemsList);
            this.bookItems.Location = new System.Drawing.Point(4, 22);
            this.bookItems.Name = "bookItems";
            this.bookItems.Padding = new System.Windows.Forms.Padding(3);
            this.bookItems.Size = new System.Drawing.Size(776, 535);
            this.bookItems.TabIndex = 0;
            this.bookItems.Text = "Экземпляры";
            this.bookItems.UseVisualStyleBackColor = true;
            // 
            // deleteBookItemButton
            // 
            this.deleteBookItemButton.Location = new System.Drawing.Point(585, 133);
            this.deleteBookItemButton.Name = "deleteBookItemButton";
            this.deleteBookItemButton.Size = new System.Drawing.Size(99, 48);
            this.deleteBookItemButton.TabIndex = 3;
            this.deleteBookItemButton.Text = "Удалить";
            this.deleteBookItemButton.UseVisualStyleBackColor = true;
            this.deleteBookItemButton.Click += new System.EventHandler(this.DeleteBookItemButton_Click);
            // 
            // updateBookItemsButton
            // 
            this.updateBookItemsButton.Location = new System.Drawing.Point(585, 78);
            this.updateBookItemsButton.Name = "updateBookItemsButton";
            this.updateBookItemsButton.Size = new System.Drawing.Size(99, 49);
            this.updateBookItemsButton.TabIndex = 1;
            this.updateBookItemsButton.Text = "Обновить";
            this.updateBookItemsButton.UseVisualStyleBackColor = true;
            this.updateBookItemsButton.Click += new System.EventHandler(this.UpdateBookItems_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.tabControl1.ResumeLayout(false);
            this.book.ResumeLayout(false);
            this.book.PerformLayout();
            this.bookItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookItemsList;
        private System.Windows.Forms.ColumnHeader itemId;
        private System.Windows.Forms.ColumnHeader temBarcode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage book;
        private System.Windows.Forms.TabPage bookItems;
        private System.Windows.Forms.Button updateBookItemsButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectSubjectsButton;
        private System.Windows.Forms.TextBox subjectSearch;
        private System.Windows.Forms.Button searchSubjectsButton;
        private System.Windows.Forms.ListView subjectsList;
        private System.Windows.Forms.ColumnHeader subjectId;
        private System.Windows.Forms.ColumnHeader subjectName;
        private System.Windows.Forms.Button selectAuthorsButton;
        private System.Windows.Forms.TextBox authorSearch;
        private System.Windows.Forms.Button searchAuthorsButton;
        private System.Windows.Forms.ListView authorsList;
        private System.Windows.Forms.ColumnHeader authorId;
        private System.Windows.Forms.ColumnHeader authorFirstName;
        private System.Windows.Forms.ColumnHeader authorLastName;
        private System.Windows.Forms.Button deleteBookItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateTextBox;
    }
}