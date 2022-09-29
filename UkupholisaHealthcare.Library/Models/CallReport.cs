using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class CallReport
    {
        public int Id { get; set; }
        public int FK_ClientId { get; set; }
        public DateTime CallBegin { get; set; }
        public DateTime CallEnd { get; set; }
        public bool IsSatisfied { get; set; }

    }
}
