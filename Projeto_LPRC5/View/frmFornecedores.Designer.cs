
namespace Projeto_LPRC5.View
{
    partial class frmFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.Label();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.barManutencao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(2, 32);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(154, 20);
            this.Name.TabIndex = 1;
            this.Name.Text = "Nome do fornecedor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
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
            this.barManutencao.Location = new System.Drawing.Point(12, 12);
            this.barManutencao.Name = "barManutencao";
            this.barManutencao.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barManutencao.Size = new System.Drawing.Size(228, 39);
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
            this.label1.Location = new System.Drawing.Point(2, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPF/CNPJ ";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(6, 171);
            this.maskedTextBox2.Mask = "(00) 0000 - 00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(277, 20);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefone";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(6, 112);
            this.maskedTextBox3.Mask = "000.000.000-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(277, 20);
            this.maskedTextBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Serviço prestado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 369);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do fornecedor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 301);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 62);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 20);
            this.textBox3.TabIndex = 13;
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barManutencao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmFornecedores";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label Name;
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