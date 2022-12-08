namespace Library.UserForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.booksListView = new System.Windows.Forms.ListView();
            this.bookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reserveButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.reservationsTab = new System.Windows.Forms.TabPage();
            this.cancelReservationButton = new System.Windows.Forms.Button();
            this.updateReservationsButton = new System.Windows.Forms.Button();
            this.reservationsList = new System.Windows.Forms.ListView();
            this.reservationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservationBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservationStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loansTab = new System.Windows.Forms.TabPage();
            this.updateLoanList = new System.Windows.Forms.Button();
            this.loansList = new System.Windows.Forms.ListView();
            this.loanId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profile = new System.Windows.Forms.TabPage();
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
            this.tabControl.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.reservationsTab.SuspendLayout();
            this.loansTab.SuspendLayout();
            this.profile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(112, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск книг";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(116, 74);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(315, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchButton.Location = new System.Drawing.Point(437, 66);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(129, 33);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "название",
            "автор",
            "предмет"});
            this.searchComboBox.Location = new System.Drawing.Point(33, 73);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(73, 21);
            this.searchComboBox.TabIndex = 3;
            this.searchComboBox.Text = "критерий";
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookId,
            this.bookTitle,
            this.bookAuthors,
            this.bookSubject});
            this.booksListView.FullRowSelect = true;
            this.booksListView.HideSelection = false;
            this.booksListView.Location = new System.Drawing.Point(20, 127);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(684, 360);
            this.booksListView.TabIndex = 4;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
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
            this.bookAuthors.Width = 270;
            // 
            // bookSubject
            // 
            this.bookSubject.DisplayIndex = 2;
            this.bookSubject.Text = "Предмет";
            this.bookSubject.Width = 278;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(572, 66);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(122, 33);
            this.reserveButton.TabIndex = 5;
            this.reserveButton.Text = "Зарезервировать";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.booksTab);
            this.tabControl.Controls.Add(this.reservationsTab);
            this.tabControl.Controls.Add(this.loansTab);
            this.tabControl.Controls.Add(this.profile);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 561);
            this.tabControl.TabIndex = 6;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.searchComboBox);
            this.booksTab.Controls.Add(this.booksListView);
            this.booksTab.Controls.Add(this.reserveButton);
            this.booksTab.Controls.Add(this.searchTextBox);
            this.booksTab.Controls.Add(this.label1);
            this.booksTab.Controls.Add(this.searchButton);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(776, 535);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Поиск книг";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // reservationsTab
            // 
            this.reservationsTab.Controls.Add(this.cancelReservationButton);
            this.reservationsTab.Controls.Add(this.updateReservationsButton);
            this.reservationsTab.Controls.Add(this.reservationsList);
            this.reservationsTab.Location = new System.Drawing.Point(4, 22);
            this.reservationsTab.Name = "reservationsTab";
            this.reservationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.reservationsTab.Size = new System.Drawing.Size(776, 535);
            this.reservationsTab.TabIndex = 1;
            this.reservationsTab.Text = "Заявки";
            this.reservationsTab.UseVisualStyleBackColor = true;
            // 
            // cancelReservationButton
            // 
            this.cancelReservationButton.Location = new System.Drawing.Point(682, 97);
            this.cancelReservationButton.Name = "cancelReservationButton";
            this.cancelReservationButton.Size = new System.Drawing.Size(75, 48);
            this.cancelReservationButton.TabIndex = 2;
            this.cancelReservationButton.Text = "Отменить";
            this.cancelReservationButton.UseVisualStyleBackColor = true;
            this.cancelReservationButton.Click += new System.EventHandler(this.CancelReservationButton_Click);
            // 
            // updateReservationsButton
            // 
            this.updateReservationsButton.Location = new System.Drawing.Point(682, 25);
            this.updateReservationsButton.Name = "updateReservationsButton";
            this.updateReservationsButton.Size = new System.Drawing.Size(75, 48);
            this.updateReservationsButton.TabIndex = 1;
            this.updateReservationsButton.Text = "Обновить";
            this.updateReservationsButton.UseVisualStyleBackColor = true;
            // 
            // reservationsList
            // 
            this.reservationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reservationId,
            this.reservationBook,
            this.reservationDate,
            this.reservationStatus});
            this.reservationsList.FullRowSelect = true;
            this.reservationsList.HideSelection = false;
            this.reservationsList.Location = new System.Drawing.Point(29, 25);
            this.reservationsList.Name = "reservationsList";
            this.reservationsList.Size = new System.Drawing.Size(634, 468);
            this.reservationsList.TabIndex = 0;
            this.reservationsList.UseCompatibleStateImageBehavior = false;
            this.reservationsList.View = System.Windows.Forms.View.Details;
            this.reservationsList.DoubleClick += new System.EventHandler(this.ReservationsList_DoubleClick);
            // 
            // loanId
            // 
            this.reservationId.Text = "loanId";
            this.reservationId.Width = 0;
            // 
            // reservationBook
            // 
            this.reservationBook.Text = "Книга";
            this.reservationBook.Width = 207;
            // 
            // reservationDate
            // 
            this.reservationDate.Text = "Дата";
            this.reservationDate.Width = 108;
            // 
            // reservationStatus
            // 
            this.reservationStatus.Text = "Статус";
            this.reservationStatus.Width = 319;
            // 
            // loansTab
            // 
            this.loansTab.Controls.Add(this.updateLoanList);
            this.loansTab.Controls.Add(this.loansList);
            this.loansTab.Location = new System.Drawing.Point(4, 22);
            this.loansTab.Name = "loansTab";
            this.loansTab.Size = new System.Drawing.Size(776, 535);
            this.loansTab.TabIndex = 2;
            this.loansTab.Text = "Взятые книги";
            this.loansTab.UseVisualStyleBackColor = true;
            // 
            // updateLoanList
            // 
            this.updateLoanList.Location = new System.Drawing.Point(682, 25);
            this.updateLoanList.Name = "updateLoanList";
            this.updateLoanList.Size = new System.Drawing.Size(75, 48);
            this.updateLoanList.TabIndex = 4;
            this.updateLoanList.Text = "Обновить";
            this.updateLoanList.UseVisualStyleBackColor = true;
            this.updateLoanList.Click += new System.EventHandler(this.UpdateLoanList_Click);
            // 
            // loansList
            // 
            this.loansList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.loanId,
            this.loanBook,
            this.loanDate,
            this.loanStatus});
            this.loansList.FullRowSelect = true;
            this.loansList.HideSelection = false;
            this.loansList.Location = new System.Drawing.Point(29, 25);
            this.loansList.Name = "loansList";
            this.loansList.Size = new System.Drawing.Size(634, 468);
            this.loansList.TabIndex = 3;
            this.loansList.UseCompatibleStateImageBehavior = false;
            this.loansList.View = System.Windows.Forms.View.Details;
            this.loansList.DoubleClick += new System.EventHandler(this.LoanList_DoubleClick);
            // 
            // loanId
            // 
            this.loanId.Text = "loanId";
            this.loanId.Width = 0;
            // 
            // loanBook
            // 
            this.loanBook.Text = "Книга";
            this.loanBook.Width = 207;
            // 
            // loanDate
            // 
            this.loanDate.Text = "Дата";
            this.loanDate.Width = 108;
            // 
            // loanStatus
            // 
            this.loanStatus.Text = "Статус";
            this.loanStatus.Width = 319;
            // 
            // profile
            // 
            this.profile.Controls.Add(this.panel1);
            this.profile.Location = new System.Drawing.Point(4, 22);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(776, 535);
            this.profile.TabIndex = 3;
            this.profile.Text = "Аккаунт";
            this.profile.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(225, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 361);
            this.panel1.TabIndex = 8;
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
            this.Controls.Add(this.tabControl);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.booksTab.PerformLayout();
            this.reservationsTab.ResumeLayout(false);
            this.loansTab.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader bookTitle;
        private System.Windows.Forms.ColumnHeader bookAuthors;
        private System.Windows.Forms.ColumnHeader bookSubject;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.ColumnHeader bookId;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage reservationsTab;
        private System.Windows.Forms.TabPage loansTab;
        private System.Windows.Forms.ListView reservationsList;
        private System.Windows.Forms.ColumnHeader reservationDate;
        private System.Windows.Forms.ColumnHeader reservationStatus;
        private System.Windows.Forms.ColumnHeader reservationId;
        private System.Windows.Forms.ColumnHeader reservationBook;
        private System.Windows.Forms.Button cancelReservationButton;
        private System.Windows.Forms.Button updateReservationsButton;
        private System.Windows.Forms.Button updateLoanList;
        private System.Windows.Forms.ListView loansList;
        private System.Windows.Forms.ColumnHeader loanId;
        private System.Windows.Forms.ColumnHeader loanBook;
        private System.Windows.Forms.ColumnHeader loanDate;
        private System.Windows.Forms.ColumnHeader loanStatus;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TextBox profilePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profileEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox profileLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox profileFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changePasswordButton;
    }
}