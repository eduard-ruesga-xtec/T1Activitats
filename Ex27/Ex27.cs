using System;
using System.Diagnostics;

namespace T1Activitats
{
    public class Ex27
    {
        /// <summary>
        /// 27. Implementa un programa que demani 20 nombres enters per teclat i retorni els valors separats
        /// en dues files: parell i senars.
        /// </summary>
        public static void Main()
        {
            const string FormatExceptionMsg = "Format incorrecte, s'espera un numero. Error: {0}";
            const string OverFlowExceptionMsg = "Numero massa gran. Error: {0}";
            const string ExceptionMsg = "Error: {0}";
            const string IndexOutOfRangeExceptionMsg = "Numero fora del rang, s'espera interval del 0-10.";

            int userNum = 0;
            try
            {
                userNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException e) { Console.WriteLine(FormatExceptionMsg, e.Message); }
            catch (OverflowException e) { Console.WriteLine(OverFlowExceptionMsg, e.Message); }
            catch (Exception e) { Console.WriteLine(ExceptionMsg, e.Message); }

            //Una forma de controlar l'error, fent un llançament d'un error a mida.
            /* if (numDay > 0 && numDay <= daysOfTheWeek.Length)
             {
                 Console.WriteLine(daysOfTheWeek[numDay - 1]);
             }
             else
             {
                 throw new Exception("Numero fora de rang");
             }*/

            //Segona forma de controlar l'acces a l'array:
            try
            {
                Console.WriteLine(daysOfTheWeek[userNum - 1]);
            }
            catch (IndexOutOfRangeException e) { Console.WriteLine(IndexOutOfRangeExceptionMsg); }
        }
    }
}
