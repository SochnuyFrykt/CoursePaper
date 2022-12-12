using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Course_paper
{
	public partial class AuthorizationForm : Form
	{
		public AuthorizationForm()
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

		private void LoginButton_Click(object sender, EventArgs e)
		{
			string loginUser = Login.Text;
			string passwordUser = Password.Text;

			DBUtils databaseUtils = new DBUtils();
			DataTable dataTable = new DataTable();
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

			MySqlCommand mySqlCommand = new MySqlCommand(
				"SELECT * FROM coursedb.users WHERE login = @uL AND pass = @uP",
				databaseUtils.GetConnection());
			mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
			mySqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

			mySqlDataAdapter.SelectCommand = mySqlCommand;
			mySqlDataAdapter.Fill(dataTable);

			if (dataTable.Rows.Count > 0)
			{
				var mainManu = new MainManuForm();
				mainManu.Show();
				Hide();
			}
			else MessageBox.Show("Логин или пароль введены неверно!!!");
			databaseUtils.CloseConnection();
		}
	}
}
