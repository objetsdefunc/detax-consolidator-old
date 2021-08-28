namespace JPI
{
   using System;

   public static class StringExtensions
   {
      public static AnyText ToText(this string self) =>
         self.UnlessNull().NotNull.EndsWith(Environment.NewLine)
            ? self.ToTextLine() as AnyText
            : string.IsNullOrWhiteSpace(self)
               ? throw new ArgumentException(
                  $"Must not be blank space.", nameof(self))
               : new BasicCharacters(self);

      public static Characters ToCharacters(this string self) =>
         new BasicCharacters(self);

      public static Characters ToCharactersOrEmpty(this string self) =>
         new BasicCharacters(self);

      public static SingleTextLine ToTextLine(this string self)
      {
         var text = self.UnlessNull().NotNull;

         if (!self.EndsWith(Environment.NewLine))
         {
            text += Environment.NewLine;
         }

         return string.IsNullOrEmpty(text)
            ? new BasicEmptyLine(text) as SingleTextLine
            : string.IsNullOrWhiteSpace(text)
               ? throw new ArgumentException(
                  $"Must not be blank space.", nameof(self))
               : new BasicSingleLine(text);
      }
   }
}
