using Gym.Shared.Entidades;
using Gym.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

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
        public DbSet <Clientes> Clientes { get; set; }
        public DbSet <Monitores> Monitores { get; set; }
        public DbSet <FichaMedica> FichaMedica { get; set; }
        public DbSet <Inscribir> inscribir { get; set; }
        public DbSet <Pagos> Pagos { get; set; }
        public DbSet <PlanEntrenamiento> planEntrenamiento { get; set; }
        public DbSet <Realizar> realizar { get; set; }
        public DbSet <Registros> registros { get; set; }
        public DbSet <Roles> Rol { get; set; }
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
            modelBuilder.Entity<Actividades>().Property(f => f.Id_Actividad).ValueGeneratedOnAdd();
            modelBuilder.Entity<Clientes>().HasKey(x => x.Id_Cliente);
            modelBuilder.Entity<Clientes>().Property(f => f.Id_Cliente).ValueGeneratedOnAdd();
            modelBuilder.Entity<Monitores>().HasKey(x => x.Id_Monitor);
            modelBuilder.Entity<Monitores>().Property(f => f.Id_Monitor).ValueGeneratedOnAdd();
            modelBuilder.Entity<FichaMedica>().HasKey(x => x.Id_Ficha);
            modelBuilder.Entity<FichaMedica>().Property(f => f.Id_Ficha).ValueGeneratedOnAdd();
            modelBuilder.Entity<Inscribir>().HasKey(x => x.Id_Inscripcion);
            modelBuilder.Entity<Inscribir>().Property(f => f.Id_Inscripcion).ValueGeneratedOnAdd();
            modelBuilder.Entity<Pagos>().HasKey(x => x.Id_Pagos);
            modelBuilder.Entity<Pagos>().Property(f => f.Id_Pagos).ValueGeneratedOnAdd();
            modelBuilder.Entity<PlanEntrenamiento>().HasKey(x => x.Id_Plan);
            modelBuilder.Entity<PlanEntrenamiento>().Property(f => f.Id_Plan).ValueGeneratedOnAdd();
            modelBuilder.Entity<Realizar>().HasKey(x => x.Id_Realizar);
            modelBuilder.Entity<Realizar>().Property(f => f.Id_Realizar).ValueGeneratedOnAdd();
            modelBuilder.Entity<Registros>().HasKey(x => x.Id_Registro);
            modelBuilder.Entity<Registros>().Property(f => f.Id_Registro).ValueGeneratedOnAdd();
            modelBuilder.Entity<Roles>().HasKey(x => x.Id_Rol);
            modelBuilder.Entity<Usuarios>().HasKey(x => x.Id_Usuario);
            modelBuilder.Entity<Usuarios>().Property(f => f.Id_Usuario).ValueGeneratedOnAdd();
            

            //RELACIONES
            
            
            modelBuilder.Entity<Clientes>()
            .HasOne(c => c.fichaMedica)
            .WithOne(fm => fm.clientes)
            .HasForeignKey<FichaMedica>(fm => fm.Id_Cliente);

            modelBuilder.Entity<Clientes>()
           .HasOne(c => c.plan)
           .WithOne(pe => pe.Clientes)
           .HasForeignKey<PlanEntrenamiento>(pe => pe.Id_Cliente);


            modelBuilder.Entity<Clientes>()
           .HasOne(c => c.inscribir)
           .WithOne(i => i.clientes)
           .HasForeignKey<Inscribir>(i => i.Id_Cliente);

            modelBuilder.Entity<Monitores>()
            .HasMany(m => m.actividades)
            .WithOne(e => e.monitores)
            .HasForeignKey(e => e.Id_Monitor);

            modelBuilder.Entity<Clientes>()
           .HasMany(c => c.registros)
           .WithOne(r => r.clientes)
           .HasForeignKey(r => r.Id_Cliente);

            modelBuilder.Entity<Clientes>()
          .HasMany(c => c.pagos)
          .WithOne(p => p.clientes)
          .HasForeignKey(p => p.Id_Cliente);

            modelBuilder.Entity<Realizar>()
           .HasMany(r => r.registros)
           .WithOne(reg => reg.realizar)
           .HasForeignKey(reg => reg.Id_Realizar);

          
            modelBuilder.Entity<Registros>()
                .HasMany(reg => reg.actividades)
                .WithOne(act => act.registros)
                .HasForeignKey(act => act.Id_Registro);

            modelBuilder.Entity<Roles>()
           .HasMany(r => r.usuarios)
           .WithOne(u => u.rol)
           .HasForeignKey(u => u.Id_rol);
        }
                  
    }
}
