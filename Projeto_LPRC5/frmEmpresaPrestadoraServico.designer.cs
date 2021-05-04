
namespace Projeto_LPRC5
{
    partial class frmEmpresaPrestadoraServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresaPrestadoraServico));
            this.barraManutencaoMarca = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.grdDadosEmpresaPrestadoraServico = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDescricaoServico = new System.Windows.Forms.TextBox();
            this.txtDescricaoEndereco = new System.Windows.Forms.TextBox();
            this.txtDescricaoEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricaoTelefone = new System.Windows.Forms.TextBox();
            this.txtDescricaoDescricao = new System.Windows.Forms.RichTextBox();
            this.barraManutencaoMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosEmpresaPrestadoraServico)).BeginInit();
            this.SuspendLayout();
            // 
            // barraManutencaoMarca
            // 
            this.barraManutencaoMarca.Dock = System.Windows.Forms.DockStyle.None;
            this.barraManutencaoMarca.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraManutencaoMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnNovo,
            this.barbtnEditar,
            this.barbtnExcluir,
            this.barbtnSalvar,
            this.barbtnCancelar,
            this.barbtnFechar});
            this.barraManutencaoMarca.Location = new System.Drawing.Point(9, 9);
            this.barraManutencaoMarca.Name = "barraManutencaoMarca";
            this.barraManutencaoMarca.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.barraManutencaoMarca.Size = new System.Drawing.Size(229, 39);
            this.barraManutencaoMarca.TabIndex = 8;
            this.barraManutencaoMarca.Text = "toolStrip1";
            // 
            // barbtnNovo
            // 
            this.barbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNovo.Image")));
            this.barbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnNovo.Name = "barbtnNovo";
            this.barbtnNovo.Size = new System.Drawing.Size(36, 36);
            this.barbtnNovo.Text = "Novo";
            this.barbtnNovo.ToolTipText = "Adicionar";
            // 
            // barbtnEditar
            // 
            this.barbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditar.Image")));
            this.barbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnEditar.Name = "barbtnEditar";
            this.barbtnEditar.Size = new System.Drawing.Size(36, 36);
            this.barbtnEditar.Text = "Editar";
            this.barbtnEditar.ToolTipText = "Editar";
            // 
            // barbtnExcluir
            // 
            this.barbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barbtnExcluir.Image")));
            this.barbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnExcluir.Name = "barbtnExcluir";
            this.barbtnExcluir.Size = new System.Drawing.Size(36, 36);
            this.barbtnExcluir.Text = "Excluir";
            this.barbtnExcluir.ToolTipText = "Excluir";
            // 
            // barbtnSalvar
            // 
            this.barbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSalvar.Image")));
            this.barbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnSalvar.Name = "barbtnSalvar";
            this.barbtnSalvar.Size = new System.Drawing.Size(36, 36);
            this.barbtnSalvar.Text = "Salvar";
            this.barbtnSalvar.ToolTipText = "Salvar";
            // 
            // barbtnCancelar
            // 
            this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelar.Image")));
            this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelar.Name = "barbtnCancelar";
            this.barbtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.barbtnCancelar.Text = "Cancelar";
            this.barbtnCancelar.ToolTipText = "Cancelar ação";
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
            // grdDadosEmpresaPrestadoraServico
            // 
            this.grdDadosEmpresaPrestadoraServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosEmpresaPrestadoraServico.Location = new System.Drawing.Point(9, 77);
            this.grdDadosEmpresaPrestadoraServico.Name = "grdDadosEmpresaPrestadoraServico";
            this.grdDadosEmpresaPrestadoraServico.Size = new System.Drawing.Size(229, 372);
            this.grdDadosEmpresaPrestadoraServico.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 10;
            // 
            // txtDescricaoServico
            // 
            this.txtDescricaoServico.Location = new System.Drawing.Point(517, 146);
            this.txtDescricaoServico.Name = "txtDescricaoServico";
            this.txtDescricaoServico.Size = new System.Drawing.Size(153, 20);
            this.txtDescricaoServico.TabIndex = 12;
            // 
            // txtDescricaoEndereco
            // 
            this.txtDescricaoEndereco.Location = new System.Drawing.Point(314, 237);
            this.txtDescricaoEndereco.Name = "txtDescricaoEndereco";
            this.txtDescricaoEndereco.Size = new System.Drawing.Size(356, 20);
            this.txtDescricaoEndereco.TabIndex = 14;
            // 
            // txtDescricaoEmpresa
            // 
            this.txtDescricaoEmpresa.Location = new System.Drawing.Point(399, 77);
            this.txtDescricaoEmpresa.Name = "txtDescricaoEmpresa";
            this.txtDescricaoEmpresa.Size = new System.Drawing.Size(182, 20);
            this.txtDescricaoEmpresa.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descrição";
            // 
            // txtDescricaoTelefone
            // 
            this.txtDescricaoTelefone.Location = new System.Drawing.Point(314, 146);
            this.txtDescricaoTelefone.Name = "txtDescricaoTelefone";
            this.txtDescricaoTelefone.Size = new System.Drawing.Size(155, 20);
            this.txtDescricaoTelefone.TabIndex = 23;
            // 
            // txtDescricaoDescricao
            // 
            this.txtDescricaoDescricao.Location = new System.Drawing.Point(314, 337);
            this.txtDescricaoDescricao.Name = "txtDescricaoDescricao";
            this.txtDescricaoDescricao.Size = new System.Drawing.Size(356, 96);
            this.txtDescricaoDescricao.TabIndex = 24;
            this.txtDescricaoDescricao.Text = "";
            // 
            // frmEmpresaPrestadoraServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 462);
            this.Controls.Add(this.txtDescricaoDescricao);
            this.Controls.Add(this.txtDescricaoTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricaoEmpresa);
            this.Controls.Add(this.txtDescricaoEndereco);
            this.Controls.Add(this.txtDescricaoServico);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grdDadosEmpresaPrestadoraServico);
            this.Controls.Add(this.barraManutencaoMarca);
            this.Name = "frmEmpresaPrestadoraServico";
            this.Text = "Form1";
            this.barraManutencaoMarca.ResumeLayout(false);
            this.barraManutencaoMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosEmpresaPrestadoraServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraManutencaoMarca;
        private System.Windows.Forms.ToolStripButton barbtnNovo;
        private System.Windows.Forms.ToolStripButton barbtnEditar;
        private System.Windows.Forms.ToolStripButton barbtnExcluir;
        private System.Windows.Forms.ToolStripButton barbtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barbtnFechar;
        private System.Windows.Forms.DataGridView grdDadosEmpresaPrestadoraServico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDescricaoServico;
        private System.Windows.Forms.TextBox txtDescricaoEndereco;
        private System.Windows.Forms.TextBox txtDescricaoEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricaoTelefone;
        private System.Windows.Forms.RichTextBox txtDescricaoDescricao;
    }
}