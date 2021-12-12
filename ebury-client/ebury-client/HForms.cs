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

        private string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private User mainUser;

        public HForms(User u)
        {
            this.mainUser = u;
        }

        public void clientInform(string primerNombre, string segundoNombre, string ciudad, string calle, string numero, string codigoPostal)
        {
            Dictionary<string, Individual> list = new Dictionary<string, Individual>();

            try
            {
                MySqlConnection conn = new MySqlConnection(connection_data);
                conn.Open();

                string sql = "SELECT firstName,lastName,birthDate,accountState, nif " +
                "FROM customer JOIN particular  USING (nif) JOIN  customerXAccount USING(nif)"
                + "JOIN eburyAccount USING(accountNumber) WHERE Country = 'NL'";

                // Add search parameters if they exist
                if (!string.IsNullOrEmpty(primerNombre))
                    sql += " AND firstName = '" + primerNombre + "'";
                if (!string.IsNullOrEmpty(segundoNombre))
                    sql += " AND lastName = '" + segundoNombre + "'";
                if (!string.IsNullOrEmpty(ciudad))
                    sql += " AND city = '" + ciudad + "'";
                if (!string.IsNullOrEmpty(calle))
                    sql += " AND street = '" + calle + "'";
                if (!string.IsNullOrEmpty(numero))
                    sql += " AND NUMBER = '" + numero + "'";
                if (!string.IsNullOrEmpty(codigoPostal))
                    sql += " AND postalCode = '" + codigoPostal + "'";
       
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Individual individual = new Individual(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
                    list.Add(rdr[4].ToString(), individual);
                }
                rdr.Close();

                // relleno los products
                foreach (KeyValuePair<string, Individual> nif in list)
                {
                    sql = "SELECT accountNumber,accountState FROM customer JOIN particular USING (nif) " +
                        "JOIN  customerXAccount USING(nif) JOIN eburyAccount USING(accountNumber) WHERE nif =" + nif.Key;
                    MySqlCommand prodCmd = new MySqlCommand(sql, conn);
                    rdr = prodCmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        nif.Value.products.Add(new products(rdr[0].ToString(), rdr[1].ToString()));
                    }

                    rdr.Close();
                }

                // relleno los addresses
                foreach (KeyValuePair<string, Individual> nif in list)
                {
                    sql = "SELECT city,street,NUMBER,postalCode,Country FROM customer JOIN particular USING (nif)" +
                        "JOIN  customerXAccount USING(nif) JOIN eburyAccount USING(accountNumber) WHERE nif = " + nif.Key;
                    MySqlCommand addrCmd = new MySqlCommand(sql, conn);
                    rdr = addrCmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        nif.Value.addresses.Add(new addresses(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString()));
                    }

                    rdr.Close();
                }

                individualsFileCreator(list.Values);
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

        public void individualsFileCreator(Dictionary<string, Individual>.ValueCollection list)
        {
            String output = "[\n";
            foreach (Individual i in list)
            {
                string stringjson = JsonConvert.SerializeObject(i);
                output += (stringjson);
                output += ",\n";
            }
            output = output.Substring(0, output.Length - 2);
            output += "]";
            //Console.WriteLine(output);

            String location = fileName("CLIENTS");
            File.AppendAllText(location, output);
        }

        public String fileName(string name)
        {
            DateTime date = DateTime.Now;
            String fName = @"\Ebury_" + name + "_" + date.ToString("ddMMyyyyHHmmss") + @".json";
            return desktopPath + fName;
        }
    }
}
