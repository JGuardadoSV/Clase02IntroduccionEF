using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase02IntroduccionEF.Migrations
{
    /// <inheritdoc />
    public partial class sinapellidoEstudiante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Persona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Persona",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
