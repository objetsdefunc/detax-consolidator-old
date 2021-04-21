namespace JPI
{
   using System.Collections.Generic;

   public static class Files
   {
      public static IEnumerable<FilePath> In(a<FolderPath> path) =>
         path.NotNull.Files();
   }
}
