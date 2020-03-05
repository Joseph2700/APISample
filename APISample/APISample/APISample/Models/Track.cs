using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APISample.Models
{
    [DataContract]
    public class Track
    {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "readable")]
        public bool Readable { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "title_short")]
        public string TitleShort { get; set; }

        [DataMember(Name = "title_version")]
        public string TitleVersion { get; set; }

        [DataMember(Name = "isrc")]
        public string Isrc { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "share")]
        public string Share { get; set; }

        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        [DataMember(Name = "track_position")]
        public int TrackPosition { get; set; }

        [DataMember(Name = "disk_number")]
        public int DiskNumber { get; set; }

        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        [DataMember(Name = "release_date")]
        public string ReleaseDate { get; set; }

        [DataMember(Name = "explicit_lyrics")]
        public bool ExplicitLyrics { get; set; }

        [DataMember(Name = "explicit_content_lyrics")]
        public int ExplicitContentLyrics { get; set; }

        [DataMember(Name = "explicit_content_cover")]
        public int ExplicitContentCover { get; set; }

        [DataMember(Name = "preview")]
        public string Preview { get; set; }

        [DataMember(Name = "bpm")]
        public int Bpm { get; set; }

        [DataMember(Name = "gain")]
        public double Gain { get; set; }

        [DataMember(Name = "available_countries")]
        public IList<string> AvailableCountries { get; set; }

        [DataMember(Name = "contributors")]
        public IList<Contributor> Contributors { get; set; }

        [DataMember(Name = "artist")]
        public Artist Artist { get; set; }

        [DataMember(Name = "album")]
        public Album Album { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
