//****************************************************************************************
//**Criado por: Giovanni Marques, Bruno Bragagnolo, Renan Vaz
//**Data de Criação: 02/05/2021
//**Instruções: Criação e configuração do formCadastroFuncionario".
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//*****************************************************************




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
    public partial class FrmCadastroFuncionarios : Form
    {
        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
        }



        //dbCadastroFuncionarios db_CadastroFuncionarios = new dbCadastroFuncionarios();
        classeCadastroFuncionarios CadastroFuncionarios = new classeCadastroFuncionarios();

        private void formataGrid()
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";

            dataGridView1.Columns[0].Width = 0;
            dataGridView1.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid()
        {



            //dataGridView1.DataSource = db_CadastroFuncionarios.selectCadastroFuncionariosBase();
        }

        private void atualizaDadosControles()
        {
            //CadastroFuncionarios = db_CadastroFuncionarios.RetornaDadosObjeto(CadastroFuncionarios);


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

            dataGridView1.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {


            //CadastroFuncionarios.Id = 0;

        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            return resultado;
        }

        private void insereCadastroFuncionarios()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraCadastroFuncionarios()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiCadastroFuncionarios()
        {
            if (0 != 0)  //if (CadastroFuncionarios.Id != 0)
            {
                DialogResult retorno = MessageBox.Show("A informação será excluida", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    //db_CadastroFuncionarios.excluiCadastroFuncionariosBase(CadastroFuncionarios);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há nada a ser excluido!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaCadastroFuncionarios()
        {
            if (verificaDadosObrigatorios() == true)
            {

                if (0 == 0)  //if (CadastroFuncionarios.Id == 0)
                {
                    //Insere os dados
                    //db_CadastroFuncionarios.insereCadastroFuncionariosBase(CadastroFuncionarios);
                }
                else
                {
                    //Altera os dados
                    //db_CadastroFuncionarios.alteraCadastroFuncionariosBase(CadastroFuncionarios);
                }
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                atualizaDadosGrid();
            }
            else
            {
                MessageBox.Show("Os dados obrigatórios não foram informados", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaCadastroFuncionarios()
        {
            DialogResult retorno = MessageBox.Show("Deseja realmente cancelar o Cadastro/Atualização dos dados do funcionário?", "AVISO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaCadastroFuncionarios()
        {
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroFuncionarios_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereCadastroFuncionarios();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraCadastroFuncionarios();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiCadastroFuncionarios();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaCadastroFuncionarios();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaCadastroFuncionarios();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaCadastroFuncionarios();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CadastroFuncionarios.Id = Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            atualizaDadosControles();

        }

        private void FrmCadastroFuncionarios_Load_1(object sender, EventArgs e)
        {

        }
    }
}