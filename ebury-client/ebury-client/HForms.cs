using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BDLibrary;
using Newtonsoft.Json;

namespace ebury_client
{
    class HForms
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PASSWORD = Properties.Settings.Default.BD_PASSWORD;

        private string connection_data = "server=" + BD_SERVER + ";user=" + BD_USER
                + ";database=" + BD_NAME + ";port=3306" + ";password=" + BD_PASSWORD;


        private User mainUser;

        public HForms(User u)
        {
            this.mainUser = u;
        }

        public void clientInform(string primerNombre, string segundoNombre, string ciudad, string calle, string numero, string codigoPostal)
        {
            List<Individual> list = new List<Individual>();
            List<String> nifs = new List<String>();

            try
            {
                MySqlConnection conn = new MySqlConnection(connection_data);
                conn.Open();

                string sql = "SELECT firstName,lastName,birthDate,accountState,country, nif " +
                "FROM customer JOIN particular  USING (nif) JOIN  customerXAccount USING(nif)" 
                + "JOIN eburyAccount USING(accountNumber)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Individual individual = new Individual(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
                    list.Add(individual);
                    nifs.Add(rdr[4].ToString());
                }
                rdr.Close();

                // relleno los products
                sql = "SELECT firstName, lastName, dateOfBirth, activeCustomer from customer WHERE COUNTRY = 'NL'";
                MySqlCommand prodCmd = new MySqlCommand(sql, conn);
                rdr = prodCmd.ExecuteReader();
                foreach(string nif in nifs)
                {
                    individual.products.Add(new products());
                }

                // relleno los addresses
                sql = "SELECT firstName, lastName, dateOfBirth, activeCustomer from customer WHERE COUNTRY = 'NL'";
                MySqlCommand addrCmd = new MySqlCommand(sql, conn);
                MySqlDataReader addrRdr = addrCmd.ExecuteReader();
                while (addrRdr.Read())
                {
                    individual.addresses.Add(new addresses());
                } 


                individualsFileCreator(list);
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void accountForm(bool activas, bool inactivas, string numeroProducto)
        {


        }

        public void individualsFileCreator(List <Individual> list)
        {
            String output = "[\n";
            foreach(Individual i in list){
                string stringjson = JsonConvert.SerializeObject(i);
                output += (stringjson);
                output += ",\n";
            }
            output += "]";
            Console.WriteLine(output);
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
