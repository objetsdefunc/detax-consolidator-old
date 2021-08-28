namespace Consolidator
{
   public sealed class Transaction
   {
      private readonly TransactionRecord line;

      internal Transaction(TransactionRecord line) => this.line = line;
   }
}
