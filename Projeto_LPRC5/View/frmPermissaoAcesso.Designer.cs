
namespace Projeto_LPRC5
{
    partial class frmPermissaoAcesso
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
            this.lblNível = new System.Windows.Forms.Label();
            this.cboNivelAcesso = new System.Windows.Forms.ComboBox();
            this.btnNívelAcesso = new System.Windows.Forms.Button();
            this.lblOpcoesAcesso = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNível
            // 
            this.lblNível.AutoSize = true;
            this.lblNível.Location = new System.Drawing.Point(13, 54);
            this.lblNível.Name = "lblNível";
            this.lblNível.Size = new System.Drawing.Size(141, 22);
            this.lblNível.TabIndex = 0;
            this.lblNível.Text = "Nível de Acesso";
            // 
            // cboNivelAcesso
            // 
            this.cboNivelAcesso.FormattingEnabled = true;
            this.cboNivelAcesso.Location = new System.Drawing.Point(17, 80);
            this.cboNivelAcesso.Name = "cboNivelAcesso";
            this.cboNivelAcesso.Size = new System.Drawing.Size(250, 30);
            this.cboNivelAcesso.TabIndex = 1;
            // 
            // btnNívelAcesso
            // 
            this.btnNívelAcesso.Location = new System.Drawing.Point(274, 80);
            this.btnNívelAcesso.Name = "btnNívelAcesso";
            this.btnNívelAcesso.Size = new System.Drawing.Size(38, 30);
            this.btnNívelAcesso.TabIndex = 2;
            this.btnNívelAcesso.Text = "...";
            this.btnNívelAcesso.UseVisualStyleBackColor = true;
            // 
            // lblOpcoesAcesso
            // 
            this.lblOpcoesAcesso.AutoSize = true;
            this.lblOpcoesAcesso.Location = new System.Drawing.Point(17, 117);
            this.lblOpcoesAcesso.Name = "lblOpcoesAcesso";
            this.lblOpcoesAcesso.Size = new System.Drawing.Size(156, 22);
            this.lblOpcoesAcesso.TabIndex = 3;
            this.lblOpcoesAcesso.Text = "Opções de Acesso";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(17, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 468);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descrição";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Permitir";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // frmPermissaoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 623);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOpcoesAcesso);
            this.Controls.Add(this.btnNívelAcesso);
            this.Controls.Add(this.cboNivelAcesso);
            this.Controls.Add(this.lblNível);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPermissaoAcesso";
            this.Text = "Manutenção de Níveis de Acesso";
            this.Load += new System.EventHandler(this.frmPermissaoAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNível;
        private System.Windows.Forms.ComboBox cboNivelAcesso;
        private System.Windows.Forms.Button btnNívelAcesso;
        private System.Windows.Forms.Label lblOpcoesAcesso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}