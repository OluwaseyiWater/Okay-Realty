using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OkayRealty.Core;

namespace OkayRealty.Data
{
    public class OkayRealtyDbContext : DbContext
    {
        public OkayRealtyDbContext(DbContextOptions<OkayRealtyDbContext> options)
            : base(options)
        {

        }

        public DbSet<Apartment> Apartments { get; set; }
    }
}

