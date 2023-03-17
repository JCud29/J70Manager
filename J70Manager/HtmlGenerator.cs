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
        private readonly List<List<string>> _parts;
        private readonly string _firstGalleryUrl = "..\\..\\J70GalleryPart1.txt";
        private readonly string _secondGalleryUrl = "..\\..\\J70GalleryPart2.txt";
        private readonly string _thirdGalleryUrl = "..\\..\\J70GalleryPart3.txt";
        private readonly FileAccess _fileClient = new FileAccess ();

        public HtmlGenerator() {
            _parts= new List<List<string>> ();
        }

        public int GenerateFile(string Title, string Description, int startRange, int endRange, string baseFileName, string Location)
        {
            List<string> file = new List<string>();
            _parts.Add(_fileClient.ReadTextFile(_firstGalleryUrl));
            _parts.Add(_fileClient.ReadTextFile(_secondGalleryUrl));
            _parts.Add(_fileClient.ReadTextFile(_thirdGalleryUrl));

            if (_parts[0].Count < 1 || _parts[1].Count < 1 || _parts[2].Count < 1)
            {
                return -1;
            }

            file.AddRange(_parts[0]);
            file.Add("<h1 class=\"text-center\">" + Title + "</h1>");
            file.Add("<p>" + Description + "</p>");
            file.AddRange(_parts[1]);

            for (int i = startRange; i <= endRange; i++)
            {
                file.Add("<div class=\"grid - item\">");
                file.Add("<img src = \"Assets/images/" + Location + "/" + baseFileName + i.ToString() + ".jpg\" alt = \"\"/>");
                file.Add("</div>");
            }

            file.AddRange(_parts[2]);

            _fileClient.CreateHtmlFile(file, Title);

            return 0;
        }

    }
}
