﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Configuration
{
    internal sealed class LectureTheatreConfiguration : IEntityTypeConfiguration<LectureTheatre>
    {
        public void Configure(EntityTypeBuilder<LectureTheatre> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.Property(m => m.Name).HasMaxLength(60);
        }
    }
}
