//****************************************************************************************
//**Criado por: Isabelle Caroline de Carvalho Costa, João Pedro Carpanezi dos Santos, Murilo Azevedo Jacon
//**Data de Criação: 02/05/2021
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
	public partial class FrmVeiculo : Form {
		public FrmVeiculo() {
			InitializeComponent();
		}

		private ClasseVeiculo veiculo = new ClasseVeiculo();
		//private readonly DbEstado dbEstado = new DbEstado();

		public void AtualizaDadosGrid() {
			//grdDadosVec.DataSource = dbEstado.SelecionarDataTable();
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
			//txtVeiculo.Enabled = habilitar;
			//TextboxPlaca.Enabled = habilitar;
			//TextboxModelo.Enabled = habilitar;
			//TextboxCor.Enabled = habilitar;

			grdDadosVec.Enabled = !habilitar;
		}

		private void LimpaCamposDados() {
			//txtVeiculo.Text = "";
			//TextboxPlaca.Text = "";
			//TextboxModelo.Text = "";
			//TextboxCor.Text = "";
			//veiculo = new ClasseVeiculo();
		}

		private bool VerificaDadosObrigatorios() {
			//if (txtVeiculo.Text == "" || TextboxPlaca.Text == "" || TextboxModelo.Text == "" || TextboxCor.Text == "") {
			//	return false;
			//}

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
			//if (veiculo.Id != 0) {
			//	DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			//	if (retorno == DialogResult.Yes) {
			//		//dbEstado.Excluir(veiculo.Id);

			//		LimpaCamposDados();
			//		AtualizaDadosGrid();
			//	}
			//} else {
			//	MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void barbtnSalvar_Click(object sender, EventArgs e) {
			//if (VerificaDadosObrigatorios()) {
			//	int id = veiculo.Id;
			//	veiculo = new ClasseVeiculo() {
   //                 Id = id,
   //                 Marca = txtVeiculo.Text,
   //                 Placa = TextboxPlaca.Text,
   //                 Modelo = TextboxModelo.Text,
   //                 Cor = TextboxCor.Text
   //             };

			//	//if (id == 0) {
			//	//	dbEstado.Salvar(veiculo);
			//	//} else {
			//	//	dbEstado.Alterar(veiculo);
			//	//}
				
			//	HabilitaBotoesMenu(true);
			//	HabilitaCamposDados(false);
			//	LimpaCamposDados();
			//	AtualizaDadosGrid();
			//} else {
			//	MessageBox.Show("Dados Obrigatórios não informados ", "Urgente!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
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
			//int id = Convert.ToInt32(grdDadosVec.CurrentRow.Cells[0].Value);
			//estado = dbEstado.SelecionarObjeto(id);

			//TextboxNome.Text = estado.Nome;
			//TextboxSigla.Text = estado.Sigla;
		}
	}
}
