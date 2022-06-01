using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAreasFiguras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false; //Atributo para salir            

            while (!salir) // Ciclo del programa 
            {
                menu(); // Menú del programa 
                int opcion = int.Parse(Console.ReadLine()); // Para resivir la opcion que desee el usuario

                switch (opcion) // Switch que ayuda con la opcion que digito el usuario 
                {
                    case 1:
                        areaDeUnRectangulo();
                        Console.ReadLine();
                        break;

                    case 2:
                        areaDeUnCuadrado();
                        Console.ReadLine();
                        break;

                    case 3:
                        areaDeUnCirculo();
                        Console.ReadLine();
                        break;
                    case 4:
                        areaDeUnTriangulo();
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Has desea salir del programa");
                        Console.ReadLine();
                        salir = true;
                        break;
                }
            }



        }
        //Metodo del menú del programa 
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la aplicacion para calcular el areá de las siguientes figuras");
            Console.WriteLine("Presione 1: Para Calcular el Areá de un Rectángulo");
            Console.WriteLine("Presione 2: Para Calcular el Areá de un Cuadrado");
            Console.WriteLine("Presione 3: Para Calcular el Areá de un Circulo");
            Console.WriteLine("Presione 4: Para Calcular el Areá de un Triángulo");
            Console.WriteLine("Presione 5: Salir");
            Console.WriteLine("************************************");
            Console.WriteLine("Precione la opcion que desee");
        }

        //Metodo para calcular el area de un rectangulo 
        public static float areaDeUnRectangulo()
        {
            float areaRectangulo = 0;
            try
            {
                Console.WriteLine("Digite la altura del rectángulo");
                float alturaRectangulo = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite la base del rectángulo");
                float baseRectangulo = float.Parse(Console.ReadLine());
                areaRectangulo = alturaRectangulo * baseRectangulo;
                Console.WriteLine("El areá es " + areaRectangulo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, digitar un numero");

            }

            return areaRectangulo;
        }

        //Metodo para calcular el cuadrado de un cuadrado 

        public static float areaDeUnCuadrado()
        {
            float areaCuadrado = 0;
            try
            {
                Console.WriteLine("Digite la medida de un lado del cuadrado");
                float ladoNumeroUno = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite la medida de un lado del cuadrado");
                float ladoNumeroDos = float.Parse(Console.ReadLine());
                areaCuadrado = ladoNumeroUno * ladoNumeroDos;
                Console.WriteLine("El areá es " + areaCuadrado);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, digitar un numero");

            }

            return areaCuadrado;
        }

        //Metedo para calcular el area de un circulo 
        public static double areaDeUnCirculo()
        {
            double areaCirculo = 0;
            double potencia = 0;
            double pi = 3.14;
            try
            {
                Console.WriteLine("Digite la medida del radio");
                float ladoNumeroUno = float.Parse(Console.ReadLine());
                potencia = Math.Pow(ladoNumeroUno, 2);
                areaCirculo = pi * potencia;
                Console.WriteLine("El areá del circulo " + areaCirculo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, digitar un numero");

            }

            return areaCirculo;
        }

        //Metodo para calcular el area de un triangulo 
        public static float areaDeUnTriangulo()
        {
            float areaTriangulo = 0;
            try
            {
                Console.WriteLine("Digite la altura del triangulo");
                float alturaTriangulo = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite la base del triangulo");
                float baseTriangulo = float.Parse(Console.ReadLine());
                areaTriangulo = (alturaTriangulo * baseTriangulo) / 2;
                Console.WriteLine("El areá del triangulo = " + areaTriangulo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, digitar un numero");

            }

            return areaTriangulo;
        }



    }
}


