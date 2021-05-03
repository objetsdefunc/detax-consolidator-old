namespace JPI
{
   using System;

   public interface Disposing<out T>
      where T : IDisposable
   {
      void UseAndDispose(Action<T> use);
   }
}
