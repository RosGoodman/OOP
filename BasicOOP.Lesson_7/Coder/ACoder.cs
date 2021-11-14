
namespace Coder
{
    public struct ACoder : ICoder
    {
        public string Encode(string str)
        {
            return ChangeCharsTowards(str, true);
        }

        public string Decode(string str)
        {
            return ChangeCharsTowards(str, false);
        }

        private string ChangeCharsTowards(string str, bool toTheEnd)
        {
            int coeff = toTheEnd ? 1 : -1;
            string encodeStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                encodeStr += (char)((int)str[i] + coeff);
            }
            return ReplaceExtremeChars(encodeStr);
        }

        private string ReplaceExtremeChars(string str)
        {
            if (str.Contains('{'))
            {
                str = str.Replace('{', 'a');
                return str.Replace('[', 'A');
            }

            str = str.Replace('`', 'z');
            return str.Replace('@', 'Z');
        }
    }
}
