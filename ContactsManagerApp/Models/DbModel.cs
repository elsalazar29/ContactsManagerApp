namespace ContactsManagerApp.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class DbModel : DbContext
    {
        // Your context has been configured to use a 'DbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ContactsManagerApp.Models.DbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbModel' 
        // connection string in the application configuration file.
        public DbModel()
            : base("name=DbModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Contact> Contacts { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }
    }

    public class Contact
    {
        [Key]
        public virtual int ContactID { get; set; }

        [Required, MaxLength(50)]
        public virtual string FirstName { get; set; }

        [Required, MaxLength(50)]
        public virtual string LastName { get; set; }

        [Required, MaxLength(50)]
        public virtual string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime Birthdate { get; set; }

        [Required]
        public virtual int NumberOfComputers { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }
    }

    public class Address
    {
        [Key]
        public virtual int AddressID { get; set; }

        [Required, MaxLength(50)]
        public virtual string AddressLine1 { get; set; }

        [MaxLength(50)]
        public virtual string AddressLine2 { get; set; }

        [Required, MaxLength(50)]
        public virtual string City { get; set; }

        [Required, MaxLength(3)]
        public virtual string StateCode { get; set; }

        [Required, MaxLength(10)]
        public virtual string Zip { get; set; }
    }
}