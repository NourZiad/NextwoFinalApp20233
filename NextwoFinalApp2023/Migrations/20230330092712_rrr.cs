using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NextwoFinalApp2023.Migrations
{
    /// <inheritdoc />
    public partial class rrr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Venu",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Venu",
                table: "Courses");
        }
    }
}
