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
		public MainManuForm()
		{
			InitializeComponent();
			var buttons = new Label[3] { CloseButton, CollapsButton, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
			var info = new InformationAboutObjects(this);
			var monitoring = new Monitoring(this);
			var salary = new SalaryCalculation(this);
			var orders = new Orders(this);
			var docs = new Docs(this);
			var completedTasks = new CompletedTasks(this);
			var generalDocs = new GeneralDocs(this);
			var blueprints = new BluePrints(this);
			ClassComand.HideShowWindow(InfoAboutObjectsButton, this, info);
			ClassComand.HideShowWindow(MonitoringButton, this, monitoring);
			ClassComand.HideShowWindow(SalaryCalcButton, this, salary);
			ClassComand.HideShowWindow(OrdersButton, this, orders);
			ClassComand.HideShowWindow(DocumentGenerationButton, this, docs);
			ClassComand.HideShowWindow(CompletedTasksButton, this, completedTasks);
			ClassComand.HideShowWindow(GeneralDocsButton, this, generalDocs);
			ClassComand.HideShowWindow(BlueprintsButton, this, blueprints);
		}

		Point lastPoint;
		//Два следующих метода позволяют двигать окно
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

		//Скрывает окно при нажатии кнопки (В панель задач)
		private void CollapsButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
	}
}
