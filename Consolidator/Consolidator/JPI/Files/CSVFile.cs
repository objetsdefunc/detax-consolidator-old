namespace JPI
{
   using System.Collections.Generic;
   using JPI.Internal;

   public class CSVFile
   {
      internal CSVFile(FilePath filePath) => Lines = new BasicCSVLines(filePath);

      public IReadOnlyCollection<CSVNamedRecord> Lines { get; }
   }
}
