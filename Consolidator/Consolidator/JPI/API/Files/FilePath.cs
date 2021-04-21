namespace JPI
{
   using System.IO;

   public sealed class FilePath
   {
      private readonly Characters path;

      internal FilePath(Characters path) =>
         this.path = new FileInfo(path.Primitive).Length == 0
            ? throw new InvalidDataException("The file is empty.")
            : path;

      public Disposing<StreamReader> OpenedForReading() =>
         Auto.Disposing(
            () => new StreamReader(File.OpenRead(path.Primitive)));

      public static FilePath ThatExists(a<Characters> path) => new FilePath(path.NotNull);
   }
}
