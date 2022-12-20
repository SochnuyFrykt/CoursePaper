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

namespace Course_paper
{
	public partial class SalaryCalculation : Form
	{
		Form formtoopen;
		double length = 0;

        public SalaryCalculation(MainManuForm form)
		{
			InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
			formtoopen = form;
            string[] dataString = File.ReadAllLines(@"D:\test.base");
			for (int i = 0; i < dataString.Length;)
                for (int k = 0; k < dataString.Length / 5; k++)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridView1.Rows[k].Cells[j].Value = dataString[i];
                        i++;
                    }
                }
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

        private void MonitoringButton_Click(object sender, EventArgs e)
        {
            StreamWriter streamwriter = new StreamWriter("D://test.base", false);
            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                {
                    streamwriter.WriteLine(dataGridView1.Rows[j].Cells[i].Value);
                }
            }
            streamwriter.Close();
            MessageBox.Show("Файл успешно сохранен");
        }
    }
}
