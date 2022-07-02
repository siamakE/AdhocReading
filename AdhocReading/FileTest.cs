using System;
using System.IO;

namespace AdhocReading
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void ChangeFileNames()
        {
            var dir = @"C:\Users\fasters\Downloads\The-Big-Bang-Theory-S01-Complete\The Big Bang Theory S01 - Complete\English\BluRay";
            DirectoryInfo d = new DirectoryInfo(dir); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.srt"); //Getting Text files
            Directory.SetCurrentDirectory(dir);
            for (int i = 0; i < Files.Length; i++)
            {
                System.IO.File.Move(Files[i].Name, (i + 1).ToString() + ".srt");
            }

        }
        
    }
}