namespace Projeto_LPRC5 {
	partial class FrmEstado {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstado));
			this.barManutencao = new System.Windows.Forms.ToolStrip();
			this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
			this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
			this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
			this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
			this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
			this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
			this.grdDadosCid = new System.Windows.Forms.DataGridView();
			this.txtBusca = new System.Windows.Forms.TextBox();
			this.TextboxSigla = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TextboxNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barManutencao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDadosCid)).BeginInit();
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
			this.barManutencao.Size = new System.Drawing.Size(259, 39);
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
			// grdDadosCid
			// 
			this.grdDadosCid.AllowUserToAddRows = false;
			this.grdDadosCid.AllowUserToDeleteRows = false;
			this.grdDadosCid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDadosCid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Sigla});
			this.grdDadosCid.Location = new System.Drawing.Point(12, 76);
			this.grdDadosCid.Name = "grdDadosCid";
			this.grdDadosCid.RowHeadersWidth = 51;
			this.grdDadosCid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDadosCid.Size = new System.Drawing.Size(240, 350);
			this.grdDadosCid.TabIndex = 1;
			this.grdDadosCid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCid_CellClick);
			// 
			// txtBusca
			// 
			this.txtBusca.Location = new System.Drawing.Point(13, 41);
			this.txtBusca.Name = "txtBusca";
			this.txtBusca.Size = new System.Drawing.Size(239, 26);
			this.txtBusca.TabIndex = 2;
			// 
			// TextboxSigla
			// 
			this.TextboxSigla.Location = new System.Drawing.Point(258, 98);
			this.TextboxSigla.Name = "TextboxSigla";
			this.TextboxSigla.Size = new System.Drawing.Size(111, 26);
			this.TextboxSigla.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(254, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Sigla";
			// 
			// TextboxNome
			// 
			this.TextboxNome.Location = new System.Drawing.Point(375, 98);
			this.TextboxNome.Name = "TextboxNome";
			this.TextboxNome.Size = new System.Drawing.Size(291, 26);
			this.TextboxNome.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(371, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nome";
			// 
			// Codigo
			// 
			this.Codigo.DataPropertyName = "estadoid";
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Nome
			// 
			this.Nome.DataPropertyName = "estadonome";
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			// 
			// Sigla
			// 
			this.Sigla.DataPropertyName = "estadosigla";
			this.Sigla.HeaderText = "Sigla";
			this.Sigla.Name = "Sigla";
			this.Sigla.ReadOnly = true;
			// 
			// FrmEstado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 438);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TextboxNome);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextboxSigla);
			this.Controls.Add(this.txtBusca);
			this.Controls.Add(this.grdDadosCid);
			this.Controls.Add(this.barManutencao);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmEstado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manutenção Estado";
			this.Load += new System.EventHandler(this.frmCid_Load);
			this.barManutencao.ResumeLayout(false);
			this.barManutencao.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDadosCid)).EndInit();
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
		private System.Windows.Forms.DataGridView grdDadosCid;
		private System.Windows.Forms.TextBox txtBusca;
		private System.Windows.Forms.TextBox TextboxSigla;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextboxNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
	}
}