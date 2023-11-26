﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhramovNA.Sprint5.Task3.V19.Lib;
using System.IO;

namespace Tyuiu.KhramovNA.Sprint5.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\nikol\source\repos\Tyuiu.KhramovNA.Sprint5\Tyuiu.KhramovNA.Sprint5.Task3.V19\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}