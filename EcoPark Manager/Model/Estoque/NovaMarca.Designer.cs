namespace EcoPark_Manager.Model.Estoque
{
    partial class NovaMarca
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
            this.btnVoltarMarca = new System.Windows.Forms.Button();
            this.btnGravarMarca = new System.Windows.Forms.Button();
            this.btnCleanMarca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNomeMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltarMarca
            // 
            this.btnVoltarMarca.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltarMarca.Location = new System.Drawing.Point(78, 150);
            this.btnVoltarMarca.Name = "btnVoltarMarca";
            this.btnVoltarMarca.Size = new System.Drawing.Size(77, 30);
            this.btnVoltarMarca.TabIndex = 52;
            this.btnVoltarMarca.TabStop = false;
            this.btnVoltarMarca.UseVisualStyleBackColor = true;
            this.btnVoltarMarca.Click += new System.EventHandler(this.btnVoltarMarca_Click);
            // 
            // btnGravarMarca
            // 
            this.btnGravarMarca.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnGravarMarca.Location = new System.Drawing.Point(331, 150);
            this.btnGravarMarca.Name = "btnGravarMarca";
            this.btnGravarMarca.Size = new System.Drawing.Size(77, 30);
            this.btnGravarMarca.TabIndex = 50;
            this.btnGravarMarca.TabStop = false;
            this.btnGravarMarca.UseVisualStyleBackColor = true;
            this.btnGravarMarca.Click += new System.EventHandler(this.btnGravarMarca_Click);
            // 
            // btnCleanMarca
            // 
            this.btnCleanMarca.Image = global::EcoPark_Manager.Properties.Resources.limpar_limpo;
            this.btnCleanMarca.Location = new System.Drawing.Point(201, 150);
            this.btnCleanMarca.Name = "btnCleanMarca";
            this.btnCleanMarca.Size = new System.Drawing.Size(77, 30);
            this.btnCleanMarca.TabIndex = 51;
            this.btnCleanMarca.TabStop = false;
            this.btnCleanMarca.UseVisualStyleBackColor = true;
            this.btnCleanMarca.Click += new System.EventHandler(this.btnCleanMarca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nova Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nome:";
            // 
            // tboxNomeMarca
            // 
            this.tboxNomeMarca.Location = new System.Drawing.Point(78, 105);
            this.tboxNomeMarca.Name = "tboxNomeMarca";
            this.tboxNomeMarca.Size = new System.Drawing.Size(330, 20);
            this.tboxNomeMarca.TabIndex = 47;
            this.tboxNomeMarca.TextChanged += new System.EventHandler(this.tboxNomeMarca_TextChanged);
            // 
            // NovaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(430, 213);
            this.Controls.Add(this.btnVoltarMarca);
            this.Controls.Add(this.btnGravarMarca);
            this.Controls.Add(this.btnCleanMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNomeMarca);
            this.Name = "NovaMarca";
            this.Text = "NovaMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarMarca;
        private System.Windows.Forms.Button btnGravarMarca;
        private System.Windows.Forms.Button btnCleanMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNomeMarca;
    }
}