using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
    [Table("Customers")]
    public class CustomerReference
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string FirstName { get; private set; }

        [StringLength(40)]
        public string LastName { get; private set; }

        public string FullName
        {
            get { return string.Concat(FirstName + " " + LastName); }
        }
        public string FullNameReverse
        {
            get { return string.Concat(LastName + ", " + FirstName); }
        }

    }
}