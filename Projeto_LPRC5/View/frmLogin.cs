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
    public partial class frmLogin : Form
    {
        //private static util suporte = new util();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //  util.usuarioAtual = util.loginAcesso(txtUsuario.Text, util.criptografaDados(txtSenha.Text));
            util.usuarioAtual = 1;
            if (util.usuarioAtual <= 0)
            {
                MessageBox.Show("Login ou Senha inválido, verifique!!!", "Login de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
