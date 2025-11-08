using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba
{
    public class KaratsubaTreeview
    {
        public KaratsubaNode Root { get; private set; }

        // Hàm tính toán chính
        public string Compute(string x, string y)
        {
            Root = ComputeRecursive(x, y);
            return Root.Result;
        }

        private KaratsubaNode ComputeRecursive(string x, string y)
        {
            x = x.TrimStart('0'); if (x.Length == 0) x = "0";
            y = y.TrimStart('0'); if (y.Length == 0) y = "0";

            var node = new KaratsubaNode { Expression = $"k({x}, {y})" };

            // Ngưỡng dừng: nếu một trong hai số nhỏ, nhân trực tiếp
            if (x.Length == 1 || y.Length == 1)
            {
                node.Result = (long.Parse(x) * long.Parse(y)).ToString();
                return node;
            }

            int n = Math.Max(x.Length, y.Length);
            int half = n / 2;

            string a = x.Length > half ? x.Substring(0, x.Length - half) : "0";
            string b = x.Substring(Math.Max(0, x.Length - half));
            string c = y.Length > half ? y.Substring(0, y.Length - half) : "0";
            string d = y.Substring(Math.Max(0, y.Length - half));

            // Đệ quy cho các nhánh con
            var acNode = ComputeRecursive(a, c);
            var bdNode = ComputeRecursive(b, d);
            var abcdNode = ComputeRecursive(AddStrings(a, b), AddStrings(c, d));

            node.Children.Add(acNode);
            node.Children.Add(bdNode);
            node.Children.Add(abcdNode);

            // Tính ad + bc
            string adbc = SubtractStrings(SubtractStrings(abcdNode.Result, acNode.Result), bdNode.Result);

            // Kết hợp kết quả
            string result = AddStrings(
                PadZeros(acNode.Result, 2 * half),
                PadZeros(adbc, half),
                bdNode.Result
            );

            node.Result = result;
            return node;
        }

        // -------------------- Hỗ trợ --------------------
        private static string PadZeros(string num, int zeros) => num == "0" ? "0" : num + new string('0', zeros);

        private static string AddStrings(params string[] numbers)
        {
            int maxLen = numbers.Max(n => n.Length);
            int[] result = new int[maxLen + 10];

            foreach (var num in numbers)
            {
                int carry = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    int n = num[num.Length - 1 - i] - '0';
                    result[i] += n + carry;
                    carry = result[i] / 10;
                    result[i] %= 10;
                }

                int idx = num.Length;
                while (carry > 0)
                {
                    result[idx] += carry;
                    carry = result[idx] / 10;
                    result[idx] %= 10;
                    idx++;
                }
            }

            var sb = new StringBuilder();
            int k = result.Length - 1;
            while (k > 0 && result[k] == 0) k--;
            for (; k >= 0; k--) sb.Append(result[k]);
            return sb.ToString();
        }

        public static string KaratsubaMultiply(string x, string y)
        {
            // Loại bỏ số 0 đầu
            x = x.TrimStart('0'); if (x.Length == 0) x = "0";
            y = y.TrimStart('0'); if (y.Length == 0) y = "0";

            // Ngưỡng dừng: nếu nhỏ, dùng truyền thống
            if (x.Length < 100 || y.Length < 100)
                return TraditionalMultiply(x, y);

            int n = Math.Max(x.Length, y.Length);
            int half = n / 2;

            string a = x.Length > half ? x.Substring(0, x.Length - half) : "0";
            string b = x.Substring(Math.Max(0, x.Length - half));
            string c = y.Length > half ? y.Substring(0, y.Length - half) : "0";
            string d = y.Substring(Math.Max(0, y.Length - half));

            string ac = KaratsubaMultiply(a, c);
            string bd = KaratsubaMultiply(b, d);
            string abcd = KaratsubaMultiply(AddStrings(a, b), AddStrings(c, d));

            string adbc = SubtractStrings(SubtractStrings(abcd, ac), bd);

            // Kết hợp kết quả bằng mảng
            return AddStrings(PadZeros(ac, 2 * half), PadZeros(adbc, half), bd);
        }

       
        // Trừ num1 - num2 (num1 >= num2)
        private static string SubtractStrings(string num1, string num2)
        {
            int n1 = num1.Length, n2 = num2.Length;
            int[] result = new int[n1];
            int borrow = 0;
            for (int i = 0; i < n1; i++)
            {
                int d1 = num1[n1 - 1 - i] - '0';
                int d2 = i < n2 ? num2[n2 - 1 - i] - '0' : 0;
                int diff = d1 - d2 - borrow;
                if (diff < 0) { diff += 10; borrow = 1; } else borrow = 0;
                result[i] = diff;
            }

            StringBuilder sb = new StringBuilder();
            int k = n1 - 1;
            while (k > 0 && result[k] == 0) k--;
            for (; k >= 0; k--) sb.Append(result[k]);
            return sb.ToString();
        }

        // Nhân truyền thống cho ngưỡng nhỏ
        private static string TraditionalMultiply(string num1, string num2)
        {
            int n1 = num1.Length;
            int n2 = num2.Length;
            int[] result = new int[n1 + n2];

            for (int i = n1 - 1; i >= 0; i--)
            {
                int carry = 0;
                int n1Digit = num1[i] - '0';
                for (int j = n2 - 1; j >= 0; j--)
                {
                    int n2Digit = num2[j] - '0';
                    int sum = n1Digit * n2Digit + result[i + j + 1] + carry;
                    carry = sum / 10;
                    result[i + j + 1] = sum % 10;
                }
                result[i] += carry;
            }

            StringBuilder sb = new StringBuilder();
            int k = 0;
            while (k < result.Length && result[k] == 0) k++;
            for (; k < result.Length; k++) sb.Append(result[k]);
            return sb.Length == 0 ? "0" : sb.ToString();
        }

    }
}
