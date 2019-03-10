using ContactList.DomainModel;
using System.Collections.Generic;

namespace ContactList.DomainModel
{
    class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public List<ProductCategory> Categories { get; set; }
    }
}
