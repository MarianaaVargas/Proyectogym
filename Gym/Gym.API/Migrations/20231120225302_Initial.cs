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
                name: "Monitores",
                columns: table => new
                {
                    Id_Monitor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Apellido1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Apellido2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Identificacion = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitores", x => x.Id_Monitor);
                });

            migrationBuilder.CreateTable(
                name: "realizar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Id_Registro = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Id_Actividad = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_realizar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id_Rol = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id_Rol);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id_rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id_Usuario);
                    table.ForeignKey(
                        name: "FK_usuarios_Rol_Id_rol",
                        column: x => x.Id_rol,
                        principalTable: "Rol",
                        principalColumn: "Id_Rol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioId_Usuario = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Apellido1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Apellido2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Identificacion = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefono = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    NumCuenta = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_Cliente);
                    table.ForeignKey(
                        name: "FK_Clientes_usuarios_UsuarioId_Usuario",
                        column: x => x.UsuarioId_Usuario,
                        principalTable: "usuarios",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FichaMedica",
                columns: table => new
                {
                    Id_Ficha = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condicion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Altura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IMC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaMedica", x => x.Id_Ficha);
                    table.ForeignKey(
                        name: "FK_FichaMedica_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_inscribir_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id_Pagos = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Precio = table.Column<double>(type: "float", maxLength: 45, nullable: false),
                    Fecha = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Id_Plan = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Total = table.Column<double>(type: "float", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id_Pagos);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
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
                    Observaciones = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fecha_Inico = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Fecha_Fin = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planEntrenamiento", x => x.Id_Plan);
                    table.ForeignKey(
                        name: "FK_planEntrenamiento_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registros",
                columns: table => new
                {
                    Id_Registro = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hora_Entrada = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Hora_Salida = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Id_Cliente = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Id_Realizar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registros", x => x.Id_Registro);
                    table.ForeignKey(
                        name: "FK_registros_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_registros_realizar_Id_Realizar",
                        column: x => x.Id_Realizar,
                        principalTable: "realizar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    Id_Actividad = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Modalidad = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Complejidad = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id_Monitor = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Id_Registro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.Id_Actividad);
                    table.ForeignKey(
                        name: "FK_Actividades_Monitores_Id_Monitor",
                        column: x => x.Id_Monitor,
                        principalTable: "Monitores",
                        principalColumn: "Id_Monitor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actividades_registros_Id_Registro",
                        column: x => x.Id_Registro,
                        principalTable: "registros",
                        principalColumn: "Id_Registro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_Id_Monitor",
                table: "Actividades",
                column: "Id_Monitor");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_Id_Registro",
                table: "Actividades",
                column: "Id_Registro");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioId_Usuario",
                table: "Clientes",
                column: "UsuarioId_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_FichaMedica_Id_Cliente",
                table: "FichaMedica",
                column: "Id_Cliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_inscribir_Id_Cliente",
                table: "inscribir",
                column: "Id_Cliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_Id_Cliente",
                table: "Pagos",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_planEntrenamiento_Id_Cliente",
                table: "planEntrenamiento",
                column: "Id_Cliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_registros_Id_Cliente",
                table: "registros",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_registros_Id_Realizar",
                table: "registros",
                column: "Id_Realizar");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_Id_rol",
                table: "usuarios",
                column: "Id_rol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "FichaMedica");

            migrationBuilder.DropTable(
                name: "inscribir");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "planEntrenamiento");

            migrationBuilder.DropTable(
                name: "Monitores");

            migrationBuilder.DropTable(
                name: "registros");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "realizar");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
