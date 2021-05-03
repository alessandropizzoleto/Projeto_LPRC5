using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPRC5
{
    public partial class frmAcesso : Form
    {
        util suporte = new util();

        public frmAcesso()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            suporte.gravaArquivoAcessoBanco(txtServidor.Text, txtUsuario.Text, txtBasedeDados.Text, txtSenha.Text, -1);
            txtServidor.Text = ""; txtUsuario.Text = ""; txtBasedeDados.Text = ""; txtSenha.Text = "";
            MessageBox.Show("Salvo com Sucesso!", "Alerta!", MessageBoxButtons.OK); 
        }

        private void frmAcesso_Load(object sender, EventArgs e)
        {
            suporte.lerArquivoAcessoBanco();
            txtServidor.Text = suporte.servidor.ToString();
            txtUsuario.Text = suporte.usuario.ToString();
            txtBasedeDados.Text = suporte.banco.ToString();
            txtSenha.Text = suporte.senha.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
