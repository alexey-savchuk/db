namespace Library.AdminForms
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.profilePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitRegistrationButton = new System.Windows.Forms.Button();
            this.profilePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profileFirstName = new System.Windows.Forms.TextBox();
            this.profileEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.profileLastName = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.roleComboBox);
            this.panel1.Controls.Add(this.profilePassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.submitRegistrationButton);
            this.panel1.Controls.Add(this.profilePhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.profileFirstName);
            this.panel1.Controls.Add(this.profileEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.profileLastName);
            this.panel1.Location = new System.Drawing.Point(63, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 470);
            this.panel1.TabIndex = 0;
            // 
            // profilePassword
            // 
            this.profilePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePassword.Location = new System.Drawing.Point(22, 278);
            this.profilePassword.Name = "profilePassword";
            this.profilePassword.Size = new System.Drawing.Size(231, 20);
            this.profilePassword.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(19, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Пароль";
            // 
            // submitRegistrationButton
            // 
            this.submitRegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitRegistrationButton.Location = new System.Drawing.Point(22, 391);
            this.submitRegistrationButton.Name = "submitRegistrationButton";
            this.submitRegistrationButton.Size = new System.Drawing.Size(231, 57);
            this.submitRegistrationButton.TabIndex = 18;
            this.submitRegistrationButton.Text = "Завершить регистрацию";
            this.submitRegistrationButton.UseVisualStyleBackColor = true;
            this.submitRegistrationButton.Click += new System.EventHandler(this.SubmitRegistrationButton_Click);
            // 
            // profilePhone
            // 
            this.profilePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePhone.Location = new System.Drawing.Point(22, 218);
            this.profilePhone.Name = "profilePhone";
            this.profilePhone.Size = new System.Drawing.Size(231, 20);
            this.profilePhone.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(19, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Телефон";
            // 
            // profileFirstName
            // 
            this.profileFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileFirstName.Location = new System.Drawing.Point(22, 43);
            this.profileFirstName.Name = "profileFirstName";
            this.profileFirstName.Size = new System.Drawing.Size(231, 20);
            this.profileFirstName.TabIndex = 11;
            // 
            // profileEmail
            // 
            this.profileEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileEmail.Location = new System.Drawing.Point(22, 161);
            this.profileEmail.Name = "profileEmail";
            this.profileEmail.Size = new System.Drawing.Size(231, 20);
            this.profileEmail.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // profileLastName
            // 
            this.profileLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileLastName.Location = new System.Drawing.Point(22, 103);
            this.profileLastName.Name = "profileLastName";
            this.profileLastName.Size = new System.Drawing.Size(231, 20);
            this.profileLastName.TabIndex = 13;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(22, 335);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(231, 21);
            this.roleComboBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(19, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Роль";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 521);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "Регистрация читателя";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox profilePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitRegistrationButton;
        private System.Windows.Forms.TextBox profilePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profileFirstName;
        private System.Windows.Forms.TextBox profileEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox profileLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}