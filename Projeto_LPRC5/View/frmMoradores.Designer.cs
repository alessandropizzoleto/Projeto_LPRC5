namespace Projeto_LPRC5
{
    partial class frmMoradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoradores));
            this.barManutencao = new System.Windows.Forms.ToolStrip();
            this.barbtnnovomorad = new System.Windows.Forms.ToolStripButton();
            this.barbtneditarmorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnexcluirmorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnsalvarmorad = new System.Windows.Forms.ToolStripButton();
            this.barbtncancelarmorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnfecharmorad = new System.Windows.Forms.ToolStripButton();
            this.lblnomemorad = new System.Windows.Forms.Label();
            this.lblrgmorad = new System.Windows.Forms.Label();
            this.lblcpfmorad = new System.Windows.Forms.Label();
            this.gtxtdadosmorad = new System.Windows.Forms.GroupBox();
            this.comboxhabid = new System.Windows.Forms.ComboBox();
            this.lblhabid = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.bttadcfotomorad = new System.Windows.Forms.Button();
            this.picboxfotomorad = new System.Windows.Forms.PictureBox();
            this.txtnomesocial = new System.Windows.Forms.TextBox();
            this.lblnomesocial = new System.Windows.Forms.Label();
            this.mtxtcpfmorad = new System.Windows.Forms.MaskedTextBox();
            this.mtxtrgmorad = new System.Windows.Forms.MaskedTextBox();
            this.txtnomemorad = new System.Windows.Forms.TextBox();
            this.grddadosmorad = new System.Windows.Forms.DataGridView();
            this.barManutencao.SuspendLayout();
            this.gtxtdadosmorad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxfotomorad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddadosmorad)).BeginInit();
            this.SuspendLayout();
            // 
            // barManutencao
            // 
            this.barManutencao.Dock = System.Windows.Forms.DockStyle.None;
            this.barManutencao.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barManutencao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnnovomorad,
            this.barbtneditarmorad,
            this.barbtnexcluirmorad,
            this.barbtnsalvarmorad,
            this.barbtncancelarmorad,
            this.barbtnfecharmorad});
            this.barManutencao.Location = new System.Drawing.Point(2, 0);
            this.barManutencao.Name = "barManutencao";
            this.barManutencao.Size = new System.Drawing.Size(228, 39);
            this.barManutencao.TabIndex = 1;
            this.barManutencao.Text = "toolStrip1";
            // 
            // barbtnnovomorad
            // 
            this.barbtnnovomorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnnovomorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnnovomorad.Image")));
            this.barbtnnovomorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnnovomorad.Name = "barbtnnovomorad";
            this.barbtnnovomorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnnovomorad.Text = "Novo";
            this.barbtnnovomorad.ToolTipText = "Adicionar Cidade";
            this.barbtnnovomorad.Click += new System.EventHandler(this.barbtnnovomorad_Click);
            // 
            // barbtneditarmorad
            // 
            this.barbtneditarmorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtneditarmorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtneditarmorad.Image")));
            this.barbtneditarmorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtneditarmorad.Name = "barbtneditarmorad";
            this.barbtneditarmorad.Size = new System.Drawing.Size(36, 36);
            this.barbtneditarmorad.Text = "Editar";
            this.barbtneditarmorad.ToolTipText = "Editar Cidade";
            this.barbtneditarmorad.Click += new System.EventHandler(this.barbtneditarmorad_Click);
            // 
            // barbtnexcluirmorad
            // 
            this.barbtnexcluirmorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnexcluirmorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnexcluirmorad.Image")));
            this.barbtnexcluirmorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnexcluirmorad.Name = "barbtnexcluirmorad";
            this.barbtnexcluirmorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnexcluirmorad.Text = "Excluir";
            this.barbtnexcluirmorad.ToolTipText = "Excluir Cidade";
            this.barbtnexcluirmorad.Click += new System.EventHandler(this.barbtnexcluirmorad_Click);
            // 
            // barbtnsalvarmorad
            // 
            this.barbtnsalvarmorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnsalvarmorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnsalvarmorad.Image")));
            this.barbtnsalvarmorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnsalvarmorad.Name = "barbtnsalvarmorad";
            this.barbtnsalvarmorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnsalvarmorad.Text = "Salvar";
            this.barbtnsalvarmorad.ToolTipText = "Salvar nova Cidade";
            this.barbtnsalvarmorad.Click += new System.EventHandler(this.barbtnsalvarmorad_Click);
            // 
            // barbtncancelarmorad
            // 
            this.barbtncancelarmorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtncancelarmorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtncancelarmorad.Image")));
            this.barbtncancelarmorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtncancelarmorad.Name = "barbtncancelarmorad";
            this.barbtncancelarmorad.Size = new System.Drawing.Size(36, 36);
            this.barbtncancelarmorad.Text = "Cancelar";
            this.barbtncancelarmorad.ToolTipText = "Cancela a operação de conclusão ou edição";
            this.barbtncancelarmorad.Click += new System.EventHandler(this.barbtncancelarmorad_Click);
            // 
            // barbtnfecharmorad
            // 
            this.barbtnfecharmorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnfecharmorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnfecharmorad.Image")));
            this.barbtnfecharmorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnfecharmorad.Name = "barbtnfecharmorad";
            this.barbtnfecharmorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnfecharmorad.Text = "Fechar";
            this.barbtnfecharmorad.ToolTipText = "Fechar Manutenção de Cidade";
            this.barbtnfecharmorad.Click += new System.EventHandler(this.barbtnfecharmorad_Click);
            // 
            // lblnomemorad
            // 
            this.lblnomemorad.AutoSize = true;
            this.lblnomemorad.Location = new System.Drawing.Point(4, 31);
            this.lblnomemorad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnomemorad.Name = "lblnomemorad";
            this.lblnomemorad.Size = new System.Drawing.Size(106, 17);
            this.lblnomemorad.TabIndex = 3;
            this.lblnomemorad.Text = "Nome Registro:";
            // 
            // lblrgmorad
            // 
            this.lblrgmorad.AutoSize = true;
            this.lblrgmorad.Location = new System.Drawing.Point(11, 125);
            this.lblrgmorad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrgmorad.Name = "lblrgmorad";
            this.lblrgmorad.Size = new System.Drawing.Size(33, 17);
            this.lblrgmorad.TabIndex = 4;
            this.lblrgmorad.Text = "RG:";
            // 
            // lblcpfmorad
            // 
            this.lblcpfmorad.AutoSize = true;
            this.lblcpfmorad.Location = new System.Drawing.Point(11, 154);
            this.lblcpfmorad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcpfmorad.Name = "lblcpfmorad";
            this.lblcpfmorad.Size = new System.Drawing.Size(38, 17);
            this.lblcpfmorad.TabIndex = 5;
            this.lblcpfmorad.Text = "CPF:";
            // 
            // gtxtdadosmorad
            // 
            this.gtxtdadosmorad.Controls.Add(this.comboxhabid);
            this.gtxtdadosmorad.Controls.Add(this.lblhabid);
            this.gtxtdadosmorad.Controls.Add(this.txtemail);
            this.gtxtdadosmorad.Controls.Add(this.lblemail);
            this.gtxtdadosmorad.Controls.Add(this.bttadcfotomorad);
            this.gtxtdadosmorad.Controls.Add(this.picboxfotomorad);
            this.gtxtdadosmorad.Controls.Add(this.txtnomesocial);
            this.gtxtdadosmorad.Controls.Add(this.lblnomesocial);
            this.gtxtdadosmorad.Controls.Add(this.mtxtcpfmorad);
            this.gtxtdadosmorad.Controls.Add(this.mtxtrgmorad);
            this.gtxtdadosmorad.Controls.Add(this.txtnomemorad);
            this.gtxtdadosmorad.Controls.Add(this.lblnomemorad);
            this.gtxtdadosmorad.Controls.Add(this.lblrgmorad);
            this.gtxtdadosmorad.Controls.Add(this.lblcpfmorad);
            this.gtxtdadosmorad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtdadosmorad.Location = new System.Drawing.Point(383, 34);
            this.gtxtdadosmorad.Margin = new System.Windows.Forms.Padding(2);
            this.gtxtdadosmorad.Name = "gtxtdadosmorad";
            this.gtxtdadosmorad.Padding = new System.Windows.Forms.Padding(2);
            this.gtxtdadosmorad.Size = new System.Drawing.Size(383, 334);
            this.gtxtdadosmorad.TabIndex = 10;
            this.gtxtdadosmorad.TabStop = false;
            this.gtxtdadosmorad.Text = "Dados Morador:";
            // 
            // comboxhabid
            // 
            this.comboxhabid.FormattingEnabled = true;
            this.comboxhabid.Location = new System.Drawing.Point(277, 125);
            this.comboxhabid.Margin = new System.Windows.Forms.Padding(2);
            this.comboxhabid.Name = "comboxhabid";
            this.comboxhabid.Size = new System.Drawing.Size(92, 25);
            this.comboxhabid.TabIndex = 26;
            // 
            // lblhabid
            // 
            this.lblhabid.AutoSize = true;
            this.lblhabid.Location = new System.Drawing.Point(188, 128);
            this.lblhabid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhabid.Name = "lblhabid";
            this.lblhabid.Size = new System.Drawing.Size(93, 17);
            this.lblhabid.TabIndex = 25;
            this.lblhabid.Text = "Habitação ID:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(107, 88);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(253, 23);
            this.txtemail.TabIndex = 24;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(4, 90);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 17);
            this.lblemail.TabIndex = 23;
            this.lblemail.Text = "E-mail:";
            // 
            // bttadcfotomorad
            // 
            this.bttadcfotomorad.Location = new System.Drawing.Point(70, 307);
            this.bttadcfotomorad.Margin = new System.Windows.Forms.Padding(2);
            this.bttadcfotomorad.Name = "bttadcfotomorad";
            this.bttadcfotomorad.Size = new System.Drawing.Size(62, 22);
            this.bttadcfotomorad.TabIndex = 22;
            this.bttadcfotomorad.Text = "Inserir";
            this.bttadcfotomorad.UseVisualStyleBackColor = true;
            // 
            // picboxfotomorad
            // 
            this.picboxfotomorad.Location = new System.Drawing.Point(14, 187);
            this.picboxfotomorad.Margin = new System.Windows.Forms.Padding(2);
            this.picboxfotomorad.Name = "picboxfotomorad";
            this.picboxfotomorad.Size = new System.Drawing.Size(116, 115);
            this.picboxfotomorad.TabIndex = 21;
            this.picboxfotomorad.TabStop = false;
            // 
            // txtnomesocial
            // 
            this.txtnomesocial.Location = new System.Drawing.Point(107, 56);
            this.txtnomesocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomesocial.Name = "txtnomesocial";
            this.txtnomesocial.Size = new System.Drawing.Size(253, 23);
            this.txtnomesocial.TabIndex = 20;
            // 
            // lblnomesocial
            // 
            this.lblnomesocial.AutoSize = true;
            this.lblnomesocial.Location = new System.Drawing.Point(4, 62);
            this.lblnomesocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnomesocial.Name = "lblnomesocial";
            this.lblnomesocial.Size = new System.Drawing.Size(91, 17);
            this.lblnomesocial.TabIndex = 19;
            this.lblnomesocial.Text = "Nome Social:";
            // 
            // mtxtcpfmorad
            // 
            this.mtxtcpfmorad.Location = new System.Drawing.Point(70, 152);
            this.mtxtcpfmorad.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtcpfmorad.Mask = "000.000.000-00";
            this.mtxtcpfmorad.Name = "mtxtcpfmorad";
            this.mtxtcpfmorad.Size = new System.Drawing.Size(105, 23);
            this.mtxtcpfmorad.TabIndex = 15;
            // 
            // mtxtrgmorad
            // 
            this.mtxtrgmorad.Location = new System.Drawing.Point(70, 123);
            this.mtxtrgmorad.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtrgmorad.Mask = "00.000.000-0";
            this.mtxtrgmorad.Name = "mtxtrgmorad";
            this.mtxtrgmorad.Size = new System.Drawing.Size(105, 23);
            this.mtxtrgmorad.TabIndex = 14;
            // 
            // txtnomemorad
            // 
            this.txtnomemorad.Location = new System.Drawing.Point(107, 25);
            this.txtnomemorad.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomemorad.Name = "txtnomemorad";
            this.txtnomemorad.Size = new System.Drawing.Size(253, 23);
            this.txtnomemorad.TabIndex = 9;
            // 
            // grddadosmorad
            // 
            this.grddadosmorad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddadosmorad.Location = new System.Drawing.Point(2, 50);
            this.grddadosmorad.Margin = new System.Windows.Forms.Padding(2);
            this.grddadosmorad.Name = "grddadosmorad";
            this.grddadosmorad.RowHeadersWidth = 51;
            this.grddadosmorad.Size = new System.Drawing.Size(364, 334);
            this.grddadosmorad.TabIndex = 2;
            this.grddadosmorad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddadosmorad_CellClick);
            // 
            // frmMoradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 406);
            this.Controls.Add(this.gtxtdadosmorad);
            this.Controls.Add(this.grddadosmorad);
            this.Controls.Add(this.barManutencao);
            this.Name = "frmMoradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manutenção Moradores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barManutencao.ResumeLayout(false);
            this.barManutencao.PerformLayout();
            this.gtxtdadosmorad.ResumeLayout(false);
            this.gtxtdadosmorad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxfotomorad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddadosmorad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barManutencao;
        private System.Windows.Forms.ToolStripButton barbtnnovomorad;
        private System.Windows.Forms.ToolStripButton barbtneditarmorad;
        private System.Windows.Forms.ToolStripButton barbtnexcluirmorad;
        private System.Windows.Forms.ToolStripButton barbtnsalvarmorad;
        private System.Windows.Forms.ToolStripButton barbtncancelarmorad;
        private System.Windows.Forms.ToolStripButton barbtnfecharmorad;
        private System.Windows.Forms.Label lblnomemorad;
        private System.Windows.Forms.Label lblrgmorad;
        private System.Windows.Forms.Label lblcpfmorad;
        private System.Windows.Forms.GroupBox gtxtdadosmorad;
        private System.Windows.Forms.TextBox txtnomemorad;
        private System.Windows.Forms.MaskedTextBox mtxtcpfmorad;
        private System.Windows.Forms.MaskedTextBox mtxtrgmorad;
        private System.Windows.Forms.Button bttadcfotomorad;
        private System.Windows.Forms.PictureBox picboxfotomorad;
        private System.Windows.Forms.TextBox txtnomesocial;
        private System.Windows.Forms.Label lblnomesocial;
        private System.Windows.Forms.DataGridView grddadosmorad;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.ComboBox comboxhabid;
        private System.Windows.Forms.Label lblhabid;
        private System.Windows.Forms.TextBox txtemail;
    }
}