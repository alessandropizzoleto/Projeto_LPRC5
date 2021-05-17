//****************************************************************************************
//**Criado por:
//**Data de Criação:
//**Instruções:
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

namespace Projeto_LPRC5
{
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        dbMarca db_Marca = new dbMarca();
        classeMarca CadastroMarca = new classeMarca();

        private void formataGrid()
        {
            grdDadosMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosMarca.Columns[0].HeaderText = "Código";
            grdDadosMarca.Columns[1].HeaderText = "Nome";
            
            grdDadosMarca.Columns[0].Width = 0;
            grdDadosMarca.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid()
        {
            grdDadosMarca.DataSource = db_Marca.selectMarcaBase();
        }

        private void atualizaDadosControles()
        {
            CadastroMarca = db_Marca.RetornaDadosObjeto(CadastroMarca);

            txtMarca.Text = CadastroMarca.getmarcaveiculonome();

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
            txtMarca.Enabled = habilitar;
            grdDadosMarca.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtMarca.Text = "";

            CadastroMarca.setmarcaveiculoid(0);
            CadastroMarca.setmarcaveiculonome("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;
            if (txtMarca.Text.Trim().Length < 2)
            {
                resultado = false;
            }
            return resultado;
        }

        private void insereMarca()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraMarca()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiMarca()
        {
            if (CadastroMarca.getmarcaveiculoid() != 0)
            {
                DialogResult retorno = MessageBox.Show("Realmente deseja excluir esta informação ?", "AVISO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_Marca.excluiMarcaBase(CadastroMarca);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há nenhuma informação a ser excluida!!", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaMarca()
        {
            if (verificaDadosObrigatorios() == true)
            {
                CadastroMarca.setmarcaveiculonome(txtMarca.Text);

                if (CadastroMarca.getmarcaveiculoid() == 0)
                {

                    CadastroMarca.setmarcaveiculonome(txtMarca.Text);
                    db_Marca.insereMarcaBase(CadastroMarca);
                }
                else
                {

                    CadastroMarca.setmarcaveiculonome(txtMarca.Text);
                    db_Marca.alteraMarcaBase(CadastroMarca);
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

        private void cancelaMarca()
        {
            DialogResult retorno = MessageBox.Show("Realmente deseja cancelar o Cadastro/Atualização da Marca?", "AVISO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaMarca()
        {
            this.Close();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereMarca();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraMarca();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiMarca();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaMarca();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaMarca();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaMarca();
        }

        private void grdDadosMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void barbtnNovo_Click_1(object sender, EventArgs e)
        {

        }

        private void grdDadosMarca_Click(object sender, EventArgs e)
        {
            CadastroMarca.setmarcaveiculoid(Convert.ToInt16(grdDadosMarca.Rows[grdDadosMarca.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }
    }
}