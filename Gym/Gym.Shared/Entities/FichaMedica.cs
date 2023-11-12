using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Shared.Entidades
{
    public class FichaMedica
    {
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Ficha { get; set; }

        [Display(Name = "Condicion medica")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 50 caracteres")]
        public string Condicion { get; set; }

        [Display(Name = "Altura")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 50 caracteres")]
        public string Altura { get; set; }

        [Display(Name = "Peso")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 50 caracteres")]
        public string Peso { get; set; }

        [Display(Name = "Indice de masa corporal")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 50 caracteres")]
        public string IMC { get; set; }

        [Display(Name = "Observaciones")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 100 caracteres")]
        public string Observaciones { get; set; }

        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Cliente { get; set; }

        
        
    }
}
