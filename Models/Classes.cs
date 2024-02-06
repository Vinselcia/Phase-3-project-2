using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolApplicationCrud.Models
{
    [Table("Classes")]
    public class Classes
    {
        [Key]
        public string ? Class_Name {  get; set; }
        public string ? Class_Section {  get; set; }
    }
}
