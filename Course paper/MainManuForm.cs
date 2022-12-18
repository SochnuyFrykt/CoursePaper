using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_paper
{
	public partial class MainManuForm : Form
	{
        InformationAboutObjects info;
        Monitoring monitoring;
        SalaryCalculation salary;
        Orders orders;
        Docs docs;
        CompletedTasks completedTasks;
        GeneralDocs generalDocs;
        BluePrints blueprints;
        public MainManuForm()
		{
			InitializeComponent();
			ClassComand.SwitchColorButton(CloseButton);
			ClassComand.SwitchColorButton(CollapsButton);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
            info = new InformationAboutObjects(this);
            monitoring = new Monitoring(this);
            salary = new SalaryCalculation(this);
            orders = new Orders(this);
            docs = new Docs(this);
            completedTasks = new CompletedTasks(this);
            generalDocs = new GeneralDocs(this);
            blueprints = new BluePrints(this);
        }
		Point lastPoint;
		private void TopPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Left += e.X - lastPoint.X;
				Top += e.Y - lastPoint.Y;
			}
		}
		private void TopPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void CollapsButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
        private void InfoAboutObjectsButton_Click(object sender, EventArgs e)
        {
            info.Show();
            Hide();
        }

        private void MonitoringButton_Click(object sender, EventArgs e)
        {
            monitoring.Show();
            Hide();
        }

        private void SalaryCalcButton_Click(object sender, EventArgs e)
        {
            salary.Show();
            Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            orders.Show();
            Hide();
        }

        private void DocumentGenerationButton_Click(object sender, EventArgs e)
        {
            docs.Show();
            Hide();
        }
        private void CompletedTasksButton_Click(object sender, EventArgs e)
        {
            completedTasks.Show();
            Hide();
        }
        private void BlueprintsButton_Click(object sender, EventArgs e)
        {
            blueprints.Show();
            Hide();
        }
        private void GeneralDocsButton_Click(object sender, EventArgs e)
        {
            generalDocs.Show();
            Hide();
        }

        private void MainManuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
