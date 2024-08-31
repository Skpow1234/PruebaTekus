using Microsoft.EntityFrameworkCore;
using PruebaTekus.Domain.Entities;

namespace PruebaTekus.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ProvidersServices> Providers_Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Provider>().HasKey(p => p.idprovider);
            modelBuilder.Entity<Services>().HasKey(s => s.idservice);
            modelBuilder.Entity<Country>().HasKey(p => p.idcountry);
            modelBuilder.Entity<ProvidersServices>()
                .HasKey(ps => new { ps.Providers_idprovider, ps.Services_idservice, ps.Country_idcountry });
            modelBuilder.Entity<ProvidersServices>()
                .HasOne(ps => ps.Provider)
                .WithMany(p => p.ProvidersServices)
                .HasForeignKey(ps => ps.Providers_idprovider)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProvidersServices>()
                .HasOne(ps => ps.Services)
                .WithMany(s => s.ProvidersServices)
                .HasForeignKey(ps => ps.Services_idservice)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProvidersServices>()
                .HasOne(ps => ps.Country)
                .WithMany(p => p.ProvidersServices)
                .HasForeignKey(ps => ps.Country_idcountry)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProvidersServices>()
                .Property(e => e.time_value).IsRequired();
            modelBuilder.Entity<Provider>().HasData(
                new Provider { idprovider = 1, nit = "900987654-1", name = "DataMasters", mail = "info@datamasters.com" },
                new Provider { idprovider = 2, nit = "900876543-2", name = "SysTech Solutions", mail = "support@systechsolutions.com" },
                new Provider { idprovider = 3, nit = "900765432-3", name = "InfiniSoft", mail = "contact@infinisoft.com" },
                new Provider { idprovider = 4, nit = "900654321-4", name = "MegaNet", mail = "service@meganet.com" },
                new Provider { idprovider = 5, nit = "900543210-5", name = "SmartWare", mail = "info@smartware.com" },
                new Provider { idprovider = 6, nit = "900432109-6", name = "TechWorld", mail = "contact@techworld.com" },
                new Provider { idprovider = 7, nit = "900321098-7", name = "ProLogic", mail = "service@prologic.com" },
                new Provider { idprovider = 8, nit = "900210987-8", name = "NetServe", mail = "support@netserve.com" },
                new Provider { idprovider = 9, nit = "900109876-9", name = "CloudNine", mail = "info@cloudnine.com" },
                new Provider { idprovider = 10, nit = "900098765-0", name = "TechEase", mail = "support@techease.com" }
            );
            modelBuilder.Entity<Services>().HasData(
                new Services { idservice = 1, service = "Cloud Hosting" },
                new Services { idservice = 2, service = "Cybersecurity Audit" },
                new Services { idservice = 3, service = "Data Analytics" },
                new Services { idservice = 4, service = "AI Development" },
                new Services { idservice = 5, service = "IoT Solutions" },
                new Services { idservice = 6, service = "Blockchain Integration" },
                new Services { idservice = 7, service = "DevOps Consulting" },
                new Services { idservice = 8, service = "Mobile App Development" },
                new Services { idservice = 9, service = "IT Support Services" },
                new Services { idservice = 10, service = "Enterprise Software" }
            );
            modelBuilder.Entity<Country>().HasData(
                new Country { idcountry = 1, country = "Germany" },
                new Country { idcountry = 2, country = "Australia" },
                new Country { idcountry = 3, country = "India" },
                new Country { idcountry = 4, country = "Japan" },
                new Country { idcountry = 5, country = "South Korea" },
                new Country { idcountry = 6, country = "France" },
                new Country { idcountry = 7, country = "United Kingdom" },
                new Country { idcountry = 8, country = "Spain" },
                new Country { idcountry = 9, country = "Italy" },
                new Country { idcountry = 10, country = "Netherlands" }
            );
            modelBuilder.Entity<ProvidersServices>().HasData(
                new ProvidersServices { Providers_idprovider = 1, Services_idservice = 1, Country_idcountry = 1, time_value = 120000 },
                new ProvidersServices { Providers_idprovider = 1, Services_idservice = 2, Country_idcountry = 2, time_value = 130000 },
                new ProvidersServices { Providers_idprovider = 2, Services_idservice = 3, Country_idcountry = 3, time_value = 140000 },
                new ProvidersServices { Providers_idprovider = 3, Services_idservice = 4, Country_idcountry = 4, time_value = 150000 },
                new ProvidersServices { Providers_idprovider = 4, Services_idservice = 5, Country_idcountry = 5, time_value = 160000 },
                new ProvidersServices { Providers_idprovider = 5, Services_idservice = 6, Country_idcountry = 6, time_value = 170000 },
                new ProvidersServices { Providers_idprovider = 6, Services_idservice = 7, Country_idcountry = 7, time_value = 180000 },
                new ProvidersServices { Providers_idprovider = 7, Services_idservice = 8, Country_idcountry = 8, time_value = 190000 },
                new ProvidersServices { Providers_idprovider = 8, Services_idservice = 9, Country_idcountry = 9, time_value = 200000 },
                new ProvidersServices { Providers_idprovider = 9, Services_idservice = 10, Country_idcountry = 10, time_value = 210000 }
            );
        }
    }
}
