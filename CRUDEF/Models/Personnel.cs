using System;
using System.Collections.Generic;

#nullable disable

namespace CRUDEF.Models
{
    public partial class Personnel
    {
        public int PersonnelId { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string Nickname { get; set; }
        public string EmpType { get; set; }
        public string ARank { get; set; }
        public string ABranch { get; set; }
        public bool? Active { get; set; }
        public string Email { get; set; }
        public DateTime? DliHire { get; set; }
        public string OfficePhone { get; set; }
        public int? Location1 { get; set; }
        public int? Location2 { get; set; }
        public int? AltOfficeSymbol { get; set; }
    }
}
