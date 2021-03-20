using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace GeradorCadastro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int ProgressValue = 0;
		public string CadastrosPath = AppDomain.CurrentDomain.BaseDirectory + @"/cadastros";
		public string GenericoPath = AppDomain.CurrentDomain.BaseDirectory + @"/generico/index.html";
		public MainForm()
		{
			InitializeComponent();
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			if (!Directory.Exists(CadastrosPath)) { Directory.CreateDirectory(CadastrosPath); }
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		public void AplicarValoresPag() {
			string PagGenerica = File.ReadAllText(GenericoPath);
			string novaPag = "";
			novaPag = PagGenerica.Replace("<[nomefunc]>", nomeFuncionario.Text);
			novaPag = novaPag.Replace("<[descfunc]>", descFuncionario.Text);
			
			if (!Directory.Exists(CadastrosPath + @"/" + pagFuncionario.Text)) {
				Directory.CreateDirectory(CadastrosPath + @"/" + pagFuncionario.Text);
				File.WriteAllText(CadastrosPath + @"/" + pagFuncionario.Text + @"/" + "index.html", novaPag);
				
				try {
				pictureBox1.Image.Save(CadastrosPath + @"/" + pagFuncionario.Text + @"/" + "user_picture.png", ImageFormat.Png);
				}
				catch {}
				}
			else {
				MessageBox.Show("Ocorreu um erro: O cadastro já existe.", "Erro");
			}
		}
		
		public Image DefinirFotoFuncionario() {

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
   			openFileDialog.InitialDirectory = "c:\\";
   			openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
   		    openFileDialog.FilterIndex = 2;
		    openFileDialog.RestoreDirectory = true;

		    if (openFileDialog.ShowDialog() == DialogResult.OK)
		    {
		    	return new Bitmap(openFileDialog.FileName);
		    	
    		}
		    
			}
			
			return null;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			AplicarValoresPag();			
		}
		
		void fotoFuncionarioClick(object sender, EventArgs e)
		{
			pictureBox1.Image = DefinirFotoFuncionario();			
		}
		

		
		void limparCamposClick(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
			nomeFuncionario.Text = "";
			descFuncionario.Text = "";
			pagFuncionario.Text = "";
		}
	}
}
