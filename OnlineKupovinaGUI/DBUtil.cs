using MySql.Data.MySqlClient;
namespace OnlineKupovinaGUI
{
    public class DBUtil
    {
        // TO DO 
        // napravi config fajl i iz njega citaj podatke

        private static string ConnectioString = "Server=; Port=; Database=; User Id=;Password=";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectioString);
        }
    }
}
