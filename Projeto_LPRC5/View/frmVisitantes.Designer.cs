namespace Projeto_LPRC5.View
{
    partial class frmVisitantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitantes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.txtPessoaFisicaId = new System.Windows.Forms.TextBox();
            this.lblPessoaFisicaId = new System.Windows.Forms.Label();
            this.grdVisitantes = new System.Windows.Forms.DataGridView();
            this.lblTipoVisitante = new System.Windows.Forms.Label();
            this.txtHabitacao = new System.Windows.Forms.TextBox();
            this.lblHabitacao = new System.Windows.Forms.Label();
            this.cmbTipoVisitante = new System.Windows.Forms.ComboBox();
            this.txtVeiculoId = new System.Windows.Forms.TextBox();
            this.lblVeiculoId = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitantes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnEditar,
            this.btnExcluir,
            this.btnSalvar,
            this.btnCancelar,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(4, 11);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(259, 39);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(36, 36);
            this.btnNovo.Tag = "1";
            this.btnNovo.Text = "Novo";
            this.btnNovo.ToolTipText = "Adicionar Cidade";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.Tag = "2";
            this.btnEditar.Text = "Editar";
            this.btnEditar.ToolTipText = "Editar Cidade";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(36, 36);
            this.btnExcluir.Tag = "3";
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.ToolTipText = "Excluir Cidade";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 36);
            this.btnSalvar.Tag = "4";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.ToolTipText = "Salvar nova Cidade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Tag = "5";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTipText = "Cancela a operação de conclusão ou edição";
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.Tag = "6";
            this.btnSair.Text = "Fechar";
            this.btnSair.ToolTipText = "Fechar Manutenção de Cidade";
            // 
            // txtPessoaFisicaId
            // 
            this.txtPessoaFisicaId.Location = new System.Drawing.Point(250, 78);
            this.txtPessoaFisicaId.Name = "txtPessoaFisicaId";
            this.txtPessoaFisicaId.Size = new System.Drawing.Size(286, 26);
            this.txtPessoaFisicaId.TabIndex = 8;
            // 
            // lblPessoaFisicaId
            // 
            this.lblPessoaFisicaId.AutoSize = true;
            this.lblPessoaFisicaId.Location = new System.Drawing.Point(250, 56);
            this.lblPessoaFisicaId.Name = "lblPessoaFisicaId";
            this.lblPessoaFisicaId.Size = new System.Drawing.Size(103, 19);
            this.lblPessoaFisicaId.TabIndex = 7;
            this.lblPessoaFisicaId.Text = "Pessoa física Id";
            // 
            // grdVisitantes
            // 
            this.grdVisitantes.AllowUserToAddRows = false;
            this.grdVisitantes.AllowUserToDeleteRows = false;
            this.grdVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisitantes.Location = new System.Drawing.Point(4, 56);
            this.grdVisitantes.Name = "grdVisitantes";
            this.grdVisitantes.ReadOnly = true;
            this.grdVisitantes.RowHeadersWidth = 51;
            this.grdVisitantes.Size = new System.Drawing.Size(240, 279);
            this.grdVisitantes.TabIndex = 6;
            // 
            // lblTipoVisitante
            // 
            this.lblTipoVisitante.AutoSize = true;
            this.lblTipoVisitante.Location = new System.Drawing.Point(250, 115);
            this.lblTipoVisitante.Name = "lblTipoVisitante";
            this.lblTipoVisitante.Size = new System.Drawing.Size(88, 19);
            this.lblTipoVisitante.TabIndex = 10;
            this.lblTipoVisitante.Text = "Tipo visitante";
            // 
            // txtHabitacao
            // 
            this.txtHabitacao.Location = new System.Drawing.Point(250, 193);
            this.txtHabitacao.Name = "txtHabitacao";
            this.txtHabitacao.Size = new System.Drawing.Size(286, 26);
            this.txtHabitacao.TabIndex = 13;
            // 
            // lblHabitacao
            // 
            this.lblHabitacao.AutoSize = true;
            this.lblHabitacao.Location = new System.Drawing.Point(250, 171);
            this.lblHabitacao.Name = "lblHabitacao";
            this.lblHabitacao.Size = new System.Drawing.Size(71, 19);
            this.lblHabitacao.TabIndex = 12;
            this.lblHabitacao.Text = "Habitação";
            // 
            // cmbTipoVisitante
            // 
            this.cmbTipoVisitante.FormattingEnabled = true;
            this.cmbTipoVisitante.Location = new System.Drawing.Point(250, 137);
            this.cmbTipoVisitante.Name = "cmbTipoVisitante";
            this.cmbTipoVisitante.Size = new System.Drawing.Size(286, 27);
            this.cmbTipoVisitante.TabIndex = 14;
            // 
            // txtVeiculoId
            // 
            this.txtVeiculoId.Location = new System.Drawing.Point(250, 252);
            this.txtVeiculoId.Name = "txtVeiculoId";
            this.txtVeiculoId.Size = new System.Drawing.Size(286, 26);
            this.txtVeiculoId.TabIndex = 16;
            // 
            // lblVeiculoId
            // 
            this.lblVeiculoId.AutoSize = true;
            this.lblVeiculoId.Location = new System.Drawing.Point(250, 230);
            this.lblVeiculoId.Name = "lblVeiculoId";
            this.lblVeiculoId.Size = new System.Drawing.Size(70, 19);
            this.lblVeiculoId.TabIndex = 15;
            this.lblVeiculoId.Text = "Veículo Id";
            // 
            // frmVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 346);
            this.Controls.Add(this.txtVeiculoId);
            this.Controls.Add(this.lblVeiculoId);
            this.Controls.Add(this.cmbTipoVisitante);
            this.Controls.Add(this.txtHabitacao);
            this.Controls.Add(this.lblHabitacao);
            this.Controls.Add(this.lblTipoVisitante);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPessoaFisicaId);
            this.Controls.Add(this.lblPessoaFisicaId);
            this.Controls.Add(this.grdVisitantes);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVisitantes";
            this.Text = "Manutenção Visitantes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.TextBox txtPessoaFisicaId;
        private System.Windows.Forms.Label lblPessoaFisicaId;
        private System.Windows.Forms.DataGridView grdVisitantes;
        private System.Windows.Forms.Label lblTipoVisitante;
        private System.Windows.Forms.TextBox txtHabitacao;
        private System.Windows.Forms.Label lblHabitacao;
        private System.Windows.Forms.ComboBox cmbTipoVisitante;
        private System.Windows.Forms.TextBox txtVeiculoId;
        private System.Windows.Forms.Label lblVeiculoId;
    }
}