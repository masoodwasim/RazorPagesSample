using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.Models
{
    public class BookViewModel
    {
        
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("author")]
            public string Author { get; set; }

            [JsonProperty("publishingCompany")]
            [DisplayName("Publisher")]
            public string PublishingCompany { get; set; }

            [JsonProperty("category")]
            public string Category { get; set; }

            [JsonProperty("price")]
            public double Price { get; set; }
        
    }
}
