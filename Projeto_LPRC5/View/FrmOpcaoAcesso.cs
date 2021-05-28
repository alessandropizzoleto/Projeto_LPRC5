//****************************************************************************************
//**Criado por: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho de Costa
//**Data de Criação: 28/05/2021
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

namespace Projeto_LPRC5 {
	public partial class FrmOpcaoAcesso : Form {
		public FrmOpcaoAcesso() {
			InitializeComponent();
		}

		private classeOpcaoAcesso opcaoAcesso = new classeOpcaoAcesso();
		private readonly dbOpcaoAcesso dbOpcaoAcesso = new dbOpcaoAcesso();

		private void formataGrid()
		{
			//Opção para selecionar a linha inteira do grid
			grdDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			grdDados.Columns[0].HeaderText = "Código";
			grdDados.Columns[1].HeaderText = "Nome";
			grdDados.Columns[2].HeaderText = "Sigla";

			grdDados.Columns[0].Width = 0;
			grdDados.Columns[1].Width = 120;
			grdDados.Columns[2].Width = 50;

		}

		public void AtualizaDadosGrid() {
			//grdDados.DataSource = dbOpcaoAcesso.SelecionarDataTable();
		}

		private void HabilitaBotoesMenu(bool hablitar) {
			barbtnNovo.Enabled = hablitar;
			barbtnEditar.Enabled = hablitar;
			barbtnExcluir.Enabled = hablitar;
			barbtnSalvar.Enabled = !hablitar;
			barbtnCancelar.Enabled = !hablitar;
			barbtnFechar.Enabled = hablitar;
		}

		private void HabilitaCamposDados(bool habilitar) {
			TextboxTag.Enabled = habilitar;
			TextBoxDescricao.Enabled = habilitar;

			grdDados.Enabled = !habilitar;
		}

		private void LimpaCamposDados() {
			TextboxTag.Text = "";
			TextBoxDescricao.Text = "";
			opcaoAcesso = new classeOpcaoAcesso();
		}

		private bool VerificaDadosObrigatorios() {
			if (TextboxTag.Text == "" || TextBoxDescricao.Text == "") {
				return false;
			}

			return true;
		}

		private void frmCid_Load(object sender, EventArgs e) {
			HabilitaBotoesMenu(true);
			HabilitaCamposDados(false);
			AtualizaDadosGrid();
			formataGrid();
		}

		private void barbtnNovo_Click(object sender, EventArgs e) {
			HabilitaBotoesMenu(false);
			HabilitaCamposDados(true);
			LimpaCamposDados();
		}

		private void barbtnEditar_Click(object sender, EventArgs e) {
			HabilitaBotoesMenu(false);
			HabilitaCamposDados(true);
		}

		private void barbtnExcluir_Click(object sender, EventArgs e) {
			if (opcaoAcesso.Codigo != 0) {
				DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (retorno == DialogResult.Yes) {
					dbOpcaoAcesso.excluiOpcaoAcessoBase(opcaoAcesso);

					LimpaCamposDados();
					AtualizaDadosGrid();
				}
			} else {
				MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void barbtnSalvar_Click(object sender, EventArgs e) {
			if (VerificaDadosObrigatorios()) {
				int id = opcaoAcesso.Codigo;
				opcaoAcesso = new classeOpcaoAcesso() {
					Codigo = id,
					CodigoTag = Convert.ToInt32(TextboxTag.Text),
					Descricao = TextBoxDescricao.Text
				};

				if (id == 0) {
					dbOpcaoAcesso.insereOpcaoAcessoBase(opcaoAcesso);
				} else {
					dbOpcaoAcesso.alteraOpcaoAcessoBase(opcaoAcesso);
				}
				
				HabilitaBotoesMenu(true);
				HabilitaCamposDados(false);
				LimpaCamposDados();
				AtualizaDadosGrid();
			} else {
				MessageBox.Show("Dados Obrigatórios não informados ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void barbtnCancelar_Click(object sender, EventArgs e) {
			DialogResult dialog = MessageBox.Show("Deseja cancelar o Cadastro/Atualização de estado?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (dialog == DialogResult.Yes) {
				HabilitaBotoesMenu(true);
				HabilitaCamposDados(false);
				LimpaCamposDados();
			}
		}

		private void barbtnFechar_Click(object sender, EventArgs e) {
			Close();
		}

		private void grdDadosCid_CellClick(object sender, DataGridViewCellEventArgs e) {
			int id = Convert.ToInt32(grdDados.CurrentRow.Cells[0].Value);

			opcaoAcesso = dbOpcaoAcesso.selectOpcaoAcessoBase(new classeOpcaoAcesso() { Codigo = id });
			TextBoxDescricao.Text = opcaoAcesso.Descricao;
			TextboxTag.Text = opcaoAcesso.CodigoTag.ToString();
		}
	}
}
