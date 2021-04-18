namespace JPI
{

   /// <summary>
   /// A type-safe way to "ensure" that a reference type is not null.
   /// All public interfaces should accept types in this way.
   /// Or... just under the interface?
   /// </summary>
   /// <typeparam name="T">Any reference type.</typeparam>
   public struct a<T>
      where T : class
   {
      internal a(T self)
      {
         self.ThrowIfNull();
         NotNull = self;
      }

      public T NotNull { get; }

      public static implicit operator a<T>(T self) => new a<T>(self);

      public static implicit operator T(a<T> self) => self.NotNull;
   }
}
