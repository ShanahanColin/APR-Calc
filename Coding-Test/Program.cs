using System;

namespace Coding_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 0;
            int apr = 249;
            Console.WriteLine("Enter Credit Limit");
            int creditLimit = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Advance Amount");
            int advanceAmount = (int)Convert.ToInt64(Console.ReadLine());

            Bam nums = new Bam(creditLimit, advanceAmount, amount, apr);
            amount = (int)nums.EquationForOutput();

            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"APR: {apr}");

            //SECOND AMOUNT AND APR
            var newApr = (apr * .25) + apr;
            if (advanceAmount <= creditLimit * .5)
            {
                Restart();
            }
            else if (advanceAmount -amount < creditLimit * .25)
            {
                Console.WriteLine($"Amount: {advanceAmount-amount}");
                Console.WriteLine($"APR: {newApr}");

                Restart();
            }else
            {
                Console.WriteLine($"Amount: {amount * .5}");
                Console.WriteLine($"APR: {newApr}");
            }

            //THIRD AMOUNT AND APR
            int newAmount = (int)(advanceAmount - (creditLimit * .25) + amount) - creditLimit;
            
            bool endTrue = Convert.ToBoolean(newAmount);

            if (endTrue)
            {
                newApr = (apr * .5) + apr;
                Console.WriteLine($"Amount: {(advanceAmount - amount) - amount * .5}");
                Console.WriteLine($"APR: {newApr}");

                Restart();
            }

            //Restart App
            void Restart()
            {
                Console.WriteLine("Restart? (yes or no)");
                string res = Console.ReadLine();
                string resLower = res.ToLower();
                if (resLower == "yes")
                {
                    Main(args);
                }
                else
                {
                    Environment.Exit(-1);
                }
            }
        }
    }
}

