using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhramovNA.Sprint5.Task4.V26.Lib;

namespace Tyuiu.KhramovNA.Sprint5.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V26.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
