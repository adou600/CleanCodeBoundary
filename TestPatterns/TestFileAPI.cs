using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileAPI;

namespace TestPatterns
{
    [TestClass]
    public class TestFileAPI
    {
        [TestMethod]
        public void TestWriteToFile()
        {
            string filename = "test.txt";
            FileWriter.DeleteFile(filename);
            FileWriter fw = new FileWriter(filename);
            fw.AppendToFile("line 1");
            fw.AppendToFile("line 2");
            fw.CloseFile();

            fw = new FileWriter(filename);
            fw.AppendToFile("line 3");
            fw.AppendToFile("line 4");
            fw.CloseFile();

            string fileContent = fw.ReadAllText();
            Assert.AreEqual("line 1\r\nline 2\r\nline 3\r\nline 4\r\n", fileContent);

        }
    }
}
