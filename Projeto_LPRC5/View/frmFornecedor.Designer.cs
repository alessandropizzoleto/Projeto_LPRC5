
namespace Projeto_LPRC5.View
{
    partial class frmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.barManutencao = new System.Windows.Forms.ToolStrip();
            this.barbtnNovoMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditarMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluirMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvarMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelarMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnFecharMorad = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.barManutencao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(517, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(533, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // barManutencao
            // 
            this.barManutencao.Dock = System.Windows.Forms.DockStyle.None;
            this.barManutencao.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barManutencao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbtnNovoMorad,
            this.barbtnEditarMorad,
            this.barbtnExcluirMorad,
            this.barbtnSalvarMorad,
            this.barbtnCancelarMorad,
            this.barbtnFecharMorad});
            this.barManutencao.Location = new System.Drawing.Point(16, 15);
            this.barManutencao.Name = "barManutencao";
            this.barManutencao.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barManutencao.Size = new System.Drawing.Size(229, 39);
            this.barManutencao.TabIndex = 3;
            this.barManutencao.Text = "toolStrip1";
            // 
            // barbtnNovoMorad
            // 
            this.barbtnNovoMorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnNovoMorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNovoMorad.Image")));
            this.barbtnNovoMorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnNovoMorad.Name = "barbtnNovoMorad";
            this.barbtnNovoMorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnNovoMorad.Text = "Novo";
            this.barbtnNovoMorad.ToolTipText = "Adicionar Cidade";
            // 
            // barbtnEditarMorad
            // 
            this.barbtnEditarMorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnEditarMorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditarMorad.Image")));
            this.barbtnEditarMorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnEditarMorad.Name = "barbtnEditarMorad";
            this.barbtnEditarMorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnEditarMorad.Text = "Editar";
            this.barbtnEditarMorad.ToolTipText = "Editar Cidade";
            // 
            // barbtnExcluirMorad
            // 
            this.barbtnExcluirMorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnExcluirMorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnExcluirMorad.Image")));
            this.barbtnExcluirMorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnExcluirMorad.Name = "barbtnExcluirMorad";
            this.barbtnExcluirMorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnExcluirMorad.Text = "Excluir";
            this.barbtnExcluirMorad.ToolTipText = "Excluir Cidade";
            // 
            // barbtnSalvarMorad
            // 
            this.barbtnSalvarMorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnSalvarMorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSalvarMorad.Image")));
            this.barbtnSalvarMorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnSalvarMorad.Name = "barbtnSalvarMorad";
            this.barbtnSalvarMorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnSalvarMorad.Text = "Salvar";
            this.barbtnSalvarMorad.ToolTipText = "Salvar nova Cidade";
            // 
            // barbtnCancelarMorad
            // 
            this.barbtnCancelarMorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelarMorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelarMorad.Image")));
            this.barbtnCancelarMorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelarMorad.Name = "barbtnCancelarMorad";
            this.barbtnCancelarMorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnCancelarMorad.Text = "Cancelar";
            this.barbtnCancelarMorad.ToolTipText = "Cancela a operação de conclusão ou edição";
            // 
            // barbtnFecharMorad
            // 
            this.barbtnFecharMorad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnFecharMorad.Image = ((System.Drawing.Image)(resources.GetObject("barbtnFecharMorad.Image")));
            this.barbtnFecharMorad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnFecharMorad.Name = "barbtnFecharMorad";
            this.barbtnFecharMorad.Size = new System.Drawing.Size(36, 36);
            this.barbtnFecharMorad.Text = "Fechar";
            this.barbtnFecharMorad.ToolTipText = "Fechar Manutenção de Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPF/CNPJ ";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(8, 210);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox2.Mask = "(00) 0000 - 00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(368, 22);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefone";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(8, 138);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox3.Mask = "000.000.000-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(368, 22);
            this.maskedTextBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Serviço prestado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(492, 454);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do fornecedor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 294);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(368, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 370);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 75);
            this.textBox2.TabIndex = 12;
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barManutencao);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFornecedor";
            this.Text = "Manutenção de Fornecedores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.barManutencao.ResumeLayout(false);
            this.barManutencao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip barManutencao;
        private System.Windows.Forms.ToolStripButton barbtnNovoMorad;
        private System.Windows.Forms.ToolStripButton barbtnEditarMorad;
        private System.Windows.Forms.ToolStripButton barbtnExcluirMorad;
        private System.Windows.Forms.ToolStripButton barbtnSalvarMorad;
        private System.Windows.Forms.ToolStripButton barbtnCancelarMorad;
        private System.Windows.Forms.ToolStripButton barbtnFecharMorad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}