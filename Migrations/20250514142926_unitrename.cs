using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackIT.Migrations
{
    /// <inheritdoc />
    public partial class unitrename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Unit",
                newName: "IsActive");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Unit",
                newName: "Active");
        }
    }
}
