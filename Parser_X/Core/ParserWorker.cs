using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_X.Core
{
    internal class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;


        public bool isActive
        {
            get;

            set;

        }
        #region Properies 
        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }
        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value); //новый экземпляр с новыми настройками парсера
            }
        }
        #endregion

        public event Action<object, T> onNewData;
        public event Action<object> OnCompleted;
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }
        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)// вместо дублирования кода  this.parser = parser;  
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }
        public void Abort()
        {
            isActive = false;

        }
        private async void Worker()// контролирует процесс работы парсера
        {
            for (int i = parserSettings.startPoint; i <= parserSettings.endPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document);

                onNewData.Invoke(this, result);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }


    }
}
