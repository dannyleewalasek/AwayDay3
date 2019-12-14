using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AwayDay3
{
    public class Company
    {
        [Key]
        public string CompanyName { get; set; }
        public string companyEmail { get; set; }
      //  public string firstName { get; set; }
      //  public string lastName { get; set; }
      //  public string address { get; set; }
      //  public string city { get; set; }
      //  public string postCode { get; set; }
      //  public string phone { get; set; }

        public Company()
        {
        }
    }
}
