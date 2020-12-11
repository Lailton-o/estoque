using Estoque.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.Data.Mappings
{
    public class MovimentacaoMapping : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Produto)
                .WithMany(c => c.Movimentacoes)
                .HasForeignKey(p => p.ProdutoId);

            builder.ToTable("Movimentacoes");
        }
    }
}
