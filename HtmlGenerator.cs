using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace J70Manager
{
    internal class HtmlGenerator
    {

        private string UrlPart1;
        private string UrlPart2;
        private string UrlPart3;
        private FileAccess FileClient = new FileAccess ();

        public HtmlGenerator() {
            UrlPart1 = "..\\..\\J70GalleryPart1.txt";
            UrlPart2 = "..\\..\\J70GalleryPart2.txt";
            UrlPart3 = "..\\..\\J70GalleryPart3.txt";
        }

        public int GenerateFile()
        {
            List<string> HtmlPart1 = FileClient.ReadTextFile(UrlPart1);
            List<string> HtmlPart2 = FileClient.ReadTextFile(UrlPart2);
            List<string> HtmlPart3 = FileClient.ReadTextFile(UrlPart3);

            if(HtmlPart1.Count < 1 || HtmlPart2.Count < 1 || HtmlPart3.Count < 1)
            {
                return -1;
            }

            return 0;
        }

    }
}
