using System;

namespace _04.BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int inputYear = int.Parse(Console.ReadLine());
            double moneyToPayEven = 0;
            double moneyToPayOdd = 0;
            int ivanchoYears = 18;

            for (int i = 1800; i <= inputYear ; i+= 2)
            {
                moneyToPayEven += 12000;
            }

            for (int i = 1801; i <= inputYear; i+= 2)
            {
                ivanchoYears = 18 + (i - 1800);
                moneyToPayOdd += 12000 + (50 * ivanchoYears);
            }

            double totalMoneyToPay = moneyToPayOdd + moneyToPayEven;
            if (totalMoneyToPay > inheritedMoney)
            {
                double insufficiency = totalMoneyToPay - inheritedMoney;
                Console.WriteLine("He will need {0:F2} dollars to survive.", insufficiency);
            }
            else if (totalMoneyToPay < inheritedMoney)
            {
                double leftMoney = inheritedMoney - totalMoneyToPay;
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", leftMoney);
            }
        }
    }
}
