//****************************************************************************************
//**Criado por: André Luiz Costa
//**Data de Criação: 19/04/2021
//**Instruções: Criação do formulário 'Tipo de Usuário'
//
//
//****** Atualizações: Alteração no setId do Tipo Usuário e criacação da variável comando para distinguir inserts de updates.
//*** Data: 01/05/2021
//*** Responsável: Giovanna Valim Frederico
//****************************************************************************************
//****** Atualizações: Alteração em salvaTipoUsuario() e atualizaDadosControles()
//*** Data: 07/05/2021
//*** Responsável: André Luiz Costa
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

        dbTipoUsuario dbtipoUsu = new dbTipoUsuario(); 
        classeTipoUsuario tipoUsuario = new classeTipoUsuario();
        bool comando;

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
            grdDadosCid.DataSource = dbtipoUsu.selectTipoUsuarioDBaseGrid();
        }

        private void atualizaDadosControles()
        {
            txtDescricaoTipo.Text = tipoUsuario.getDescricao();
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
            tipoUsuario.setId(-1);
            tipoUsuario.setDescricao("");
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
                //Atualizando os dados do objeto

                if (comando == true)
                {
                    //Insere os dados
                    tipoUsuario.setDescricao(txtDescricaoTipo.Text);
                    dbtipoUsu.insereTipoUsuario(tipoUsuario);
                }
                else if(comando == false)
                {
                    //Altera os dados
                    tipoUsuario.setDescricao(txtDescricaoTipo.Text);
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
            comando = true;
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraTipoUsuario();
            comando = false;
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
            tipoUsuario.setId(Convert.ToInt16(grdDadosCid.Rows[grdDadosCid.CurrentRow.Index].Cells[0].Value.ToString()));
            selectTipoUsuarioDBase(tipoUsuario);
            atualizaDadosControles();
        }

        private void selectTipoUsuarioDBase(classeTipoUsuario tUsuario)
        {
            tipoUsuario = dbtipoUsu.selectTipoUsuarioDBase(tipoUsuario);

            txtDescricaoTipo.Text = tipoUsuario.getDescricao();
        }
    }
}
