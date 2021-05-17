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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeriado));
            this.grdDadosFe = new System.Windows.Forms.DataGridView();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.dia = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.barManutencaoCor = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosFe)).BeginInit();
            this.barManutencaoCor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDadosFe
            // 
            this.grdDadosFe.AllowUserToAddRows = false;
            this.grdDadosFe.AllowUserToDeleteRows = false;
            this.grdDadosFe.AllowUserToResizeColumns = false;
            this.grdDadosFe.AllowUserToResizeRows = false;
            this.grdDadosFe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosFe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDadosFe.Location = new System.Drawing.Point(12, 41);
            this.grdDadosFe.Name = "grdDadosFe";
            this.grdDadosFe.ReadOnly = true;
            this.grdDadosFe.RowHeadersWidth = 51;
            this.grdDadosFe.Size = new System.Drawing.Size(240, 336);
            this.grdDadosFe.TabIndex = 1;
            this.grdDadosFe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosFe_CellClick);
            this.grdDadosFe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosFe_CellContentClick);
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Location = new System.Drawing.Point(258, 121);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(65, 30);
            this.txtDia.TabIndex = 3;
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.Location = new System.Drawing.Point(254, 97);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(45, 22);
            this.dia.TabIndex = 4;
            this.dia.Text = "Dia:";
            this.dia.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(329, 121);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(69, 30);
            this.txtMes.TabIndex = 5;
            // 
            // mes
            // 
            this.mes.AutoSize = true;
            this.mes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes.Location = new System.Drawing.Point(330, 97);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(50, 22);
            this.mes.TabIndex = 6;
            this.mes.Text = "Mês:";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descricao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(254, 40);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(124, 22);
            this.descricao.TabIndex = 7;
            this.descricao.Text = "Comemoração";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(258, 64);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 30);
            this.txtNome.TabIndex = 8;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.barManutencaoCor.Location = new System.Drawing.Point(-2, -1);
            this.barManutencaoCor.Name = "barManutencaoCor";
            this.barManutencaoCor.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.barManutencaoCor.Size = new System.Drawing.Size(230, 39);
            this.barManutencaoCor.TabIndex = 9;
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
            this.barbtnNovo.ToolTipText = "Adicionar Feriado";
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
            this.barbtnEditar.ToolTipText = "Editar Feriado";
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
            this.barbtnExcluir.ToolTipText = "Excluir Feriado";
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
            this.barbtnSalvar.ToolTipText = "Salvar novo Feriado";
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
            this.barbtnCancelar.ToolTipText = "Cancelar";
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
            this.barbtnFechar.ToolTipText = "Fechar";
            this.barbtnFechar.Click += new System.EventHandler(this.barbtnFechar_Click);
            // 
            // frmFeriado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 385);
            this.Controls.Add(this.barManutencaoCor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.grdDadosFe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFeriado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manutenção Feriado";
            this.Load += new System.EventHandler(this.frmFeriado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosFe)).EndInit();
            this.barManutencaoCor.ResumeLayout(false);
            this.barManutencaoCor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdDadosFe;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label dia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label mes;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStrip barManutencaoCor;
        private System.Windows.Forms.ToolStripButton barbtnNovo;
        private System.Windows.Forms.ToolStripButton barbtnEditar;
        private System.Windows.Forms.ToolStripButton barbtnExcluir;
        private System.Windows.Forms.ToolStripButton barbtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barbtnFechar;
    }
}