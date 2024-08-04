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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iddtextr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtver = table.Column<int>(type: "int", nullable: false),
                    Iddtext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iddt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddteta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dddtoficia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dddtrectifa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cddtcirvis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qddttaxchg = table.Column<double>(type: "float", nullable: false),
                    Ista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtbur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtburdst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtdep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtentrep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nddtimmioe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lddtnomioe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtagr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lddtagr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtpayori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtpaidst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lddtnomfod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtincote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtdevfob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtdevfle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtdevass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddttransp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtmdetrn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cddtpaytrn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nddtart = table.Column<int>(type: "int", nullable: false),
                    Nddtdelai = table.Column<int>(type: "int", nullable: false),
                    Dddtbae = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dddtsalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dddtcancel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dddtechean = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cddtobs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDTs", x => x.ID);
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
