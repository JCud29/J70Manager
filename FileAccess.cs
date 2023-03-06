using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace J70Manager
{
	internal class FileAccess
	{
		public FileAccess() { }

		public List<string> ReadTextFile(string filePath)
		{
			try
			{
				return File.ReadAllLines(filePath).ToList();
			}
			catch
			{
				return new List<string>();
			}
		}

		public void CreateHtmlFile(List<string> file, string title)
		{
			using (FileStream fs = new FileStream("..\\..\\" + title + ".html", FileMode.Create))
			{
				using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
				{
					foreach (string line in file)
					{
						writer.WriteLine(line);
					}
				}
			}
		}
	}
}
