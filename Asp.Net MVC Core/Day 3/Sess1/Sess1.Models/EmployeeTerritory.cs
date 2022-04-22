﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Sess1.Models
{
    public partial class EmployeeTerritory
    {
        public short EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
