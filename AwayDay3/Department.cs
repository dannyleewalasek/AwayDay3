/*
 * Danny Walasek
 * Radoslaw Warowny    
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AwayDay3
{
    public class Department
    {
        [Key]
        public string DepartmentName { get;set;}
        public string companyName;
        public Department() {}
    }
}
