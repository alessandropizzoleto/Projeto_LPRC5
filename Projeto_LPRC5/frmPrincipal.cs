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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
 
        }

        private void tipoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoUsuario tipoUsuario = new frmTipoUsuario();
            tipoUsuario.MdiParent = this;
            tipoUsuario.Show();
        }

        private void mnuClassificaPessoa_Click(object sender, EventArgs e)
        {
            frmClassificaPessoa classificaPessoa = new frmClassificaPessoa();
            classificaPessoa.MdiParent = this;
            classificaPessoa.Show();
        }

        private void mnuAcesso_Click(object sender, EventArgs e)
        {
            frmAcesso acesso = new frmAcesso();
            acesso.MdiParent = this;
            acesso.Show();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCor Corno = new frmCor();
            Corno.Show();
        }
    }
}
