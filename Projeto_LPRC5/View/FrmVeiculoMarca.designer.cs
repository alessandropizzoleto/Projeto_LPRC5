namespace Projeto_LPRC5
{
    partial class FrmVeiculoMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculoMarca));
			this.barManutencao = new System.Windows.Forms.ToolStrip();
			this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
			this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
			this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
			this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
			this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
			this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
			this.grdDadosVeiculoModelo = new System.Windows.Forms.DataGridView();
			this.txtVeiculoMarca = new System.Windows.Forms.TextBox();
			this.lblVeiculoMarca = new System.Windows.Forms.Label();
			this.barManutencao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDadosVeiculoModelo)).BeginInit();
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
			this.barbtnNovo.ToolTipText = "Adicionar Cidade";
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
			this.barbtnEditar.ToolTipText = "Editar Cidade";
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
			this.barbtnExcluir.ToolTipText = "Excluir Cidade";
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
			this.barbtnSalvar.ToolTipText = "Salvar nova Cidade";
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
			this.barbtnFechar.ToolTipText = "Fechar Manutenção de Cidade";
			this.barbtnFechar.Click += new System.EventHandler(this.barbtnFechar_Click);
			// 
			// grdDadosVeiculoModelo
			// 
			this.grdDadosVeiculoModelo.AllowUserToAddRows = false;
			this.grdDadosVeiculoModelo.AllowUserToDeleteRows = false;
			this.grdDadosVeiculoModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDadosVeiculoModelo.Location = new System.Drawing.Point(12, 43);
			this.grdDadosVeiculoModelo.Name = "grdDadosVeiculoModelo";
			this.grdDadosVeiculoModelo.ReadOnly = true;
			this.grdDadosVeiculoModelo.RowHeadersWidth = 51;
			this.grdDadosVeiculoModelo.Size = new System.Drawing.Size(240, 320);
			this.grdDadosVeiculoModelo.TabIndex = 1;
			this.grdDadosVeiculoModelo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCid_CellClick);
			// 
			// txtVeiculoMarca
			// 
			this.txtVeiculoMarca.Enabled = false;
			this.txtVeiculoMarca.Location = new System.Drawing.Point(266, 68);
			this.txtVeiculoMarca.Name = "txtVeiculoMarca";
			this.txtVeiculoMarca.Size = new System.Drawing.Size(247, 26);
			this.txtVeiculoMarca.TabIndex = 3;
			// 
			// lblVeiculoMarca
			// 
			this.lblVeiculoMarca.AutoSize = true;
			this.lblVeiculoMarca.Location = new System.Drawing.Point(262, 43);
			this.lblVeiculoMarca.Name = "lblVeiculoMarca";
			this.lblVeiculoMarca.Size = new System.Drawing.Size(49, 19);
			this.lblVeiculoMarca.TabIndex = 4;
			this.lblVeiculoMarca.Text = "Marca";
			// 
			// FrmVeiculoMarca
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 374);
			this.Controls.Add(this.lblVeiculoMarca);
			this.Controls.Add(this.txtVeiculoMarca);
			this.Controls.Add(this.grdDadosVeiculoModelo);
			this.Controls.Add(this.barManutencao);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmVeiculoMarca";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manutenção do Modelo de Veículo";
			this.Load += new System.EventHandler(this.frmVeiculoModelo_Load);
			this.barManutencao.ResumeLayout(false);
			this.barManutencao.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDadosVeiculoModelo)).EndInit();
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
        private System.Windows.Forms.DataGridView grdDadosVeiculoModelo;
        private System.Windows.Forms.TextBox txtVeiculoMarca;
        private System.Windows.Forms.Label lblVeiculoMarca;
    }
}