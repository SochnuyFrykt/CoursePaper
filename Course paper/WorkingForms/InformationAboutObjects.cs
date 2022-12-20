using StrWriter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class InformationAboutObjects : Form
    {
        Form formtoopen;
        public InformationAboutObjects(MainManuForm form)
        {
            InitializeComponent();
			var buttons = new Label[4] { CloseButton, CollapsButton, buttonBack, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            formtoopen = form;
            //StreamWriter1.Load(dataGridView1, "Tables\\test3.base");
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
            StreamWriter1.Save(dataGridView1, "Tables\\test3.base");
        }
    }
}
