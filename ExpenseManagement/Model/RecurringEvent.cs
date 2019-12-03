using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Model
{
    class RecurringEvent : Event
    {
        public string Status { get; set; }
        public DateTime EventEndDate { get; set; }
    }
}
