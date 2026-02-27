using System.ComponentModel.Design;

namespace FlujoDeControl_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empleado;
            double sueldo,sueldoAnual;
            

            Console.WriteLine("Ingrese el nombre del empleado:");
            empleado = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo del empleado:");
            sueldo = Convert.ToDouble(Console.ReadLine());

            sueldoAnual = sueldo * 12;
            double isr = 0;

            if (sueldoAnual <= 416220)
            {
                isr = 0;
            }
            else if (sueldoAnual > 416220 && sueldoAnual <= 624329)
            {
                isr = (sueldoAnual - 416220) * 0.15;
            }
            else if (sueldoAnual > 624329 && sueldoAnual <= 867123)
            {
                isr = (sueldoAnual - 624329) * 0.20 + 31216.5;
            }
            else
            {
                isr = (sueldoAnual - 867123) * 0.25 + 79776.5;
            }

            double isrMensual = isr / 12;

            Console.WriteLine( "--RESULTADOS--");
            Console.WriteLine($"Tu Sueldo es : {sueldo}");
            Console.WriteLine($"Tu Sueldo Anual es : {sueldoAnual}");
            

            if (isr == 0)
                Console.WriteLine("ISR a pagar: N/A");
              
            else
                Console.WriteLine($"ISR a pagar al año: RD$ {isr}");

        }
    }
}
