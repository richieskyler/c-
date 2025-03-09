using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Richard.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDescriptionName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desciprion",
                table: "Products",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Desciprion");
        }
    }
}
