using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class GeneralDocs : Form
    {
        Form formToOpen;
        public GeneralDocs() // Конструктор для всех должностей кроме генерального директора
        {
            InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            webBrowser1.Url = new Uri(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "GeneralDocs"));
            buttonBack.Visible = false;
        }
        public GeneralDocs(MainManuForm form) // Конструктор только для генерального директора
        {
            InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            webBrowser1.Url = new Uri(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "GeneralDocs"));
            formToOpen = form;
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
    }
}
