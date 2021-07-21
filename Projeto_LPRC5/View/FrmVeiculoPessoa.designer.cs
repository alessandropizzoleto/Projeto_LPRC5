namespace Projeto_LPRC5 {
	partial class FrmVeiculoPessoa {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculoPessoa));
			this.barManutencao = new System.Windows.Forms.ToolStrip();
			this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
			this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
			this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
			this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
			this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
			this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
			this.grdDadosVec = new System.Windows.Forms.DataGridView();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMorador = new System.Windows.Forms.TextBox();
			this.txtCor = new System.Windows.Forms.TextBox();
			this.txtVeiculo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.barManutencao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDadosVec)).BeginInit();
			this.SuspendLayout();
			// 
			// barManutencao
			// 
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
			this.barManutencao.Size = new System.Drawing.Size(615, 39);
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
			this.grdDadosVec.Location = new System.Drawing.Point(12, 42);
			this.grdDadosVec.Name = "grdDadosVec";
			this.grdDadosVec.ReadOnly = true;
			this.grdDadosVec.RowHeadersWidth = 51;
			this.grdDadosVec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDadosVec.Size = new System.Drawing.Size(240, 282);
			this.grdDadosVec.TabIndex = 1;
			this.grdDadosVec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCid_CellClick);
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(257, 64);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(187, 26);
			this.txtPlaca.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(258, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Placa";
			// 
			// txtMorador
			// 
			this.txtMorador.Location = new System.Drawing.Point(256, 137);
			this.txtMorador.Name = "txtMorador";
			this.txtMorador.Size = new System.Drawing.Size(187, 26);
			this.txtMorador.TabIndex = 4;
			// 
			// txtCor
			// 
			this.txtCor.Location = new System.Drawing.Point(257, 216);
			this.txtCor.Name = "txtCor";
			this.txtCor.Size = new System.Drawing.Size(186, 26);
			this.txtCor.TabIndex = 5;
			// 
			// txtVeiculo
			// 
			this.txtVeiculo.Location = new System.Drawing.Point(257, 295);
			this.txtVeiculo.Name = "txtVeiculo";
			this.txtVeiculo.Size = new System.Drawing.Size(186, 26);
			this.txtVeiculo.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(257, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Morador";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(258, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 19);
			this.label3.TabIndex = 9;
			this.label3.Text = "Cor";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(258, 273);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Veiculo";
			// 
			// FrmVeiculoPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 333);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtVeiculo);
			this.Controls.Add(this.txtCor);
			this.Controls.Add(this.txtMorador);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPlaca);
			this.Controls.Add(this.grdDadosVec);
			this.Controls.Add(this.barManutencao);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmVeiculoPessoa";
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
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMorador;
		private System.Windows.Forms.TextBox txtCor;
		private System.Windows.Forms.TextBox txtVeiculo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}