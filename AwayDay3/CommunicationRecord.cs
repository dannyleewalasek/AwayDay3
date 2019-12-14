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
        [Key]
        public int communcationID;
        public String companyName;
        public String departmentName;
        public String requestID;
        public enum messageType
        {
            Email,
            Post,
            Telephone
        }
        public messageType communcationType;
        public DateTime timeCreated;
        public bool disagreementFlagged;

        public CommunicationRecord()
        {

        }
    }
}
