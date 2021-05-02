namespace Projeto_LPRC5 {
	partial class FrmVeiculo {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculo));
			this.barManutencao = new System.Windows.Forms.ToolStrip();
			this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
			this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
			this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
			this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
			this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
			this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
			this.grdDadosVec = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.veiculomarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.veiculoplaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.veiculomodelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.veiculocor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtBusca = new System.Windows.Forms.TextBox();
			this.TextboxMarca = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TextboxPlaca = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TextboxModelo = new System.Windows.Forms.TextBox();
			this.TextboxCor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.barManutencao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDadosVec)).BeginInit();
			this.SuspendLayout();
			// 
			// barManutencao
			// 
			this.barManutencao.Dock = System.Windows.Forms.DockStyle.None;
			this.barManutencao.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.barManutencao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnNovo,
            this.barbtnEditar,
            this.barbtnExcluir,
            this.barbtnSalvar,
            this.barbtnCancelar,
            this.barbtnFechar});
			this.barManutencao.Location = new System.Drawing.Point(0, 0);
			this.barManutencao.Name = "barManutencao";
			this.barManutencao.Size = new System.Drawing.Size(228, 39);
			this.barManutencao.TabIndex = 0;
			this.barManutencao.Text = "toolStrip1";
			// 
			// barbtnNovo
			// 
			this.barbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.barbtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNovo.Image")));
			this.barbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.barbtnNovo.Name = "barbtnNovo";
			this.barbtnNovo.Size = new System.Drawing.Size(36, 36);
			this.barbtnNovo.Text = "Novo";
			this.barbtnNovo.ToolTipText = "Adicionar Estado";
			this.barbtnNovo.Click += new System.EventHandler(this.barbtnNovo_Click);
			// 
			// barbtnEditar
			// 
			this.barbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.barbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditar.Image")));
			this.barbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.barbtnEditar.Name = "barbtnEditar";
			this.barbtnEditar.Size = new System.Drawing.Size(36, 36);
			this.barbtnEditar.Text = "Editar";
			this.barbtnEditar.ToolTipText = "Editar Estado";
			this.barbtnEditar.Click += new System.EventHandler(this.barbtnEditar_Click);
			// 
			// barbtnExcluir
			// 
			this.barbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.barbtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barbtnExcluir.Image")));
			this.barbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.barbtnExcluir.Name = "barbtnExcluir";
			this.barbtnExcluir.Size = new System.Drawing.Size(36, 36);
			this.barbtnExcluir.Text = "Excluir";
			this.barbtnExcluir.ToolTipText = "Excluir Estado";
			this.barbtnExcluir.Click += new System.EventHandler(this.barbtnExcluir_Click);
			// 
			// barbtnSalvar
			// 
			this.barbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.barbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSalvar.Image")));
			this.barbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.barbtnSalvar.Name = "barbtnSalvar";
			this.barbtnSalvar.Size = new System.Drawing.Size(36, 36);
			this.barbtnSalvar.Text = "Salvar";
			this.barbtnSalvar.ToolTipText = "Salvar novo estado";
			this.barbtnSalvar.Click += new System.EventHandler(this.barbtnSalvar_Click);
			// 
			// barbtnCancelar
			// 
			this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.barbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelar.Image")));
			this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.barbtnCancelar.Name = "barbtnCancelar";
			this.barbtnCancelar.Size = new System.Drawing.Size(36, 36);
			this.barbtnCancelar.Text = "Cancelar";
			this.barbtnCancelar.ToolTipText = "Cancela a operação de conclusão ou edição";
			this.barbtnCancelar.Click += new System.EventHandler(this.barbtnCancelar_Click);
			// 
			// barbtnFechar
			// 
			this.barbtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.barbtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnFechar.Image")));
			this.barbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.barbtnFechar.Name = "barbtnFechar";
			this.barbtnFechar.Size = new System.Drawing.Size(36, 36);
			this.barbtnFechar.Text = "Fechar";
			this.barbtnFechar.ToolTipText = "Fechar Manutenção de Estado";
			this.barbtnFechar.Click += new System.EventHandler(this.barbtnFechar_Click);
			// 
			// grdDadosVec
			// 
			this.grdDadosVec.AllowUserToAddRows = false;
			this.grdDadosVec.AllowUserToDeleteRows = false;
			this.grdDadosVec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDadosVec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.veiculomarca,
            this.veiculoplaca,
            this.veiculomodelo,
            this.veiculocor});
			this.grdDadosVec.Location = new System.Drawing.Point(12, 76);
			this.grdDadosVec.Name = "grdDadosVec";
			this.grdDadosVec.RowHeadersWidth = 51;
			this.grdDadosVec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDadosVec.Size = new System.Drawing.Size(240, 350);
			this.grdDadosVec.TabIndex = 1;
			this.grdDadosVec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCid_CellClick);
			// 
			// Codigo
			// 
			this.Codigo.DataPropertyName = "veiculoid";
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// veiculomarca
			// 
			this.veiculomarca.HeaderText = "Marca";
			this.veiculomarca.Name = "veiculomarca";
			this.veiculomarca.ReadOnly = true;
			// 
			// veiculoplaca
			// 
			this.veiculoplaca.HeaderText = "Placa";
			this.veiculoplaca.Name = "veiculoplaca";
			this.veiculoplaca.ReadOnly = true;
			// 
			// veiculomodelo
			// 
			this.veiculomodelo.HeaderText = "Modelo";
			this.veiculomodelo.Name = "veiculomodelo";
			this.veiculomodelo.ReadOnly = true;
			// 
			// veiculocor
			// 
			this.veiculocor.HeaderText = "Cor";
			this.veiculocor.Name = "veiculocor";
			this.veiculocor.ReadOnly = true;
			// 
			// txtBusca
			// 
			this.txtBusca.Location = new System.Drawing.Point(13, 41);
			this.txtBusca.Name = "txtBusca";
			this.txtBusca.Size = new System.Drawing.Size(239, 26);
			this.txtBusca.TabIndex = 2;
			// 
			// TextboxMarca
			// 
			this.TextboxMarca.Location = new System.Drawing.Point(258, 101);
			this.TextboxMarca.Name = "TextboxMarca";
			this.TextboxMarca.Size = new System.Drawing.Size(211, 26);
			this.TextboxMarca.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(258, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Marca";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TextboxPlaca
			// 
			this.TextboxPlaca.Location = new System.Drawing.Point(475, 101);
			this.TextboxPlaca.Name = "TextboxPlaca";
			this.TextboxPlaca.Size = new System.Drawing.Size(191, 26);
			this.TextboxPlaca.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(471, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Placa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TextboxModelo
			// 
			this.TextboxModelo.Location = new System.Drawing.Point(258, 168);
			this.TextboxModelo.Name = "TextboxModelo";
			this.TextboxModelo.Size = new System.Drawing.Size(211, 26);
			this.TextboxModelo.TabIndex = 7;
			// 
			// TextboxCor
			// 
			this.TextboxCor.Location = new System.Drawing.Point(475, 168);
			this.TextboxCor.Name = "TextboxCor";
			this.TextboxCor.Size = new System.Drawing.Size(191, 26);
			this.TextboxCor.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(258, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 19);
			this.label3.TabIndex = 9;
			this.label3.Text = "Modelo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(471, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Cor";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 438);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TextboxCor);
			this.Controls.Add(this.TextboxModelo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TextboxPlaca);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextboxMarca);
			this.Controls.Add(this.txtBusca);
			this.Controls.Add(this.grdDadosVec);
			this.Controls.Add(this.barManutencao);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmVeiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manutenção Veículo";
			this.Load += new System.EventHandler(this.frmCid_Load);
			this.barManutencao.ResumeLayout(false);
			this.barManutencao.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDadosVec)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip barManutencao;
		private System.Windows.Forms.ToolStripButton barbtnNovo;
		private System.Windows.Forms.ToolStripButton barbtnEditar;
		private System.Windows.Forms.ToolStripButton barbtnExcluir;
		private System.Windows.Forms.ToolStripButton barbtnSalvar;
		private System.Windows.Forms.ToolStripButton barbtnCancelar;
		private System.Windows.Forms.ToolStripButton barbtnFechar;
		private System.Windows.Forms.DataGridView grdDadosVec;
		private System.Windows.Forms.TextBox txtBusca;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn veiculomarca;
		private System.Windows.Forms.DataGridViewTextBoxColumn veiculoplaca;
		private System.Windows.Forms.DataGridViewTextBoxColumn veiculomodelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn veiculocor;
		private System.Windows.Forms.TextBox TextboxMarca;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextboxPlaca;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TextboxModelo;
		private System.Windows.Forms.TextBox TextboxCor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}