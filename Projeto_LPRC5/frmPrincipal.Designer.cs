
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassificaPessoa));
            this.mnuCadastro = new System.Windows.Forms.MenuStrip();
            this.barMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.barMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCadastro.Location = new System.Drawing.Point(0, 0);
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(956, 24);
            this.mnuCadastro.TabIndex = 0;
            // 
            // barMenu
            // 
            this.barMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.barMenu.Location = new System.Drawing.Point(0, 24);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 548);
            this.Controls.Add(this.barMenu);
            this.Controls.Add(this.mnuCadastro);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuCadastro;
            this.Name = "frmPrincipal";
            this.Text = "Software de Controle de Condomínio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCadastro;
        private System.Windows.Forms.ToolStrip barMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

