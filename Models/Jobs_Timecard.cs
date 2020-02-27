﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterRecoveryAPI.Models
{
    public class Jobs_Timecard
    {
        [Key]
        public int Id { get; set; }
        public int JobId { get; set; }
        public int TimecardId { get; set; }
        public Jobs Jobs { get; set; }
        public Timecard Timecard { get; set; }
    }
}