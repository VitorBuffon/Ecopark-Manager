using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Arquivo: Model/Vendas/ItemPedido.cs
namespace EcoPark_Manager.Model.Vendas
{
    public class ItemPedido
    {
        public int ProdutoCodigo { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}


