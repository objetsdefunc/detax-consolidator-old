namespace JPI
{
   using System;
   using JPI.Internal;

   public static class Auto
   {
      public static Disposing<T> Disposing<T>(Func<T> createT)
         where T : IDisposable => new AutoDisposing<T>(createT.UnlessNull());
   }
}
