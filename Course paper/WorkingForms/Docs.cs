﻿using Course_paper.DocsFolder;
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
    public partial class Docs : Form
    {
        Form formToOpen;
        public Docs(MainManuForm form)
        {
            InitializeComponent();
            ClassComand.SwitchColorButton(CloseButton);
            ClassComand.SwitchColorButton(CollapsButton);
            ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
            formToOpen = form;
        }

        public Docs()
        {
            InitializeComponent();
            ClassComand.SwitchColorButton(CloseButton);
            ClassComand.SwitchColorButton(CollapsButton);
            ClassComand.Close(CloseButton);
            ClassComand.ShowHelp(helpButton);
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            formToOpen.Show();
            Hide();
        }

    private void DismissalEmployee_Click(object sender, EventArgs e)
    {
      var dismissalForm = new DismissalEmployee();
      dismissalForm.Show();
      Hide();
    }
  }
}