using System.IO;
using Codescape.Utilities.Testing;
using NUnit.Framework;

namespace Codescape.Tests.Utilities
{
	[TestFixture]
	public class TTestServices
	{
		private string filePath = Path.Combine(Path.GetTempPath(), "testingFile.txt");

		[SetUp()]
		public void UnpackFiles()
		{
			TestServices.CreateFile(filePath, "Codescape.Tests.Files.testfile.txt", "Codescape.Tests");
		}

		[TearDown()]
		public void TidyUp()
		{
			TestServices.DeleteFile(filePath);
		}

		[Test]
		public void TestFileWriting()
		{
			Assert.True(File.Exists(filePath));
		}
	}
}
