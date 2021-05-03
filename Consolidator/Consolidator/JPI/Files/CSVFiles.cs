namespace JPI
{
   using System.Collections;
   using System.Collections.Generic;
   using System.IO;
   using System.Linq;
   using JPI.Linq;

   public class CSVFiles : IReadOnlyCollection<CSVFile>
   {
      private readonly IReadOnlyList<CSVFile> files;

      public CSVFiles(a<FolderPath> path) =>
         files = Directory.GetFiles(
            path.NotNull.Primitive,
            "*.csv",
            SearchOption.TopDirectoryOnly)
               .Map(file => new CSVFile(FilePath.ThatExists(file.ToCharacters().UnlessNull())))
               .ToList();

      public CSVFiles(CSVFile file) => files = file.InAList();

      public int Count => files.Count;

      public IEnumerator<CSVFile> GetEnumerator() => files.GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => files.GetEnumerator();
   }
}
