using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezCPU
{
    class IsNull
    {
        public string isNull(object o)
        {
            if(o != null)
            {
                return o.ToString();
            }
            else
            {
                return "N/A";
            }
        }
    }
}
