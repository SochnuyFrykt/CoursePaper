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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
				UserRole();
			}
			else MessageBox.Show("Логин или пароль введены неверно!!!");
			databaseUtils.CloseConnection();
		}

		public void UserRole()
		{
            string UserName = Login.Text; ;

            string connStr = "server=localhost; port=3306; username=root; password= root; database=coursedb;";
            string sql = "SELECT Post FROM coursedb.users WHERE `login` = @un";

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlParameter nameParam = new MySqlParameter("@un", UserName);

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add(nameParam);

            string Form_Role = command.ExecuteScalar().ToString();

			//         Switch(Form_Role)
			//{
			//	case "Администратор": Form.ActiveForm.Close(); Form1 f1 = new Form1(); f1.Show(); break;
			//             default:  Form.ActiveForm.Close(); Form2 f2 = new Form2(); f2.Show();
			//         }
			switch (Form_Role)
			{
				case "Генеральный директор":
					var mainManu = new MainManuForm();
					mainManu.Show();
					Hide();
					break;
			}
            conn.Close();
        }
	}
}
