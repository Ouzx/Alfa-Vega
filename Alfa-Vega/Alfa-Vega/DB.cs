using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        /// Veri tabanı baplantısını koparır.
        /// </summary>
        public void Disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
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
            row.Clear();
            string cmd = "SELECT * FROM " + _table + " WHERE ID = " + _id.ToString();
            int columns = GetColumnCount(_table);
            Connect();
            using (MySqlDataReader reader = new MySqlCommand(cmd, connection).ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < columns; i++) row.Add(reader.GetString(i));
                }
            }
            Disconnect();
            
            return row;

        }


        /// <summary>
        /// İstenilen tablonun sütun isimlerini verir.
        /// </summary>
        /// <param name="tablename">Tablo ismi</param>
        /// <returns></returns>
        public void Edit(string _tablename, int _id, params object[] _data)
        {
            Connect();
            DataTable schema = null;
            using (var schemaCommand = new MySqlCommand("SELECT * FROM " + _tablename, connection))
            {
                using (var reader = schemaCommand.ExecuteReader(CommandBehavior.SchemaOnly))
                {
                    schema = reader.GetSchemaTable();
                }
            }
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction tr = null;
            cmd.Connection = connection;
            cmd.Transaction = tr;
            StringBuilder s = new StringBuilder();
            s.Append("UPDATE "+ _tablename + " SET ");
            for(int i = 1; i < schema.Rows.Count; i++)
            {
                s.Append(schema.Rows[i]["ColumnName"] + "=" + _data[i-1] + ",");
            }
            s.Remove(s.Length - 1, 1);
            s.Append(" WHERE ID = " + _id);
            cmd.CommandText = s.ToString();
            cmd.ExecuteNonQuery();
            Disconnect();
        }


        /// <summary>
        /// Adı verilen elemanı tablodan siler.
        /// </summary>
        /// <param name="_table"></param>
        /// <param name="_name"></param>
        public void Remove(string _table, int _id)
        {
            Connect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM " + _table + " WHERE ID = " + _id;
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        /// <summary>
        /// İstenilen tablodan ID ve Name'i çeker.
        /// </summary>
        public void GetAll(string _table, Selected.Mode mode)
        {

            string cmd = "SELECT ID, NAME FROM " + _table;
            Connect();
            using (MySqlDataReader reader = new MySqlCommand(cmd, connection).ExecuteReader())
            {
                switch (mode)
                {
                    case Selected.Mode.Name:
                        Selected.NameInt.Clear();
                        Selected.NameName.Clear();
                        while (reader.Read())
                        {
                            Selected.NameInt.Add(reader.GetInt32(0));
                            Selected.NameName.Add(reader.GetString(1));
                        }
                        break;

                    case Selected.Mode.Type:
                        Selected.TypeInt.Clear();
                        Selected.TypeName.Clear();
                        while (reader.Read())
                        {
                            Selected.TypeInt.Add(reader.GetInt32(0));
                            Selected.TypeName.Add(reader.GetString(1));
                        }
                        break;

                    case Selected.Mode.Owner:
                        Selected.OwnerInt.Clear();
                        Selected.OwnerName.Clear();
                        while (reader.Read())
                        {
                            Selected.OwnerInt.Add(reader.GetInt32(0));
                            Selected.OwnerName.Add(reader.GetString(1));
                        }
                        break;
                }
            }
            Disconnect();
        }

        /// <summary>
        /// Vega'ların bağlılık sistemi diğer birimlerden farklı olduğu için;
        /// tüm bağlılıklardan ayrı ayrı ve senksron bir şekilde veri çekmek gerekiyordu.
        /// Metot şu şekilde çalışıyor. 
        /// Her bağlılık biriminin enum karşılığı alınıp(örn: 3 olsun) => Çekilen id'ye eklenir. 30005 gibi.
        /// </summary>
        public void GetVEGA()
        {

            Connect();
            for (int i = 0; i < 6; i++)
            {
                string s = ((Settings.Unit)i).ToString();
                string cmd = "SELECT ID, NAME FROM " + s;
                using (MySqlDataReader reader = new MySqlCommand(cmd, connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //string tempp = reader.GetInt32(0).ToString(i.ToString() + "0000");
                        Selected.OwnerInt.Add(Convert.ToInt32(reader.GetInt32(0).ToString(i.ToString() + "0000")));
                        Selected.OwnerName.Add(reader.GetString(1));
                    }
                }
            }
            
            Disconnect();
        }

        /// <summary>
        /// Menü içeriklerini alır.
        /// </summary>
        public void GetMenus()
        {
            ClearMenus();
            Connect();
            string empty = "";
            for (int i = 0; i < 6; i++)
            {
                switch ((Selected.Units)i)
                {
                    case Selected.Units.FACTORIES:
                        empty = "OWNER_ID";
                        break;
                    case Selected.Units.DEPARTMENTS:
                        empty = "FACTORY_ID";
                        break;
                    case Selected.Units.PLACES:
                        empty = "DEPARTMANT_ID";
                        break;
                    case Selected.Units.MACHINES:
                        empty = "DEPARTMANT_ID";
                        break;
                    case Selected.Units.WORKERS:
                        empty = "DEPARTMANT_ID";
                        break;
                    case Selected.Units.VEGAS:
                        empty = "OWNER_ID";
                        break;
                }

                string cmd = "SELECT ID, NAME, "+empty+" FROM " + ((Selected.Units)i).ToString();
                using (MySqlDataReader reader = new MySqlCommand(cmd, connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> temp = new List<string>();
                        temp.Add(reader.GetString(0)); // ID
                        temp.Add(reader.GetString(1)); // NAME
                        temp.Add(reader.GetString(2)); //OWNER ID
                        Selected.Menu[i].Add(temp);
                    }
                }
            }
            Disconnect();
        }
        /// <summary>
        /// Menü listelerini temizler.
        /// </summary>
        public void ClearMenus()
        {
            for(int i = 0; i < 6; i++)
            {
                Selected.Menu[i].Clear();
            }
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

        public bool CheckUser(string _name, string _password)
        {
            string sql = "SELECT * FROM USERS";
            bool Granted = false;
            Connect();
            using (MySqlDataReader reader = new MySqlCommand(sql, connection).ExecuteReader())
            {
                while(reader.Read())
                {
                    
                    if (_name.ToLower() == reader.GetString(1).ToLower())
                        if (_password == reader.GetString(2))
                            Granted = true;
                            
                   //System.Windows.Forms.MessageBox.Show(reader.GetString(1) + "\n" + reader.GetString(0));
                }
            }
            return Granted;
        }

        public string GetOwnerName(Selected.Units _unit,string _id)
        {
            string _table = "";
            string temp = "";
            switch (_unit)
            {
                case Selected.Units.FACTORIES:
                    _table = "USERS";
                    break;
                case Selected.Units.DEPARTMENTS:
                    _table = "FACTORIES";
                    break;
                case Selected.Units.PLACES:
                    _table = "DEPARTMENTS";
                    break;
                case Selected.Units.MACHINES:
                    _table = "DEPARTMENTS";
                    break;
                case Selected.Units.WORKERS:
                    _table = "DEPARTMENTS";
                    break;
                case Selected.Units.VEGAS:
                    _table = "DEPARTMENTS";
                    break;
                default: break;
            }
            string s = "";
            if (_unit != Selected.Units.FACTORIES)
            {
                s = "SELECT NAME FROM " + _table + " WHERE ID=" + _id;
                Connect();
                using (MySqlDataReader reader = new MySqlCommand(s, connection).ExecuteReader())
                {
                    if (reader.Read()) if (!reader.IsDBNull(0)) temp = reader.GetString(0);
                }
                Disconnect();
            }
            return temp;
        }
        
    }
}
