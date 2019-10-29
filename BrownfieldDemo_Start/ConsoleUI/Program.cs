using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    //NOTE= THE THINGS THAT ARE IN UPPERCASE ARE THINGS I WANTED TO TRY
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t, ttl;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            t = int.Parse(Console.ReadLine());
            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time:");
            String cont = (Console.ReadLine()); //Boolean not accepted. We could have done that if the string is "yes", boolean cont is "true" and if it's "no", is false. 
            if (cont == "yes")
            {
                do
                {
                    Console.Write("Enter what you did: ");
                    w = Console.ReadLine();
                    Console.Write("How long did you do it for: ");
                    t = int.Parse(Console.ReadLine());
                    ent.HoursWorked = t;
                    ent.WorkDone = w;
                    ents.Add(ent);
                    Console.Write("Do you want to enter more time:");
                    cont = (Console.ReadLine());
                } while (cont == "yes");
            }
                ttl = 0;
                for (i = 0; i < ents.Count; i++)
                {
                    if (ents[i].WorkDone.Contains("ACME"))
                    {
                        ttl ++; //We have to operate the ttl with itself, not with the variable "i"
                    }
                }
                Console.WriteLine("Simulating Sending email to Acme");
                Console.WriteLine("Your bill is $" + ttl * (125 * t) + " for the hours worked."); //The right amount for ACME was 125, not 150
                for (i = 0; i < ents.Count; i++) // MY GUESS WAS TO PUT TTL TO 0 SO IT DOESN'T OPERATE WITH THE "OLD" TTL VARIABLE FROM ACME
                {
                    if (ents[i].WorkDone.Contains("ABC"))
                    {
                        ttl++; //Same as before
                    }
                }
                Console.WriteLine("Simulating Sending email to ABC");
                Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");
                for (i = 0; i < ents.Count; i++)
                {
                    ttl += ents[i].HoursWorked;
                }
                if (ttl > 40)
                {
                    Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
                }
                else
                {
                    Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
                }
                Console.WriteLine();
                Console.Write("Press any key to exit application...");
                Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
