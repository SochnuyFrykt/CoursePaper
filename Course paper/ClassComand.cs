﻿using System;
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
		//Позволяем менять цвет кнопок при наведении
		public static void SwitchColorButton(Label button)
		{
			button.MouseEnter += (s, n) =>
				button.ForeColor = Color.FromArgb(149, 149, 149);
			button.MouseLeave += (s, n) =>
				button.ForeColor = Color.White;
		}
		//Действие при нажатии кнопки закрыть в приложении
		public static void Close(Label button)
		{
			button.MouseClick += (s, n) =>
				Application.Exit();
		}
        //Действие при нажатии кнопки скрыть в приложении
        public static void Hide(Label button)
		{
			button.MouseClick += (s, n) =>
			{
				var help = new Help();
				help.Hide();
			};
		}
        //Действие при нажатии кнопки помощь в приложении (Открывает помощь)
        public static void ShowHelp(Label button)
		{
			button.MouseClick += (s, n) =>
			{
				var help = new Help();
				help.Show();
			};
		}

		public static void ReturnWindow(Label buttonBack, Form hideForm, Form showForm)
		{
			buttonBack.MouseClick += (s, n) =>
			{
				hideForm.Hide();
				showForm.Show();
			};
		}

		public static void HideShowWindow(Button buttonBack, Form hideForm, Form showForm)
		{
			buttonBack.MouseClick += (s, n) =>
			{
				showForm.Show();
				hideForm.Hide();
			};
		}

	}
}
