namespace TasksLibrary
{
    using System.Linq;

    public class Reverser
    {
        public static string ReverseWords(string text)
        {
            return
                string.Join(" ", text.Split(' ', '\t', '\n').Reverse());
        }
    }
}
