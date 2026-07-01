/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 01/07/2026
 * Time: 09:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_1
{
	partial class TelaCadastroDoCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_NomeDoCliente;
		private System.Windows.Forms.TextBox txt_Cliente;
		private System.Windows.Forms.Label lbl_TelaLogin;
		private System.Windows.Forms.Label lbl_telefone;
		private System.Windows.Forms.TextBox txt_telefone;
		private System.Windows.Forms.Label lbl_email;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label lbl_endereco;
		private System.Windows.Forms.TextBox txt_endereco;
		private System.Windows.Forms.Label lbl_observaçao;
		private System.Windows.Forms.TextBox txt_observaçao;
		private System.Windows.Forms.Button btn_CadastrarCliente;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_NomeDoCliente = new System.Windows.Forms.Label();
			this.txt_Cliente = new System.Windows.Forms.TextBox();
			this.lbl_TelaLogin = new System.Windows.Forms.Label();
			this.lbl_telefone = new System.Windows.Forms.Label();
			this.txt_telefone = new System.Windows.Forms.TextBox();
			this.lbl_email = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.lbl_endereco = new System.Windows.Forms.Label();
			this.txt_endereco = new System.Windows.Forms.TextBox();
			this.lbl_observaçao = new System.Windows.Forms.Label();
			this.txt_observaçao = new System.Windows.Forms.TextBox();
			this.btn_CadastrarCliente = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_NomeDoCliente
			// 
			this.lbl_NomeDoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_NomeDoCliente.Location = new System.Drawing.Point(22, 105);
			this.lbl_NomeDoCliente.Name = "lbl_NomeDoCliente";
			this.lbl_NomeDoCliente.Size = new System.Drawing.Size(197, 22);
			this.lbl_NomeDoCliente.TabIndex = 11;
			this.lbl_NomeDoCliente.Text = "Digite o nome do cliente:\r\n\r\n";
			this.lbl_NomeDoCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_Cliente
			// 
			this.txt_Cliente.Location = new System.Drawing.Point(225, 107);
			this.txt_Cliente.Name = "txt_Cliente";
			this.txt_Cliente.Size = new System.Drawing.Size(339, 20);
			this.txt_Cliente.TabIndex = 12;
			// 
			// lbl_TelaLogin
			// 
			this.lbl_TelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TelaLogin.Location = new System.Drawing.Point(120, 21);
			this.lbl_TelaLogin.Name = "lbl_TelaLogin";
			this.lbl_TelaLogin.Size = new System.Drawing.Size(423, 33);
			this.lbl_TelaLogin.TabIndex = 13;
			this.lbl_TelaLogin.Text = "Cadastro do cliente";
			this.lbl_TelaLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl_telefone
			// 
			this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_telefone.Location = new System.Drawing.Point(25, 157);
			this.lbl_telefone.Name = "lbl_telefone";
			this.lbl_telefone.Size = new System.Drawing.Size(284, 22);
			this.lbl_telefone.TabIndex = 14;
			this.lbl_telefone.Text = "Digite o número de telefone do cliente:\r\n\r\n";
			this.lbl_telefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_telefone
			// 
			this.txt_telefone.Location = new System.Drawing.Point(315, 159);
			this.txt_telefone.Name = "txt_telefone";
			this.txt_telefone.Size = new System.Drawing.Size(259, 20);
			this.txt_telefone.TabIndex = 15;
			// 
			// lbl_email
			// 
			this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_email.Location = new System.Drawing.Point(25, 208);
			this.lbl_email.Name = "lbl_email";
			this.lbl_email.Size = new System.Drawing.Size(194, 22);
			this.lbl_email.TabIndex = 16;
			this.lbl_email.Text = "Digite o e-mail do cliente:";
			this.lbl_email.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(225, 210);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(339, 20);
			this.txt_email.TabIndex = 17;
			// 
			// lbl_endereco
			// 
			this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_endereco.Location = new System.Drawing.Point(12, 252);
			this.lbl_endereco.Name = "lbl_endereco";
			this.lbl_endereco.Size = new System.Drawing.Size(214, 30);
			this.lbl_endereco.TabIndex = 18;
			this.lbl_endereco.Text = "Digite o endereço do cliente:\r\n";
			this.lbl_endereco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_endereco
			// 
			this.txt_endereco.Location = new System.Drawing.Point(231, 254);
			this.txt_endereco.Name = "txt_endereco";
			this.txt_endereco.Size = new System.Drawing.Size(333, 20);
			this.txt_endereco.TabIndex = 19;
			// 
			// lbl_observaçao
			// 
			this.lbl_observaçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_observaçao.Location = new System.Drawing.Point(11, 289);
			this.lbl_observaçao.Name = "lbl_observaçao";
			this.lbl_observaçao.Size = new System.Drawing.Size(214, 30);
			this.lbl_observaçao.TabIndex = 20;
			this.lbl_observaçao.Text = "observação:\r\n";
			this.lbl_observaçao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_observaçao
			// 
			this.txt_observaçao.Location = new System.Drawing.Point(185, 291);
			this.txt_observaçao.Name = "txt_observaçao";
			this.txt_observaçao.Size = new System.Drawing.Size(333, 20);
			this.txt_observaçao.TabIndex = 21;
			// 
			// btn_CadastrarCliente
			// 
			this.btn_CadastrarCliente.Location = new System.Drawing.Point(231, 348);
			this.btn_CadastrarCliente.Name = "btn_CadastrarCliente";
			this.btn_CadastrarCliente.Size = new System.Drawing.Size(152, 59);
			this.btn_CadastrarCliente.TabIndex = 22;
			this.btn_CadastrarCliente.Text = "Cadastrar clientes";
			this.btn_CadastrarCliente.UseVisualStyleBackColor = true;
			this.btn_CadastrarCliente.Click += new System.EventHandler(this.Btn_CadastrarClienteClick);
			// 
			// TelaCadastroDoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 478);
			this.Controls.Add(this.btn_CadastrarCliente);
			this.Controls.Add(this.txt_observaçao);
			this.Controls.Add(this.lbl_observaçao);
			this.Controls.Add(this.txt_endereco);
			this.Controls.Add(this.lbl_endereco);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.lbl_email);
			this.Controls.Add(this.txt_telefone);
			this.Controls.Add(this.lbl_telefone);
			this.Controls.Add(this.lbl_TelaLogin);
			this.Controls.Add(this.txt_Cliente);
			this.Controls.Add(this.lbl_NomeDoCliente);
			this.Name = "TelaCadastroDoCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "TelaCadastroDoCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
