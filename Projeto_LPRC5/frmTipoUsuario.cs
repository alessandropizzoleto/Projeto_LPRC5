//****************************************************************************************
//**Criado por: André Luiz Costa
//**Data de Criação: 19/04/2021
//**Instruções: Criação do formulário 'Tipo de Usuário'
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
    public partial class frmTipoUsuario : Form
    {
        public frmTipoUsuario()
        {
            InitializeComponent();
        }

        dbTipoUsuario dbtipoUsu = new dbTipoUsuario(); //Alterar o nome
        tipoUsuario usuario = new tipoUsuario();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosCid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCid.Columns[0].HeaderText = "Código";
            grdDadosCid.Columns[1].HeaderText = "Descrição";

            grdDadosCid.Columns[0].Width = 0;
            grdDadosCid.Columns[1].Width = 120;

        }

        private void selectUsuarioDBase()
        {
            grdDadosCid.DataSource = dbtipoUsu.selectTipoUsuarioDBaseGrid();
        }

             

            public void atualizaDadosGrid()
        {
            //DataTable tabelaCidade = new DataTable();
            //tabelaCidade = dbCidade.selectCiddBase();
            //grdDadosCid.DataSource = tabelaCidade;

            //pode ser também

            grdDadosCid.DataSource = dbtipoUsu.selectTipoUsuarioDBaseGrid();
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
            txtDescricaoTipo.Enabled = habilitar;
            grdDadosCid.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtDescricaoTipo.Text = "";
            txtIdTipo.Text = "";

            usuario.setId(0); //REVER
            //padrao.setNome("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtDescricaoTipo.Text.Length == 0)
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
            if (usuario.getId() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    dbtipoUsu.excluiTipoUsuario(usuario);

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

                if (usuario.getId() == 0)
                {
                    //Insere os dados
                    usuario.setDescricao(txtDescricaoTipo.Text);
                    dbtipoUsu.insereTipoUsuario(usuario);
                }
                else
                {
                    //Altera os dados
                    usuario.setDescricao(txtDescricaoTipo.Text);
                    dbtipoUsu.alteraTipoUsuario(usuario);
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

        private void frmTipoUsuario_Load(object sender, EventArgs e)
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

        private void grdDadosCid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario.setId(Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString()));
            selectTipoUsuarioDBase(usuario);
            atualizaDadosControles();
        }

        private void selectTipoUsuarioDBase(tipoUsuario tUsuario)
        {
            usuario = dbtipoUsu.selectTipoUsuarioDBase(usuario);

            txtDescricaoTipo.Text = usuario.getDescricao();
        }
    }
}
