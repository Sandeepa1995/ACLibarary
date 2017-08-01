using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACLibarary.Classes
{
    class Book
    {
        [JsonProperty(PropertyName = "title")]
        public string title;
        [JsonProperty(PropertyName = "author")]
        public string author;
        [JsonProperty(PropertyName = "refCode")]
        public string refCode;
        [JsonProperty(PropertyName = "type")]
        public string type;
        [JsonProperty(PropertyName = "holder")]
        public string holder;        
    }
}
