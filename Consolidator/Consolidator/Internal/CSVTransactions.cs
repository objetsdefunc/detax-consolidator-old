namespace Consolidator.Internal
{
   using JPI;
   using JPI.Linq;

   internal sealed class CSVTransactions : BasicTransactions, Transactions
   {
      internal CSVTransactions(FilePath path)
         : base(CSV.LinesFrom(path).Map(line => new Transaction(line)))
      {
      }
   }
}
