namespace Consolidator
{
   using System.Collections.Generic;
   using System.Linq;
   using JPI;
   using JPI.Linq;

   public static class Portfolio
   {
      public static IReadOnlyCollection<Transaction> UniqueTransactionsFrom(
         IEnumerable<TransactionRecordsFile> files) =>
            files
               .Flatten(f => f)
               .Distinct()
               .Map(record => new Transaction(record)).ToList();

      public static IReadOnlyCollection<TransactionRecordsFile> TransactionFilesFrom(CSVFiles files) =>
         files
            .Map(file => new BasicTransactionFile(file))
            .ToList();
   }
}
