using KatmanliMimariProject.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimariProject.Data.Seeds
{
    class PersonSeed : IEntityTypeConfiguration<Person>
    {
        private readonly int[] _ids;
        public PersonSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person { Id = _ids[0], Name = "Furkan", Surname = "ŞALE" },
                new Person { Id = _ids[1], Name = "Doğukan", Surname = "ŞALE" }
                );
        }
    }
}
