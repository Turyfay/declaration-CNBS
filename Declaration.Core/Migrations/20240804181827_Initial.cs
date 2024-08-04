using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Declaration.Core.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DDTs",
                columns: table => new
                {
                    Iddt = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Iddtextr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtver = table.Column<int>(type: "int", nullable: false),
                    Iddtext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddteta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dddtoficia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dddtrectifa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cddtcirvis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qddttaxchg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtbur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtburdst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtdep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtentrep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtagr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lddtagr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nddtimmioe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lddtnomioe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtpayori = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtpaidst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lddtnomfod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtincote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtdevfob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtdevfle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtdevass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddttransp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtmdetrn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cddtpaytrn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nddtart = table.Column<int>(type: "int", nullable: false),
                    Nddtdelai = table.Column<int>(type: "int", nullable: true),
                    Dddtbae = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dddtsalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dddtcancel = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dddtechean = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cddtobs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDTs", x => x.Iddt);
                });

            migrationBuilder.CreateTable(
                name: "LAQs",
                columns: table => new
                {
                    Iliq = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nart = table.Column<int>(type: "int", nullable: false),
                    Clqatax = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Clqatyp = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mlqabas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Qlqacoefic = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mlqa = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LAQs", x => new { x.Iliq, x.Nart, x.Clqatax, x.Clqatyp });
                });

            migrationBuilder.CreateTable(
                name: "ARTs",
                columns: table => new
                {
                    Iddt = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nart = table.Column<int>(type: "int", nullable: false),
                    Carttyp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codbenef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cartetamrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iespnce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cartdesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cartpayori = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cartpayacq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cartpayprc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iddtapu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nartapu = table.Column<int>(type: "int", nullable: true),
                    Qartbul = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martunitar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cartuntdcl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qartuntdcl = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cartuntest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qartuntest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Qartkgrbrt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Qartkgrnet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martfob = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Martfobdol = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martfle = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martass = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martemma = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martfrai = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martajuinc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martajuded = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martbasimp = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTs", x => new { x.Iddt, x.Nart });
                    table.ForeignKey(
                        name: "FK_ARTs_DDTs_Iddt",
                        column: x => x.Iddt,
                        principalTable: "DDTs",
                        principalColumn: "Iddt",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LIQs",
                columns: table => new
                {
                    Iliq = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cliqdop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliqeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mliq = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mliqgar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dlippay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Clipnomope = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIQs", x => x.Iliq);
                    table.ForeignKey(
                        name: "FK_LIQs_DDTs_Iliq",
                        column: x => x.Iliq,
                        principalTable: "DDTs",
                        principalColumn: "Iddt",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARTs");

            migrationBuilder.DropTable(
                name: "LAQs");

            migrationBuilder.DropTable(
                name: "LIQs");

            migrationBuilder.DropTable(
                name: "DDTs");
        }
    }
}
