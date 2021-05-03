namespace Consolidator.Internal
{
   using System.Collections.Generic;
   using JPI.Linq;

   internal class TransactionGroups :
      BasicTransactionGroup,
      Transactions,
      IReadOnlyCollection<Transaction>
   {
      internal TransactionGroups(IEnumerable<TransactionGroup> groups)
         : base(groups.Flatten(s => s))
      {
      }
   }
}
