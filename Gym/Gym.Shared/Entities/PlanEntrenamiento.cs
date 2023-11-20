using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gym.Shared.Entidades
{
    public class PlanEntrenamiento
    {
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Plan { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Cliente { get; set; }

        public Clientes Clientes { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Monitor { get; set; }

        [Display(Name = "Plan de entrenamiento")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public int Plan { get; set; }

        [Display(Name = "Precio del plan de entrenamiento")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public int Precio { get; set; }

        [Display(Name = "Observaciones sobre el plan de entrenamiento")]
        [MaxLength(100, ErrorMessage = "El campo no debe tener mas de 100 caracteres")]
        public string Observaciones { get; set; }

       
        [Display(Name = "Fecha inicio")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Fecha_Inico { get; set; }

        [Display(Name = "Fecha fin")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Fecha_Fin { get; set; }

        
    }
}
