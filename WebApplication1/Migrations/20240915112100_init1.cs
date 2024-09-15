using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medkit",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ip_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bandage = table.Column<int>(type: "int", nullable: false),
                    elastric = table.Column<int>(type: "int", nullable: false),
                    splint = table.Column<int>(type: "int", nullable: false),
                    plaster_mark = table.Column<int>(type: "int", nullable: false),
                    plaster = table.Column<int>(type: "int", nullable: false),
                    plaster_mark_2 = table.Column<int>(type: "int", nullable: false),
                    spirit = table.Column<int>(type: "int", nullable: false),
                    foil_nrc = table.Column<int>(type: "int", nullable: false),
                    mask = table.Column<int>(type: "int", nullable: false),
                    bloodsucker = table.Column<int>(type: "int", nullable: false),
                    latex = table.Column<int>(type: "int", nullable: false),
                    dust_wound = table.Column<int>(type: "int", nullable: false),
                    medpack = table.Column<int>(type: "int", nullable: false),
                    uwaga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cord_x = table.Column<double>(type: "float", nullable: false),
                    cord_y = table.Column<double>(type: "float", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medkit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    privelage = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medkit");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
