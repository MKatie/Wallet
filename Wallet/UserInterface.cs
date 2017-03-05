using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
   public class UserInterface
   {
      private List<decimal> _costs = new List<decimal>();
      private List<decimal> _income = new List<decimal>();

      //private decimal _income;

      public List<decimal> ReadCosts()
      {
         return Read(_costs);
      }

      public List<decimal> ReadSaldo()
      {
         return Read(_income);
      }

      private List<decimal> Read(List<decimal> list)
      {
         int counter = int.Parse(Console.ReadLine());

         for (int i = 0; i < counter; i++)
         {
            decimal n = decimal.Parse(Console.ReadLine());
            list.Add(n);
         }
         return list;
      }

      public decimal WriteSumOfCosts()
      {
         decimal sum = WriteSum(_costs);
         sum *= (-1);
         Console.WriteLine(sum);
         return sum;
      }

      public decimal WriteSumOfIncome()
      {
         decimal sum = WriteSum(_income);
         Console.WriteLine(sum);
         return sum;
      }

      public decimal WriteSum(List<decimal> list)
      {
         decimal sum = CostOperations.Sum(list);
         return sum;
      }




      //public decimal ReadSaldo()
      //{
      //   _income = decimal.Parse(Console.ReadLine());
      //   return _income;
      //}

      //public void WriteSaldo()
      //{
      //   SaldoOperations saldo = new SaldoOperations();
      //   decimal x = saldo.UpdateSaldo(_income);
      //   Console.WriteLine($"Twoje obecne saldo wynosi: {x}" );
   }

}
