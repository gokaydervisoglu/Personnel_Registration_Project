using System.IO;

namespace PersonelKayitProjesi.Extensions
{
    public static class StreamReaderExtensions
    {
        public static string ReadStringUntil(this StreamReader sr, char delimiter)
        {
            string result = "";
            int nextChar;

            while ((nextChar = sr.Read()) != -1 && nextChar != delimiter)
            {
                result += (char)nextChar;
            }

            return result;
        }
    }
}
