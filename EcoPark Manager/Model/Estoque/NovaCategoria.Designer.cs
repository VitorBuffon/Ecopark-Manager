namespace EcoPark_Manager.Model.Estoque
{
    partial class NovaCategoria
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
            this.tboxNomeCate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltarCate = new System.Windows.Forms.Button();
            this.btnGravarCate = new System.Windows.Forms.Button();
            this.btnCleanCate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNomeCate
            // 
            this.tboxNomeCate.Location = new System.Drawing.Point(73, 103);
            this.tboxNomeCate.Name = "tboxNomeCate";
            this.tboxNomeCate.Size = new System.Drawing.Size(351, 20);
            this.tboxNomeCate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova Categoria";
            // 
            // btnVoltarCate
            // 
            this.btnVoltarCate.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltarCate.Location = new System.Drawing.Point(73, 148);
            this.btnVoltarCate.Name = "btnVoltarCate";
            this.btnVoltarCate.Size = new System.Drawing.Size(77, 30);
            this.btnVoltarCate.TabIndex = 46;
            this.btnVoltarCate.TabStop = false;
            this.btnVoltarCate.UseVisualStyleBackColor = true;
            this.btnVoltarCate.Click += new System.EventHandler(this.btnVoltarCate_Click);
            // 
            // btnGravarCate
            // 
            this.btnGravarCate.Image = global::EcoPark_Manager.Properties.Resources.salvar_arquivo;
            this.btnGravarCate.Location = new System.Drawing.Point(326, 148);
            this.btnGravarCate.Name = "btnGravarCate";
            this.btnGravarCate.Size = new System.Drawing.Size(77, 30);
            this.btnGravarCate.TabIndex = 44;
            this.btnGravarCate.TabStop = false;
            this.btnGravarCate.UseVisualStyleBackColor = true;
            this.btnGravarCate.Click += new System.EventHandler(this.btnGravarCate_Click);
            // 
            // btnCleanCate
            // 
            this.btnCleanCate.Image = global::EcoPark_Manager.Properties.Resources.limpar_limpo;
            this.btnCleanCate.Location = new System.Drawing.Point(201, 148);
            this.btnCleanCate.Name = "btnCleanCate";
            this.btnCleanCate.Size = new System.Drawing.Size(77, 30);
            this.btnCleanCate.TabIndex = 45;
            this.btnCleanCate.TabStop = false;
            this.btnCleanCate.UseVisualStyleBackColor = true;
            this.btnCleanCate.Click += new System.EventHandler(this.btnCleanCate_Click);
            // 
            // NovaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(441, 219);
            this.Controls.Add(this.btnVoltarCate);
            this.Controls.Add(this.btnGravarCate);
            this.Controls.Add(this.btnCleanCate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNomeCate);
            this.Name = "NovaCategoria";
            this.Text = "NovaCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNomeCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltarCate;
        private System.Windows.Forms.Button btnGravarCate;
        private System.Windows.Forms.Button btnCleanCate;
    }
}