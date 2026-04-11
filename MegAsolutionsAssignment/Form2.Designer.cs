namespace MegAsolutionsAssignment
{
    partial class Form2
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
            this.listbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintslip = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 25;
            this.listbox.Location = new System.Drawing.Point(364, 19);
            this.listbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(441, 404);
            this.listbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPrintslip);
            this.panel1.Controls.Add(this.txtHours);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listbox);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 466);
            this.panel1.TabIndex = 1;
            // 
            // btnPrintslip
            // 
            this.btnPrintslip.Location = new System.Drawing.Point(79, 330);
            this.btnPrintslip.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrintslip.Name = "btnPrintslip";
            this.btnPrintslip.Size = new System.Drawing.Size(150, 44);
            this.btnPrintslip.TabIndex = 8;
            this.btnPrintslip.Text = "PrintSlip";
            this.btnPrintslip.UseVisualStyleBackColor = true;
            this.btnPrintslip.Click += new System.EventHandler(this.btnPrintslip_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(61, 244);
            this.txtHours.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(196, 30);
            this.txtHours.TabIndex = 7;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(61, 142);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(196, 30);
            this.txtSalary.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(61, 44);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(291, 30);
            this.txtFullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hours worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Full Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 504);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "Print slip solutions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintslip;
    }
}