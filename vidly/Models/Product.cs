using System.Text.Json;
using System.Text.Json.Serialization;

namespace vidly.Models
{
    public class Product
    {
        public int id { get; set; }
        public String name { get; set; }
        public double price { get; set; }
        
        public String description { get; set; }


        [JsonPropertyName("image")]
        public String image { get; set; }

        public override string ToString()=>JsonSerializer.Serialize<Product>(this);
        
    }
}
