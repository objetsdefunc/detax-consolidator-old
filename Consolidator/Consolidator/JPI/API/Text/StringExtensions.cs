namespace JPI
{
   public static class StringExtensions
   {
      public static Text ToText(this string self) =>
         new Text(self);
   }
}
