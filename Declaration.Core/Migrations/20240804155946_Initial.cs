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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DDTs");
        }
    }
}
