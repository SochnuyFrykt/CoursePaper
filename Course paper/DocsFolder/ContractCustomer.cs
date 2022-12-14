using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper.DocsFolder
{
	public partial class ContractCustomer : Form
	{
		Form formToOpen;
		public ContractCustomer()
		{
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, ButtonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.ShowHelp(helpButton);
			ClassComand.Close(CloseButton);
			string path = @"C:\Users\sereb\OneDrive\Рабочий стол\Курсовая работа по ПИ\CoursePaper\Course paper\DocsFolder\DocsTemplate\Договор об оказании услуг.docx";
			var items = new Dictionary<string, string> //Атрибуты для замены
			{
				{ "<SNM>", SNM.Text },
				{ "<CO>", CustomerOrganization.Text },
				{ "<dd>", DateTime.Now.ToString("dd") },
				{ "<MM>", DateTime.Now.ToString("MM") },
				{ "<yy>", DateTime.Now.ToString("yy") },
				{ "<SD>", StartDate.Value.ToString("dd MM yyyy") },
				{ "<ED>", EndDate.Value.ToString("dd MM yyyy") },
				{ "<B>", Budget.Text },
				{ "<TB>", TypeBuilding.Text },
			};
			GenerateFile.Generate(generateButton, path, items);
			formToOpen = new Docs(new MainManuForm());
		}

		Point lastPoint;
		private void TopPanel_MouseMove(object sender, MouseEventArgs e) // Метод для перемещения окон
		{
			if (e.Button == MouseButtons.Left)
			{
				Left += e.X - lastPoint.X;
				Top += e.Y - lastPoint.Y;
			}
		}

		private void TopPanel_MouseDown(object sender, MouseEventArgs e) // Метод для сохранения точки
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void ButtonBack_Click(object sender, EventArgs e) // Показ предыдущего окна при нажатии на кнопку
		{
			formToOpen.Show();
			Hide();
		}
	}
}
