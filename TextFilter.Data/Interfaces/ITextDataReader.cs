using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter.Data.Interfaces
{
    interface ITextDataReader
    {
        string GetDataString(string path);
    }
}
