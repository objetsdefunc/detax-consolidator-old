namespace JPI
{
   using System;

   internal sealed class BasicSingleLine : SingleTextLine, Characters, AnyText
   {
      internal BasicSingleLine(string text) =>
         Primitive = string.IsNullOrWhiteSpace(text.UnlessNull()) || !text.EndsWith(Environment.NewLine)
            ? throw new ArgumentException(
               $"Must be a line that's not empty.", nameof(text))
            : text;

      public string Primitive { get; }

      public bool Matches(Characters name) => throw new NotImplementedException();
   }
}
