using Gym.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Gym.API.Data

{
    public class DataContext:DbContext
    {
        public DataContext() : base()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Actividades> Actividades { get; set; }
        public DbSet <RolesUsuario> rolesUsuario { get; set; }
        public DbSet <Clientes> Clientes { get; set; }
        public DbSet <FichaMedica> FichaMedica { get; set; }
        public DbSet <Inscribir> inscribir { get; set; }
        public DbSet <Pagos> Pagos { get; set; }
        public DbSet <PlanEntrenamiento> planEntrenamiento { get; set; }
        public DbSet <Realizar> realizar { get; set; }
        public DbSet <Registros> registros { get; set; }
        public DbSet <Rol> Rol { get; set; }
        public DbSet <Usuarios> usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actividades>().HasKey(x => x.Id_Actividad);
            modelBuilder.Entity<Clientes>().HasKey(x => x.Id_Cliente);
            modelBuilder.Entity<Clientes>().Property(f => f.Id_Cliente).ValueGeneratedOnAdd();
            modelBuilder.Entity<FichaMedica>().HasKey(x => x.Id_Ficha);
            modelBuilder.Entity<Inscribir>().HasKey(x => x.Id);
            modelBuilder.Entity<Pagos>().HasKey(x => x.Id_Pagos);
            modelBuilder.Entity<PlanEntrenamiento>().HasKey(x => x.Id_Plan);

            modelBuilder.Entity<Realizar>().HasKey(x => x.Id);
            modelBuilder.Entity<Registros>().HasKey(x => x.Id_Registro);
            modelBuilder.Entity<Rol>().HasKey(x => x.Id_Rol);

            modelBuilder.Entity<Usuarios>().HasKey(x => x.Id_Usuario);
            modelBuilder.Entity<Usuarios>().Property(f => f.Id_Usuario).ValueGeneratedOnAdd();

            modelBuilder.Entity<RolesUsuario>().HasKey(p => p.id);
            modelBuilder.Entity<RolesUsuario>().Property(f => f.id).ValueGeneratedOnAdd();

            //RELACIONES
            modelBuilder.Entity<RolesUsuario>().HasOne(ur => ur.usuario).WithMany(u => u.RolesUsuario).HasForeignKey(ur => ur.usuario_id);
            modelBuilder.Entity<RolesUsuario>().HasOne(ur => ur.rol).WithMany(r => r.RolesUsuario).HasForeignKey(ur => ur.Id_Rol);
            modelBuilder.Entity<Usuarios>().HasOne(u => u.Cliente).WithOne(c => c.Usuario).HasForeignKey<Clientes>(c => c.Id_Usuario);
        }
                  
    }
}
