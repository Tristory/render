using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Test6.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        //Foreign key
        [Display(Name = "Role")]
        public virtual int RoleId { get; set; }

        //[ForeignKey("Id")]
        //public virtual Role Roles { get; set; }

        //Foreign key
        [Display(Name = "Department")]
        public virtual int DepartmentId { get; set; }

        //[ForeignKey("Id")]
        //public virtual Department Departments { get; set; }

        public User()
        { }
    }
}
