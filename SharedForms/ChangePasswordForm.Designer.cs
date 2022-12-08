namespace Library.SharedForms
{
    partial class ChangePasswordForm
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
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitPasswordButton = new System.Windows.Forms.Button();
            this.showPasswordCheckBox1 = new System.Windows.Forms.CheckBox();
            this.showPasswordCheckBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старый пароль";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(83, 37);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '*';
            this.oldPasswordTextBox.Size = new System.Drawing.Size(125, 20);
            this.oldPasswordTextBox.TabIndex = 1;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(83, 93);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(125, 20);
            this.newPasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новый пароль";
            // 
            // SubmitPasswordButton
            // 
            this.SubmitPasswordButton.Location = new System.Drawing.Point(103, 141);
            this.SubmitPasswordButton.Name = "SubmitPasswordButton";
            this.SubmitPasswordButton.Size = new System.Drawing.Size(95, 27);
            this.SubmitPasswordButton.TabIndex = 4;
            this.SubmitPasswordButton.Text = "Изменить";
            this.SubmitPasswordButton.UseVisualStyleBackColor = true;
            this.SubmitPasswordButton.Click += new System.EventHandler(this.SubmitPasswordButton_Click);
            // 
            // showPasswordCheckBox1
            // 
            this.showPasswordCheckBox1.AutoSize = true;
            this.showPasswordCheckBox1.Location = new System.Drawing.Point(214, 40);
            this.showPasswordCheckBox1.Name = "showPasswordCheckBox1";
            this.showPasswordCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.showPasswordCheckBox1.TabIndex = 5;
            this.showPasswordCheckBox1.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox1.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox1_CheckedChanged);
            // 
            // showPasswordCheckBox2
            // 
            this.showPasswordCheckBox2.AutoSize = true;
            this.showPasswordCheckBox2.Location = new System.Drawing.Point(214, 96);
            this.showPasswordCheckBox2.Name = "showPasswordCheckBox2";
            this.showPasswordCheckBox2.Size = new System.Drawing.Size(15, 14);
            this.showPasswordCheckBox2.TabIndex = 6;
            this.showPasswordCheckBox2.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox2.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox2_CheckedChanged);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.showPasswordCheckBox2);
            this.Controls.Add(this.showPasswordCheckBox1);
            this.Controls.Add(this.SubmitPasswordButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitPasswordButton;
        private System.Windows.Forms.CheckBox showPasswordCheckBox1;
        private System.Windows.Forms.CheckBox showPasswordCheckBox2;
    }
}