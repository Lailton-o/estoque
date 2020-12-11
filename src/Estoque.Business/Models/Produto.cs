using Estoque.Business.Models.Common;
using System;
using System.Collections.Generic;

namespace Estoque.Business.Models
{
    public class Produto : Entity
    {
        public string CodigoDeBarras { get; set; }
        public string Nome { get; set; }
        public Guid FornecedorId { get; set; }
        public decimal PrecoUnidade { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual IEnumerable<Movimentacao> Movimentacoes { get; set; }
    }
}
