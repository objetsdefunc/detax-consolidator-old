namespace JPI
{
   internal sealed class BasicCharacters : Characters, AnyText
   {
      internal BasicCharacters(string text) =>
         Primitive = string.IsNullOrWhiteSpace(text.UnlessNull()) || string.IsNullOrEmpty(text)
            ? throw new System.ArgumentException(
               $"Cannot be white space or empty", nameof(text))
            : text;

      public string Primitive { get; }

      public bool Matches(Characters name) => Primitive.ToUpperInvariant() == name.Primitive.ToUpperInvariant();
   }
}
