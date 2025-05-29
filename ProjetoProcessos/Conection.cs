using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoProcessos
{
    internal class Conection
    {
        //public string conec = "SERVER=localhost; DATABASE=processos; UID=root; PWD=; PORT=;";
        public string conec = "SERVER=mysql744.umbler.com; DATABASE=dbprocessos; UID=processo; PWD=processos2003; PORT=41890;";

        public MySqlConnection conx = null;


        public void OpenConnection()
        {

            try {

                conx = new MySqlConnection(conec);
                conx.Open();

            }
            catch(Exception ex) {

                MessageBox.Show($"Erro de Servidor: {ex.Message}");
            
            }

        }
        public void CloseConnection()
        {
            try
            {
                conx = new MySqlConnection(conec);
                conx.Close();
            }
            catch (Exception ex) {

                MessageBox.Show($"Erro de Servidor: {ex.Message}");

            }
        
        }
    }
}
