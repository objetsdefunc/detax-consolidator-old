namespace JPI
{
   public sealed class CSVLine
   {
      private readonly string line;

      internal CSVLine(LineOfText line) => this.line = line.Primitive;

      // Temp
      internal Text Text() => (line.Split(',')[5] + " " + line.Split(',')[6]).ToText();
   }
}
