using System;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
	public partial class Orders : Form
	{
		Form formToOpen;
		public Orders(MainManuForm form) // Конструктор только для генерального директора
		{
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
			formToOpen = form;
		}
		public Orders()// Конструктор для всех должностей кроме генерального директора
		{
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
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

		private void buttonBack_Click(object sender, EventArgs e) // Возврат окна
		{
			formToOpen.Show();
			Hide();
		}

		private void SendButton_Click(object sender, EventArgs e) //Метод отправки сообщений с заказом товара
		{
			if (richTextBox1.Text != "")
			{
				MailAddress fromAddress = new MailAddress("limon12345ivanoff@ya.ru", "Данил");
				MailAddress toAdress = new MailAddress("kuzkokuzkovi4@gmail.com");
				MailMessage mailMessage = new MailMessage(fromAddress, toAdress);

				mailMessage.Subject = "Заказ товара";
				mailMessage.Body = richTextBox1.Text;

				SmtpClient smtpClient = new SmtpClient();
				smtpClient.Host = "smtp.gmail.com";
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtpClient.UseDefaultCredentials = false;
				smtpClient.Credentials = new NetworkCredential(fromAddress.Address, "Ss2-n9h-eii-3VS");

				smtpClient.Send(mailMessage);
			}
			else
				throw new ArgumentException("Вы пытаетесь отправить пустое письмо. Так делать плохо!");
		}
	}
}
