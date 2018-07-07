using System;
using System.Collections.Generic;

namespace ContactList.DomainModels
{
    class Contact
    {

        public Contact()
        {
            Groups = new List<Group>();
        }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public string ProfilePicture { get; set; }
        public List<Group> Groups { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
