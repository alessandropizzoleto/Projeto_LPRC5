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
            this.grdVisitantes = new System.Windows.Forms.DataGridView();
            this.txtNomeRegitro = new System.Windows.Forms.TextBox();
            this.lblNomeRegistro = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.cmbHabitacaoId = new System.Windows.Forms.ComboBox();
            this.cmbTipoVisitante = new System.Windows.Forms.ComboBox();
            this.lblHabitacao = new System.Windows.Forms.Label();
            this.lblTipoVisitante = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(268, 39);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grdVisitantes
            // 
            this.grdVisitantes.AllowUserToAddRows = false;
            this.grdVisitantes.AllowUserToDeleteRows = false;
            this.grdVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisitantes.Location = new System.Drawing.Point(4, 57);
            this.grdVisitantes.Name = "grdVisitantes";
            this.grdVisitantes.ReadOnly = true;
            this.grdVisitantes.RowHeadersWidth = 51;
            this.grdVisitantes.Size = new System.Drawing.Size(238, 294);
            this.grdVisitantes.TabIndex = 6;
            // 
            // txtNomeRegitro
            // 
            this.txtNomeRegitro.Location = new System.Drawing.Point(253, 81);
            this.txtNomeRegitro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeRegitro.Name = "txtNomeRegitro";
            this.txtNomeRegitro.Size = new System.Drawing.Size(185, 30);
            this.txtNomeRegitro.TabIndex = 45;
            // 
            // lblNomeRegistro
            // 
            this.lblNomeRegistro.AutoSize = true;
            this.lblNomeRegistro.Location = new System.Drawing.Point(249, 55);
            this.lblNomeRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeRegistro.Name = "lblNomeRegistro";
            this.lblNomeRegistro.Size = new System.Drawing.Size(129, 22);
            this.lblNomeRegistro.TabIndex = 44;
            this.lblNomeRegistro.Text = "Nome Registro";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(249, 321);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(189, 30);
            this.txtRg.TabIndex = 43;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(249, 295);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(32, 22);
            this.lblRg.TabIndex = 42;
            this.lblRg.Text = "Rg";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(249, 261);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(189, 30);
            this.txtCpf.TabIndex = 41;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(249, 235);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(39, 22);
            this.lblCpf.TabIndex = 40;
            this.lblCpf.Text = "Cpf";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(249, 201);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 30);
            this.txtEmail.TabIndex = 39;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(249, 175);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(253, 141);
            this.txtNomeSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(185, 30);
            this.txtNomeSocial.TabIndex = 37;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.Location = new System.Drawing.Point(249, 115);
            this.lblNomeSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(113, 22);
            this.lblNomeSocial.TabIndex = 36;
            this.lblNomeSocial.Text = "Nome Social";
            // 
            // cmbHabitacaoId
            // 
            this.cmbHabitacaoId.FormattingEnabled = true;
            this.cmbHabitacaoId.Location = new System.Drawing.Point(458, 139);
            this.cmbHabitacaoId.Name = "cmbHabitacaoId";
            this.cmbHabitacaoId.Size = new System.Drawing.Size(167, 30);
            this.cmbHabitacaoId.TabIndex = 51;
            // 
            // cmbTipoVisitante
            // 
            this.cmbTipoVisitante.FormattingEnabled = true;
            this.cmbTipoVisitante.Location = new System.Drawing.Point(458, 81);
            this.cmbTipoVisitante.Name = "cmbTipoVisitante";
            this.cmbTipoVisitante.Size = new System.Drawing.Size(167, 30);
            this.cmbTipoVisitante.TabIndex = 48;
            // 
            // lblHabitacao
            // 
            this.lblHabitacao.AutoSize = true;
            this.lblHabitacao.Location = new System.Drawing.Point(458, 114);
            this.lblHabitacao.Name = "lblHabitacao";
            this.lblHabitacao.Size = new System.Drawing.Size(112, 22);
            this.lblHabitacao.TabIndex = 47;
            this.lblHabitacao.Text = "Habitação Id";
            // 
            // lblTipoVisitante
            // 
            this.lblTipoVisitante.AutoSize = true;
            this.lblTipoVisitante.Location = new System.Drawing.Point(458, 57);
            this.lblTipoVisitante.Name = "lblTipoVisitante";
            this.lblTipoVisitante.Size = new System.Drawing.Size(119, 22);
            this.lblTipoVisitante.TabIndex = 46;
            this.lblTipoVisitante.Text = "Tipo visitante";
            // 
            // frmVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 359);
            this.Controls.Add(this.cmbHabitacaoId);
            this.Controls.Add(this.cmbTipoVisitante);
            this.Controls.Add(this.lblHabitacao);
            this.Controls.Add(this.lblTipoVisitante);
            this.Controls.Add(this.txtNomeRegitro);
            this.Controls.Add(this.lblNomeRegistro);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNomeSocial);
            this.Controls.Add(this.lblNomeSocial);
            this.Controls.Add(this.toolStrip1);
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
        private System.Windows.Forms.DataGridView grdVisitantes;
        private System.Windows.Forms.TextBox txtNomeRegitro;
        private System.Windows.Forms.Label lblNomeRegistro;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.ComboBox cmbHabitacaoId;
        private System.Windows.Forms.ComboBox cmbTipoVisitante;
        private System.Windows.Forms.Label lblHabitacao;
        private System.Windows.Forms.Label lblTipoVisitante;
    }
}