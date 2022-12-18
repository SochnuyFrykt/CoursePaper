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

    public partial class Monitoring : Form
    {
        Form formtoopen;
        public Monitoring(Form form)
		{
			InitializeComponent();
			ClassComand.SwitchColorButton(CloseButton);
			ClassComand.SwitchColorButton(CollapsButton);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
			formtoopen = form;
            dataGridView1.Rows.Add("123", "123", "123");
            FileStream fin = new FileStream("D://test.base", FileMode.Append);
            using (StreamWriter streamwriter = new StreamWriter(fin))
            {
                //bool doNotWrite = false;

                //for (int j = 0; j <= dataGridView1.Rows.Count; j++)
                //    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                //        if (dataGridView1.Rows[j].Cells[i].Value == null)
                //            doNotWrite = true;

                //if (!doNotWrite)
                //{
                    for (int j = 0; j <= dataGridView1.Rows.Count-1; j++)
                        for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                            streamwriter.WriteLine(dataGridView1.Rows[j].Cells[i].Value);
                    streamwriter.Write("");
                    streamwriter.Close();
                    MessageBox.Show("Файл успешно сохранен");
                //}
                //else
                //    MessageBox.Show("Не все информация о рейсе введена");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
