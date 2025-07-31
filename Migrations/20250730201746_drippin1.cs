using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drippin.Migrations
{
    /// <inheritdoc />
    public partial class drippin1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    proId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proPrecio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    proImagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    proImagen2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    proImagen3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    proImagen4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    prodCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.proId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
