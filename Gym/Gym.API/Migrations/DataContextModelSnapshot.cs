﻿// <auto-generated />
using Gym.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gym.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gym.Shared.Entidades.Actividades", b =>
                {
                    b.Property<int>("Id_Actividad")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Actividad"));

                    b.Property<string>("Complejidad")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Id_Monitor")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Modalidad")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Actividad");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Clientes", b =>
                {
                    b.Property<int>("Id_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Cliente"));

                    b.Property<string>("Apellido1")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Apellido2")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Ciudad")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Id_Rol")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Identificacion")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("NumCuenta")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("Id_Cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.FichaMedica", b =>
                {
                    b.Property<int>("Id_Ficha")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Ficha"));

                    b.Property<string>("Altura")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Condicion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IMC")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_Cliente")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Peso")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Ficha");

                    b.ToTable("FichaMedica");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Inscribir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Cliente")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Id_Plan")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("inscribir");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Monitores", b =>
                {
                    b.Property<int>("Id_Monitor")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Monitor"));

                    b.Property<string>("Apellido1")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Apellido2")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Ciudad")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Id_Rol")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Identificacion")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("Id_Monitor");

                    b.ToTable("Monitores");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Pagos", b =>
                {
                    b.Property<int>("Id_Pagos")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Pagos"));

                    b.Property<string>("Fecha")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Id_Cliente")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Id_Plan")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasMaxLength(45)
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasMaxLength(45)
                        .HasColumnType("float");

                    b.HasKey("Id_Pagos");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.PlanEntrenamiento", b =>
                {
                    b.Property<int>("Id_Plan")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Plan"));

                    b.Property<string>("Fecha_Fin")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Fecha_Inico")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Id_Cliente")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Id_Monitor")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Plan")
                        .HasMaxLength(45)
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("Id_Plan");

                    b.ToTable("planEntrenamiento");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Realizar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Actividad")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Id_Registro")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("realizar");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Registros", b =>
                {
                    b.Property<int>("Id_Registro")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Registro"));

                    b.Property<string>("Hora_Entrada")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Hora_Salida")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Id_Cliente")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id_Registro");

                    b.ToTable("registros");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Roles", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"));

                    b.Property<string>("Estado")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Rol")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Gym.Shared.Entidades.Usuarios", b =>
                {
                    b.Property<int>("Id_Usuarios")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Usuarios"));

                    b.Property<string>("Contraseña")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Id_Rol")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id_Usuarios");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
