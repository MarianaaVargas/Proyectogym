using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gym.Shared.Entidades
{
    public class Rol
    {

     
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Rol { get; set; }


        [Display(Name = "Rol del usuario")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public string Nombre { get; set; }

        public ICollection<RolesUsuario> RolesUsuario { get; set; }



    }
}
