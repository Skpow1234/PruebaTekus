using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaTekus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    idcountry = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.idcountry);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    idprovider = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.idprovider);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    idservice = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.idservice);
                });

            migrationBuilder.CreateTable(
                name: "Providers_Services",
                columns: table => new
                {
                    Providers_idprovider = table.Column<int>(type: "int", nullable: false),
                    Services_idservice = table.Column<int>(type: "int", nullable: false),
                    Country_idcountry = table.Column<int>(type: "int", nullable: false),
                    time_value = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers_Services", x => new { x.Providers_idprovider, x.Services_idservice, x.Country_idcountry });
                    table.ForeignKey(
                        name: "FK_Providers_Services_Countries_Country_idcountry",
                        column: x => x.Country_idcountry,
                        principalTable: "Countries",
                        principalColumn: "idcountry",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Providers_Services_Providers_Providers_idprovider",
                        column: x => x.Providers_idprovider,
                        principalTable: "Providers",
                        principalColumn: "idprovider",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Providers_Services_Services_Services_idservice",
                        column: x => x.Services_idservice,
                        principalTable: "Services",
                        principalColumn: "idservice",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "idcountry", "country" },
                values: new object[,]
                {
                    { 1, "Germany" },
                    { 2, "Australia" },
                    { 3, "India" },
                    { 4, "Japan" },
                    { 5, "South Korea" },
                    { 6, "France" },
                    { 7, "United Kingdom" },
                    { 8, "Spain" },
                    { 9, "Italy" },
                    { 10, "Netherlands" }
                });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "idprovider", "mail", "name", "nit" },
                values: new object[,]
                {
                    { 1, "info@datamasters.com", "DataMasters", "900987654-1" },
                    { 2, "support@systechsolutions.com", "SysTech Solutions", "900876543-2" },
                    { 3, "contact@infinisoft.com", "InfiniSoft", "900765432-3" },
                    { 4, "service@meganet.com", "MegaNet", "900654321-4" },
                    { 5, "info@smartware.com", "SmartWare", "900543210-5" },
                    { 6, "contact@techworld.com", "TechWorld", "900432109-6" },
                    { 7, "service@prologic.com", "ProLogic", "900321098-7" },
                    { 8, "support@netserve.com", "NetServe", "900210987-8" },
                    { 9, "info@cloudnine.com", "CloudNine", "900109876-9" },
                    { 10, "support@techease.com", "TechEase", "900098765-0" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "idservice", "service" },
                values: new object[,]
                {
                    { 1, "Cloud Hosting" },
                    { 2, "Cybersecurity Audit" },
                    { 3, "Data Analytics" },
                    { 4, "AI Development" },
                    { 5, "IoT Solutions" },
                    { 6, "Blockchain Integration" },
                    { 7, "DevOps Consulting" },
                    { 8, "Mobile App Development" },
                    { 9, "IT Support Services" },
                    { 10, "Enterprise Software" }
                });

            migrationBuilder.InsertData(
                table: "Providers_Services",
                columns: new[] { "Country_idcountry", "Providers_idprovider", "Services_idservice", "time_value" },
                values: new object[,]
                {
                    { 1, 1, 1, 120000f },
                    { 2, 1, 2, 130000f },
                    { 3, 2, 3, 140000f },
                    { 4, 3, 4, 150000f },
                    { 5, 4, 5, 160000f },
                    { 6, 5, 6, 170000f },
                    { 7, 6, 7, 180000f },
                    { 8, 7, 8, 190000f },
                    { 9, 8, 9, 200000f },
                    { 10, 9, 10, 210000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Services_Country_idcountry",
                table: "Providers_Services",
                column: "Country_idcountry");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Services_Services_idservice",
                table: "Providers_Services",
                column: "Services_idservice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Providers_Services");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
