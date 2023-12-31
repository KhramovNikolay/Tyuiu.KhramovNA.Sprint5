﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhramovNA.Sprint5.Task0.V4.Lib
{
    public class DataService : ISprint5Task0V4
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = 2 * Math.Pow(x, 3) + 0.5 * Math.Pow(x, 2) - 3.5 * x + 2;
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}