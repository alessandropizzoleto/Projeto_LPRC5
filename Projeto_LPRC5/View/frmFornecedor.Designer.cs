
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TxtJuridica = new System.Windows.Forms.TextBox();
            this.IdPessoa = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Razao = new System.Windows.Forms.Label();
            this.TxtRazao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtDDI = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtWebsite = new System.Windows.Forms.MaskedTextBox();
            this.Txtnro = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.TxtProdutos = new System.Windows.Forms.TextBox();
            this.TxtServ = new System.Windows.Forms.MaskedTextBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.TelaIni = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(893, 205);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // TxtJuridica
            // 
            this.TxtJuridica.Location = new System.Drawing.Point(144, 40);
            this.TxtJuridica.Name = "TxtJuridica";
            this.TxtJuridica.Size = new System.Drawing.Size(42, 20);
            this.TxtJuridica.TabIndex = 14;
            // 
            // IdPessoa
            // 
            this.IdPessoa.AutoSize = true;
            this.IdPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPessoa.Location = new System.Drawing.Point(3, 40);
            this.IdPessoa.Name = "IdPessoa";
            this.IdPessoa.Size = new System.Drawing.Size(141, 16);
            this.IdPessoa.TabIndex = 15;
            this.IdPessoa.Text = " ID da pessoa jurídica:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TelaIni});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // Razao
            // 
            this.Razao.AutoSize = true;
            this.Razao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Razao.Location = new System.Drawing.Point(13, 111);
            this.Razao.Name = "Razao";
            this.Razao.Size = new System.Drawing.Size(92, 16);
            this.Razao.TabIndex = 17;
            this.Razao.Text = "Razão Social:";
            // 
            // TxtRazao
            // 
            this.TxtRazao.Location = new System.Drawing.Point(111, 111);
            this.TxtRazao.Name = "TxtRazao";
            this.TxtRazao.Size = new System.Drawing.Size(223, 20);
            this.TxtRazao.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome Fantasia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.TxtDDI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtWebsite);
            this.groupBox1.Controls.Add(this.Txtnro);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtCEP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtRazao);
            this.groupBox1.Controls.Add(this.Razao);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 331);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados gerais do fornecedor:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnLimpar);
            this.groupBox5.Controls.Add(this.BtnDeletar);
            this.groupBox5.Controls.Add(this.BtnAtualizar);
            this.groupBox5.Controls.Add(this.BtnSalvar);
            this.groupBox5.Location = new System.Drawing.Point(695, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(139, 133);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackgroundImage = global::Projeto_LPRC5.Properties.Resources.icons8_dustpan_48__1_;
            this.BtnLimpar.Location = new System.Drawing.Point(72, 79);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(47, 54);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackgroundImage = global::Projeto_LPRC5.Properties.Resources.icons8_excluir_propriedade_50;
            this.BtnDeletar.Location = new System.Drawing.Point(6, 79);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(50, 54);
            this.BtnDeletar.TabIndex = 2;
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackgroundImage = global::Projeto_LPRC5.Properties.Resources.icons8_atualizações_disponíveis_50;
            this.BtnAtualizar.Location = new System.Drawing.Point(72, 19);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(47, 49);
            this.BtnAtualizar.TabIndex = 1;
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackgroundImage = global::Projeto_LPRC5.Properties.Resources.icons8_salvar_48;
            this.BtnSalvar.Location = new System.Drawing.Point(9, 19);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(47, 47);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtDDI
            // 
            this.TxtDDI.Location = new System.Drawing.Point(111, 275);
            this.TxtDDI.Mask = "+00";
            this.TxtDDI.Name = "TxtDDI";
            this.TxtDDI.Size = new System.Drawing.Size(30, 20);
            this.TxtDDI.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "DDI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Website:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(195, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "*Somente para casos de consulta ou atualização de dados";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Location = new System.Drawing.Point(111, 182);
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Size = new System.Drawing.Size(223, 20);
            this.TxtWebsite.TabIndex = 26;
            // 
            // Txtnro
            // 
            this.Txtnro.Location = new System.Drawing.Point(111, 245);
            this.Txtnro.Name = "Txtnro";
            this.Txtnro.Size = new System.Drawing.Size(73, 20);
            this.Txtnro.TabIndex = 25;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(111, 148);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(223, 20);
            this.TxtNome.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Número:";
            // 
            // TxtCEP
            // 
            this.TxtCEP.Location = new System.Drawing.Point(111, 217);
            this.TxtCEP.Mask = "00000-000";
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(65, 20);
            this.TxtCEP.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "CEP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 228);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtEmail);
            this.groupBox3.Controls.Add(this.TxtProdutos);
            this.groupBox3.Controls.Add(this.TxtServ);
            this.groupBox3.Controls.Add(this.TxtTelefone);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(379, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 228);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "Produtos fornecidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "E-mail:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(111, 25);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(165, 20);
            this.TxtEmail.TabIndex = 36;
            // 
            // TxtProdutos
            // 
            this.TxtProdutos.Location = new System.Drawing.Point(6, 149);
            this.TxtProdutos.Multiline = true;
            this.TxtProdutos.Name = "TxtProdutos";
            this.TxtProdutos.Size = new System.Drawing.Size(264, 73);
            this.TxtProdutos.TabIndex = 40;
            // 
            // TxtServ
            // 
            this.TxtServ.Location = new System.Drawing.Point(111, 97);
            this.TxtServ.Name = "TxtServ";
            this.TxtServ.Size = new System.Drawing.Size(165, 20);
            this.TxtServ.TabIndex = 38;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(111, 65);
            this.TxtTelefone.Mask = "(00) 0000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(83, 20);
            this.TxtTelefone.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tipo de serviço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Telefone (fixo):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtJuridica);
            this.groupBox4.Controls.Add(this.IdPessoa);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtID);
            this.groupBox4.Location = new System.Drawing.Point(3, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(669, 68);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = " ID do fornecedor:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(144, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(42, 20);
            this.txtID.TabIndex = 28;
            // 
            // TelaIni
            // 
            this.TelaIni.Name = "TelaIni";
            this.TelaIni.Size = new System.Drawing.Size(180, 22);
            this.TelaIni.Text = "Tela Inicial";
            this.TelaIni.Click += new System.EventHandler(this.TelaIni_Click);
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFornecedor";
            this.Text = "Manutenção de Fornecedores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TxtJuridica;
        private System.Windows.Forms.Label IdPessoa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label Razao;
        private System.Windows.Forms.MaskedTextBox TxtRazao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtProdutos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox TxtServ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TxtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TxtDDI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtWebsite;
        private System.Windows.Forms.TextBox Txtnro;
        private System.Windows.Forms.MaskedTextBox TxtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ToolStripMenuItem TelaIni;
    }
}