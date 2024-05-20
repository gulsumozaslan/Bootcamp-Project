using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User : BaseEntity<Guid>
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }

        //public virtual Instructor? Instructor { get; set; }
        //public virtual Applicant? Applicant { get; set; }
        //public virtual Employee? Employee { get; set; }
        

        public User()
        {
           
        }

        public User(Guid id,string userName, string firstName, string lastName, string nationalIdentity, string email, string password, DateTime dateOfBirth) : this()
        {
            Id = id;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            Email = email;
            Password = password;
            DateOfBirth = dateOfBirth;
        }
    }
}
