using Gym.API.Data;
using Gym.Shared.Entidades;
using Gym.Shared.Entities;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Market.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckActividadesAsync();
            await CheckClientesAsync();
            await CheckFichaMedicaAsync();
            await CheckInscribirAsync();
            await CheckMonitoresAsync();
            await CheckPagosAsync();
            await CheckPlanEntrenamientoAsync();
            await CheckRealizarAsync();
            await CheckRegistrosAsync();
            await CheckRolesAsync();
            await CheckUsuariosAsync();
        }

        private async Task CheckActividadesAsync()
        {
            if (!_context.Actividades.Any())
            {
                _context.Actividades.Add(new Actividades { Id_Actividad = 1 });
                _context.Actividades.Add(new Actividades { Nombre = "Sentadillas" });
            }

            await _context.SaveChangesAsync();
        }
        private async Task CheckClientesAsync()
        {
            if (_context.Clientes.Any()) 
            { 
                _context.Clientes.Add(new Clientes { Id_Cliente = 1 });
                _context.Clientes.Add(new Clientes { Nombre = "Andres" });

            }
            await _context.SaveChangesAsync();

        }

        private async Task CheckFichaMedicaAsync()
        {
            if (_context.FichaMedica.Any())
            {
                _context.FichaMedica.Add(new FichaMedica { Id_Ficha = 1 });

            }
            await _context.SaveChangesAsync();
        }
        private async Task CheckInscribirAsync()
        {
            if (_context.inscribir.Any())
            {
                _context.inscribir.Add(new Inscribir { Id_Inscripcion = 1 });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckMonitoresAsync()
        {
            if (_context.Monitores.Any())
            {
                _context.Monitores.Add(new Monitores { Id_Monitor = 1 });
                _context.Monitores.Add(new Monitores { Nombre = "Luis" });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckPagosAsync()
        {
            if (!_context.Pagos.Any())
            {
                _context.Pagos.Add(new Pagos { Id_Pagos = 1 });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckPlanEntrenamientoAsync()
        {
            if (_context.planEntrenamiento.Any())
            {
                _context.planEntrenamiento.Add(new PlanEntrenamiento { Id_Plan= 1 });
            }
            await _context.SaveChangesAsync();
        }
        private async Task CheckRealizarAsync()
        {
            if (_context.realizar.Any())
            {
                _context.realizar.Add(new Realizar { Id_Realizar = 1 });
            }
            await _context.SaveChangesAsync();
        }
        
        private async Task CheckRegistrosAsync()
        {
            if (_context.registros.Any())
            {
                _context.registros.Add(new Registros { Id_Registro = 1 });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckRolesAsync()
        {
            if (_context.Rol.Any())
            {
                _context.Rol.Add(new Roles { Id_Rol = 1 });
            }
            await _context.SaveChangesAsync();
        }
        private async Task CheckUsuariosAsync ()
        {
            if (_context.usuarios.Any())
            {
                _context.usuarios.Add(new Usuarios { Id_Usuario = 1 });
            }
            await _context.SaveChangesAsync();
        }
    }
}

