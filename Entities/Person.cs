using System;

namespace Sca.Api.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string ADT { get; set; }

        public string AMKA { get; set; }

        public string AFM { get; set; }

        public int? Sex { get; set; }

        public DateTime? BirthDate { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string StreetNumber { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public byte[] Photo { get; set; }
    }
}