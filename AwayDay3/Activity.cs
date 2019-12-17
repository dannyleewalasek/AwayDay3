using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AwayDay3
{
    class Activity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ActivityID { get; set; }
        public String activity { get; set; }
        public int requestID;
        public bool priceRequested;
        public DateTime date;
    }
}
