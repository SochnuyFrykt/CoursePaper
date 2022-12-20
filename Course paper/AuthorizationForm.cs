using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Course_paper
{

	public partial class AuthorizationForm : Form
	{

        Point lastPoint;
        public AuthorizationForm()
		{
			InitializeComponent();
			var buttons = new Label[3] { CloseButton, CollapsButton, helpButton };
			foreach (var button in buttons)
				ClassComand.SwitchColorButton(button);
			ClassComand.Close(CloseButton);
			ClassComand.ShowHelp(helpButton);
		}


		//Два метода снизу позволяют двигать окно программы
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

		//Позволяет скрыть окно программы
		private void CollapsButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		//Действие при нажатии кнопки авторизации
		private void LoginButton_Click(object sender, EventArgs e) //Подключается к базе данных, проверяет правильность пароля и логина
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
				var temp = Login.Text;
                UserRole(temp);
			}
			else MessageBox.Show("Логин или пароль введены неверно!!!");
			databaseUtils.CloseConnection();
		}

		//Подключается к базе данных и смотрит роль пользователя
		public void UserRole(string temp) 
		{
			string UserName = temp;
			string connStr = "server=localhost; port=3306; username=root; password= root; database=coursedb;";
			string sql = "SELECT Post FROM coursedb.users WHERE `login` = @un";
			MySqlConnection conn = new MySqlConnection(connStr);
			conn.Open();
			MySqlParameter nameParam = new MySqlParameter("@un", UserName);
			MySqlCommand command = new MySqlCommand(sql, conn);
			command.Parameters.Add(nameParam);
			string Form_Role = command.ExecuteScalar().ToString();
			switch (Form_Role)
			{
				case "Генеральный директор":
					var mainManu = new MainManuForm();
					mainManu.Show(); Hide();
					break;
				case "Инженер":
					var generalDocs = new GeneralDocs();
					generalDocs.Show(); Hide();
					break;
				case "Производитель работ":
					var orders = new Orders();
					orders.Show(); Hide();
					break;
				case "Конструктор":
					var blueprints = new BluePrints();
					blueprints.Show(); Hide();
					break;
				case "Архитектор":
					var docs = new GeneralDocs();
					docs.Show(); Hide();
					break;
				case "Финансовый менеджер":
					var completedTasks = new CompletedTasks();
					completedTasks.Show(); Hide();
					break;
			}
			conn.Close();

		}
    }
}
