using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            try
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, BD_USER, BD_PASSWORD);
                object[] tupla = miBD.Select("SELECT * FROM user WHERE userName ='" + n + "';")[0];
                username = (string)tupla[0];
                password = (string)tupla[1];
                this.password = (string)tupla[1];
                this.username = (string)tupla[0];
            }
            catch (Exception ex)
            {
                throw new Error("Usuario o Contraseña Incorrecta: " + ex.Message);
            }
                
        }
    }
}
