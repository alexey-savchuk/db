namespace Library.AdminForms
{
    partial class AddBookItemForm
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
            this.addBookItemButton = new System.Windows.Forms.Button();
            this.selectStatusButton = new System.Windows.Forms.Button();
            this.statusList = new System.Windows.Forms.ListView();
            this.statusId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shelfMarkTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBookItemButton
            // 
            this.addBookItemButton.Location = new System.Drawing.Point(601, 323);
            this.addBookItemButton.Name = "addBookItemButton";
            this.addBookItemButton.Size = new System.Drawing.Size(90, 62);
            this.addBookItemButton.TabIndex = 27;
            this.addBookItemButton.Text = "Добавить";
            this.addBookItemButton.UseVisualStyleBackColor = true;
            this.addBookItemButton.Click += new System.EventHandler(this.AddBookItemButton_Click);
            // 
            // selectStatusButton
            // 
            this.selectStatusButton.Location = new System.Drawing.Point(431, 196);
            this.selectStatusButton.Name = "selectStatusButton";
            this.selectStatusButton.Size = new System.Drawing.Size(125, 32);
            this.selectStatusButton.TabIndex = 26;
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
            this.statusList.Location = new System.Drawing.Point(67, 196);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(325, 189);
            this.statusList.TabIndex = 25;
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
            // shelfMarkTextBox
            // 
            this.shelfMarkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shelfMarkTextBox.Location = new System.Drawing.Point(67, 103);
            this.shelfMarkTextBox.Name = "shelfMarkTextBox";
            this.shelfMarkTextBox.Size = new System.Drawing.Size(325, 20);
            this.shelfMarkTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(64, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Место в библиотеке";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(67, 158);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(325, 20);
            this.statusTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(64, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Статус";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeTextBox.Location = new System.Drawing.Point(67, 51);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(325, 20);
            this.barcodeTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Штрих-код";
            // 
            // AddBookItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.addBookItemButton);
            this.Controls.Add(this.selectStatusButton);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.shelfMarkTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddBookItemForm";
            this.Text = "AddBookItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBookItemButton;
        private System.Windows.Forms.Button selectStatusButton;
        private System.Windows.Forms.ListView statusList;
        private System.Windows.Forms.ColumnHeader statusId;
        private System.Windows.Forms.ColumnHeader statusName;
        private System.Windows.Forms.TextBox shelfMarkTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label1;
    }
}