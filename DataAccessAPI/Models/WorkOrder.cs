using System;
using System.Collections.Generic;

namespace DataAccessAPI.Models
{
    public partial class WorkOrder
    {
        public int Wonum { get; set; }
        public string? Email { get; set; }
        public string? Status { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? DateComplete { get; set; }
        public string? ContactName { get; set; }
        public string? TechnicianComments { get; set; }
        public string? ContactNumber { get; set; }
        public int? TechnicianId { get; set; }
        public string? Problem { get; set; }

        public virtual Technician? Technician { get; set; }
    }
}
