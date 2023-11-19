using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.API.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "Roles",
                newName: "Id_Rol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_Rol",
                table: "Roles",
                newName: "IdRol");
        }
    }
}
