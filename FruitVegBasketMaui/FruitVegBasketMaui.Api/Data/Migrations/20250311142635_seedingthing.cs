using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FruitVegBasketMaui.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedingthing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BgColor",
                value: "#ffff00");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BgColor",
                value: "#7fbdc7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BgColor",
                value: "#ffff00");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BgColor",
                value: "#e28083");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BgColor",
                value: "#dad1f9");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BgColor",
                value: "#e28083");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BgColor",
                value: "#e28083");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BgColor",
                value: "#d0f200");
        }
    }
}
