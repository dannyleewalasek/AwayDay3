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
    class Request
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RequestID { get; set; }
        public int numberOfGuests;
        public string departmentName;
        public DateTime Date;
    }
}
