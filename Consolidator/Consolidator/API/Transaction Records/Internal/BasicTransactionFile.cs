namespace Consolidator
{
   using System.Collections.Generic;
   using Consolidator.Internal;
   using JPI;
   using JPI.Internal;
   using JPI.Linq;

   internal class BasicTransactionFile :
      TransactionRecords,
      TransactionRecordsFile,
      IReadOnlyCollection<TransactionRecord>
   {
      internal BasicTransactionFile(CSVFile file)
         : base(file.Lines.Map(line => new TransactionRecord(new CSVDatedRecord(line))))
      {
      }
   }
}
