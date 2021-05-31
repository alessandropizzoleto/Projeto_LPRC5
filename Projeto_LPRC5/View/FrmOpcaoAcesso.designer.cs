namespace Projeto_LPRC5 {
	partial class FrmOpcaoAcesso {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpcaoAcesso));
            this.barManutencao = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.TextboxTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
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
            this.barManutencao.Size = new System.Drawing.Size(229, 39);
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
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(8, 42);
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.RowHeadersWidth = 51;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(240, 301);
            this.grdDados.TabIndex = 1;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCid_CellClick);
            this.grdDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellContentClick);
            // 
            // TextboxTag
            // 
            this.TextboxTag.Location = new System.Drawing.Point(258, 64);
            this.TextboxTag.Name = "TextboxTag";
            this.TextboxTag.Size = new System.Drawing.Size(291, 30);
            this.TextboxTag.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tag";
            // 
            // TextBoxDescricao
            // 
            this.TextBoxDescricao.Location = new System.Drawing.Point(258, 125);
            this.TextBoxDescricao.Name = "TextBoxDescricao";
            this.TextBoxDescricao.Size = new System.Drawing.Size(291, 30);
            this.TextBoxDescricao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição";
            // 
            // FrmOpcaoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxTag);
            this.Controls.Add(this.grdDados);
            this.Controls.Add(this.barManutencao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOpcaoAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Estado";
            this.Load += new System.EventHandler(this.frmCid_Load);
            this.barManutencao.ResumeLayout(false);
            this.barManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
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
		private System.Windows.Forms.DataGridView grdDados;
		private System.Windows.Forms.TextBox TextboxTag;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxDescricao;
		private System.Windows.Forms.Label label3;
	}
}