using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    Id_Actividad = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Modalidad = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Complejidad = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Id_Monitor = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.Id_Actividad);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Rol = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Apellido1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Apellido2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Identificacion = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefono = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NumCuenta = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "FichaMedica",
                columns: table => new
                {
                    Id_Ficha = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condicion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Altura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Peso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IMC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaMedica", x => x.Id_Ficha);
                });

            migrationBuilder.CreateTable(
                name: "inscribir",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Id_Plan = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscribir", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monitores",
                columns: table => new
                {
                    Id_Monitor = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Rol = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Apellido1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Apellido2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Identificacion = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefono = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitores", x => x.Id_Monitor);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id_Pagos = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Precio = table.Column<double>(type: "float", maxLength: 45, nullable: false),
                    Fecha = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Id_Plan = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Total = table.Column<double>(type: "float", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id_Pagos);
                });

            migrationBuilder.CreateTable(
                name: "planEntrenamiento",
                columns: table => new
                {
                    Id_Plan = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Id_Monitor = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Plan = table.Column<int>(type: "int", maxLength: 45, nullable: false),
                    Precio = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Fecha_Inico = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Fecha_Fin = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planEntrenamiento", x => x.Id_Plan);
                });

            migrationBuilder.CreateTable(
                name: "realizar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Registro = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Id_Actividad = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_realizar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registros",
                columns: table => new
                {
                    Id_Registro = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hora_Entrada = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Hora_Salida = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registros", x => x.Id_Registro);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id_Usuarios = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contraseña = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Id_Rol = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id_Usuarios);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "FichaMedica");

            migrationBuilder.DropTable(
                name: "inscribir");

            migrationBuilder.DropTable(
                name: "Monitores");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "planEntrenamiento");

            migrationBuilder.DropTable(
                name: "realizar");

            migrationBuilder.DropTable(
                name: "registros");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
