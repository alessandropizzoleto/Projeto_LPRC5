//****************************************************************************************
//**Criado por: Alexandro Junior, Caique Bruno , Guilherme Beig
//**Data de Criação: 03/05/2021
//**Instruções: Criaçao design do forms Moradores, incluindo informações necessarias para cadastro de morador
//
//
//****** Atualizações: 
// *** Data:
//*** Responsável:
//
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
using Projeto_LPRC5.Model.Conexão;
using Projeto_LPRC5.Model.Classe;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5
{
    public partial class frmMoradores : Form
    {
        public frmMoradores()
        {
            InitializeComponent();
        }

        dbMoradores db_Moradores = new dbMoradores();
        classeMoradores ClasseMoradores = new classeMoradores();

        private void carregaCmbox()
        {
            MySqlDataReader reader;
            reader = db_Moradores.SelectComboBox();
            while (reader.Read())
            {
               comboxhabid.ValueMember = reader["habitacao_id"].ToString();
               comboxhabid.Items.Add(reader["habitacao_id"]);
            }
        }

        private void formataGrid()
        {

            grddadosmorad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            grddadosmorad.Columns[0].HeaderText = "Id";
            grddadosmorad.Columns[1].HeaderText = "Nome";
            grddadosmorad.Columns[2].HeaderText = "Nome Social";
            grddadosmorad.Columns[3].HeaderText = "Foto";
            grddadosmorad.Columns[4].HeaderText = "E-Mail";
            grddadosmorad.Columns[5].HeaderText = "CPF";
            grddadosmorad.Columns[6].HeaderText = "RG";
            grddadosmorad.Columns[7].HeaderText = "Habitacao";



            grddadosmorad.Columns[0].Width = 50;
            grddadosmorad.Columns[1].Width = 150;
            grddadosmorad.Columns[2].Width = 150;
            grddadosmorad.Columns[3].Width = 50;
            grddadosmorad.Columns[4].Width = 150;
            grddadosmorad.Columns[5].Width = 70;
            grddadosmorad.Columns[6].Width = 70;
            grddadosmorad.Columns[7].Width = 50;

        }

        public void atualizaDadosGrid()
        {
            grddadosmorad.DataSource = db_Moradores.selectMoradoresBase();
        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            barbtnnovomorad.Enabled = hablitar;
            barbtneditarmorad.Enabled = hablitar;
            barbtnexcluirmorad.Enabled = hablitar;
            barbtnsalvarmorad.Enabled = !hablitar;
            barbtncancelarmorad.Enabled = !hablitar;
            barbtnfecharmorad.Enabled = hablitar;
        }
        private void habilitaCamposDados(bool habilitar)
        {
            txtnomemorad.Enabled = habilitar;
            txtnomesocial.Enabled = habilitar;
            txtemail.Enabled = habilitar;
            mtxtcpfmorad.Enabled = habilitar;
            mtxtrgmorad.Enabled = habilitar;
            grddadosmorad.Enabled = !habilitar;
            comboxhabid.Enabled = habilitar;
            
        }

        private void limpaCamposDados()
        {
            comboxhabid.SelectedItem = null;
            txtnomemorad.Text = txtnomesocial.Text = mtxtcpfmorad.Text = mtxtrgmorad.Text = txtemail.Text = null;
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            // Descomentar a linha abaixo após a implementação das classe habitação (resposabilidade de outro grupo). 
            /* if (cmbHabitacaoId.SelectedItem == null)
             {
                 resultado = false;
             }*/
            if (txtnomemorad.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtnomesocial.Text.Length < 2)
            {
                resultado = false;
            }
            else if (mtxtcpfmorad.Text.Length < 2)
            {
                resultado = false;
            }
            else if (mtxtrgmorad.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtemail.Text.Length < 2)
            {
                resultado = false;
            }

            return resultado;
        }

        private void insereMorador()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnnovomorad.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Inclusão de Moradores", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void alteraMorador()
        {
            MessageBox.Show("Não é possível alterar dados de moradores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void excluiMorador()
        {
            MessageBox.Show("Não é possível excluir moradores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void salvaVisita()
        {
            if (verificaDadosObrigatorios() == true)
            {
               // ClasseMoradores.setPessoaNomeRegistro(txtnomemorad.Text.ToString());
               //ClasseMoradores.setPessoaNomeSocial(txtnomesocial.Text.ToString());
               // ClasseMoradores.setPessoaEmail(txtemail.Text.ToString());
               // ClasseMoradores.cpf = mtxtcpfmorad.Text.ToString();
               // ClasseMoradores.rg = mtxtrgmorad.Text.ToString();
               // ClasseMoradores.setHabitacaoId(Convert.ToInt16(comboxhabid.Text.ToString()));
               

                db_Moradores.insereMoradoresBase(txtnomemorad.Text.ToString(), txtnomesocial.Text.ToString(), txtemail.Text.ToString(), mtxtcpfmorad.Text.ToString(), mtxtrgmorad.Text.ToString(), Convert.ToInt16(comboxhabid.Text.ToString()));
                           

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
        private void cancelaMorador()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro do morador?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                limpaCamposDados();
            }
        }

        private void barbtnnovomorad_Click(object sender, EventArgs e)
        {
            
        }

        private void barbtneditarmorad_Click(object sender, EventArgs e)
        {

        }

        private void barbtnexcluirmorad_Click(object sender, EventArgs e)
        {

        }

        private void barbtnsalvarmorad_Click(object sender, EventArgs e)
        {

        }

        private void barbtncancelarmorad_Click(object sender, EventArgs e)
        {

        }

        private void barbtnfecharmorad_Click(object sender, EventArgs e)
        {

        }
    }
}
