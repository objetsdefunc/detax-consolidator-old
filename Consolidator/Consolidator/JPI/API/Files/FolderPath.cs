namespace JPI
{
   using System.Collections.Generic;
   using System.IO;
   using JPI.Linq;

   public sealed class FolderPath
   {
      private readonly Characters path;

      internal FolderPath(Characters path) =>
         this.path = Directory.Exists(path.Primitive)
            ? path
            : throw new DirectoryNotFoundException(path.Primitive);

      public IEnumerable<FilePath> Files() =>
         Directory.GetFiles(
            path.Primitive,
            "*.*",
            SearchOption.TopDirectoryOnly)
               .Map(path => FilePath.ThatExists(path.ToCharacters().UnlessNull()));

      public static FolderPath ThatExists(a<Characters> path) => new FolderPath(path.NotNull);
   }
}
