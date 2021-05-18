//****************************************************************************************
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Roberto Marcheti Neto
//**Data de Criação: 28/04/2021
//**Instruções: Criação do formulário frmVeiculoModelo
// 
//
//****** Atualizações: Tanto código quanto form estão OK, não sendo necessário fazer alterações
//*** Data: 03/05/2021
//*** Responsável: Giovanni Marques

//****** Atualizações: Alteração e correção do código do formulário frmVeiculoModelo
//*** Data: 04/05/2021
//*** Responsável: Roberto Marcheti Neto
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
    public partial class frmVeiculoModelo : Form
    {
        public frmVeiculoModelo()
        {
            InitializeComponent();
        }

        dbVeiculoModelo db_veiculoMode = new dbVeiculoModelo();
        classeVeiculoModelo veiculoModelo = new classeVeiculoModelo();

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
            grdDadosVeiculoModelo.DataSource = db_veiculoMode.selectVeiculoModeloBase();
        }

        private void atualizaDadosControles()
        {
            veiculoModelo = db_veiculoMode.RetornaDadosObjeto(veiculoModelo);

            txtVeiculoModelo.Text = veiculoModelo.getnomeVeiculo();
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
            txtVeiculoModelo.Enabled = habilitar;
            grdDadosVeiculoModelo.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtVeiculoModelo.Text = "";
            veiculoModelo.setVeiculoID(-1);
            veiculoModelo.setnomeVeiculo("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtVeiculoModelo.Text.Trim().Length < 2)
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
            if (veiculoModelo.getVeiculoID() != -1)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_veiculoMode.excluiVeiculoModelo(veiculoModelo);

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
                veiculoModelo.setnomeVeiculo(txtVeiculoModelo.Text);
                if (veiculoModelo.getVeiculoID() == -1)
                {
                    //Insere os dados
                    db_veiculoMode.insereVeiculoModelo(veiculoModelo);
                }
                else
                {
                    //Altera os dados
                    db_veiculoMode.alteraVeiculoModelo(veiculoModelo);
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
            veiculoModelo.setVeiculoID(Convert.ToInt16(grdDadosVeiculoModelo.Rows[grdDadosVeiculoModelo.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }

       
    }
}
