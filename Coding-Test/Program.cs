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
                Environment.Exit(-1);
            }
            else if (advanceAmount -amount < creditLimit * .25)
            {

                Console.WriteLine($"Amount: {advanceAmount-amount}");
                Console.WriteLine($"APR: {newApr}");

                Environment.Exit(-1);
            }
            
            else
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
            }
        }











        //int newAmount = advanceAmount - amount;
        //if(creditLimit*.25 > advanceAmount - amount)
        //{
        //    Console.WriteLine($"Amount: {newAmount}");
        //    Console.WriteLine($"APR: {newApr}");
        //}else
        //{
        //    Console.WriteLine($"Amount: {amount*.5}");
        //    Console.WriteLine($"APR: {newApr}");
        //}

        ////THIRD AMOUNT AND APR

        //if (amount + amount*.5 != advanceAmount)
        //{
        //    Console.WriteLine($"Amount: Not yet");
        //    Console.WriteLine($"APR: {newApr}");
        //}
        //else if (creditLimit * .25 > advanceAmount - amount)
        //{

        //}







        //int newAmount = (int)((advanceAmount - amount) * .5);
        //if (amount == advanceAmount)
        //{

        //}else if(advanceAmount - amount < newAmount)
        //{
        //    Console.WriteLine($"Amount: {newAmount}");
        //    Console.WriteLine($"APR: {newApr}");
        //}else
        //{
        //    Console.WriteLine($"Amount: {advanceAmount-amount}");
        //    Console.WriteLine($"APR: {newApr}");
        //}

        ////Console.WriteLine(advanceAmount - amount - newAmount);

        //newApr = (apr * .5) + apr;
        //if(advanceAmount -amount == advanceAmount || advanceAmount  == newAmount)
        //{

        //}
        //else if (amount + newAmount != advanceAmount)
        //{
        //    Console.WriteLine($"Amount: {advanceAmount - amount - newAmount}");
        //    Console.WriteLine($"APR: {newApr}");
        //}




        //if (advanceAmount < creditLimit*.50)
        //{

        //    Console.WriteLine($"Second Amount: ");
        //}
        //Amount = ((int)(CreditLimit * .5));






    }
}

