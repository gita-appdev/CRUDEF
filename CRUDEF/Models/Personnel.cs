using System;
using System.Collections.Generic;

#nullable disable

namespace CRUDEF.Models
{
    public partial class Personnel
    {
#nullable enable
        public int PersId { get; set; }
        public string? Edipi { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? Nickname { get; set; }
        public int? EmpType { get; set; }
        public int? ActiveDutySvcId { get; set; }
        public string? OfficialEmail { get; set; }
        public DateTime Dlihire { get; set; }
        public DateTime? Scdleave { get; set; }
        public DateTime? SecurityClearance { get; set; }
        public DateTime? Dlideparture { get; set; }
        public int? DepartureReason { get; set; }
        public string? Notes { get; set; }
        public Byte[]? Edipiencrypt { get; set; }
        public string? AdpayGrade { get; set; }
#nullable disable
    }
}
