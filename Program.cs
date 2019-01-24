using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book movie tickets...!!!");
            var movie = "";//string
            var tickets = 0;//int
            var pay = 0.0;//double
            var tpay = 0.0;
            var rating = 0.0m;//decimal
            var popcorn = 'n';//char
            var popcorn_amt = 50;
            var alert = "";
            var alert_need = false;//bool
            while (movie == "")
            {
                Console.WriteLine("Enter movie name:");
                movie = Console.ReadLine();
            }
                Console.WriteLine("Number of tickets:");
                tickets = Convert.ToInt32(Console.ReadLine());
            
            if (tickets > 0)
            {
                switch (tickets)
                {
                    case 1:
                        Console.WriteLine("Pay 10 for 1 ticket.");
                        break;
                    case 2:
                        Console.WriteLine("Pay 20 for 2 tickets.");
                        break;
                    case 3:
                        Console.WriteLine("Pay 30 for 3 tickets.");
                        break;
                    case 4:
                        Console.WriteLine("Pay 40 for 4 tickets.");
                        break;
                    case 5:
                        Console.WriteLine("Pay 50 for 5 tickets.");
                        break;
                    default:
                        Console.WriteLine("\nNumber of tickets should be less than or equal to 5...!!!");
                        break;
                }
            }
            if (tickets == 1)
            {
                pay = 10;
            }
            else if (tickets == 2)
            {
                pay = 20;
            }
            else if (tickets == 3)
            {
                pay = 30;
            }
            else if (tickets == 4)
            {
                pay = 40;
            }
            else if (tickets == 5)
                    {
                pay = 50;
            }
                Console.WriteLine("Movie interest rating :");
                rating = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Would you like to have popcorn? y/n");
                popcorn = Convert.ToChar(Console.ReadLine());
            if (popcorn == 'y')
            {
                tpay = pay + (0.1 * pay)+ popcorn_amt;
                
                Console.WriteLine($"Total pay including tax and popcorn:{tpay}");
            }
            else
            {
                tpay = pay + (0.1 * pay);
                Console.WriteLine($"Total pay including tax:{tpay}");
            }
                Console.WriteLine("Do you need mobile alerts? yes/no");
                alert = Console.ReadLine();
            if (alert == "yes")
            {
                alert_need = true;
            }
                Console.WriteLine("Okay. Thank you...!!!");
        }
        
    }
}