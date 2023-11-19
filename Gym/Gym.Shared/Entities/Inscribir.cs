using System.ComponentModel.DataAnnotations;

namespace Gym.Shared.Entidades
{
    public class Inscribir
    {
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Cliente { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        public int Id_Plan { get; set; }
    }
}
