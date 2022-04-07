using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class FACTURA
    {
        [Key]
        [Required]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres")]
        [Display(Name = "Número de factura")]
        public string FAC_NUMERO { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Cliente/Usuario")]
        public string CLI_USUARIO { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres")]
        [Display(Name = "ID tipo de envío")]
        public string TIP_ID { get; set; }


        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres")]
        [Display(Name = "Número de envío")]
        public string ENV_NUMERO { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de facturación")]
        public DateTime FAC_FECHA { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Mínimo 10 caracteres")]
        [MaxLength(250, ErrorMessage = "Máximo 250 caracteres")]
        [Display(Name = "Dirección cliente")]
        public string FAC_DIRECCION_CLI { get; set; }

        [Required]
        [MinLength(7, ErrorMessage = "Mínimo 7 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Email cliente")]
        public string FAC_EMAIL_CLI { get; set; }
        
        [Display(Name = "Subtotal")]
        [Range(0, 9999999.99, ErrorMessage = "Subtotal fuera de los rangos establecidos")]
        public decimal FAC_MONTO_SUBTOTAL { get; set; }
        
        [Display(Name = "Total")]
        [Range(0, 9999999.99, ErrorMessage = "Total fuera de los rangos establecidos")]
        public decimal FAC_MONTO_TOTAL { get; set; }
    }
}
