using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_Serilazation
{
    [Serializable]
    public class Product
    {
        public string ProductName { get; set; }
        public double Price{ get; set; }
        public string Description { get; set; }
    }
}
