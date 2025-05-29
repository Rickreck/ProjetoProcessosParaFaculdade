using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProcessos
{
    public partial class FrmLogin : Form
    {
        Conection con = new Conection();
        
      
        public FrmLogin()
        {
            InitializeComponent();
        }

     private void registerButton_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            frm.ShowDialog();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.OpenConnection();
                MySqlCommand cmdVerify;
             MySqlDataReader reader;
                cmdVerify = new MySqlCommand("SELECT * FROM login WHERE nome_usuario=@nome", con.conx);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerify;
                cmdVerify.Parameters.AddWithValue("@nome", textUser.Text);
                
                reader = cmdVerify.ExecuteReader();

                if (reader.Read()) {

                    string nomeUsuario = reader.GetString("nome_usuario");
                    string hashedPassword = reader.GetString("senha");
                    reader.Close();


                   if(BCrypt.Net.BCrypt.Verify(textPassword.Text, hashedPassword)) {
                        FrmMenu frm = new FrmMenu();

                        this.Hide(); 
                        frm.FormClosed += (s, args) => this.Close(); 
                        frm.Show();
                    }
                    else
                    {

                        MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Esse usuário não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);

            }

            
            con.CloseConnection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
