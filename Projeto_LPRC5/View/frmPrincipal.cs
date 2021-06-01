//****************************************************************************************

//**Criado por:
//**Data de Criação:
//**Instruções
// 
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: verificacao de usuario nas manutencoes de veiculo modelo, moradores, feriados e encomendas
//*** Data: 03/05/2021
//*** Responsável: Guilherme de Andrade Rissato

//****************************************************************************************
using Projeto_LPRC5;

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
            util.usuarioAtual = -1;
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
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(veiculomodelo.Tag), 0) == true)
            {
                veiculomodelo.MdiParent = this;
                veiculomodelo.Show();

            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Veículo Modelo", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade cidade = new frmCidade();
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(cidade.Tag), 0) == true)
            {
                cidade.MdiParent = this;
                cidade.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Cidade", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void moradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoradores moradores = new frmMoradores();
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(moradores.Tag), 0) == true)
            {
                moradores.MdiParent = this;
                moradores.Show();
            }
            else 
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Moradores", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void feriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeriado feriado = new frmFeriado();
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(feriado.Tag), 0) == true)
            {
                feriado.MdiParent = this;
                feriado.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Feriados", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnuEncomendas_Click(object sender, EventArgs e)
        {
            frmEncomendas encomendas = new frmEncomendas();
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(encomendas.Tag), 0) == true)
            {
                encomendas.MdiParent = this;
                encomendas.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Encomendas", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void PermissoesDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermissaoAcesso permissao = new frmPermissaoAcesso();
            permissao.MdiParent = this;
            permissao.Show();
        }
    }
}
