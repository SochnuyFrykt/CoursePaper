using Course_paper.DocsFolder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
	public partial class Docs : Form
	{
		Form formToOpen;
		public Docs(MainManuForm form) // Конструктор только для генерального директора
        {
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, ButtonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
			formToOpen = form;
		}

		public Docs() // Конструктор для всех должностей кроме генерального директора
        {
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, ButtonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
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

		private void CollapsButton_Click(object sender, EventArgs e) // Скрытие окна
        {
			WindowState = FormWindowState.Minimized;
		}

		private void ButtonBack_Click(object sender, EventArgs e) // Возврат окна
        {
			formToOpen.Show();
			Hide();
		}

		private void DismissalEmployee_Click(object sender, EventArgs e) // Метод для перехода в окно "Увольнение работника"
		{
			var dismissalForm = new DismissalEmployee();
			dismissalForm.Show();
			Hide();
		}

		private void AcceptanceEmployee_Click(object sender, EventArgs e) // Метод для перехода в окно "Принятие работника"
        {
			var acceptanceEmplaoyee = new AcceptanceEmployee();
			acceptanceEmplaoyee.Show();
			Hide();
		}

		private void ContractCustomer_Click(object sender, EventArgs e) // Метод для перехода в окно "Оформление контракта с заказчиком"
        {
			var contractCustomer = new ContractCustomer();
			contractCustomer.Show();
			Hide();
		}
	}
}
