namespace JPI
{
   internal sealed class BasicWhiteSpace : WhiteSpace, Text
   {
      internal BasicWhiteSpace(string text) =>
         Primitive = string.IsNullOrWhiteSpace(text.UnlessNull())
            ? text
            : throw new System.ArgumentException(
               $"Must be whitespace", nameof(text));

      public string Primitive { get; }
   }
}
