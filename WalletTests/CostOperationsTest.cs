using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet;

namespace WalletTests
{
   [TestClass]
   public class CostOperationsTest
   {
      [TestMethod]
      public void SumTest()
      {
         List<decimal> costs = new List<decimal> {2, 4.5m, 1 };
         decimal expected = 7.5m;

         decimal actual = CostOperations.Sum(costs);

         Assert.AreEqual(expected, actual);
      }


   }
}
