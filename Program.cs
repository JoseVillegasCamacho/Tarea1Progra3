using System;

namespace tarea1Progra3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program ma = new Program();
            

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Ingresar nombres y notas de 5 estudiantes");
                    Console.WriteLine("2. Calcular el promedio de las 5 notas");
                    Console.WriteLine("3. Calcular la nota mas alta");
                    Console.WriteLine("4. Calcular cuantos estudiantes tienen una nota mayor al promedio y cuantos una nota menor");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            ma.Cargar();
                            break;

                        case 2:
                            ma.calcularPromedio();
                            break;

                        case 3:
                            ma.calcularNotaMasAlta();
                            break;
                        case 4:
                            ma.mayorYMenorAlPromedio();
                            salir = true;
                            break;
                        case 5:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();
        }

        public int acumulador = 0;
        public string[] nombres; //empleados
        public int[] notas; //sueldostot

        public void Cargar()
        {
            nombres = new String[5];
            notas = new int[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("\n"+"Ingrese el nombre del estudiante");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }


        public void calcularPromedio()
        {
            

            for (int i = 0; i < notas.Length; i++)
            {
                acumulador += notas[i];
            }
            acumulador = acumulador / notas.Length;

            Console.WriteLine("El promedio de las notas es de: "+acumulador+ "\n");
        }

        public void calcularNotaMasAlta()
        {
            int mayor = notas[0];
            String nombreAlta = nombres[0];

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                    nombreAlta = nombres[i];
                }
            }
            Console.WriteLine("El estudiante con mayor nota es " + nombreAlta + " que tiene una nota de " + mayor+ "\n");
        }

        public void mayorYMenorAlPromedio()
        {
            int totalEstudiantesMayor = 0;
            int totalEstudiantesMenor = 0;
            int totalIgualPromedio = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < acumulador)
                {
                    totalEstudiantesMenor++;
                }
                else if (notas[i] > acumulador)
                {
                    totalEstudiantesMayor++;
                }
                else if (notas[i] == acumulador)
                {
                    totalIgualPromedio++;
                }
            }
            Console.WriteLine("Hay "+totalEstudiantesMayor+" estudiantes mayor al promedio,"+ "\n"+"Hay "+totalEstudiantesMenor+" estudiantes menores al promedio," + "\n"+"Hay "+totalIgualPromedio+" estudiantes igual al promedio");

        }

    }
}
