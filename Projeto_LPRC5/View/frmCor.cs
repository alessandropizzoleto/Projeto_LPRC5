//****************************************************************************************
//**Criado por: Guilherme, Alexandro, Caique
//**Data de Criação: 20/04/2021
//**Instruções: Formulário CRUD Cor.
//
//
//****** Atualizações: Formulário criado
//*** Data:20/04/2021
//*** Responsável:Guilherme Beig

//****** Atualizações: Criação de novas funções para mostrar resultados no grid e usar as informações do grid para executar o update e delete.
//*** Data: 01/05/2021
//*** Responsável: Amanda Ferrari, André Costa, Giovanna Valim

//****** Atualizações: Criação do campo "Descrição cor" no form e adaptação do código.
//*** Data: 03/05/2021
//*** Responsável: Giovanna Valim

//****** Atualizações: Inserção da função para verificar o nível de permissão do usuário.
//*** Data: 06/06/2021
//*** Responsável: Amanda Ferrari, André Costa, Giovanna Valim
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
        bool comando;

        private void formataGrid()
        {
            grdDadosCor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDadosCor.RowHeadersVisible = false;
            grdDadosCor.Columns[0].HeaderText = "Código";
            grdDadosCor.Columns[1].HeaderText = "Nome";

            grdDadosCor.Columns[0].Width = 0;
            grdDadosCor.Columns[1].Width = 120;
            grdDadosCor.Columns[0].Visible = false;
            
        }

        public void atualizaDadosGrid()
        {
            grdDadosCor.DataSource = db_Cor.selectCorDBaseGrid();
        }
 
        private void atualizaDadosControles()
        {
            tinta = db_Cor.selectCorDBase(tinta);
            txtNomeCor.Text = tinta.getCorNome();
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
            txtNomeCor.Enabled = habilitar;
            grdDadosCor.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtNomeCor.Text = "";
            tinta.setCorNome("");
            tinta.setCorId(-1);
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtNomeCor.Text.Length == 0)
            {
                resultado = false;
            }

            return resultado;
        }
        private void insereCor()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnNovo.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Inclusão de Cidades", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void alteraCor()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnEditar.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Alteração de Cidades", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void excluiCor()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnExcluir.Tag)) == true)
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
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Exclusão de Cidades", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void salvaCor()
        {
            if (verificaDadosObrigatorios() == true)
            {
                if (comando == true)
                {
                    tinta.setCorNome(txtNomeCor.Text);
                    db_Cor.insereCorBase(tinta);
                }
                else if  (comando == false)
                {
                    tinta.setCorNome(txtNomeCor.Text);
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
            comando = true;
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraCor();
            comando = false;
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
            selectCorDBase(tinta);
            atualizaDadosControles();
        }

        private void grdDadosCid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void selectCorDBase(classeCor tinta)
        {
            tinta = db_Cor.selectCorDBase(tinta);
            txtNomeCor.Text = tinta.getCorNome();
        }

        private void selectCorDBase()
        {
            grdDadosCor.DataSource = db_Cor.selectCorDBaseGrid();
        }

        private void fmrCor_Load(object sender, EventArgs e)
        {
            db_Cor.selectCorDBase();
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
