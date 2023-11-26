using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.KhramovNA.Sprint5.Task1.V23.Lib;

namespace Tyuiu.KhramovNA.Sprint5.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\nikol\source\repos\Tyuiu.KhramovNA.Sprint5\Tyuiu.KhramovNA.Sprint5.Task1.V23\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}