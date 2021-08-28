namespace Consolidator.Internal
{
   using System.Collections;
   using System.Collections.Generic;
   using System.Linq;

   internal abstract class TransactionRecords : IReadOnlyCollection<TransactionRecord>
   {
      private readonly List<TransactionRecord> transactions;

      internal TransactionRecords(IEnumerable<TransactionRecord> transactions) =>
         this.transactions = transactions.ToList();

      public int Count => transactions.Count;

      public IEnumerator<TransactionRecord> GetEnumerator() => transactions.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => transactions.GetEnumerator();
   }
}
