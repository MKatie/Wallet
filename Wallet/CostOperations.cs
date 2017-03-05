using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
   public class CostOperations
   {
      public static decimal Sum(List<decimal> costs)
      {
         decimal sum = 0;
         foreach (var item in costs)
         {
            sum += item;
         }
         return sum;
      }

   }
}
