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
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(URL).ToList<string>();

            return new List<string>();
        }
    }
}
