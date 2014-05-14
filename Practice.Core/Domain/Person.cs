using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
    public abstract class Person : IObjectWithState, IValidatableObject
    {
        //private string lastName;

        public int Id { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        //public string LastName
        //{
        //  get { return lastName; }
        //  set
        //  {
        //    if (value.Length > 40)
        //    {
        //      throw new System.InvalidOperationException("LastName cannot exceed 40 characters");
        //    }
        //    else
        //    {
        //      lastName = value;
        //    }
        //  }
        //}

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [NotMapped]
        public State State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstName == EmailAddress)
            {
                yield return new ValidationResult("First Name cannot match Email Address", new[] { "FirstName", "EmailAddress" });
            }
        }
    }
}