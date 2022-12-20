using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace Course_paper
{
	public partial class Orders : Form
	{
		Form formtoopen;
		public Orders(MainManuForm form)
		{
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
			formtoopen = form;
		}
		public Orders()
		{
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
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

		private void label2_Click(object sender, EventArgs e)
		{
			formtoopen.Show();
			Hide();
		}

		private void SendButton_Click(object sender, EventArgs e)
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
