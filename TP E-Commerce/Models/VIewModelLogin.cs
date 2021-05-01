using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TP_E_Commerce.Models
{
    public class VIewModelLogin
    {
        [Required]
        [Display(Name ="Nombre de Usuario")]
        public string user { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}