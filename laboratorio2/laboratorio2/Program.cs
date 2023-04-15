using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsLogica logi = new ClsLogica();
            ClsUsuario[] Tipousuario = new ClsUsuario[2];

            //Crear usuarios
            Tipousuario[0] = new Tipousuario(1, "SU", "Tomatito123", 22, "Admin", logi);
            Tipousuario[1] = new Tipousuario(2, "Bob", "1234", 25, "Vendedor", supermarket);

            Console.WriteLine("Bienvenido, inicie sesion");
            Console.WriteLine("Nombre de usuario");
            string User = Console.ReadLine();
            Console.WriteLine("Contraseña");
            string Pass = Console.ReadLine();

            int Level = 0;
            for (int i = 0; i < Tipousuario.Length; i++)
            {
                if (User == user[i].UserName && Pass == Tipousuario[i].Password)
                {
                    if (Tipousuario[i].Level == "Admin")
                    {
                        Level = 1;
                    }
                    if (Tipousuario[i].Level == "Vendedor")
                    {
                        Level = 2;
                    }
                }
            }

            if (Level == 1)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("¨1) Agregar categoria");
                Console.WriteLine("¨2) Agregar categoria");
                Console.WriteLine("¨3) Crear categoria");
                Console.WriteLine("¿Qué desea hacer?");
            }
            Console.WriteLine(Level);
            Console.ReadLine();
        }

    }
    }
    
}
