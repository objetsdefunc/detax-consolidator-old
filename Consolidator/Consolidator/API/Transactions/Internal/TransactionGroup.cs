namespace Consolidator.Internal
{
   using System.Collections.Generic;
   using JPI;
   using JPI.Linq;

   internal class TransactionGroup : BasicTransactionGroup, Transactions, IReadOnlyCollection<Transaction>
   {
      internal TransactionGroup(CSVFile file)
         : base(file.Lines.Map(line => new Transaction(line)))
      {
      }
   }
}
