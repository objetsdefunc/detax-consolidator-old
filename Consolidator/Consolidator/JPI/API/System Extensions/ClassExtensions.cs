﻿namespace JPI
{
   using System.Collections.Generic;

   public static class ClassExtensions
   {
      public static IReadOnlyList<T> InAList<T>(this T self)
         where T : class => new List<T>() { self };
   }
}
