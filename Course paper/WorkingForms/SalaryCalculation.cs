using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrWriter;

namespace Course_paper
{
	public partial class SalaryCalculation : Form
	{
		Form formtoopen;

        public SalaryCalculation(MainManuForm form)
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

        private void Send_Click(object sender, EventArgs e)
        {
			StreamWriter1.Save(dataGridView1, "Tables\\test.base");

        }
		public void Itog()
		{
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
					if (LineFull(i, dataGridView1))
					{
						dataGridView1.Rows[i].Cells[4].Value = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
					}
			}
		}
		public static bool LineFull(int i,DataGridView dgv)
		{
			for (int j = 0; j < dgv.ColumnCount-1; j++)
				if (dgv.Rows[i].Cells[j].Value == "" || dgv.Rows[i].Cells[j].Value == null)
					return false;
			return true;
		}

        private void totalButton_Click(object sender, EventArgs e)
        {
            Itog();
        }
    }
}
