﻿using COMTUR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COMTUR.Data.Map
{
    public class TipoAtracaoMap : IEntityTypeConfiguration<TipoAtracaoModel>
    {
        public void Configure(EntityTypeBuilder<TipoAtracaoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);

            // Relacionamento TipoAtracao com Atracao
            builder.HasMany(x => x.Atracao).WithOne(x => x.TipoAtracaoModel).IsRequired().OnDelete(DeleteBehavior.Cascade);
        }
    }
}