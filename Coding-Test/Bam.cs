using System;
namespace Coding_Test
{
     class Bam
    {
        public static int CreditLimit { get; set; }
        public static int AdvanceAmount { get; set; }
        public static int Amount { get; set; }
        public static int APR { get; set; }

        public Bam(int creditLimit, int advanceAmount, int amount, int apr)
        {
            CreditLimit = creditLimit;
            AdvanceAmount = advanceAmount;
            Amount = amount;
            APR = apr;
        }

        //FIRST AMOUNT CALCULATION
         public decimal EquationForOutput()
        {
            Amount = ((int)(CreditLimit * .5));
            if (AdvanceAmount <= CreditLimit * .5)
            {
                Amount = AdvanceAmount;
               return Amount;
            }
            return Amount;
        }
    }
}
