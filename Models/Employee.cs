using System;
using System.Collections.Generic;

#nullable disable

namespace Employee.Models
{
    public partial class Employee
    {
        public int? StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
