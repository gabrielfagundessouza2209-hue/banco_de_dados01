using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atividade_1
{
	public partial class TelaCadastroDoCliente : Form
	{
		public TelaCadastroDoCliente()
			
			
		{
			InitializeComponent();
			
		} 
		
		string conexaoBanco =  "server=localhost;port=3306;database=sistema_clientes;uid=root;pwd=;";
		void Btn_CadastrarClienteClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txt_Cliente.Text)|| string.IsNullOrWhiteSpace(txt_telefone.Text))
			{
				
				MessageBox.Show("Os campos nome do cliente e telefone são obrigatorios!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
			}
			
			try
			{
				using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
				{
					conexao.Open();
					string query = "INSERT INTO clientes (nome_cliente, telefone, email, endereco, observacao) " +
                           "VALUES (@nome, @telefone, @email, @endereco, @observacao)";
				          
					using(MySqlCommand comando = new MySqlCommand(query, conexao))
					{
						comando.Parameters.AddWithValue("@nome",txt_Cliente.Text);
						comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
						comando.Parameters.AddWithValue("@email", txt_email.Text);
						comando.Parameters.AddWithValue("@endereco", txt_endereco.Text);
						comando.Parameters.AddWithValue("@observacao", txt_observaçao.Text);
						
						comando.ExecuteNonQuery();
						
						
						MessageBox.Show("Cliente cadastrado com sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
						LimparCampos();
										
					}
					
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar cliente:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}
		private void LimparCampos()
		{
			txt_Cliente.Clear();
			txt_telefone.Clear();
			txt_email.Clear();
			txt_endereco.Clear();
			txt_observaçao.Clear();
			txt_Cliente.Focus();   // coloca o cursor de volta no primeiro campo
		}
		
		
			
	}
	
}
