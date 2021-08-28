namespace JPI.Internal
{
   internal class CSVNamedField
   {
      private readonly Characters name;

      public CSVNamedField(Characters name, Characters value)
      {
         this.name = name;
         Value = value;
      }

      public Characters Value { get; }
   }
}
