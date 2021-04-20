namespace Projeto_LPRC5
{
    partial class frmFeriado
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
            this.barManutencao = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.grdDadosCid = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.textDia = new System.Windows.Forms.TextBox();
            this.dia = new System.Windows.Forms.Label();
            this.textMes = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
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
            this.barManutencao.Size = new System.Drawing.Size(150, 25);
            this.barManutencao.TabIndex = 0;
            this.barManutencao.Text = "toolStrip1";
            // 
            // barbtnNovo
            // 
            this.barbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnNovo.Name = "barbtnNovo";
            this.barbtnNovo.Size = new System.Drawing.Size(23, 22);
            this.barbtnNovo.Text = "Novo";
            this.barbtnNovo.ToolTipText = "Adicionar Cidade";
            this.barbtnNovo.Click += new System.EventHandler(this.barbtnNovo_Click);
            // 
            // barbtnEditar
            // 
            this.barbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnEditar.Name = "barbtnEditar";
            this.barbtnEditar.Size = new System.Drawing.Size(23, 22);
            this.barbtnEditar.Text = "Editar";
            this.barbtnEditar.ToolTipText = "Editar Cidade";
            this.barbtnEditar.Click += new System.EventHandler(this.barbtnEditar_Click);
            // 
            // barbtnExcluir
            // 
            this.barbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnExcluir.Name = "barbtnExcluir";
            this.barbtnExcluir.Size = new System.Drawing.Size(23, 22);
            this.barbtnExcluir.Text = "Excluir";
            this.barbtnExcluir.ToolTipText = "Excluir Cidade";
            this.barbtnExcluir.Click += new System.EventHandler(this.barbtnExcluir_Click);
            // 
            // barbtnSalvar
            // 
            this.barbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnSalvar.Name = "barbtnSalvar";
            this.barbtnSalvar.Size = new System.Drawing.Size(23, 22);
            this.barbtnSalvar.Text = "Salvar";
            this.barbtnSalvar.ToolTipText = "Salvar nova Cidade";
            this.barbtnSalvar.Click += new System.EventHandler(this.barbtnSalvar_Click);
            // 
            // barbtnCancelar
            // 
            this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelar.Name = "barbtnCancelar";
            this.barbtnCancelar.Size = new System.Drawing.Size(23, 22);
            this.barbtnCancelar.Text = "Cancelar";
            this.barbtnCancelar.ToolTipText = "Cancela a operação de conclusão ou edição";
            this.barbtnCancelar.Click += new System.EventHandler(this.barbtnCancelar_Click);
            // 
            // barbtnFechar
            // 
            this.barbtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnFechar.Name = "barbtnFechar";
            this.barbtnFechar.Size = new System.Drawing.Size(23, 22);
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
            // textDia
            // 
            this.textDia.Location = new System.Drawing.Point(297, 76);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(104, 26);
            this.textDia.TabIndex = 3;
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.Location = new System.Drawing.Point(332, 52);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(39, 21);
            this.dia.TabIndex = 4;
            this.dia.Text = "Dia:";
            this.dia.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMes
            // 
            this.textMes.Location = new System.Drawing.Point(514, 76);
            this.textMes.Name = "textMes";
            this.textMes.Size = new System.Drawing.Size(104, 26);
            this.textMes.TabIndex = 5;
            // 
            // mes
            // 
            this.mes.AutoSize = true;
            this.mes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes.Location = new System.Drawing.Point(543, 52);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(46, 21);
            this.mes.TabIndex = 6;
            this.mes.Text = "Mês:";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descricao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(415, 134);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(89, 21);
            this.descricao.TabIndex = 7;
            this.descricao.Text = "Descrição:";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(297, 158);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(321, 116);
            this.textDescricao.TabIndex = 8;
            this.textDescricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmFeriado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 438);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.textMes);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.grdDadosCid);
            this.Controls.Add(this.barManutencao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFeriado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Feriado";
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
        private System.Windows.Forms.TextBox textDia;
        private System.Windows.Forms.Label dia;
        private System.Windows.Forms.TextBox textMes;
        private System.Windows.Forms.Label mes;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.TextBox textDescricao;
    }
}