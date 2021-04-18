namespace Consolidator.Internal
{
   using System.Collections;
   using System.Collections.Generic;
   using System.Linq;
   using JPI;

   internal sealed class CSVTransactions : Transactions
   {
      private readonly List<Transaction> transactions;

      internal CSVTransactions(FilePath path) =>
         transactions = CSV.LinesFrom(path)
            .Select(line => new Transaction(line))
         .ToList();

      public int Count => transactions.Count;

      public IEnumerator<Transaction> GetEnumerator() => transactions.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => transactions.GetEnumerator();
   }
}
