namespace Projeto_LPRC5.View
{
    partial class frmPrestador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestador));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.txtPJuridicaId = new System.Windows.Forms.TextBox();
            this.lblPJuridicaId = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.grdVisitantes = new System.Windows.Forms.DataGridView();
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
            this.toolStrip1.Location = new System.Drawing.Point(8, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(260, 39);
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
            // txtPJuridicaId
            // 
            this.txtPJuridicaId.Location = new System.Drawing.Point(255, 77);
            this.txtPJuridicaId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPJuridicaId.Name = "txtPJuridicaId";
            this.txtPJuridicaId.Size = new System.Drawing.Size(255, 26);
            this.txtPJuridicaId.TabIndex = 8;
            // 
            // lblPJuridicaId
            // 
            this.lblPJuridicaId.AutoSize = true;
            this.lblPJuridicaId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPJuridicaId.Location = new System.Drawing.Point(249, 45);
            this.lblPJuridicaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPJuridicaId.Name = "lblPJuridicaId";
            this.lblPJuridicaId.Size = new System.Drawing.Size(119, 19);
            this.lblPJuridicaId.TabIndex = 7;
            this.lblPJuridicaId.Text = "Pessoa Jurídica Id";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(255, 152);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 26);
            this.txtDescricao.TabIndex = 13;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(255, 120);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 19);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição";
            // 
            // grdVisitantes
            // 
            this.grdVisitantes.AllowUserToAddRows = false;
            this.grdVisitantes.AllowUserToDeleteRows = false;
            this.grdVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisitantes.Location = new System.Drawing.Point(8, 46);
            this.grdVisitantes.Name = "grdVisitantes";
            this.grdVisitantes.ReadOnly = true;
            this.grdVisitantes.RowHeadersWidth = 51;
            this.grdVisitantes.Size = new System.Drawing.Size(240, 279);
            this.grdVisitantes.TabIndex = 14;
            // 
            // frmPrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 346);
            this.Controls.Add(this.grdVisitantes);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPJuridicaId);
            this.Controls.Add(this.lblPJuridicaId);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrestador";
            this.Text = "Manutenção Prestador";
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
        private System.Windows.Forms.TextBox txtPJuridicaId;
        private System.Windows.Forms.Label lblPJuridicaId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridView grdVisitantes;
    }
}