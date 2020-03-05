using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APISample.Models
{
    [DataContract]
    public class Album
    {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "cover")]
        public string Cover { get; set; }

        [DataMember(Name = "cover_small")]
        public string CoverSmall { get; set; }

        [DataMember(Name = "cover_medium")]
        public string CoverMedium { get; set; }

        [DataMember(Name = "cover_big")]
        public string CoverBig { get; set; }

        [DataMember(Name = "cover_xl")]
        public string CoverXl { get; set; }

        [DataMember(Name = "release_date")]
        public string ReleaseDate { get; set; }

        [DataMember(Name = "tracklist")]
        public string Tracklist { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }

}
