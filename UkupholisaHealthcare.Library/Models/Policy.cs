using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class Policy
    {
        public string? Id { get; set; }
        public string? PolicyName { get; set; }
        public string? Description { get; set; }
        public decimal PolicyMonthlyPrice { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
        public string? Policy_UID { get; set; }

    }
}
