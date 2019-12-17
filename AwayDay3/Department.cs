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
        public String DepartmentName { get;set;}
        public String companyName;
        public Department()
        {

        }
    }
}
