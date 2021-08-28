namespace JPI.Internal
{
   using System.Collections;
   using System.Collections.Generic;
   using System.Linq;
   using JPI;
   using JPI.Linq;

   internal sealed class BasicCSVLines : IReadOnlyCollection<CSVNamedRecord>
   {
      private readonly List<CSVNamedRecord> records;

      internal BasicCSVLines(FilePath path)
      {
         var lines = new List<SingleTextLine>();

         path.OpenedForReading().UseAndDispose(
            reader =>
            {
               while (!reader.EndOfStream)
               {
                  // TODO: What if this throws?
                  lines.Add(reader.ReadLine().ToTextLine());
               }
            });

         var header = lines[0];

         records = lines.Skip(1).Map(line => new CSVNamedRecord(new CSVHeader(header), new CSVRecord(line))).ToList();
      }

      public int Count => records.Count;

      public IEnumerator<CSVNamedRecord> GetEnumerator() => records.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => records.GetEnumerator();
   }
}
