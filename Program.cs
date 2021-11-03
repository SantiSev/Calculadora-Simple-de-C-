using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR_EPICO
{
    class Program
    {
        static void Main(string[] args)
        {
          
            #region CALCULADORA EPICA
            Boolean continuar = true;
            while (continuar)
            {

                Console.WriteLine("Bienvenido a la calculadora Epica \r\n" +
                "presione 1 para SUMAR\n" +
                "presione 2 para RESTAR\n" +
                "presione 3 para MULTIPLICAR\n" +
                "presione 4 para DIVIDIR\n" +
                "presione 0 para FINALIZAR\n");

                int INPUT = int.Parse(Console.ReadLine());

                int TERMINAR = 0;
                int VALOR_0_1 = 0;

                double EJERCICIO = 0;
                double VARIABLE1 = 0;
                double VARIABLE2 = 0;
                

                if (INPUT == 0
                    ) { continuar = false; }



                switch (INPUT)
                {
                    case 1:
                        Console.WriteLine("VAMOS A SUMAR!");

                        EJERCICIO = SUMAR(out VARIABLE1, out VARIABLE2);
                        Console.WriteLine(VARIABLE1 + " + " + VARIABLE2 + " = " + EJERCICIO);

                        VALOR_0_1 = PREGUNTA(TERMINAR);
                        if (VALOR_0_1 == 0) { continuar = false; }

                        break;

                    case 2:
                        Console.WriteLine("VAMOS A RESTAR!");

                        EJERCICIO = RESTAR(out VARIABLE1, out VARIABLE2);

                        Console.WriteLine(VARIABLE1 + " - " + VARIABLE2 + " = " + EJERCICIO);


                        VALOR_0_1 = PREGUNTA(TERMINAR);
                        if (VALOR_0_1 == 0) { continuar = false; }

                        break;


                    case 3:
                        Console.WriteLine("VAMOS A MULTIPLICAR!");

                        EJERCICIO = MULTIPLICAR(out VARIABLE1, out VARIABLE2);

                        Console.WriteLine(VARIABLE1 + " x " + VARIABLE2 + " = " + EJERCICIO);

                        VALOR_0_1 = PREGUNTA(TERMINAR);
                        if (VALOR_0_1 == 0) { continuar = false; }

                        break;



                    case 4:
                        Console.WriteLine("VAMOS A DIVIDAR!");

                        
                        EJERCICIO = DIVIDIR(out VARIABLE1, out VARIABLE2);
                       

                        Console.WriteLine(VARIABLE1 + " /  " + VARIABLE2 + " = " + EJERCICIO);


                        VALOR_0_1 = PREGUNTA(TERMINAR);
                        if (VALOR_0_1 == 0) { continuar = false; }


                        break;

                }
            }
            #endregion
            
            Console.ReadKey();
        }

        static int PREGUNTA(int valor)
        {
            Console.WriteLine("desea salir? presione 0 sino presione cualquier numero");
            valor = int.Parse(Console.ReadLine());
            if (valor == 0)
            {
                return 0;
            }
            else { return 1; }


        } ///funcion para continuar o frenar cuentas

        static double SUMAR(out double valor1, out double valor2)
        {
            Console.WriteLine("INGRESE EL PRIMER NUMERO");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
            valor2 = double.Parse(Console.ReadLine());

            double SUMA = valor1 + valor2;
            return SUMA;
        }

        static double RESTAR(out double valor1, out double valor2)
        {
            Console.WriteLine("INGRESE EL PRIMER NUMERO");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
            valor2 = double.Parse(Console.ReadLine());

            double RESTA = valor1 - valor2;
            return RESTA;
        }

        static double MULTIPLICAR(out double valor1, out double valor2)
        {
            Console.WriteLine("INGRESE EL PRIMER NUMERO");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
            valor2 = double.Parse(Console.ReadLine());

            double MULTIPLO = valor1 * valor2;
            return MULTIPLO;
        }

        static double DIVIDIR(out double valor1, out double valor2)
        {

            Console.WriteLine("INGRESE EL PRIMER NUMERO");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
            valor2 = double.Parse(Console.ReadLine());

            if (valor2 == 0)
            {
                Console.WriteLine("ERROR, LA CUENTA: " + valor1 + "/0" + " da INFINITO");
                return 0;
            }
            else
            {
                double DIVISION = valor1 / valor2;
                return DIVISION;
            }




        }

        static double GUARDO_INFO(out double valor) 
        {
            valor = 0;

            return valor;
        }
    }
}
