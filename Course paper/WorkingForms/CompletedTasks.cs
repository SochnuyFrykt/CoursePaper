using StrWriter;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class CompletedTasks : Form
    {
        Form formtoopen;
        public CompletedTasks() // Конструктор для всех должностей кроме генерального директора
        {
            InitializeComponent();
            ClassComand.SwitchColorButton(CloseButton);
            ClassComand.SwitchColorButton(CollapsButton);
            ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            StreamWriter1.Load(dataGridView2, "Tables\\test2.base");
        }
        public CompletedTasks(MainManuForm form) // Конструктор только для генерального директора
        {
            InitializeComponent();
            ClassComand.SwitchColorButton(CloseButton);
            ClassComand.SwitchColorButton(CollapsButton);
            ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            formtoopen = form;
            StreamWriter1.Load(dataGridView2, "Tables\\test2.base");
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
            StreamWriter1.Save(dataGridView2, "Tables\\test2.base");
        }
    }
}
