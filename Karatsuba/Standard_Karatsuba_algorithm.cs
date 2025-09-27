using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba
{
    internal class Standard_Karatsuba_algorithm
    {
        //Biến cục bộ
        private long x;
        private long y;
        //Kết quả
        public long Result { get; set; }

        //Phương thức khỏi tạo không tham số đầu ra là 0

        public Standard_Karatsuba_algorithm()
        {
            x = y = 0;
            Result = 0;
        }
        //Phương thức khỏi tạo có tham số đầu ra là kết quả của phép nhân
        public Standard_Karatsuba_algorithm(long a, long b)
        {
            x = a;
            y = b;
            Result = Karatsuba(x, y);
        }

        //Thuật toán Karatsuba thuần túy để nhân hai số nguyên dương (Không nhân số âm)
        private long Karatsuba(long a, long b)
        {
            //Điều kiện dừng đệ quy khi 1 trong 2 số nhỏ hơn 10
            if (a < 10 || b < 0)
                return a * b;
            //Nếu không thì thực hiện đệ quy
            else
            {
                // Nếu một trong hai số nhỏ, dùng phép nhân bình thường
                if (x < 10 || y < 10)
                    return x * y;

                // Tính số chữ số lớn nhất
                int n = Math.Max(x.ToString().Length, y.ToString().Length);
                int halfN = n / 2;

                // Chia số x và y thành 2 phần: cao và thấp
                long x1 = x / (long)Math.Pow(10, halfN);  // phần cao
                long x0 = x % (long)Math.Pow(10, halfN);  // phần thấp
                long y1 = y / (long)Math.Pow(10, halfN);  // phần cao
                long y0 = y % (long)Math.Pow(10, halfN);  // Phần thấp

                // Tính 3 phép nhân Karatsuba
                long z2 = Karatsuba(x1, y1);                // Cao 1 * Cao 2
                long z0 = Karatsuba(x0, y0);                // Thâp 1 * Thấp 2
                long z1 = Karatsuba(x1 + x0, y1 + y0) - z2 - z0; // (Cao 1 + Thấp 1) * (Cao 2 + Thấp 2) - z2 - z0

                // Ghép kết quả lại
                return z2 * (long)Math.Pow(10, 2 * halfN) + z1 * (long)Math.Pow(10, halfN) + z0;
            }
        }
    }
}
