using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    internal class Policy
    {
        public int Id { get; set; }
        public int FK_FamilyLink_Id { get; set; }
        public string? PolicyName { get; set; }
        public string? Description { get; set; }
        public decimal PolicyPrice { get; set; }
        public bool? IsApproved { get; set; }
    }
}
