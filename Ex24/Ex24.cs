using System;
using System.Diagnostics;

namespace T1Activitats
{
    public class Ex24
    {
        /// <summary>
        /// 24. Implementa un algorisme on l’usuari escrigui un valor que representarà el dia de la setmana
        /// (segons la seva posició) de l'1 al 7. El programa mostrarà el nom del dia corresponent:
        /// Dilluns, Dimarts, Dimecres, Dijous,.... 
        /// Cal desenvolupar totes les etapes del disseny d’un programa i controlar els possibles errors.
        /// </summary>
        public static void Main()
        {
            const string FormatExceptionMsg = "Format incorrecte, s'espera un numero. Error: {0}";
            const string OverFlowExceptionMsg = "Numero massa gran. Error: {0}";
            const string ExceptionMsg = "Error: {0}";
            const string IndexOutOfRangeExceptionMsg = "Numero fora del rang, s'espera interval del 1-7.";

            string[] daysOfTheWeek = { "Dilluns", "Dimarts", "Dimecres", "Dijous", "Divendres", "Dissabte", "Diumenge" };
            int numDay = 0;
            try
            {
                numDay = int.Parse(Console.ReadLine());
            }
            catch (FormatException e) { Console.WriteLine(FormatExceptionMsg,e.Message); }
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
                Console.WriteLine(daysOfTheWeek[numDay - 1]);
            }
            catch (IndexOutOfRangeException e) { Console.WriteLine(IndexOutOfRangeExceptionMsg); }
        }
    }
}
