using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPROJECT
{

    class Brand
    {
        public string Name { get; set; }

        public string Description;

        public Brand (string name)
        {
            Name = name;
        }

        public Brand()
        {
        }

        public override string ToString()
        {
            return $"{Name} ";
        }
    }
}
