using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoProcessos
{
    public partial class FormProcess : Form
    {
        Conection con = new Conection();
        string sql;
        string id;
        MySqlCommand cmd;
        string dataFormated;
        private string formattedFinalDate;

        public FormProcess()
        {
            InitializeComponent();
        }
        private void PrincipalForm(object sender, EventArgs e)
        {
         
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            EnblZones();
            textName.Focus();
            ClearLabel();
            EnblFunction();
            newButton.Enabled = false;
            deleteButton.Enabled = false;
            editButton.Enabled = false;
        }

        public bool Verification()
        {
            if (textName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um Nome");
                textName.Focus();
                return false;
            }

            maskedtextPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (maskedtextPhone.Text.ToString().Trim() != "")
            {

                if (maskedtextPhone.Text.Length > 0 && maskedtextPhone.Text.Length < 11)
                {
                    MessageBox.Show("Você precisa digitar um número válido");
                    maskedtextPhone.Focus();
                    return false;
                }
                if (!long.TryParse(maskedtextPhone.Text, out long numero))
                {

                    MessageBox.Show("O telefone deve conter apenas números.");
                    maskedtextPhone.Text = "";
                    return false;

                }
              
            }
            if (maskedtextPhone.Text.ToString().Trim() == "")
                maskedtextPhone.Text = "( não informado )";
            if (textLocal.Text.ToString().Trim() == "")
                textLocal.Text = "( não informado )";

            maskedTextBoxDate.TextMaskFormat = MaskFormat.IncludeLiterals;



            string textData = maskedTextBoxDate.Text;


            if (string.IsNullOrWhiteSpace(textData) || textData == "  /  /")
            {
                MessageBox.Show("A data não pode estar vazia.");
                maskedTextBoxDate.Focus();
                return false;
            }


            if (!DateTime.TryParseExact(textData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInicio))
            {
                MessageBox.Show("Data inválida. Use o formato dd/MM/aaaa.");
                maskedTextBoxDate.Clear();
                maskedTextBoxDate.Focus();
                return false;
            }




            dataFormated = dataInicio.ToString("yyyy-MM-dd");

            string finalDateText = textDateFinal.Text;

     
            if (string.IsNullOrWhiteSpace(finalDateText) || finalDateText == "  /  /")
            {
                MessageBox.Show("Data inválida. Use o formato dd/MM/aaaa.");
                maskedTextBoxDate.Clear();
                maskedTextBoxDate.Focus();
                return false;
            }

            
            if (!DateTime.TryParseExact(finalDateText, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime finalDate))
            {
                MessageBox.Show("Data inválida. Use o formato dd/MM/aaaa.");
                textDateFinal.Clear();
                textDateFinal.Focus();
                return false;
            }

            
            if (finalDate.Date < DateTime.Today)
            {
                MessageBox.Show("The final date cannot be earlier than today.");
                textDateFinal.Focus();
                return false;
            }

            formattedFinalDate = finalDate.ToString("yyyy-MM-dd");

           
            return true;





        }
        private void saveButton_Click(object sender, EventArgs e)
        {

            if (!Verification()) return;


            newButton.Enabled = true;
            con.OpenConnection();

        sql = "INSERT INTO processos (nome, local, telefone, data, `data final`) VALUES(@nome, @local, @telefone, @data, @datafinal) ";
            cmd = new MySqlCommand(sql, con.conx);
            cmd.Parameters.AddWithValue("@nome", textName.Text);
            cmd.Parameters.AddWithValue("@local", textLocal.Text);
            cmd.Parameters.AddWithValue("@telefone", maskedtextPhone.Text);
            cmd.Parameters.AddWithValue("@data", dataFormated);
            cmd.Parameters.AddWithValue("@datafinal", formattedFinalDate);
            cmd.ExecuteNonQuery();
            con.CloseConnection();
            ListGrid();
            DsblFunction();
            ClearLabel();

            MessageBox.Show("Processo salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
           private void PrincipalForm_Load(object sender, EventArgs e)
        {
            ListGrid();
            gridData.ReadOnly = true; 
            gridData.AllowUserToAddRows = false;
        }

        private void formateGrid()
        {

            gridData.Columns[0].HeaderText = "ID";
            gridData.Columns[1].HeaderText = "Nome do Processo";
            gridData.Columns[2].HeaderText = "Local";
            gridData.Columns[3].HeaderText = "Telefone p/ contato";
            gridData.Columns[4].HeaderText = "Data de início";
            gridData.Columns[5].HeaderText = "Data Final";

            gridData.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void ListGrid()
        {

            con.OpenConnection();
            sql = "SELECT * FROM processos ORDER BY NOME ASC";
            cmd = new MySqlCommand(@sql, con.conx);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridData.DataSource = dt;
            con.CloseConnection( );

            formateGrid();

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var deleteAswer = MessageBox.Show("Tem certeza que deseja apagar o processo?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (deleteAswer == DialogResult.No) return;


            
            con.OpenConnection();

            sql = "DELETE FROM processos WHERE id=@id ";
            cmd = new MySqlCommand(sql, con.conx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.CloseConnection();
            ClearLabel();
            DsblFunction();
            newButton.Enabled = true;
            ListGrid();

            MessageBox.Show("Processo excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            ClearLabel();
            DsblFunction();
            newButton.Enabled = true;
        }

        private void textBoxName(object sender, EventArgs e)
        {

        }

        private void textBoxLocal(object sender, EventArgs e)
        {

        }

        private void textBoxPhone(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DsblFunction()
        {
            cancelButton.Enabled = false;
            saveButton.Enabled = false;
            textLocal.Enabled = false;
            deleteButton.Enabled = false;
            editButton.Enabled = false;
            maskedtextPhone.Enabled = false;
            maskedTextBoxDate.Enabled = false;
            textName.Enabled = false;
            textDateFinal.Enabled = false;
        }
        private void ClearLabel()
        {

            textName.Text = "";
            textLocal.Text = "";
            maskedtextPhone.Text = "";
            maskedTextBoxDate.Text = "";
            textDateFinal.Text = "";

        }
        private void EnblFunction()
        {
            newButton.Enabled = true;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
            deleteButton.Enabled = true;
            editButton.Enabled = true;
        }

        private void EnblZones()
        {
            textName.Enabled = true;
            textLocal.Enabled = true;
            maskedtextPhone.Enabled = true;
            maskedTextBoxDate.Enabled = true;
            textDateFinal.Enabled = true;
        }
        private void editButton_Click(object sender, EventArgs e)
        {

            var alterAswer = MessageBox.Show("Tem certeza que deseja alterar o processo?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (alterAswer == DialogResult.No) return;
            MessageBox.Show("Processo editado com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!Verification()) return;
            newButton.Enabled = true;
            con.OpenConnection();

            sql = "UPDATE processos SET nome=@nome, local=@local, telefone= @telefone, data=@data, `data final`=@datafinal  WHERE id=@id ";
            cmd = new MySqlCommand(sql, con.conx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", textName.Text);
            cmd.Parameters.AddWithValue("@local", textLocal.Text);
            cmd.Parameters.AddWithValue("@telefone", maskedtextPhone.Text);
            cmd.Parameters.AddWithValue("@data", dataFormated);
            cmd.Parameters.AddWithValue("@datafinal", formattedFinalDate);
            cmd.ExecuteNonQuery();
            con.CloseConnection();
            ListGrid();
            DsblFunction();
            ClearLabel();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

   private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnblFunction();
            EnblZones();
            newButton.Enabled = false;
            saveButton.Enabled= false;

            id= gridData.CurrentRow.Cells[0].Value.ToString();
            textName.Text = gridData.CurrentRow.Cells[1].Value.ToString();
            textLocal.Text = gridData.CurrentRow.Cells[2].Value.ToString();
            maskedtextPhone.Text = gridData.CurrentRow.Cells[3].Value.ToString();
            maskedTextBoxDate.Text = gridData.CurrentRow.Cells[4].Value.ToString();
        }

        private void SearchName()
        {
            con.OpenConnection();
            sql = "SELECT * FROM processos WHERE nome LIKE @nome ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.conx);
            cmd.Parameters.AddWithValue("@nome", textSearch.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridData.DataSource = dt;
            con.CloseConnection();

            formateGrid();
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            SearchName();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDateFinal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
