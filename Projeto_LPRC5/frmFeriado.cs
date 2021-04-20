//****************************************************************************************
//**Criado por: Matues Siste
//**Data de Criação: 20/04/2021
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

namespace Projeto_LPRC5
{
    public partial class frmFeriado : Form
    {
        public frmFeriado()
        {
            InitializeComponent();
        }

        bdFeriado db_Feriado = new bdFeriado();
        ClasseFeriado feriado = new ClasseFeriado();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosCid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCid.Columns[0].HeaderText = "Código";
            grdDadosCid.Columns[1].HeaderText = "Nome";

            grdDadosCid.Columns[0].Width = 0;
            grdDadosCid.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid()
        {
            //DataTable tabelaCidade = new DataTable();
            //tabelaCidade = dbCidade.selectCiddBase();
            //grdDadosCid.DataSource = tabelaCidade;

            //pode ser também

            grdDadosCid.DataSource = db_Feriado.selectFeriadoBase();
        }

        private void atualizaDadosControles()
        {
            feriado = db_Feriado.RetornaDadosObjeto(feriado);

            //txtNome.Text = cidade.getNome();
        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            barbtnNovo.Enabled = hablitar;
            barbtnEditar.Enabled = hablitar;
            barbtnExcluir.Enabled = hablitar;
            barbtnSalvar.Enabled = !hablitar;
            barbtnCancelar.Enabled = !hablitar;
            barbtnFechar.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar)
        {
            //txtNome.Enabled = habilitar;
            grdDadosCid.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            //txtNome.Text = "";

            feriado.Id= 0;
            //feriado.setNome("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            //if (txtNome.Text.Trim().Length < 4)
            //{
            //    resultado = false;
            //}


            return resultado;
        }

        private void insereFeriado()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraFeriado()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiFeriado()
        {
            if (feriado.Id != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_Feriado.excluiFeriadoBase(feriado);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaFeriado()
        {
            if (verificaDadosObrigatorios() == true)
            {
                //Atualizando os dados do objeto estado.
                //feriado.setNome(txtNome.Text);

                if (feriado.Id == 0)
                {
                    //Insere os dados
                    db_Feriado.insereFeriadoBase(feriado);
                }
                else
                {
                    //Altera os dados
                    db_Feriado.alteraFeriadoBase(feriado);
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

        private void cancelaFeriado()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Feriado?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaFeriado()
        {
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void frmCid_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereFeriado();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraFeriado();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiFeriado();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaFeriado();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaFeriado();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaFeriado();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            feriado.Id = Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString());
            atualizaDadosControles();
        }

        private void frmFeriado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
