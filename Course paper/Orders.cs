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
    public partial class Orders : Template
    {
        Form formtoopen;
        public Orders(MainMenu form)
        {
            InitializeComponent();
            formtoopen = form;
        }
        //public Orders(MainMenuWorker form)
        //{
        //    InitializeComponent();
        //    formtoopen = form;
        //}
        public override void ButtonBack_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }
    }
}
