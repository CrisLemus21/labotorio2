﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    internal class ClsUsuario
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }

        private ClsLogica clsLogica;

        public void CreateCategory(string name)
        {
            ClsCategoria cate = new ClsCategoria { Name = name };
            clsLogica.AddCategory(cate);
        }

        public void CrearProducto(string nombre, string provedor, DateTime vencimiento,
                                  DateTime fechaEntrada, string detalle, decimal precio, int unidades)
        {
            ClsProdectos productos = new ClsProdectos();
            {
                Nombre = nombre,
                Provedor = provedor,
                vencimiento = expiry,
                fechaEntrada = entry,
                detalle = detail,
                precio = price,
                unidad = unit
            };
            supermarket.AddProduct(product);
        }

        public void DeleteCategory(string name)
        {
            Category category = supermarket.FindCategory(name);
            supermarket.DeleteCategory(category);
        }

        public void DeleteProduct(string name)
        {
            Product product = supermarket.FindProduct(name);
            supermarket.DeleteProduct(product);
        }

        public Category FindCategory(string name)
        {
            return supermarket.FindCategory(name);
        }

        public Product FindProduct(string name)
        {
            return supermarket.FindProduct(name);
        }

        public void SeeCategory()
        {
            Console.WriteLine("Categorías:");
            foreach (Category category in supermarket.Categories)
            {
                Console.WriteLine(category.Name);
            }
        }

        public void SeeProduct()
        {
            Console.WriteLine("Productos:");
            foreach (Product product in supermarket.Products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public void MakeSale(string clientName, string productDetail, decimal pay)
        {
            Sell sell = new Sell
            {
                ClientName = clientName,
                ProductDetail = productDetail,
                Pay = pay
            };

        }

        public User(int id, string name, string password, int age, string level, Supermarket supermarket)
        {
            this.id = id;
            this.UserName = name;
            this.Password = password;
            this.Age = age;
            this.Level = level;
            this.supermarket = supermarket;
        }
    }
}
