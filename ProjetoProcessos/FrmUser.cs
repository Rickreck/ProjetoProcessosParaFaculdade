using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProcessos
{
    public partial class FrmUser : Form
    {

        Conection con = new Conection();
        string sql;
        
        MySqlCommand cmd;
        string hashedPassword;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public bool ValidationEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void ClearLabel()
        {

            textBoxUser.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            

        }
        private bool Verification()
        {
            if (textBoxUser.Text.ToString().Trim() == "" || textBoxUser.Text.ToString().Length < 6)
            {
                MessageBox.Show("Digite um Nome de Usuário válido");
                textBoxUser.Focus();
                return false;
            }

            con.OpenConnection();

            string sql = "SELECT COUNT(*) FROM login WHERE `nome_usuario` = @nomeUsuario";
            MySqlCommand cmd = new MySqlCommand(sql, con.conx);
            cmd.Parameters.AddWithValue("@nomeUsuario", textBoxUser.Text);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            con.CloseConnection();
            if (count > 0)
            {

                MessageBox.Show("Esse Usuário já existe");
                textBoxUser.Focus();
                return false;


            }
            if (textBoxEmail.Text.ToString().Trim() == "" || !ValidationEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Digite um email válido");
                textBoxEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Digite uma senha válida");
                textBoxPassword.Focus();
                return false;
            }
            if (textBoxPassword.Text.ToString().Length < 8) {

                MessageBox.Show("Sua senha é curta demais");
                textBoxPassword.Focus();
                return false;
            }

            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Suas senhas não coincidem");
                textBoxRepeatPassword.Focus();
                return false;
            }


            return true;
        }
        private void accountButton_Click(object sender, EventArgs e)
        {

            if (!Verification()) return;
           hashedPassword = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
            con.OpenConnection();

            sql = "INSERT INTO login (`nome_usuario`, `email`, `senha`) VALUES (@nome, @email, @senha)";
            cmd = new MySqlCommand(sql, con.conx);
            cmd.Parameters.AddWithValue("@nome", textBoxUser.Text);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@senha", hashedPassword);

            cmd.ExecuteNonQuery();
            con.CloseConnection();

            MessageBox.Show("Conta criada com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearLabel();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
