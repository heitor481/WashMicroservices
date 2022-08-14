using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WashClothes.Domain
{
    public class Clothes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Color { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ClotheType Type { get; set; }

		public int UserId { get; set; }
        public string Image { get; set; }
    }
}
