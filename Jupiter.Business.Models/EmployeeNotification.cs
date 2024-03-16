using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmployeeNotification
    {
        public int EmergencyId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpCode { get; set; }
        public string LocationDetails { get; set; }
        public int ResponseCodeId { get; set; }  // enum
        public DateTime ETA { get; set; }
        public string ResponseNote { get; set; }
        public bool isEmergencyActivated { get; set; }  // return always true if emergency insert or edit
    }
}
