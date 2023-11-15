using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Shared.Entidades
{
    public class Usuarios
    {
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Usuarios { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        public string? Contraseña { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Rol {get; set; }


    }
}
