//****************************************************************************************
//**Criado por: Isabelle Caroline de Carvalho Costa, João Pedro Carpanezi dos Santos, Murilo Azevedo Jacon
//**Data de Criação: 02/05/2021
//**Instruções:
//
//
//****************************************************************************************
//****** Atualizações: Atualizado para novo modelo do banco
//*** Data: 21/07/2021
//*** Responsável: Murilo Azevedo Jacon, João Pedro Carpanezi dos Santos, Isabelle Caroline de Carvalho de Costa
//****************************************************************************************
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
	public partial class FrmVeiculo : Form {
		public FrmVeiculo() {
			InitializeComponent();
		}

		private ClasseVeiculo veiculo = new ClasseVeiculo();
		private DbVeiculo db = new DbVeiculo();

		public void AtualizaDadosGrid() {
			grdDadosVec.DataSource = db.SelectVeiculoDBaseGrid();
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
			txtMarca.Enabled = habilitar;
			txtModelo.Enabled = habilitar;

			grdDadosVec.Enabled = !habilitar;
		}

		private void LimpaCamposDados() {
			txtMarca.Text = "";
			txtModelo.Text = "";
			veiculo = new ClasseVeiculo();
		}

		private bool VerificaDadosObrigatorios() {
			if (txtModelo.Text == "" || txtMarca.Text == "") {
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
			if (veiculo.ID != 0) {
				DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (retorno == DialogResult.Yes) {
					db.ExcluiVeiculoBase(veiculo);

					LimpaCamposDados();
					AtualizaDadosGrid();
				}
			} else {
				MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void barbtnSalvar_Click(object sender, EventArgs e) {
			if (VerificaDadosObrigatorios()) {
				int id = veiculo.ID;
				veiculo = new ClasseVeiculo {
					ID = id,
					MarcaID = Convert.ToInt32(txtMarca.Text),
					ModeloID = Convert.ToInt32(txtModelo.Text)
				};

				if (id == 0) {
					db.InsereVeiculoBase(veiculo);
				} else {
					db.AlteraVeiculoBase(veiculo);
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
			veiculo = db.SelectVeiculoDBase(new ClasseVeiculo { ID = id });

			txtMarca.Text = veiculo.MarcaID.ToString();
			txtModelo.Text = veiculo.ModeloID.ToString();
		}
	}
}
