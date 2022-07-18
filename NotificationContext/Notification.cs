namespace Balta.NotificationContext
{
    public sealed class Notification //clase não pode ser extendida, ou seja. Não posso criar variações dela.
    {
        public Notification()
        {
            
        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
        
        
    }
}