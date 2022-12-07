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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(149, 149, 149);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HideButton_MouseEnter(object sender, EventArgs e)
        {
            HideButton.ForeColor = Color.FromArgb(149, 149, 149);
        }

        private void HideButton_MouseLeave(object sender, EventArgs e)
        {
            HideButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            //Help help = new Help();
            //help.Show();
        }

        public virtual void ButtonBack_Click(object sender, EventArgs e)
        {
            //var form1 = new SignInForm();
            //form1.Show();
            //Hide();
        }
    }
}
