using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ConstantInterpolatedStrings_Framework
    {
        public const string Name = "Some";
        public const string Surname = "Beavers";

        public const string Nickname = $"{Name}{Surname}";
    }
}
