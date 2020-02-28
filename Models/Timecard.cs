using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterRecoveryAPI.Models
{
    public class Timecard
    {
        // Timecard ID
        [Key]
        public int Id { get; set; }
        public string SiteCode { get; set; }
        // Contractor name
        public string Name { get; set; }
        //Date created
        public DateTime DateCreated { get; set; }
        public int TotalJobHrs { get; set; }
        public int TotalMachineHrs { get; set; }
        public int TotalJobAmount { get; set; }
        public int TotalMachineAmount { get; set; }
        //TODO: create isdone
        public Boolean isConfirmed { get; set; }
        public ICollection<Jobs_Timecard> Jobs_Timecards { get; set; }
        public ICollection<Machines_Timecard> Machines_Timecards { get; set; }
    }
}