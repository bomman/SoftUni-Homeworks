using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericListT
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    class VersionAttribute : Attribute
    {
        private int minor;
        private int major;

        public VersionAttribute(int major, int minor)
        {
            this.minor = minor;
            this.major = major;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.major, this.minor);
        }
    }
}
