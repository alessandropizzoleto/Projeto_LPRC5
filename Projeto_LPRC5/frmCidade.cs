//****************************************************************************************
//**Criado por:
//**Data de Criação:
//**Instruções:
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
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
        classeCidade padrao = new classeCidade();

        private void formataGrid() {
            //Opção para selecionar a linha inteira do grid
            grdDadosCid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCid.Columns[0].HeaderText = "Código";
            grdDadosCid.Columns[1].HeaderText = "Nome";

            grdDadosCid.Columns[0].Width = 0;
            grdDadosCid.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid() {
            //DataTable tabelaCidade = new DataTable();
            //tabelaCidade = dbCidade.selectCiddBase();
            //grdDadosCid.DataSource = tabelaCidade;

            //pode ser também

            grdDadosCid.DataSource = db_Cidade.selectCidadeBase();
        }

        private void atualizaDadosControles() {
            padrao = db_Cidade.RetornaDadosObjeto(padrao);

            //txtNome.Text = cidade.getNome();
        }

        private void habilitaBotoesMenu(bool hablitar) {
            barbtnNovo.Enabled = hablitar;
            barbtnEditar.Enabled = hablitar;
            barbtnExcluir.Enabled = hablitar;
            barbtnSalvar.Enabled = !hablitar;
            barbtnCancelar.Enabled = !hablitar;
            barbtnFechar.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar) {
            //txtNome.Enabled = habilitar;
            grdDadosCid.Enabled = !habilitar;
        }

        private void limpaCamposDados() {
            //txtNome.Text = "";

            padrao.setCidadeId(0);
            //padrao.setNome("");
        }

        private bool verificaDadosObrigatorios() {
            bool resultado = true;

            //if (txtNome.Text.Trim().Length < 4)
            //{
            //    resultado = false;
            //}


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
            if (padrao.getCidadeId() != 0) {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes) {
                    db_Cidade.excluiCidadeBase(padrao);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            } else {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaCidade() {
            if (verificaDadosObrigatorios() == true) {
                //Atualizando os dados do objeto estado.
                //padrao.setNome(txtNome.Text);

                if (padrao.getCidadeId() == 0) {
                    //Insere os dados
                    db_Cidade.insereCidadeBase(padrao);
                } else {
                    //Altera os dados
                    db_Cidade.alteraCidadeBase(padrao);
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

        private void lblNome_Click(object sender, EventArgs e) {

        }

        private void frmCid_Load(object sender, EventArgs e) {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnNovo_Click(object sender, EventArgs e) {
            insereCidade();
        }

        private void barbtnEditar_Click(object sender, EventArgs e) {
            alteraCidade();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e) {
            excluiCidade();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e) {
            salvaCidade();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e) {
            cancelaCidade();
        }

        private void barbtnFechar_Click(object sender, EventArgs e) {
            fechaCidade();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e) {
            padrao.setCidadeId(Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }
    }
}
