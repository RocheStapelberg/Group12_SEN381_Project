using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class FamilyLink
    {
        public int Id { get; set; }
        public string? FamilyName { get; set; }
        public int MemberCount { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
