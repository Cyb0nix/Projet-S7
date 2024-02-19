using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaAPI.Migrations
{
    /// <inheritdoc />
    public partial class te : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountsReceivable",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountsReceivable",
                table: "Customers");
        }
    }
}
