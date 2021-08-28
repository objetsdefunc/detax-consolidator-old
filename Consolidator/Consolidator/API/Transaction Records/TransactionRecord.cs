namespace Consolidator
{
   using System;
   using JPI.Internal;

   public sealed class TransactionRecord : IEquatable<TransactionRecord>
   {
      private readonly CSVDatedRecord line;

      internal TransactionRecord(CSVDatedRecord line)
      {
         this.line = line;

         Date = line.Date;
      }

      public DateTime Date { get; }

      public bool Equals(TransactionRecord other) => throw new NotImplementedException();
   }
}
