namespace JPI
{
   using System.Collections.Generic;
   using System.Linq;
   using JPI.Linq;
   using LanguageExt;

   public sealed class CSVHeader
   {
      internal CSVHeader(SingleTextLine line) =>
         Columns = line.Primitive
            .Split(',')
            .Map(column => column.ToCharacters())
            .ToList();

      public IReadOnlyList<Characters> Columns { get; }

      internal Option<int> IndexOf(Characters name)
      {
         var matches = Columns
            .Select((column, index) => (column, index))
            .Where(pair => pair.column.Matches(name));

         return matches.Any()
            ? matches.Single().index
            : Option<int>.None;
      }
   }
}
