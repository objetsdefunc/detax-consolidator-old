namespace JPI
{
   using System.IO;

   public sealed class FilePath
   {
      private readonly FileInfo info;

      internal FilePath(FileInfo info) => this.info = info;

      public string Extension => info.Extension;

      public Disposing<StreamReader> OpenedForReading() =>
         Auto.Disposing(
            () => new StreamReader(File.OpenRead(info.FullName)));

      public static FilePath ThatExists(a<Characters> path)
      {
         var info = new FileInfo(path.NotNull.Primitive);

         return info.Length == 0
            ? throw new InvalidDataException("The file is empty.")
            : new FilePath(info);
      }
   }
}
