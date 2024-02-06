using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolApplicationCrud.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]

        public int Student_Id { get; set; }
        public string ? Name {  get; set; }
        public double Marks {  get; set; }
    }
}
