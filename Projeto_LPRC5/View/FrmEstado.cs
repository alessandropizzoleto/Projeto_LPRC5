//****************************************************************************************
//**Criado por: Murilo Azevedo Jacon
//**Data de Criação: 26/04/2021
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
	public partial class FrmEstado : Form {
		public FrmEstado() {
			InitializeComponent();
		}

		private ClasseEstado estado = new ClasseEstado();
		private readonly DbEstado dbEstado = new DbEstado();

		private void formataGrid()
		{
			//Opção para selecionar a linha inteira do grid
			grdDadosEstado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			grdDadosEstado.Columns[0].HeaderText = "Código";
			grdDadosEstado.Columns[1].HeaderText = "Nome";
			grdDadosEstado.Columns[2].HeaderText = "Sigla";

			grdDadosEstado.Columns[0].Width = 0;
			grdDadosEstado.Columns[1].Width = 120;
			grdDadosEstado.Columns[2].Width = 50;

		}

		public void AtualizaDadosGrid() {
			grdDadosEstado.DataSource = dbEstado.SelecionarDataTable();
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
			TextboxNome.Enabled = habilitar;
			TextboxSigla.Enabled = habilitar;

			grdDadosEstado.Enabled = !habilitar;
		}

		private void LimpaCamposDados() {
			TextboxNome.Text = "";
			TextboxSigla.Text = "";
			estado = new ClasseEstado();
		}

		private bool VerificaDadosObrigatorios() {
			if (TextboxNome.Text == "" || TextboxSigla.Text.Length != 2) {
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
			if (estado.Id != 0) {
				DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (retorno == DialogResult.Yes) {
					dbEstado.Excluir(estado.Id);

					LimpaCamposDados();
					AtualizaDadosGrid();
				}
			} else {
				MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void barbtnSalvar_Click(object sender, EventArgs e) {
			if (VerificaDadosObrigatorios()) {
				int id = estado.Id;
				estado = new ClasseEstado() {
					Id = id,
					Nome = TextboxNome.Text,
					Sigla = TextboxSigla.Text
				};

				if (id == 0) {
					dbEstado.Salvar(estado);
				} else {
					dbEstado.Alterar(estado);
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
			int id = Convert.ToInt32(grdDadosEstado.CurrentRow.Cells[0].Value);

			estado = dbEstado.SelecionarObjeto(id);
			TextboxNome.Text = estado.Nome;
			TextboxSigla.Text = estado.Sigla;
		}
	}
}
