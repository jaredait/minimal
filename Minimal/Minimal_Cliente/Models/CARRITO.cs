using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models
{
    public class CARRITO
    {
        public static int Default_Id = 1;
        public static int Default_Cantidad = 1;


        public CARRITO()
        {
            CAR_ID = Default_Id;
            CAR_CANTIDAD = Default_Cantidad;
        }

        [Key]
        public int CAR_ID { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_USUARIO { get; set; }

        [Required]
        [Display(Name = "ID")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(25, ErrorMessage = "Máximo 25 caracteres")]
        public string PRD_ID { get; set; }

        [Range(0, 65535)]
        [Display(Name = "Cantidad")]
        public int CAR_CANTIDAD { get; set; }
    }
}
