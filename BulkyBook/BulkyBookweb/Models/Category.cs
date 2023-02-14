using System.ComponentModel.DataAnnotations;

namespace BulkyBookweb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String? Name { get; set; }


        public int DisplayOrder { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
