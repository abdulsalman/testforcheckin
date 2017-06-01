using Newtonsoft.Json;

namespace ArabWaha.Models
{
    public class Announcement
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }


		//The below are to be Remove

		public string Ttle { get; set; }

    }
}
