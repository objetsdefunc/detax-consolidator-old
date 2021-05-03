namespace JPI
{
   internal sealed class BasicEmptyText : EmptyText, Text
   {
      internal BasicEmptyText(string text) =>
         Primitive = string.IsNullOrEmpty(text.UnlessNull())
            ? text
            : throw new System.ArgumentException(
               $"Must be empty", nameof(text));

      public string Primitive { get; }
   }
}
