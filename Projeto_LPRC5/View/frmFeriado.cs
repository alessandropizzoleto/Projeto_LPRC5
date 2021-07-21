//****************************************************************************************
//**Criado por: Mateus Siste
//**Data de Criação: 20/04/2021
//**Instruções:
//
//
//****** Atualizações: Criação de novas funções e modificação das que não funcionavam alem de mostrar resultados no grid e capacidade usar as informações do grid para executar o update e delete.
//*** Data: 03/05/2021
//*** Responsável: Grupo 6
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
        classeFeriado feriado = new classeFeriado();
        bool comando;

        private void formataGrid()
        {
            
            grdDadosFe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDadosFe.RowHeadersVisible = false;
            grdDadosFe.Columns[0].HeaderText = "Código";
            grdDadosFe.Columns[1].HeaderText = "Nome";
            grdDadosFe.Columns[2].HeaderText = "Dia";
            grdDadosFe.Columns[3].HeaderText = "Mes";

            grdDadosFe.Columns[0].Width = 0;
            grdDadosFe.Columns[1].Width = 120;
            grdDadosFe.Columns[2].Width = 50;
            grdDadosFe.Columns[3].Width = 50;
            grdDadosFe.Columns[0].Visible = false;

        }

        public void atualizaDadosGrid()
        {
            grdDadosFe.DataSource = db_Feriado.selectFeriadoDBaseGrid();
        }

        private void atualizaDadosControles()
        {
            feriado = db_Feriado.selectFeriadoDBase(feriado);

            txtNome.Text = feriado.FeriadoNome;
            txtDia.Text = feriado.FeriadoDia.ToString();
            txtMes.Text = feriado.FeriadoMes.ToString();

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
            txtNome.Enabled = habilitar;
            txtDia.Enabled = habilitar;
            txtMes.Enabled = habilitar;
            grdDadosFe.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtNome.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
           
           
           feriado.FeriadoId = -1;
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtNome.Text.Length == 0)
            {
                resultado = false;
            }if (txtMes.Text.Length == 0)
            {
                resultado = false;
            }
            if (txtDia.Text.Length == 0)
            {
                resultado = false;
            }


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
            if (feriado.FeriadoId != 0)
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
               
                if (comando == true)
                {
                    //Insere os dados
                    feriado.FeriadoNome = txtNome.Text;
                    feriado.FeriadoDia = Convert.ToInt32(txtDia.Text);
                    feriado.FeriadoMes = Convert.ToInt32(txtMes.Text);

                    db_Feriado.insereFeriadoBase(feriado);
                }
                else if (comando == false)
                {
                    feriado.FeriadoNome = txtNome.Text;
                    feriado.FeriadoDia = Convert.ToInt32(txtDia.Text);
                    feriado.FeriadoMes = Convert.ToInt32(txtMes.Text);
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

 

       

        private void frmFeriado_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraFeriado();
            comando = false;
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
               insereFeriado();
            comando = true;
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

       

        private void grdDadosFe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            feriado.FeriadoId = Convert.ToInt16(grdDadosFe.Rows[grdDadosFe.CurrentRow.Index].Cells[0].Value.ToString());
            atualizaDadosControles();
        }

        private void grdDadosFe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
