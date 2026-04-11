using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MegAsolutionsAssignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPrintslip_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            double salary = Convert.ToDouble(txtSalary.Text);
            int hours = Convert.ToInt16(txtHours.Text);
            double grossPay;
            double taxes;
            double netSalary;

            if(hours <= 12){
                grossPay = salary * hours;
                taxes = grossPay * 0.2;
                netSalary = grossPay - taxes;
            }
            else{
                int overtime = hours -12;
                grossPay = (salary * hours) + overtime;
                taxes = grossPay * 0.2;
                netSalary = grossPay - taxes;
            }
            
            listbox.Items.Clear();
            
            listbox.Items.Add("----------------------PAYSLIP--------------------------------\n");
            listbox.Items.Add("--------------MEGA SOLUTIONS CAMPANY-------------------------\n");
            listbox.Items.Add("--------------------------------------------------------------");
            listbox.Items.Add("\n" + "Employee Full Name: " + "\t" + name + "\n");
            listbox.Items.Add("Date of Payment:" + "\t\t" + "2020-12-31\n");
            listbox.Items.Add("--------------------------------------------------------------\n");
            listbox.Items.Add("Normal Hours work:" + "\t\t" + "12h\n");
            listbox.Items.Add("Hours worked:" + "\t\t" + hours + "\n");
            listbox.Items.Add("Salary: " + "\t\t\t" + "R" + salary + "\n");
            listbox.Items.Add("Gross Payment:" + "\t\t" + "R" + grossPay + "\n");
            listbox.Items.Add("Net Salary:" + "\t\t" + "R" + netSalary + "\n");
            listbox.Items.Add("--------------------------------------------------------------\n");
            listbox.Items.Add("-------------------Deduction----------------------------------\n");
            listbox.Items.Add("--------------------------------------------------------------\n");
            listbox.Items.Add("Taxation:" + "\t\t\t" + "R" + taxes + "\n");
            listbox.Items.Add("---------------------------------------------------------------");
            
        }


    }
}
