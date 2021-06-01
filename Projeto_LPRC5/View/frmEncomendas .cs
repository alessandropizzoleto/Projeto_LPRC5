//****************************************************************************************
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Roberto Marcheti Neto
//**Data de Criação: 03/05/2021
//**Instruções: Criação do formulário frmEncomendas
//
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: Ajustes das funçoes de procedures
//*** Data:03/05/2021
//*** Responsável: Guilherme de Andrade Rissato

//**Grupo 7: Guilherme A.Rissato, Caio Costa Braga, Roberto Marcheti Neto
//****** Atualizações: verificacao da data na procedure de dados obrigatorios
//*** Data:03/05/2021
//*** Responsável: Guilherme de Andrade Rissato
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
    public partial class frmEncomendas : Form
    {
        public frmEncomendas()
        {
            InitializeComponent();
            
        }

        dbEncomenda db_Encomenda = new dbEncomenda();
        classeEncomendas encomenda = new classeEncomendas();

        private void formataGrid()
        {
            //Opção para selecionar a linha inteira do grid
            grdDadosEncomenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosEncomenda.Columns[0].HeaderText = "Código";
            grdDadosEncomenda.Columns[1].HeaderText = "Destinatário";
            grdDadosEncomenda.Columns[2].HeaderText = "Complemento";

            grdDadosEncomenda.Columns[0].Width = 0;
            grdDadosEncomenda.Columns[1].Width = 100;
            grdDadosEncomenda.Columns[2].Width = 80;

        }

        public void atualizaDadosGrid()
        {
            grdDadosEncomenda.DataSource = db_Encomenda.selectEncomendaBase();
        }

        private void atualizaDadosControles()
        {
            encomenda = db_Encomenda.RetornaDadosObjeto(encomenda);

            txtDestinatario.Text = encomenda.getdestinatario();
            txtComplemento.Text = encomenda.getComplemento();
            txtDescricao.Text = encomenda.getDescricao();
            txtEntreguePara.Text = encomenda.getEntreguePara();
            txtEntreguePor.Text = encomenda.getEntreguePor();
            txtRecebida.Text = encomenda.getRecebidaPor();
            msktxtDataEntrada.Text = Convert.ToString(encomenda.getDataEntrada());
            msktxtDataSaida.Text = Convert.ToString(encomenda.getDataSaida());

        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            barbtnNovo.Enabled = hablitar;
            barbtnEditar.Enabled =hablitar;
            barbtnExcluir.Enabled = hablitar;
            barbtnSalvar.Enabled = !hablitar;
            barbtnCancelar.Enabled = !hablitar;
            barbtnFechar.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar)
        {
            txtBusca.Enabled = !habilitar;
            txtDescricao.Enabled = habilitar;
            txtDestinatario.Enabled = habilitar;
            txtEntreguePara.Enabled = habilitar;
            txtEntreguePor.Enabled = habilitar;
            txtRecebida.Enabled = habilitar;
            txtComplemento.Enabled = habilitar;
            msktxtDataEntrada.Enabled = habilitar;
            msktxtDataSaida.Enabled = habilitar;
            grdDadosEncomenda.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtBusca.Text = "";
            txtComplemento.Text = "";
            txtDescricao.Text = "";
            txtDestinatario.Text = "";
            txtEntreguePara.Text = "";
            txtEntreguePor.Text = "";
            txtRecebida.Text = "";
            msktxtDataEntrada.Text = "";
            msktxtDataSaida.Text = "";

            encomenda.setCodigo(-1);
            encomenda.setComplemento("");
            encomenda.setDataEntrada(Convert.ToDateTime(null));
            encomenda.setDataSaida(Convert.ToDateTime(null));
            encomenda.setDescricao("");
            encomenda.setDestinatario("");
            encomenda.setEntreguePara("");
            encomenda.setEntreguePor("");
            encomenda.setRecebidaPor("");
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            if (txtDestinatario.Text.ToString() == "" || txtEntreguePor.Text.ToString() == "" ||
                msktxtDataEntrada.Text.ToString() == "" ||txtRecebida.Text.ToString() == ""|| 
                txtComplemento.Text.ToString() == "")
                {
                    resultado = false;
                }

            return resultado;
        }

        private void InsereEncomenda()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
        }

        private void AlteraEncomenda()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
        }

        private void ExcluiEncomenda()
        {
            if (encomenda.getCodigo() != -1)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada ?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    db_Encomenda.excluiEncomendaBase(encomenda);

                    limpaCamposDados();
                    atualizaDadosGrid();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setEncomendas() {
            encomenda.setComplemento(txtComplemento.Text.ToString());
            encomenda.setDataEntrada(Convert.ToDateTime(msktxtDataEntrada.Text));
            if (msktxtDataSaida.Text.ToString() == "  /  /") {
                encomenda.setDataSaida(Convert.ToDateTime(null));
            }
            else
            {
                encomenda.setDataSaida(Convert.ToDateTime(msktxtDataSaida.Text));
            }
            encomenda.setDescricao(txtDescricao.Text.ToString());
            encomenda.setDestinatario(txtDestinatario.Text.ToString());
            encomenda.setEntreguePara(txtEntreguePara.Text.ToString());
            encomenda.setEntreguePor(txtEntreguePor.Text.ToString());
            encomenda.setRecebidaPor(txtRecebida.Text.ToString());
        }

        private void SalvaEncomenda()
        {
           
            if (verificaDadosObrigatorios() == true)
            {
                setEncomendas();

                if (encomenda.getCodigo() == -1)
                {
                    //Insere os dados
                    db_Encomenda.insereEncomendaBase(encomenda);
                }
                else
                {
                    //Altera os dados
                    db_Encomenda.alteraEncomendaBase(encomenda);
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

        private void cancelaEncomenda()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização da Encomenda?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }

        private void frmEncomendas_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
        }

        private void FechaEncomenda()
        {
            this.Close();
        }

        private void barbtnNovo_Click(object sender, EventArgs e)
        {
            InsereEncomenda();
        }

        private void barbtnEditar_Click(object sender, EventArgs e)
        {
            AlteraEncomenda();
        }

        private void barbtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluiEncomenda();
        }

        private void barbtnSalvar_Click(object sender, EventArgs e)
        {
            SalvaEncomenda();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaEncomenda();
        }

        private void barbtnFechar_Click(object sender, EventArgs e)
        {
            FechaEncomenda();
        }

        private void grdDadosEncomenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void grdDadosEncomenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            encomenda.setCodigo(Convert.ToInt16(grdDadosEncomenda.Rows[grdDadosEncomenda.CurrentRow.Index].Cells[0].Value.ToString()));
            atualizaDadosControles();
        }
    }
}
