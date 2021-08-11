using System;

namespace MixedDeconstruction
{
    public class CodeStyle
    {
        private void CodeStyle1()
        {
            int y;
            int x;
            int z;
            (x, y, z) = (1, 2, 3);

            var s = 1;
        }

        public int z { get; set; }
    }
}