namespace MargaretOvoAccount
{
    partial class Form1
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
            this.groupBoxTopUp = new System.Windows.Forms.GroupBox();
            this.buttonTopUp = new System.Windows.Forms.Button();
            this.textBoxNominalTopUp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBuy = new System.Windows.Forms.GroupBox();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.buttonDisplayData = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxOvoID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRegisterAccount = new System.Windows.Forms.GroupBox();
            this.groupBoxDisplayData = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSelectAccount = new System.Windows.Forms.ComboBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxTopUp.SuspendLayout();
            this.groupBoxBuy.SuspendLayout();
            this.groupBoxRegisterAccount.SuspendLayout();
            this.groupBoxDisplayData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTopUp
            // 
            this.groupBoxTopUp.Controls.Add(this.buttonTopUp);
            this.groupBoxTopUp.Controls.Add(this.textBoxNominalTopUp);
            this.groupBoxTopUp.Controls.Add(this.label7);
            this.groupBoxTopUp.Location = new System.Drawing.Point(30, 293);
            this.groupBoxTopUp.Name = "groupBoxTopUp";
            this.groupBoxTopUp.Size = new System.Drawing.Size(326, 140);
            this.groupBoxTopUp.TabIndex = 32;
            this.groupBoxTopUp.TabStop = false;
            this.groupBoxTopUp.Text = "Top Up";
            // 
            // buttonTopUp
            // 
            this.buttonTopUp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTopUp.Location = new System.Drawing.Point(109, 76);
            this.buttonTopUp.Name = "buttonTopUp";
            this.buttonTopUp.Size = new System.Drawing.Size(90, 28);
            this.buttonTopUp.TabIndex = 8;
            this.buttonTopUp.Text = "TOP UP";
            this.buttonTopUp.UseVisualStyleBackColor = false;
            this.buttonTopUp.Click += new System.EventHandler(this.ButtonTopUp_Click);
            // 
            // textBoxNominalTopUp
            // 
            this.textBoxNominalTopUp.Location = new System.Drawing.Point(109, 42);
            this.textBoxNominalTopUp.Name = "textBoxNominalTopUp";
            this.textBoxNominalTopUp.Size = new System.Drawing.Size(178, 20);
            this.textBoxNominalTopUp.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nominal Top Up :";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(680, 438);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 28);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Electricity Voucher",
            "Internet Voucher"});
            this.comboBoxItems.Location = new System.Drawing.Point(129, 28);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(166, 21);
            this.comboBoxItems.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Items to Buy :";
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(129, 96);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(90, 28);
            this.buttonBuy.TabIndex = 8;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(129, 63);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(104, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price :";
            // 
            // groupBoxBuy
            // 
            this.groupBoxBuy.Controls.Add(this.comboBoxItems);
            this.groupBoxBuy.Controls.Add(this.label6);
            this.groupBoxBuy.Controls.Add(this.buttonBuy);
            this.groupBoxBuy.Controls.Add(this.textBoxPrice);
            this.groupBoxBuy.Controls.Add(this.label5);
            this.groupBoxBuy.Location = new System.Drawing.Point(364, 293);
            this.groupBoxBuy.Name = "groupBoxBuy";
            this.groupBoxBuy.Size = new System.Drawing.Size(406, 140);
            this.groupBoxBuy.TabIndex = 33;
            this.groupBoxBuy.TabStop = false;
            this.groupBoxBuy.Text = "Buy";
            // 
            // buttonClearData
            // 
            this.buttonClearData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearData.Location = new System.Drawing.Point(143, 201);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(117, 28);
            this.buttonClearData.TabIndex = 10;
            this.buttonClearData.Text = "CLEAR DATA";
            this.buttonClearData.UseVisualStyleBackColor = false;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // buttonDisplayData
            // 
            this.buttonDisplayData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDisplayData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayData.Location = new System.Drawing.Point(20, 202);
            this.buttonDisplayData.Name = "buttonDisplayData";
            this.buttonDisplayData.Size = new System.Drawing.Size(117, 28);
            this.buttonDisplayData.TabIndex = 9;
            this.buttonDisplayData.Text = "DISPLAY DATA";
            this.buttonDisplayData.UseVisualStyleBackColor = false;
            this.buttonDisplayData.Click += new System.EventHandler(this.ButtonDisplayData_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(20, 22);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(378, 173);
            this.listBoxData.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(109, 183);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(90, 28);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // textBoxOvoID
            // 
            this.textBoxOvoID.Location = new System.Drawing.Point(109, 146);
            this.textBoxOvoID.Name = "textBoxOvoID";
            this.textBoxOvoID.Size = new System.Drawing.Size(178, 20);
            this.textBoxOvoID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ovo ID :";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(109, 110);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.PasswordChar = '*';
            this.textBoxPIN.Size = new System.Drawing.Size(178, 20);
            this.textBoxPIN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PIN :";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(109, 73);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(178, 20);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // groupBoxRegisterAccount
            // 
            this.groupBoxRegisterAccount.Controls.Add(this.buttonRegister);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxOvoID);
            this.groupBoxRegisterAccount.Controls.Add(this.label4);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxPIN);
            this.groupBoxRegisterAccount.Controls.Add(this.label3);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxRegisterAccount.Controls.Add(this.label2);
            this.groupBoxRegisterAccount.Controls.Add(this.textBoxName);
            this.groupBoxRegisterAccount.Controls.Add(this.label1);
            this.groupBoxRegisterAccount.Location = new System.Drawing.Point(30, 17);
            this.groupBoxRegisterAccount.Name = "groupBoxRegisterAccount";
            this.groupBoxRegisterAccount.Size = new System.Drawing.Size(326, 236);
            this.groupBoxRegisterAccount.TabIndex = 30;
            this.groupBoxRegisterAccount.TabStop = false;
            this.groupBoxRegisterAccount.Text = "Register Account";
            // 
            // groupBoxDisplayData
            // 
            this.groupBoxDisplayData.Controls.Add(this.buttonClearData);
            this.groupBoxDisplayData.Controls.Add(this.buttonDisplayData);
            this.groupBoxDisplayData.Controls.Add(this.listBoxData);
            this.groupBoxDisplayData.Location = new System.Drawing.Point(364, 17);
            this.groupBoxDisplayData.Name = "groupBoxDisplayData";
            this.groupBoxDisplayData.Size = new System.Drawing.Size(406, 236);
            this.groupBoxDisplayData.TabIndex = 31;
            this.groupBoxDisplayData.TabStop = false;
            this.groupBoxDisplayData.Text = "Display Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Select Account";
            // 
            // comboBoxSelectAccount
            // 
            this.comboBoxSelectAccount.FormattingEnabled = true;
            this.comboBoxSelectAccount.Location = new System.Drawing.Point(364, 263);
            this.comboBoxSelectAccount.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSelectAccount.Name = "comboBoxSelectAccount";
            this.comboBoxSelectAccount.Size = new System.Drawing.Size(106, 21);
            this.comboBoxSelectAccount.TabIndex = 36;
            this.comboBoxSelectAccount.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectAccount_SelectedIndexChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(475, 259);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(149, 28);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "REMOVE ACCOUNT";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.comboBoxSelectAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxTopUp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxBuy);
            this.Controls.Add(this.groupBoxRegisterAccount);
            this.Controls.Add(this.groupBoxDisplayData);
            this.Name = "Form1";
            this.Text = "Ovo Simple Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTopUp.ResumeLayout(false);
            this.groupBoxTopUp.PerformLayout();
            this.groupBoxBuy.ResumeLayout(false);
            this.groupBoxBuy.PerformLayout();
            this.groupBoxRegisterAccount.ResumeLayout(false);
            this.groupBoxRegisterAccount.PerformLayout();
            this.groupBoxDisplayData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTopUp;
        private System.Windows.Forms.Button buttonTopUp;
        private System.Windows.Forms.TextBox textBoxNominalTopUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxBuy;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxOvoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRegisterAccount;
        private System.Windows.Forms.GroupBox groupBoxDisplayData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSelectAccount;
        private System.Windows.Forms.Button buttonRemove;
    }
}

