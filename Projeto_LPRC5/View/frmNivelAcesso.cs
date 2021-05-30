//****************************************************************************************
//**Criado por: Antonio Naranjo  e Rafael Fogaça
//**Data de Criação: 30/05/2021
//**Instruções: Criação de formulário
//****************************************************************************************

using Projeto_LPRC5.Model.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_LPRC5.View {
    public partial class frmNivelAcesso : Form
    {
        public frmNivelAcesso()
        {
            InitializeComponent();
        }

        dbNivelAcesso db_NivelAcesso = new dbNivelAcesso();
        classeNivelAcesso classeNivelAcesso = new classeNivelAcesso();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosCid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCid.Columns[0].HeaderText = "Código";
            grdDadosCid.Columns[1].HeaderText = "Nome";

            grdDadosCid.Columns[0].Width = 0;
            grdDadosCid.Columns[1].Width = 120;

        }
        private void limpaCamposDados()
        {
            txtAcesso.Text = "";
            classeNivelAcesso.Id = -1;
        }

        private bool verificaDadosnotnull()
        {
            bool resultado = true;
            // habilitacao da verificao
            if (txtAcesso.Text.Trim().Length < 2)
            {
                resultado = false;
            }

            return resultado;
        }

        private void atualizaDadosControles()
        {
            //verificação se o objeto nao é nulo
            classeNivelAcesso = db_NivelAcesso.RetornaDadosObjeto(classeNivelAcesso);

            txtAcesso.Text = classeNivelAcesso.Descricao;
        }


        private void excluiNivelAcesso()
        {
            if (classeNivelAcesso.Id != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_NivelAcesso.excluiNivelAcessoBase(classeNivelAcesso);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void salvaNivelAcesso()
        {
            if (verificaDadosnotnull() == true)
            {
                //Atualizando os dados do objeto cidade.
                classeNivelAcesso.Descricao = txtAcesso.Text;

                if (classeNivelAcesso.Id == -1)
                {
                    //Insere os dados
                    //alimentacao da classe objeto com a informacao do txtCidade para ser enviado ao banco de dados
                    classeNivelAcesso.Descricao = txtAcesso.Text;
                    db_NivelAcesso.insereNivelAcessoBase(classeNivelAcesso);
                }
                else
                {
                    //Altera os dados
                    //alimentacao da classe objeto com a informacao do txtCidade para ser enviado ao banco de dados
                    classeNivelAcesso.Descricao = txtAcesso.Text;
                    db_NivelAcesso.alteraNivelAcessoBase(classeNivelAcesso);
                }
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
        public void atualizaDadosGrid()
        {
            grdDadosCid.DataSource = db_NivelAcesso.selectNivelAcessoBase();
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
        private void alteraNivelAcesso()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void habilitaCamposDados(bool habilitar)
        {
            //habilitação do campo txtCidade e o grd no form
            txtAcesso.Enabled = habilitar;
            grdDadosCid.Enabled = !habilitar;
        }



        private void cancelaAcesso()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização do Acesso?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaAcesso()
        {
            this.Close();
        }

        private void frmNivelAcesso_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void grdDadosCid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insereNivelAcesso()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            insereNivelAcesso();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            alteraNivelAcesso();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluiNivelAcesso();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvaNivelAcesso();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaAcesso();
        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechaAcesso();
        }
        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classeNivelAcesso.Id=(Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }
    }
}

