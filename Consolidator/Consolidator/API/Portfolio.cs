namespace Consolidator
{
   using Consolidator.Internal;
   using JPI;
   using JPI.Linq;

   public static class Portfolio
   {
      public static Transactions TransactionsFrom(CSVFiles files) =>
         new TransactionGroups(files.Map(file => new TransactionGroup(file)));
   }
}
