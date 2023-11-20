using Gym.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Shared.Entities
{
    public class Monitores
    {
        public int Id_Monitor { get; set; }

        [Display(Name = "Nombre del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Primer apellido del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Apellido1 { get; set; }

        [Display(Name = "Segundo apellido del monitor")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Apellido2 { get; set; }
        [Display(Name = "Identificacion del monitor")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Identificacion { get; set; }

        [Display(Name = "Direccion de residencia del monitor")]
        [MaxLength(30, ErrorMessage = "El campo no debe tener mas de 30 caracteres")]
        public string Direccion { get; set; }

        [Display(Name = "Ciudad de residencia del monitor")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public string Ciudad { get; set; }

        [Display(Name = "Numero telefonico del monitor")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Telefono { get; set; }

        public List<Actividades> actividades { get; set; }
    }
}
