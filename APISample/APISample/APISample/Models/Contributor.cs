using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APISample.Models
{
    [DataContract]
    public class Contributor
    {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "share")]
        public string Share { get; set; }

        [DataMember(Name = "picture")]
        public string Picture { get; set; }

        [DataMember(Name = "picture_small")]
        public string PictureSmall { get; set; }

        [DataMember(Name = "picture_medium")]
        public string PictureMedium { get; set; }

        [DataMember(Name = "picture_big")]
        public string PictureBig { get; set; }

        [DataMember(Name = "picture_xl")]
        public string PictureXl { get; set; }

        [DataMember(Name = "radio")]
        public bool Radio { get; set; }

        [DataMember(Name = "tracklist")]
        public string Tracklist { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }
    }

}
