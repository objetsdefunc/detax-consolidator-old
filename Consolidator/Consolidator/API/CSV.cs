namespace Consolidator
{
   using Consolidator.Internal;
   using JPI;

   public static class CSV
   {
      public static Transactions TransactionsFrom(a<FilePath> path) =>
         new CSVTransactions(path);
   }
}
