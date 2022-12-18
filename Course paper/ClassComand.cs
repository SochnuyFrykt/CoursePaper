using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_paper
{
	internal class ClassComand
	{
		public static void SwitchColorButton(Label button)
		{
			button.MouseEnter += (s, n) =>
				button.ForeColor = Color.FromArgb(149, 149, 149);
			button.MouseLeave += (s, n) =>
				button.ForeColor = Color.White;
		}

		public static void Close(Label button)
		{
			button.MouseClick += (s, n) =>
				Application.Exit();
		}

		public static void Hide(Label button)
		{
			button.MouseClick += (s, n) =>
			{
				var help = new Help();
				help.Hide();
			};
		}

		public static void ShowHelp(Label button)
		{
			button.MouseClick += (s, n) =>
			{
				var help = new Help();
				help.Show();
			};
		}
	}
}
