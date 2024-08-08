using IGI.Icegate_Integration.Core.Context;
using IGI.Icegate_Integration.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGI.Icegate_Integration.Infrastructure.Context
{
    public class IGIdbContext : DbContext , IIGIdbContext
    {
        public IGIdbContext(DbContextOptions<IGIdbContext> options):base(options) 
        {

        }
        public DbSet<IntegrationRequest> IntegrationRequest { get; set; }
        public DbSet<IntegrationResponse> IntegrationResponse { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IntegrationRequest>().ToTable("IntegrationRequest", "IGI");
            modelBuilder.Entity<IntegrationResponse>().ToTable("IntegrationResponse", "IGI");
        }

    }
}
