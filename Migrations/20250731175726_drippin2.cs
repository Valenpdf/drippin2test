using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drippin.Migrations
{
    /// <inheritdoc />
    public partial class drippin2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EsDestacado",
                table: "Producto",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsDestacado",
                table: "Producto");
        }
    }
}
