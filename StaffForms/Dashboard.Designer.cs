namespace Library.StaffForms
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.members = new System.Windows.Forms.TabPage();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.updateMembersButton = new System.Windows.Forms.Button();
            this.membersList = new System.Windows.Forms.ListView();
            this.memberId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.books = new System.Windows.Forms.TabPage();
            this.addBookButton = new System.Windows.Forms.Button();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.ListView();
            this.bookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authors = new System.Windows.Forms.TabPage();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.authorSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchAuthorsButton = new System.Windows.Forms.Button();
            this.authorsList = new System.Windows.Forms.ListView();
            this.authorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjects = new System.Windows.Forms.TabPage();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.subjectSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchSubjectsButton = new System.Windows.Forms.Button();
            this.subjectsList = new System.Windows.Forms.ListView();
            this.subjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profile = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.profilePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profileFirstName = new System.Windows.Forms.TextBox();
            this.profileEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.profileLastName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.members.SuspendLayout();
            this.books.SuspendLayout();
            this.authors.SuspendLayout();
            this.subjects.SuspendLayout();
            this.profile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.members);
            this.tabControl1.Controls.Add(this.books);
            this.tabControl1.Controls.Add(this.authors);
            this.tabControl1.Controls.Add(this.subjects);
            this.tabControl1.Controls.Add(this.profile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // members
            // 
            this.members.Controls.Add(this.deleteMemberButton);
            this.members.Controls.Add(this.addMemberButton);
            this.members.Controls.Add(this.updateMembersButton);
            this.members.Controls.Add(this.membersList);
            this.members.Location = new System.Drawing.Point(4, 22);
            this.members.Name = "members";
            this.members.Padding = new System.Windows.Forms.Padding(3);
            this.members.Size = new System.Drawing.Size(776, 535);
            this.members.TabIndex = 0;
            this.members.Text = "Читатели";
            this.members.UseVisualStyleBackColor = true;
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(685, 145);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(67, 53);
            this.deleteMemberButton.TabIndex = 7;
            this.deleteMemberButton.Text = "Удалить";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            this.deleteMemberButton.Click += new System.EventHandler(this.DeleteMemberButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(685, 86);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(67, 53);
            this.addMemberButton.TabIndex = 6;
            this.addMemberButton.Text = "Добавить";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // updateMembersButton
            // 
            this.updateMembersButton.Location = new System.Drawing.Point(685, 27);
            this.updateMembersButton.Name = "updateMembersButton";
            this.updateMembersButton.Size = new System.Drawing.Size(67, 53);
            this.updateMembersButton.TabIndex = 5;
            this.updateMembersButton.Text = "Обновить";
            this.updateMembersButton.UseVisualStyleBackColor = true;
            this.updateMembersButton.Click += new System.EventHandler(this.UpdateMembersButton_Click);
            // 
            // membersList
            // 
            this.membersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberId,
            this.memberName,
            this.memberEmail});
            this.membersList.FullRowSelect = true;
            this.membersList.HideSelection = false;
            this.membersList.Location = new System.Drawing.Point(28, 27);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(634, 468);
            this.membersList.TabIndex = 4;
            this.membersList.UseCompatibleStateImageBehavior = false;
            this.membersList.View = System.Windows.Forms.View.Details;
            this.membersList.DoubleClick += new System.EventHandler(this.MembersList_DoubleClick);
            // 
            // memberId
            // 
            this.memberId.Text = "memberId";
            this.memberId.Width = 0;
            // 
            // memberName
            // 
            this.memberName.Text = "Имя";
            this.memberName.Width = 300;
            // 
            // memberEmail
            // 
            this.memberEmail.Text = "E-mail";
            this.memberEmail.Width = 269;
            // 
            // books
            // 
            this.books.Controls.Add(this.addBookButton);
            this.books.Controls.Add(this.searchComboBox);
            this.books.Controls.Add(this.searchTextBox);
            this.books.Controls.Add(this.label1);
            this.books.Controls.Add(this.searchButton);
            this.books.Controls.Add(this.booksList);
            this.books.Location = new System.Drawing.Point(4, 22);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(776, 535);
            this.books.TabIndex = 2;
            this.books.Text = "Книги";
            this.books.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(680, 98);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(72, 75);
            this.addBookButton.TabIndex = 10;
            this.addBookButton.Text = "Добавить";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "название",
            "автор",
            "предмет"});
            this.searchComboBox.Location = new System.Drawing.Point(72, 52);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(73, 21);
            this.searchComboBox.TabIndex = 9;
            this.searchComboBox.Text = "критерий";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(155, 53);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(315, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(151, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск книг";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchButton.Location = new System.Drawing.Point(476, 45);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(129, 33);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // booksList
            // 
            this.booksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookId,
            this.bookTitle,
            this.bookAuthors,
            this.bookSubject});
            this.booksList.FullRowSelect = true;
            this.booksList.HideSelection = false;
            this.booksList.Location = new System.Drawing.Point(31, 98);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(625, 355);
            this.booksList.TabIndex = 5;
            this.booksList.UseCompatibleStateImageBehavior = false;
            this.booksList.View = System.Windows.Forms.View.Details;
            this.booksList.DoubleClick += new System.EventHandler(this.BooksList_DoubleClick);
            // 
            // bookId
            // 
            this.bookId.DisplayIndex = 3;
            this.bookId.Text = "bookId";
            this.bookId.Width = 0;
            // 
            // bookTitle
            // 
            this.bookTitle.DisplayIndex = 0;
            this.bookTitle.Text = "Название";
            this.bookTitle.Width = 195;
            // 
            // bookAuthors
            // 
            this.bookAuthors.DisplayIndex = 1;
            this.bookAuthors.Text = "Автор(ы)";
            this.bookAuthors.Width = 284;
            // 
            // bookSubject
            // 
            this.bookSubject.DisplayIndex = 2;
            this.bookSubject.Text = "Предмет";
            this.bookSubject.Width = 119;
            // 
            // authors
            // 
            this.authors.Controls.Add(this.addAuthorButton);
            this.authors.Controls.Add(this.authorSearch);
            this.authors.Controls.Add(this.label6);
            this.authors.Controls.Add(this.searchAuthorsButton);
            this.authors.Controls.Add(this.authorsList);
            this.authors.Location = new System.Drawing.Point(4, 22);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(776, 535);
            this.authors.TabIndex = 3;
            this.authors.Text = "Авторы";
            this.authors.UseVisualStyleBackColor = true;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(677, 124);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(72, 75);
            this.addAuthorButton.TabIndex = 16;
            this.addAuthorButton.Text = "Добавить";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // authorSearch
            // 
            this.authorSearch.Location = new System.Drawing.Point(152, 79);
            this.authorSearch.Name = "authorSearch";
            this.authorSearch.Size = new System.Drawing.Size(315, 20);
            this.authorSearch.TabIndex = 13;
            this.authorSearch.TextChanged += new System.EventHandler(this.authorSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(148, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Поиск авторов";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // searchAuthorsButton
            // 
            this.searchAuthorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchAuthorsButton.Location = new System.Drawing.Point(473, 71);
            this.searchAuthorsButton.Name = "searchAuthorsButton";
            this.searchAuthorsButton.Size = new System.Drawing.Size(129, 33);
            this.searchAuthorsButton.TabIndex = 14;
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
            this.authorsList.Location = new System.Drawing.Point(28, 124);
            this.authorsList.Name = "authorsList";
            this.authorsList.Size = new System.Drawing.Size(625, 355);
            this.authorsList.TabIndex = 11;
            this.authorsList.UseCompatibleStateImageBehavior = false;
            this.authorsList.View = System.Windows.Forms.View.Details;
            this.authorsList.SelectedIndexChanged += new System.EventHandler(this.authorsList_SelectedIndexChanged);
            this.authorsList.DoubleClick += new System.EventHandler(this.AuthorsList_DoubleClick);
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
            // subjects
            // 
            this.subjects.Controls.Add(this.addSubjectButton);
            this.subjects.Controls.Add(this.subjectSearch);
            this.subjects.Controls.Add(this.label7);
            this.subjects.Controls.Add(this.searchSubjectsButton);
            this.subjects.Controls.Add(this.subjectsList);
            this.subjects.Location = new System.Drawing.Point(4, 22);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(776, 535);
            this.subjects.TabIndex = 4;
            this.subjects.Text = "Предметы";
            this.subjects.UseVisualStyleBackColor = true;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(677, 124);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(72, 75);
            this.addSubjectButton.TabIndex = 21;
            this.addSubjectButton.Text = "Добавить";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // subjectSearch
            // 
            this.subjectSearch.Location = new System.Drawing.Point(152, 79);
            this.subjectSearch.Name = "subjectSearch";
            this.subjectSearch.Size = new System.Drawing.Size(315, 20);
            this.subjectSearch.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(148, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Поиск предметов";
            // 
            // searchSubjectsButton
            // 
            this.searchSubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchSubjectsButton.Location = new System.Drawing.Point(473, 71);
            this.searchSubjectsButton.Name = "searchSubjectsButton";
            this.searchSubjectsButton.Size = new System.Drawing.Size(129, 33);
            this.searchSubjectsButton.TabIndex = 20;
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
            this.subjectsList.Location = new System.Drawing.Point(28, 124);
            this.subjectsList.Name = "subjectsList";
            this.subjectsList.Size = new System.Drawing.Size(625, 355);
            this.subjectsList.TabIndex = 17;
            this.subjectsList.UseCompatibleStateImageBehavior = false;
            this.subjectsList.View = System.Windows.Forms.View.Details;
            this.subjectsList.DoubleClick += new System.EventHandler(this.SubjectsList_DoubleClick);
            // 
            // subjectId
            // 
            this.subjectId.Text = "subjectId";
            this.subjectId.Width = 0;
            // 
            // subjectName
            // 
            this.subjectName.Text = "Название";
            this.subjectName.Width = 292;
            // 
            // profile
            // 
            this.profile.Controls.Add(this.button1);
            this.profile.Controls.Add(this.panel1);
            this.profile.Location = new System.Drawing.Point(4, 22);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(776, 535);
            this.profile.TabIndex = 1;
            this.profile.Text = "Аккаунт";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.changePasswordButton);
            this.panel1.Controls.Add(this.profilePhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.profileFirstName);
            this.panel1.Controls.Add(this.profileEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.profileLastName);
            this.panel1.Location = new System.Drawing.Point(241, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 361);
            this.panel1.TabIndex = 9;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordButton.Location = new System.Drawing.Point(47, 301);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(194, 32);
            this.changePasswordButton.TabIndex = 9;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // profilePhone
            // 
            this.profilePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePhone.Enabled = false;
            this.profilePhone.Location = new System.Drawing.Point(47, 244);
            this.profilePhone.Name = "profilePhone";
            this.profilePhone.Size = new System.Drawing.Size(194, 20);
            this.profilePhone.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(44, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Телефон";
            // 
            // profileFirstName
            // 
            this.profileFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileFirstName.Enabled = false;
            this.profileFirstName.Location = new System.Drawing.Point(47, 46);
            this.profileFirstName.Name = "profileFirstName";
            this.profileFirstName.Size = new System.Drawing.Size(194, 20);
            this.profileFirstName.TabIndex = 1;
            // 
            // profileEmail
            // 
            this.profileEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileEmail.Enabled = false;
            this.profileEmail.Location = new System.Drawing.Point(47, 175);
            this.profileEmail.Name = "profileEmail";
            this.profileEmail.Size = new System.Drawing.Size(194, 20);
            this.profileEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(44, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // profileLastName
            // 
            this.profileLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileLastName.Enabled = false;
            this.profileLastName.Location = new System.Drawing.Point(47, 106);
            this.profileLastName.Name = "profileLastName";
            this.profileLastName.Size = new System.Drawing.Size(194, 20);
            this.profileLastName.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.members.ResumeLayout(false);
            this.books.ResumeLayout(false);
            this.books.PerformLayout();
            this.authors.ResumeLayout(false);
            this.authors.PerformLayout();
            this.subjects.ResumeLayout(false);
            this.subjects.PerformLayout();
            this.profile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage members;
        private System.Windows.Forms.TabPage books;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button updateMembersButton;
        private System.Windows.Forms.ListView membersList;
        private System.Windows.Forms.ColumnHeader memberId;
        private System.Windows.Forms.ColumnHeader memberName;
        private System.Windows.Forms.ColumnHeader memberEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox profilePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profileFirstName;
        private System.Windows.Forms.TextBox profileEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox profileLastName;
        private System.Windows.Forms.ListView booksList;
        private System.Windows.Forms.ColumnHeader bookId;
        private System.Windows.Forms.ColumnHeader bookTitle;
        private System.Windows.Forms.ColumnHeader bookAuthors;
        private System.Windows.Forms.ColumnHeader bookSubject;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TabPage authors;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.TextBox authorSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchAuthorsButton;
        private System.Windows.Forms.ListView authorsList;
        private System.Windows.Forms.ColumnHeader authorId;
        private System.Windows.Forms.ColumnHeader authorFirstName;
        private System.Windows.Forms.TabPage subjects;
        private System.Windows.Forms.ColumnHeader authorLastName;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.TextBox subjectSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchSubjectsButton;
        private System.Windows.Forms.ListView subjectsList;
        private System.Windows.Forms.ColumnHeader subjectId;
        private System.Windows.Forms.ColumnHeader subjectName;
        private System.Windows.Forms.Button button1;
    }
}