using System;
using System.Collections;
using System.Collections.Generic;

namespace ContactList.DomainModel
{
    class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }


    }



    
}
