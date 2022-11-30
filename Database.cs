using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;

namespace TabazatGUIAdata
{

    internal class Database
    {
        private MySqlConnection sqlconnection;
        private MySqlCommand sqlcommand;
        private string errorMessage = null;
        public Database(string host, string user, string password, string database) { 
        
            MySqlConnectionStringBuilder stringbuilder = new MySqlConnectionStringBuilder();
            stringbuilder.Server = host;
            stringbuilder.UserID = user;
            stringbuilder.Password = password;
            stringbuilder.Database = database;
            sqlconnection = new MySqlConnection(stringbuilder.ConnectionString);
            sqlcommand = sqlconnection.CreateCommand();

        }
        private bool databaseOpen()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Open)
                {

                    sqlconnection.Open();

                }

            }
            catch (MySqlException ex)
            {

                errorMessage = ex.Message;
                return false;

            }

            return true;
        }
        private bool databaseClose()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Closed)
                {

                    sqlconnection.Close();

                }

            }
            catch (MySqlException ex)
            {

                errorMessage = ex.Message;
                return false;

            }

            return true;
        }

        public List<GyumolcsAdat> getAllGyumolcs()
        {

            List<GyumolcsAdat> gyumolcsAdats = new List<GyumolcsAdat>();
            sqlcommand.CommandText = "SELECT `id`, `nev`, `egysegar`, `mennyiseg` FROM `gyumolcs` WHERE 1";
            if (databaseOpen())
            {

                using (MySqlDataReader dr = sqlcommand.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        GyumolcsAdat uj = new GyumolcsAdat(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                        gyumolcsAdats.Add(uj);

                    }

                }

            }
            else
            {

                MessageBox.Show(errorMessage);

            }
            databaseClose();

            return gyumolcsAdats;

        }

    }
}
