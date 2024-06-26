﻿using AcessoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DetalleFacturaDatos : IDatos<DetalleFactura>
    {
        servicios1Entities contexto;
        public DetalleFacturaDatos()
        {
            contexto = new servicios1Entities();
        }
        public bool Nuevo(DetalleFactura item)
        {
            if (contexto.DetalleFactura.Add(item) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public List<DetalleFactura> Listar()
        {
            return contexto.DetalleFactura.ToList();
        }
        public DetalleFactura BuscarId(int id)
        {
            return contexto.DetalleFactura.Where(df => df.id == id).FirstOrDefault();
        }
        public bool Actualizar(DetalleFactura item)
        {
            DetalleFactura temp = BuscarId(item.id);
            temp.idFactura = item.idFactura;
            temp.idProducto = item.idProducto;
            temp.cantidad = item.cantidad;
            temp.precio = item.precio;
            contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(DetalleFactura item)
        {
            DetalleFactura temp = BuscarId(item.id);
            if (temp != null)
            {
                contexto.DetalleFactura.Remove(temp);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
