using System;
using System.Diagnostics;

namespace T1Activitats
{
    public class Ex25
    {
        /// <summary>
        /// 25. Implementa un algorisme on l’usuari escrigui un valor que representarà una nota (en format decimal). 
        /// El programa haurà de retornar el valor qualitatiu corresponent:
        /// "Excel·lent", "Notable", "Bé", "Suficient", "Suspès", "Nota invàlida". 
        /// Cal desenvolupar totes les etapes del disseny d’un programa i controlar els possibles errors.
        /// </summary>
        public static void Main()
        {
            const string FormatExceptionMsg = "Format incorrecte, s'espera un numero. Error: {0}";
            const string OverFlowExceptionMsg = "Numero massa gran. Error: {0}";
            const string ExceptionMsg = "Error: {0}";
            const string IndexOutOfRangeExceptionMsg = "Numero fora del rang, s'espera interval del 0-10.";

            string[] marksCollection = { "Excel·lent", "Notable", "Be", "Suficient", "Suspes", "Nota invalida" };
            float mark = 0f;
            string markResult = "";
            try
            {
                mark = float.Parse(Console.ReadLine())//Intento provocar un error;
            }
            catch (FormatException e) { Console.WriteLine(FormatExceptionMsg, e.Message); }
            catch (OverflowException e) { Console.WriteLine(OverFlowExceptionMsg, e.Message); }
            catch (Exception e) { Console.WriteLine(ExceptionMsg, e.Message); }

            if (mark >= 9f && mark <= 10f) { markResult = marksCollection[0]; }
            else if (mark >= 7f && mark < 9f) { markResult = marksCollection[1]; }
            else if (mark >= 6f && mark < 7f) { markResult = marksCollection[2]; }
            else if (mark >= 5f && mark < 6f) { markResult = marksCollection[3]; }
            else if (mark >= 0f && mark < 5f) { markResult = marksCollection[4]; }
            else { markResult = marksCollection[5]; }

            Console.WriteLine(markResult);

        }
    }
}
