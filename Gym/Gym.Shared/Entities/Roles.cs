﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gym.Shared.Entidades
{
    public class Roles
    {

     
        [MaxLength(10, ErrorMessage = "El campo no debe tener mas de 10 caracteres")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Id_Rol { get; set; }

        [Display(Name = "Estado del usuario")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public string? Estado { get; set; }

        [Display(Name = "Rol del usuario")]
        [MaxLength(20, ErrorMessage = "El campo no debe tener mas de 20 caracteres")]
        public string? Rol { get; set; }



    }
}
