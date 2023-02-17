namespace Form_task
{
    partial class Name
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
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.BirthLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.Maleradiobtn = new System.Windows.Forms.RadioButton();
            this.Femaleradiobtn = new System.Windows.Forms.RadioButton();
            this.FormLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.namechecklbl = new System.Windows.Forms.Label();
            this.surnamechecklbl = new System.Windows.Forms.Label();
            this.emailcheck = new System.Windows.Forms.Label();
            this.AgemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.agechecklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(12, 170);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(225, 22);
            this.EmailtextBox.TabIndex = 2;
            this.EmailtextBox.TextChanged += new System.EventHandler(this.EmailtextBox_TextChanged);
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Location = new System.Drawing.Point(340, 107);
            this.SurnametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(226, 22);
            this.SurnametextBox.TabIndex = 3;
            this.SurnametextBox.TextChanged += new System.EventHandler(this.SurnametextBox_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(16, 107);
            this.NametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(252, 22);
            this.NametextBox.TabIndex = 4;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Tomato;
            this.NameLbl.Font = new System.Drawing.Font("Dollar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(13, 84);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(63, 14);
            this.NameLbl.TabIndex = 6;
            this.NameLbl.Text = "Name";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.BackColor = System.Drawing.Color.Tomato;
            this.SurnameLbl.Font = new System.Drawing.Font("Dollar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLbl.Location = new System.Drawing.Point(336, 84);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(105, 14);
            this.SurnameLbl.TabIndex = 7;
            this.SurnameLbl.Text = "Surname";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.BackColor = System.Drawing.Color.Tomato;
            this.AgeLbl.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.Location = new System.Drawing.Point(336, 146);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(33, 15);
            this.AgeLbl.TabIndex = 8;
            this.AgeLbl.Text = "Age";
            this.AgeLbl.Click += new System.EventHandler(this.AgeLbl_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(338, 243);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 24);
            this.dateTimePicker.TabIndex = 10;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.BackColor = System.Drawing.Color.Tomato;
            this.EmailLbl.Font = new System.Drawing.Font("CricketHeavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(13, 144);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(45, 13);
            this.EmailLbl.TabIndex = 11;
            this.EmailLbl.Text = "Email";
            // 
            // BirthLbl
            // 
            this.BirthLbl.AutoSize = true;
            this.BirthLbl.BackColor = System.Drawing.Color.Tomato;
            this.BirthLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthLbl.Location = new System.Drawing.Point(334, 221);
            this.BirthLbl.Name = "BirthLbl";
            this.BirthLbl.Size = new System.Drawing.Size(69, 18);
            this.BirthLbl.TabIndex = 14;
            this.BirthLbl.Text = "Birth date";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.BackColor = System.Drawing.Color.Teal;
            this.GenderLbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderLbl.Location = new System.Drawing.Point(255, 311);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(53, 19);
            this.GenderLbl.TabIndex = 15;
            this.GenderLbl.Text = "Gender";
            // 
            // Maleradiobtn
            // 
            this.Maleradiobtn.AutoSize = true;
            this.Maleradiobtn.BackColor = System.Drawing.Color.Transparent;
            this.Maleradiobtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Maleradiobtn.Location = new System.Drawing.Point(252, 338);
            this.Maleradiobtn.Name = "Maleradiobtn";
            this.Maleradiobtn.Size = new System.Drawing.Size(56, 23);
            this.Maleradiobtn.TabIndex = 16;
            this.Maleradiobtn.TabStop = true;
            this.Maleradiobtn.Text = "Male";
            this.Maleradiobtn.UseVisualStyleBackColor = false;
            // 
            // Femaleradiobtn
            // 
            this.Femaleradiobtn.AutoSize = true;
            this.Femaleradiobtn.BackColor = System.Drawing.Color.Transparent;
            this.Femaleradiobtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Femaleradiobtn.Location = new System.Drawing.Point(252, 367);
            this.Femaleradiobtn.Name = "Femaleradiobtn";
            this.Femaleradiobtn.Size = new System.Drawing.Size(70, 23);
            this.Femaleradiobtn.TabIndex = 17;
            this.Femaleradiobtn.TabStop = true;
            this.Femaleradiobtn.Text = "Female";
            this.Femaleradiobtn.UseVisualStyleBackColor = false;
            // 
            // FormLbl
            // 
            this.FormLbl.AutoSize = true;
            this.FormLbl.BackColor = System.Drawing.Color.Blue;
            this.FormLbl.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLbl.Location = new System.Drawing.Point(247, -1);
            this.FormLbl.Name = "FormLbl";
            this.FormLbl.Size = new System.Drawing.Size(143, 67);
            this.FormLbl.TabIndex = 18;
            this.FormLbl.Text = "Form";
            this.FormLbl.Click += new System.EventHandler(this.FormLbl_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Gray;
            this.LoginBtn.Location = new System.Drawing.Point(439, 311);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(109, 49);
            this.LoginBtn.TabIndex = 19;
            this.LoginBtn.Text = "Log In";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // namechecklbl
            // 
            this.namechecklbl.AutoSize = true;
            this.namechecklbl.Location = new System.Drawing.Point(19, 113);
            this.namechecklbl.Name = "namechecklbl";
            this.namechecklbl.Size = new System.Drawing.Size(0, 16);
            this.namechecklbl.TabIndex = 20;
            // 
            // surnamechecklbl
            // 
            this.surnamechecklbl.AutoSize = true;
            this.surnamechecklbl.Location = new System.Drawing.Point(337, 115);
            this.surnamechecklbl.Name = "surnamechecklbl";
            this.surnamechecklbl.Size = new System.Drawing.Size(0, 16);
            this.surnamechecklbl.TabIndex = 22;
            // 
            // emailcheck
            // 
            this.emailcheck.AutoSize = true;
            this.emailcheck.Location = new System.Drawing.Point(337, 192);
            this.emailcheck.Name = "emailcheck";
            this.emailcheck.Size = new System.Drawing.Size(0, 16);
            this.emailcheck.TabIndex = 23;
            // 
            // AgemaskedTextBox
            // 
            this.AgemaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgemaskedTextBox.Location = new System.Drawing.Point(338, 168);
            this.AgemaskedTextBox.Mask = "000";
            this.AgemaskedTextBox.Name = "AgemaskedTextBox";
            this.AgemaskedTextBox.Size = new System.Drawing.Size(100, 24);
            this.AgemaskedTextBox.TabIndex = 9;
            this.AgemaskedTextBox.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(12, 245);
            this.maskedTextBox2.Mask = "(999) 00-000-00-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(271, 22);
            this.maskedTextBox2.TabIndex = 12;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.BackColor = System.Drawing.Color.Tomato;
            this.PhoneLbl.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLbl.Location = new System.Drawing.Point(12, 223);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(46, 15);
            this.PhoneLbl.TabIndex = 13;
            this.PhoneLbl.Text = "Phone";
            // 
            // agechecklbl
            // 
            this.agechecklbl.AutoSize = true;
            this.agechecklbl.Location = new System.Drawing.Point(19, 193);
            this.agechecklbl.Name = "agechecklbl";
            this.agechecklbl.Size = new System.Drawing.Size(0, 16);
            this.agechecklbl.TabIndex = 21;
            this.agechecklbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(663, 387);
            this.Controls.Add(this.emailcheck);
            this.Controls.Add(this.surnamechecklbl);
            this.Controls.Add(this.agechecklbl);
            this.Controls.Add(this.namechecklbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.FormLbl);
            this.Controls.Add(this.Femaleradiobtn);
            this.Controls.Add(this.Maleradiobtn);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.BirthLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.AgemaskedTextBox);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.SurnametextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Name";
            this.Text = "Name";
            this.Load += new System.EventHandler(this.Name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox SurnametextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label BirthLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.RadioButton Maleradiobtn;
        private System.Windows.Forms.RadioButton Femaleradiobtn;
        private System.Windows.Forms.Label FormLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label namechecklbl;
        private System.Windows.Forms.Label surnamechecklbl;
        private System.Windows.Forms.Label emailcheck;
        private System.Windows.Forms.MaskedTextBox AgemaskedTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label agechecklbl;
    }
}

