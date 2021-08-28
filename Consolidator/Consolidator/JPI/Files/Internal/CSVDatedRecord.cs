namespace JPI.Internal
{
   using System;
   using System.Globalization;

   internal class CSVDatedRecord
   {
      public CSVDatedRecord(CSVNamedRecord record)
      {
         var time = record.Column("time".ToCharacters())
            .Some(some => DateTime.Parse(some.Value.Primitive, new CultureInfo("en-US")))
            .None(() => throw new InvalidOperationException());

         Date = record.Column("date".ToCharacters())
            .Some(some => DateTime.Parse(some.Value.Primitive, new CultureInfo("en-US")).Date + time.TimeOfDay)
            .None(() => time);
      }

      public DateTime Date { get; }
   }
}
