using System.Diagnostics;

namespace Numberguesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen in meinem Numberguesser, viel Spass!");

            {
                Console.WriteLine("Anleitung: nach jeder Eingabe Enter drücken um Programm fortzusetzten");
            }

            Stopwatch timer = new Stopwatch();
            Console.WriteLine("Die Stoppuhr wird gestartet sobald Enter gedrückt wird");
            Console.ReadKey();
            timer.Start();


            Random rand = new Random();
            int guess = 0;
            string welcome = "Errate die Zahl von 1 bis 100, und schreiben sie die Zahl unten ein.";
            Console.WriteLine(welcome);
            Console.WriteLine("geben sie hier den Zahlenbereich ein in dem sie spielen möchten");
            int  num = Convert.ToInt32(Console.ReadLine());
            
            Random myObject = new Random();
            myObject.Next(1, num);
            int i = 0;
            



            Console.WriteLine("Sie spielen im Bereich 1 -" + num);
            Console.WriteLine("Geben sie bitte ihre Schätzung ein.");

            while (guess != myObject)
            {

                
                try
                {

                    

                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > myObject)
                    {
                        Console.WriteLine("Deine Zahl ist zu hoch, versuche es mit einer tiefernen Zahl.");
                    }

                    if (guess < myObject)
                    {
                        Console.WriteLine("Deine Zahl war zu tief, versuche es mit einer höheren zahl.");
                    }

                    if (guess == myObject)
                    {
                        Console.WriteLine("Glückwunsch du hast die Zahl erraten, jetzt kannst du dir den Rest des Tages freinehmen.");

                    }
                }

                catch
                {

                    i--;
                }


                i++;
            }

            timer.Stop();
            long TotalMiliseconds = timer.ElapsedMilliseconds;
            float seconds = ((float)TotalMiliseconds / 1000);
            Console.WriteLine("Deine Zeit:" + seconds);
            Console.ReadKey();

            Console.WriteLine("Deine Versuche; " + i);
               
            Console.WriteLine(myObject + ", war die random Zahl");
           
            Console.ReadLine();

            
               
           

           
            

        }
    }
}