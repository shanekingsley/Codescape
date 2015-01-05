using System.IO;
using System.Reflection;

namespace Codescape.Utilities.Testing
{
	public class TestServices
	{
		public static void CreateFile(string path, string manifestFilename, string overrideAssembly = null)
		{
			Assembly a;
			if (string.IsNullOrEmpty(overrideAssembly))
				a = Assembly.GetExecutingAssembly();
			else
				a = Assembly.Load(overrideAssembly);

			using (Stream s = a.GetManifestResourceStream(manifestFilename))
			{
				using (StreamReader sr = new StreamReader(s))
				{
					using (StreamWriter sw = File.CreateText(path))
					{
						sw.Write(sr.ReadToEnd());
						sw.Flush();
					}
				}
			}
		}

		public static void DeleteFile(string path)
		{
			if(File.Exists(path))
				File.Delete(path);
		}
	}
}