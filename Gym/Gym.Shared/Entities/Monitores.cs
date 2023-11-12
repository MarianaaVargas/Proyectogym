using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gym.Shared.Entidades
{
    public class Monitores
    {

        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Monitor { get; set; }

        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Rol { get; set; }

        [Display(Name = "Nombre del Monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Primer apellido del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Apellido1 { get; set; }

        [Display(Name = "Segundo apellido del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Apellido2 { get; set; }
        [Display(Name = "Identificacion del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Identificacion { get; set; }

        [Display(Name = "Direccion de residencia del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 30 caracteres")]
        public string Direccion { get; set; }

        [Display(Name = "Ciudad de residencia del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public string Ciudad { get; set; }

        [Display(Name = "Numero telefonico del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Telefono { get; set; }

        [Display(Name = "Email del cliente")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 40 caracteres")]
        public string Email { get; set; }

        
    }
}
