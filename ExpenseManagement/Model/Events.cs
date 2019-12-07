using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Model
{
    class Event : BaseModel
    {
        public string Location { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public DateTime EventDate { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set;}
    }
}
