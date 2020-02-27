using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterRecoveryAPI.Models
{
    public class Machines
    {
        // Machine id
        [Key]
        public int Id { get; set; }
        // Machine code
        public string MachineCode { get; set; }
        // Machine description
        public string Description { get; set; }
        // Hourly Rent
        public int HrRent { get; set; }
        // Max Hours Per day
        public int MaxHrPerDay { get; set; }
        //public Timecard Timecard { get; set; }
        public ICollection<Machines_Timecard> Machines_Timecards { get; set; }
    }
}
