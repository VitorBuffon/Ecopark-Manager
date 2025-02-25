namespace EcoPark_Manager.Model
{
    partial class Estoques
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
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bancoProduto = new EcoPark_Manager.bancoProduto();
            this.tboxNameProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxFornProd = new System.Windows.Forms.ComboBox();
            this.cboxMarcProd = new System.Windows.Forms.ComboBox();
            this.tboxObsProd = new System.Windows.Forms.TextBox();
            this.checkBoxItemPerecivel = new System.Windows.Forms.CheckBox();
            this.dateTimeValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.tBoxPrecoProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericQuantProd = new System.Windows.Forms.NumericUpDown();
            this.cboxUniMedProd = new System.Windows.Forms.ComboBox();
            this.btnNovoForn = new System.Windows.Forms.Button();
            this.btnNovaMarc = new System.Windows.Forms.Button();
            this.cboxCateProd = new System.Windows.Forms.ComboBox();
            this.produtoTableAdapter = new EcoPark_Manager.bancoProdutoTableAdapters.ProdutoTableAdapter();
            this.btnNovaCate = new System.Windows.Forms.Button();
            this.btnNovoProd = new System.Windows.Forms.Button();
            this.btnVoltarProd = new System.Windows.Forms.Button();
            this.btnCancProd = new System.Windows.Forms.Button();
            this.btnGravarProd = new System.Windows.Forms.Button();
            this.btnCleanProd = new System.Windows.Forms.Button();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoparkDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AutoGenerateColumns = false;
            this.dgvProd.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvProd.DataSource = this.produtoBindingSource1;
            this.dgvProd.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProd.Location = new System.Drawing.Point(58, 560);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(1146, 219);
            this.dgvProd.TabIndex = 0;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "prodcodigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prodnome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prodcatecodigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prodmarccodigo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prodforncodigo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "produnidademedida";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unidade de Medida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "prodquantidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "proddatavalidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data de Validade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prodpreco";
            this.dataGridViewTextBoxColumn9.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "prodobservacao";
            this.dataGridViewTextBoxColumn10.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "prodlote";
            this.dataGridViewTextBoxColumn11.HeaderText = "Lote";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.bancoProduto;
            // 
            // bancoProduto
            // 
            this.bancoProduto.DataSetName = "bancoProduto";
            this.bancoProduto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tboxNameProd
            // 
            this.tboxNameProd.Location = new System.Drawing.Point(119, 92);
            this.tboxNameProd.Name = "tboxNameProd";
            this.tboxNameProd.Size = new System.Drawing.Size(268, 20);
            this.tboxNameProd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidade de Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Observações";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fornecedor";
            // 
            // cboxFornProd
            // 
            this.cboxFornProd.FormattingEnabled = true;
            this.cboxFornProd.Location = new System.Drawing.Point(586, 92);
            this.cboxFornProd.Name = "cboxFornProd";
            this.cboxFornProd.Size = new System.Drawing.Size(253, 21);
            this.cboxFornProd.TabIndex = 13;
            // 
            // cboxMarcProd
            // 
            this.cboxMarcProd.FormattingEnabled = true;
            this.cboxMarcProd.Location = new System.Drawing.Point(586, 171);
            this.cboxMarcProd.Name = "cboxMarcProd";
            this.cboxMarcProd.Size = new System.Drawing.Size(253, 21);
            this.cboxMarcProd.TabIndex = 14;
            // 
            // tboxObsProd
            // 
            this.tboxObsProd.Location = new System.Drawing.Point(124, 404);
            this.tboxObsProd.Multiline = true;
            this.tboxObsProd.Name = "tboxObsProd";
            this.tboxObsProd.Size = new System.Drawing.Size(723, 75);
            this.tboxObsProd.TabIndex = 15;
            // 
            // checkBoxItemPerecivel
            // 
            this.checkBoxItemPerecivel.AutoSize = true;
            this.checkBoxItemPerecivel.Location = new System.Drawing.Point(845, 331);
            this.checkBoxItemPerecivel.Name = "checkBoxItemPerecivel";
            this.checkBoxItemPerecivel.Size = new System.Drawing.Size(94, 17);
            this.checkBoxItemPerecivel.TabIndex = 16;
            this.checkBoxItemPerecivel.Text = "Item perecível";
            this.checkBoxItemPerecivel.UseVisualStyleBackColor = true;
            this.checkBoxItemPerecivel.CheckedChanged += new System.EventHandler(this.checkBoxItemPerecivel_CheckedChanged);
            // 
            // dateTimeValidade
            // 
            this.dateTimeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeValidade.Location = new System.Drawing.Point(586, 329);
            this.dateTimeValidade.Name = "dateTimeValidade";
            this.dateTimeValidade.Size = new System.Drawing.Size(253, 20);
            this.dateTimeValidade.TabIndex = 17;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.Location = new System.Drawing.Point(586, 298);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(177, 25);
            this.lblDataValidade.TabIndex = 18;
            this.lblDataValidade.Text = "Data de Validade";
            // 
            // tBoxPrecoProd
            // 
            this.tBoxPrecoProd.Location = new System.Drawing.Point(586, 254);
            this.tBoxPrecoProd.Name = "tBoxPrecoProd";
            this.tBoxPrecoProd.Size = new System.Drawing.Size(253, 20);
            this.tBoxPrecoProd.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Preço";
            // 
            // numericQuantProd
            // 
            this.numericQuantProd.Location = new System.Drawing.Point(119, 330);
            this.numericQuantProd.Name = "numericQuantProd";
            this.numericQuantProd.Size = new System.Drawing.Size(268, 20);
            this.numericQuantProd.TabIndex = 21;
            // 
            // cboxUniMedProd
            // 
            this.cboxUniMedProd.FormattingEnabled = true;
            this.cboxUniMedProd.Location = new System.Drawing.Point(119, 254);
            this.cboxUniMedProd.Name = "cboxUniMedProd";
            this.cboxUniMedProd.Size = new System.Drawing.Size(268, 21);
            this.cboxUniMedProd.TabIndex = 22;
            // 
            // btnNovoForn
            // 
            this.btnNovoForn.Image = global::EcoPark_Manager.Properties.Resources.publicar;
            this.btnNovoForn.Location = new System.Drawing.Point(845, 92);
            this.btnNovoForn.Name = "btnNovoForn";
            this.btnNovoForn.Size = new System.Drawing.Size(30, 23);
            this.btnNovoForn.TabIndex = 23;
            this.btnNovoForn.UseVisualStyleBackColor = true;
            this.btnNovoForn.Click += new System.EventHandler(this.btnNovoForn_Click);
            // 
            // btnNovaMarc
            // 
            this.btnNovaMarc.Image = global::EcoPark_Manager.Properties.Resources.publicar;
            this.btnNovaMarc.Location = new System.Drawing.Point(845, 169);
            this.btnNovaMarc.Name = "btnNovaMarc";
            this.btnNovaMarc.Size = new System.Drawing.Size(30, 23);
            this.btnNovaMarc.TabIndex = 24;
            this.btnNovaMarc.UseVisualStyleBackColor = true;
            this.btnNovaMarc.Click += new System.EventHandler(this.btnNovaMarc_Click);
            // 
            // cboxCateProd
            // 
            this.cboxCateProd.FormattingEnabled = true;
            this.cboxCateProd.Location = new System.Drawing.Point(119, 171);
            this.cboxCateProd.Name = "cboxCateProd";
            this.cboxCateProd.Size = new System.Drawing.Size(268, 21);
            this.cboxCateProd.TabIndex = 25;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btnNovaCate
            // 
            this.btnNovaCate.Image = global::EcoPark_Manager.Properties.Resources.adicionar;
            this.btnNovaCate.Location = new System.Drawing.Point(393, 169);
            this.btnNovaCate.Name = "btnNovaCate";
            this.btnNovaCate.Size = new System.Drawing.Size(36, 23);
            this.btnNovaCate.TabIndex = 44;
            this.btnNovaCate.UseVisualStyleBackColor = true;
            this.btnNovaCate.Click += new System.EventHandler(this.btnNovaCate_Click);
            // 
            // btnNovoProd
            // 
            this.btnNovoProd.Image = global::EcoPark_Manager.Properties.Resources.publicar;
            this.btnNovoProd.Location = new System.Drawing.Point(122, 498);
            this.btnNovoProd.Name = "btnNovoProd";
            this.btnNovoProd.Size = new System.Drawing.Size(77, 30);
            this.btnNovoProd.TabIndex = 39;
            this.btnNovoProd.TabStop = false;
            this.btnNovoProd.UseVisualStyleBackColor = true;
            this.btnNovoProd.Click += new System.EventHandler(this.btnNovoProd_Click);
            // 
            // btnVoltarProd
            // 
            this.btnVoltarProd.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltarProd.Location = new System.Drawing.Point(764, 498);
            this.btnVoltarProd.Name = "btnVoltarProd";
            this.btnVoltarProd.Size = new System.Drawing.Size(77, 30);
            this.btnVoltarProd.TabIndex = 43;
            this.btnVoltarProd.TabStop = false;
            this.btnVoltarProd.UseVisualStyleBackColor = true;
            this.btnVoltarProd.Click += new System.EventHandler(this.btnVoltarProd_Click);
            // 
            // btnCancProd
            // 
            this.btnCancProd.Image = global::EcoPark_Manager.Properties.Resources.cancelar;
            this.btnCancProd.Location = new System.Drawing.Point(604, 498);
            this.btnCancProd.Name = "btnCancProd";
            this.btnCancProd.Size = new System.Drawing.Size(77, 30);
            this.btnCancProd.TabIndex = 42;
            this.btnCancProd.TabStop = false;
            this.btnCancProd.UseVisualStyleBackColor = true;
            this.btnCancProd.Click += new System.EventHandler(this.btnCancProd_Click);
            // 
            // btnGravarProd
            // 
            this.btnGravarProd.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnGravarProd.Location = new System.Drawing.Point(284, 498);
            this.btnGravarProd.Name = "btnGravarProd";
            this.btnGravarProd.Size = new System.Drawing.Size(77, 30);
            this.btnGravarProd.TabIndex = 40;
            this.btnGravarProd.TabStop = false;
            this.btnGravarProd.UseVisualStyleBackColor = true;
            this.btnGravarProd.Click += new System.EventHandler(this.btnGravarProd_Click);
            // 
            // btnCleanProd
            // 
            this.btnCleanProd.Image = global::EcoPark_Manager.Properties.Resources.limpar_limpo;
            this.btnCleanProd.Location = new System.Drawing.Point(444, 498);
            this.btnCleanProd.Name = "btnCleanProd";
            this.btnCleanProd.Size = new System.Drawing.Size(77, 30);
            this.btnCleanProd.TabIndex = 41;
            this.btnCleanProd.TabStop = false;
            this.btnCleanProd.UseVisualStyleBackColor = true;
            this.btnCleanProd.Click += new System.EventHandler(this.btnCleanProd_Click);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            // 
            // Estoques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1234, 823);
            this.Controls.Add(this.btnNovaCate);
            this.Controls.Add(this.btnNovoProd);
            this.Controls.Add(this.btnVoltarProd);
            this.Controls.Add(this.btnCancProd);
            this.Controls.Add(this.btnGravarProd);
            this.Controls.Add(this.btnCleanProd);
            this.Controls.Add(this.cboxCateProd);
            this.Controls.Add(this.btnNovaMarc);
            this.Controls.Add(this.btnNovoForn);
            this.Controls.Add(this.cboxUniMedProd);
            this.Controls.Add(this.numericQuantProd);
            this.Controls.Add(this.tBoxPrecoProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDataValidade);
            this.Controls.Add(this.dateTimeValidade);
            this.Controls.Add(this.checkBoxItemPerecivel);
            this.Controls.Add(this.tboxObsProd);
            this.Controls.Add(this.cboxMarcProd);
            this.Controls.Add(this.cboxFornProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNameProd);
            this.Controls.Add(this.dgvProd);
            this.Name = "Estoques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.TextBox tboxNameProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxFornProd;
        private System.Windows.Forms.ComboBox cboxMarcProd;
        private System.Windows.Forms.TextBox tboxObsProd;
        private System.Windows.Forms.CheckBox checkBoxItemPerecivel;
        private System.Windows.Forms.DateTimePicker dateTimeValidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.TextBox tBoxPrecoProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericQuantProd;
        private System.Windows.Forms.ComboBox cboxUniMedProd;
        private System.Windows.Forms.Button btnNovoForn;
        private System.Windows.Forms.Button btnNovaMarc;
        private System.Windows.Forms.ComboBox cboxCateProd;
        private System.Windows.Forms.Button btnNovoProd;
        private System.Windows.Forms.Button btnVoltarProd;
        private System.Windows.Forms.Button btnCancProd;
        private System.Windows.Forms.Button btnGravarProd;
        private System.Windows.Forms.Button btnCleanProd;
        private System.Windows.Forms.Button btnNovaCate;
        private System.Windows.Forms.BindingSource ecoparkDataSet2BindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcatecodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodmarccodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodforncodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnidademedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proddatavalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodobservacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodloteDataGridViewTextBoxColumn;
        private bancoProduto bancoProduto;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private bancoProdutoTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}