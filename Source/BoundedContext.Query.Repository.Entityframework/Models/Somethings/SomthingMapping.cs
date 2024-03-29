﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoundedContext.Query.Entityframework.Models.Somethings
{
    public class SomthingMapping : IEntityTypeConfiguration<Something>
    {
        public void Configure(EntityTypeBuilder<Something> builder)
        {
            builder.ToTable("Somethings");

            builder.HasKey(sm => sm.Id);
            builder.Property(sm => sm.Name);
        }
    }
}