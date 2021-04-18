namespace JPI
{
   using JPI.Internal;

   public static class CSV
   {
      public static CSVLines LinesFrom(a<FilePath> path) =>
         new BasicCSVLines(path);
   }
}
