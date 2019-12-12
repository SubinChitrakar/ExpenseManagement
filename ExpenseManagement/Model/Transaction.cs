using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Model
{
    public class Transaction : BaseModel
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Note { get; set; }
    }
}
