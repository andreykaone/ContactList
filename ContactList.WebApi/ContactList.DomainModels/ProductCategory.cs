
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList.DomainModel
{
    class ProductCategory
    {
        public long Id { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
