namespace JPI
{
   using System;

   public static class StringExtensions
   {
      public static Text ToText(this string self) =>
         string.IsNullOrEmpty(self.UnlessNull())
            ? new BasicEmptyText(self)
            : string.IsNullOrWhiteSpace(self)
               ? new BasicWhiteSpace(self)
               : new BasicCharacters(self) as Text;

      public static Characters ToCharacters(this string self) =>
         new BasicCharacters(self);

      public static LineOfText ToCharactersOrEmpty(this string self) =>
         string.IsNullOrEmpty(self.UnlessNull())
            ? new BasicEmptyText(self)
            : string.IsNullOrWhiteSpace(self)
               ? throw new ArgumentException("Must not be only white space, unless empty.")
               : new BasicCharacters(self) as LineOfText;
   }
}
