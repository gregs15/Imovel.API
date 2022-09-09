using Imovel.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Infrastructure.Persistence.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
           .HasOne(p => p.Corretor)
            .WithMany(e => e.Imoveis)
             .HasForeignKey(p => p.IdCorretor)
             .OnDelete(DeleteBehavior.Restrict);


            builder
                .HasOne(p => p.Cliente)
                .WithMany(d => d.OwnedImoveis)
                .HasForeignKey(p => p.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);




        }
    }
}
