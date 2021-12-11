using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BDLibrary;

namespace ebury_client
{
    class HFroms
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PASSWORD = Properties.Settings.Default.BD_PASSWORD;

        private string connection_data = @"server=" + BD_SERVER + ";userid=" + BD_USER
                + ";password=" + BD_PASSWORD + ";database=" + BD_NAME;

        private User mainUser;

        public HFroms(User u)
        {
            this.mainUser = u;

        }

        public void clientInform()
        {

        }

        public void accountForm()
        {


        }

        public void csvFileCreator(string inputText)
        {


        }
        public String fileName()
        {

            return "";
        }
    }
}
