using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba
{
    public class Karatsuba_Algrorithm
    {
        //Biến cục bộ
        private long x;
        private long y;
        public long Result { get; set; }
        //Phương thức khỏi tạo không tham sốq
        public Karatsuba_Algrorithm()
        {
            x = 0;
            y = 0;
            Result = 0;
        }
        //Phương thức khỏi tạo có tham số
        public Karatsuba_Algrorithm(long x, long y)
        {
            this.x = x;
            this.y = y;
            Result = KaratsubaMultiply(x, y);
        }
        //Phương thức thiết lập và truy xuất giá trị x
        public long _x
        {
            get
            {
                return x;
            }
            set { x = value; }

        }
        //Phương thức thiết lập và truy xuất giá trị y
        public long _y
        {
            get
            {
                return y;
            }
            set { y = value; }
        }
       

        public static long KaratsubaMultiply(long x, long y)
        {
            //Kiểm tra dấu của kết quả
            int s = (x > 0 ? 1 : -1) * (y > 0 ? 1 : -1);

            x = Math.Abs(x);
            y = Math.Abs(y);

            //Điều kiện dừng đệ quy
            if (x < 10 || y < 10)
                return x * y * s;

            // Tính toán kích thước của số lớn nhất
            int maxSize = Math.Max(x.ToString().Length, y.ToString().Length);
            int halfSize = maxSize / 2;

            //Chia số thành hai nữa ở giữa
            long a = x / (long)Math.Pow(10, halfSize);
            long b = x % (long)Math.Pow(10, halfSize);
            long c = y / (long)Math.Pow(10, halfSize);
            long d = y % (long)Math.Pow(10, halfSize);

            // Gọi 3 lần đệ quy để tính toán các tích nhỏ hơn
            long ac = KaratsubaMultiply(a, c);
            long bd = KaratsubaMultiply(b, d);
            long ab_cd = KaratsubaMultiply(a + b, c + d);

            // Trả về kết quả theo công thức
            return s * ac * (long)Math.Pow(10, 2 * halfSize) + (ab_cd - ac - bd) * (long)Math.Pow(10, halfSize) + bd;
        }
    }
}
