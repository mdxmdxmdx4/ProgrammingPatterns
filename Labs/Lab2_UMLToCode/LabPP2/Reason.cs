using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPP2
{
    public class Reason
    {
        public string ResignReason { get; set; }
        public Reason(string res)
        {
            ResignReason = res;
        }

        public override string ToString()
        {
            return ResignReason;
        }
    }
}
