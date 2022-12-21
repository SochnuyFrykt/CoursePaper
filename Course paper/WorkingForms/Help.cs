using System;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
	public partial class Help : Form
	{
		public Help() // Конструктор для всех должностей
		{
			InitializeComponent();
			var buttons = new Label[2] { CloseButton, CollapsButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Hide(CloseButton);
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

		private void CloseButton_Click(object sender, EventArgs e) // Закрытие окна
		{
			Close();
		}
	}
}
