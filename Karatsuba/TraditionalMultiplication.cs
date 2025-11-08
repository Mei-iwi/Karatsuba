using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Karatsuba
{
    class TraditionalMultiplication
    {
        // Hàm nhận hai số dưới dạng string, thực thi hàm multiply, trả về kết quả và thời gian
        public static (string result, double elapsedMs) MeasureTraditionalMultiply(string num1, string num2)
        {
            Stopwatch sw = Stopwatch.StartNew();    // Bắt đầu đồng hồ
            string result = TraditionalMultiplication.TraditionalMultiply(num1, num2);
            sw.Stop();                               // Dừng đồng hồ
            double elapsedMs = sw.Elapsed.TotalMilliseconds;
            return (result, elapsedMs);
        }

        public static string TraditionalMultiply(string num1, string num2)
        {
            // Loại bỏ các số 0 đứng đầu
            num1 = num1.TrimStart('0');
            if (num1.Length == 0) num1 = "0";

            num2 = num2.TrimStart('0');
            if (num2.Length == 0) num2 = "0";

            int n1 = num1.Length;
            int n2 = num2.Length;
            int[] result = new int[n1 + n2]; // Mảng lưu kết quả từng bước

            // Nhân từng chữ số từ phải sang trái
            for (int i = n1 - 1; i >= 0; i--)
            {
                int carry = 0;
                int digit1 = num1[i] - '0';

                for (int j = n2 - 1; j >= 0; j--)
                {
                    int digit2 = num2[j] - '0';

                    // Nhân chữ số hiện tại, cộng với giá trị đã có ở vị trí + carry
                    int tempSum = digit1 * digit2 + result[i + j + 1] + carry;

                    result[i + j + 1] = tempSum % 10; // Lưu chữ số hiện tại
                    carry = tempSum / 10;             // Lưu phần nhớ
                }

                // Cộng phần carry còn lại vào vị trí trước đó
                result[i] += carry;
            }

            // Chuyển mảng kết quả thành chuỗi, bỏ số 0 đứng đầu
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < result.Length && result[index] == 0) index++;
            for (; index < result.Length; index++)
            {
                sb.Append(result[index]);
            }

            return sb.Length == 0 ? "0" : sb.ToString();
        }


    }
}

