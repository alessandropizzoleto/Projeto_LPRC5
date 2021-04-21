//****************************************************************************************
//**Criado por: Guilherme, Alexandro, Caique
//**Data de Criação: 20/04/2021
//**Instruções: Formulário CRUD Cor.
//
//
//****** Atualizações: Formulário criado
//*** Data:20/04/2021
//*** Responsável:Guilherme Beig
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
    public partial class frmCor : Form
    {
        public frmCor()
        {
            InitializeComponent();
        }
        dbCor db_Cor = new dbCor();
        classeCor tinta = new classeCor();

        private void formataGrid()
        {
           grdDadosCor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCor.Columns[0].HeaderText = "Código";
            grdDadosCor.Columns[1].HeaderText = "Nome";

            grdDadosCor.Columns[0].Width = 0;
            grdDadosCor.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid()
        {
            

            grdDadosCor.DataSource = db_Cor.selectCorBase();
        }
 
        private void atualizaDadosControles()
        {
            tinta = db_Cor.RetornaDadosObjeto(tinta);

            
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
         
            grdDadosCor.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
           

            tinta.setCorId(0);
            
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            


            return resultado;
        }
        private void insereCor()
        {
            //     habilitaBotoesMenu(false);
            //     habilitaCamposDados(true);
            //     limpaCamposDados();

            classeCor CorTemp = new classeCor();
            CorTemp.setCorNome(txtBuscaCor.Text);
            db_Cor.insereCorBase(CorTemp);
           
        }

        private void alteraCor()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiCor()
        {
            if (tinta.getCorId() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir os dados informados? ", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_Cor.excluiCorBase(tinta);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível excluir", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaCor()
        {
            if (verificaDadosObrigatorios() == true)
            {
                

                if (tinta.getCorId() == 0)
                {
                  
                    db_Cor.insereCorBase(tinta);
                }
                else
                {
                    
                    db_Cor.alteraCorBase(tinta);
                }
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                atualizaDadosGrid();
            }
            else
            {
                MessageBox.Show("Insira todos os dados obrigatórios nos campos mostrados. ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelaCor()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Cor?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaCor()
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
            insereCor();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraCor();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiCor();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaCor();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaCor();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaCor();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tinta.setCorId(Convert.ToInt16(grdDadosCor.Rows[grdDadosCor.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }

        private void grdDadosCid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fmrCor_Load(object sender, EventArgs e)
        {

        }

        private void barbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
