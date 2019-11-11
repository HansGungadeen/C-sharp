using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrgStandardLibraryBLL;

namespace OrganisationWinAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee E = new Employee()
            {
                EmpId = 200,
                Name = "Jack",
                SalaryPerDay = 45.5,
                HRA = 13.7
            };

            double GS = E.GetSalary(4);
            label1.Text = "Salary of " + E.Name + "is" + GS.ToString();
           
        }
    }
}
