
namespace Projeto_LPRC5
{
    partial class frmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarca));
            this.barraManutencaoMarca = new System.Windows.Forms.ToolStrip();
            this.barbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barbtnFechar = new System.Windows.Forms.ToolStripButton();
            this.grdDadosMarca = new System.Windows.Forms.DataGridView();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barraManutencaoMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // barraManutencaoMarca
            // 
            this.barraManutencaoMarca.Dock = System.Windows.Forms.DockStyle.None;
            this.barraManutencaoMarca.ImageScalingSize = new System.Drawing.Size(33, 32);
            this.barraManutencaoMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnNovo,
            this.barbtnEditar,
            this.barbtnExcluir,
            this.barbtnSalvar,
            this.barbtnCancelar,
            this.barbtnFechar});
            this.barraManutencaoMarca.Location = new System.Drawing.Point(16, 9);
            this.barraManutencaoMarca.Name = "barraManutencaoMarca";
            this.barraManutencaoMarca.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.barraManutencaoMarca.Size = new System.Drawing.Size(266, 39);
            this.barraManutencaoMarca.TabIndex = 3;
            this.barraManutencaoMarca.Text = "toolStrip1";
            // 
            // barbtnNovo
            // 
            this.barbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNovo.Image")));
            this.barbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnNovo.Name = "barbtnNovo";
            this.barbtnNovo.Size = new System.Drawing.Size(37, 36);
            this.barbtnNovo.Text = "Novo";
            this.barbtnNovo.ToolTipText = "Adicionar Marca";
            this.barbtnNovo.Click += new System.EventHandler(this.barbtnNovo_Click_1);
            // 
            // barbtnEditar
            // 
            this.barbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditar.Image")));
            this.barbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnEditar.Name = "barbtnEditar";
            this.barbtnEditar.Size = new System.Drawing.Size(37, 36);
            this.barbtnEditar.Text = "Editar";
            this.barbtnEditar.ToolTipText = "Editar Marca";
            // 
            // barbtnExcluir
            // 
            this.barbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barbtnExcluir.Image")));
            this.barbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnExcluir.Name = "barbtnExcluir";
            this.barbtnExcluir.Size = new System.Drawing.Size(37, 36);
            this.barbtnExcluir.Text = "Excluir";
            this.barbtnExcluir.ToolTipText = "Excluir Marca";
            // 
            // barbtnSalvar
            // 
            this.barbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSalvar.Image")));
            this.barbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnSalvar.Name = "barbtnSalvar";
            this.barbtnSalvar.Size = new System.Drawing.Size(37, 36);
            this.barbtnSalvar.Text = "Salvar";
            this.barbtnSalvar.ToolTipText = "Salvar nova Marca";
            // 
            // barbtnCancelar
            // 
            this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelar.Image")));
            this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelar.Name = "barbtnCancelar";
            this.barbtnCancelar.Size = new System.Drawing.Size(37, 36);
            this.barbtnCancelar.Text = "Cancelar";
            this.barbtnCancelar.ToolTipText = "Cancelar ação";
            // 
            // barbtnFechar
            // 
            this.barbtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnFechar.Image")));
            this.barbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnFechar.Name = "barbtnFechar";
            this.barbtnFechar.Size = new System.Drawing.Size(37, 36);
            this.barbtnFechar.Text = "Fechar";
            this.barbtnFechar.ToolTipText = "Fechar";
            // 
            // grdDadosMarca
            // 
            this.grdDadosMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosMarca.Location = new System.Drawing.Point(16, 91);
            this.grdDadosMarca.Name = "grdDadosMarca";
            this.grdDadosMarca.RowHeadersWidth = 51;
            this.grdDadosMarca.Size = new System.Drawing.Size(364, 347);
            this.grdDadosMarca.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(179, 65);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(201, 20);
            this.txtMarca.TabIndex = 7;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca do veículo:";
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.grdDadosMarca);
            this.Controls.Add(this.barraManutencaoMarca);
            this.Name = "frmMarca";
            this.Text = "Manutenção Marca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            this.barraManutencaoMarca.ResumeLayout(false);
            this.barraManutencaoMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosMarca)).EndInit();
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
        private System.Windows.Forms.DataGridView grdDadosMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
    }
}