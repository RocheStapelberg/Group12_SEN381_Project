using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class Package
    {
        public int Id { get; set; }
        public int FK_PolicyId { get; set; }
        public string? PackageName { get; set; }
        public string? PackageDescription { get; set; }
        public decimal PackageCost { get; set; }
        public bool IsActive  { get; set; }




    }
}
