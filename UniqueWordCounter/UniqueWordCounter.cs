using System;
using System.Linq;

 namespace UniqueWordCounter
{
    public class UniqueCounter
    {
        public static string countUnique(string input)
        {
            string output = "";
            if (String.IsNullOrWhiteSpace(input))
            {
                return "";//clean up
            }
            string[] list = input.Trim().Split(' ');

            var groupedList = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() })
                        .OrderBy(x => x.Value);//trying to order the the words alphabetically
            foreach (var x in groupedList)
            {
                output += "Word: " + x.Value + " Count: " + x.Count + "\r\n";
            }
            output += "Total Unique Count: " + list.Distinct().Count();
            return output;

        }
    }
}

