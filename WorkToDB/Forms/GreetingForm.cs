using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkToDB.Forms
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void toStartForm_Click(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            startForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutPlasticWindows();
            aboutForm.Show();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var buyerForm = new BuyerForm();
            buyerForm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var executionWorkForm = new ExecutionWorkForm();
            executionWorkForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var develeryForm = new DeveleryForm();
            develeryForm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var contractForm = new ContractForm();
            contractForm.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            var estimateForm = new EstimateForm();
            estimateForm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            var materialForm = new MaterialForm();
            materialForm.Show();
        }

        private void AdminStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminForm = new AutorizationForm();
            adminForm.Show();
        }

        private void querySelectStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryForm = new QueryForm();
            queryForm.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            var queryWriteForm = new QueryWriteForm();
            queryWriteForm.Show();
        }

        private void requestDateStripMenuItem_Click(object sender, EventArgs e)
        {
            var requestForm = new RequestForm();
            requestForm.Show();
        }

        private void reportToolStripMenu_Click(object sender, EventArgs e)
        {

        }

    }
}
