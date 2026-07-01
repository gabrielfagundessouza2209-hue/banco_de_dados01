/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 30/06/2026
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_1
{
	partial class TelaLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_TelaLogin;
		private System.Windows.Forms.Label lbl_Usuario;
		private System.Windows.Forms.TextBox txt_Usuario;
		private System.Windows.Forms.Label lbl_Senha;
		private System.Windows.Forms.TextBox txt_Senha;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.LinkLabel linkLabel_TelaDeLogin;
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
			this.lbl_TelaLogin = new System.Windows.Forms.Label();
			this.lbl_Usuario = new System.Windows.Forms.Label();
			this.txt_Usuario = new System.Windows.Forms.TextBox();
			this.lbl_Senha = new System.Windows.Forms.Label();
			this.txt_Senha = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.linkLabel_TelaDeLogin = new System.Windows.Forms.LinkLabel();
			this.lbl_DescriçãoLogin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_TelaLogin
			// 
			this.lbl_TelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TelaLogin.Location = new System.Drawing.Point(105, 38);
			this.lbl_TelaLogin.Name = "lbl_TelaLogin";
			this.lbl_TelaLogin.Size = new System.Drawing.Size(423, 33);
			this.lbl_TelaLogin.TabIndex = 9;
			this.lbl_TelaLogin.Text = "Tela de login\r\n";
			this.lbl_TelaLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl_Usuario
			// 
			this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Usuario.Location = new System.Drawing.Point(63, 168);
			this.lbl_Usuario.Name = "lbl_Usuario";
			this.lbl_Usuario.Size = new System.Drawing.Size(206, 22);
			this.lbl_Usuario.TabIndex = 10;
			this.lbl_Usuario.Text = "Digite seu nome de usuário:\r\n\r\n";
			this.lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_Usuario
			// 
			this.txt_Usuario.Location = new System.Drawing.Point(275, 170);
			this.txt_Usuario.Name = "txt_Usuario";
			this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
			this.txt_Usuario.TabIndex = 11;
			// 
			// lbl_Senha
			// 
			this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Senha.Location = new System.Drawing.Point(96, 217);
			this.lbl_Senha.Name = "lbl_Senha";
			this.lbl_Senha.Size = new System.Drawing.Size(136, 22);
			this.lbl_Senha.TabIndex = 12;
			this.lbl_Senha.Text = "Digite sua senha:\r\n\r\n";
			this.lbl_Senha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_Senha
			// 
			this.txt_Senha.Location = new System.Drawing.Point(238, 219);
			this.txt_Senha.Name = "txt_Senha";
			this.txt_Senha.PasswordChar = '*';
			this.txt_Senha.Size = new System.Drawing.Size(100, 20);
			this.txt_Senha.TabIndex = 13;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(234, 284);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(140, 42);
			this.btn_Login.TabIndex = 14;
			this.btn_Login.Text = "Entrar";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.Btn_LoginClick);
			// 
			// linkLabel_TelaDeLogin
			// 
			this.linkLabel_TelaDeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel_TelaDeLogin.Location = new System.Drawing.Point(164, 415);
			this.linkLabel_TelaDeLogin.Name = "linkLabel_TelaDeLogin";
			this.linkLabel_TelaDeLogin.Size = new System.Drawing.Size(282, 23);
			this.linkLabel_TelaDeLogin.TabIndex = 15;
			this.linkLabel_TelaDeLogin.TabStop = true;
			this.linkLabel_TelaDeLogin.Text = "Ir para a tela de cadastro\r\n";
			this.linkLabel_TelaDeLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel_TelaDeLogin.Click += new System.EventHandler(this.LinkLabel_TelaDeLoginClick);
			// 
			// lbl_DescriçãoLogin
			// 
			this.lbl_DescriçãoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DescriçãoLogin.Location = new System.Drawing.Point(78, 366);
			this.lbl_DescriçãoLogin.Name = "lbl_DescriçãoLogin";
			this.lbl_DescriçãoLogin.Size = new System.Drawing.Size(450, 34);
			this.lbl_DescriçãoLogin.TabIndex = 17;
			this.lbl_DescriçãoLogin.Text = "Clique no link abaixo caso queira ser redirecionado para tela de \r\ncadastro\r\n";
			this.lbl_DescriçãoLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 478);
			this.Controls.Add(this.lbl_DescriçãoLogin);
			this.Controls.Add(this.linkLabel_TelaDeLogin);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.txt_Senha);
			this.Controls.Add(this.lbl_Senha);
			this.Controls.Add(this.txt_Usuario);
			this.Controls.Add(this.lbl_Usuario);
			this.Controls.Add(this.lbl_TelaLogin);
			this.Name = "TelaLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "TelaLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
