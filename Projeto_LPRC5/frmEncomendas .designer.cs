namespace Projeto_LPRC5
{
    partial class frmEncomendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncomendas));
            this.barManutencao = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.grdDadosCid = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblTipoEncomenda = new System.Windows.Forms.Label();
            this.txtTipoEncomenda = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lblRecebida = new System.Windows.Forms.Label();
            this.txtRecebida = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.lblEntreguePor = new System.Windows.Forms.Label();
            this.txtEntreguePor = new System.Windows.Forms.TextBox();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.TextBox();
            this.lblEntreguePara = new System.Windows.Forms.Label();
            this.txtEntreguePara = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
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
            // grdDadosCid
            // 
            this.grdDadosCid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosCid.Location = new System.Drawing.Point(12, 76);
            this.grdDadosCid.Name = "grdDadosCid";
            this.grdDadosCid.RowHeadersWidth = 51;
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
            // lblTipoEncomenda
            // 
            this.lblTipoEncomenda.AutoSize = true;
            this.lblTipoEncomenda.Location = new System.Drawing.Point(261, 76);
            this.lblTipoEncomenda.Name = "lblTipoEncomenda";
            this.lblTipoEncomenda.Size = new System.Drawing.Size(133, 19);
            this.lblTipoEncomenda.TabIndex = 3;
            this.lblTipoEncomenda.Text = "Tipo de Encomenda:";
            // 
            // txtTipoEncomenda
            // 
            this.txtTipoEncomenda.Location = new System.Drawing.Point(400, 73);
            this.txtTipoEncomenda.Name = "txtTipoEncomenda";
            this.txtTipoEncomenda.Size = new System.Drawing.Size(348, 26);
            this.txtTipoEncomenda.TabIndex = 4;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(262, 122);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(84, 19);
            this.lblDestinatario.TabIndex = 5;
            this.lblDestinatario.Text = "Destinatário:";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(401, 119);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(347, 26);
            this.txtDestinatario.TabIndex = 6;
            // 
            // lblRecebida
            // 
            this.lblRecebida.AutoSize = true;
            this.lblRecebida.Location = new System.Drawing.Point(262, 169);
            this.lblRecebida.Name = "lblRecebida";
            this.lblRecebida.Size = new System.Drawing.Size(95, 19);
            this.lblRecebida.TabIndex = 7;
            this.lblRecebida.Text = "Recebida Por:";
            // 
            // txtRecebida
            // 
            this.txtRecebida.Location = new System.Drawing.Point(401, 165);
            this.txtRecebida.Name = "txtRecebida";
            this.txtRecebida.Size = new System.Drawing.Size(347, 26);
            this.txtRecebida.TabIndex = 8;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(263, 214);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(111, 19);
            this.lblDataEntrada.TabIndex = 9;
            this.lblDataEntrada.Text = "Data da Entrada:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(400, 212);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(120, 26);
            this.txtDataEntrada.TabIndex = 10;
            // 
            // lblEntreguePor
            // 
            this.lblEntreguePor.AutoSize = true;
            this.lblEntreguePor.Location = new System.Drawing.Point(263, 260);
            this.lblEntreguePor.Name = "lblEntreguePor";
            this.lblEntreguePor.Size = new System.Drawing.Size(91, 19);
            this.lblEntreguePor.TabIndex = 11;
            this.lblEntreguePor.Text = "Entregue Por:";
            // 
            // txtEntreguePor
            // 
            this.txtEntreguePor.Location = new System.Drawing.Point(400, 258);
            this.txtEntreguePor.Name = "txtEntreguePor";
            this.txtEntreguePor.Size = new System.Drawing.Size(348, 26);
            this.txtEntreguePor.TabIndex = 12;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(262, 308);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(102, 19);
            this.lblDataSaida.TabIndex = 13;
            this.lblDataSaida.Text = "Data da Saída: ";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Location = new System.Drawing.Point(400, 305);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(120, 26);
            this.txtDataSaida.TabIndex = 14;
            // 
            // lblEntreguePara
            // 
            this.lblEntreguePara.AutoSize = true;
            this.lblEntreguePara.Location = new System.Drawing.Point(262, 355);
            this.lblEntreguePara.Name = "lblEntreguePara";
            this.lblEntreguePara.Size = new System.Drawing.Size(97, 19);
            this.lblEntreguePara.TabIndex = 15;
            this.lblEntreguePara.Text = "Entregue Para:";
            this.lblEntreguePara.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEntreguePara
            // 
            this.txtEntreguePara.Location = new System.Drawing.Point(400, 351);
            this.txtEntreguePara.Name = "txtEntreguePara";
            this.txtEntreguePara.Size = new System.Drawing.Size(347, 26);
            this.txtEntreguePara.TabIndex = 16;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(261, 400);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(63, 19);
            this.lblUnidade.TabIndex = 17;
            this.lblUnidade.Text = "Unidade:";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(400, 397);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(347, 26);
            this.txtUnidade.TabIndex = 18;
            // 
            // frmEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 438);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.txtEntreguePara);
            this.Controls.Add(this.lblEntreguePara);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.txtEntreguePor);
            this.Controls.Add(this.lblEntreguePor);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.txtRecebida);
            this.Controls.Add(this.lblRecebida);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txtTipoEncomenda);
            this.Controls.Add(this.lblTipoEncomenda);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.grdDadosCid);
            this.Controls.Add(this.barManutencao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEncomendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Encomendas";
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
        private System.Windows.Forms.Label lblTipoEncomenda;
        private System.Windows.Forms.TextBox txtTipoEncomenda;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblRecebida;
        private System.Windows.Forms.TextBox txtRecebida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.Label lblEntreguePor;
        private System.Windows.Forms.TextBox txtEntreguePor;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.TextBox txtDataSaida;
        private System.Windows.Forms.Label lblEntreguePara;
        private System.Windows.Forms.TextBox txtEntreguePara;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtUnidade;
    }
}