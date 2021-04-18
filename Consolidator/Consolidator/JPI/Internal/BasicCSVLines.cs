namespace JPI.Internal
{
   using System.Collections;
   using System.Collections.Generic;
   using System.Linq;
   using JPI;

   internal sealed class BasicCSVLines : CSVLines, IReadOnlyCollection<CSVLine>
   {
      private readonly List<CSVLine> lines;

      internal BasicCSVLines(FilePath path)
      {
         lines = new List<CSVLine>();

         path.OpenedForReading().UseAndDispose(
            reader =>
            {
               while (!reader.EndOfStream)
               {
                  lines.Add(new CSVLine(reader.ReadLine().ToText()));
               }
            });

         lines = lines.Skip(1).ToList();
      }

      public int Count => lines.Count;

      public IEnumerator<CSVLine> GetEnumerator() => lines.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => lines.GetEnumerator();
   }
}
