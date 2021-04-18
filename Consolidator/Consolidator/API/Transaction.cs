namespace Consolidator
{
   using JPI;

   public sealed class Transaction
   {
      private readonly CSVLine line;

      internal Transaction(CSVLine line) => this.line = line;
   }
}
