//****************************************************************************************
//**Criado por:
//**Data de Criação:
//**Instruções
// 
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: verificacao de usuario nas manutencoes de veiculo modelo, moradores, feriados e encomendas
//*** Data: 01/06/2021
//*** Responsável: Guilherme de Andrade Rissato

//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: verificacao de usuario nas manutencoes de tipo de usuario, classificacao de pessoas, cor, marca e estado
//*** Data: 01/06/2021
//*** Responsável: Roberto Marcheti Neto

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
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(tipoUsuario.Tag), 0) == true)
            { 
                tipoUsuario.MdiParent = this;
                tipoUsuario.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Tipo de Usuário", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void mnuClassificaPessoa_Click(object sender, EventArgs e)
        {
            frmClassificaPessoa classificaPessoa = new frmClassificaPessoa();
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(classificaPessoa.Tag), 0) == true)
            {
                classificaPessoa.MdiParent = this;
                classificaPessoa.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Classificação de Pessoas", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(Cor.Tag), 0) == true)
            { 
                Cor.MdiParent = this;
                Cor.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Cor", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(marca.Tag), 0) == true)
            { 
                marca.MdiParent = this;
                marca.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Marca", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstado estado = new FrmEstado();
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(estado.Tag), 0) == true)
            {
              estado.MdiParent = this;
              estado.Show();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Estado", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBox.Show("Usuário não tem permissão para realizar Manutenção em Feriado", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void condomínioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa empresa = new frmEmpresa();
            empresa.MdiParent = this;
            empresa.Show();
        }
    }
}
