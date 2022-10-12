using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public String? Email { get; set; }
        public byte[]? Password { get; set; }
    }
}
