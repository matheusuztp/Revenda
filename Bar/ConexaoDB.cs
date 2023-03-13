using MySql.Data.MySqlClient;
using System.Configuration;

namespace Barzinho
{
    public class ConexaoDB
    {
        private static readonly ConexaoDB instanciaMySQL = new ConexaoDB();

        private ConexaoDB() { }

        public static ConexaoDB getInstancia()
        {
            return instanciaMySQL;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["BancoDados"].ToString();
            return new MySqlConnection(conn);
        }
    }

}
