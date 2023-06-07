using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


            Person persona1 = new Person { Nombre = "Milagros", Edad = 45 };
            Person persona2 = new Person { Nombre = "Belen", Edad = 55 };
            Person persona3 = new Person { Nombre = "Maria", Edad =60 };
            Person persona4 = new Person { Nombre = "Claudio", Edad = 4 };
            Person persona5 = new Person { Nombre = "Alfonso", Edad = 7 };
            Person persona6 = new Person { Nombre = "Matias", Edad = 5 };
            Person persona7 = new Person { Nombre = "Juano", Edad = 1 };
            Person persona8 = new Person { Nombre = "Sebastian", Edad = 4 };

            Node n1 = new Node(1, persona1);
            Node n2 = new Node(2, persona2);
            Node n3 = new Node(3, persona3);
            Node n4 = new Node(4, persona4);
            Node n5 = new Node(5, persona5);
            Node n6 = new Node(6, persona6);
            Node n7 = new Node(7, persona7);
            Node n8 = new Node(8, persona8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);


            // visitar el árbol aquí
            SumaEdades visitor = new SumaEdades();
            n1.Accept(visitor);

            //obtener suma de edades 
            int SumaDeEdades = visitor.SumaDeEdades;
            Console.WriteLine("Suma de edades: " + SumaDeEdades);

            //crear visitador de MayorEdadChild
            MayorEdadChild mayorEdadVisitor = new MayorEdadChild();

            //visitar arbol y determinar el hijo mas grande
            n2.Accept(mayorEdadVisitor);
             
            //obtener numero del hijo mas grande
            int mayorEdad = mayorEdadVisitor.MayorNumero();
            Console.WriteLine($"El hijo más grande tiene {mayorEdad} años");
            
            // crear visitador de NombreMasLargo
            NombreMasLargo nombreMasLargoVisitor = new NombreMasLargo();
        
            // visitar el arbol y determinar el nombre mas largo
            n3.Accept(nombreMasLargoVisitor);

            //obtener nombre mas largo
            string nombreMasLargo = nombreMasLargoVisitor.LongestName;
            Console.WriteLine("El nombre más largo es: " + nombreMasLargo);

           
            
        }
    }
}
