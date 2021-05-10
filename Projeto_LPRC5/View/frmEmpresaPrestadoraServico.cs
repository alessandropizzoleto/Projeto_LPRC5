//****************************************************************************************
//**Criado por: Mateus Siste
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

namespace Projeto_LPRC5
{
    public partial class frmEmpresaPrestadoraServico : Form
    {
        public frmEmpresaPrestadoraServico()
        {
            InitializeComponent();
        }

        //dbEmpresaPrestadoraServico db_EmpresaPrestadoraServico = new dbEmpresaPrestadoraServico();
        ClasseEmpresaPrestadoraServico padrao = new ClasseEmpresaPrestadoraServico();

        bool comando;
        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosEmpresaPrestadoraServico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosEmpresaPrestadoraServico.Columns[0].HeaderText = "Empresa";
            grdDadosEmpresaPrestadoraServico.Columns[1].HeaderText = "Telefone";
            grdDadosEmpresaPrestadoraServico.Columns[3].HeaderText = "Tipo de Serviço";
            grdDadosEmpresaPrestadoraServico.Columns[4].HeaderText = "Endereço";
            grdDadosEmpresaPrestadoraServico.Columns[5].HeaderText = "Descrição";

            grdDadosEmpresaPrestadoraServico.Columns[0].Width = 0;
            grdDadosEmpresaPrestadoraServico.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid()
        {
            //DataTable tabelaEmpresaPrestadoraServicoade = new DataTable();
            //tabelaEmpresaPrestadoraServicoade = dbEmpresaPrestadoraServicoade.selectEmpresaPrestadoraServicodBase();
            //grdDadosEmpresaPrestadoraServico.DataSource = tabelaEmpresaPrestadoraServicoade;

            //pode ser também

           // grdDadosEmpresaPrestadoraServico.DataSource = db_EmpresaPrestadoraServico.selectEmpresaPrestadoraServicoBase();
        }

        private void atualizaDadosControles()
        {
            //EmpresaPrestadoraServico = db_EmpresaPrestadoraServico.RetornaDadosObjeto(EmpresaPrestadoraServico);


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
            txtDescricaoEmpresa.Enabled = habilitar;
            txtDescricaoTelefone.Enabled = habilitar;
            txtDescricaoServico.Enabled = habilitar;
            txtDescricaoEndereco.Enabled = habilitar;
            txtDescricaoDescricao.Enabled = habilitar;

            grdDadosEmpresaPrestadoraServico.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtDescricaoEmpresa.Text = "";
            txtDescricaoTelefone.Text = "";
            txtDescricaoServico.Text = "";
            txtDescricaoEndereco.Text = "";
            txtDescricaoDescricao.Text = "";
            // padrao.setEmpresaPrestadoraServicoId (-1);
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtDescricaoEmpresa.Text.Length == 0)
            {
                resultado = false;
            }
            if (txtDescricaoEmpresa.Text.Length == 0)
            {
                resultado = false;
            }
            if (txtDescricaoTelefone.Text.Length == 0)
            {
                resultado = false;
            }
            if (txtDescricaoEndereco.Text.Length == 0)
            {
                resultado = false;
            }
            if (txtDescricaoDescricao.Text.Length == 0)
            {
                resultado = false;
            }

            return resultado;

        }

        private void insereEmpresaPrestadoraServico()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraEmpresaPrestadoraServico()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

            private void excluiEmpresaPrestadoraServico()
            {
            // if (padrao.getEmpresaPrestadoraServicoId() != 0)
            //  {
            // DialogResult retorno = MessageBox.Show("Deseja excluir os dados informados? ", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if (retorno == DialogResult.Yes)
            // {
            //db_EmpresaPrestadoraServico.excluiEmpresaPrestadoraServicoBase(padrao);

            // limpaCamposDados();
            // atualizaDadosGrid();
            // }
            //  }
            //    else
            // {
            // MessageBox.Show("Não foi possível excluir", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void salvaEmpresaPrestadoraServico()
        {
            if (verificaDadosObrigatorios() == true)
            {
                if (comando == true)
                {
                    // padrao.setEmpresaPrestadoraServicoNome(txtDescricaoEmpresa.Text);
                    // padrao.setEmpresaPrestadoraServiconumero(Convert.ToInt32(txtDescricaoTelefone.Text));
                    // padrao.setEmpresaPrestadoraServicoservico(txtDescricaoServico.Text);
                    //  padrao.setEmpresaPrestadoraServicolocal(txtDescricaoEndereco.Text);
                    //  padrao.setEmpresaPrestadoraServicoDesc(txtDescricaoDescricao.Text);
                    //db_EmpresaPrestadoraServico.insereEmpresaPrestadoraServicoBase(padrao);
                }
                else if (comando == false)
                {
                    // padrao.setEmpresaPrestadoraServicoNome(txtDescricaoEmpresa.Text);
                    //  padrao.setEmpresaPrestadoraServiconumero(Convert.ToInt32(txtDescricaoTelefone.Text));
                    // padrao.setEmpresaPrestadoraServicoservico(txtDescricaoServico.Text);
                    //  padrao.setEmpresaPrestadoraServicolocal(txtDescricaoEndereco.Text);
                    //  padrao.setEmpresaPrestadoraServicoDesc(txtDescricaoDescricao.Text);
                    //db_EmpresaPrestadoraServico.alteraEmpresaPrestadoraServicoBase(padrao);
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

        private void cancelaEmpresaPrestadoraServico()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da EmpresaPrestadoraServico?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }
        private void fechaEmpresaPrestadoraServico()
        {
            this.Close();
        }


        private void frmEmpresaPrestadoraServico_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereEmpresaPrestadoraServico();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraEmpresaPrestadoraServico();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiEmpresaPrestadoraServico();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaEmpresaPrestadoraServico();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaEmpresaPrestadoraServico();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaEmpresaPrestadoraServico();
        }

    }
}