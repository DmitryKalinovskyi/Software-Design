using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class VirusType
    {
        public string TypeName { get; set; }

        // here you can write weakness of current virus

        public VirusType(string typeName)
        {
            TypeName = typeName;
        }

    }
}
