using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterRecoveryAPI.Models
{
    public class Timecard
    {
        // Timecard ID
        public int Id { get; set; }
        // Contractor name
        public string Name { get; set; }
        //Date created
        public DateTime DateCreated { get; set; }
        //TODO: create isdone
        public Boolean isConfirmed { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<Machines> Machines { get; set; }
    }
}
