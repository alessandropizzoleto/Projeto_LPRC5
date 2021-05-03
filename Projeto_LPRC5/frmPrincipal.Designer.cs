
namespace Projeto_LPRC5
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuCadastro = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClassificaPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.corToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastro.SuspendLayout();
            this.barMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.mnuCadastro.Location = new System.Drawing.Point(0, 0);
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuCadastro.Size = new System.Drawing.Size(956, 28);
            this.mnuCadastro.TabIndex = 0;
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTipoUsuario});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // mnuTipoUsuario
            // 
            this.mnuTipoUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeUsuárioToolStripMenuItem,
            this.mnuClassificaPessoa,
            this.corToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.estadoToolStripMenuItem,
            this.veículoModeloToolStripMenuItem,
            this.cidadeToolStripMenuItem});
            this.mnuTipoUsuario.Name = "mnuTipoUsuario";
            this.mnuTipoUsuario.Size = new System.Drawing.Size(224, 26);
            this.mnuTipoUsuario.Text = "Básico";
            // 
            // tipoDeUsuárioToolStripMenuItem
            // 
            this.tipoDeUsuárioToolStripMenuItem.Name = "tipoDeUsuárioToolStripMenuItem";
            this.tipoDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.tipoDeUsuárioToolStripMenuItem.Text = "Tipo de Usuário";
            this.tipoDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuárioToolStripMenuItem_Click);
            // 
            // mnuClassificaPessoa
            // 
            this.mnuClassificaPessoa.Name = "mnuClassificaPessoa";
            this.mnuClassificaPessoa.Size = new System.Drawing.Size(252, 26);
            this.mnuClassificaPessoa.Text = "Classificação de Pessoas";
            this.mnuClassificaPessoa.Click += new System.EventHandler(this.mnuClassificaPessoa_Click);
            // 
            // corToolStripMenuItem
            // 
            this.corToolStripMenuItem.Name = "corToolStripMenuItem";
            this.corToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.corToolStripMenuItem.Text = "Cor";
            this.corToolStripMenuItem.Click += new System.EventHandler(this.corToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.estadoToolStripMenuItem.Text = "Estado";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.estadoToolStripMenuItem_Click);
            // 
            // veículoModeloToolStripMenuItem
            // 
            this.veículoModeloToolStripMenuItem.Name = "veículoModeloToolStripMenuItem";
            this.veículoModeloToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.veículoModeloToolStripMenuItem.Text = "Veículo Modelo";
            this.veículoModeloToolStripMenuItem.Click += new System.EventHandler(this.veículoModeloToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcesso});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // mnuAcesso
            // 
            this.mnuAcesso.Name = "mnuAcesso";
            this.mnuAcesso.Size = new System.Drawing.Size(180, 26);
            this.mnuAcesso.Text = "Acesso SGBD";
            this.mnuAcesso.Click += new System.EventHandler(this.mnuAcesso_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(131, 26);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // barMenu
            // 
            this.barMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.barMenu.Location = new System.Drawing.Point(0, 28);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(956, 39);
            this.barMenu.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 548);
            this.Controls.Add(this.barMenu);
            this.Controls.Add(this.mnuCadastro);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuCadastro;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "Software de Controle de Condomínio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuCadastro.ResumeLayout(false);
            this.mnuCadastro.PerformLayout();
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCadastro;
        private System.Windows.Forms.ToolStrip barMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTipoUsuario;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClassificaPessoa;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAcesso;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem corToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
    }
}

