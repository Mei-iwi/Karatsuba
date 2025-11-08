using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba
{
    public class KaratsubaNode
    {
        public string Expression { get; set; }  
        public string Result { get; set; }       
        public List<KaratsubaNode> Children { get; set; } = new List<KaratsubaNode>();
    }

}
