using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ebury_client
{
    class User{

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PASSWORD = Properties.Settings.Default.BD_PASSWORD;


        private string username;
        private string password;

        public User(string n, string p)
        {

            string datos_conexion = @"server=eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com;userid=grupo03;password=2zzd92Xe7sr4BRxW;database=grupo03DB";

            MySqlConnection conexion = null;

            try
            {
                conexion = new MySqlConnection(datos_conexion);
                conexion.Open();

                string query = "SELECT * FROM user;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds, "user");
                DataTable dt = ds.Tables["user"];
                bool found = false;

                //debug
                Console.Write("da: " + da + "\n");
                Console.Write("ds: " + ds + "\n");
                Console.Write("dt: " + dt + "\n");

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        if(col.ToString() == "username" && row[col].ToString() == n)
                        {
                            if(row["password"].ToString() == p)
                            {
                                username = row[col].ToString();
                                password = row["password"].ToString();
                                found = true;
                            }
                        }
                    }
                }
                if(!found)
                {
                    throw new Error("Incorrect Username or Password");
                }
            }
            catch (Exception e)
            {
                throw new Error("Incorrect Username or Password: " + e);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
                
        }
    }
}
