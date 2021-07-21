//****************************************************************************************
//**Criado por: Isabelle Caroline de Carvalho Costa, João Pedro Carpanezi dos Santos, Murilo Azevedo Jacon
//**Data de Criação: 21/07/2021
//**Instruções:
//
//

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

namespace Projeto_LPRC5 {
	public partial class FrmVeiculoPessoa : Form {
		public FrmVeiculoPessoa() {
			InitializeComponent();
		}

		private ClasseVeiculoPessoa veiculoPessoa = new ClasseVeiculoPessoa();
		private DbVeiculoPessoa db = new DbVeiculoPessoa();

		public void AtualizaDadosGrid() {
			grdDadosVec.DataSource = db.SelectVeiculoPessoaDBaseGrid();
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
			txtPlaca.Enabled = habilitar;
			txtMorador.Enabled = habilitar;
			txtCor.Enabled = habilitar;
			txtVeiculo.Enabled = habilitar;

			grdDadosVec.Enabled = !habilitar;
		}

		private void LimpaCamposDados() {
			txtPlaca.Text = "";
			txtMorador.Text = "";
			txtCor.Text = "";
			txtVeiculo.Text = "";
			veiculoPessoa = new ClasseVeiculoPessoa();
		}

		private bool VerificaDadosObrigatorios() {
			if (txtPlaca.Text == "" || txtMorador.Text == "" || txtCor.Text == "" || txtVeiculo.Text == "") {
				return false;
			}

			return true;
		}

		private void frmCid_Load(object sender, EventArgs e) {
			HabilitaBotoesMenu(true);
			HabilitaCamposDados(false);
			AtualizaDadosGrid();
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
			if (veiculoPessoa.ID != 0) {
				DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (retorno == DialogResult.Yes) {
					db.ExcluiVeiculoPessoaBase(veiculoPessoa);

					LimpaCamposDados();
					AtualizaDadosGrid();
				}
			} else {
				MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void barbtnSalvar_Click(object sender, EventArgs e) {
			if (VerificaDadosObrigatorios()) {
				int id = veiculoPessoa.ID;
				veiculoPessoa = new ClasseVeiculoPessoa {
					ID = id,
					Placa = txtPlaca.Text,
					MoradorID = Convert.ToInt32(txtMorador.Text),
					CorID = Convert.ToInt32(txtCor.Text),
					VeiculoID = Convert.ToInt32(txtVeiculo.Text)
				};

				if (id == 0) {
					db.InsereVeiculoPessoaBase(veiculoPessoa);
				} else {
					db.AlteraVeiculoPessoaBase(veiculoPessoa);
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
			int id = Convert.ToInt32(grdDadosVec.CurrentRow.Cells[0].Value);
			veiculoPessoa = db.SelectVeiculoPessoaDBase(new ClasseVeiculoPessoa { ID = id });

			txtPlaca.Text = veiculoPessoa.Placa;
			txtMorador.Text = veiculoPessoa.MoradorID.ToString();
			txtCor.Text = veiculoPessoa.CorID.ToString();
			txtVeiculo.Text = veiculoPessoa.VeiculoID.ToString();
		}
	}
}
