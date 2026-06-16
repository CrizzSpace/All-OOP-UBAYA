namespace MargaretOvoAccount
{
    partial class FormTopUp
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
            this.groupBoxTopUp = new System.Windows.Forms.GroupBox();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonTopUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNominalTopUp = new System.Windows.Forms.TextBox();
            this.groupBoxTopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(167, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 57);
            this.label1.TabIndex = 40;
            this.label1.Text = "Top Up";
            // 
            // groupBoxTopUp
            // 
            this.groupBoxTopUp.Controls.Add(this.textBoxNominalTopUp);
            this.groupBoxTopUp.Controls.Add(this.label2);
            this.groupBoxTopUp.Controls.Add(this.comboBoxAccount);
            this.groupBoxTopUp.Controls.Add(this.buttonClose);
            this.groupBoxTopUp.Controls.Add(this.buttonTopUp);
            this.groupBoxTopUp.Controls.Add(this.label5);
            this.groupBoxTopUp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTopUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxTopUp.Location = new System.Drawing.Point(31, 84);
            this.groupBoxTopUp.Name = "groupBoxTopUp";
            this.groupBoxTopUp.Size = new System.Drawing.Size(430, 173);
            this.groupBoxTopUp.TabIndex = 39;
            this.groupBoxTopUp.TabStop = false;
            this.groupBoxTopUp.Text = "Top Up";
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(160, 38);
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
            this.buttonClose.Location = new System.Drawing.Point(265, 118);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 28);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonTopUp
            // 
            this.buttonTopUp.BackColor = System.Drawing.Color.White;
            this.buttonTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTopUp.FlatAppearance.BorderSize = 0;
            this.buttonTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopUp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTopUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTopUp.Location = new System.Drawing.Point(160, 118);
            this.buttonTopUp.Name = "buttonTopUp";
            this.buttonTopUp.Size = new System.Drawing.Size(90, 28);
            this.buttonTopUp.TabIndex = 8;
            this.buttonTopUp.Text = "TOP UP";
            this.buttonTopUp.UseVisualStyleBackColor = false;
            this.buttonTopUp.Click += new System.EventHandler(this.ButtonTopUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nominal Top Up :";
            // 
            // textBoxNominalTopUp
            // 
            this.textBoxNominalTopUp.Location = new System.Drawing.Point(161, 76);
            this.textBoxNominalTopUp.Name = "textBoxNominalTopUp";
            this.textBoxNominalTopUp.Size = new System.Drawing.Size(132, 25);
            this.textBoxNominalTopUp.TabIndex = 39;
            // 
            // FormTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(490, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTopUp);
            this.Name = "FormTopUp";
            this.Text = "FormTopUp";
            this.Load += new System.EventHandler(this.FormTopUp_Load);
            this.groupBoxTopUp.ResumeLayout(false);
            this.groupBoxTopUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTopUp;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonTopUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNominalTopUp;
    }
}