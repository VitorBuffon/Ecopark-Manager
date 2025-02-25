namespace EcoPark_Manager.Model.Reservas
{
    partial class Reservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.resercodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alocodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resdatainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resdatafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resvalorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoparkDataSet2 = new EcoPark_Manager.ecoparkDataSet2();
            this.cboxTipoAlojamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxStatusAlojamento = new System.Windows.Forms.ComboBox();
            this.txtNumeroAlojamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reservaTableAdapter = new EcoPark_Manager.ecoparkDataSet2TableAdapters.ReservaTableAdapter();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.btnSairRes = new System.Windows.Forms.Button();
            this.btnNovaReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AutoGenerateColumns = false;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resercodigoDataGridViewTextBoxColumn,
            this.alocodigoDataGridViewTextBoxColumn,
            this.clicodigoDataGridViewTextBoxColumn,
            this.resdatainicioDataGridViewTextBoxColumn,
            this.resdatafimDataGridViewTextBoxColumn,
            this.resvalorDataGridViewTextBoxColumn});
            this.dgvReservas.DataSource = this.reservaBindingSource;
            this.dgvReservas.Location = new System.Drawing.Point(72, 113);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(542, 256);
            this.dgvReservas.TabIndex = 37;
            // 
            // resercodigoDataGridViewTextBoxColumn
            // 
            this.resercodigoDataGridViewTextBoxColumn.DataPropertyName = "resercodigo";
            this.resercodigoDataGridViewTextBoxColumn.HeaderText = "resercodigo";
            this.resercodigoDataGridViewTextBoxColumn.Name = "resercodigoDataGridViewTextBoxColumn";
            this.resercodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.resercodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // alocodigoDataGridViewTextBoxColumn
            // 
            this.alocodigoDataGridViewTextBoxColumn.DataPropertyName = "alocodigo";
            this.alocodigoDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.alocodigoDataGridViewTextBoxColumn.Name = "alocodigoDataGridViewTextBoxColumn";
            // 
            // clicodigoDataGridViewTextBoxColumn
            // 
            this.clicodigoDataGridViewTextBoxColumn.DataPropertyName = "clicodigo";
            this.clicodigoDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clicodigoDataGridViewTextBoxColumn.Name = "clicodigoDataGridViewTextBoxColumn";
            // 
            // resdatainicioDataGridViewTextBoxColumn
            // 
            this.resdatainicioDataGridViewTextBoxColumn.DataPropertyName = "resdata_inicio";
            this.resdatainicioDataGridViewTextBoxColumn.HeaderText = "Data de entrada";
            this.resdatainicioDataGridViewTextBoxColumn.Name = "resdatainicioDataGridViewTextBoxColumn";
            // 
            // resdatafimDataGridViewTextBoxColumn
            // 
            this.resdatafimDataGridViewTextBoxColumn.DataPropertyName = "resdata_fim";
            this.resdatafimDataGridViewTextBoxColumn.HeaderText = "Data de saída";
            this.resdatafimDataGridViewTextBoxColumn.Name = "resdatafimDataGridViewTextBoxColumn";
            // 
            // resvalorDataGridViewTextBoxColumn
            // 
            this.resvalorDataGridViewTextBoxColumn.DataPropertyName = "resvalor";
            this.resvalorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.resvalorDataGridViewTextBoxColumn.Name = "resvalorDataGridViewTextBoxColumn";
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.ecoparkDataSet2;
            // 
            // ecoparkDataSet2
            // 
            this.ecoparkDataSet2.DataSetName = "ecoparkDataSet2";
            this.ecoparkDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxTipoAlojamento
            // 
            this.cboxTipoAlojamento.FormattingEnabled = true;
            this.cboxTipoAlojamento.Location = new System.Drawing.Point(224, 87);
            this.cboxTipoAlojamento.Name = "cboxTipoAlojamento";
            this.cboxTipoAlojamento.Size = new System.Drawing.Size(88, 21);
            this.cboxTipoAlojamento.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tipo";
            // 
            // cboxStatusAlojamento
            // 
            this.cboxStatusAlojamento.FormattingEnabled = true;
            this.cboxStatusAlojamento.Location = new System.Drawing.Point(346, 87);
            this.cboxStatusAlojamento.Name = "cboxStatusAlojamento";
            this.cboxStatusAlojamento.Size = new System.Drawing.Size(88, 21);
            this.cboxStatusAlojamento.TabIndex = 41;
            // 
            // txtNumeroAlojamento
            // 
            this.txtNumeroAlojamento.Location = new System.Drawing.Point(463, 87);
            this.txtNumeroAlojamento.Name = "txtNumeroAlojamento";
            this.txtNumeroAlojamento.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroAlojamento.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Numero";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(72, 87);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(118, 20);
            this.txtNomeCliente.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nome do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Status ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Alojamento";
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Image = global::EcoPark_Manager.Properties.Resources.filtro__1_;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(535, 83);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(79, 27);
            this.btnAplicarFiltros.TabIndex = 38;
            this.btnAplicarFiltros.TabStop = false;
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            // 
            // btnSairRes
            // 
            this.btnSairRes.Image = global::EcoPark_Manager.Properties.Resources.arrowiosbackoutline_110927;
            this.btnSairRes.Location = new System.Drawing.Point(72, 375);
            this.btnSairRes.Name = "btnSairRes";
            this.btnSairRes.Size = new System.Drawing.Size(38, 37);
            this.btnSairRes.TabIndex = 36;
            this.btnSairRes.TabStop = false;
            this.btnSairRes.UseVisualStyleBackColor = true;
            this.btnSairRes.Click += new System.EventHandler(this.btnSairRes_Click);
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnNovaReserva.Location = new System.Drawing.Point(576, 375);
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(38, 37);
            this.btnNovaReserva.TabIndex = 30;
            this.btnNovaReserva.TabStop = false;
            this.btnNovaReserva.UseVisualStyleBackColor = true;
            this.btnNovaReserva.Click += new System.EventHandler(this.btnNovaRes_Click);
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(684, 569);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroAlojamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxStatusAlojamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxTipoAlojamento);
            this.Controls.Add(this.btnAplicarFiltros);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnSairRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovaReserva);
            this.Name = "Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoparkDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaReserva;
        private System.Windows.Forms.Button btnSairRes;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.ComboBox cboxTipoAlojamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxStatusAlojamento;
        private System.Windows.Forms.TextBox txtNumeroAlojamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private ecoparkDataSet2 ecoparkDataSet2;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private ecoparkDataSet2TableAdapters.ReservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resercodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alocodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resdatainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resdatafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resvalorDataGridViewTextBoxColumn;
    }
}