namespace JPI
{
   public static class NotNullExtensions
   {
      public static void ThrowIfNull<T>(this T self)
         where T : class => _ = self ?? throw new System.ArgumentNullException(nameof(self));

      public static a<T> UnlessNull<T>(this T self)
         where T : class => self;
   }
}
