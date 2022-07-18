using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public class Base : Notifiable
    {
        public Base()
        {
             Id = Guid.NewGuid(); //SPOF -> Ponto único de falha 
        }
          public Guid Id { get; set; }    
    }
}