using Usoif.models;

namespace Usoif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño , Joven o adulto
            /*
             * Niños 0- 12
             * Joven 13 - 25
             * Adultos 26 a mas.
             **/
            Console.WriteLine("Evaluar Edad");
            Console.Write("Ingresa tu edad");
            int edad = 0;
            edad = Convert.ToInt16(Console.ReadLine());
            Evaluate evaluate = new Evaluate();
                string message = evaluate.EvalAge(edad);
            Console.WriteLine(message);
           
        }
    }
}
