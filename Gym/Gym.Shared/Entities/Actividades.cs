using Gym.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gym.Shared.Entidades
{
    public class Actividades
    {
        
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage= "El campo es obligatorio")]
        public int Id_Actividad { get; set; }

        [Display(Name = "Nombre de la actividad")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Modalidad de la actividad")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Modalidad { get; set; }

        [Display(Name = "Complejidad de la actividad")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Complejidad { get; set; }

        [Display(Name = "Descripcion de la actividad")]
        [MaxLength(100, ErrorMessage = "El campo no debe tener mas de 100 caracteres")]
        public string Descripcion { get; set; }

        [Display(Name = "Observaciones")]
        [MaxLength(100, ErrorMessage = "El campo no debe tener mas de 100 caracteres")]
        public string Observaciones { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Monitor { get; set; }

        public Monitores monitores { get; set; }

        public int Id_Registro { get; set; }
        public Registros registros { get; set; }

    }
  
}
