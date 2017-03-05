using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
   public class Program
   {
      static void Main(string[] args)
      {
     
         UserInterface ui = new UserInterface();
         SaldoOperations saldo = new SaldoOperations();
         bool exit = false;

         while (!exit)
         {
            Console.WriteLine("Jesli chcesz dodac kwote wybierz 1, jesli dodac wydatki wybierz 2, aby wyjsc wybierz 666");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
               case 1:
                  {
                     Console.WriteLine("Podaj ilosc oraz kwoty: ");
                     ui.ReadSaldo();
                     var sum = ui.WriteSumOfIncome();
                     saldo.UpdateSaldo(sum);
                     break;
                  }
               case 2:
                  {
                     Console.WriteLine("Podaj ilosc oraz kwoty: ");
                     ui.ReadCosts();
                     var sum = ui.WriteSumOfCosts();
                     saldo.UpdateSaldo(sum);
                     break;
                  }
               case 666:
                  {
                     exit = true;
                     break;
                  }

               default:
                  {
                     Console.WriteLine("Errrrrrorrrrr! Idz do domu. Ale buba. ");
                     break;
                  }
            }
         }
      }


   }
}
