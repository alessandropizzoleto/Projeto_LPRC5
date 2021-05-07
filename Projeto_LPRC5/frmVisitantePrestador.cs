//****************************************************************************************
//**Criado por:André , Amanda e Giovanna
//**Data de Criação: 01/05/2021
//**Instruções: Criação do formulário Visitiante/Prestador
// Será alterado após a criação da conexão
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************

//TODO: Validar os atributos da classe e alterar as conexões do formulário.
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
    public partial class frmVisitantePrestador : Form
    {
        public frmVisitantePrestador()
        {
            InitializeComponent();
        }


        dbTipoUsuario dbtipoUsu = new dbTipoUsuario();
        classeTipoUsuario tipoUsuario = new classeTipoUsuario();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosVisitante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosVisitante.Columns[0].HeaderText = "Código";
            grdDadosVisitante.Columns[1].HeaderText = "Descrição";

            grdDadosVisitante.Columns[0].Width = 0;
            grdDadosVisitante.Columns[1].Width = 120;

        }

        private void selectUsuarioDBase()
        {
            grdDadosVisitante.DataSource = dbtipoUsu.selectTipoUsuarioDBaseGrid();
        }


        public void atualizaDadosGrid()
        {
            //DataTable tabelaCidade = new DataTable();
            //tabelaCidade = dbCidade.selectCiddBase();
            //grdDadosCid.DataSource = tabelaCidade;

            //pode ser também

            grdDadosVisitante.DataSource = dbtipoUsu.selectTipoUsuarioDBaseGrid();
        }

        private void atualizaDadosControles()
        {

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
            txtNomeVisitante.Enabled = habilitar;
            grdDadosVisitante.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtNomeVisitante.Text = "";
            tipoUsuario.setId(0);
            tipoUsuario.setDescricao("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtNomeVisitante.Text.Length == 0)
            {
                resultado = false;
            }


            return resultado;
        }

        private void insereTipoUsuario()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraTipoUsuario()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiTipoUsuario()
        {
            if (tipoUsuario.getId() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    dbtipoUsu.excluiTipoUsuario(tipoUsuario);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaTipoUsuario()
        {
            if (verificaDadosObrigatorios() == true)
            {
                //Atualizando os dados do objeto estado.
                //padrao.setNome(txtNome.Text);

                if (tipoUsuario.getId() == 0)
                {
                    //Insere os dados
                    tipoUsuario.setDescricao(txtNomeVisitante.Text);
                    dbtipoUsu.insereTipoUsuario(tipoUsuario);
                }
                else
                {
                    //Altera os dados
                    tipoUsuario.setDescricao(txtNomeVisitante.Text);
                    dbtipoUsu.alteraTipoUsuario(tipoUsuario);
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

        private void cancelaTipoUsuario()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Default?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaTipoUsuario()
        {
            this.Close();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereTipoUsuario();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraTipoUsuario();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaTipoUsuario();
        }

        private void frmVisitantePrestador_Load(object sender, EventArgs e)
        {
            dbtipoUsu.selectTipoUsuarioDBase();
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiTipoUsuario();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaTipoUsuario();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaTipoUsuario();
        }

        private void grdDadosVisitante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoUsuario.setId(Convert.ToInt16(grdDadosVisitante.Rows[grdDadosVisitante.CurrentRow.Index].Cells[0].Value.ToString()));
            selectTipoUsuarioDBase(tipoUsuario);
            atualizaDadosControles();
        }

        private void selectTipoUsuarioDBase(classeTipoUsuario tUsuario)
        {
            tipoUsuario = dbtipoUsu.selectTipoUsuarioDBase(tipoUsuario);

            txtNomeVisitante.Text = tipoUsuario.getDescricao();
        }

    }
}
