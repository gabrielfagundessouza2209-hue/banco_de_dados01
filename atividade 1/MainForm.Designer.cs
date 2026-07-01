/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 30/06/2026
 * Time: 09:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_1
{
	partial class TelaDeCadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.TextBox textBox_Senha;
		private System.Windows.Forms.Label lbl_Usuario;
		private System.Windows.Forms.Label lbl_Senha;
		private System.Windows.Forms.TextBox textBox_Nome;
		private System.Windows.Forms.Label lbl_Nome;
		private System.Windows.Forms.LinkLabel linkLabel_TelaDeCadastro;
		private System.Windows.Forms.Button btn_Cadastrar;
		private System.Windows.Forms.Label lbl_TelaDeCadastroDeUsuario;
		private System.Windows.Forms.Label lbl_DescriçãoLogin;
		
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
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.textBox_Senha = new System.Windows.Forms.TextBox();
			this.lbl_Usuario = new System.Windows.Forms.Label();
			this.lbl_Senha = new System.Windows.Forms.Label();
			this.textBox_Nome = new System.Windows.Forms.TextBox();
			this.lbl_Nome = new System.Windows.Forms.Label();
			this.linkLabel_TelaDeCadastro = new System.Windows.Forms.LinkLabel();
			this.btn_Cadastrar = new System.Windows.Forms.Button();
			this.lbl_TelaDeCadastroDeUsuario = new System.Windows.Forms.Label();
			this.lbl_DescriçãoLogin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(322, 195);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(199, 20);
			this.txt_usuario.TabIndex = 0;
			// 
			// textBox_Senha
			// 
			this.textBox_Senha.Location = new System.Drawing.Point(260, 233);
			this.textBox_Senha.Multiline = true;
			this.textBox_Senha.Name = "textBox_Senha";
			this.textBox_Senha.Size = new System.Drawing.Size(199, 20);
			this.textBox_Senha.TabIndex = 1;
			// 
			// lbl_Usuario
			// 
			this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Usuario.Location = new System.Drawing.Point(44, 193);
			this.lbl_Usuario.Name = "lbl_Usuario";
			this.lbl_Usuario.Size = new System.Drawing.Size(274, 22);
			this.lbl_Usuario.TabIndex = 2;
			this.lbl_Usuario.Text = "Cadastre seu novo nome de usuário :";
			this.lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl_Senha
			// 
			this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Senha.Location = new System.Drawing.Point(57, 229);
			this.lbl_Senha.Name = "lbl_Senha";
			this.lbl_Senha.Size = new System.Drawing.Size(197, 24);
			this.lbl_Senha.TabIndex = 3;
			this.lbl_Senha.Text = "Cadastre sua nova senha:";
			// 
			// textBox_Nome
			// 
			this.textBox_Nome.Location = new System.Drawing.Point(291, 158);
			this.textBox_Nome.Name = "textBox_Nome";
			this.textBox_Nome.Size = new System.Drawing.Size(199, 20);
			this.textBox_Nome.TabIndex = 4;
			// 
			// lbl_Nome
			// 
			this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nome.Location = new System.Drawing.Point(44, 156);
			this.lbl_Nome.Name = "lbl_Nome";
			this.lbl_Nome.Size = new System.Drawing.Size(241, 22);
			this.lbl_Nome.TabIndex = 5;
			this.lbl_Nome.Text = "Digite seu nome para cadastro:\r\n";
			this.lbl_Nome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// linkLabel_TelaDeCadastro
			// 
			this.linkLabel_TelaDeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel_TelaDeCadastro.Location = new System.Drawing.Point(221, 380);
			this.linkLabel_TelaDeCadastro.Name = "linkLabel_TelaDeCadastro";
			this.linkLabel_TelaDeCadastro.Size = new System.Drawing.Size(191, 23);
			this.linkLabel_TelaDeCadastro.TabIndex = 6;
			this.linkLabel_TelaDeCadastro.TabStop = true;
			this.linkLabel_TelaDeCadastro.Text = "Ir para a tela de login";
			this.linkLabel_TelaDeCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_TelaDeLoginLinkClicked);
			// 
			// btn_Cadastrar
			// 
			this.btn_Cadastrar.Location = new System.Drawing.Point(239, 286);
			this.btn_Cadastrar.Name = "btn_Cadastrar";
			this.btn_Cadastrar.Size = new System.Drawing.Size(140, 42);
			this.btn_Cadastrar.TabIndex = 7;
			this.btn_Cadastrar.Text = "cadastrar usuário";
			this.btn_Cadastrar.UseVisualStyleBackColor = true;
			this.btn_Cadastrar.Click += new System.EventHandler(this.Btn_CadastrarClick);
			// 
			// lbl_TelaDeCadastroDeUsuario
			// 
			this.lbl_TelaDeCadastroDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TelaDeCadastroDeUsuario.Location = new System.Drawing.Point(98, 35);
			this.lbl_TelaDeCadastroDeUsuario.Name = "lbl_TelaDeCadastroDeUsuario";
			this.lbl_TelaDeCadastroDeUsuario.Size = new System.Drawing.Size(423, 33);
			this.lbl_TelaDeCadastroDeUsuario.TabIndex = 8;
			this.lbl_TelaDeCadastroDeUsuario.Text = "Tela de cadastro de usuário\r\n";
			this.lbl_TelaDeCadastroDeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl_DescriçãoLogin
			// 
			this.lbl_DescriçãoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DescriçãoLogin.Location = new System.Drawing.Point(95, 346);
			this.lbl_DescriçãoLogin.Name = "lbl_DescriçãoLogin";
			this.lbl_DescriçãoLogin.Size = new System.Drawing.Size(450, 34);
			this.lbl_DescriçãoLogin.TabIndex = 9;
			this.lbl_DescriçãoLogin.Text = "clique no link abaixo para ser redirecionado a tela de login\r\n";
			this.lbl_DescriçãoLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TelaDeCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 478);
			this.Controls.Add(this.lbl_DescriçãoLogin);
			this.Controls.Add(this.lbl_TelaDeCadastroDeUsuario);
			this.Controls.Add(this.btn_Cadastrar);
			this.Controls.Add(this.linkLabel_TelaDeCadastro);
			this.Controls.Add(this.lbl_Nome);
			this.Controls.Add(this.textBox_Nome);
			this.Controls.Add(this.lbl_Senha);
			this.Controls.Add(this.lbl_Usuario);
			this.Controls.Add(this.textBox_Senha);
			this.Controls.Add(this.txt_usuario);
			this.Name = "TelaDeCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Cadastro usuário";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
