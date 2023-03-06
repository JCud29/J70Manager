using System.Collections.Generic;

namespace J70Manager
{
	internal class HtmlGenerator
	{
		private readonly List<List<string>> _parts;

		private readonly string _firstGallaryUrl = "..\\..\\J70GalleryPart1.txt";
		private readonly string _secondGallaryUrl = "..\\..\\J70GalleryPart2.txt";
		private readonly string _thirdGallaryUrl = "..\\..\\J70GalleryPart3.txt";
		private readonly FileAccess _fileClient = new FileAccess();

		public HtmlGenerator()
		{
			_parts = new List<List<string>>();
		}

		public int GenerateFile(string title, string description, int startRange, int endRange, string baseFileName, string location)
		{
			List<string> file = new List<string>();

			_parts.Add(_fileClient.ReadTextFile(_firstGallaryUrl));
			_parts.Add(_fileClient.ReadTextFile(_secondGallaryUrl));
			_parts.Add(_fileClient.ReadTextFile(_thirdGallaryUrl));

			if (_parts[0].Count < 1 || _parts[1].Count < 1 || _parts[2].Count < 1)
			{
				return -1;
			}

			file.AddRange(_parts[0]);
			file.Add("<h1 class=\"text-center\">" + title + "</h1>");
			file.Add("<p>" + description + "</p>");
			file.AddRange(_parts[1]);

			for (int i = startRange; i < endRange; i++)
			{
				file.Add("<div class=\"grid - item\">");
				file.Add("<img src = \"Assets/images/" + location + "/" + baseFileName + i.ToString() + ".jpg\" alt = \"\"/>");
				file.Add("</div>");
			}

			file.AddRange(_parts[2]);

			_fileClient.CreateHtmlFile(file, title);

			return 0;
		}
	}
}
