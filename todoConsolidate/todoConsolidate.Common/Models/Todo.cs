using System;
using System.Collections.Generic;
using System.Text;

namespace todoConsolidate.Common.Models
{
    public class Todo
    {
        public DateTime Timestamp { get; set; }

        public int EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public int Type { get; set; }

        public bool IsConsolidated { get; set; }
    }
}
