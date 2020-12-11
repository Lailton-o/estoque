using Estoque.Business.Enums;
using Estoque.Business.Models.Common;

namespace Estoque.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
