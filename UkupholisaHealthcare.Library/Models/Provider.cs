using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string? ProviderName { get; set; }
        public string? ProviderAddress { get; set; }
        public string? ProviderContact { get; set; }
    }
}
