//****************************************************************************************
//**Criado por: Amanda, André e Giovanna 
//**Data de Criação: 20/07/2021
//**Instruções:
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
    public partial class frmTipoVisitante : Form
    {
        public frmTipoVisitante()
        {
            InitializeComponent();
        }

        dbTipoVisitante dbTipoVisitante = new dbTipoVisitante();
        classeTipoVisitante tipoVisitante = new classeTipoVisitante();
        bool comando;

        private void formataGrid()
        {
            grdDescricao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDescricao.RowHeadersVisible = false;
            grdDescricao.Columns[0].HeaderText = "Código";
            grdDescricao.Columns[1].HeaderText = "Descrição";

            grdDescricao.Columns[0].Width = 0;
            grdDescricao.Columns[1].Width = 120;
        }

        public void atualizaDadosGrid()
        {
            grdDescricao.DataSource = dbTipoVisitante.SelectTipoVisitanteDBaseGrid();
        }

        private void atualizaDadosControles()
        {
            tipoVisitante = dbTipoVisitante.SelectTipoVisitanteDBase(tipoVisitante);
            txtDescricao.Text = tipoVisitante.visitanteDescricao;
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
            txtDescricao.Enabled = habilitar;
            grdDescricao.Enabled = !habilitar;
        }
        private void limpaCamposDados()
        {
            txtDescricao.Text = "";
            tipoVisitante.visitanteDescricao = "";
            tipoVisitante.tipoVisitanteId = -1;
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtDescricao.Text.Length == 0)
            {
                resultado = false;
            }

            return resultado;
        }

        private void insereTipoVisitante()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnNovo.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Inclusão de Tipos de Visitantes", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void alteraTipoVisitante()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnEditar.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Alteração de Tipos de Visitantes", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void excluiTipoVisitante()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnExcluir.Tag)) == true)
            {
                if (tipoVisitante.tipoVisitanteId != 0)
                {
                    DialogResult retorno = MessageBox.Show("Deseja excluir os dados informados? ", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (retorno == DialogResult.Yes)
                    {
                        dbTipoVisitante.ExcluiTipoVisitanteBase(tipoVisitante);
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
                MessageBox.Show("Usuário não tem permissão para realizar a Exclusão de Tipos de Visitantes", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salvaTipoVisitante()
        {
            if (verificaDadosObrigatorios() == true)
            {
                if (comando == true)
                {
                    tipoVisitante.visitanteDescricao = txtDescricao.Text;
                    dbTipoVisitante.InsereTipoVisitanteBase(tipoVisitante);
                }
                else if (comando == false)
                {
                    tipoVisitante.visitanteDescricao = txtDescricao.Text;
                    dbTipoVisitante.AlteraTipoVisitanteBase(tipoVisitante);
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

        private void cancelaTipoVisitante()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização de Tipos de Usuário?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }

        private void fechaTipoVisitante()
        {
            this.Close();
        }

        private void frmTipoVisitante_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            insereTipoVisitante();
            comando = true;
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraTipoVisitante();
            comando = false;
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiTipoVisitante();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaTipoVisitante();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaTipoVisitante();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaTipoVisitante();
        }

        private void selectTipoVisitanteDBase()
        {
            grdDescricao.DataSource = dbTipoVisitante.SelectTipoVisitanteDBaseGrid();
        }

        private void barbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void selectTipoVisitanteDBase(classeTipoVisitante tipoVisitante)
        {
            tipoVisitante = dbTipoVisitante.SelectTipoVisitanteDBase(tipoVisitante);
            txtDescricao.Text = tipoVisitante.visitanteDescricao;
        }

        private void grdDescricao_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tipoVisitante.tipoVisitanteId = Convert.ToInt16(grdDescricao.Rows[grdDescricao.CurrentRow.Index].Cells[0].Value.ToString());
            selectTipoVisitanteDBase(tipoVisitante);
            atualizaDadosControles();
        }
    }
}
