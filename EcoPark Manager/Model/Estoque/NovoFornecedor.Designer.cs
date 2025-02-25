namespace EcoPark_Manager.Model.Estoque
{
    partial class NovoFornecedor
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
            this.btnVoltarForn = new System.Windows.Forms.Button();
            this.btnGravarForn = new System.Windows.Forms.Button();
            this.btnCleanForn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNomeForn = new System.Windows.Forms.TextBox();
            this.cboxCpfForn = new System.Windows.Forms.CheckBox();
            this.cboxCnpjForn = new System.Windows.Forms.CheckBox();
            this.MasCpfCnpjForn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxEnderecoForn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxCidadeForn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxObsForn = new System.Windows.Forms.TextBox();
            this.MasNumeroContato = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnVoltarForn
            // 
            this.btnVoltarForn.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltarForn.Location = new System.Drawing.Point(10, 378);
            this.btnVoltarForn.Name = "btnVoltarForn";
            this.btnVoltarForn.Size = new System.Drawing.Size(77, 30);
            this.btnVoltarForn.TabIndex = 52;
            this.btnVoltarForn.TabStop = false;
            this.btnVoltarForn.UseVisualStyleBackColor = true;
            this.btnVoltarForn.Click += new System.EventHandler(this.btnVoltarForn_Click);
            // 
            // btnGravarForn
            // 
            this.btnGravarForn.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnGravarForn.Location = new System.Drawing.Point(480, 378);
            this.btnGravarForn.Name = "btnGravarForn";
            this.btnGravarForn.Size = new System.Drawing.Size(77, 30);
            this.btnGravarForn.TabIndex = 50;
            this.btnGravarForn.TabStop = false;
            this.btnGravarForn.UseVisualStyleBackColor = true;
            this.btnGravarForn.Click += new System.EventHandler(this.btnGravarForn_Click);
            // 
            // btnCleanForn
            // 
            this.btnCleanForn.Image = global::EcoPark_Manager.Properties.Resources.limpar_limpo;
            this.btnCleanForn.Location = new System.Drawing.Point(247, 378);
            this.btnCleanForn.Name = "btnCleanForn";
            this.btnCleanForn.Size = new System.Drawing.Size(77, 30);
            this.btnCleanForn.TabIndex = 51;
            this.btnCleanForn.TabStop = false;
            this.btnCleanForn.UseVisualStyleBackColor = true;
            this.btnCleanForn.Click += new System.EventHandler(this.btnCleanForn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Novo Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nome:";
            // 
            // tboxNomeForn
            // 
            this.tboxNomeForn.Location = new System.Drawing.Point(96, 75);
            this.tboxNomeForn.Name = "tboxNomeForn";
            this.tboxNomeForn.Size = new System.Drawing.Size(462, 20);
            this.tboxNomeForn.TabIndex = 47;
            // 
            // cboxCpfForn
            // 
            this.cboxCpfForn.AutoSize = true;
            this.cboxCpfForn.Location = new System.Drawing.Point(417, 108);
            this.cboxCpfForn.Name = "cboxCpfForn";
            this.cboxCpfForn.Size = new System.Drawing.Size(46, 17);
            this.cboxCpfForn.TabIndex = 53;
            this.cboxCpfForn.Text = "CPF";
            this.cboxCpfForn.UseVisualStyleBackColor = true;
            this.cboxCpfForn.CheckedChanged += new System.EventHandler(this.cboxCpfForn_CheckedChanged);
            // 
            // cboxCnpjForn
            // 
            this.cboxCnpjForn.AutoSize = true;
            this.cboxCnpjForn.Location = new System.Drawing.Point(485, 108);
            this.cboxCnpjForn.Name = "cboxCnpjForn";
            this.cboxCnpjForn.Size = new System.Drawing.Size(53, 17);
            this.cboxCnpjForn.TabIndex = 54;
            this.cboxCnpjForn.Text = "CNPJ";
            this.cboxCnpjForn.UseVisualStyleBackColor = true;
            this.cboxCnpjForn.CheckedChanged += new System.EventHandler(this.cboxCnpjForn_CheckedChanged);
            // 
            // MasCpfCnpjForn
            // 
            this.MasCpfCnpjForn.Location = new System.Drawing.Point(400, 129);
            this.MasCpfCnpjForn.Name = "MasCpfCnpjForn";
            this.MasCpfCnpjForn.Size = new System.Drawing.Size(158, 20);
            this.MasCpfCnpjForn.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Endereço:";
            // 
            // tboxEnderecoForn
            // 
            this.tboxEnderecoForn.Location = new System.Drawing.Point(96, 183);
            this.tboxEnderecoForn.Name = "tboxEnderecoForn";
            this.tboxEnderecoForn.Size = new System.Drawing.Size(462, 20);
            this.tboxEnderecoForn.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Numero de Contato:";
            // 
            // tboxCidadeForn
            // 
            this.tboxCidadeForn.Location = new System.Drawing.Point(96, 129);
            this.tboxCidadeForn.Name = "tboxCidadeForn";
            this.tboxCidadeForn.Size = new System.Drawing.Size(253, 20);
            this.tboxCidadeForn.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Observações";
            // 
            // tboxObsForn
            // 
            this.tboxObsForn.Location = new System.Drawing.Point(10, 296);
            this.tboxObsForn.Multiline = true;
            this.tboxObsForn.Name = "tboxObsForn";
            this.tboxObsForn.Size = new System.Drawing.Size(548, 68);
            this.tboxObsForn.TabIndex = 64;
            // 
            // MasNumeroContato
            // 
            this.MasNumeroContato.Location = new System.Drawing.Point(399, 229);
            this.MasNumeroContato.Name = "MasNumeroContato";
            this.MasNumeroContato.Size = new System.Drawing.Size(158, 20);
            this.MasNumeroContato.TabIndex = 65;
            // 
            // NovoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(569, 428);
            this.Controls.Add(this.MasNumeroContato);
            this.Controls.Add(this.tboxObsForn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxCidadeForn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxEnderecoForn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MasCpfCnpjForn);
            this.Controls.Add(this.cboxCnpjForn);
            this.Controls.Add(this.cboxCpfForn);
            this.Controls.Add(this.btnVoltarForn);
            this.Controls.Add(this.btnGravarForn);
            this.Controls.Add(this.btnCleanForn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNomeForn);
            this.Name = "NovoFornecedor";
            this.Text = "NovoFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarForn;
        private System.Windows.Forms.Button btnGravarForn;
        private System.Windows.Forms.Button btnCleanForn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNomeForn;
        private System.Windows.Forms.CheckBox cboxCpfForn;
        private System.Windows.Forms.CheckBox cboxCnpjForn;
        private System.Windows.Forms.MaskedTextBox MasCpfCnpjForn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxEnderecoForn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxCidadeForn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxObsForn;
        private System.Windows.Forms.MaskedTextBox MasNumeroContato;
    }
}