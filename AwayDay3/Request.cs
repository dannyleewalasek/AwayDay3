using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AwayDay3
{
    class Request
    {
        [Key]
        public String RequestID { get; set; }
        public String companyName;
        public String departmentName;
        public DateTime Date;
        public List<Activity> activitys;
    }
}
