using System.Net.Mime;
using System.Text.RegularExpressions;

namespace ACT25IdentifierMethods
{
    public static class Identifier
    {
        public static string Clean(string content)
        {
            content = content.Replace("_", " ");
            content = content.Replace("\0", "CTRL");
            
            content = ReplaceKebabCase(content);
            content = Regex.Replace(content,"[]","");
            return content;
        }
        private static string ReplaceKebabCase(string content)
        {
            try
            {
                while (content.IndexOf("-") != -1)
                {
                    string replaceString = "-" + content[content.IndexOf("-") + 1];
                    string newString = new string(new char[] { content.ToUpper()[content.IndexOf("-") + 1] });
                    content = content.Replace(replaceString, newString);
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
            return content;
        }
        private static string ClearNonChars(string content)
        {
            const char space = ' ';
            const char Limita = 'a';
            const char Limitz = 'z';

            const char LimitA = 'A';
            const char LimitZ = 'Z';

            const char Limitø = 'ø';
            const char Limitž = 'ž';

            const char LimitÀ = 'À';
            const char Limitö = 'ö';

            const char Limitα = 'α';
            const char Limitω = 'ω';

            char[] contentChars = content.ToCharArray();
            List<char> chars = new List<char>();

            for(int i = 0; i < contentChars.Length; i++)
            {
                if ((InRange(space, space, contentChars[i]) || InRange(LimitA, LimitZ, contentChars[i]) || InRange(Limita, Limitz, contentChars[i]) || InRange(Limitø,Limitž, contentChars[i]) || InRange(LimitÀ, Limitö, contentChars[i])) && !InRange(Limitα, Limitω, contentChars[i]))
                {
                    chars.Add(contentChars[i]);
                }
            }
            return new string(chars.ToArray());
        }
        private static bool InRange(char minRange, char maxRange, char compareValue)
        {
            int utfMinRange = Convert.ToInt32(minRange);
            int utfMaxRange = Convert.ToInt32(maxRange);
            int utfCompareValue = Convert.ToInt32(compareValue);

            return InRange(utfMinRange,utfMaxRange, utfCompareValue);
        }
        private static bool InRange(int minRange, int maxRange, int compareValue)
        {
            return compareValue>=minRange && compareValue<=maxRange;
        }

    }
}
