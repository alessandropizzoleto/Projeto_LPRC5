//****************************************************************************************
//**Criado por: Amanda Iaquinta, André Costa e Giovanna Frederico
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
using Projeto_LPRC5.Model.Conexão;
using Projeto_LPRC5.Model.Classe;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5.View
{
    public partial class frmVisitantes : Form
    {
        public frmVisitantes()
        {
            InitializeComponent();
        }

        dbVisitantes db_Visitantes = new dbVisitantes();
        dbTipoVisitante dbTipoVisitante = new dbTipoVisitante();
        classeVisitantes ClasseVisitantes = new classeVisitantes();

        private void carregaCmbox()
        {
            MySqlDataReader reader;
            reader = dbTipoVisitante.SelectCmbBox();
            while (reader.Read())
            {
                cmbTipoVisitante.ValueMember = reader["tipo_visitante_id"].ToString();
                cmbTipoVisitante.DisplayMember = reader["visitante_descricao"].ToString();
                cmbTipoVisitante.Items.Add(reader["visitante_descricao"]);
            }
        }
        private void formataGrid()
        {
            
            grdVisitantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

           
            
            grdVisitantes.Columns[0].HeaderText = "Nome";
            grdVisitantes.Columns[1].HeaderText = "Id Visita";
            grdVisitantes.Columns[2].HeaderText = "Data Visita";
            grdVisitantes.Columns[3].HeaderText = "Id pessoa";
            grdVisitantes.Columns[4].HeaderText = "Habitação Id";
            grdVisitantes.Columns[5].HeaderText = "Tipo Visitante Id";

            grdVisitantes.Columns[0].Width = 100;
            grdVisitantes.Columns[1].Width = 50;
            grdVisitantes.Columns[2].Width = 50;
            grdVisitantes.Columns[3].Width = 50;
            grdVisitantes.Columns[4].Width = 50;
            grdVisitantes.Columns[5].Width = 50;

        }

        public void atualizaDadosGrid()
        {
            grdVisitantes.DataSource = db_Visitantes.selectVisitantes();
        }

        private void habilitaBotoesMenu(bool hablitar)
        {
            btnNovo.Enabled = hablitar;
            btnEditar.Enabled = hablitar;
            btnExcluir.Enabled = hablitar;
            btnSalvar.Enabled = !hablitar;
            btnCancelar.Enabled = !hablitar;
            btnSair.Enabled = hablitar;
        }

        private void habilitaCamposDados(bool habilitar)
        {
            txtNomeRegitro.Enabled = habilitar;
            txtNomeSocial.Enabled = habilitar;
            txtEmail.Enabled = habilitar;
            txtCpf.Enabled = habilitar;
            txtRg.Enabled = habilitar;
            grdVisitantes.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            cmbHabitacaoId.SelectedItem = null;
            cmbTipoVisitante.SelectedItem = null;
            txtNomeRegitro.Text = "";
            txtNomeSocial.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;

           /* if (cmbHabitacaoId.SelectedItem == null)
            {
                resultado = false;
            }*/
            if (txtNomeRegitro.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtNomeSocial.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtEmail.Text.Length < 2)
            {
                resultado = false;
            }
            else if (txtCpf.Text.Length < 12)
            {
                resultado = false;
            }
            else if (txtRg.Text.Length < 10)
            {
                resultado = false;
            }

            return resultado;
        }

        private void inseriVisita()
        {
            if (util.verificaPermissao(util.usuarioAtual, Convert.ToInt16(this.Tag), Convert.ToInt16(btnNovo.Tag)) == true)
            {
                habilitaBotoesMenu(false);
                habilitaCamposDados(true);
                limpaCamposDados();
            }
            else
            {
                MessageBox.Show("Usuário não tem permissão para realizar a Inclusão de Visitas", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void alteraVisita()
        {
                MessageBox.Show("Não é possível alterar dados de visitas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void excluiVisita()
        {
               MessageBox.Show("Não é possível excluir visitas.","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void salvaVisita()
        {
            if (verificaDadosObrigatorios() == true)
            {
                ClasseVisitantes.setPessoaNomeRegistro(txtNomeRegitro.Text.ToString());
                ClasseVisitantes.setPessoaNomeSocial(txtNomeSocial.Text.ToString());
                ClasseVisitantes.setPessoaEmail(txtEmail.Text.ToString());
                ClasseVisitantes.cpf = txtCpf.Text.ToString();
                ClasseVisitantes.rg = txtRg.Text.ToString();
               // ClasseVisitantes.habitacaoId = Convert.ToInt32(cmbHabitacaoId.Text);
                ClasseVisitantes.tipoVisitanteId = Convert.ToInt32(cmbTipoVisitante.ValueMember);

                db_Visitantes.insereVisitante(ClasseVisitantes);

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

        private void cancelaVisita()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro da visita?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                limpaCamposDados();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inseriVisita();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            alteraVisita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluiVisita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvaVisita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaVisita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisitantes_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            atualizaDadosGrid();
            formataGrid();
            carregaCmbox();
        }
    }
}
