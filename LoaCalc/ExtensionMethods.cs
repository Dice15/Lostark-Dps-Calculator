﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoaCalc
{
    public static class ExtensionMethods
    {
        public static string ToStr(this Enum skill)
        {
            string res = skill.ToString();

            res = res.Replace("__", "");
            res = res.Replace("_", " ");

            return res;
        }
    }
}