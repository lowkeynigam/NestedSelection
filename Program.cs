using System;

namespace SelectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string username1 = "HalcyonicFlame";
            string password1 = "leaguepassword";

                 Console.WriteLine("Please enter your Username and Password: ");
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();

                     if (input1 == username1 && input2 == password1) 
                     {
                         Console.WriteLine("Login successful!");
                     }
                     else 
                     {
                        Console.WriteLine("Login unsuccessful.");
                     }
                        
                    
                 



                
            
        }
    }
}
