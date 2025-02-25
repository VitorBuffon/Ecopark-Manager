namespace EcoPark_Manager.Model.Funcionario
{
    partial class Funcionario
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxGenFunc = new System.Windows.Forms.ComboBox();
            this.lblSalFunc = new System.Windows.Forms.Label();
            this.lblGeneroFunc = new System.Windows.Forms.Label();
            this.lblAdmissaoFunc = new System.Windows.Forms.Label();
            this.txtObsFunc = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtCargoFunc = new System.Windows.Forms.TextBox();
            this.txtAddressFunc = new System.Windows.Forms.TextBox();
            this.txtNameFunc = new System.Windows.Forms.TextBox();
            this.lblCargoFunc = new System.Windows.Forms.Label();
            this.lblTelFunc = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblAddressFunc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.checkDeslFunc = new System.Windows.Forms.CheckBox();
            this.dataDeslFunc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataAdmFunc = new System.Windows.Forms.DateTimePicker();
            this.txtRgFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoparkDataSet1 = new EcoPark_Manager.ecoparkDataSet1();
            this.ecoparkDataSet = new EcoPark_Manager.ecoparkDataSet();
            this.ecoparkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoparkDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new EcoPark_Manager.ecoparkDataSet1TableAdapters.FuncionariosTableAdapter();
            this.txtCpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtTelFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtSalFunc = new System.Windows.Forms.MaskedTextBox();
            this.btnNovoFunc = new System.Windows.Forms.Button();
            this.btnVoltarFunc = new System.Windows.Forms.Button();
            this.btnCancFunc = new System.Windows.Forms.Button();
            this.btnGravarFunc = new System.Windows.Forms.Button();
            this.btnCleanFunc = new System.Windows.Forms.Button();
            this.funcobservacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcdatadesligamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcgeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcdataadmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcsalarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcenderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(609, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Funcionários";
            // 
            // cboxGenFunc
            // 
            this.cboxGenFunc.FormattingEnabled = true;
            this.cboxGenFunc.Location = new System.Drawing.Point(317, 268);
            this.cboxGenFunc.Name = "cboxGenFunc";
            this.cboxGenFunc.Size = new System.Drawing.Size(225, 21);
            this.cboxGenFunc.TabIndex = 57;
            // 
            // lblSalFunc
            // 
            this.lblSalFunc.AutoSize = true;
            this.lblSalFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFunc.Location = new System.Drawing.Point(571, 187);
            this.lblSalFunc.Name = "lblSalFunc";
            this.lblSalFunc.Size = new System.Drawing.Size(61, 17);
            this.lblSalFunc.TabIndex = 55;
            this.lblSalFunc.Text = "Salário *";
            // 
            // lblGeneroFunc
            // 
            this.lblGeneroFunc.AutoSize = true;
            this.lblGeneroFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroFunc.Location = new System.Drawing.Point(316, 248);
            this.lblGeneroFunc.Name = "lblGeneroFunc";
            this.lblGeneroFunc.Size = new System.Drawing.Size(65, 17);
            this.lblGeneroFunc.TabIndex = 54;
            this.lblGeneroFunc.Text = "Genero *";
            // 
            // lblAdmissaoFunc
            // 
            this.lblAdmissaoFunc.AutoSize = true;
            this.lblAdmissaoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissaoFunc.Location = new System.Drawing.Point(827, 188);
            this.lblAdmissaoFunc.Name = "lblAdmissaoFunc";
            this.lblAdmissaoFunc.Size = new System.Drawing.Size(132, 17);
            this.lblAdmissaoFunc.TabIndex = 52;
            this.lblAdmissaoFunc.Text = "Data de Admissão *";
            // 
            // txtObsFunc
            // 
            this.txtObsFunc.Location = new System.Drawing.Point(317, 327);
            this.txtObsFunc.Multiline = true;
            this.txtObsFunc.Name = "txtObsFunc";
            this.txtObsFunc.Size = new System.Drawing.Size(709, 53);
            this.txtObsFunc.TabIndex = 51;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(316, 307);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(92, 17);
            this.lblObs.TabIndex = 50;
            this.lblObs.Text = "Observações";
            // 
            // txtCargoFunc
            // 
            this.txtCargoFunc.Location = new System.Drawing.Point(317, 208);
            this.txtCargoFunc.Name = "txtCargoFunc";
            this.txtCargoFunc.Size = new System.Drawing.Size(225, 20);
            this.txtCargoFunc.TabIndex = 49;
            // 
            // txtAddressFunc
            // 
            this.txtAddressFunc.Location = new System.Drawing.Point(317, 153);
            this.txtAddressFunc.Name = "txtAddressFunc";
            this.txtAddressFunc.Size = new System.Drawing.Size(470, 20);
            this.txtAddressFunc.TabIndex = 46;
            // 
            // txtNameFunc
            // 
            this.txtNameFunc.Location = new System.Drawing.Point(317, 95);
            this.txtNameFunc.Name = "txtNameFunc";
            this.txtNameFunc.Size = new System.Drawing.Size(470, 20);
            this.txtNameFunc.TabIndex = 45;
            // 
            // lblCargoFunc
            // 
            this.lblCargoFunc.AutoSize = true;
            this.lblCargoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoFunc.Location = new System.Drawing.Point(316, 188);
            this.lblCargoFunc.Name = "lblCargoFunc";
            this.lblCargoFunc.Size = new System.Drawing.Size(55, 17);
            this.lblCargoFunc.TabIndex = 44;
            this.lblCargoFunc.Text = "Cargo *";
            // 
            // lblTelFunc
            // 
            this.lblTelFunc.AutoSize = true;
            this.lblTelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFunc.Location = new System.Drawing.Point(570, 248);
            this.lblTelFunc.Name = "lblTelFunc";
            this.lblTelFunc.Size = new System.Drawing.Size(147, 17);
            this.lblTelFunc.TabIndex = 43;
            this.lblTelFunc.Text = "Numero de Telefone *";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(827, 75);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 17);
            this.lblCpf.TabIndex = 42;
            this.lblCpf.Text = "CPF *";
            // 
            // lblAddressFunc
            // 
            this.lblAddressFunc.AutoSize = true;
            this.lblAddressFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressFunc.Location = new System.Drawing.Point(316, 133);
            this.lblAddressFunc.Name = "lblAddressFunc";
            this.lblAddressFunc.Size = new System.Drawing.Size(78, 17);
            this.lblAddressFunc.TabIndex = 41;
            this.lblAddressFunc.Text = "Endereço *";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(316, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 17);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Nome Completo *";
            // 
            // checkDeslFunc
            // 
            this.checkDeslFunc.AutoSize = true;
            this.checkDeslFunc.Location = new System.Drawing.Point(829, 294);
            this.checkDeslFunc.Name = "checkDeslFunc";
            this.checkDeslFunc.Size = new System.Drawing.Size(131, 17);
            this.checkDeslFunc.TabIndex = 58;
            this.checkDeslFunc.Text = "Funcionário Desligado";
            this.checkDeslFunc.UseVisualStyleBackColor = true;
            this.checkDeslFunc.CheckedChanged += new System.EventHandler(this.checkDeslFunc_CheckedChanged_1);
            // 
            // dataDeslFunc
            // 
            this.dataDeslFunc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDeslFunc.Location = new System.Drawing.Point(829, 269);
            this.dataDeslFunc.Name = "dataDeslFunc";
            this.dataDeslFunc.Size = new System.Drawing.Size(197, 20);
            this.dataDeslFunc.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Data de Desligamento *";
            // 
            // dataAdmFunc
            // 
            this.dataAdmFunc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAdmFunc.Location = new System.Drawing.Point(829, 208);
            this.dataAdmFunc.Name = "dataAdmFunc";
            this.dataAdmFunc.Size = new System.Drawing.Size(197, 20);
            this.dataAdmFunc.TabIndex = 61;
            // 
            // txtRgFunc
            // 
            this.txtRgFunc.Location = new System.Drawing.Point(829, 153);
            this.txtRgFunc.Name = "txtRgFunc";
            this.txtRgFunc.Size = new System.Drawing.Size(197, 20);
            this.txtRgFunc.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "RG *";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.ecoparkDataSet1;
            // 
            // ecoparkDataSet1
            // 
            this.ecoparkDataSet1.DataSetName = "ecoparkDataSet1";
            this.ecoparkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ecoparkDataSet
            // 
            this.ecoparkDataSet.DataSetName = "ecoparkDataSet";
            this.ecoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ecoparkDataSetBindingSource
            // 
            this.ecoparkDataSetBindingSource.DataSource = this.ecoparkDataSet;
            this.ecoparkDataSetBindingSource.Position = 0;
            // 
            // ecoparkDataSetBindingSource1
            // 
            this.ecoparkDataSetBindingSource1.DataSource = this.ecoparkDataSet;
            this.ecoparkDataSetBindingSource1.Position = 0;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // txtCpfFunc
            // 
            this.txtCpfFunc.Location = new System.Drawing.Point(830, 95);
            this.txtCpfFunc.Name = "txtCpfFunc";
            this.txtCpfFunc.Size = new System.Drawing.Size(196, 20);
            this.txtCpfFunc.TabIndex = 65;
            // 
            // txtTelFunc
            // 
            this.txtTelFunc.Location = new System.Drawing.Point(572, 269);
            this.txtTelFunc.Name = "txtTelFunc";
            this.txtTelFunc.Size = new System.Drawing.Size(225, 20);
            this.txtTelFunc.TabIndex = 66;
            // 
            // txtSalFunc
            // 
            this.txtSalFunc.Location = new System.Drawing.Point(572, 208);
            this.txtSalFunc.Name = "txtSalFunc";
            this.txtSalFunc.Size = new System.Drawing.Size(225, 20);
            this.txtSalFunc.TabIndex = 67;
            // 
            // btnNovoFunc
            // 
            this.btnNovoFunc.Image = global::EcoPark_Manager.Properties.Resources.publicar;
            this.btnNovoFunc.Location = new System.Drawing.Point(361, 394);
            this.btnNovoFunc.Name = "btnNovoFunc";
            this.btnNovoFunc.Size = new System.Drawing.Size(82, 31);
            this.btnNovoFunc.TabIndex = 68;
            this.btnNovoFunc.TabStop = false;
            this.btnNovoFunc.UseVisualStyleBackColor = true;
            this.btnNovoFunc.Click += new System.EventHandler(this.btnNovoFunc_Click);
            // 
            // btnVoltarFunc
            // 
            this.btnVoltarFunc.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltarFunc.Location = new System.Drawing.Point(901, 394);
            this.btnVoltarFunc.Name = "btnVoltarFunc";
            this.btnVoltarFunc.Size = new System.Drawing.Size(82, 31);
            this.btnVoltarFunc.TabIndex = 72;
            this.btnVoltarFunc.TabStop = false;
            this.btnVoltarFunc.UseVisualStyleBackColor = true;
            this.btnVoltarFunc.Click += new System.EventHandler(this.btnVoltarFunc_Click);
            // 
            // btnCancFunc
            // 
            this.btnCancFunc.Image = global::EcoPark_Manager.Properties.Resources.cancelar;
            this.btnCancFunc.Location = new System.Drawing.Point(766, 394);
            this.btnCancFunc.Name = "btnCancFunc";
            this.btnCancFunc.Size = new System.Drawing.Size(82, 31);
            this.btnCancFunc.TabIndex = 71;
            this.btnCancFunc.TabStop = false;
            this.btnCancFunc.UseVisualStyleBackColor = true;
            this.btnCancFunc.Click += new System.EventHandler(this.btnCancFunc_Click);
            // 
            // btnGravarFunc
            // 
            this.btnGravarFunc.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnGravarFunc.Location = new System.Drawing.Point(496, 394);
            this.btnGravarFunc.Name = "btnGravarFunc";
            this.btnGravarFunc.Size = new System.Drawing.Size(82, 31);
            this.btnGravarFunc.TabIndex = 69;
            this.btnGravarFunc.TabStop = false;
            this.btnGravarFunc.UseVisualStyleBackColor = true;
            this.btnGravarFunc.Click += new System.EventHandler(this.btnGravarFunc_Click);
            // 
            // btnCleanFunc
            // 
            this.btnCleanFunc.Image = global::EcoPark_Manager.Properties.Resources.limpar_limpo;
            this.btnCleanFunc.Location = new System.Drawing.Point(631, 394);
            this.btnCleanFunc.Name = "btnCleanFunc";
            this.btnCleanFunc.Size = new System.Drawing.Size(82, 31);
            this.btnCleanFunc.TabIndex = 70;
            this.btnCleanFunc.TabStop = false;
            this.btnCleanFunc.UseVisualStyleBackColor = true;
            this.btnCleanFunc.Click += new System.EventHandler(this.btnCleanFunc_Click);
            // 
            // funcobservacoesDataGridViewTextBoxColumn
            // 
            this.funcobservacoesDataGridViewTextBoxColumn.DataPropertyName = "funcobservacoes";
            this.funcobservacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.funcobservacoesDataGridViewTextBoxColumn.Name = "funcobservacoesDataGridViewTextBoxColumn";
            // 
            // funcdatadesligamentoDataGridViewTextBoxColumn
            // 
            this.funcdatadesligamentoDataGridViewTextBoxColumn.DataPropertyName = "funcdata_desligamento";
            this.funcdatadesligamentoDataGridViewTextBoxColumn.HeaderText = "Data de Desligamento";
            this.funcdatadesligamentoDataGridViewTextBoxColumn.Name = "funcdatadesligamentoDataGridViewTextBoxColumn";
            // 
            // functelefoneDataGridViewTextBoxColumn
            // 
            this.functelefoneDataGridViewTextBoxColumn.DataPropertyName = "functelefone";
            this.functelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.functelefoneDataGridViewTextBoxColumn.Name = "functelefoneDataGridViewTextBoxColumn";
            // 
            // funcgeneroDataGridViewTextBoxColumn
            // 
            this.funcgeneroDataGridViewTextBoxColumn.DataPropertyName = "funcgenero";
            this.funcgeneroDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.funcgeneroDataGridViewTextBoxColumn.Name = "funcgeneroDataGridViewTextBoxColumn";
            // 
            // funcdataadmissaoDataGridViewTextBoxColumn
            // 
            this.funcdataadmissaoDataGridViewTextBoxColumn.DataPropertyName = "funcdata_admissao";
            this.funcdataadmissaoDataGridViewTextBoxColumn.HeaderText = "Data de Admissão";
            this.funcdataadmissaoDataGridViewTextBoxColumn.Name = "funcdataadmissaoDataGridViewTextBoxColumn";
            // 
            // funcsalarioDataGridViewTextBoxColumn
            // 
            this.funcsalarioDataGridViewTextBoxColumn.DataPropertyName = "funcsalario";
            this.funcsalarioDataGridViewTextBoxColumn.HeaderText = "Salário";
            this.funcsalarioDataGridViewTextBoxColumn.Name = "funcsalarioDataGridViewTextBoxColumn";
            // 
            // funccargoDataGridViewTextBoxColumn
            // 
            this.funccargoDataGridViewTextBoxColumn.DataPropertyName = "funccargo";
            this.funccargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.funccargoDataGridViewTextBoxColumn.Name = "funccargoDataGridViewTextBoxColumn";
            // 
            // funcrgDataGridViewTextBoxColumn
            // 
            this.funcrgDataGridViewTextBoxColumn.DataPropertyName = "funcrg";
            this.funcrgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.funcrgDataGridViewTextBoxColumn.Name = "funcrgDataGridViewTextBoxColumn";
            // 
            // funcenderecoDataGridViewTextBoxColumn
            // 
            this.funcenderecoDataGridViewTextBoxColumn.DataPropertyName = "funcendereco";
            this.funcenderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.funcenderecoDataGridViewTextBoxColumn.Name = "funcenderecoDataGridViewTextBoxColumn";
            // 
            // funccpfDataGridViewTextBoxColumn
            // 
            this.funccpfDataGridViewTextBoxColumn.DataPropertyName = "funccpf";
            this.funccpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.funccpfDataGridViewTextBoxColumn.Name = "funccpfDataGridViewTextBoxColumn";
            // 
            // funcnomeDataGridViewTextBoxColumn
            // 
            this.funcnomeDataGridViewTextBoxColumn.DataPropertyName = "funcnome";
            this.funcnomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.funcnomeDataGridViewTextBoxColumn.Name = "funcnomeDataGridViewTextBoxColumn";
            // 
            // funccodigoDataGridViewTextBoxColumn
            // 
            this.funccodigoDataGridViewTextBoxColumn.DataPropertyName = "funccodigo";
            this.funccodigoDataGridViewTextBoxColumn.HeaderText = "funccodigo";
            this.funccodigoDataGridViewTextBoxColumn.Name = "funccodigoDataGridViewTextBoxColumn";
            this.funccodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.funccodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funccodigoDataGridViewTextBoxColumn,
            this.funcnomeDataGridViewTextBoxColumn,
            this.funccpfDataGridViewTextBoxColumn,
            this.funcenderecoDataGridViewTextBoxColumn,
            this.funcrgDataGridViewTextBoxColumn,
            this.funccargoDataGridViewTextBoxColumn,
            this.funcsalarioDataGridViewTextBoxColumn,
            this.funcdataadmissaoDataGridViewTextBoxColumn,
            this.funcgeneroDataGridViewTextBoxColumn,
            this.functelefoneDataGridViewTextBoxColumn,
            this.funcdatadesligamentoDataGridViewTextBoxColumn,
            this.funcobservacoesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(115, 455);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 201);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "R$";
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1352, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovoFunc);
            this.Controls.Add(this.btnVoltarFunc);
            this.Controls.Add(this.btnCancFunc);
            this.Controls.Add(this.btnGravarFunc);
            this.Controls.Add(this.btnCleanFunc);
            this.Controls.Add(this.txtSalFunc);
            this.Controls.Add(this.txtTelFunc);
            this.Controls.Add(this.txtCpfFunc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRgFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataAdmFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDeslFunc);
            this.Controls.Add(this.checkDeslFunc);
            this.Controls.Add(this.cboxGenFunc);
            this.Controls.Add(this.lblSalFunc);
            this.Controls.Add(this.lblGeneroFunc);
            this.Controls.Add(this.lblAdmissaoFunc);
            this.Controls.Add(this.txtObsFunc);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtCargoFunc);
            this.Controls.Add(this.txtAddressFunc);
            this.Controls.Add(this.txtNameFunc);
            this.Controls.Add(this.lblCargoFunc);
            this.Controls.Add(this.lblTelFunc);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblAddressFunc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label9);
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxGenFunc;
        private System.Windows.Forms.Label lblSalFunc;
        private System.Windows.Forms.Label lblGeneroFunc;
        private System.Windows.Forms.Label lblAdmissaoFunc;
        private System.Windows.Forms.TextBox txtObsFunc;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtCargoFunc;
        private System.Windows.Forms.TextBox txtAddressFunc;
        private System.Windows.Forms.TextBox txtNameFunc;
        private System.Windows.Forms.Label lblCargoFunc;
        private System.Windows.Forms.Label lblTelFunc;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblAddressFunc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkDeslFunc;
        private System.Windows.Forms.DateTimePicker dataDeslFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataAdmFunc;
        private System.Windows.Forms.TextBox txtRgFunc;
        private System.Windows.Forms.Label label2;
        private ecoparkDataSet ecoparkDataSet;
        private System.Windows.Forms.BindingSource ecoparkDataSetBindingSource;
        private System.Windows.Forms.BindingSource ecoparkDataSetBindingSource1;
        private ecoparkDataSet1 ecoparkDataSet1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private ecoparkDataSet1TableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtCpfFunc;
        private System.Windows.Forms.MaskedTextBox txtTelFunc;
        private System.Windows.Forms.MaskedTextBox txtSalFunc;
        private System.Windows.Forms.Button btnNovoFunc;
        private System.Windows.Forms.Button btnVoltarFunc;
        private System.Windows.Forms.Button btnCancFunc;
        private System.Windows.Forms.Button btnGravarFunc;
        private System.Windows.Forms.Button btnCleanFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcobservacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcdatadesligamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcgeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcdataadmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcsalarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}