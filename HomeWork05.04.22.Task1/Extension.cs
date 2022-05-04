using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork05._04._22.Task1
{
   static  class Extension
    {
        public static void ContainsMethod(this string name, string value)
        {
            bool result = false;
            string Chek = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if ((i + value.Length) > name.Length)
                {
                    break;
                }
                Chek = name.Substring(i, value.Length);
                if (Chek.ToLower() == value.ToLower())
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
