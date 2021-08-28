namespace JPI
{
   using System.Collections.Generic;
   using System.Linq;
   using JPI.Linq;

   public sealed class CSVRecord
   {
      internal CSVRecord(SingleTextLine line) =>
         Fields = line.Primitive
            .Split(',')
            .Map(field => field.ToCharacters()) need better files?
            .ToList();

      public IReadOnlyList<Characters> Fields { get; }
   }
}
