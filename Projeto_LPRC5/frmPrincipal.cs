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
            //util suporte = new util();

            //suporte.lerArquivoAcessoBanco(@"C:\software\acesso.txt");

            frmAcesso acesso = new frmAcesso();
            acesso.MdiParent = this;
            acesso.Show();
        }
    }
}
