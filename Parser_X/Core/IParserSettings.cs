using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_X.Core
{
    internal interface IParserSettings
    {
        String baseURL { get; set; }

        String prefix { get; set; }

        int  startPoint { get; set; }// с какой страницы парсить

        int endPoint { get; set; } // конечная страница парсинга
    }
}
