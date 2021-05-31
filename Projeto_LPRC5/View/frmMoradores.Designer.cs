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
            this.barbtnNovoMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnEditarMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnExcluirMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnSalvarMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelarMorad = new System.Windows.Forms.ToolStripButton();
            this.barbtnFecharMorad = new System.Windows.Forms.ToolStripButton();
            this.grdDadosMorad = new System.Windows.Forms.DataGridView();
            this.lblnomeMorad = new System.Windows.Forms.Label();
            this.lblRGMorad = new System.Windows.Forms.Label();
            this.lblcpfMorad = new System.Windows.Forms.Label();
            this.lblsexoMorad = new System.Windows.Forms.Label();
            this.lblTelefoneMorad = new System.Windows.Forms.Label();
            this.gtxtDadosMorad = new System.Windows.Forms.GroupBox();
            this.rbtnMascMorad = new System.Windows.Forms.RadioButton();
            this.rbtnFemininoMorad = new System.Windows.Forms.RadioButton();
            this.rbtnNaoEspecificMorad = new System.Windows.Forms.RadioButton();
            this.txtNomeMorad = new System.Windows.Forms.TextBox();
            this.lblnascMorad = new System.Windows.Forms.Label();
            this.gtxtResidMorad = new System.Windows.Forms.GroupBox();
            this.lblBlocoMorad = new System.Windows.Forms.Label();
            this.lblNumresiMorad = new System.Windows.Forms.Label();
            this.txtNumResMorad = new System.Windows.Forms.TextBox();
            this.cboxBlocoMorad = new System.Windows.Forms.ComboBox();
            this.gtxtVeicMorad = new System.Windows.Forms.GroupBox();
            this.lblplacaMorad = new System.Windows.Forms.Label();
            this.lblmodeloVeicMorad = new System.Windows.Forms.Label();
            this.lblCorVeicMorad = new System.Windows.Forms.Label();
            this.cboxPlacaVeicMorad = new System.Windows.Forms.ComboBox();
            this.cboxModelVeicMorad = new System.Windows.Forms.ComboBox();
            this.cboxCorVeicMorad = new System.Windows.Forms.ComboBox();
            this.lblruaMorad = new System.Windows.Forms.Label();
            this.txtruaMorad = new System.Windows.Forms.TextBox();
            this.mtxtRgMorad = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPFMorad = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascMorad = new System.Windows.Forms.DateTimePicker();
            this.mtxtTele1Morad = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTele2Morad = new System.Windows.Forms.MaskedTextBox();
            this.barManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosMorad)).BeginInit();
            this.gtxtDadosMorad.SuspendLayout();
            this.gtxtResidMorad.SuspendLayout();
            this.gtxtVeicMorad.SuspendLayout();
            this.SuspendLayout();
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
            this.barManutencao.Location = new System.Drawing.Point(3, 0);
            this.barManutencao.Name = "barManutencao";
            this.barManutencao.Size = new System.Drawing.Size(229, 39);
            this.barManutencao.TabIndex = 1;
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
            // grdDadosMorad
            // 
            this.grdDadosMorad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosMorad.Location = new System.Drawing.Point(3, 352);
            this.grdDadosMorad.Name = "grdDadosMorad";
            this.grdDadosMorad.RowHeadersWidth = 51;
            this.grdDadosMorad.Size = new System.Drawing.Size(1328, 426);
            this.grdDadosMorad.TabIndex = 2;
            // 
            // lblnomeMorad
            // 
            this.lblnomeMorad.AutoSize = true;
            this.lblnomeMorad.Location = new System.Drawing.Point(6, 34);
            this.lblnomeMorad.Name = "lblnomeMorad";
            this.lblnomeMorad.Size = new System.Drawing.Size(58, 20);
            this.lblnomeMorad.TabIndex = 3;
            this.lblnomeMorad.Text = "Nome:";
            // 
            // lblRGMorad
            // 
            this.lblRGMorad.AutoSize = true;
            this.lblRGMorad.Location = new System.Drawing.Point(6, 77);
            this.lblRGMorad.Name = "lblRGMorad";
            this.lblRGMorad.Size = new System.Drawing.Size(39, 20);
            this.lblRGMorad.TabIndex = 4;
            this.lblRGMorad.Text = "RG:";
            // 
            // lblcpfMorad
            // 
            this.lblcpfMorad.AutoSize = true;
            this.lblcpfMorad.Location = new System.Drawing.Point(214, 81);
            this.lblcpfMorad.Name = "lblcpfMorad";
            this.lblcpfMorad.Size = new System.Drawing.Size(47, 20);
            this.lblcpfMorad.TabIndex = 5;
            this.lblcpfMorad.Text = "CPF:";
            // 
            // lblsexoMorad
            // 
            this.lblsexoMorad.AutoSize = true;
            this.lblsexoMorad.Location = new System.Drawing.Point(5, 163);
            this.lblsexoMorad.Name = "lblsexoMorad";
            this.lblsexoMorad.Size = new System.Drawing.Size(51, 20);
            this.lblsexoMorad.TabIndex = 6;
            this.lblsexoMorad.Text = "Sexo:";
            // 
            // lblTelefoneMorad
            // 
            this.lblTelefoneMorad.AutoSize = true;
            this.lblTelefoneMorad.Location = new System.Drawing.Point(6, 215);
            this.lblTelefoneMorad.Name = "lblTelefoneMorad";
            this.lblTelefoneMorad.Size = new System.Drawing.Size(87, 20);
            this.lblTelefoneMorad.TabIndex = 7;
            this.lblTelefoneMorad.Text = "Telefones:";
            // 
            // gtxtDadosMorad
            // 
            this.gtxtDadosMorad.Controls.Add(this.mtxtTele2Morad);
            this.gtxtDadosMorad.Controls.Add(this.mtxtTele1Morad);
            this.gtxtDadosMorad.Controls.Add(this.dtpDataNascMorad);
            this.gtxtDadosMorad.Controls.Add(this.mtxtCPFMorad);
            this.gtxtDadosMorad.Controls.Add(this.mtxtRgMorad);
            this.gtxtDadosMorad.Controls.Add(this.lblnascMorad);
            this.gtxtDadosMorad.Controls.Add(this.txtNomeMorad);
            this.gtxtDadosMorad.Controls.Add(this.rbtnNaoEspecificMorad);
            this.gtxtDadosMorad.Controls.Add(this.lblTelefoneMorad);
            this.gtxtDadosMorad.Controls.Add(this.rbtnFemininoMorad);
            this.gtxtDadosMorad.Controls.Add(this.rbtnMascMorad);
            this.gtxtDadosMorad.Controls.Add(this.lblnomeMorad);
            this.gtxtDadosMorad.Controls.Add(this.lblRGMorad);
            this.gtxtDadosMorad.Controls.Add(this.lblsexoMorad);
            this.gtxtDadosMorad.Controls.Add(this.lblcpfMorad);
            this.gtxtDadosMorad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtDadosMorad.Location = new System.Drawing.Point(12, 56);
            this.gtxtDadosMorad.Name = "gtxtDadosMorad";
            this.gtxtDadosMorad.Size = new System.Drawing.Size(498, 260);
            this.gtxtDadosMorad.TabIndex = 10;
            this.gtxtDadosMorad.TabStop = false;
            this.gtxtDadosMorad.Text = "Dados Pessoais:";
            this.gtxtDadosMorad.Enter += new System.EventHandler(this.groupBoxdadosMorad_Enter);
            // 
            // rbtnMascMorad
            // 
            this.rbtnMascMorad.AutoSize = true;
            this.rbtnMascMorad.Location = new System.Drawing.Point(62, 161);
            this.rbtnMascMorad.Name = "rbtnMascMorad";
            this.rbtnMascMorad.Size = new System.Drawing.Size(106, 24);
            this.rbtnMascMorad.TabIndex = 7;
            this.rbtnMascMorad.TabStop = true;
            this.rbtnMascMorad.Text = "Masculino";
            this.rbtnMascMorad.UseVisualStyleBackColor = true;
            // 
            // rbtnFemininoMorad
            // 
            this.rbtnFemininoMorad.AutoSize = true;
            this.rbtnFemininoMorad.Location = new System.Drawing.Point(172, 161);
            this.rbtnFemininoMorad.Name = "rbtnFemininoMorad";
            this.rbtnFemininoMorad.Size = new System.Drawing.Size(98, 24);
            this.rbtnFemininoMorad.TabIndex = 8;
            this.rbtnFemininoMorad.TabStop = true;
            this.rbtnFemininoMorad.Text = "Feminino";
            this.rbtnFemininoMorad.UseVisualStyleBackColor = true;
            // 
            // rbtnNaoEspecificMorad
            // 
            this.rbtnNaoEspecificMorad.AutoSize = true;
            this.rbtnNaoEspecificMorad.Location = new System.Drawing.Point(276, 161);
            this.rbtnNaoEspecificMorad.Name = "rbtnNaoEspecificMorad";
            this.rbtnNaoEspecificMorad.Size = new System.Drawing.Size(161, 24);
            this.rbtnNaoEspecificMorad.TabIndex = 9;
            this.rbtnNaoEspecificMorad.TabStop = true;
            this.rbtnNaoEspecificMorad.Text = "Não Especificado";
            this.rbtnNaoEspecificMorad.UseVisualStyleBackColor = true;
            this.rbtnNaoEspecificMorad.CheckedChanged += new System.EventHandler(this.radioButtonOutrosMorad_CheckedChanged);
            // 
            // txtNomeMorad
            // 
            this.txtNomeMorad.Location = new System.Drawing.Point(71, 34);
            this.txtNomeMorad.Name = "txtNomeMorad";
            this.txtNomeMorad.Size = new System.Drawing.Size(336, 27);
            this.txtNomeMorad.TabIndex = 9;
            // 
            // lblnascMorad
            // 
            this.lblnascMorad.AutoSize = true;
            this.lblnascMorad.Location = new System.Drawing.Point(5, 122);
            this.lblnascMorad.Name = "lblnascMorad";
            this.lblnascMorad.Size = new System.Drawing.Size(94, 20);
            this.lblnascMorad.TabIndex = 13;
            this.lblnascMorad.Text = "Data Nasc:";
            // 
            // gtxtResidMorad
            // 
            this.gtxtResidMorad.Controls.Add(this.txtruaMorad);
            this.gtxtResidMorad.Controls.Add(this.lblruaMorad);
            this.gtxtResidMorad.Controls.Add(this.cboxBlocoMorad);
            this.gtxtResidMorad.Controls.Add(this.txtNumResMorad);
            this.gtxtResidMorad.Controls.Add(this.lblNumresiMorad);
            this.gtxtResidMorad.Controls.Add(this.lblBlocoMorad);
            this.gtxtResidMorad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtResidMorad.Location = new System.Drawing.Point(516, 56);
            this.gtxtResidMorad.Name = "gtxtResidMorad";
            this.gtxtResidMorad.Size = new System.Drawing.Size(430, 260);
            this.gtxtResidMorad.TabIndex = 9;
            this.gtxtResidMorad.TabStop = false;
            this.gtxtResidMorad.Text = "Endereço:";
            // 
            // lblBlocoMorad
            // 
            this.lblBlocoMorad.AutoSize = true;
            this.lblBlocoMorad.Location = new System.Drawing.Point(22, 80);
            this.lblBlocoMorad.Name = "lblBlocoMorad";
            this.lblBlocoMorad.Size = new System.Drawing.Size(57, 20);
            this.lblBlocoMorad.TabIndex = 4;
            this.lblBlocoMorad.Text = "Bloco:";
            // 
            // lblNumresiMorad
            // 
            this.lblNumresiMorad.AutoSize = true;
            this.lblNumresiMorad.Location = new System.Drawing.Point(22, 120);
            this.lblNumresiMorad.Name = "lblNumresiMorad";
            this.lblNumresiMorad.Size = new System.Drawing.Size(73, 20);
            this.lblNumresiMorad.TabIndex = 5;
            this.lblNumresiMorad.Text = "Numero:";
            // 
            // txtNumResMorad
            // 
            this.txtNumResMorad.Location = new System.Drawing.Point(110, 120);
            this.txtNumResMorad.Name = "txtNumResMorad";
            this.txtNumResMorad.Size = new System.Drawing.Size(121, 27);
            this.txtNumResMorad.TabIndex = 12;
            // 
            // cboxBlocoMorad
            // 
            this.cboxBlocoMorad.FormattingEnabled = true;
            this.cboxBlocoMorad.Location = new System.Drawing.Point(110, 80);
            this.cboxBlocoMorad.Name = "cboxBlocoMorad";
            this.cboxBlocoMorad.Size = new System.Drawing.Size(121, 28);
            this.cboxBlocoMorad.TabIndex = 13;
            // 
            // gtxtVeicMorad
            // 
            this.gtxtVeicMorad.Controls.Add(this.cboxCorVeicMorad);
            this.gtxtVeicMorad.Controls.Add(this.cboxModelVeicMorad);
            this.gtxtVeicMorad.Controls.Add(this.cboxPlacaVeicMorad);
            this.gtxtVeicMorad.Controls.Add(this.lblCorVeicMorad);
            this.gtxtVeicMorad.Controls.Add(this.lblmodeloVeicMorad);
            this.gtxtVeicMorad.Controls.Add(this.lblplacaMorad);
            this.gtxtVeicMorad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtVeicMorad.Location = new System.Drawing.Point(952, 56);
            this.gtxtVeicMorad.Name = "gtxtVeicMorad";
            this.gtxtVeicMorad.Size = new System.Drawing.Size(379, 260);
            this.gtxtVeicMorad.TabIndex = 10;
            this.gtxtVeicMorad.TabStop = false;
            this.gtxtVeicMorad.Text = "Veiculo:";
            // 
            // lblplacaMorad
            // 
            this.lblplacaMorad.AutoSize = true;
            this.lblplacaMorad.Location = new System.Drawing.Point(22, 28);
            this.lblplacaMorad.Name = "lblplacaMorad";
            this.lblplacaMorad.Size = new System.Drawing.Size(56, 20);
            this.lblplacaMorad.TabIndex = 0;
            this.lblplacaMorad.Text = "Placa:";
            // 
            // lblmodeloVeicMorad
            // 
            this.lblmodeloVeicMorad.AutoSize = true;
            this.lblmodeloVeicMorad.Location = new System.Drawing.Point(22, 58);
            this.lblmodeloVeicMorad.Name = "lblmodeloVeicMorad";
            this.lblmodeloVeicMorad.Size = new System.Drawing.Size(68, 20);
            this.lblmodeloVeicMorad.TabIndex = 11;
            this.lblmodeloVeicMorad.Text = "Modelo:";
            // 
            // lblCorVeicMorad
            // 
            this.lblCorVeicMorad.AutoSize = true;
            this.lblCorVeicMorad.Location = new System.Drawing.Point(25, 91);
            this.lblCorVeicMorad.Name = "lblCorVeicMorad";
            this.lblCorVeicMorad.Size = new System.Drawing.Size(41, 20);
            this.lblCorVeicMorad.TabIndex = 12;
            this.lblCorVeicMorad.Text = "Cor:";
            // 
            // cboxPlacaVeicMorad
            // 
            this.cboxPlacaVeicMorad.FormattingEnabled = true;
            this.cboxPlacaVeicMorad.Location = new System.Drawing.Point(118, 21);
            this.cboxPlacaVeicMorad.Name = "cboxPlacaVeicMorad";
            this.cboxPlacaVeicMorad.Size = new System.Drawing.Size(150, 28);
            this.cboxPlacaVeicMorad.TabIndex = 13;
            // 
            // cboxModelVeicMorad
            // 
            this.cboxModelVeicMorad.FormattingEnabled = true;
            this.cboxModelVeicMorad.Location = new System.Drawing.Point(118, 58);
            this.cboxModelVeicMorad.Name = "cboxModelVeicMorad";
            this.cboxModelVeicMorad.Size = new System.Drawing.Size(150, 28);
            this.cboxModelVeicMorad.TabIndex = 14;
            // 
            // cboxCorVeicMorad
            // 
            this.cboxCorVeicMorad.FormattingEnabled = true;
            this.cboxCorVeicMorad.Location = new System.Drawing.Point(118, 88);
            this.cboxCorVeicMorad.Name = "cboxCorVeicMorad";
            this.cboxCorVeicMorad.Size = new System.Drawing.Size(150, 28);
            this.cboxCorVeicMorad.TabIndex = 15;
            // 
            // lblruaMorad
            // 
            this.lblruaMorad.AutoSize = true;
            this.lblruaMorad.Location = new System.Drawing.Point(22, 42);
            this.lblruaMorad.Name = "lblruaMorad";
            this.lblruaMorad.Size = new System.Drawing.Size(44, 20);
            this.lblruaMorad.TabIndex = 14;
            this.lblruaMorad.Text = "Rua:";
            // 
            // txtruaMorad
            // 
            this.txtruaMorad.Location = new System.Drawing.Point(110, 42);
            this.txtruaMorad.Name = "txtruaMorad";
            this.txtruaMorad.Size = new System.Drawing.Size(263, 27);
            this.txtruaMorad.TabIndex = 15;
            // 
            // mtxtRgMorad
            // 
            this.mtxtRgMorad.Location = new System.Drawing.Point(62, 77);
            this.mtxtRgMorad.Mask = "00.000.000-0";
            this.mtxtRgMorad.Name = "mtxtRgMorad";
            this.mtxtRgMorad.Size = new System.Drawing.Size(128, 27);
            this.mtxtRgMorad.TabIndex = 14;
            // 
            // mtxtCPFMorad
            // 
            this.mtxtCPFMorad.Location = new System.Drawing.Point(268, 78);
            this.mtxtCPFMorad.Mask = "000.000.000-00";
            this.mtxtCPFMorad.Name = "mtxtCPFMorad";
            this.mtxtCPFMorad.Size = new System.Drawing.Size(139, 27);
            this.mtxtCPFMorad.TabIndex = 15;
            // 
            // dtpDataNascMorad
            // 
            this.dtpDataNascMorad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascMorad.Location = new System.Drawing.Point(105, 122);
            this.dtpDataNascMorad.Name = "dtpDataNascMorad";
            this.dtpDataNascMorad.Size = new System.Drawing.Size(122, 27);
            this.dtpDataNascMorad.TabIndex = 16;
            // 
            // mtxtTele1Morad
            // 
            this.mtxtTele1Morad.Location = new System.Drawing.Point(93, 212);
            this.mtxtTele1Morad.Mask = "(00) 00000-0000";
            this.mtxtTele1Morad.Name = "mtxtTele1Morad";
            this.mtxtTele1Morad.Size = new System.Drawing.Size(168, 27);
            this.mtxtTele1Morad.TabIndex = 17;
            // 
            // mtxtTele2Morad
            // 
            this.mtxtTele2Morad.Location = new System.Drawing.Point(269, 212);
            this.mtxtTele2Morad.Mask = "(00) 00000-0000";
            this.mtxtTele2Morad.Name = "mtxtTele2Morad";
            this.mtxtTele2Morad.Size = new System.Drawing.Size(168, 27);
            this.mtxtTele2Morad.TabIndex = 18;
            // 
            // frmMoradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 790);
            this.Controls.Add(this.gtxtVeicMorad);
            this.Controls.Add(this.gtxtResidMorad);
            this.Controls.Add(this.gtxtDadosMorad);
            this.Controls.Add(this.grdDadosMorad);
            this.Controls.Add(this.barManutencao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMoradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manutenção Moradores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMoradores_Load);
            this.barManutencao.ResumeLayout(false);
            this.barManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosMorad)).EndInit();
            this.gtxtDadosMorad.ResumeLayout(false);
            this.gtxtDadosMorad.PerformLayout();
            this.gtxtResidMorad.ResumeLayout(false);
            this.gtxtResidMorad.PerformLayout();
            this.gtxtVeicMorad.ResumeLayout(false);
            this.gtxtVeicMorad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barManutencao;
        private System.Windows.Forms.ToolStripButton barbtnNovoMorad;
        private System.Windows.Forms.ToolStripButton barbtnEditarMorad;
        private System.Windows.Forms.ToolStripButton barbtnExcluirMorad;
        private System.Windows.Forms.ToolStripButton barbtnSalvarMorad;
        private System.Windows.Forms.ToolStripButton barbtnCancelarMorad;
        private System.Windows.Forms.ToolStripButton barbtnFecharMorad;
        private System.Windows.Forms.DataGridView grdDadosMorad;
        private System.Windows.Forms.Label lblnomeMorad;
        private System.Windows.Forms.Label lblRGMorad;
        private System.Windows.Forms.Label lblcpfMorad;
        private System.Windows.Forms.Label lblsexoMorad;
        private System.Windows.Forms.Label lblTelefoneMorad;
        private System.Windows.Forms.GroupBox gtxtDadosMorad;
        private System.Windows.Forms.Label lblnascMorad;
        private System.Windows.Forms.TextBox txtNomeMorad;
        private System.Windows.Forms.RadioButton rbtnNaoEspecificMorad;
        private System.Windows.Forms.RadioButton rbtnFemininoMorad;
        private System.Windows.Forms.RadioButton rbtnMascMorad;
        private System.Windows.Forms.GroupBox gtxtResidMorad;
        private System.Windows.Forms.ComboBox cboxBlocoMorad;
        private System.Windows.Forms.TextBox txtNumResMorad;
        private System.Windows.Forms.Label lblNumresiMorad;
        private System.Windows.Forms.Label lblBlocoMorad;
        private System.Windows.Forms.GroupBox gtxtVeicMorad;
        private System.Windows.Forms.Label lblCorVeicMorad;
        private System.Windows.Forms.Label lblmodeloVeicMorad;
        private System.Windows.Forms.Label lblplacaMorad;
        private System.Windows.Forms.TextBox txtruaMorad;
        private System.Windows.Forms.Label lblruaMorad;
        private System.Windows.Forms.ComboBox cboxCorVeicMorad;
        private System.Windows.Forms.ComboBox cboxModelVeicMorad;
        private System.Windows.Forms.ComboBox cboxPlacaVeicMorad;
        private System.Windows.Forms.MaskedTextBox mtxtTele2Morad;
        private System.Windows.Forms.MaskedTextBox mtxtTele1Morad;
        private System.Windows.Forms.DateTimePicker dtpDataNascMorad;
        private System.Windows.Forms.MaskedTextBox mtxtCPFMorad;
        private System.Windows.Forms.MaskedTextBox mtxtRgMorad;
    }
}