namespace JPI.Internal
{
   using System;

   internal sealed class AutoDisposing<T> : Disposing<T>
      where T : IDisposable
   {
      private readonly Func<T> createDisposable;

      internal AutoDisposing(Func<T> createDisposable) =>
         this.createDisposable = createDisposable;

      public void UseAndDispose(Action<T> use)
      {
         use.ThrowIfNull();

         using (var disposable = createDisposable())
         {
            use(disposable);
         }
      }
   }
}
