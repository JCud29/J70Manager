using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J70Manager
{
    internal class FileAccess
    {
        public FileAccess() { }

        public List<string> ReadTextFile(string URL) {
            try
            {
                return File.ReadAllLines(URL).ToList<string>();
            }
            catch (Exception e)
            {
                return new List<string>();
            }
        }
    }
}
