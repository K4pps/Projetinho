using site;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto
{
    public partial class Form1 : Form
    {
        private int Id;


        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            Tabelao.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM KAPPS1";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string email = (string)dr["Email"];
                    string senha = (string)dr["Senha"];
                    string telefone = (string)dr["Telefone"];
                    string nome = (string)dr["Nome"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(telefone);
                    lv.SubItems.Add(senha);
                    Tabelao.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void lbnome_Click(object sender, EventArgs e)
        {

        }

        //private bool IsValidPhoneNumber(string telefone)
        //{
        //    // Define a expressão regular para validar um número de telefone no formato (99) 99999-9999
        //    string pattern = @"^\(\d{2}\)\d{5}-\d{4}$";

        //    // Cria um objeto Regex com a expressão regular
        //    Regex regex = new Regex(pattern);

        //    // Usa o método Match para verificar se o telefone corresponde ao padrão
        //    return regex.IsMatch(telefone);
        //}


        private void lbtelefone_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Tabelao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE KAPPS1 SET Email = @Email, Senha = @Senha, Cpf = @Cpf, Telefone = @Telefone, Nome = @Nome, WHERE ID = @ID";

            sqlCommand.Parameters.AddWithValue("@Email", textemail.Text);
            sqlCommand.Parameters.AddWithValue("@Senha", textsenha.Text);
            sqlCommand.Parameters.AddWithValue("@Telefone", textemail.Text);
            sqlCommand.Parameters.AddWithValue("@Nome", textname.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void Tabelao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;

            index = Tabelao.FocusedItem.Index;

            Id = int.Parse(Tabelao.Items[index].SubItems[0].Text);

            textname.Text = Tabelao.Items[index].SubItems[1].Text;

            textemail.Text = Tabelao.Items[index].SubItems[2].Text;

            textemail.Text = Tabelao.Items[index].SubItems[3].Text;

            textsenha.Text = Tabelao.Items[index].SubItems[4].Text;


        }

        
        private void LtvStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = Tabelao.FocusedItem.Index;
            Id = int.Parse(Tabelao.Items[index].SubItems[0].Text);
            textname.Text = Tabelao.Items[index].SubItems[1].Text;
            textemail.Text = Tabelao.Items[index].SubItems[2].Text;
            textemail.Text = Tabelao.Items[index].SubItems[3].Text;
            textsenha.Text = Tabelao.Items[index].SubItems[5].Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Código para excluir
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM KAPPS1 WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {
            string name = textname.Text, email = textemail.Text, telefone = txttele.Text;
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            {
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO KAPPS1 VALUES (@Email, @Senha, @Cpf, @Telefone, @Nome)";

                sqlCommand.Parameters.AddWithValue("@Email", textemail.Text);
                sqlCommand.Parameters.AddWithValue("@Senha", textsenha.Text);
                sqlCommand.Parameters.AddWithValue("@Telefone", txttele.Text);
                sqlCommand.Parameters.AddWithValue("@Nome", textname.Text);
                sqlCommand.ExecuteNonQuery();
            };


            MessageBox.Show("Cadastro realizado com sucesso!");


            //if (IsValidEmail(email) && ValidarCPF(cpf))
            //{
            //    MessageBox.Show("Email e CPF válidos!", "Validação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Email ou CPF inválidos!", "Validação Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE KAPPS1 SET

            Nome       = @nome, 
            Email      = @email,
            Cpf        = @cpf, 
            Telefone   = @telefone, 
            Senha      = @senha
            where 
            ID = @ID";

            sqlCommand.Parameters.AddWithValue("@nome", textname.Text);
            sqlCommand.Parameters.AddWithValue("@email", textemail.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txttele.Text);
            sqlCommand.Parameters.AddWithValue("@senha", textsenha.Text);
            sqlCommand.Parameters.AddWithValue("@id", Id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Editado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            textname.Clear();
            txttele.Clear();
            textsenha.Clear();
            textemail.Clear();


            UpdateListView();
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            //Código para excluir
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM KAPPS1 WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
