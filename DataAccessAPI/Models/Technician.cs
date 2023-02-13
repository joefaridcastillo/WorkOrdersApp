using System;
using System.Collections.Generic;

namespace DataAccessAPI.Models
{
    public partial class Technician
    {
        public Technician()
        {
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int TechnicianId { get; set; }
        public string TechnicianName { get; set; } = null!;
        public string TechnicianEmail { get; set; } = null!;

        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
