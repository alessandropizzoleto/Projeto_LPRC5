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
        classeMoradores morad = new classeMoradores();
        bool comando;

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
            morad.setPessoaID(-1);
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

            
            if (comboxhabid.SelectedItem == null)
             {
                 resultado = false;
             }
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

        private void insereMoradores()
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

        private void alteraMoradores()
        {

            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnnovomorad.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();

            }
            else
            {
                MessageBox.Show("Não é possível alterar dados de moradores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void excluiMoradores()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(barbtnexcluirmorad.Tag)) == true)
            {

                if (morad.getPessoaID() != 0)
                {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();

                morad.atualizaMoradores("excluir");

                }
            else
            {
                MessageBox.Show("Não é possível excluir moradores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Exclusão da Cor selecionada", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void salvaMoradores()
        {
            if (verificaDadosObrigatorios() == true)
            {

                if (comando == true)
                {
                    morad.setPessoaNomeRegistro(txtnomemorad.Text.ToString());
                    morad.setPessoaNomeSocial(txtnomesocial.Text.ToString());
                    morad.setPessoaEmail(txtemail.Text.ToString());
                    morad.cpf = mtxtcpfmorad.Text.ToString();
                    morad.rg = mtxtrgmorad.Text.ToString();
                    morad.setHabitacaoId(Convert.ToInt16(comboxhabid.Text.ToString()));


                    // db_Moradores.insereMoradoresBase(morad);
                    morad.atualizaMoradores("inserir");

                    
                }
                else if (comando == false)
                {

                    morad.setPessoaNomeRegistro(txtnomemorad.Text.ToString());
                    morad.setPessoaNomeSocial(txtnomesocial.Text.ToString());
                    morad.setPessoaEmail(txtemail.Text.ToString());
                    morad.cpf = mtxtcpfmorad.Text.ToString();
                    morad.rg = mtxtrgmorad.Text.ToString();
                    morad.setHabitacaoId(Convert.ToInt16(comboxhabid.Text.ToString()));

                    //db_Moradores.alteraMoradoresBase(morad);
                    morad.atualizaMoradores("atualizar");
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
        private void cancelaMorador()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro do morador?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }

        private void fechaMoradores()
        {
            this.Close();
        }

        private void barbtnnovomorad_Click(object sender, EventArgs e)
        {
            insereMoradores();
            comando = true;
        }

        private void barbtneditarmorad_Click(object sender, EventArgs e)
        {
            alteraMoradores();
            comando = false;
        }

        private void barbtnexcluirmorad_Click(object sender, EventArgs e)
        {
            excluiMoradores();
        }

        private void barbtnsalvarmorad_Click(object sender, EventArgs e)
        {
            salvaMoradores();
        }

        private void barbtncancelarmorad_Click(object sender, EventArgs e)
        {
            cancelaMorador();
        }

        private void barbtnfecharmorad_Click(object sender, EventArgs e)
        {
            fechaMoradores();
        }

        private void atualizaDadosControles()
        {
            db_Moradores.selectMoradoresBase(morad.getPessoaID());
            txtnomemorad.Text = morad.getPessoaNomeRegistro();
            txtnomesocial.Text = morad.getPessoaNomeSocial();
            txtemail.Text = morad.getPessoaEmail();
            mtxtcpfmorad.Text = morad.cpf;
            mtxtrgmorad.Text = morad.rg;
            comboxhabid.Text = morad.getHabitacaoId().ToString();

        }
        private void grddadosmorad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            morad.setPessoaID(Convert.ToInt16(grddadosmorad.Rows[grddadosmorad.CurrentRow.Index].Cells[0].Value.ToString()));
           db_Moradores.selectMoradoresBase();
                   


            atualizaDadosControles();
        }
    }
}
