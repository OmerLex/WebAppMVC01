using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC01.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewPropertiesToCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Car");
        }
    }
}
