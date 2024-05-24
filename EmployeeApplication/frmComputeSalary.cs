using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary: Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName, lastName, depart, job;

            firstName = textBox1.Text;
            lastName = textBox2.Text;
            depart = textBox3.Text;
            job = textBox4.Text;
            double ratePerHour = Convert.ToDouble(textBox5.Text); 
            int basicsalary = Convert.ToInt32(textBox6.Text);
            PartTimeEmployee PartTimeEmp = new PartTimeEmployee(firstName, lastName, depart, job);
            PartTimeEmp.ComputeSalary(basicsalary,ratePerHour);
            label10.Text = PartTimeEmp.FirstName;
            label11.Text = PartTimeEmp.LastName;   
            label12.Text = Convert.ToDouble(PartTimeEmp.BasicSalary).ToString();

        }

    }
}
