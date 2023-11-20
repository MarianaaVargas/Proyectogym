using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Shared.Entidades
{
    public class Registros
    {
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Registro { get; set; }

        [Display(Name = "Hora de entrada")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Hora_Entrada { get; set; }

        [Display(Name = "Hora de salida")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Hora_Salida { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Cliente { get; set; }
        public Clientes clientes { get; set; }

        public int Id_Realizar { get; set; }
        public Realizar realizar { get; set; }

        public List <Actividades> actividades { get; set; }
        
        
    }
}
