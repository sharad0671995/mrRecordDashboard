using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExSheet.Migrations
{
    /// <inheritdoc />
    public partial class initialPP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientMasterss",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    logo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMasterss", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Clientpmasterss",
                columns: table => new
                {
                    ClientPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plant_no = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientpmasterss", x => x.ClientPId);
                });

            migrationBuilder.CreateTable(
                name: "lineMasterss",
                columns: table => new
                {
                    LineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lineMasterss", x => x.LineId);
                });

            migrationBuilder.CreateTable(
                name: "Studentss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentss", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientMasterss");

            migrationBuilder.DropTable(
                name: "Clientpmasterss");

            migrationBuilder.DropTable(
                name: "lineMasterss");

            migrationBuilder.DropTable(
                name: "Studentss");
        }
    }
}
