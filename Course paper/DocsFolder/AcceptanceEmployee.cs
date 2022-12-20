using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_paper.DocsFolder
{
	public partial class AcceptanceEmployee : Form
	{
		Form formToOpen;
		public AcceptanceEmployee()
		{
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, ButtonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.ShowHelp(helpButton);
			ClassComand.Close(CloseButton);
			formToOpen = new Docs(new MainManuForm());
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

		private void ButtonBack_Click(object sender, EventArgs e)
		{
			formToOpen.Show();
			Hide();
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			var generate = new GenerateFileAcceptanceEmployee(@"C:\Users\sereb\OneDrive\Рабочий стол\Курсовая работа по ПИ\CoursePaper\Course paper\DocsFolder\prikaz-o-prieme-na-rabotu-blank-t1.doc");

			var items = new Dictionary<string, string>
			{
				{ "<SNM>", SNM.Text },
				{ "<Post>", Post.Text },
				{ "<AD>", acceptanceDate.Value.ToString("dd.MM.yyyy") },
				{ "<Salary>", Salary.Text },
				{ "<TP>", TrialPeriod.Text },
			};

			generate.Process(items);
		}
	}
}
