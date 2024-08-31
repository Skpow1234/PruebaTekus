﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaTekus.Infrastructure.Data;

#nullable disable

namespace PruebaTekus.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaTekus.Domain.Entities.Country", b =>
                {
                    b.Property<int>("idcountry")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idcountry"));

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idcountry");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            idcountry = 1,
                            country = "Colombia"
                        },
                        new
                        {
                            idcountry = 2,
                            country = "United States"
                        },
                        new
                        {
                            idcountry = 3,
                            country = "Canada"
                        },
                        new
                        {
                            idcountry = 4,
                            country = "Mexico"
                        },
                        new
                        {
                            idcountry = 5,
                            country = "Brazil"
                        },
                        new
                        {
                            idcountry = 6,
                            country = "Argentina"
                        },
                        new
                        {
                            idcountry = 7,
                            country = "Chile"
                        },
                        new
                        {
                            idcountry = 8,
                            country = "Peru"
                        },
                        new
                        {
                            idcountry = 9,
                            country = "Venezuela"
                        },
                        new
                        {
                            idcountry = 10,
                            country = "Uruguay"
                        });
                });

            modelBuilder.Entity("PruebaTekus.Domain.Entities.Provider", b =>
                {
                    b.Property<int>("idprovider")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idprovider"));

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idprovider");

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            idprovider = 1,
                            mail = "tecnisoft@gmail.com",
                            name = "Tecnisoft",
                            nit = "900123456-1"
                        },
                        new
                        {
                            idprovider = 2,
                            mail = "servitech@yahoo.com",
                            name = "ServiTech",
                            nit = "900234567-2"
                        },
                        new
                        {
                            idprovider = 3,
                            mail = "solucionesit@hotmail.com",
                            name = "Soluciones IT",
                            nit = "900345678-3"
                        },
                        new
                        {
                            idprovider = 4,
                            mail = "digitalware@gmail.com",
                            name = "DigitalWare",
                            nit = "900456789-4"
                        },
                        new
                        {
                            idprovider = 5,
                            mail = "techpro@yahoo.com",
                            name = "TechPro",
                            nit = "900567890-5"
                        },
                        new
                        {
                            idprovider = 6,
                            mail = "infotech@hotmail.com",
                            name = "InfoTech",
                            nit = "900678901-6"
                        },
                        new
                        {
                            idprovider = 7,
                            mail = "cybersoft@gmail.com",
                            name = "CyberSoft",
                            nit = "900789012-7"
                        },
                        new
                        {
                            idprovider = 8,
                            mail = "compunet@yahoo.com",
                            name = "CompuNet",
                            nit = "900890123-8"
                        },
                        new
                        {
                            idprovider = 9,
                            mail = "netsolutions@hotmail.com",
                            name = "NetSolutions",
                            nit = "900901234-9"
                        },
                        new
                        {
                            idprovider = 10,
                            mail = "softtech@gmail.com",
                            name = "SoftTech",
                            nit = "900012345-0"
                        });
                });

            modelBuilder.Entity("PruebaTekus.Domain.Entities.ProvidersServices", b =>
                {
                    b.Property<int>("Providers_idprovider")
                        .HasColumnType("int");

                    b.Property<int>("Services_idservice")
                        .HasColumnType("int");

                    b.Property<int>("Country_idcountry")
                        .HasColumnType("int");

                    b.Property<float>("time_value")
                        .HasColumnType("real");

                    b.HasKey("Providers_idprovider", "Services_idservice", "Country_idcountry");

                    b.HasIndex("Country_idcountry");

                    b.HasIndex("Services_idservice");

                    b.ToTable("Providers_Services");

                    b.HasData(
                        new
                        {
                            Providers_idprovider = 1,
                            Services_idservice = 1,
                            Country_idcountry = 1,
                            time_value = 100000f
                        },
                        new
                        {
                            Providers_idprovider = 1,
                            Services_idservice = 2,
                            Country_idcountry = 2,
                            time_value = 150000f
                        },
                        new
                        {
                            Providers_idprovider = 2,
                            Services_idservice = 3,
                            Country_idcountry = 3,
                            time_value = 200000f
                        },
                        new
                        {
                            Providers_idprovider = 3,
                            Services_idservice = 4,
                            Country_idcountry = 4,
                            time_value = 250000f
                        },
                        new
                        {
                            Providers_idprovider = 4,
                            Services_idservice = 5,
                            Country_idcountry = 5,
                            time_value = 300000f
                        },
                        new
                        {
                            Providers_idprovider = 5,
                            Services_idservice = 6,
                            Country_idcountry = 6,
                            time_value = 350000f
                        },
                        new
                        {
                            Providers_idprovider = 6,
                            Services_idservice = 7,
                            Country_idcountry = 7,
                            time_value = 400000f
                        },
                        new
                        {
                            Providers_idprovider = 7,
                            Services_idservice = 8,
                            Country_idcountry = 8,
                            time_value = 450000f
                        },
                        new
                        {
                            Providers_idprovider = 8,
                            Services_idservice = 9,
                            Country_idcountry = 9,
                            time_value = 500000f
                        },
                        new
                        {
                            Providers_idprovider = 9,
                            Services_idservice = 10,
                            Country_idcountry = 10,
                            time_value = 550000f
                        });
                });

            modelBuilder.Entity("PruebaTekus.Domain.Entities.Services", b =>
                {
                    b.Property<int>("idservice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idservice"));

                    b.Property<string>("service")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idservice");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            idservice = 1,
                            service = "Mantenimiento de PC"
                        },
                        new
                        {
                            idservice = 2,
                            service = "Instalación de Software"
                        },
                        new
                        {
                            idservice = 3,
                            service = "Soporte Técnico Remoto"
                        },
                        new
                        {
                            idservice = 4,
                            service = "Consultoría IT"
                        },
                        new
                        {
                            idservice = 5,
                            service = "Desarrollo de Software"
                        },
                        new
                        {
                            idservice = 6,
                            service = "Seguridad Informática"
                        },
                        new
                        {
                            idservice = 7,
                            service = "Hosting y Dominios"
                        },
                        new
                        {
                            idservice = 8,
                            service = "Diseño Web"
                        },
                        new
                        {
                            idservice = 9,
                            service = "Redes y Telecomunicaciones"
                        },
                        new
                        {
                            idservice = 10,
                            service = "Backup y Recuperación"
                        });
                });

            modelBuilder.Entity("PruebaTekus.Domain.Entities.ProvidersServices", b =>
                {
                    b.HasOne("PruebaTekus.Domain.Entities.Country", "Country")
                        .WithMany("ProvidersServices")
                        .HasForeignKey("Country_idcountry")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaTekus.Domain.Entities.Provider", "Provider")
                        .WithMany("ProvidersServices")
                        .HasForeignKey("Providers_idprovider")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaTekus.Domain.Entities.Services", "Services")
                        .WithMany("ProvidersServices")
                        .HasForeignKey("Services_idservice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Provider");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("PruebaTekus.Domain.Entities.Country", b =>
                {
                    b.Navigation("ProvidersServices");
                });

            modelBuilder.Entity("PruebaTekus.Domain.Entities.Provider", b =>
                {
                    b.Navigation("ProvidersServices");
                });

            modelBuilder.Entity("PruebaTekus.Domain.Entities.Services", b =>
                {
                    b.Navigation("ProvidersServices");
                });
#pragma warning restore 612, 618
        }
    }
}
