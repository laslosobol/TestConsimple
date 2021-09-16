using System.Collections;
using System.Collections.Generic;

namespace TestConsimple.Data
{
    public class Root
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}