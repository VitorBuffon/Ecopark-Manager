namespace EcoPark_Manager.Model.Alojamentos
{
    partial class CadastroAlojamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTipoAloj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroAloj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxStatusAloj = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObsAloj = new System.Windows.Forms.TextBox();
            this.btnGravarAloj = new System.Windows.Forms.Button();
            this.btnLimparAloj = new System.Windows.Forms.Button();
            this.btnVoltarCadastroAloj = new System.Windows.Forms.Button();
            this.dgvAlojamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Alojamento";
            // 
            // cboxTipoAloj
            // 
            this.cboxTipoAloj.FormattingEnabled = true;
            this.cboxTipoAloj.Location = new System.Drawing.Point(331, 87);
            this.cboxTipoAloj.Name = "cboxTipoAloj";
            this.cboxTipoAloj.Size = new System.Drawing.Size(179, 21);
            this.cboxTipoAloj.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "O que deseja cadastrar?";
            // 
            // txtNumeroAloj
            // 
            this.txtNumeroAloj.Location = new System.Drawing.Point(331, 137);
            this.txtNumeroAloj.Name = "txtNumeroAloj";
            this.txtNumeroAloj.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroAloj.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero do alojamento";
            // 
            // cboxStatusAloj
            // 
            this.cboxStatusAloj.FormattingEnabled = true;
            this.cboxStatusAloj.Location = new System.Drawing.Point(331, 184);
            this.cboxStatusAloj.Name = "cboxStatusAloj";
            this.cboxStatusAloj.Size = new System.Drawing.Size(179, 21);
            this.cboxStatusAloj.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status do alojamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Observações";
            // 
            // txtObsAloj
            // 
            this.txtObsAloj.Location = new System.Drawing.Point(163, 246);
            this.txtObsAloj.Multiline = true;
            this.txtObsAloj.Name = "txtObsAloj";
            this.txtObsAloj.Size = new System.Drawing.Size(441, 77);
            this.txtObsAloj.TabIndex = 8;
            // 
            // btnGravarAloj
            // 
            this.btnGravarAloj.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnGravarAloj.Location = new System.Drawing.Point(529, 338);
            this.btnGravarAloj.Name = "btnGravarAloj";
            this.btnGravarAloj.Size = new System.Drawing.Size(75, 31);
            this.btnGravarAloj.TabIndex = 9;
            this.btnGravarAloj.UseVisualStyleBackColor = true;
            this.btnGravarAloj.Click += new System.EventHandler(this.btnGravarAloj_Click);
            // 
            // btnLimparAloj
            // 
            this.btnLimparAloj.Image = global::EcoPark_Manager.Properties.Resources.limpar_limpo;
            this.btnLimparAloj.Location = new System.Drawing.Point(346, 338);
            this.btnLimparAloj.Name = "btnLimparAloj";
            this.btnLimparAloj.Size = new System.Drawing.Size(75, 31);
            this.btnLimparAloj.TabIndex = 10;
            this.btnLimparAloj.UseVisualStyleBackColor = true;
            this.btnLimparAloj.Click += new System.EventHandler(this.btnLimparAloj_Click);
            // 
            // btnVoltarCadastroAloj
            // 
            this.btnVoltarCadastroAloj.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltarCadastroAloj.Location = new System.Drawing.Point(163, 338);
            this.btnVoltarCadastroAloj.Name = "btnVoltarCadastroAloj";
            this.btnVoltarCadastroAloj.Size = new System.Drawing.Size(75, 31);
            this.btnVoltarCadastroAloj.TabIndex = 11;
            this.btnVoltarCadastroAloj.Text = "\r\n";
            this.btnVoltarCadastroAloj.UseVisualStyleBackColor = true;
            this.btnVoltarCadastroAloj.Click += new System.EventHandler(this.btnVoltarCadastroAloj_Click);
            // 
            // dgvAlojamentos
            // 
            this.dgvAlojamentos.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvAlojamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamentos.Location = new System.Drawing.Point(108, 371);
            this.dgvAlojamentos.Name = "dgvAlojamentos";
            this.dgvAlojamentos.Size = new System.Drawing.Size(577, 193);
            this.dgvAlojamentos.TabIndex = 12;
            this.dgvAlojamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlojamentos_CellContentClick);
            // 
            // CadastroAlojamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.dgvAlojamentos);
            this.Controls.Add(this.btnVoltarCadastroAloj);
            this.Controls.Add(this.btnLimparAloj);
            this.Controls.Add(this.btnGravarAloj);
            this.Controls.Add(this.txtObsAloj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxStatusAloj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroAloj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxTipoAloj);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAlojamento";
            this.Text = "CadastrarAlojamento";
            this.Load += new System.EventHandler(this.CadastroAlojamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxTipoAloj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroAloj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxStatusAloj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObsAloj;
        private System.Windows.Forms.Button btnGravarAloj;
        private System.Windows.Forms.Button btnLimparAloj;
        private System.Windows.Forms.Button btnVoltarCadastroAloj;
        private System.Windows.Forms.DataGridView dgvAlojamentos;
    }
}