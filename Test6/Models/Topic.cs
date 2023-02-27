using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test6.Models
{
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CloseDate_1 { get; set; }

        [Required]
        public string CloseDate_2 { get; set;}

        public Topic()
        { }
    }
}
