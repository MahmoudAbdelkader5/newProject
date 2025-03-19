using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Access_layer.model
{
  

    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, 1000000, ErrorMessage = "Salary must be between 0 and 1,000,000")]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Hire date is required")]
        public DateTime HireTime { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
        [ForeignKey("Department")]

        public int ?DepartmentId { get; set; }
       // [InverseProperty("Department")]
        public Department Department { get; set; }


    }
}
