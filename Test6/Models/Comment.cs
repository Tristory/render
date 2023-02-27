using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Test6.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Datetime { get; set; }
        
        //Foreign key
        [Display(Name = "User")]
        public virtual int UserId { get; set; }

        //[ForeignKey("Id")]
        //public virtual User Users { get; set; }
        
        //Foreign key
        [Display(Name = "Idea")]
        public virtual int IdeaId { get; set; }

        //[ForeignKey("Id")]
        //public virtual Idea Ideas { get; set; }

        public Comment() { }
    }
}
