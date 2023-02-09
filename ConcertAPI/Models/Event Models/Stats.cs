namespace ConcertAPI.Models.Event_Models
{
    public class Stats
    {
        public int event_count { get; set; }
        public int? listing_count { get; set; }
        public int? average_price { get; set; }
        public int? lowest_price_good_deals { get; set; }
        public int? lowest_price { get; set; }
        public int? highest_price { get; set; }
        public int? visible_listing_count { get; set; }
        public List<int> dq_bucket_counts { get; set; }
        public int? median_price { get; set; }
        public int? lowest_sg_base_price { get; set; }
        public int? lowest_sg_base_price_good_deals { get; set; }
    }


}
