using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using WorkToDB.Forms;

namespace WorkToDB
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {   
            EmployeeForm = new EmployeeForm();
            EmployeeForm.Show();
        }

        private void BuyerButton_Click(object sender, EventArgs e)
        {
            BuyerForm = new BuyerForm();
            BuyerForm.Show();
        }

        private void ExecuteWorkButton_Click(object sender, EventArgs e)
        {
            ExecutionWorkForm = new ExecutionWorkForm();
            ExecutionWorkForm.Show();
        }

        private void DeveleryButton_Click(object sender, EventArgs e)
        {
            DeveleryForm = new DeveleryForm();
            DeveleryForm.Show();
        }

        private void ContractButton_Click(object sender, EventArgs e)
        {
            ContractForm = new ContractForm();
            ContractForm.Show();
        }

        private void EstimateButton_Click(object sender, EventArgs e)
        {
            EstimateForm = new EstimateForm();
            EstimateForm.Show();      
        }

        private void MaterialButton_Click(object sender, EventArgs e)
        {
            MaterialForm = new MaterialForm();
            MaterialForm.Show();
        }
    }
}
