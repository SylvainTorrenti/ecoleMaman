using Dapper;
using ecoleMaman.Properties;
using MySql.Data.MySqlClient;

namespace ecoleMaman
{
    internal class Db
    {
        private readonly MySqlConnection _dbConnection;
        public Db()
        {
            _dbConnection = new(Settings.Default.dbConnect);
        }

        public IEnumerable<Word> GetWords()
        {
            try
            {
                _dbConnection.Open();
                var q = "SELECT * from mots";
                return _dbConnection.Query<Word>(q);
            }
            finally 
            { 
                _dbConnection.Close(); 
            }

        }
    }
}
