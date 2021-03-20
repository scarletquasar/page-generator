/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 19/03/2021
 * Hora: 20:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace GeradorCadastro
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.nomeFuncionario = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.descFuncionario = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.fotoFuncionario = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.pagFuncionario = new System.Windows.Forms.RichTextBox();
			this.limparCampos = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(430, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "GERADOR DE CADASTROS";
			// 
			// nomeFuncionario
			// 
			this.nomeFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nomeFuncionario.Location = new System.Drawing.Point(236, 41);
			this.nomeFuncionario.Multiline = false;
			this.nomeFuncionario.Name = "nomeFuncionario";
			this.nomeFuncionario.Size = new System.Drawing.Size(331, 32);
			this.nomeFuncionario.TabIndex = 2;
			this.nomeFuncionario.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "NOME DO FUNCIONÁRIO:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 40);
			this.label3.TabIndex = 5;
			this.label3.Text = "DESCRIÇÃO DO FUNCIONÁRIO:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// descFuncionario
			// 
			this.descFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.descFuncionario.Location = new System.Drawing.Point(168, 112);
			this.descFuncionario.Name = "descFuncionario";
			this.descFuncionario.Size = new System.Drawing.Size(398, 222);
			this.descFuncionario.TabIndex = 4;
			this.descFuncionario.Text = "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 184);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// fotoFuncionario
			// 
			this.fotoFuncionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fotoFuncionario.Location = new System.Drawing.Point(12, 155);
			this.fotoFuncionario.Name = "fotoFuncionario";
			this.fotoFuncionario.Size = new System.Drawing.Size(150, 23);
			this.fotoFuncionario.TabIndex = 7;
			this.fotoFuncionario.Text = "Foto do funcionário";
			this.fotoFuncionario.UseVisualStyleBackColor = true;
			this.fotoFuncionario.Click += new System.EventHandler(this.fotoFuncionarioClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(291, 340);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(275, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Gerar página ";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(217, 32);
			this.label4.TabIndex = 11;
			this.label4.Text = "PÁGINA DO CADASTRO:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pagFuncionario
			// 
			this.pagFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pagFuncionario.Location = new System.Drawing.Point(236, 73);
			this.pagFuncionario.Multiline = false;
			this.pagFuncionario.Name = "pagFuncionario";
			this.pagFuncionario.Size = new System.Drawing.Size(331, 32);
			this.pagFuncionario.TabIndex = 10;
			this.pagFuncionario.Text = "";
			// 
			// limparCampos
			// 
			this.limparCampos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.limparCampos.Location = new System.Drawing.Point(13, 341);
			this.limparCampos.Name = "limparCampos";
			this.limparCampos.Size = new System.Drawing.Size(272, 23);
			this.limparCampos.TabIndex = 12;
			this.limparCampos.Text = "Limpar campos";
			this.limparCampos.UseVisualStyleBackColor = true;
			this.limparCampos.Click += new System.EventHandler(this.limparCamposClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 376);
			this.Controls.Add(this.limparCampos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pagFuncionario);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.fotoFuncionario);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.descFuncionario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nomeFuncionario);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(588, 405);
			this.MinimumSize = new System.Drawing.Size(588, 405);
			this.Name = "MainForm";
			this.Text = "GeradorCadastro";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button limparCampos;
		private System.Windows.Forms.RichTextBox pagFuncionario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button fotoFuncionario;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox descFuncionario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox nomeFuncionario;
		private System.Windows.Forms.Label label1;
	}
}
