using System.Collections.Generic;
using System.Linq;

namespace Gongchengshi.Collections
{
   public static class Extensions
   {
      public static IEnumerable<ulong> FindByHammingDistance(this IEnumerable<ulong> @this, ulong value, int maxDistance)
      {
         return @this.Where(item => item.HammingDistance(value) <= maxDistance);
      }
   }
}
