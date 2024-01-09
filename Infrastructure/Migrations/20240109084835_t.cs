using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class t : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabinets",
                columns: table => new
                {
                    Adresse = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabinets", x => x.Adresse);
                });

            migrationBuilder.CreateTable(
                name: "Entreprisees",
                columns: table => new
                {
                    NomEntreprise = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdresseEntreprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NbrEquipement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprisees", x => x.NomEntreprise);
                });

            migrationBuilder.CreateTable(
                name: "Equipements",
                columns: table => new
                {
                    Reference = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFabrication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeEquipement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipements", x => x.Reference);
                });

            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    ReferenceAudit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrequenceAudit = table.Column<int>(type: "int", nullable: false),
                    StatutAudit = table.Column<bool>(type: "bit", nullable: false),
                    CabinetAuditFK = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.ReferenceAudit);
                    table.ForeignKey(
                        name: "FK_Audits_Cabinets_CabinetAuditFK",
                        column: x => x.CabinetAuditFK,
                        principalTable: "Cabinets",
                        principalColumn: "Adresse");
                });

            migrationBuilder.CreateTable(
                name: "EntrepriseEquipement",
                columns: table => new
                {
                    EntrepriseNomEntreprise = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EquipementsReference = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrepriseEquipement", x => new { x.EntrepriseNomEntreprise, x.EquipementsReference });
                    table.ForeignKey(
                        name: "FK_EntrepriseEquipement_Entreprisees_EntrepriseNomEntreprise",
                        column: x => x.EntrepriseNomEntreprise,
                        principalTable: "Entreprisees",
                        principalColumn: "NomEntreprise",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntrepriseEquipement_Equipements_EquipementsReference",
                        column: x => x.EquipementsReference,
                        principalTable: "Equipements",
                        principalColumn: "Reference",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    DateAudit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditFK = table.Column<int>(type: "int", nullable: false),
                    EquipementFK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DureAuditJour = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<int>(type: "int", nullable: false),
                    AuditReferenceAudit = table.Column<int>(type: "int", nullable: false),
                    EquipementReference = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => new { x.EquipementFK, x.AuditFK, x.DateAudit });
                    table.ForeignKey(
                        name: "FK_Details_Audits_AuditReferenceAudit",
                        column: x => x.AuditReferenceAudit,
                        principalTable: "Audits",
                        principalColumn: "ReferenceAudit",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details_Equipements_EquipementReference",
                        column: x => x.EquipementReference,
                        principalTable: "Equipements",
                        principalColumn: "Reference",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audits_CabinetAuditFK",
                table: "Audits",
                column: "CabinetAuditFK");

            migrationBuilder.CreateIndex(
                name: "IX_Details_AuditReferenceAudit",
                table: "Details",
                column: "AuditReferenceAudit");

            migrationBuilder.CreateIndex(
                name: "IX_Details_EquipementReference",
                table: "Details",
                column: "EquipementReference");

            migrationBuilder.CreateIndex(
                name: "IX_EntrepriseEquipement_EquipementsReference",
                table: "EntrepriseEquipement",
                column: "EquipementsReference");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "EntrepriseEquipement");

            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "Entreprisees");

            migrationBuilder.DropTable(
                name: "Equipements");

            migrationBuilder.DropTable(
                name: "Cabinets");
        }
    }
}
