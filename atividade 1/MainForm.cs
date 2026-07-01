using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atividade_1
{
	
	public partial class TelaDeCadastro : Form
	{
		public TelaDeCadastro()
		{
			
			InitializeComponent();		
		}
		
	string conexaoBanco = "server=localhost;port=3306;database=sistema_clientes;uid=root;pwd=;";

        void Btn_CadastrarClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Nome.Text) ||
                string.IsNullOrWhiteSpace(txt_usuario.Text) ||
                string.IsNullOrWhiteSpace(textBox_Senha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // CORREÇÃO: Adicionado o 'using' aqui
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();

                    string query = "INSERT INTO usuarios (nome, usuario, senha) VALUES (@nome, @usuario, @senha)";

                    // CORREÇÃO: Adicionado o 'using' aqui também
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBox_Nome.Text.Trim());
                        comando.Parameters.AddWithValue("@usuario", txt_usuario.Text.Trim());
                        comando.Parameters.AddWithValue("@senha", textBox_Senha.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TelaLogin login = new TelaLogin();
                        login.Show();
                        
                        // CORREÇÃO: Mudado de Close() para Hide() para não fechar o app inteiro
                        this.Hide(); 
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        } 

        void LinkLabel_TelaDeLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            
            // CORREÇÃO: Mudado de Close() para Hide() aqui também
            this.Hide(); 
        }
    
        
}
    }
	