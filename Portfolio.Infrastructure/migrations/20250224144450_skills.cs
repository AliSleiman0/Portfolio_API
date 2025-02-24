using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class skills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "skill_id",
                table: "skills_g",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "skill_id",
                table: "skills_f",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "skill_id",
                table: "skills_b",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "skills_g",
                newName: "skill_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "skills_f",
                newName: "skill_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "skills_b",
                newName: "skill_id");
        }
    }
}
