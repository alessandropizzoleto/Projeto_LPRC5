
namespace Projeto_LPRC5
{
    partial class frmVisitantePrestador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitantePrestador));
            this.grdDadosVisitante = new System.Windows.Forms.DataGridView();
            this.txtBuscaCor = new System.Windows.Forms.TextBox();
            this.barManutencaoCor = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.txtNomeVisitante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.chkVisitante = new System.Windows.Forms.CheckBox();
            this.chkPrestador = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.chkVeiculo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosVisitante)).BeginInit();
            this.barManutencaoCor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDadosVisitante
            // 
            this.grdDadosVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosVisitante.Location = new System.Drawing.Point(20, 127);
            this.grdDadosVisitante.Margin = new System.Windows.Forms.Padding(6);
            this.grdDadosVisitante.Name = "grdDadosVisitante";
            this.grdDadosVisitante.RowHeadersWidth = 51;
            this.grdDadosVisitante.Size = new System.Drawing.Size(304, 377);
            this.grdDadosVisitante.TabIndex = 7;
            // 
            // txtBuscaCor
            // 
            this.txtBuscaCor.Location = new System.Drawing.Point(22, 80);
            this.txtBuscaCor.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscaCor.Name = "txtBuscaCor";
            this.txtBuscaCor.Size = new System.Drawing.Size(302, 30);
            this.txtBuscaCor.TabIndex = 6;
            // 
            // barManutencaoCor
            // 
            this.barManutencaoCor.Dock = System.Windows.Forms.DockStyle.None;
            this.barManutencaoCor.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barManutencaoCor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnNovo,
            this.barbtnEditar,
            this.barbtnExcluir,
            this.barbtnSalvar,
            this.barbtnCancelar,
            this.barbtnFechar});
            this.barManutencaoCor.Location = new System.Drawing.Point(3, 18);
            this.barManutencaoCor.Name = "barManutencaoCor";
            this.barManutencaoCor.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.barManutencaoCor.Size = new System.Drawing.Size(231, 39);
            this.barManutencaoCor.TabIndex = 5;
            this.barManutencaoCor.Text = "toolStrip1";
            // 
            // barbtnNovo
            // 
            this.barbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNovo.Image")));
            this.barbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnNovo.Name = "barbtnNovo";
            this.barbtnNovo.Size = new System.Drawing.Size(36, 36);
            this.barbtnNovo.Text = "Novo";
            this.barbtnNovo.ToolTipText = "Adicionar Cor";
            // 
            // barbtnEditar
            // 
            this.barbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditar.Image")));
            this.barbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnEditar.Name = "barbtnEditar";
            this.barbtnEditar.Size = new System.Drawing.Size(36, 36);
            this.barbtnEditar.Text = "Editar";
            this.barbtnEditar.ToolTipText = "Editar Cor";
            // 
            // barbtnExcluir
            // 
            this.barbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barbtnExcluir.Image")));
            this.barbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnExcluir.Name = "barbtnExcluir";
            this.barbtnExcluir.Size = new System.Drawing.Size(36, 36);
            this.barbtnExcluir.Text = "Excluir";
            this.barbtnExcluir.ToolTipText = "Excluir Cor";
            // 
            // barbtnSalvar
            // 
            this.barbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSalvar.Image")));
            this.barbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnSalvar.Name = "barbtnSalvar";
            this.barbtnSalvar.Size = new System.Drawing.Size(36, 36);
            this.barbtnSalvar.Text = "Salvar";
            this.barbtnSalvar.ToolTipText = "Salvar nova Cor";
            // 
            // barbtnCancelar
            // 
            this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelar.Image")));
            this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelar.Name = "barbtnCancelar";
            this.barbtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.barbtnCancelar.Text = "Cancelar";
            this.barbtnCancelar.ToolTipText = "Cancelar";
            // 
            // barbtnFechar
            // 
            this.barbtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnFechar.Image")));
            this.barbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnFechar.Name = "barbtnFechar";
            this.barbtnFechar.Size = new System.Drawing.Size(36, 36);
            this.barbtnFechar.Text = "Fechar";
            this.barbtnFechar.ToolTipText = "Fechar";
            // 
            // txtNomeVisitante
            // 
            this.txtNomeVisitante.Location = new System.Drawing.Point(367, 80);
            this.txtNomeVisitante.Margin = new System.Windows.Forms.Padding(6);
            this.txtNomeVisitante.Name = "txtNomeVisitante";
            this.txtNomeVisitante.Size = new System.Drawing.Size(356, 30);
            this.txtNomeVisitante.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(366, 148);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(6);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(356, 30);
            this.txtCPF.TabIndex = 10;
            // 
            // chkVisitante
            // 
            this.chkVisitante.AutoSize = true;
            this.chkVisitante.Location = new System.Drawing.Point(369, 205);
            this.chkVisitante.Name = "chkVisitante";
            this.chkVisitante.Size = new System.Drawing.Size(106, 26);
            this.chkVisitante.TabIndex = 12;
            this.chkVisitante.Text = "Visitante ";
            this.chkVisitante.UseVisualStyleBackColor = true;
            // 
            // chkPrestador
            // 
            this.chkPrestador.AutoSize = true;
            this.chkPrestador.Location = new System.Drawing.Point(498, 205);
            this.chkPrestador.Name = "chkPrestador";
            this.chkPrestador.Size = new System.Drawing.Size(196, 26);
            this.chkPrestador.TabIndex = 13;
            this.chkPrestador.Text = "Prestador de serviço";
            this.chkPrestador.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome Empresa:";
            // 
            // textNomeEmpresa
            // 
            this.textNomeEmpresa.Location = new System.Drawing.Point(363, 271);
            this.textNomeEmpresa.Margin = new System.Windows.Forms.Padding(6);
            this.textNomeEmpresa.Name = "textNomeEmpresa";
            this.textNomeEmpresa.Size = new System.Drawing.Size(356, 30);
            this.textNomeEmpresa.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vínculo do Visitante:";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(363, 346);
            this.txtVeiculo.Margin = new System.Windows.Forms.Padding(6);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(356, 30);
            this.txtVeiculo.TabIndex = 16;
            // 
            // chkVeiculo
            // 
            this.chkVeiculo.AutoSize = true;
            this.chkVeiculo.Location = new System.Drawing.Point(366, 399);
            this.chkVeiculo.Name = "chkVeiculo";
            this.chkVeiculo.Size = new System.Drawing.Size(156, 26);
            this.chkVeiculo.TabIndex = 18;
            this.chkVeiculo.Text = "Usando Veículo";
            this.chkVeiculo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Placa do Veículo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(363, 468);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(356, 30);
            this.txtPlaca.TabIndex = 19;
            // 
            // frmVisitantePrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.chkVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNomeEmpresa);
            this.Controls.Add(this.chkPrestador);
            this.Controls.Add(this.chkVisitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeVisitante);
            this.Controls.Add(this.grdDadosVisitante);
            this.Controls.Add(this.txtBuscaCor);
            this.Controls.Add(this.barManutencaoCor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVisitantePrestador";
            this.Text = "Cadastro Visitante / Prestador de Serviço";
            this.Load += new System.EventHandler(this.frmVisitantePrestador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosVisitante)).EndInit();
            this.barManutencaoCor.ResumeLayout(false);
            this.barManutencaoCor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDadosVisitante;
        private System.Windows.Forms.TextBox txtBuscaCor;
        private System.Windows.Forms.ToolStrip barManutencaoCor;
        private System.Windows.Forms.ToolStripButton barbtnNovo;
        private System.Windows.Forms.ToolStripButton barbtnEditar;
        private System.Windows.Forms.ToolStripButton barbtnExcluir;
        private System.Windows.Forms.ToolStripButton barbtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barbtnFechar;
        private System.Windows.Forms.TextBox txtNomeVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.CheckBox chkVisitante;
        private System.Windows.Forms.CheckBox chkPrestador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNomeEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.CheckBox chkVeiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}