using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models
{
    public class CLIENTE
    {
        [Key]
        [Required]
        [Display(Name = "Usuario")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_USUARIO { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "Máximo 25 caracteres")]
        public string CLI_CONTRASENA { get; set; }

        [Required]
        [Display(Name = "Cédula/RUC")]
        [MinLength(10, ErrorMessage = "Mínimo 10 caracteres")]
        [MaxLength(13, ErrorMessage = "Máximo 13 caracteres")]
        public string CLI_CEDULA_RUC { get; set; }

        [Required]
        [Display(Name = "Email")]
        [MinLength(7, ErrorMessage = "Mínimo 7 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_EMAIL { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_NOMBRE { get; set; }

        [Display(Name = "Apellido")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_APELLIDO { get; set; }

        [Display(Name = "Edad")]
        [Range(18, 120, ErrorMessage ="Debe tener al menos 18 años")]
        public int CLI_EDAD { get; set; }

        [Display(Name = "Sexo")]
        public char CLI_SEXO { get; set; }

        [Display(Name = "Dirección")]
        [MinLength(10, ErrorMessage = "Mínimo 10 caracteres")]
        [MaxLength(250, ErrorMessage = "Máximo 250 caracteres")]
        public string CLI_DIRECCION { get; set; }

        [Display(Name = "Ciudad")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_CIUDAD { get; set; }

        [Display(Name = "Provincia")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_PROVINCIA { get; set; }

        [Display(Name = "Teléfono")]
        [MinLength(7, ErrorMessage = "Mínimo 7 caracteres")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string CLI_TELEFONO { get; set; }

    }
}
