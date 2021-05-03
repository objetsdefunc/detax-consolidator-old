namespace JPI
{
   using JPI.Internal;

   public class CSVFile
   {
      internal CSVFile(FilePath filePath) => Lines = new BasicCSVLines(filePath);

      public CSVLines Lines { get; }
   }
}
