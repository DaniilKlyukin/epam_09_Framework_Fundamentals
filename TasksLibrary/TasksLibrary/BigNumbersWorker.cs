namespace TasksLibrary
{
    using System;
    using System.Text;

    public class BigNumbersWorker
    {
        public static string Sum(string num1, string num2)
        {
            var uNum1Length = num1.Length;
            var uNum2Length = num2.Length;

            var maxLength = Math.Max(uNum1Length, uNum2Length);

            var sBuilder = new StringBuilder();

            var nextDigit = 0;
            for (int i = 0; i < maxLength; i++)
            {
                var currentDigit = nextDigit;
                nextDigit = 0;
                if (i < uNum1Length)
                {
                    currentDigit += (num1[uNum1Length - i - 1] - '0');
                }

                if (i < uNum2Length)
                {
                    currentDigit += (num2[uNum2Length - i - 1] - '0');
                }

                if (currentDigit > 9)
                {
                    nextDigit = currentDigit / 10;
                    currentDigit -= nextDigit * 10;
                }

                sBuilder.Append(currentDigit);
            }

            if (nextDigit != 0)
                sBuilder.Append(nextDigit);

            var reversedBuilder = new StringBuilder();
            for (int i = sBuilder.Length - 1; i >= 0; i--)
            {
                reversedBuilder.Append(sBuilder[i]);
            }


            return reversedBuilder.ToString();
        }
    }
}
