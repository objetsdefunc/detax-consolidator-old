namespace JPI.Internal
{
   using LanguageExt;

   public class CSVNamedRecord
   {
      private readonly CSVHeader header;
      private readonly CSVRecord record;

      public CSVNamedRecord(CSVHeader header, CSVRecord record)
      {
         this.header = header;
         this.record = record;
      }

      internal Option<CSVNamedField> Column(Characters name) =>
         header
            .IndexOf(name)
            .Map(index => new CSVNamedField(header.Columns[index], record.Fields[index]));
   }
}
