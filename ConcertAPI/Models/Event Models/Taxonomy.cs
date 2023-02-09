namespace ConcertAPI.Models.Event_Models
{
    public class Taxonomy
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? parent_id { get; set; }
        public DocumentSource document_source { get; set; }
        public int rank { get; set; }
    }


}
