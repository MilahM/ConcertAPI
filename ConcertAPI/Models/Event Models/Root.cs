namespace ConcertAPI.Models.Event_Models
{
    public class Root
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public List<Event> events { get; set; }
        public Meta meta { get; set; }
    }

}
