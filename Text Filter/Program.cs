using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            var stringInput = "ayodeleadesina";

            var offset = stringInput.Length % 2 == 0 ? 1 : 0;
            var middle = stringInput.Substring(stringInput.Length / 2 - offset, offset + 1);

            var marker = true;







        }
    }
}
