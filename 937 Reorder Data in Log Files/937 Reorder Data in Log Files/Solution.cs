using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _937_Reorder_Data_in_Log_Files
{
    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var count = logs.Length;
            string[] stringArray = new string[count];

            //digit array
            List<string> digitArray = new List<string>();
            List<string> letArray = new List<string>();

            foreach (string x in logs)
            {
                if (Char.IsNumber(x[x.Length - 1]))
                    digitArray.Add(x);
                else
                    letArray.Add(x);
            }

            List<ministring> intermediary = new List<ministring>();
            foreach (string x in letArray)
            {
                var y = new ministring(x);
                intermediary.Add(y);

            }

            intermediary.Sort();

            for (var i = 0; i < letArray.Count; ++i)
            {
                letArray[i] = intermediary[i]._stringStart;
            }


            return letArray.Concat(digitArray).ToArray();
        }
    }
}
