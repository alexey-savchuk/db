namespace Library.AdminForms
{
    partial class ReservationForm
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
            this.reservationBook = new System.Windows.Forms.TextBox();
            this.reservationSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reservationAuthors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reservationDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reservationStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reservationBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reservationShelfMark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateReservationButton = new System.Windows.Forms.Button();
            this.selectStatusButton = new System.Windows.Forms.Button();
            this.statusList = new System.Windows.Forms.ListView();
            this.statusId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Книга";
            // 
            // reservationBook
            // 
            this.reservationBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationBook.Enabled = false;
            this.reservationBook.Location = new System.Drawing.Point(122, 35);
            this.reservationBook.Name = "reservationBook";
            this.reservationBook.Size = new System.Drawing.Size(495, 20);
            this.reservationBook.TabIndex = 1;
            // 
            // reservationSubject
            // 
            this.reservationSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationSubject.Enabled = false;
            this.reservationSubject.Location = new System.Drawing.Point(122, 142);
            this.reservationSubject.Name = "reservationSubject";
            this.reservationSubject.Size = new System.Drawing.Size(495, 20);
            this.reservationSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(119, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Предмет";
            // 
            // reservationAuthors
            // 
            this.reservationAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationAuthors.Enabled = false;
            this.reservationAuthors.Location = new System.Drawing.Point(122, 87);
            this.reservationAuthors.Name = "reservationAuthors";
            this.reservationAuthors.Size = new System.Drawing.Size(495, 20);
            this.reservationAuthors.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(119, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор(ы)";
            // 
            // reservationDate
            // 
            this.reservationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationDate.Enabled = false;
            this.reservationDate.Location = new System.Drawing.Point(122, 306);
            this.reservationDate.Name = "reservationDate";
            this.reservationDate.Size = new System.Drawing.Size(495, 20);
            this.reservationDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(119, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата заявки";
            // 
            // reservationStatus
            // 
            this.reservationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationStatus.Enabled = false;
            this.reservationStatus.Location = new System.Drawing.Point(122, 360);
            this.reservationStatus.Name = "reservationStatus";
            this.reservationStatus.Size = new System.Drawing.Size(495, 20);
            this.reservationStatus.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(119, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статус";
            // 
            // reservationBarcode
            // 
            this.reservationBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationBarcode.Enabled = false;
            this.reservationBarcode.Location = new System.Drawing.Point(122, 200);
            this.reservationBarcode.Name = "reservationBarcode";
            this.reservationBarcode.Size = new System.Drawing.Size(495, 20);
            this.reservationBarcode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(119, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Штрих-код";
            // 
            // reservationShelfMark
            // 
            this.reservationShelfMark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationShelfMark.Enabled = false;
            this.reservationShelfMark.Location = new System.Drawing.Point(122, 252);
            this.reservationShelfMark.Name = "reservationShelfMark";
            this.reservationShelfMark.Size = new System.Drawing.Size(495, 20);
            this.reservationShelfMark.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(119, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Место в библиотеке";
            // 
            // updateReservationButton
            // 
            this.updateReservationButton.Location = new System.Drawing.Point(482, 446);
            this.updateReservationButton.Name = "updateReservationButton";
            this.updateReservationButton.Size = new System.Drawing.Size(90, 62);
            this.updateReservationButton.TabIndex = 21;
            this.updateReservationButton.Text = "Обновить";
            this.updateReservationButton.UseVisualStyleBackColor = true;
            this.updateReservationButton.Click += new System.EventHandler(this.UpdateReservationButton_Click);
            // 
            // selectStatusButton
            // 
            this.selectStatusButton.Location = new System.Drawing.Point(482, 408);
            this.selectStatusButton.Name = "selectStatusButton";
            this.selectStatusButton.Size = new System.Drawing.Size(125, 32);
            this.selectStatusButton.TabIndex = 20;
            this.selectStatusButton.Text = "Выбрать";
            this.selectStatusButton.UseVisualStyleBackColor = true;
            this.selectStatusButton.Click += new System.EventHandler(this.SelectStatusButton_Click);
            // 
            // statusList
            // 
            this.statusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusId,
            this.statusName});
            this.statusList.FullRowSelect = true;
            this.statusList.HideSelection = false;
            this.statusList.Location = new System.Drawing.Point(135, 408);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(341, 113);
            this.statusList.TabIndex = 19;
            this.statusList.UseCompatibleStateImageBehavior = false;
            this.statusList.View = System.Windows.Forms.View.Details;
            // 
            // statusId
            // 
            this.statusId.Text = "statusId";
            this.statusId.Width = 0;
            // 
            // statusName
            // 
            this.statusName.Text = "Название";
            this.statusName.Width = 241;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 550);
            this.Controls.Add(this.updateReservationButton);
            this.Controls.Add(this.selectStatusButton);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.reservationShelfMark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reservationBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reservationStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reservationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reservationAuthors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reservationSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reservationBook);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reservationBook;
        private System.Windows.Forms.TextBox reservationSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reservationAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reservationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reservationStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reservationBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reservationShelfMark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateReservationButton;
        private System.Windows.Forms.Button selectStatusButton;
        private System.Windows.Forms.ListView statusList;
        private System.Windows.Forms.ColumnHeader statusId;
        private System.Windows.Forms.ColumnHeader statusName;
    }
}