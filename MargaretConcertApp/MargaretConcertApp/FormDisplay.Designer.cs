namespace MargaretConcertApp
{
    partial class FormDisplay
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
            this.comboBoxConcert = new System.Windows.Forms.ComboBox();
            this.buttonThis = new System.Windows.Forms.Button();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxConcert
            // 
            this.comboBoxConcert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConcert.FormattingEnabled = true;
            this.comboBoxConcert.Location = new System.Drawing.Point(357, 401);
            this.comboBoxConcert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxConcert.Name = "comboBoxConcert";
            this.comboBoxConcert.Size = new System.Drawing.Size(235, 28);
            this.comboBoxConcert.TabIndex = 9;
            this.comboBoxConcert.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConcert_SelectedIndexChanged);
            // 
            // buttonThis
            // 
            this.buttonThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThis.Location = new System.Drawing.Point(615, 401);
            this.buttonThis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThis.Name = "buttonThis";
            this.buttonThis.Size = new System.Drawing.Size(167, 28);
            this.buttonThis.TabIndex = 8;
            this.buttonThis.Text = "Show This Concert";
            this.buttonThis.UseVisualStyleBackColor = true;
            this.buttonThis.Click += new System.EventHandler(this.ButtonThis_Click);
            // 
            // buttonMonth
            // 
            this.buttonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonth.Location = new System.Drawing.Point(136, 401);
            this.buttonMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(197, 28);
            this.buttonMonth.TabIndex = 7;
            this.buttonMonth.Text = "Concert This Month";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.ButtonMonth_Click);
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayAll.Location = new System.Drawing.Point(12, 401);
            this.buttonDisplayAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(100, 28);
            this.buttonDisplayAll.TabIndex = 6;
            this.buttonDisplayAll.Text = "Display All";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.ButtonDisplayAll_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 20;
            this.listBoxData.Location = new System.Drawing.Point(16, 15);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(764, 324);
            this.listBoxData.TabIndex = 5;
            // 
            // FormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.comboBoxConcert);
            this.Controls.Add(this.buttonThis);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.listBoxData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDisplay";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxConcert;
        private System.Windows.Forms.Button buttonThis;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.ListBox listBoxData;
    }
}