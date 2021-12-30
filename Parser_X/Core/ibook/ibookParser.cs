using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_X.Core.ibook
{
    internal class ibookParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            // document.QuerySelectorAll можем получить все теги определенного типа с помощью linq методов, проверяем существует ли свойство класс и содержит ли такой-то класс

            var list = new List<string>();
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("comment-text"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);

            }

            return list.ToArray();// преобразуем в массив и возвращаем
        }
    }
}
