using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkupholisaHealthcare.Library.Models
{
    public class MedicalCondition
    {
        public int Id { get; set; }

        public int FK_TreatmentId { get; set; }

        public string ConditionName { get; set; }

        public string Description { get; set; }
    }
}
