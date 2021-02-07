﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePowerTools.Handlers.Compare
{
    public class CompareLogModel
    {
        public List<CompareLogModel> SubLogs { get; set; }
        public CompareType Type { get; set; }
        public CompareState State { get; set; }
        public string Name { get; set; }
        public CompareAttributes Attribute { get; set; }
        public string Expected { get; set; }
        public string Found { get; set; }
    }

}
