namespace JPI
{
   internal sealed class BasicBlankSpaceOld : BlankSpace, AnyText
   {
      internal BasicBlankSpaceOld(string text) =>
         Primitive = string.IsNullOrWhiteSpace(text.UnlessNull())
            ? text
            : throw new System.ArgumentException(
               $"Must be whitespace", nameof(text));

      public string Primitive { get; }
   }
}
