namespace JPI.Linq
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public static class LinqExtensions
   {
      public static IEnumerable<TResult> Map<TSource, TResult>(
         this IEnumerable<TSource> self, Func<TSource, TResult> selector) =>
         self.Select(x => selector(x));

      public static IEnumerable<TResult> Flatten<TSource, TResult>(
         this IEnumerable<TSource> self, Func<TSource, IEnumerable<TResult>> selector) =>
               self.SelectMany(selector);
   }
}
