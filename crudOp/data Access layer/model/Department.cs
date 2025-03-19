using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Access_layer.model
{
    public class Department
    {
        public int id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Code field is required.")]
        public string code { get; set; } = string.Empty;

        public DateTime dateCreation { get; set; } = DateTime.UtcNow;
       // [InverseProperty("Employee")]

        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>();
    }
}
