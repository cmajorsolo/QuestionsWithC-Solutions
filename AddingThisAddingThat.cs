using System;
using System.Linq;

namespace SpencerStuart
{
    public class AddingThisAddingThat
    {
		public int carry = 0;

        public byte[] AddRecursive(byte[] f, byte[] s)
        {
            byte[] result = AddRecursiveActualFunction(f, s);
			return result.Reverse().ToArray();
        }

		public byte[] AddRecursiveActualFunction(byte[] f, byte[] s)
		{
            f = f.Reverse().ToArray();
			s = s.Reverse().ToArray();
			if (f.Length == 0) return new byte[] { };
			int tempresult = f[0] + s[0] + carry;
			byte[] z = new byte[]{ (byte)(tempresult) };
			carry = tempresult / (byte.MaxValue + 1);
            return z.Concat(AddRecursiveActualFunction(f.Skip(1).Reverse().ToArray(), s.Skip(1).Reverse().ToArray())).ToArray();
		}
    }
}
