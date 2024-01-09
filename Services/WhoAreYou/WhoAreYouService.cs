namespace MiniChallenge2to4.Services.WhoAreYou
{
    public class WhoAreYouService : IWhoAreYouService
    {
        public string WhoAreYou(string name, string time)
        {
        
        return $"hi {name}, you woke up at {time}";
            
        }
    }
}