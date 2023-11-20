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
        public int Id_Usuario { get; set; }

        [Display(Name = "Estado del usuario")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Estado { get; set; }

        [Display(Name = "Email del cliente")]
        [MaxLength(40, ErrorMessage = "El campo no debe tener mas de 40 caracteres")]
        public string Email { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        public string Password { get; set; }

       public int Id_rol {  get; set; }
       public Roles rol { get; set; }


    }
}
