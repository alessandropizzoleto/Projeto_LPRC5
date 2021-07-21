//****************************************************************************************
//**Criado por: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho de Costa
//**Data de Criação: 21/07/2021
//**Instruções:


using Projeto_LPRC5.Model.Classe;
using Projeto_LPRC5.Model.Conexão;
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
    public partial class FrmVeiculoMarca : Form
    {
        public FrmVeiculoMarca()
        {
            InitializeComponent();
        }

        DbVeiculoMarca db = new DbVeiculoMarca();
        ClasseVeiculoMarca veiculoMarca = new ClasseVeiculoMarca();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosVeiculoModelo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosVeiculoModelo.Columns[0].HeaderText = "Código";
            grdDadosVeiculoModelo.Columns[1].HeaderText = "Nome";

            grdDadosVeiculoModelo.Columns[0].Width = 0;
            grdDadosVeiculoModelo.Columns[1].Width = 120;

        }

        public void atualizaDadosGrid()
        {
            grdDadosVeiculoModelo.DataSource = db.SelectVeiculoMarcaDBaseGrid();
        }

        private void atualizaDadosControles()
        {
            veiculoMarca = db.SelectVeiculoMarcaDBase(veiculoMarca);

            txtVeiculoMarca.Text = veiculoMarca.Nome;
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
            txtVeiculoMarca.Enabled = habilitar;
            grdDadosVeiculoModelo.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtVeiculoMarca.Text = "";
            veiculoMarca.ID = -1;
            veiculoMarca.Nome = "";
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtVeiculoMarca.Text.Trim().Length < 2)
            {
               resultado = false;
            }


            return resultado;
        }

        private void insereVeiculoModelo()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void alteraVeiculoModelo()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void excluiVeiculoModelo()
        {
            if (veiculoMarca.ID != -1)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db.ExcluiVeiculoMarcaBase(veiculoMarca);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvaVeiculoModelo()
        {
            if (verificaDadosObrigatorios() == true)
            {
                veiculoMarca.Nome = txtVeiculoMarca.Text;
                if (veiculoMarca.ID == -1)
                {
                    //Insere os dados
                    db.InsereVeiculoMarcaBase(veiculoMarca);
                }
                else
                {
                    //Altera os dados
                    db.AlteraVeiculoMarcaBase(veiculoMarca);
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

        private void cancelaVeiculoModelo()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Default?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }

        private void frmVeiculoModelo_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }
        private void fechaVeiculoModelo()
        {
            this.Close();
        }        
        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            insereVeiculoModelo();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            alteraVeiculoModelo();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            excluiVeiculoModelo();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            salvaVeiculoModelo();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaVeiculoModelo();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            fechaVeiculoModelo();
        }

        private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            veiculoMarca.ID = Convert.ToInt16(grdDadosVeiculoModelo.Rows[grdDadosVeiculoModelo.CurrentRow.Index].Cells[0].Value.ToString());
            atualizaDadosControles();
        }
    }
}
