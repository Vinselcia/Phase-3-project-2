using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolApplicationCrud.Models
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        public int Sub_Id { get; set; }
        public string ? Sub_Name {  get; set; }
    }
}
