namespace SerializarXml
{
    partial class frmSerializarXml
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerializarXml));
            this.txtpathXml = new System.Windows.Forms.TextBox();
            this.openFileXml = new System.Windows.Forms.OpenFileDialog();
            this.btnLerXml = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbIdentificacao = new System.Windows.Forms.TabPage();
            this.tbEmitente = new System.Windows.Forms.TabPage();
            this.lblNaturezaOperacao = new System.Windows.Forms.Label();
            this.txtNaturezaOperacao = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtCpfCnpjEmitente = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblInscricaoEstadual = new System.Windows.Forms.Label();
            this.txtInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.gbEnderecoEmitente = new System.Windows.Forms.GroupBox();
            this.txtLogradouroEmitente = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtNroEmitente = new System.Windows.Forms.TextBox();
            this.lblNroEmitente = new System.Windows.Forms.Label();
            this.txtMunicipioEmitente = new System.Windows.Forms.TextBox();
            this.lblMunicipioEmitente = new System.Windows.Forms.Label();
            this.txtUFEmitente = new System.Windows.Forms.TextBox();
            this.lblUFEmitente = new System.Windows.Forms.Label();
            this.lblArquivoXml = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbIdentificacao.SuspendLayout();
            this.tbEmitente.SuspendLayout();
            this.gbEnderecoEmitente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpathXml
            // 
            this.txtpathXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpathXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpathXml.Location = new System.Drawing.Point(55, 30);
            this.txtpathXml.Name = "txtpathXml";
            this.txtpathXml.ReadOnly = true;
            this.txtpathXml.Size = new System.Drawing.Size(402, 23);
            this.txtpathXml.TabIndex = 0;
            // 
            // openFileXml
            // 
            this.openFileXml.FileName = "openFileDialog1";
            this.openFileXml.Filter = ".xml|";
            this.openFileXml.Title = "Abrir Nota Fiscal";
            // 
            // btnLerXml
            // 
            this.btnLerXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLerXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerXml.Location = new System.Drawing.Point(463, 30);
            this.btnLerXml.Name = "btnLerXml";
            this.btnLerXml.Size = new System.Drawing.Size(32, 23);
            this.btnLerXml.TabIndex = 1;
            this.btnLerXml.Text = "...";
            this.btnLerXml.UseVisualStyleBackColor = true;
            this.btnLerXml.Click += new System.EventHandler(this.btnLerXml_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbIdentificacao);
            this.tabControl1.Controls.Add(this.tbEmitente);
            this.tabControl1.Location = new System.Drawing.Point(55, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 295);
            this.tabControl1.TabIndex = 2;
            // 
            // tbIdentificacao
            // 
            this.tbIdentificacao.Controls.Add(this.txtDataEmissao);
            this.tbIdentificacao.Controls.Add(this.txtSerie);
            this.tbIdentificacao.Controls.Add(this.txtModelo);
            this.tbIdentificacao.Controls.Add(this.txtNumero);
            this.tbIdentificacao.Controls.Add(this.lblData);
            this.tbIdentificacao.Controls.Add(this.lblModelo);
            this.tbIdentificacao.Controls.Add(this.lblSerie);
            this.tbIdentificacao.Controls.Add(this.lblNumero);
            this.tbIdentificacao.Controls.Add(this.txtNaturezaOperacao);
            this.tbIdentificacao.Controls.Add(this.lblNaturezaOperacao);
            this.tbIdentificacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdentificacao.Location = new System.Drawing.Point(4, 22);
            this.tbIdentificacao.Name = "tbIdentificacao";
            this.tbIdentificacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbIdentificacao.Size = new System.Drawing.Size(394, 269);
            this.tbIdentificacao.TabIndex = 0;
            this.tbIdentificacao.Text = "Identificação";
            this.tbIdentificacao.UseVisualStyleBackColor = true;
            // 
            // tbEmitente
            // 
            this.tbEmitente.Controls.Add(this.gbEnderecoEmitente);
            this.tbEmitente.Controls.Add(this.txtInscricaoEstadual);
            this.tbEmitente.Controls.Add(this.lblInscricaoEstadual);
            this.tbEmitente.Controls.Add(this.txtCpfCnpjEmitente);
            this.tbEmitente.Controls.Add(this.lblCpfCnpj);
            this.tbEmitente.Controls.Add(this.txtNomeFantasia);
            this.tbEmitente.Controls.Add(this.lblNomeFantasia);
            this.tbEmitente.Controls.Add(this.txtRazaoSocial);
            this.tbEmitente.Controls.Add(this.lblRazaoSocial);
            this.tbEmitente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmitente.Location = new System.Drawing.Point(4, 22);
            this.tbEmitente.Name = "tbEmitente";
            this.tbEmitente.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmitente.Size = new System.Drawing.Size(394, 269);
            this.tbEmitente.TabIndex = 1;
            this.tbEmitente.Text = "Emitente";
            this.tbEmitente.UseVisualStyleBackColor = true;
            // 
            // lblNaturezaOperacao
            // 
            this.lblNaturezaOperacao.AutoSize = true;
            this.lblNaturezaOperacao.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaturezaOperacao.Location = new System.Drawing.Point(8, 9);
            this.lblNaturezaOperacao.Name = "lblNaturezaOperacao";
            this.lblNaturezaOperacao.Size = new System.Drawing.Size(106, 13);
            this.lblNaturezaOperacao.TabIndex = 0;
            this.lblNaturezaOperacao.Text = "Natureza Operação";
            // 
            // txtNaturezaOperacao
            // 
            this.txtNaturezaOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaturezaOperacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaturezaOperacao.Location = new System.Drawing.Point(11, 25);
            this.txtNaturezaOperacao.Name = "txtNaturezaOperacao";
            this.txtNaturezaOperacao.ReadOnly = true;
            this.txtNaturezaOperacao.Size = new System.Drawing.Size(370, 23);
            this.txtNaturezaOperacao.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(8, 63);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(218, 63);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(32, 13);
            this.lblSerie.TabIndex = 3;
            this.lblSerie.Text = "Série";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(133, 63);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(289, 63);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(76, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data Emissão";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(11, 79);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(103, 23);
            this.txtNumero.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(136, 79);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(45, 23);
            this.txtModelo.TabIndex = 7;
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(221, 79);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(45, 23);
            this.txtSerie.TabIndex = 8;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataEmissao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEmissao.Location = new System.Drawing.Point(292, 79);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.ReadOnly = true;
            this.txtDataEmissao.Size = new System.Drawing.Size(89, 23);
            this.txtDataEmissao.TabIndex = 9;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazaoSocial.Location = new System.Drawing.Point(11, 25);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.ReadOnly = true;
            this.txtRazaoSocial.Size = new System.Drawing.Size(370, 22);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(8, 9);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(71, 13);
            this.lblRazaoSocial.TabIndex = 2;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFantasia.Location = new System.Drawing.Point(11, 66);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.ReadOnly = true;
            this.txtNomeFantasia.Size = new System.Drawing.Size(370, 22);
            this.txtNomeFantasia.TabIndex = 5;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(8, 50);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(85, 13);
            this.lblNomeFantasia.TabIndex = 4;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtCpfCnpjEmitente
            // 
            this.txtCpfCnpjEmitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCnpjEmitente.Location = new System.Drawing.Point(11, 107);
            this.txtCpfCnpjEmitente.Name = "txtCpfCnpjEmitente";
            this.txtCpfCnpjEmitente.ReadOnly = true;
            this.txtCpfCnpjEmitente.Size = new System.Drawing.Size(131, 22);
            this.txtCpfCnpjEmitente.TabIndex = 7;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(8, 91);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(60, 13);
            this.lblCpfCnpj.TabIndex = 6;
            this.lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // lblInscricaoEstadual
            // 
            this.lblInscricaoEstadual.AutoSize = true;
            this.lblInscricaoEstadual.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricaoEstadual.Location = new System.Drawing.Point(236, 91);
            this.lblInscricaoEstadual.Name = "lblInscricaoEstadual";
            this.lblInscricaoEstadual.Size = new System.Drawing.Size(99, 13);
            this.lblInscricaoEstadual.TabIndex = 8;
            this.lblInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(239, 107);
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.ReadOnly = true;
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(142, 22);
            this.txtInscricaoEstadual.TabIndex = 9;
            // 
            // gbEnderecoEmitente
            // 
            this.gbEnderecoEmitente.Controls.Add(this.txtUFEmitente);
            this.gbEnderecoEmitente.Controls.Add(this.lblUFEmitente);
            this.gbEnderecoEmitente.Controls.Add(this.txtMunicipioEmitente);
            this.gbEnderecoEmitente.Controls.Add(this.lblMunicipioEmitente);
            this.gbEnderecoEmitente.Controls.Add(this.txtNroEmitente);
            this.gbEnderecoEmitente.Controls.Add(this.lblNroEmitente);
            this.gbEnderecoEmitente.Controls.Add(this.txtLogradouroEmitente);
            this.gbEnderecoEmitente.Controls.Add(this.lblLogradouro);
            this.gbEnderecoEmitente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnderecoEmitente.Location = new System.Drawing.Point(11, 139);
            this.gbEnderecoEmitente.Name = "gbEnderecoEmitente";
            this.gbEnderecoEmitente.Size = new System.Drawing.Size(370, 116);
            this.gbEnderecoEmitente.TabIndex = 10;
            this.gbEnderecoEmitente.TabStop = false;
            this.gbEnderecoEmitente.Text = "Endereço";
            // 
            // txtLogradouroEmitente
            // 
            this.txtLogradouroEmitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouroEmitente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouroEmitente.Location = new System.Drawing.Point(11, 34);
            this.txtLogradouroEmitente.Name = "txtLogradouroEmitente";
            this.txtLogradouroEmitente.ReadOnly = true;
            this.txtLogradouroEmitente.Size = new System.Drawing.Size(277, 22);
            this.txtLogradouroEmitente.TabIndex = 9;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(8, 18);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(69, 13);
            this.lblLogradouro.TabIndex = 8;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txtNroEmitente
            // 
            this.txtNroEmitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroEmitente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroEmitente.Location = new System.Drawing.Point(298, 34);
            this.txtNroEmitente.Name = "txtNroEmitente";
            this.txtNroEmitente.ReadOnly = true;
            this.txtNroEmitente.Size = new System.Drawing.Size(55, 22);
            this.txtNroEmitente.TabIndex = 11;
            // 
            // lblNroEmitente
            // 
            this.lblNroEmitente.AutoSize = true;
            this.lblNroEmitente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroEmitente.Location = new System.Drawing.Point(295, 18);
            this.lblNroEmitente.Name = "lblNroEmitente";
            this.lblNroEmitente.Size = new System.Drawing.Size(50, 13);
            this.lblNroEmitente.TabIndex = 10;
            this.lblNroEmitente.Text = "Número";
            // 
            // txtMunicipioEmitente
            // 
            this.txtMunicipioEmitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMunicipioEmitente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipioEmitente.Location = new System.Drawing.Point(11, 75);
            this.txtMunicipioEmitente.Name = "txtMunicipioEmitente";
            this.txtMunicipioEmitente.ReadOnly = true;
            this.txtMunicipioEmitente.Size = new System.Drawing.Size(277, 22);
            this.txtMunicipioEmitente.TabIndex = 13;
            // 
            // lblMunicipioEmitente
            // 
            this.lblMunicipioEmitente.AutoSize = true;
            this.lblMunicipioEmitente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipioEmitente.Location = new System.Drawing.Point(8, 59);
            this.lblMunicipioEmitente.Name = "lblMunicipioEmitente";
            this.lblMunicipioEmitente.Size = new System.Drawing.Size(60, 13);
            this.lblMunicipioEmitente.TabIndex = 12;
            this.lblMunicipioEmitente.Text = "Município";
            // 
            // txtUFEmitente
            // 
            this.txtUFEmitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUFEmitente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUFEmitente.Location = new System.Drawing.Point(298, 75);
            this.txtUFEmitente.Name = "txtUFEmitente";
            this.txtUFEmitente.ReadOnly = true;
            this.txtUFEmitente.Size = new System.Drawing.Size(55, 22);
            this.txtUFEmitente.TabIndex = 15;
            // 
            // lblUFEmitente
            // 
            this.lblUFEmitente.AutoSize = true;
            this.lblUFEmitente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFEmitente.Location = new System.Drawing.Point(295, 59);
            this.lblUFEmitente.Name = "lblUFEmitente";
            this.lblUFEmitente.Size = new System.Drawing.Size(21, 13);
            this.lblUFEmitente.TabIndex = 14;
            this.lblUFEmitente.Text = "UF";
            // 
            // lblArquivoXml
            // 
            this.lblArquivoXml.AutoSize = true;
            this.lblArquivoXml.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoXml.Location = new System.Drawing.Point(56, 14);
            this.lblArquivoXml.Name = "lblArquivoXml";
            this.lblArquivoXml.Size = new System.Drawing.Size(179, 13);
            this.lblArquivoXml.TabIndex = 10;
            this.lblArquivoXml.Text = "Informe a Nota Fiscal para leitura";
            // 
            // frmSerializarXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 399);
            this.Controls.Add(this.lblArquivoXml);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLerXml);
            this.Controls.Add(this.txtpathXml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSerializarXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ler Nota Fiscal";
            this.tabControl1.ResumeLayout(false);
            this.tbIdentificacao.ResumeLayout(false);
            this.tbIdentificacao.PerformLayout();
            this.tbEmitente.ResumeLayout(false);
            this.tbEmitente.PerformLayout();
            this.gbEnderecoEmitente.ResumeLayout(false);
            this.gbEnderecoEmitente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpathXml;
        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.Button btnLerXml;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbIdentificacao;
        private System.Windows.Forms.TabPage tbEmitente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNaturezaOperacao;
        private System.Windows.Forms.Label lblNaturezaOperacao;
        private System.Windows.Forms.TextBox txtDataEmissao;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtCpfCnpjEmitente;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtInscricaoEstadual;
        private System.Windows.Forms.Label lblInscricaoEstadual;
        private System.Windows.Forms.GroupBox gbEnderecoEmitente;
        private System.Windows.Forms.TextBox txtMunicipioEmitente;
        private System.Windows.Forms.Label lblMunicipioEmitente;
        private System.Windows.Forms.TextBox txtNroEmitente;
        private System.Windows.Forms.Label lblNroEmitente;
        private System.Windows.Forms.TextBox txtLogradouroEmitente;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtUFEmitente;
        private System.Windows.Forms.Label lblUFEmitente;
        private System.Windows.Forms.Label lblArquivoXml;
    }
}

