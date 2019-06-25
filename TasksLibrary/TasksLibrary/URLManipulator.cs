namespace TasksLibrary
{
    using System.Linq;

    public class URLManipulator
    {
        public static string AddOrChangeUrlParameter(string url, string keyValueParameter)
        {
            var domen = "";
            var urlParams = "";

            var domenAndParams = url.Split('?');
            if (domenAndParams.Length == 2)
            {
                domen = domenAndParams[0];
                urlParams = domenAndParams[1];
            }
            else if (domenAndParams.Length == 1)
            {
                domen = domenAndParams[0];
            }

            var key = keyValueParameter.Split('=').First();

            if (!urlParams.Contains(key))
            {
                var separator = urlParams == "" ? '?' : '&';

                return $"{url}{separator}{keyValueParameter}";
            }
            else
            {
                var parameters = urlParams.Split('&');

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].Split('=')[0] == key)
                    {
                        parameters[i] = keyValueParameter;
                    }
                }

                return $"{domen}?{string.Join("&", parameters)}";
            }
        }
    }
}
