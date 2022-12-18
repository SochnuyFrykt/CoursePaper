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
	public partial class DismissalEmployee : Form
	{
        Form formToOpen;
        public DismissalEmployee(Docs form)
		{
			InitializeComponent();
			var buttons = new Label[4] {CloseButton, CollapsButton, ButtonBack, helpButton};
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
            formToOpen = form;
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
    }
}
