using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
