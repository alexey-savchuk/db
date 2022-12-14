namespace Library.AdminForms
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
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.updateMembersButton = new System.Windows.Forms.Button();
            this.membersList = new System.Windows.Forms.ListView();
            this.memberId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.books = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.ListView();
            this.bookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authors = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.authorSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchAuthorsButton = new System.Windows.Forms.Button();
            this.authorsList = new System.Windows.Forms.ListView();
            this.authorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjects = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.subjectSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchSubjectsButton = new System.Windows.Forms.Button();
            this.subjectsList = new System.Windows.Forms.ListView();
            this.subjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statuses = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.itemStatusList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanStatusList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reservationStatusList = new System.Windows.Forms.ListView();
            this.statusId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profile = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateProfileButton = new System.Windows.Forms.Button();
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
            this.statuses.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.statuses);
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
            this.members.Controls.Add(this.roleComboBox);
            this.members.Controls.Add(this.deleteMemberButton);
            this.members.Controls.Add(this.addMemberButton);
            this.members.Controls.Add(this.updateMembersButton);
            this.members.Controls.Add(this.membersList);
            this.members.Location = new System.Drawing.Point(4, 22);
            this.members.Name = "members";
            this.members.Padding = new System.Windows.Forms.Padding(3);
            this.members.Size = new System.Drawing.Size(776, 535);
            this.members.TabIndex = 0;
            this.members.Text = "Пользователи";
            this.members.UseVisualStyleBackColor = true;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(633, 27);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(122, 21);
            this.roleComboBox.TabIndex = 8;
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(633, 442);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(122, 53);
            this.deleteMemberButton.TabIndex = 7;
            this.deleteMemberButton.Text = "Удалить";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            this.deleteMemberButton.Click += new System.EventHandler(this.DeleteMemberButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(633, 383);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(122, 53);
            this.addMemberButton.TabIndex = 6;
            this.addMemberButton.Text = "Добавить";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // updateMembersButton
            // 
            this.updateMembersButton.Location = new System.Drawing.Point(633, 54);
            this.updateMembersButton.Name = "updateMembersButton";
            this.updateMembersButton.Size = new System.Drawing.Size(122, 53);
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
            this.membersList.Size = new System.Drawing.Size(585, 468);
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
            this.memberName.Width = 244;
            // 
            // memberEmail
            // 
            this.memberEmail.Text = "E-mail";
            this.memberEmail.Width = 238;
            // 
            // books
            // 
            this.books.Controls.Add(this.button7);
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
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(681, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 75);
            this.button7.TabIndex = 11;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.DeleteBooks_Click);
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
            this.bookSubject,
            this.bookDate});
            this.booksList.FullRowSelect = true;
            this.booksList.HideSelection = false;
            this.booksList.Location = new System.Drawing.Point(30, 98);
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
            this.bookTitle.Width = 177;
            // 
            // bookAuthors
            // 
            this.bookAuthors.DisplayIndex = 1;
            this.bookAuthors.Text = "Автор(ы)";
            this.bookAuthors.Width = 224;
            // 
            // bookSubject
            // 
            this.bookSubject.DisplayIndex = 2;
            this.bookSubject.Text = "Предмет";
            this.bookSubject.Width = 114;
            // 
            // bookDate
            // 
            this.bookDate.Text = "Год публикации";
            this.bookDate.Width = 100;
            // 
            // authors
            // 
            this.authors.Controls.Add(this.button8);
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
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(678, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 75);
            this.button8.TabIndex = 17;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.DeleteAuthors_Click);
            // 
            // authorSearch
            // 
            this.authorSearch.Location = new System.Drawing.Point(152, 79);
            this.authorSearch.Name = "authorSearch";
            this.authorSearch.Size = new System.Drawing.Size(315, 20);
            this.authorSearch.TabIndex = 13;
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
            this.subjects.Controls.Add(this.button9);
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
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(679, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 75);
            this.button9.TabIndex = 22;
            this.button9.Text = "Удалить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DeleteSubjects_Click);
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
            // statuses
            // 
            this.statuses.Controls.Add(this.button6);
            this.statuses.Controls.Add(this.button5);
            this.statuses.Controls.Add(this.button4);
            this.statuses.Controls.Add(this.itemStatusList);
            this.statuses.Controls.Add(this.loanStatusList);
            this.statuses.Controls.Add(this.button3);
            this.statuses.Controls.Add(this.button2);
            this.statuses.Controls.Add(this.button1);
            this.statuses.Controls.Add(this.label10);
            this.statuses.Controls.Add(this.label9);
            this.statuses.Controls.Add(this.label8);
            this.statuses.Controls.Add(this.reservationStatusList);
            this.statuses.Location = new System.Drawing.Point(4, 22);
            this.statuses.Name = "statuses";
            this.statuses.Size = new System.Drawing.Size(776, 535);
            this.statuses.TabIndex = 5;
            this.statuses.Text = "Статусы";
            this.statuses.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(550, 435);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 21);
            this.button6.TabIndex = 16;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DeleteItemStatus_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(292, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 21);
            this.button5.TabIndex = 15;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DeleteLoanStatus_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 21);
            this.button4.TabIndex = 14;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DeleteReservationStatus_Click);
            // 
            // itemStatusList
            // 
            this.itemStatusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.itemStatusList.FullRowSelect = true;
            this.itemStatusList.HideSelection = false;
            this.itemStatusList.Location = new System.Drawing.Point(550, 50);
            this.itemStatusList.Name = "itemStatusList";
            this.itemStatusList.Size = new System.Drawing.Size(200, 350);
            this.itemStatusList.TabIndex = 13;
            this.itemStatusList.UseCompatibleStateImageBehavior = false;
            this.itemStatusList.View = System.Windows.Forms.View.Details;
            this.itemStatusList.DoubleClick += new System.EventHandler(this.ItemStatus_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "statusId";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Название";
            this.columnHeader4.Width = 152;
            // 
            // loanStatusList
            // 
            this.loanStatusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.loanStatusList.FullRowSelect = true;
            this.loanStatusList.HideSelection = false;
            this.loanStatusList.Location = new System.Drawing.Point(292, 50);
            this.loanStatusList.Name = "loanStatusList";
            this.loanStatusList.Size = new System.Drawing.Size(200, 350);
            this.loanStatusList.TabIndex = 12;
            this.loanStatusList.UseCompatibleStateImageBehavior = false;
            this.loanStatusList.View = System.Windows.Forms.View.Details;
            this.loanStatusList.DoubleClick += new System.EventHandler(this.LoanStatusList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "statusId";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 152;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddItemStatus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 21);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddLoanStatus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddReservationStatus_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(557, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Статусы экземпляров книг";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(278, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Статусы записей о взятых книгах";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Статусы заявок на получение книг";
            // 
            // reservationStatusList
            // 
            this.reservationStatusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusId,
            this.statusName});
            this.reservationStatusList.FullRowSelect = true;
            this.reservationStatusList.HideSelection = false;
            this.reservationStatusList.Location = new System.Drawing.Point(33, 50);
            this.reservationStatusList.Name = "reservationStatusList";
            this.reservationStatusList.Size = new System.Drawing.Size(200, 350);
            this.reservationStatusList.TabIndex = 0;
            this.reservationStatusList.UseCompatibleStateImageBehavior = false;
            this.reservationStatusList.View = System.Windows.Forms.View.Details;
            this.reservationStatusList.DoubleClick += new System.EventHandler(this.ReservationStatusList_DoubleClick);
            // 
            // statusId
            // 
            this.statusId.Text = "statusId";
            this.statusId.Width = 0;
            // 
            // statusName
            // 
            this.statusName.Text = "Название";
            this.statusName.Width = 152;
            // 
            // profile
            // 
            this.profile.Controls.Add(this.button10);
            this.profile.Controls.Add(this.panel1);
            this.profile.Location = new System.Drawing.Point(4, 22);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(776, 535);
            this.profile.TabIndex = 1;
            this.profile.Text = "Аккаунт";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(676, 499);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 30);
            this.button10.TabIndex = 10;
            this.button10.Text = "Выйти";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.updateProfileButton);
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
            // updateProfileButton
            // 
            this.updateProfileButton.Location = new System.Drawing.Point(47, 277);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Size = new System.Drawing.Size(194, 33);
            this.updateProfileButton.TabIndex = 10;
            this.updateProfileButton.Text = "Обновить";
            this.updateProfileButton.UseVisualStyleBackColor = true;
            this.updateProfileButton.Click += new System.EventHandler(this.UpdateProfileButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordButton.Location = new System.Drawing.Point(47, 316);
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
            this.profilePhone.Location = new System.Drawing.Point(47, 239);
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
            this.label5.Location = new System.Drawing.Point(44, 219);
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
            this.statuses.ResumeLayout(false);
            this.statuses.PerformLayout();
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
        private System.Windows.Forms.TabPage authors;
        private System.Windows.Forms.TextBox authorSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchAuthorsButton;
        private System.Windows.Forms.ListView authorsList;
        private System.Windows.Forms.ColumnHeader authorId;
        private System.Windows.Forms.ColumnHeader authorFirstName;
        private System.Windows.Forms.TabPage subjects;
        private System.Windows.Forms.ColumnHeader authorLastName;
        private System.Windows.Forms.TextBox subjectSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchSubjectsButton;
        private System.Windows.Forms.ListView subjectsList;
        private System.Windows.Forms.ColumnHeader subjectId;
        private System.Windows.Forms.ColumnHeader subjectName;
        private System.Windows.Forms.Button updateProfileButton;
        private System.Windows.Forms.TabPage statuses;
        private System.Windows.Forms.ListView itemStatusList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView loanStatusList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView reservationStatusList;
        private System.Windows.Forms.ColumnHeader statusId;
        private System.Windows.Forms.ColumnHeader statusName;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ColumnHeader bookDate;
    }
}