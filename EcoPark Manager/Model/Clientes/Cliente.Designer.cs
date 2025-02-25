namespace EcoPark_Manager.Model
{
    partial class Cliente
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
            this.txtObsCli = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtAddressCli = new System.Windows.Forms.TextBox();
            this.txtNameCli = new System.Windows.Forms.TextBox();
            this.lblNasc = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRgCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.dataNascCli = new System.Windows.Forms.DateTimePicker();
            this.cboxGenCli = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoparkDataSet = new EcoPark_Manager.ecoparkDataSet();
            this.clientesTableAdapter = new EcoPark_Manager.ecoparkDataSetTableAdapters.ClientesTableAdapter();
            this.txtTelCli = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfCli = new System.Windows.Forms.MaskedTextBox();
            this.cliobservacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cligenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliendereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidatanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clirg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clitelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltarCli = new System.Windows.Forms.Button();
            this.btnCancCli = new System.Windows.Forms.Button();
            this.btnGravarCli = new System.Windows.Forms.Button();
            this.btnCleanCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label9.Location = new System.Drawing.Point(468, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Clientes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtObsCli
            // 
            this.txtObsCli.Location = new System.Drawing.Point(121, 223);
            this.txtObsCli.Multiline = true;
            this.txtObsCli.Name = "txtObsCli";
            this.txtObsCli.Size = new System.Drawing.Size(473, 42);
            this.txtObsCli.TabIndex = 33;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(121, 203);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(92, 17);
            this.lblObs.TabIndex = 31;
            this.lblObs.Text = "Observações";
            // 
            // txtAddressCli
            // 
            this.txtAddressCli.Location = new System.Drawing.Point(121, 176);
            this.txtAddressCli.Name = "txtAddressCli";
            this.txtAddressCli.Size = new System.Drawing.Size(473, 20);
            this.txtAddressCli.TabIndex = 31;
            // 
            // txtNameCli
            // 
            this.txtNameCli.Location = new System.Drawing.Point(121, 82);
            this.txtNameCli.Name = "txtNameCli";
            this.txtNameCli.Size = new System.Drawing.Size(473, 20);
            this.txtNameCli.TabIndex = 26;
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.Location = new System.Drawing.Point(654, 110);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(145, 17);
            this.lblNasc.TabIndex = 24;
            this.lblNasc.Text = "Data de Nascimento *";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(654, 63);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(147, 17);
            this.lblTel.TabIndex = 23;
            this.lblTel.Text = "Numero de Telefone *";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(121, 110);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 17);
            this.lblCpf.TabIndex = 22;
            this.lblCpf.Text = "CPF *";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(121, 157);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 17);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Endereço *";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(121, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 17);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Nome Completo *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Genero *";
            // 
            // txtRgCli
            // 
            this.txtRgCli.Location = new System.Drawing.Point(383, 129);
            this.txtRgCli.Name = "txtRgCli";
            this.txtRgCli.Size = new System.Drawing.Size(211, 20);
            this.txtRgCli.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "RG *";
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.Image = global::EcoPark_Manager.Properties.Resources.publicar;
            this.btnNovoCli.Location = new System.Drawing.Point(121, 271);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(57, 30);
            this.btnNovoCli.TabIndex = 34;
            this.btnNovoCli.TabStop = false;
            this.btnNovoCli.UseVisualStyleBackColor = true;
            this.btnNovoCli.Click += new System.EventHandler(this.btnNovoCli_Click);
            // 
            // dataNascCli
            // 
            this.dataNascCli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascCli.Location = new System.Drawing.Point(654, 129);
            this.dataNascCli.Name = "dataNascCli";
            this.dataNascCli.Size = new System.Drawing.Size(203, 20);
            this.dataNascCli.TabIndex = 43;
            this.dataNascCli.Value = new System.DateTime(2024, 4, 30, 13, 52, 29, 0);
            // 
            // cboxGenCli
            // 
            this.cboxGenCli.FormattingEnabled = true;
            this.cboxGenCli.Location = new System.Drawing.Point(654, 175);
            this.cboxGenCli.Name = "cboxGenCli";
            this.cboxGenCli.Size = new System.Drawing.Size(203, 21);
            this.cboxGenCli.TabIndex = 44;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.ecoparkDataSet;
            // 
            // ecoparkDataSet
            // 
            this.ecoparkDataSet.DataSetName = "ecoparkDataSet";
            this.ecoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // txtTelCli
            // 
            this.txtTelCli.Location = new System.Drawing.Point(654, 82);
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(203, 20);
            this.txtTelCli.TabIndex = 46;
            // 
            // txtCpfCli
            // 
            this.txtCpfCli.Location = new System.Drawing.Point(121, 129);
            this.txtCpfCli.Name = "txtCpfCli";
            this.txtCpfCli.Size = new System.Drawing.Size(211, 20);
            this.txtCpfCli.TabIndex = 47;
            // 
            // cliobservacoes
            // 
            this.cliobservacoes.DataPropertyName = "cliobservacoes";
            this.cliobservacoes.FillWeight = 100.1409F;
            this.cliobservacoes.HeaderText = "Obervações";
            this.cliobservacoes.Name = "cliobservacoes";
            this.cliobservacoes.Width = 90;
            // 
            // cligenero
            // 
            this.cligenero.DataPropertyName = "cligenero";
            this.cligenero.FillWeight = 98.84574F;
            this.cligenero.HeaderText = "Genero";
            this.cligenero.Name = "cligenero";
            this.cligenero.Width = 67;
            // 
            // cliendereco
            // 
            this.cliendereco.DataPropertyName = "cliendereco";
            this.cliendereco.FillWeight = 98.07812F;
            this.cliendereco.HeaderText = "Endereço";
            this.cliendereco.Name = "cliendereco";
            this.cliendereco.Width = 78;
            // 
            // clidatanasc
            // 
            this.clidatanasc.DataPropertyName = "clidatanasc";
            this.clidatanasc.FillWeight = 97.84216F;
            this.clidatanasc.HeaderText = "Data de Nascimento";
            this.clidatanasc.Name = "clidatanasc";
            this.clidatanasc.Width = 118;
            // 
            // clirg
            // 
            this.clirg.DataPropertyName = "clirg";
            this.clirg.FillWeight = 96.90942F;
            this.clirg.HeaderText = "RG";
            this.clirg.Name = "clirg";
            this.clirg.Width = 48;
            // 
            // clicpf
            // 
            this.clicpf.DataPropertyName = "clicpf";
            this.clicpf.FillWeight = 99.16992F;
            this.clicpf.HeaderText = "CPF";
            this.clicpf.Name = "clicpf";
            this.clicpf.Width = 52;
            // 
            // clitelefone
            // 
            this.clitelefone.DataPropertyName = "clitelefone";
            this.clitelefone.FillWeight = 100.6401F;
            this.clitelefone.HeaderText = "Telefone";
            this.clitelefone.Name = "clitelefone";
            this.clitelefone.Width = 74;
            // 
            // clinome
            // 
            this.clinome.DataPropertyName = "clinome";
            this.clinome.FillWeight = 102.7657F;
            this.clinome.HeaderText = "Nome";
            this.clinome.Name = "clinome";
            this.clinome.Width = 60;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "clicodigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 65;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.clinome,
            this.clitelefone,
            this.clicpf,
            this.clirg,
            this.clidatanasc,
            this.cliendereco,
            this.cligenero,
            this.cliobservacoes});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 244);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(654, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 71);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltarCli
            // 
            this.btnVoltarCli.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltarCli.Location = new System.Drawing.Point(537, 271);
            this.btnVoltarCli.Name = "btnVoltarCli";
            this.btnVoltarCli.Size = new System.Drawing.Size(57, 30);
            this.btnVoltarCli.TabIndex = 38;
            this.btnVoltarCli.TabStop = false;
            this.btnVoltarCli.UseVisualStyleBackColor = true;
            this.btnVoltarCli.Click += new System.EventHandler(this.btnVoltarCli_Click);
            // 
            // btnCancCli
            // 
            this.btnCancCli.Image = global::EcoPark_Manager.Properties.Resources.cancelar;
            this.btnCancCli.Location = new System.Drawing.Point(433, 271);
            this.btnCancCli.Name = "btnCancCli";
            this.btnCancCli.Size = new System.Drawing.Size(57, 30);
            this.btnCancCli.TabIndex = 37;
            this.btnCancCli.TabStop = false;
            this.btnCancCli.UseVisualStyleBackColor = true;
            this.btnCancCli.Click += new System.EventHandler(this.btnCancCli_Click);
            // 
            // btnGravarCli
            // 
            this.btnGravarCli.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnGravarCli.Location = new System.Drawing.Point(225, 271);
            this.btnGravarCli.Name = "btnGravarCli";
            this.btnGravarCli.Size = new System.Drawing.Size(57, 30);
            this.btnGravarCli.TabIndex = 35;
            this.btnGravarCli.TabStop = false;
            this.btnGravarCli.UseVisualStyleBackColor = true;
            this.btnGravarCli.Click += new System.EventHandler(this.btnGravarCli_Click);
            // 
            // btnCleanCli
            // 
            this.btnCleanCli.Image = global::EcoPark_Manager.Properties.Resources.limpar_limpo;
            this.btnCleanCli.Location = new System.Drawing.Point(329, 271);
            this.btnCleanCli.Name = "btnCleanCli";
            this.btnCleanCli.Size = new System.Drawing.Size(57, 30);
            this.btnCleanCli.TabIndex = 36;
            this.btnCleanCli.TabStop = false;
            this.btnCleanCli.UseVisualStyleBackColor = true;
            this.btnCleanCli.Click += new System.EventHandler(this.btnCleanCli_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(976, 601);
            this.Controls.Add(this.txtCpfCli);
            this.Controls.Add(this.txtTelCli);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboxGenCli);
            this.Controls.Add(this.dataNascCli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovoCli);
            this.Controls.Add(this.btnVoltarCli);
            this.Controls.Add(this.btnCancCli);
            this.Controls.Add(this.txtRgCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravarCli);
            this.Controls.Add(this.btnCleanCli);
            this.Controls.Add(this.txtObsCli);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtAddressCli);
            this.Controls.Add(this.txtNameCli);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label9);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGravarCli;
        private System.Windows.Forms.Button btnCleanCli;
        private System.Windows.Forms.TextBox txtObsCli;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtAddressCli;
        private System.Windows.Forms.TextBox txtNameCli;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRgCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancCli;
        private System.Windows.Forms.Button btnVoltarCli;
        private System.Windows.Forms.Button btnNovoCli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dataNascCli;
        private System.Windows.Forms.ComboBox cboxGenCli;
        private ecoparkDataSet ecoparkDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ecoparkDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtTelCli;
        private System.Windows.Forms.MaskedTextBox txtCpfCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliobservacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cligenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliendereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidatanasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clirg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clitelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}