﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mopsik_www.Models
{
    public class Facility
    {
        public string PolishName { get; set; }
        public string IconName { get; set; }

        public Facility(string polishName, string iconName)
        {
            PolishName = polishName;
            IconName = iconName;
        }

    }
}
