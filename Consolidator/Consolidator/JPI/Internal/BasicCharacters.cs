namespace JPI
{
   internal sealed class BasicCharacters : Characters, LineOfText, Text
   {
      internal BasicCharacters(string text) =>
         Primitive = string.IsNullOrWhiteSpace(text.UnlessNull())
            ? throw new System.ArgumentException(
               $"Cannot be white space", nameof(text))
            : text;

      public string Primitive { get; }
   }
}
