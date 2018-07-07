using System.Collections.Generic;

namespace ContactList.DomainModels
{
    class Group
    {
        public Group()
        {
            GroupContacts = new List<Contact>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Contact> GroupContacts { get; set; }
    }
}
