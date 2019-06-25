namespace TasksLibrary
{
    using System.Linq;
    using System.Text;

    public class StringWorker
    {
        public static string ToTitleCase(string text, string exceptionString = "")
        {
            var excWords = exceptionString.ToLower().Split(' ');
            var textWords = text.ToLower().Split(' ');

            var sBuilder = new StringBuilder(CapitalizeWord(textWords.First()) + " ");

            for (int i = 1; i < textWords.Length; i++)
            {
                if (!excWords.Contains(textWords[i]))
                    sBuilder.Append(CapitalizeWord(textWords[i]));
                else
                    sBuilder.Append(textWords[i]);

                sBuilder.Append(" ");
            }

            sBuilder.Remove(sBuilder.Length - 1, 1);

            return sBuilder.ToString();
        }

        private static string CapitalizeWord(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1);
        }
    }
}
