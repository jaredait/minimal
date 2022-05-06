﻿using Minimal_Cliente.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public interface IProductoCarritoAccess
    {
        IEnumerable<ProductoCarritoViewModel> GetProductoCarritoViewModels(IEnumerable<CARRITO> listaCarrito);
    }
}