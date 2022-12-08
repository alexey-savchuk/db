namespace Library.StaffForms
{
    partial class BookItemForm
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
            this.shelfMarkTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ListView();
            this.statusId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectStatusButton = new System.Windows.Forms.Button();
            this.updateBookItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shelfMarkTextBox
            // 
            this.shelfMarkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shelfMarkTextBox.Location = new System.Drawing.Point(74, 109);
            this.shelfMarkTextBox.Name = "shelfMarkTextBox";
            this.shelfMarkTextBox.Size = new System.Drawing.Size(341, 20);
            this.shelfMarkTextBox.TabIndex = 15;
            this.shelfMarkTextBox.TextChanged += new System.EventHandler(this.shelfMarkTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(71, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Место в библиотеке";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(74, 164);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(341, 20);
            this.statusTextBox.TabIndex = 13;
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(71, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Статус";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeTextBox.Location = new System.Drawing.Point(74, 57);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(341, 20);
            this.barcodeTextBox.TabIndex = 11;
            this.barcodeTextBox.TextChanged += new System.EventHandler(this.barcodeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Штрих-код";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusList
            // 
            this.statusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusId,
            this.statusName});
            this.statusList.FullRowSelect = true;
            this.statusList.HideSelection = false;
            this.statusList.Location = new System.Drawing.Point(74, 202);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(341, 189);
            this.statusList.TabIndex = 16;
            this.statusList.UseCompatibleStateImageBehavior = false;
            this.statusList.View = System.Windows.Forms.View.Details;
            this.statusList.SelectedIndexChanged += new System.EventHandler(this.statusList_SelectedIndexChanged);
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
            // selectStatusButton
            // 
            this.selectStatusButton.Location = new System.Drawing.Point(438, 202);
            this.selectStatusButton.Name = "selectStatusButton";
            this.selectStatusButton.Size = new System.Drawing.Size(125, 32);
            this.selectStatusButton.TabIndex = 17;
            this.selectStatusButton.Text = "Выбрать";
            this.selectStatusButton.UseVisualStyleBackColor = true;
            this.selectStatusButton.Click += new System.EventHandler(this.SelectStatusButton_Click);
            // 
            // updateBookItemButton
            // 
            this.updateBookItemButton.Location = new System.Drawing.Point(611, 345);
            this.updateBookItemButton.Name = "updateBookItemButton";
            this.updateBookItemButton.Size = new System.Drawing.Size(90, 62);
            this.updateBookItemButton.TabIndex = 18;
            this.updateBookItemButton.Text = "Обновить";
            this.updateBookItemButton.UseVisualStyleBackColor = true;
            this.updateBookItemButton.Click += new System.EventHandler(this.UpdateBookItemButton_Click);
            // 
            // BookItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBookItemButton);
            this.Controls.Add(this.selectStatusButton);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.shelfMarkTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BookItemForm";
            this.Text = "BookItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox shelfMarkTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView statusList;
        private System.Windows.Forms.Button selectStatusButton;
        private System.Windows.Forms.Button updateBookItemButton;
        private System.Windows.Forms.ColumnHeader statusId;
        private System.Windows.Forms.ColumnHeader statusName;
    }
}