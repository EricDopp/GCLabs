using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoptionMVC.Migrations
{
    /// <inheritdoc />
    public partial class Buddy2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1,
                column: "img",
                value: "https://images.pexels.com/photos/332612/pexels-photo-332612.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1,
                column: "img",
                value: "");
        }
    }
}
