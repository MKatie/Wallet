using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
   public class SaldoOperations
   {
      private decimal _saldo = 0;

      public decimal UpdateSaldo(decimal sum)
      {
         _saldo += sum;

         Console.WriteLine($"Obecne saldo wynosi: {_saldo}");

         return _saldo;
      }
   }
}
