using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAlignCalculator
{

    internal class FloatNumberControl
    {
        public float FloatNext(float x)
        {
            if (float.IsNaN(x) || x == float.PositiveInfinity)
                return x;

            int bits = unchecked((int)System.BitConverter.ToUInt32(System.BitConverter.GetBytes(x), 0));

            if (bits >= 0)
                bits++;
            else
                bits--;

            byte[] bytes = BitConverter.GetBytes(bits);
            float result = 0;
            Buffer.BlockCopy(bytes, 0, new[] { result }, 0, 4);
            return BitConverter.ToSingle(bytes, 0);
        }

        public float FloatPrev(float x)
        {
            if (float.IsNaN(x) || x == float.PositiveInfinity)
                return x;

            int bits = unchecked((int)System.BitConverter.ToUInt32(System.BitConverter.GetBytes(x), 0));

            if (bits >= 0)
                bits--;
            else
                bits++;

            byte[] bytes = BitConverter.GetBytes(bits);
            float result = 0;
            Buffer.BlockCopy(bytes, 0, new[] { result }, 0, 4);
            return BitConverter.ToSingle(bytes, 0);
        }
    }
}
