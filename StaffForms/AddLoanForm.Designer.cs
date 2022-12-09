namespace Library.StaffForms
{
    partial class AddLoanForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.ListView();
            this.bookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
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
            this.booksList.Location = new System.Drawing.Point(26, 37);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(625, 355);
            this.booksList.TabIndex = 6;
            this.booksList.UseCompatibleStateImageBehavior = false;
            this.booksList.View = System.Windows.Forms.View.Details;
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
            this.bookTitle.Width = 157;
            // 
            // bookAuthors
            // 
            this.bookAuthors.DisplayIndex = 1;
            this.bookAuthors.Text = "Автор(ы)";
            this.bookAuthors.Width = 246;
            // 
            // bookSubject
            // 
            this.bookSubject.DisplayIndex = 2;
            this.bookSubject.Text = "Предмет";
            this.bookSubject.Width = 112;
            // 
            // bookDate
            // 
            this.bookDate.Text = "Год публикации";
            this.bookDate.Width = 93;
            // 
            // AddLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.button1);
            this.Name = "AddLoanForm";
            this.Text = "AddLoanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView booksList;
        private System.Windows.Forms.ColumnHeader bookId;
        private System.Windows.Forms.ColumnHeader bookTitle;
        private System.Windows.Forms.ColumnHeader bookAuthors;
        private System.Windows.Forms.ColumnHeader bookSubject;
        private System.Windows.Forms.ColumnHeader bookDate;
    }
}