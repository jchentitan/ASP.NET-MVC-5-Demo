using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public virtual int DepartmentId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}