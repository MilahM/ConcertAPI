namespace ConcertAPI.Models.Event_Models
{
    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public bool primary { get; set; }
        public Images images { get; set; }
        public string image { get; set; }
        public DocumentSource document_source { get; set; }
    }


}
