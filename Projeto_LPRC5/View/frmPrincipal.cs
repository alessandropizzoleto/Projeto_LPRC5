using Projeto_LPRC5.Grupo_6.Moradores;

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
            frmCor Cor = new frmCor();
            Cor.MdiParent = this;
            Cor.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.MdiParent = this;
            marca.Show();
        }

		private void estadoToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmEstado {
                MdiParent = this
            }.Show();
		}

        private void veículoModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculoModelo veiculomodelo = new frmVeiculoModelo();
            veiculomodelo.MdiParent = this;
            veiculomodelo.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade cidade = new frmCidade();
            cidade.MdiParent = this;
            cidade.Show();
        }

        private void moradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoradores moradores = new frmMoradores();
            moradores.MdiParent = this;
            moradores.Show();
        }

        private void feriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeriado feriado = new frmFeriado();
            feriado.MdiParent = this;
            feriado.Show();
        }

        private void mnuEncomendas_Click(object sender, EventArgs e)
        {
            frmEncomendas encomendas = new frmEncomendas();
            encomendas.MdiParent = this;
            encomendas.Show();
        }
    }
}
