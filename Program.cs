using System;
using System.Runtime.Serialization.Formatters;

namespace Arrays_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int k = 1;
            string[] nombres = new string[6] { "Hamel", "Juan  ", "Ana  ", "Miguel", "Lucia", "Maria" };
            int[] edad = new int[6] { 22, 34, 24, 19, 52, 29 };

            for (int i = 0; i < nombres.Length; i++)
            {
                
                Console.WriteLine($"{k}. {nombres[i]}\t{edad[i]}");
                k++;
            }

            var materias5to = new[]
            {
                new {Materia="Análisis de sistemas\t", Creditos=4},
                new {Materia="Redes I\t\t\t", Creditos=4},
                new {Materia="Física II\t\t\t", Creditos = 4},
                new {Materia= "Gestion Empresarial\t\t", Creditos = 3},
                new{Materia="Base de datos\t\t", Creditos= 4}
            };
            Console.WriteLine("\n\t\tQuinto Cuatrimestre\n");
            for (int i = 0; i < materias5to.Length; i++)
            {
                Console.WriteLine(materias5to[i]);
            }

            Estudiantes[] datos = new Estudiantes[10];
            datos[0] = new Estudiantes("Luis  ", "Ing. En Sistemas");
            datos[1] = new Estudiantes("Miguel", "Medicina    ");
            datos[2] = new Estudiantes("José  ", "Psicología  ");
            datos[3] = new Estudiantes("Ana  ", "Contabilidad");
            datos[4] = new Estudiantes("Samel", "CiberSeguridad");
            datos[5] = new Estudiantes("Julio", "Arquitectura");
            datos[6] = new Estudiantes("Maria", "Telecomunicación");
            datos[7] = new Estudiantes("Lisbeth", "Ciencias Sociales");
            datos[8] = new Estudiantes("Nora  ", "Matemáticas  ");
            datos[9] = new Estudiantes("Johnny", "Diseño grafico");

            Console.WriteLine("_________________________________________________________");
            foreach (Estudiantes recorrer in datos)
            {                
                Console.WriteLine(recorrer.GetInfo());               
            }
            Console.WriteLine("_________________________________________________________");
        }
    }
    class Estudiantes
    {
        private String nombres;
        private String carreras;
        
        public Estudiantes(String nombres, String carreras)
        {
            this.nombres = nombres;
            this.carreras = carreras;
        }
        public String GetInfo()
        {
            return "| Nombre: " + nombres + " \t| Carrera: " + carreras + " \t|";
        }
    }
}
