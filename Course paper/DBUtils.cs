using MySql.Data.MySqlClient;

namespace Course_paper
{
	internal class DBUtils
	{

        //	Инициализирует новый экземпляр класса MySqlConnection содержащий строку подключения.
        MySqlConnection connection = new MySqlConnection(
			"server=localhost;" +
			"port=3306;" +
			"username=root;" +
			"password=root;" +
			"database=coursedb"); 

		//Метод открытия соединения с базой данных
		public void OpenConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
				connection.Open();
		}

        //Метод закрытия соединения с базой данных
        public void CloseConnection()
		{
			if (connection.State == System.Data.ConnectionState.Open)
				connection.Close();
		}

		public MySqlConnection GetConnection() => connection;
	}
}
