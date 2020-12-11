using Estoque.Business.Models.Common;
using System;

namespace Estoque.Business.Models
{
    public class Produto : Entity
    {
        public string CodigoDeBarras { get; set; }
        public string Nome { get; set; }
        public Guid FornecedorId { get; set; }
        public decimal PrecoUnidade { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
