using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Test6.Models
{
    public class Idea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }
        public string FilePath { get; set; }

        [Required]
        public string Datetime { get; set; }

        //Foreign key
        [Display(Name = "User")]
        public virtual int UserId { get; set; }

        //[ForeignKey("Id")]
        //public virtual User Users { get; set; }

        //Foreign key
        [Display(Name = "Category")]
        public virtual int CategoryId { get; set; }

        //[ForeignKey("Id")]
        //public virtual Category Categories { get; set; }

        //Foreign key
        [Display(Name = "Topic")]
        public virtual int TopicId { get; set; }

        //[ForeignKey("Id")]
        //public virtual Topic Topics { get; set; }

        public Idea() 
        { }
    }
}
