using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoptionMVC.Migrations
{
    /// <inheritdoc />
    public partial class MoreData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 8,
                column: "img",
                value: "https://images.pexels.com/photos/15802496/pexels-photo-15802496/free-photo-of-portrait-of-a-bengal-cat.jpeg?auto=compress&cs=tinysrgb&w=600");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 8,
                column: "img",
                value: "https://media.istockphoto.com/id/867775498/photo/bengal-cat-outdoor.jpg?s=612x612&w=is&k=20&c=hPk5pMn5h9IRQdvgAzipYnMn7VxkB28W1lsSNA_FPx0=");
        }
    }
}
