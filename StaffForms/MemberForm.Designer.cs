namespace Library.StaffForms
{
    partial class MemberForm
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
            this.profile = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeProfileButton = new System.Windows.Forms.Button();
            this.profilePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profileFirstName = new System.Windows.Forms.TextBox();
            this.profileEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.profileLastName = new System.Windows.Forms.TextBox();
            this.reservations = new System.Windows.Forms.TabPage();
            this.createLoanButton = new System.Windows.Forms.Button();
            this.updateReservationsButton = new System.Windows.Forms.Button();
            this.reservationsList = new System.Windows.Forms.ListView();
            this.reservationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservationBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservationStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loans = new System.Windows.Forms.TabPage();
            this.updateLoansButton = new System.Windows.Forms.Button();
            this.loansList = new System.Windows.Forms.ListView();
            this.loanId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.profile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.reservations.SuspendLayout();
            this.loans.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profile);
            this.tabControl1.Controls.Add(this.reservations);
            this.tabControl1.Controls.Add(this.loans);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // profile
            // 
            this.profile.Controls.Add(this.panel1);
            this.profile.Location = new System.Drawing.Point(4, 22);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(776, 535);
            this.profile.TabIndex = 0;
            this.profile.Text = "Аккаунт";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.changeProfileButton);
            this.panel1.Controls.Add(this.profilePhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.profileFirstName);
            this.panel1.Controls.Add(this.profileEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.profileLastName);
            this.panel1.Location = new System.Drawing.Point(247, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 419);
            this.panel1.TabIndex = 10;
            // 
            // changeProfileButton
            // 
            this.changeProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeProfileButton.Location = new System.Drawing.Point(47, 301);
            this.changeProfileButton.Name = "changeProfileButton";
            this.changeProfileButton.Size = new System.Drawing.Size(194, 38);
            this.changeProfileButton.TabIndex = 9;
            this.changeProfileButton.Text = "Применить изменения";
            this.changeProfileButton.UseVisualStyleBackColor = true;
            this.changeProfileButton.Click += new System.EventHandler(this.ChangeProfileButton_Click);
            // 
            // profilePhone
            // 
            this.profilePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // reservations
            // 
            this.reservations.Controls.Add(this.createLoanButton);
            this.reservations.Controls.Add(this.updateReservationsButton);
            this.reservations.Controls.Add(this.reservationsList);
            this.reservations.Location = new System.Drawing.Point(4, 22);
            this.reservations.Name = "reservations";
            this.reservations.Padding = new System.Windows.Forms.Padding(3);
            this.reservations.Size = new System.Drawing.Size(776, 535);
            this.reservations.TabIndex = 1;
            this.reservations.Text = "Заявки";
            this.reservations.UseVisualStyleBackColor = true;
            // 
            // createLoanButton
            // 
            this.createLoanButton.Location = new System.Drawing.Point(681, 88);
            this.createLoanButton.Name = "createLoanButton";
            this.createLoanButton.Size = new System.Drawing.Size(75, 49);
            this.createLoanButton.TabIndex = 3;
            this.createLoanButton.Text = "Выдать книгу";
            this.createLoanButton.UseVisualStyleBackColor = true;
            this.createLoanButton.Click += new System.EventHandler(this.CreateLoanButton_Click);
            // 
            // updateReservationsButton
            // 
            this.updateReservationsButton.Location = new System.Drawing.Point(681, 24);
            this.updateReservationsButton.Name = "updateReservationsButton";
            this.updateReservationsButton.Size = new System.Drawing.Size(75, 49);
            this.updateReservationsButton.TabIndex = 2;
            this.updateReservationsButton.Text = "Обновить";
            this.updateReservationsButton.UseVisualStyleBackColor = true;
            this.updateReservationsButton.Click += new System.EventHandler(this.UpdateReservationsButton_Click);
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
            this.reservationsList.Location = new System.Drawing.Point(32, 24);
            this.reservationsList.Name = "reservationsList";
            this.reservationsList.Size = new System.Drawing.Size(634, 468);
            this.reservationsList.TabIndex = 1;
            this.reservationsList.UseCompatibleStateImageBehavior = false;
            this.reservationsList.View = System.Windows.Forms.View.Details;
            this.reservationsList.DoubleClick += new System.EventHandler(this.ReservationsList_DoubleClick);
            // 
            // reservationId
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
            // loans
            // 
            this.loans.Controls.Add(this.button1);
            this.loans.Controls.Add(this.updateLoansButton);
            this.loans.Controls.Add(this.loansList);
            this.loans.Location = new System.Drawing.Point(4, 22);
            this.loans.Name = "loans";
            this.loans.Size = new System.Drawing.Size(776, 535);
            this.loans.TabIndex = 2;
            this.loans.Text = "Взятые книги";
            this.loans.UseVisualStyleBackColor = true;
            // 
            // updateLoansButton
            // 
            this.updateLoansButton.Location = new System.Drawing.Point(677, 24);
            this.updateLoansButton.Name = "updateLoansButton";
            this.updateLoansButton.Size = new System.Drawing.Size(75, 49);
            this.updateLoansButton.TabIndex = 5;
            this.updateLoansButton.Text = "Обновить";
            this.updateLoansButton.UseVisualStyleBackColor = true;
            this.updateLoansButton.Click += new System.EventHandler(this.UpdateLoansButton_Click);
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
            this.loansList.Location = new System.Drawing.Point(26, 24);
            this.loansList.Name = "loansList";
            this.loansList.Size = new System.Drawing.Size(634, 468);
            this.loansList.TabIndex = 4;
            this.loansList.UseCompatibleStateImageBehavior = false;
            this.loansList.View = System.Windows.Forms.View.Details;
            this.loansList.DoubleClick += new System.EventHandler(this.LoansList_DoubleClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выдать книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateLoanWithoutReservation_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MemberForm";
            this.Text = "Читатель";
            this.tabControl1.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.reservations.ResumeLayout(false);
            this.loans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabPage reservations;
        private System.Windows.Forms.TabPage loans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeProfileButton;
        private System.Windows.Forms.TextBox profilePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profileFirstName;
        private System.Windows.Forms.TextBox profileEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox profileLastName;
        private System.Windows.Forms.ListView reservationsList;
        private System.Windows.Forms.ColumnHeader reservationId;
        private System.Windows.Forms.ColumnHeader reservationBook;
        private System.Windows.Forms.ColumnHeader reservationDate;
        private System.Windows.Forms.ColumnHeader reservationStatus;
        private System.Windows.Forms.ListView loansList;
        private System.Windows.Forms.ColumnHeader loanId;
        private System.Windows.Forms.ColumnHeader loanBook;
        private System.Windows.Forms.ColumnHeader loanDate;
        private System.Windows.Forms.ColumnHeader loanStatus;
        private System.Windows.Forms.Button updateReservationsButton;
        private System.Windows.Forms.Button updateLoansButton;
        private System.Windows.Forms.Button createLoanButton;
        private System.Windows.Forms.Button button1;
    }
}