﻿using AgendaSis.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaSis.Infra.Mapeamento
{
    public class PessoaFisicaMapping : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder
                .Property(p => p.DataNascimento)
                .HasColumnName("DataNascimento")
                .IsRequired();
            builder
                .Property(p => p.Cpf)
                .HasColumnName("CPF")
                .HasMaxLength(11)
                .IsRequired();
            builder
                .Property(p => p.GeneroId)
                .HasColumnName("GeneroId")
                .IsRequired();
            builder
                .HasOne(h => h.Genero)
                .WithMany()
                .HasForeignKey(h => h.GeneroId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasBaseType<Pessoa>();
        }
    }
}
