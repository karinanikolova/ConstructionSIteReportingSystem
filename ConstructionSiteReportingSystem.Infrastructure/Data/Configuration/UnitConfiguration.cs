﻿using ConstructionSiteReportingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConstructionSiteReportingSystem.Infrastructure.Data.Configuration
{
    internal class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            // Applying query filer to the entity in order for Entity Framework Core to ignore soft-deleted records when executing queries. The query filer will only show entities with the IsDeleted property set to 'false'.
            builder.HasQueryFilter(c => c.IsDeleted == false);

            // Seeding data for Units
            var data = new DataSeed();

            builder.HasData(new List<Unit>(data.Units));
        }
    }
}
