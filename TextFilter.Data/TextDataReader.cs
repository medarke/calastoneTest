using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFilter.Data.Interfaces;

namespace TextFilter.Data
{
    public class TextDataReader : ITextDataReader
    {
        public string GetDataString(string path)
        {
            //todo:Change Path to config
            string data = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");




            return data;
        }

    
    }
}
