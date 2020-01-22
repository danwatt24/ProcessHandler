using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessController
{
    public class Process
    {
        public Target Foreground { get; set; }
        public Target WindowRect { get; set; }
        public Target Screenshot { get; set; }
        public Target Keyboard { get; set; }
        public Target Mouse { get; set; }
    }

    public class Target
    {
        public bool IsClass { get; set; }
        public string Name { get; set; }
        public Target Child { get; set; }
    }
}
