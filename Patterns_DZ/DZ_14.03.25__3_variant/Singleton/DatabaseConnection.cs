namespace Patterns_DZ.DZ_14._03._25__3_variant.Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection dbConnection;

        private DatabaseConnection()
        {

        }

        public static DatabaseConnection GetInstance()
        {
            if (dbConnection == null)
            {
                dbConnection = new DatabaseConnection();
            }

            return dbConnection;
        }

        //Соединение с базой данных
        public void Connection()
        {
            Console.WriteLine("Соединение с базой данных установлено.");
        }

        //обработка запроса
        public void RequestProcessing(string query)
        {
            Console.WriteLine("Выполняется запрос: " + query);
        }

        //разъединение с базой данных
        public void Disconnection()
        {
            Console.WriteLine("Соединение с базой данных разорвано.");
        }
    }
}