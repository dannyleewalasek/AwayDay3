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
    class CommunicationRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int communicationID { get; set; }
        public string companyName { get; set; }
        public string departmentName { get; set; }
        public int requestID { get; set; }
        public enum messageType
        {
            Email,
            Post,
            Telephone
        }
        public messageType communcationType { get; set; }
        public DateTime timeCreated { get; set; }
        public bool disagreementFlagged { get; set; }
        public string messageText { get; set; }

        public CommunicationRecord()
        {

        }
    }
}
