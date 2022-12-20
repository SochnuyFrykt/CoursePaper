using StrWriter;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class InformationAboutObjects : Form
    {
        Form formtoopen;
        public InformationAboutObjects(MainManuForm form) // Конструктор только для генерального директора
        {
            InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            formtoopen = form;
            StreamWriter1.Load(dataGridView1, "Tables\\test3.base");
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
            formtoopen.Show();
            Hide();
        }

        private void Send_Click(object sender, EventArgs e) // Сохранение изменений из таблицы в файл
        {
            StreamWriter1.Save(dataGridView1, "Tables\\test3.base");
        }
    }
}
