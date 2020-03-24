using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Alfa_Vega
{
    /// <summary>
    /// Veri tabanı ile ilgili tüm işlemleri buradan gerçekleştirir.
    /// </summary>
    class DB
    {
        /// <summary>
        /// Global connection var.
        /// </summary>
        public MySqlConnection connection;

        /// <summary>
        /// Verilen bilgilerle veritabanına bağlanır.
        /// </summary>
        public bool Connect()
        {
            string conn;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "endustri4_db";
            build.Password = "proveg@4553";
            build.Database = "endustri4_db";
            build.Server = "endustri4.provega.com.tr";
            conn = build.ToString();
            connection = new MySqlConnection(conn);
            connection.Open();

            if (connection.State == System.Data.ConnectionState.Open) return true;
            else return false;
        }

        /// <summary>
        /// Veri tabanına veri ekler.
        /// </summary>
        /// <param name="_cmd">SQL Komutu</param>
        public void Write(string _cmd)
        {
            Connect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = _cmd;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        /// <summary>
        /// Veri tabanından id'si verilen bir satırı okur.
        /// </summary>
        /// <param name="_table">Tablo</param>
        /// <param name="_id">ID</param>
        /// <returns>Satır</returns>
        public List<string> Read(string _table, int _id)
        {
            List<string> row = new List<string>();
            string cmd = "SELECT * FROM " + _table + " WHERE ID = " + _id.ToString();
            int columns = GetColumnCount(_table);
            Connect();
            using (MySqlDataReader reader = new MySqlCommand(cmd, connection).ExecuteReader())
            {
                if (reader.Read())
                {
                    for (int i = 0; i < columns; i++) row.Add(reader.GetString(i));
                }
            }
            Disconnect();
            return row;

        }

        /// <summary>
        /// Veri tabanı baplantısını koparır.
        /// </summary>
        public void Disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        /// <summary>
        /// En son satırdaki id'yi döndürür.
        /// </summary>
        /// <param name="_table">İlgili tablo</param>
        /// <returns></returns>
        public int GetLastID(string _table)
        {
            int i = -1;
            string s = "SELECT MAX(ID) FROM " + _table;
            Connect();
            using (MySqlDataReader reader = new MySqlCommand(s, connection).ExecuteReader())
            {
                if (reader.Read()) if (!reader.IsDBNull(0)) i = reader.GetInt32(0);
            }
            Disconnect();
            return i;
        }
        /// <summary>
        /// İstenilen tablonun toplam sütun sayısını döndürür.
        /// </summary>
        /// <param name="_table">tablo</param>
        /// <returns></returns>
        public int GetColumnCount(string _table)
        {
            int i = 0;
            string s = "SELECT count(*) FROM information_schema.columns WHERE table_name = '" + _table + "'";
            Connect();
            using (MySqlDataReader reader = new MySqlCommand(s, connection).ExecuteReader())
            {
                if (reader.Read()) i = reader.GetInt32(0);
            }
            Disconnect();
            return i;
        }
        

        public void GetClock()
        {

        }
        
    }
}
