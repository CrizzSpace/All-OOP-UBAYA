namespace MargaretOvoAccount
{
    partial class FormBuy
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
            this.groupBoxBuy = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.groupBoxBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(144, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 57);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buy Items";
            // 
            // groupBoxBuy
            // 
            this.groupBoxBuy.Controls.Add(this.comboBoxItems);
            this.groupBoxBuy.Controls.Add(this.textBoxPrice);
            this.groupBoxBuy.Controls.Add(this.label3);
            this.groupBoxBuy.Controls.Add(this.label2);
            this.groupBoxBuy.Controls.Add(this.comboBoxAccount);
            this.groupBoxBuy.Controls.Add(this.buttonClose);
            this.groupBoxBuy.Controls.Add(this.buttonBuy);
            this.groupBoxBuy.Controls.Add(this.label5);
            this.groupBoxBuy.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxBuy.Location = new System.Drawing.Point(24, 77);
            this.groupBoxBuy.Name = "groupBoxBuy";
            this.groupBoxBuy.Size = new System.Drawing.Size(430, 212);
            this.groupBoxBuy.TabIndex = 41;
            this.groupBoxBuy.TabStop = false;
            this.groupBoxBuy.Text = "Buy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Items to Buy :";
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(160, 34);
            this.comboBoxAccount.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(195, 27);
            this.comboBoxAccount.TabIndex = 37;
            this.comboBoxAccount.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAccount_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.Location = new System.Drawing.Point(265, 159);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 28);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.White;
            this.buttonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuy.FlatAppearance.BorderSize = 0;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuy.Location = new System.Drawing.Point(160, 159);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(90, 28);
            this.buttonBuy.TabIndex = 8;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(161, 116);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(132, 25);
            this.textBoxPrice.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Price :";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Electricity Voucher",
            "Internet Voucher"});
            this.comboBoxItems.Location = new System.Drawing.Point(160, 74);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(195, 27);
            this.comboBoxItems.TabIndex = 42;
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(475, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxBuy);
            this.Name = "FormBuy";
            this.Text = "FormBuy";
            this.Load += new System.EventHandler(this.FormBuy_Load);
            this.groupBoxBuy.ResumeLayout(false);
            this.groupBoxBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxItems;
    }
}