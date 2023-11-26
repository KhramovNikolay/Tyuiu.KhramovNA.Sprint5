using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhramovNA.Sprint5.Task2.V16.Lib;

namespace Tyuiu.KhramovNA.Sprint5.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\nikol\source\repos\Tyuiu.KhramovNA.Sprint5\Tyuiu.KhramovNA.Sprint5.Task2.V16\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}