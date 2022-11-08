using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class Client
    {

        public int Id { get; set; }
        public int FamilyLink_Id{ get; set; }
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Range(14, 99)]
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [Phone]
        public string? Cellphone { get; set; }
        public string? MemberType { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string? Client_UID { get; set; }


    }
}
