using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market__CRM
{
    internal class Products : BaseEntity
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
