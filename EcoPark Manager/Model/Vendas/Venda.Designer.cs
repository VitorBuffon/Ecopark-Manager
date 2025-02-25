namespace EcoPark_Manager.Model.Vendas
{
    partial class Venda
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
            this.cboxProduto = new System.Windows.Forms.ComboBox();
            this.Produto = new System.Windows.Forms.Label();
            this.ListItensPedido = new System.Windows.Forms.ListView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tboxValorFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.tboxValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAplicarDesc = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxProduto
            // 
            this.cboxProduto.FormattingEnabled = true;
            this.cboxProduto.Location = new System.Drawing.Point(154, 61);
            this.cboxProduto.Name = "cboxProduto";
            this.cboxProduto.Size = new System.Drawing.Size(410, 21);
            this.cboxProduto.TabIndex = 0;
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produto.Location = new System.Drawing.Point(79, 63);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(62, 17);
            this.Produto.TabIndex = 1;
            this.Produto.Text = "Produto:";
            // 
            // ListItensPedido
            // 
            this.ListItensPedido.HideSelection = false;
            this.ListItensPedido.Location = new System.Drawing.Point(62, 140);
            this.ListItensPedido.Name = "ListItensPedido";
            this.ListItensPedido.Size = new System.Drawing.Size(502, 170);
            this.ListItensPedido.TabIndex = 4;
            this.ListItensPedido.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = global::EcoPark_Manager.Properties.Resources.publicar;
            this.btnAdicionar.Location = new System.Drawing.Point(308, 104);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(31, 20);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // tboxValorFinal
            // 
            this.tboxValorFinal.Location = new System.Drawing.Point(324, 401);
            this.tboxValorFinal.Name = "tboxValorFinal";
            this.tboxValorFinal.Size = new System.Drawing.Size(137, 20);
            this.tboxValorFinal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Pago:";
            // 
            // tboxDesconto
            // 
            this.tboxDesconto.Location = new System.Drawing.Point(324, 362);
            this.tboxDesconto.Name = "tboxDesconto";
            this.tboxDesconto.Size = new System.Drawing.Size(137, 20);
            this.tboxDesconto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade:";
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Location = new System.Drawing.Point(80, 318);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(121, 30);
            this.btnFinalizarPedido.TabIndex = 12;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click_1);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(80, 357);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(121, 30);
            this.btnFinalizarVenda.TabIndex = 13;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click_1);
            // 
            // tboxValorTotal
            // 
            this.tboxValorTotal.Location = new System.Drawing.Point(324, 323);
            this.tboxValorTotal.Name = "tboxValorTotal";
            this.tboxValorTotal.Size = new System.Drawing.Size(137, 20);
            this.tboxValorTotal.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor Total:";
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(154, 104);
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(148, 20);
            this.numericQuantidade.TabIndex = 17;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::EcoPark_Manager.Properties.Resources.seta_esquerda;
            this.btnVoltar.Location = new System.Drawing.Point(467, 399);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 25);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAplicarDesc
            // 
            this.btnAplicarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarDesc.Image = global::EcoPark_Manager.Properties.Resources.verificado;
            this.btnAplicarDesc.Location = new System.Drawing.Point(467, 360);
            this.btnAplicarDesc.Name = "btnAplicarDesc";
            this.btnAplicarDesc.Size = new System.Drawing.Size(97, 25);
            this.btnAplicarDesc.TabIndex = 18;
            this.btnAplicarDesc.UseVisualStyleBackColor = true;
            this.btnAplicarDesc.Click += new System.EventHandler(this.btnAplicarDesc_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::EcoPark_Manager.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(80, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAplicarDesc);
            this.Controls.Add(this.numericQuantidade);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tboxValorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxValorFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ListItensPedido);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.cboxProduto);
            this.Name = "Venda";
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxProduto;
        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.ListView ListItensPedido;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tboxValorFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.TextBox tboxValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.Button btnAplicarDesc;
        private System.Windows.Forms.Button btnVoltar;
    }
}