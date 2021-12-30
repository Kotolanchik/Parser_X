namespace Parser_X.Core.ibook
{
    internal class ibookSettings : IParserSettings
    {
        public ibookSettings(int start, int end)
        {
            startPoint = start;
            endPoint = end;
        }
        public string baseURL { get; set; } = "https://iknigi.net/otzivi-na-knigi";
        public string prefix { get; set; } = "/page/{currentID}/";
        public int startPoint { get; set; }
        public int endPoint { get; set; }
    }
}
