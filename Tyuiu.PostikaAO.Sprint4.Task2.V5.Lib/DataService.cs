﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PostikaAO.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    c += array[i];
                }
            }
            return c;
        }
    }
}
