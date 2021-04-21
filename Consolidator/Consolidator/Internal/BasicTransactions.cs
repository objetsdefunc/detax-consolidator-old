namespace Consolidator.Internal
{
   using System.Collections;
   using System.Collections.Generic;
   using System.Linq;

   internal abstract class BasicTransactions : Transactions
   {
      private readonly List<Transaction> transactions;

      internal BasicTransactions(IEnumerable<Transaction> transactions) =>
         this.transactions = transactions.ToList();

      public int Count => transactions.Count;

      public IEnumerator<Transaction> GetEnumerator() => transactions.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => transactions.GetEnumerator();
   }
}
