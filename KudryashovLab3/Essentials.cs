using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudryashovLab3
{
    public class Essentials
    {
        public static int[] Convert(string source)
        {
            string[] arr = source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] output = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (int.TryParse(arr[i], out int x))
                { output[i] = x; }
            }
            return output;
        }
    }
}
