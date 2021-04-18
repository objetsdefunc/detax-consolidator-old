namespace JPI
{
   public sealed class Text
   {
      internal Text(a<string> text) =>
         Primitive = string.IsNullOrWhiteSpace(text)
            ? throw new System.ArgumentException(
               $"'{nameof(text)}' cannot be null or whitespace", nameof(text))
            : text;

      public string Primitive { get; }
   }
}
