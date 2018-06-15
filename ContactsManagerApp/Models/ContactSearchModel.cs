namespace ContactsManagerApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ContactSearchModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public virtual int NumberOfComputers { get; set; }

        public List<Contact> Results { get; set; }
    }
}