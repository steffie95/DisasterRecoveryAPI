using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterRecoveryAPI.Models
{
    public class Jobs
    {
        // Job id
        [Key]
        public int Id { get; set; }
        // Job code
        public string JobCode { get; set; }
        // Job description
        public string Description { get; set; }
        // Hourly Rate
        public int HrRate { get; set; }
        // Max Hours Per day
        public int MaxHrPerDay { get; set; }
        
        public Timecard Timecard { get; set; }
        public ICollection<Jobs_Timecard> Jobs_Timecard { get; set; }
    }
}
