using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.ViewModels
{
    public class ProductoCarritoViewModel
    {
        [Display(Name = "ID")]
        public int CAR_ID { get; set; }

        [Display(Name = "Usuario")]
        public string CLI_USUARIO { get; set; }

        [Display(Name = "Producto ID")]
        public string PRD_ID { get; set; }

        [Display(Name = "Cantidad")]
        public int CAR_CANTIDAD { get; set; }

        [Display(Name = "Precio unitario")]
        [DataType(DataType.Currency)]
        public decimal PRD_PRECIO { get; set; }

        [Display(Name = "Peso")]
        public decimal PRD_PESO { get; set; }

        [Display(Name = "Descripción")]
        public string PRD_DESCRIPCION { get; set; }

        [Display(Name = "Imagen")]
        public string PRD_RUTA_IMAGEN { get; set; }

    }
}
