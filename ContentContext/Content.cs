using Balta.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Base // abstract nunca deixa instanciar essa clase, apenas herdar
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }      
        public string ?Title { get; set; }
        public string ?Url { get; set; }
    }
}