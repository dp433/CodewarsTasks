using System.Text;


namespace SplitInParts
{
    public class Kata
    {
        public static string SplitInParts(string s, int partLength)
        {
            var splitedStr = new StringBuilder();
            var counter = 0;

            for (var i = 0; i < s.Length; i++)
            {
                splitedStr.Append(s[i]);
                counter++;
                if (counter == partLength)
                {
                    splitedStr.Append(" ");
                    counter = 0;
                }
            }

            return splitedStr.ToString().Trim();
        }

        public static string SplitInParts1(string s, int partLength)
        {
            for (int i = partLength; i < s.Length; i += partLength + 1)
                s = s.Insert(i, " ");
            return s;
        }
    }
}
