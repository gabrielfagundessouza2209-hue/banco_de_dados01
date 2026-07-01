using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atividade_1
{
	public partial class TelaLogin : Form
	{
		public TelaLogin()
		{
			
			InitializeComponent();
		}
		private string conexaoBanco = "server=localhost;port=3306;database=sistema_clientes;uid=root;pwd=;";
        // NOME CORRIGIDO: Agora bate com o "Btn_LoginClick" do seu Designer
        private void Btn_LoginClick(object sender, EventArgs e)
        {
            // Validação simples para não deixar pesquisar campos vazios
            if (string.IsNullOrWhiteSpace(txt_Usuario.Text) || string.IsNullOrWhiteSpace(txt_Senha.Text))
            {
                MessageBox.Show("Por favor, digite o usuário e a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND senha = @senha";
                    
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
                        comando.Parameters.AddWithValue("@senha", txt_Senha.Text);

                        int resultado = Convert.ToInt32(comando.ExecuteScalar());

                        if (resultado > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            TelaCadastroDoCliente telaCliente = new TelaCadastroDoCliente();
                            telaCliente.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NOME AJUSTADO: Método que chamaremos ao clicar no LinkLabel
        private void LinkLabel_TelaDeLoginClick(object sender, EventArgs e)
        { 
            TelaDeCadastro cadastroUsuario = new TelaDeCadastro();
            cadastroUsuario.Show();
            this.Hide();
        }
    }
}