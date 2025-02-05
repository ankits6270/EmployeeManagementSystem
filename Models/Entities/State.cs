using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models.Entities
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<City> Cities { get; set; }
    }
}
