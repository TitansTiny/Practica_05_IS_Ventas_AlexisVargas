﻿using AcessoADatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductosNegocio
    {
        ProductoDatos productos;
        public ProductosNegocio()
        {
            productos = new ProductoDatos();
        }
        public List<Producto> All()
        {
            return productos.Listar();
        }
        public Producto ById(int id)
        {
            return productos.Listar().Where(p => p.id == id).SingleOrDefault();
        }
        public bool insertarProducto(Producto productoNuevo)
        {
            return productos.Nuevo(productoNuevo);
        }
        public bool actualizarProducto(Producto producto)
        {
            return productos.Actualizar(producto);
        }
        public bool eliminarProducto(Producto producto)
        {
            return productos.Eliminar(producto);
        }
    }
}
