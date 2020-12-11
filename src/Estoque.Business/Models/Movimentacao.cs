using Estoque.Business.Enums;
using Estoque.Business.Models.Common;
using System;

namespace Estoque.Business.Models
{
    public class Movimentacao : Entity
    {
        public Movimentacao()
        {
            DataMovimentacao = DateTime.Now;
        }
        public Guid ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public TipoMovimentacao TipoMovimentacao { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public decimal PrecoUnidade { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
