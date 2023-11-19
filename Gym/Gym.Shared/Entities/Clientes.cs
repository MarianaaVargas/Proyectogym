using System.ComponentModel.DataAnnotations;

namespace Gym.Shared.Entidades
{
    public class Clientes
    {

        public int Id_Cliente { get; set; }

        public int Id_Usuario { get; set; }

        public Usuarios Usuario { get; set; }

        [Display(Name = "Nombre del cliente")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string? Nombre { get; set; }

        [Display(Name = "Primer apellido del cliente")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string? Apellido1 { get; set; }

        [Display(Name = "Segundo apellido del cliente")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string? Apellido2 { get; set; }
        [Display(Name = "Identificacion del cliente")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Identificacion { get; set; }

        [Display(Name = "Direccion de residencia del cliente")]
        [MaxLength(30, ErrorMessage = "El campo no debe tener mas de 30 caracteres")]
        public string? Direccion { get; set; }

        [Display(Name = "Ciudad de residencia del cliente")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public string? Ciudad { get; set; }

        [Display(Name = "Numero telefonico del cliente")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Telefono { get; set; }

        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int NumCuenta { get; set; }

        public PlanEntrenamiento? plan {  get; set; }

    }
}
