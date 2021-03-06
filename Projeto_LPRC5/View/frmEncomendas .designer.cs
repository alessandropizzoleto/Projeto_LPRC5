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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblRecebida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblEntreguePor = new System.Windows.Forms.Label();
            this.txtEntreguePor = new System.Windows.Forms.TextBox();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblEntreguePara = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.msktxtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.msktxtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.cmbDestinatario = new System.Windows.Forms.ComboBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.cmbMoradorRecebeu = new System.Windows.Forms.ComboBox();
            this.cmbHabitacao = new System.Windows.Forms.ComboBox();
            this.grdDadosEncomenda = new System.Windows.Forms.DataGridView();
            this.barManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosEncomenda)).BeginInit();
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
            this.barbtnNovo.ToolTipText = "Adicionar Encomenda";
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
            this.barbtnEditar.ToolTipText = "Editar Encomenda";
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
            this.barbtnExcluir.ToolTipText = "Excluir Encomenda";
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
            this.barbtnSalvar.ToolTipText = "Salvar nova Encomenda";
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
            this.barbtnFechar.ToolTipText = "Fechar Manutenção de Encomenda";
            this.barbtnFechar.Click += new System.EventHandler(this.barbtnFechar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(13, 41);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(215, 26);
            this.txtBusca.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(242, 222);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 19);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(400, 219);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(332, 26);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(242, 41);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(84, 19);
            this.lblDestinatario.TabIndex = 5;
            this.lblDestinatario.Text = "Destinatário:";
            // 
            // lblRecebida
            // 
            this.lblRecebida.AutoSize = true;
            this.lblRecebida.Location = new System.Drawing.Point(523, 40);
            this.lblRecebida.Name = "lblRecebida";
            this.lblRecebida.Size = new System.Drawing.Size(95, 19);
            this.lblRecebida.TabIndex = 7;
            this.lblRecebida.Text = "Recebida Por:";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(242, 86);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(111, 19);
            this.lblDataEntrada.TabIndex = 9;
            this.lblDataEntrada.Text = "Data da Entrada:";
            // 
            // lblEntreguePor
            // 
            this.lblEntreguePor.AutoSize = true;
            this.lblEntreguePor.Location = new System.Drawing.Point(242, 132);
            this.lblEntreguePor.Name = "lblEntreguePor";
            this.lblEntreguePor.Size = new System.Drawing.Size(149, 19);
            this.lblEntreguePor.TabIndex = 11;
            this.lblEntreguePor.Text = "Entregue pela empresa:";
            // 
            // txtEntreguePor
            // 
            this.txtEntreguePor.Location = new System.Drawing.Point(400, 129);
            this.txtEntreguePor.Name = "txtEntreguePor";
            this.txtEntreguePor.Size = new System.Drawing.Size(332, 26);
            this.txtEntreguePor.TabIndex = 12;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(516, 86);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(102, 19);
            this.lblDataSaida.TabIndex = 13;
            this.lblDataSaida.Text = "Data da Saída: ";
            // 
            // lblEntreguePara
            // 
            this.lblEntreguePara.AutoSize = true;
            this.lblEntreguePara.Location = new System.Drawing.Point(242, 173);
            this.lblEntreguePara.Name = "lblEntreguePara";
            this.lblEntreguePara.Size = new System.Drawing.Size(97, 19);
            this.lblEntreguePara.TabIndex = 15;
            this.lblEntreguePara.Text = "Entregue Para:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(529, 177);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 19);
            this.lblComplemento.TabIndex = 17;
            this.lblComplemento.Text = "Habitação:";
            // 
            // msktxtDataEntrada
            // 
            this.msktxtDataEntrada.Location = new System.Drawing.Point(400, 83);
            this.msktxtDataEntrada.Mask = "00/00/0000";
            this.msktxtDataEntrada.Name = "msktxtDataEntrada";
            this.msktxtDataEntrada.Size = new System.Drawing.Size(118, 26);
            this.msktxtDataEntrada.TabIndex = 19;
            this.msktxtDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtDataSaida
            // 
            this.msktxtDataSaida.Location = new System.Drawing.Point(616, 83);
            this.msktxtDataSaida.Mask = "00/00/0000";
            this.msktxtDataSaida.Name = "msktxtDataSaida";
            this.msktxtDataSaida.Size = new System.Drawing.Size(116, 26);
            this.msktxtDataSaida.TabIndex = 20;
            this.msktxtDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // cmbDestinatario
            // 
            this.cmbDestinatario.FormattingEnabled = true;
            this.cmbDestinatario.Location = new System.Drawing.Point(400, 38);
            this.cmbDestinatario.Name = "cmbDestinatario";
            this.cmbDestinatario.Size = new System.Drawing.Size(117, 27);
            this.cmbDestinatario.TabIndex = 21;
            this.cmbDestinatario.DropDown += new System.EventHandler(this.cmbDestinatario_DropDown);
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(616, 32);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(116, 27);
            this.cmbFuncionario.TabIndex = 22;
            this.cmbFuncionario.DropDown += new System.EventHandler(this.cmbFuncionario_DropDown);
            // 
            // cmbMoradorRecebeu
            // 
            this.cmbMoradorRecebeu.FormattingEnabled = true;
            this.cmbMoradorRecebeu.Location = new System.Drawing.Point(400, 174);
            this.cmbMoradorRecebeu.Name = "cmbMoradorRecebeu";
            this.cmbMoradorRecebeu.Size = new System.Drawing.Size(117, 27);
            this.cmbMoradorRecebeu.TabIndex = 23;
            this.cmbMoradorRecebeu.DropDown += new System.EventHandler(this.cmbMoradorRecebeu_DropDown);
            // 
            // cmbHabitacao
            // 
            this.cmbHabitacao.FormattingEnabled = true;
            this.cmbHabitacao.Location = new System.Drawing.Point(615, 173);
            this.cmbHabitacao.Name = "cmbHabitacao";
            this.cmbHabitacao.Size = new System.Drawing.Size(117, 27);
            this.cmbHabitacao.TabIndex = 24;
            this.cmbHabitacao.DropDown += new System.EventHandler(this.cmbHabitacao_DropDown);
            // 
            // grdDadosEncomenda
            // 
            this.grdDadosEncomenda.AllowUserToAddRows = false;
            this.grdDadosEncomenda.AllowUserToDeleteRows = false;
            this.grdDadosEncomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosEncomenda.Location = new System.Drawing.Point(13, 73);
            this.grdDadosEncomenda.Name = "grdDadosEncomenda";
            this.grdDadosEncomenda.ReadOnly = true;
            this.grdDadosEncomenda.RowHeadersWidth = 51;
            this.grdDadosEncomenda.Size = new System.Drawing.Size(215, 200);
            this.grdDadosEncomenda.TabIndex = 25;
            this.grdDadosEncomenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosEncomenda_CellClick);
            // 
            // frmEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 285);
            this.Controls.Add(this.grdDadosEncomenda);
            this.Controls.Add(this.cmbHabitacao);
            this.Controls.Add(this.cmbMoradorRecebeu);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.cmbDestinatario);
            this.Controls.Add(this.msktxtDataSaida);
            this.Controls.Add(this.msktxtDataEntrada);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblEntreguePara);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.txtEntreguePor);
            this.Controls.Add(this.lblEntreguePor);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblRecebida);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.barManutencao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEncomendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Encomendas";
            this.Load += new System.EventHandler(this.frmEncomendas_Load);
            this.barManutencao.ResumeLayout(false);
            this.barManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosEncomenda)).EndInit();
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
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblRecebida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblEntreguePor;
        private System.Windows.Forms.TextBox txtEntreguePor;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblEntreguePara;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.MaskedTextBox msktxtDataEntrada;
        private System.Windows.Forms.MaskedTextBox msktxtDataSaida;
        private System.Windows.Forms.ComboBox cmbDestinatario;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.ComboBox cmbMoradorRecebeu;
        private System.Windows.Forms.ComboBox cmbHabitacao;
        private System.Windows.Forms.DataGridView grdDadosEncomenda;
    }
}