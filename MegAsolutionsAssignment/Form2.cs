using System;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
namespace MegAsolutionsAssignment
{
    // Ensure your project references System.Windows.Forms.dll and targets .NET Framework.
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnPrintslip_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            double salary = Convert.ToDouble(txtSalary.Text);
            int hours = Convert.ToInt16(txtHours.Text);
            double grossPay;
            double taxes;
            double netSalary;

            if (hours <= 12)
            {
                grossPay = salary * hours;
                taxes = grossPay * 0.2;
                netSalary = grossPay - taxes;
            }
            else
            {
                int overtime = hours - 12;
                grossPay = (salary * hours) + overtime;
                taxes = grossPay * 0.2;
                netSalary = grossPay - taxes;
            }

            if (listbox != null)
            {
                string paymentDate = DateTime.Now.ToString("yyyy-MM-dd");

                listbox.Items.Clear();

                _ = listbox.Items.Add("-------------------------- PAYSLIP --------------------------\n");
                _ = listbox.Items.Add("-------------------- MEGA SOLUTIONS COMPANY -------------------\n");
                _ = listbox.Items.Add("--------------------------------------------------------------\n");
                _ = listbox.Items.Add("Employee Name:" + "\t\t" + name + "\n");
                _ = listbox.Items.Add("Payment Date:" + "\t\t" + paymentDate + "\n");
                _ = listbox.Items.Add("--------------------------------------------------------------\n");
                _ = listbox.Items.Add("Standard Hours:" + "\t\t" + "12h\n");
                _ = listbox.Items.Add("Hours Worked:" + "\t\t" + hours.ToString() + "\n");
                _ = listbox.Items.Add("Hourly Rate:" + "\t\t" + "R" + salary.ToString("F2") + "\n");
                _ = listbox.Items.Add("Gross Pay:" + "\t\t" + "R" + grossPay.ToString("F2") + "\n");
                _ = listbox.Items.Add("Net Pay:" + "\t\t" + "R" + netSalary.ToString("F2") + "\n");
                _ = listbox.Items.Add("--------------------------------------------------------------\n");
                _ = listbox.Items.Add("------------------------ DEDUCTIONS --------------------------\n");
                _ = listbox.Items.Add("--------------------------------------------------------------\n");
                _ = listbox.Items.Add("Tax Withheld:" + "\t" + "R" + taxes.ToString("F2") + "\n");
                _ = listbox.Items.Add("--------------------------------------------------------------");
            }
        }


    }
}
