using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public virtual int EmployeeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Gender { get; set; }
        public virtual string City { get; set; }
        public virtual int DepartmentId { get; set; }
    }
}