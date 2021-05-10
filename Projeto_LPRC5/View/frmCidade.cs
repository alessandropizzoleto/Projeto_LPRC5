//****************************************************************************************
//**Criado por: Geanluca Sampaio de Sousa, Thomas Taino, Aldemir Humberto Soares Neto, Felipe Lopes Silva e Silva
//**Data de Criação: 19/04/2021
//**Instruções: Criação de formulário
//
//
//****** Atualizações:mudança do nome da variavel da instancia da classeCidade, verificação se o objeto não é nulo para fazer a requisição no BD 
//*** Data:02/05/2021
//*** Responsável:Guilherme de Andrade Rissato
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LPRC5 {
    public partial class frmCidade : Form {
        public frmCidade() {
            InitializeComponent();
        }

        dbCidade db_Cidade = new dbCidade();
        classeCidade classeCidade = new classeCidade();

        private void formataGrid() {
            //Opção para selecionar a linha inteira do grid
            grdDadosCid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCid.Columns[0].HeaderText = "Código";
            grdDadosCid.Columns[1].HeaderText = "Nome";

            grdDadosCid.Columns[0].Width = 0;
            grdDadosCid.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid() {
           grdDadosCid.DataSource = db_Cidade.selectCidadeBase();
        }

        private void atualizaDadosControles() {
            //verificação se o objeto nao é nulo
            classeCidade = db_Cidade.RetornaDadosObjeto(classeCidade);
            
            txtCidade.Text = classeCidade.getCidadeNome();
        }

        private void habilitaBotoesMenu(bool hablitar) {
            btnNovo.Enabled = hablitar;
            btnEditar.Enabled = hablitar;
            btnExcluir.Enabled = hablitar;
            btnSalvar.Enabled = !hablitar;
            btnCancelar.Enabled = !hablitar;
            btnSair.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar) {
            //habilitação do campo txtCidade e o grd no form
            txtBusca.Enabled = !habilitar;
            txtCidade.Enabled = habilitar;
            grdDadosCid.Enabled = !habilitar;
        }

        private void limpaCamposDados() {
            txtCidade.Text = "";
            classeCidade.setCidadeId(-1);
        }

        private bool verificaDadosObrigatorios() {
            bool resultado = true;
            // habilitacao da verificao
            if (txtCidade.Text.Trim().Length < 2)
            {
                resultado = false;
            }


            return resultado;
        }

        private void insereCidade() {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraCidade() {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiCidade() {
            if (classeCidade.getCidadeId() != 0) {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes) {
                    db_Cidade.excluiCidadeBase(classeCidade);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            } else {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaCidade() {
            if (verificaDadosObrigatorios() == true) {
                //Atualizando os dados do objeto cidade.
                classeCidade.setCidadeNome(txtCidade.Text);

                if (classeCidade.getCidadeId() == -1) {
                    //Insere os dados
                    //alimentacao da classe objeto com a informacao do txtCidade para ser enviado ao banco de dados
                    classeCidade.setCidadeNome(txtCidade.Text);
                    db_Cidade.insereCidadeBase(classeCidade);
                } else {
                    //Altera os dados
                    //alimentacao da classe objeto com a informacao do txtCidade para ser enviado ao banco de dados
                    classeCidade.setCidadeNome(txtCidade.Text);
                    db_Cidade.alteraCidadeBase(classeCidade);
                }
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                atualizaDadosGrid();
            } else {
                MessageBox.Show("Dados Obrigatórios não informados ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaCidade() {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Cidade?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes) {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaCidade() {
            this.Close();
        }

        private void frmCid_Load(object sender, EventArgs e) {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            insereCidade();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            alteraCidade();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluiCidade();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvaCidade();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaCidade();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechaCidade();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void grdDadosCid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classeCidade.setCidadeId(Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }

        
    }
}
