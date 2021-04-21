namespace Consolidator.Internal
{
   using System.Collections.Generic;
   using JPI.Linq;

   internal sealed class ManyTransactions : BasicTransactions, Transactions
   {
      internal ManyTransactions(IEnumerable<Transactions> many)
         : base(many.Flatten(x => x))
      {
      }
   }
}
