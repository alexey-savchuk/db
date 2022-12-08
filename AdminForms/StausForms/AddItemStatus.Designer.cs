namespace Library.AdminForms.StausForms
{
    partial class AddItemStatusForm
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
            this.statusNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusNameTextBox
            // 
            this.statusNameTextBox.Location = new System.Drawing.Point(119, 103);
            this.statusNameTextBox.MaxLength = 30;
            this.statusNameTextBox.Name = "statusNameTextBox";
            this.statusNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.statusNameTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddStatus_Click);
            // 
            // AddItemStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusNameTextBox);
            this.Name = "AddItemStatusForm";
            this.Text = "AddReservationStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}