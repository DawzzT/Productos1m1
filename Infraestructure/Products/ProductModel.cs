using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Products
{
    class ProductModel
    {
        private Product[] productos;

        #region CRUD


        public void Add(Product p)
        {
            Add(p, ref productos);
        }

        public bool  Delete (Product p)
        {
            if(p == null)
            {
                throw new ArgumentException("El objeto no puede ser null");
            }
            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El producto con id {p.Id} no ha sido encontrado.");
            }
            if (index !=  productos.Length - 1)
            {
                productos[index] = productos[productos.Length - 1];
            }
            Product[] tmp = new Product[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;
            return productos.Length == tmp.Length;
        }
        public int Update(Product p)
        {
            if ( p == null)
            {
                throw new ArgumentException("El objeto no puede ser null");
            }

            int index = GetIndexById(p.Id);
            if ( index < 0)
            {
                throw new ArgumentException($"El producto con id {p.Id} no ha sido encontrado.");
            }
            productos[index] = p;
            return index;
        }
        public Product[] GetAll()
        {
            return productos;
        }


        #endregion

        #region PrivateMethods


        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El Id no puede ser menor que 0");
            }
           int index = int.MinValue, i = 0;
            if (productos == null)
            {
                return index;
            }
            foreach (Product p in productos)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void Add(Product p, ref Product[] pds)
        {
            if ( pds == null)
            {
                pds = new Product[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Product[] tmp = new Product[pds.Length - 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }


        #endregion

        #region Queries


        public Product GetProductById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException($"El id {id} no es valido");
            }
            int index = GetIndexById(id);
           
            return index <= 0 ? null : productos[index];
        }

        public Product[] GetProductByUnidadMedida(MeasurementUnit m)
        {
            Product[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach(Product p in productos)
            {
                if (p.Unit == m)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Product[] GetProductByCaducity(DateTime dt)
        {
            Product[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Product p in productos)
            {
                if (p.CaducityDate.CompareTo(dt) <=0)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Product[] GetProductByPriceRange(decimal min, decimal max)
        {
            Product[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Product p in productos)
            {
                if (p.Price >= min && p.Price <= max)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Product[] GetProductByPrice()
        {
            Array.Sort(productos, new Product.ProductPriceCompare());

            return productos;
        }

        #endregion
    }
}
