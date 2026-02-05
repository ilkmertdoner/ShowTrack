using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ShowTrack.Entity
{
    public class MovieDescription
    {
        [JsonPropertyName("#TITLE")]
        public string title { get; set; }

        [JsonPropertyName("#YEAR")]
        public int year { get; set; }

        [JsonPropertyName("#IMDB_ID")]
        public string imdb_id { get; set; }

        [JsonPropertyName("#IMG_POSTER")]
        public string img_url { get; set; }

        [JsonPropertyName("#TYPE")]
        public string type { get; set; }

        [JsonPropertyName("#RANK")]
        public int rank { get; set; }

        [JsonPropertyName("#ACTORS")]
        public string actors { get; set; }

        [JsonPropertyName("#AKA")]
        public string aka { get; set; }

        [JsonPropertyName("#IMDB_URL")]
        public string imdb_url { get; set; }
    }
}
