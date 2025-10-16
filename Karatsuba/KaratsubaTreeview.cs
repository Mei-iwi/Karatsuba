using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba
{
    public class KaratsubaTreeview
    {
        public KaratsubaNode Root { get; private set; }

        public long Compute(long x, long y)
        {
            Root = ComputeRecursive(x, y);
            return Root.Result;
        }

        private KaratsubaNode ComputeRecursive(long x, long y)
        {
            var node = new KaratsubaNode { Expression = $"k({x}, {y})" };

            if (x < 10 || y < 10)
            {
                node.Result = x * y;
                return node;
            }

            int maxSize = Math.Max(x.ToString().Length, y.ToString().Length);
            int halfSize = maxSize / 2;

            long a = x / (long)Math.Pow(10, halfSize);
            long b = x % (long)Math.Pow(10, halfSize);
            long c = y / (long)Math.Pow(10, halfSize);
            long d = y % (long)Math.Pow(10, halfSize);

            // Đệ quy
            var acNode = ComputeRecursive(a, c);
            var bdNode = ComputeRecursive(b, d);
            var abcdNode = ComputeRecursive(a + b, c + d);

            node.Children.Add(acNode);
            node.Children.Add(bdNode);
            node.Children.Add(abcdNode);

            long result = acNode.Result * (long)Math.Pow(10, 2 * halfSize)
                        + (abcdNode.Result - acNode.Result - bdNode.Result) * (long)Math.Pow(10, halfSize)
                        + bdNode.Result;

            node.Result = result;
            return node;
        }
    }
}
