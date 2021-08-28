namespace JPI
{
   using System;

   internal sealed class BasicEmptyLine : SingleTextLine, EmptyLine, AnyText
   {
      internal BasicEmptyLine(string text) =>
         Primitive = string.IsNullOrEmpty(text.UnlessNull()) && text.EndsWith(Environment.NewLine)
            ? text
            : throw new ArgumentException(
               $"Must be an empty line", nameof(text));

      public string Primitive { get; }

      public bool Matches(Characters name) => throw new NotImplementedException();
   }
}
