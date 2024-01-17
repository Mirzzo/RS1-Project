using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StayHard.Migrations
{
    /// <inheritdoc />
    public partial class StayHardDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivGrada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drzava = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikPlan",
                columns: table => new
                {
                    PlanID = table.Column<int>(type: "int", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    TrajanjePretplate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikPlan", x => new { x.PlanID, x.KorisnikID });
                });

            migrationBuilder.CreateTable(
                name: "KreditnaKartica",
                columns: table => new
                {
                    KarticaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojKartice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumIsteka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SigurnosniBroj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KreditnaKartica", x => x.KarticaID);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    PlanID = table.Column<int>(type: "int", nullable: false),
                    RecenzijaID = table.Column<int>(type: "int", nullable: false),
                    Vrijednost = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vrijeme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => new { x.KorisnikID, x.PlanID });
                });

            migrationBuilder.CreateTable(
                name: "TipTreninga",
                columns: table => new
                {
                    TipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipTreninga", x => x.TipID);
                });

            migrationBuilder.CreateTable(
                name: "Trener",
                columns: table => new
                {
                    TrenerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certifikat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Struka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trener", x => x.TrenerID);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    OsobaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradId = table.Column<int>(type: "int", nullable: false),
                    KarticaID = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.OsobaID);
                    table.ForeignKey(
                        name: "FK_Osoba_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Osoba_KreditnaKartica_KarticaID",
                        column: x => x.KarticaID,
                        principalTable: "KreditnaKartica",
                        principalColumn: "KarticaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanTreninga",
                columns: table => new
                {
                    PlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrenerID = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TipID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanTreninga", x => x.PlanID);
                    table.ForeignKey(
                        name: "FK_PlanTreninga_Trener_TrenerID",
                        column: x => x.TrenerID,
                        principalTable: "Trener",
                        principalColumn: "TrenerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OsobaID = table.Column<int>(type: "int", nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BMI = table.Column<int>(type: "int", nullable: false),
                    isVIP = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Osoba_OsobaID",
                        column: x => x.OsobaID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KupovinaPlana",
                columns: table => new
                {
                    KupovinaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanID = table.Column<int>(type: "int", nullable: false),
                    PlanTreningaPlanID = table.Column<int>(type: "int", nullable: false),
                    KarticaID = table.Column<int>(type: "int", nullable: false),
                    KreditnaKarticaKarticaID = table.Column<int>(type: "int", nullable: false),
                    VrijemeKupovine = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupovinaPlana", x => x.KupovinaID);
                    table.ForeignKey(
                        name: "FK_KupovinaPlana_KreditnaKartica_KreditnaKarticaKarticaID",
                        column: x => x.KreditnaKarticaKarticaID,
                        principalTable: "KreditnaKartica",
                        principalColumn: "KarticaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupovinaPlana_PlanTreninga_PlanTreningaPlanID",
                        column: x => x.PlanTreningaPlanID,
                        principalTable: "PlanTreninga",
                        principalColumn: "PlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SadrzajPlana",
                columns: table => new
                {
                    SadrzajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanID = table.Column<int>(type: "int", nullable: false),
                    PlanTreningaPlanID = table.Column<int>(type: "int", nullable: false),
                    Dan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SadrzajPlana", x => x.SadrzajID);
                    table.ForeignKey(
                        name: "FK_SadrzajPlana_PlanTreninga_PlanTreningaPlanID",
                        column: x => x.PlanTreningaPlanID,
                        principalTable: "PlanTreninga",
                        principalColumn: "PlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_OsobaID",
                table: "Korisnik",
                column: "OsobaID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaPlana_KreditnaKarticaKarticaID",
                table: "KupovinaPlana",
                column: "KreditnaKarticaKarticaID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaPlana_PlanTreningaPlanID",
                table: "KupovinaPlana",
                column: "PlanTreningaPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_GradId",
                table: "Osoba",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_KarticaID",
                table: "Osoba",
                column: "KarticaID");

            migrationBuilder.CreateIndex(
                name: "IX_PlanTreninga_TrenerID",
                table: "PlanTreninga",
                column: "TrenerID");

            migrationBuilder.CreateIndex(
                name: "IX_SadrzajPlana_PlanTreningaPlanID",
                table: "SadrzajPlana",
                column: "PlanTreningaPlanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "KorisnikPlan");

            migrationBuilder.DropTable(
                name: "KupovinaPlana");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "SadrzajPlana");

            migrationBuilder.DropTable(
                name: "TipTreninga");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "PlanTreninga");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "KreditnaKartica");

            migrationBuilder.DropTable(
                name: "Trener");
        }
    }
}
