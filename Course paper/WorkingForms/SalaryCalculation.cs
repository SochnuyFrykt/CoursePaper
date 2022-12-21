using System;
using System.Drawing;
using System.Windows.Forms;
using StrWriter;

namespace Course_paper
{
	public partial class SalaryCalculation : Form
	{
		Form formtoopen;

        public SalaryCalculation(MainManuForm form) // Конструктор только для генерального директора
        {
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
			formtoopen = form;
			StreamWriter1.Load(dataGridView1, "Tables\\test.base");
        }
        public SalaryCalculation()// Конструктор для всех должностей кроме генерального директора
        {
            InitializeComponent();
            var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
            foreach (var button in buttons)
                ClassComand.SwitchColorButton(button);
            ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            StreamWriter1.Load(dataGridView1, "Tables\\test.base");
            buttonBack.Visible = false;
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
			StreamWriter1.Save(dataGridView1, "Tables\\test.base");

        }
		public static void Itog(DataGridView dataGridView1) // Вычисляет заработную плату сотрудника
		{
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
					if (LineFull(i, dataGridView1))
					{
						dataGridView1.Rows[i].Cells[4].Value = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
					}
			}
		}
		public static bool LineFull(int i,DataGridView dgv) // Проверяет заполненность строки таблицы (используется в методе Itog)
		{
			for (int j = 0; j < dgv.ColumnCount-1; j++)
				if (dgv.Rows[i].Cells[j].Value == "" || dgv.Rows[i].Cells[j].Value == null)
					return false;
			return true;
		}

        private void totalButton_Click(object sender, EventArgs e) // Кнопка для рассчета заработной платы
        {
            Itog(dataGridView1);
        }
    }
}
