using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace Parser_X.Core
{
    internal class HtmlLoader // в значение этого класса загружать исходный код страницы из указаных настроек парсера
    {
        readonly HttpClient client;
        readonly string URL;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            URL = $"{settings.baseURL}{settings.prefix}";            
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentURL = URL.Replace("/page/{currentID}/", "");
            if (id != 1)
            {
                 currentURL = URL.Replace("{currentID}", id.ToString());
            }
            
                var response = await client.GetAsync(currentURL);    //принимать результат гет асинк  по указанной ссылке
                string source = null;

                if (response != null && response.StatusCode == HttpStatusCode.OK)
                {
                    source = await response.Content.ReadAsStringAsync();
                }
                return source;
            
        }
    }
}
