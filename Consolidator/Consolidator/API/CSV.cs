namespace Consolidator
{
   using System.Collections.Generic;
   using Consolidator.Internal;
   using JPI;
   using JPI.Linq;

   public static class CSV
   {
      public static Transactions TransactionsFrom(FilePath path) =>
         new CSVTransactions(path);

      public static Transactions TransactionsFrom(IEnumerable<FilePath> paths) =>
         new ManyTransactions(
            paths.Map(path => new CSVTransactions(path)));
   }
}
