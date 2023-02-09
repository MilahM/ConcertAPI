using Newtonsoft.Json;

namespace ConcertAPI.Models.Event_Models
{
    public class Images
    {
        public string huge { get; set; }

        [JsonProperty("1200x525")]
        public string _1200x525 { get; set; }

        [JsonProperty("1200x627")]
        public string _1200x627 { get; set; }

        [JsonProperty("136x136")]
        public string _136x136 { get; set; }

        [JsonProperty("500_700")]
        public string _500_700 { get; set; }

        [JsonProperty("800x320")]
        public string _800x320 { get; set; }
        public string banner { get; set; }
        public string block { get; set; }
        public string criteo_130_160 { get; set; }
        public string criteo_170_235 { get; set; }
        public string criteo_205_100 { get; set; }
        public string criteo_400_300 { get; set; }
        public string fb_100x72 { get; set; }
        public string fb_600_315 { get; set; }
        public string ipad_event_modal { get; set; }
        public string ipad_header { get; set; }
        public string ipad_mini_explore { get; set; }
        public string mongo { get; set; }
        public string square_mid { get; set; }
        public string triggit_fb_ad { get; set; }
    }


}
