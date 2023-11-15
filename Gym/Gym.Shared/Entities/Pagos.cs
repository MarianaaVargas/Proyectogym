using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gym.Shared.Entidades
{
    public class Pagos
    {
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Pagos { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Cliente { get; set; }

        [Display(Name = "Precio")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public double Precio { get; set; }

        [Display(Name = "Fecha")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string? Fecha { get; set; }

        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Plan { get; set; }

        [Display(Name = "Total a pagar")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public double Total { get; set; }

    }
}

