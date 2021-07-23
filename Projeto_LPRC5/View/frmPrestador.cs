//****************************************************************************************
//**Criado por: Amanda Iaquinta, André Costa e Giovanna Frederico 
//**Data de Criação: 20/07/2021
//**Instruções:
//****************************************************************************************
using Projeto_LPRC5.Model.Classe;
using Projeto_LPRC5.Model.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPRC5.View
{
    public partial class frmPrestador : Form
    {
        public frmPrestador()
        {
            InitializeComponent();
        }

        dbPrestador db_Prestador = new dbPrestador();
        classePrestador ClassePrestador = new classePrestador();

        private void formataGrid()
        {

            grdPrestador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            grdPrestador.Columns[0].HeaderText = "Id Visita";
            grdPrestador.Columns[1].HeaderText = "Data Visita";
            grdPrestador.Columns[2].HeaderText = "Id P. Jurídica";
            grdPrestador.Columns[3].HeaderText = "Descrição";

            grdPrestador.Columns[0].Width = 100;
            grdPrestador.Columns[1].Width = 100;
            grdPrestador.Columns[2].Width = 100;
            grdPrestador.Columns[3].Width = 100;
        }

        public void atualizaDadosGrid()
        {
            grdPrestador.DataSource = db_Prestador.selectPrestador();
        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            btnNovo.Enabled = hablitar;
            btnEditar.Enabled = hablitar;
            btnExcluir.Enabled = hablitar;
            btnSalvar.Enabled = !hablitar;
            btnCancelar.Enabled = !hablitar;
            btnSair.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar)
        {
            txtNomeRegistro.Enabled = habilitar;
            txtNomeSocial.Enabled = habilitar;
            txtEmail.Enabled = habilitar;
            txtCNPJ.Enabled = habilitar;
            txtInscEstadual.Enabled = habilitar;
            txtInsMunicipal.Enabled = habilitar;
            txtDescricao.Enabled = habilitar;
            grdPrestador.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtNomeRegistro.Text = "";
            txtNomeSocial.Text = "";
            txtEmail.Text = "";
            txtCNPJ.Text = "";
            txtInscEstadual.Text = "";
            txtInsMunicipal.Text = "";
            txtDescricao.Text = "";
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtNomeRegistro.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtNomeSocial.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtEmail.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtCNPJ.Text.Length < 18)
            {
                resultado = false;
            }
            else if (txtInscEstadual.Text.Length < 15)
            {
                resultado = false;
            }
            else if (txtInsMunicipal.Text.Length < 10)
            {
                resultado = false;
            }
            else if (txtDescricao.Text.Length == 0)
            {
                resultado = false;
            }

            return resultado;
        }

        private void inseriPrestador()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(btnNovo.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Inclusão de Prestadores", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void alteraPrestador()
        {
            MessageBox.Show("Não é possível alterar dados de visitas de prestadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void excluiPrestador()
        {
            MessageBox.Show("Não é possível excluir visitas de prestadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void salvaPrestador()
        {
            if (verificaDadosObrigatorios() == true)
            {
                ClassePrestador.setPessoaNomeRegistro(txtNomeRegistro.Text.ToString());
                ClassePrestador.setPessoaNomeSocial(txtNomeSocial.Text.ToString());
                ClassePrestador.setPessoaEmail(txtEmail.Text.ToString());
                ClassePrestador.setPJuridicaCNPJ(txtCNPJ.Text.ToString());
                ClassePrestador.setPJuridicaInscEstadual(txtInscEstadual.Text.ToString());
                ClassePrestador.setPJuridicaInscMunicipal(txtInsMunicipal.Text.ToString());
                ClassePrestador.servicodescricao = txtDescricao.Text;

                db_Prestador.inserePrestador(ClassePrestador);

                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                atualizaDadosGrid();
            }
            else
            {
                MessageBox.Show("Dados Obrigatórios não informados ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaPrestador()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro da visita?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                limpaCamposDados();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inseriPrestador();
        }

        private void frmPrestador_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            limpaCamposDados();
            atualizaDadosGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            alteraPrestador();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluiPrestador();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvaPrestador();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaPrestador();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
